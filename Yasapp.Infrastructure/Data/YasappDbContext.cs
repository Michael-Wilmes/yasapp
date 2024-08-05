using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Yasapp.Domain.Entities;
using Yasapp.Domain.Entities.Masterdata;
using Yasapp.Domain.Entities.StudyPlanning;

namespace Yasapp.Infrastructure.Data
{
    public class YasappDbContext : DbContext
    {
        IConfiguration _config;

        public YasappDbContext()
        {
        }

        public YasappDbContext(IConfiguration config)
        {
            _config = config;
        }

        public YasappDbContext(DbContextOptions<YasappDbContext> options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //todo: get this from a central source !!!!

            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = _config?["ConnectionStrings:yasappDb"];

                if (_config != null)
                {
                    optionsBuilder.UseSqlServer(connectionString, x => x.MigrationsHistoryTable("__yasappDb_MigrationHistory"));
                }
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
                     .HasMany(e => e.StudyPrograms)
                     .WithMany(e => e.Students);

            
            modelBuilder.Entity<Student>()
                    .HasMany(e => e.Modules)
                    .WithMany(e => e.Students);


            modelBuilder.Entity<Student>()
                    .HasMany(e => e.MonthlyPlans)
                    .WithOne(e => e.Student)
                    .OnDelete(DeleteBehavior.ClientCascade);


            modelBuilder.Entity<Student>()
                .HasMany(e => e.WeeklyPlans)
                .WithOne(e => e.Student)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.DailyPlans)
                .WithOne(e => e.Student)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Student>()
                    .HasMany(e => e.PlannerTasks)
                    .WithOne(e => e.Student)
                    .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<StudyProgram>()
                       .HasMany(e => e.Modules)
                       .WithOne(e => e.StudyProgram)
                       .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<StudyProgram>()
                     .HasMany(e => e.Students)
                     .WithMany(e => e.StudyPrograms);

            modelBuilder.Entity<Contact>()
                  .HasMany(e => e.Modules)
                  .WithMany(e => e.Contacts);

            //    modelBuilder.Entity<WeeklyPlanner>(entity =>
            //    {
            //        entity.HasOne(e => e.Student)
            //            .WithMany(e => e.WeeklyPlans)
            //            .HasForeignKey(e => e.StudentId)
            //            .OnDelete(DeleteBehavior.NoAction);
            //    });

            //    modelBuilder.Entity<PlannerTask>( entity =>             {

            //        entity.HasOne(e => e.Student)
            //            .WithMany(e => e.PlannerTasks)
            //            .HasForeignKey(e => e.StudentId)
            //            .OnDelete(DeleteBehavior.NoAction);
            //    });



            //    modelBuilder.Entity<DailyPlanner>(entity => {
            //        entity.HasOne(e => e.Student)
            //            .WithMany(e => e.DailyPlans)
            //            .HasForeignKey(e => e.StudentId)
            //            .OnDelete(DeleteBehavior.NoAction);
            //    });
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Conventions.Remove(typeof(TableNameFromDbSetConvention));
        }

        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<DailyPlanner> DailyPlanners { get; set; } = null!;
        public DbSet<Examination> Examinations { get; set; } = null!;
        public DbSet<Module> Modules { get; set; } = null!;
        public DbSet<ModuleItem> ModuleItems { get; set; } = null!;
        public DbSet<PlannerTask> PlannerTasks { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<WeeklyPlanner> WeeklyPlanners { get; set; } = null!;
        public DbSet<StudyProgram> StudyPrograms { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using yasapp.Domain.Entities;

namespace yasapp.Infrastructure.Data
{
    public class YasappDbContext : DbContext
    {
        IConfiguration _config;
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
            // modelBuilder.HasPostgresExtension("pg_catalog", "adminpack");

            modelBuilder.Entity<StudentModuleMapping>(entity =>
            {
                //composite key
                entity.HasKey(e => new { e.StudentId, e.ModuleId});
                entity.HasIndex(e => new { e.StudentId, e.ModuleId }).IsUnique();
            });

            modelBuilder.Entity<WeeklyPlanner>(entity =>
            {
                entity.HasOne(e => e.Student)
                    .WithMany(e => e.WeeklyPlans)
                    .HasForeignKey(e => e.StudentId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<PlannerTask>( entity =>             {

                entity.HasOne(e => e.Student)
                    .WithMany(e => e.PlannerTasks)
                    .HasForeignKey(e => e.StudentId)
                    .OnDelete(DeleteBehavior.NoAction);
            });


            modelBuilder.Entity<DailyPlanner>(entity => {

                entity.HasOne(e => e.Student)
                    .WithMany(e => e.DailyPlans)
                    .HasForeignKey(e => e.StudentId)
                    .OnDelete(DeleteBehavior.NoAction);
            });
        }


        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<DailyPlanner> DailyPlanners { get; set; } = null!;
        public DbSet<Examination> Examinations { get; set; } = null!;
        public DbSet<Module> Modules { get; set; } = null!;
        public DbSet<ModuleItem> ModuleItems { get; set; } = null!;
        public DbSet<PlannerTask> PlannerTasks { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<StudentModuleMapping> StudentModuleMappings { get; set; } = null!;
        public DbSet<WeeklyPlanner> WeeklyPlanners { get; set; } = null!;
    }
}

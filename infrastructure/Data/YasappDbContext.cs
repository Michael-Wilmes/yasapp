using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using yasapp.Domain.Entities;

namespace yasapp.Infrastructure.Data
{
    public class YasappDbContext : DbContext
    {
        public YasappDbContext (DbContextOptions<YasappDbContext> options)
            : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; } = null!;
        //dbset of dailyplanner

    }
}

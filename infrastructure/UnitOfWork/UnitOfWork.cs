using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yasapp.Infrastructure.Data;
using yasapp.Infrastructure.Intefaces;

namespace yasapp.Infrastructure.UnitOfWork
{
    public class UnitOfWork(YasappDbContext _context) : IUnitOfWork
    {
        public async Task SaveChangesAsync()
        {
            await  _context.SaveChangesAsync();
        }
    }
}

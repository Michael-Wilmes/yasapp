using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yasapp.Domain.Entities;
using Yasapp.Domain.Entities.Masterdata;
using Yasapp.Infrastructure.Data;
using Yasapp.Infrastructure.Interfaces;
using Yasapp.Infrastructure.Repositories;

namespace Yasapp.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly YasappDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public UnitOfWork(YasappDbContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
        }

        public IRepository<T> Repository<T>() where T : BaseEntity
        {
            var test = _serviceProvider.GetRequiredService<IRepository<T>>();
            return _serviceProvider.GetRequiredService<IRepository<T>>();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yasapp.Domain.Entities;
using yasapp.Domain.Entities.Masterdata;
using yasapp.Infrastructure.Data;
using yasapp.Infrastructure.Interfaces;
using yasapp.Infrastructure.Repositories;

namespace yasapp.Infrastructure.UnitOfWork
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

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}

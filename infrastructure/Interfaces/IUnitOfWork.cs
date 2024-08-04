using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yasapp.Domain.Entities;
using yasapp.Infrastructure.Data;
using yasapp.Infrastructure.Interfaces;
using yasapp.Infrastructure.Repositories;

namespace yasapp.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> Repository<T>() where T : BaseEntity;
        Task CommitAsync();
    }

}

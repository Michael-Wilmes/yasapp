using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yasapp.Domain.Entities;
using Yasapp.Infrastructure.Data;
using Yasapp.Infrastructure.Interfaces;
using Yasapp.Infrastructure.Repositories;

namespace Yasapp.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> Repository<T>() where T : BaseEntity;
        Task SaveChangesAsync();
    }

}

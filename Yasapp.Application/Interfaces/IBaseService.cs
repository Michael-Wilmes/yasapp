using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yasapp.Shared.Models;

namespace Yasapp.Application.Interfaces
{
    public interface IBaseService<T> where T : ModelBase
    {
        Task<IEnumerable<T>> ReadAllAsync();
        Task<T> CreateAsync(T model);
        Task<T> ReadAsync(int  id);
        Task<T> UpdateAsync(T model);
        bool DeleteAsync(int id);

    }
}

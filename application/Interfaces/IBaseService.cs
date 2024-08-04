using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yasapp.Shared.Models;

namespace yasapp.Application.Interfaces
{
    public interface IBaseService<T> where T : ModelBase
    {
        Task<IEnumerable<T>> ReadAllAsync();
        T Create(T model);
        T Read(int  id);
        T Update(T model);
        bool Delete(int id);

    }
}

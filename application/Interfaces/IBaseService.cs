using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yasapp.Shared.Models;

namespace yasapp.Application.Interfaces
{
    public interface BaseService<T> where T : ModelBase
    {
        T Create(T model);
        T Read(int  id);
        T Update(T model);
        bool Delete(int id);

    }
}

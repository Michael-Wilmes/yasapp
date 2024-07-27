using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yasapp.Application.Models;

namespace yasapp.Application.Contracts
{
    public interface BaseService<T> where T : ModelBase
    {
        T Create(T model);
        T Read(int  id);
        T Update(T model);
        bool Delete(int id);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yasapp.Domain.Entities;
using Yasapp.Domain.Entities.Masterdata;

namespace Yasapp.Application.Interfaces
{
    
    public interface IModuleService<TModel> : IBaseService<TModel> where TModel : ModelBase
    {

    }
}

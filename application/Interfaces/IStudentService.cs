using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yasapp.Domain.Entities;
using yasapp.Domain.Entities.Masterdata;

namespace yasapp.Application.Interfaces
{
    public interface IStudentService<TModel> : IBaseService<TModel> where TModel : ModelBase 
    {
    }
}

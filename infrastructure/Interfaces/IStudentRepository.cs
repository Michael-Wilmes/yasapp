

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yasapp.Domain.Entities;

namespace yasapp.Infrastructure.Interfaces
{
    public interface IStudentRepository<T> : IRepository<T> where T : BaseEntity
    {
    }
}

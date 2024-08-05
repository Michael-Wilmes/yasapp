using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yasapp.Domain.Entities;

namespace Yasapp.Infrastructure.Interfaces
{
    public interface IStudyProgramRepository<T> : IRepository<T> where T : BaseEntity
    {
    }
}

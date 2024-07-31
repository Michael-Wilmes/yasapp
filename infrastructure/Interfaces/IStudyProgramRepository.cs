using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yasapp.Infrastructure.Interfaces
{
    public interface IStudyProgramRepository<T> : IRepository<T> where T : class
    {
    }
}

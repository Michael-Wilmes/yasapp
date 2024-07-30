using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yasapp.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}

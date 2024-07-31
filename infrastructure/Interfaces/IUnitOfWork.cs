using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yasapp.Domain.Entities;
using yasapp.Infrastructure.Interfaces;
using yasapp.Infrastructure.Repositories;

namespace yasapp.Infrastructure.Intefaces
{
    public interface IUnitOfWork<T1,T2,T3,T4,T5> where T1 : class
                                                where T2 : class
                                                where T3 : class
                                                where T4 : class
                                                where T5 : class
    {
        IExaminationRepository<T1> GetExaminationRepository();
        IModuleRepository<T2> GetModuleRepository();
        IStudentRepository<T3> GetStudentRepository();
        IStudyProgramRepository<T4> GetStudyProgramRepository();
        IContactRepository<T5> GetContactRepository();
        Task SaveChangesAsync();
    }
}

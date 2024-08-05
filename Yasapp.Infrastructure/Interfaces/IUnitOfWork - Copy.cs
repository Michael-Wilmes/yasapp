//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Yasapp.Domain.Entities;
//using Yasapp.Infrastructure.Interfaces;
//using Yasapp.Infrastructure.Repositories;

//namespace Yasapp.Infrastructure.Interfaces
//{
//    public interface IUnitOfWork where T1 : BaseEntity
//                                                where T2 : BaseEntity
//                                                where T3 : BaseEntity
//                                                where T4 : BaseEntity
//                                                where T5 : BaseEntity
//    {
//        IExaminationRepository<T1> GetExaminationRepository();
//        IModuleRepository<T2> GetModuleRepository();
//        IStudentRepository<T3> GetStudentRepository();
//        IStudyProgramRepository<T4> GetStudyProgramRepository();
//        IContactRepository<T5> GetContactRepository();
//        Task SaveChangesAsync();
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using yasapp.Domain.Entities;
//using yasapp.Domain.Entities.Masterdata;
//using yasapp.Infrastructure.Data;
//using yasapp.Infrastructure.Intefaces;
//using yasapp.Infrastructure.Interfaces;
//using yasapp.Infrastructure.Repositories;

//namespace yasapp.Infrastructure.UnitOfWork
//{
//    public class UnitOfWork<T1,T2,T3,T4,T5>(YasappDbContext _context) 
//                : IUnitOfWork<T1,T2,T3,T4,T5>
//        where T1 : BaseEntity
//        where T2 : BaseEntity
//        where T3 : BaseEntity
//        where T4 : BaseEntity
//        where T5 : BaseEntity
//    {
//        private IExaminationRepository<T1> _examaminationRepo;
//        private IModuleRepository<T2> _moduleRepo;
//        private IStudentRepository<T3> _studentRepo;
//        private IStudyProgramRepository<T4> _studyProgramRepo;
//        private IContactRepository<T5> _contactRepo;

//        public async Task SaveChangesAsync()
//        {
//            await  _context.SaveChangesAsync();
//        }

//        public IExaminationRepository<T1> GetExaminationRepository()
//        {
//            if (_examaminationRepo == null)
//            {
//                _examaminationRepo = new ExaminationRepository<T1>(_context);
//            }
//            return _examaminationRepo;
//        }

//        public IModuleRepository<T2> GetModuleRepository()
//        { 
//            if (_moduleRepo == null)
//            {
//                _moduleRepo = new ModuleRepository<T2>(_context);
//            }
//            return _moduleRepo;
//        }

//        public IStudentRepository<T3> GetStudentRepository()
//        { 
//            if (_studentRepo == null)
//            {
//                _studentRepo = new StudentRepository<T3>(_context);
//            }
//            return _studentRepo;
//        }

//        public IStudyProgramRepository<T4> GetStudyProgramRepository()
//        {
//            if (_studyProgramRepo == null)
//            {
//                _studyProgramRepo = new StudyProgramRepository<T4>(_context);
//            }
//            return _studyProgramRepo;
//        }

//        public IContactRepository<T5> GetContactRepository()
//        {
//            if (_contactRepo == null)
//            {
//                _contactRepo = new ContactRepository<T5>(_context);
//            }
//            return _contactRepo;
//        }
//    }
//}

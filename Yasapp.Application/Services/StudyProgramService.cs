using Serilog.Core;
using Yasapp.Application.Interfaces;
using Yasapp.Domain.Entities;

namespace Yasapp.Application.Services
{
    public class StudyProgramService : IStudyProgramService<StudyProgramModel>
    {
        private ILogger _logger;
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;
        private IRepository<StudyProgram> _repository;

        public StudyProgramService(Logger logger, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            _repository = _unitOfWork.Repository<StudyProgram>();

            if (_repository == null)
            {
                throw new ArgumentNullException("Study Program-Repository");
            }
        }

        public async Task<IEnumerable<StudyProgramModel>> ReadAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<StudyProgramModel>>(entities);
        }

        public async Task<StudyProgramModel> CreateAsync(StudyProgramModel model)
        {
            //todo: validation
            var entity = _mapper.Map<StudyProgram>(model);
            await _repository.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<StudyProgramModel>(await _repository.GetByIdAsync(entity.Id));
        }

        public async Task<StudyProgramModel>? ReadAsync(int id)
        {
            return _mapper.Map<StudyProgramModel>(await _repository.GetByIdAsync(id));
        }

        public async Task<StudyProgramModel>? UpdateAsync(StudyProgramModel model)
        {
            //todo: validation
            StudyProgram? entity = await _repository.GetByIdAsync(model.Id);
            if (entity == null)
            {
                return null;
            }

            _mapper.Map<StudyProgramModel, StudyProgram>(model, entity);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<StudyProgramModel>(await _repository.GetByIdAsync(model.Id));
        }

        public async Task<StudyProgramModel>? DeleteByIdAsync(int id)
        {
            StudyProgram? deleteEntity = await _repository.GetByIdAsync(id);
            if (deleteEntity == null)
            {
                return null;
            }

            await _repository.DeleteAsync(deleteEntity);
            return _mapper.Map<StudyProgramModel>(deleteEntity);
        }

        public async Task<StudyProgramModel>? DeleteAsync(StudyProgramModel entity)
        {
            StudyProgram? deleteEntity = await _repository.GetByIdAsync(entity.Id);
            if (deleteEntity == null)
            {
                return null;
            }

            await _repository.DeleteAsync(deleteEntity);
            return _mapper.Map<StudyProgramModel>(deleteEntity);
        }
    }
}

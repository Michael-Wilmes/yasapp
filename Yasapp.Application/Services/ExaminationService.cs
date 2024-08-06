using Serilog.Core;
using Yasapp.Application.Interfaces;
using Yasapp.Domain.Entities;

namespace Yasapp.Application.Services
{
    public class ExaminationService : IExaminationService<ExaminationModel> 
    {
        private ILogger _logger;
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;
        private IRepository<Examination> _repository;

        public ExaminationService(Logger logger, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            _repository = _unitOfWork.Repository<Examination>();

            if (_repository == null)
            {
                throw new ArgumentNullException("Examination-Repository");
            }
        }

        public async Task<IEnumerable<ExaminationModel>> ReadAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<ExaminationModel>>(entities);
        }

        public async Task<ExaminationModel> CreateAsync(ExaminationModel model)
        {
            //todo: validation
            var entity = _mapper.Map<Examination>(model);
            await _repository.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<ExaminationModel>(await _repository.GetByIdAsync(entity.Id));
        }

        public async Task<ExaminationModel>? ReadAsync(int id)
        {
            return _mapper.Map<ExaminationModel>(await _repository.GetByIdAsync(id));
        }

        public async Task<ExaminationModel>? UpdateAsync(ExaminationModel model)
        {
            //todo: validation
            Examination? entity = await _repository.GetByIdAsync(model.Id);
            if (entity == null)
            {
                return null;
            }

            _mapper.Map<ExaminationModel, Examination>(model, entity);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<ExaminationModel>(await _repository.GetByIdAsync(model.Id));
        }

        public async Task<ExaminationModel>? DeleteByIdAsync(int id)
        {
            Examination? deleteEntity = await _repository.GetByIdAsync(id);
            if (deleteEntity == null)
            {
                return null;
            }

            await _repository.DeleteAsync(deleteEntity);
            return _mapper.Map<ExaminationModel>(deleteEntity);
        }

        public async Task<ExaminationModel>? DeleteAsync(ExaminationModel entity)
        {
            Examination? deleteEntity = await _repository.GetByIdAsync(entity.Id);
            if (deleteEntity == null)
            {
                return null;
            }

            await _repository.DeleteAsync(deleteEntity);
            return _mapper.Map<ExaminationModel>(deleteEntity);
        }
    }
}

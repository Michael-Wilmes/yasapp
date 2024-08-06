namespace Yasapp.Application.Services
{
    public class ModuleService : IModuleService<ModuleModel>

    {
        private ILogger _logger;
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;
        private IRepository<Module> _repository;

        public ModuleService(ILogger logger, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            _repository = _unitOfWork.Repository<Module>();

            if (_repository == null)
            {
                throw new ArgumentNullException("Module-Repository");
            }
        }

        public async Task<IEnumerable<ModuleModel>> ReadAllAsync()
        {

            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<ModuleModel>>(entities);
        }

        public async Task<ModuleModel> CreateAsync(ModuleModel model)
        {
            var entity = _mapper.Map<Module>(model);
            await _repository.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<ModuleModel>(await _repository.GetByIdAsync(entity.Id));
        }

        public async Task<ModuleModel>? ReadAsync(int id)
        {
            return _mapper.Map<ModuleModel>(await _repository.GetByIdAsync(id));
        }

        public async Task<ModuleModel>? UpdateAsync(ModuleModel model)
        {
            //todo: Validation
            Module? entity = await _repository.GetByIdAsync(model.Id);
            if (entity == null)
            {
                return null;
            }

            _mapper.Map<ModuleModel, Module>(model, entity);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<ModuleModel>(await _repository.GetByIdAsync(model.Id));
        }

        public async Task<ModuleModel>? DeleteByIdAsync(int id)
        {
            Module? deleteEntity = await _repository.GetByIdAsync(id);
            if (deleteEntity == null)
            {
                return null;
            }

            await _repository.DeleteAsync(deleteEntity);
            return _mapper.Map<ModuleModel>(deleteEntity);
        }

        public async Task<ModuleModel>? DeleteAsync(ModuleModel entity)
        {
            Module? deleteEntity = await _repository.GetByIdAsync(entity.Id);
            if (deleteEntity == null)
            {
                return null;
            }

            await _repository.DeleteAsync(deleteEntity);
            return _mapper.Map<ModuleModel>(deleteEntity);
        }
    }
}

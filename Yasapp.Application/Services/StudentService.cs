namespace Yasapp.Application.Services
{
    public class StudentService : IStudentService<StudentModel>
    {
        private ILogger _logger;
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;
        private IRepository<Student> _repository;

        public StudentService(ILogger logger, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            _repository = _unitOfWork.Repository<Student>();

            if (_repository == null)
            {
                throw new ArgumentNullException("Student-Repository");
            }
        }

        public async Task<IEnumerable<StudentModel>> ReadAllAsync()
        {

            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<StudentModel>>(entities);
        }

        public async Task<StudentModel> CreateAsync(StudentModel model)
        {
            var entity = _mapper.Map<Student>(model);
            await _repository.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<StudentModel>(await _repository.GetByIdAsync(entity.Id));
        }

        public async Task<StudentModel>? ReadAsync(int id)
        {
            return _mapper.Map<StudentModel>(await _repository.GetByIdAsync(id));
        }

        public async Task<StudentModel>? UpdateAsync(StudentModel model)
        {
            //todo: Validation
            Student? entity = await _repository.GetByIdAsync(model.Id);
            if (entity == null)
            {
                return null;
            }

            _mapper.Map<StudentModel, Student>(model, entity);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<StudentModel>(await _repository.GetByIdAsync(model.Id));
        }

        public async Task<StudentModel>? DeleteByIdAsync(int id)
        {
            Student? deleteEntity = await _repository.GetByIdAsync(id);
            if (deleteEntity == null)
            {
                return null;
            }

            await _repository.DeleteAsync(deleteEntity);
            return _mapper.Map<StudentModel>(deleteEntity);
        }

        public async Task<StudentModel>? DeleteAsync(StudentModel entity)
        {
            Student? deleteEntity = await _repository.GetByIdAsync(entity.Id);
            if (deleteEntity == null)
            {
                return null;
            }

            await _repository.DeleteAsync(deleteEntity);
            return _mapper.Map<StudentModel>(deleteEntity);
        }
    }
}

namespace Yasapp.Application.Services
{
    public class StudentService(ILogger _logger,
                                IMapper _mapper, 
                                IUnitOfWork _unitOfWork)
        : IStudentService<StudentModel> 
    {
        public async Task<IEnumerable<StudentModel>> ReadAllAsync()
        {

            var repo = _unitOfWork.Repository<Student>();
            var entities = await repo.GetAllAsync();
            return _mapper.Map<IEnumerable<StudentModel>>(entities);
        }

        public async Task<StudentModel> CreateAsync(StudentModel model)
        {
            var repo = _unitOfWork.Repository<Student>();
            var entity = _mapper.Map<Student>(model);
            await repo.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<StudentModel>(await repo.GetByIdAsync(entity.Id));
        }

        public Task<StudentModel> ReadAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<StudentModel> UpdateAsync(StudentModel model)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

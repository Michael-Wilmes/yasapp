using Yasapp.Application.Interfaces;
using Yasapp.Domain.Entities;

namespace Yasapp.Application.Services
{
    public class ExaminationService(ILogger _logger,
                                    IMapper _mapper,
                                    IUnitOfWork _unitOfWork)
        : IExaminationService<ExaminationModel> 
    {

        public async Task<IEnumerable<ExaminationModel>> ReadAllAsync()
        {
            var repo = _unitOfWork.Repository<Examination>();
            var entities = await repo.GetAllAsync();
            return _mapper.Map<IEnumerable<ExaminationModel>>(entities);
        }

        public Task<ExaminationModel> CreateAsync(ExaminationModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ExaminationModel> ReadAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ExaminationModel> UpdateAsync(ExaminationModel model)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

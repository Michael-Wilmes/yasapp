using yasapp.Application.Interfaces;
using yasapp.Domain.Entities;

namespace yasapp.Application.Services
{
    public class ExaminationService<TModel, TEntity>(
                                    ILogger _logger,
                                    IMapper _mapper,
                                    IUnitOfWork _unitOfWork)
        : IExaminationService<TModel, TEntity> where TModel : ModelBase  where TEntity : BaseEntity
    {
        public TModel Create(TModel model)
        {
            var repo = _unitOfWork.Repository<TEntity>();
            throw new NotImplementedException();
        }

        public TModel Read(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TModel>> ReadAllAsync()
        {
            var repo = _unitOfWork.Repository<TEntity>();
            var entities = await repo.GetAllAsync();
            return _mapper.Map<IEnumerable<TModel>>(entities);
        }

        public TModel Update(TModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

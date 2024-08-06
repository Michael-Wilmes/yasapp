using Serilog.Core;
using Yasapp.Application.Interfaces;
using Yasapp.Domain.Entities;

namespace Yasapp.Application.Services
{
    public class ContactService : IContactService<ContactModel>
    {
        private ILogger _logger;
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;
        private IRepository<Contact> _repository;

        public ContactService(Logger logger, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            _repository = _unitOfWork.Repository<Contact>();

            if (_repository == null)
            {
                throw new ArgumentNullException("Contact-Repository");
            }
        }

        public async Task<IEnumerable<ContactModel>> ReadAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<ContactModel>>(entities);
        }

        public async Task<ContactModel> CreateAsync(ContactModel model)
        {
            //todo: validation
            var entity = _mapper.Map<Contact>(model);
            await _repository.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<ContactModel>(await _repository.GetByIdAsync(entity.Id));
        }

        public async Task<ContactModel>? ReadAsync(int id)
        {
            return _mapper.Map<ContactModel>(await _repository.GetByIdAsync(id));
        }

        public async Task<ContactModel>? UpdateAsync(ContactModel model)
        {
            //todo: validation
            Contact? entity = await _repository.GetByIdAsync(model.Id);
            if (entity == null)
            {
                return null;
            }

            _mapper.Map<ContactModel, Contact>(model, entity);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<ContactModel>(await _repository.GetByIdAsync(model.Id));
        }

        public async Task<ContactModel>? DeleteByIdAsync(int id)
        {
            Contact? deleteEntity = await _repository.GetByIdAsync(id);
            if (deleteEntity == null)
            {
                return null;
            }

            await _repository.DeleteAsync(deleteEntity);
            return _mapper.Map<ContactModel>(deleteEntity);
        }

        public async Task<ContactModel>? DeleteAsync(ContactModel entity)
        {
            Contact? deleteEntity = await _repository.GetByIdAsync(entity.Id);
            if (deleteEntity == null)
            {
                return null;
            }

            await _repository.DeleteAsync(deleteEntity);
            return _mapper.Map<ContactModel>(deleteEntity);
        }
    }
}

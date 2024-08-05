namespace Yasapp.Application.Services.Profiles
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<Contact, ContactModel>();
            CreateMap<ContactModel, Contact>();
        }
    }
}
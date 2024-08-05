using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yasapp.Application.Services.Profiles
{
    public class ModuleItemProfile : Profile
    {
        public ModuleItemProfile()
        {
            CreateMap<ModuleItem, ModuleItemModel>();
            CreateMap<ModuleItemModel, ModuleItem>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yasapp.Application.Services.Profiles
{
    public class StudyProgramProfile : Profile
    {
        public StudyProgramProfile()
        {
            CreateMap<StudyProgram, StudyProgramModel>();
            CreateMap<StudyProgramModel, StudyProgram>();
        }
    }
}

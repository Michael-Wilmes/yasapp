using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yasapp.Application.Services.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentModel>();
                //.ForMember(dest => dest.StudyPrograms, opt => opt.Ignore());
            CreateMap<StudentModel, Student>()
                .ForMember(dest => dest.UserId, opt => opt.Ignore())
                //.ForMember(dest => dest.StudyPrograms, opt => opt.Ignore())
                .ForMember(dest => dest.DailyPlans, opt => opt.Ignore())
                .ForMember(dest => dest.PlannerTasks, opt => opt.Ignore())
                .ForMember(dest => dest.MonthlyPlannings, opt => opt.Ignore())
                .ForMember(dest => dest.WeeklyPlans, opt => opt.Ignore())
                .ForMember(dest => dest.Modules, opt => opt.Ignore());
        }
    }
}

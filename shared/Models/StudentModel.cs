using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace yasapp.Shared.Models
{
    public class  StudentModel : ModelBase
    {
        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public DateOnly StartedAt { get; set; }
        public DateTime? FinishedAt { get; set; }

        public DateTime? PlannedEnd { get; set; }
        public DateTime? RealEnd { get; set; }

        public string? StudentMailAddress { get; set; }
        public string? RegistrationNumber { get; set; }
        public DateTime RegistrationValidFrom { get; set; }
        public DateTime RegistrationValidTo { get; set; }

        public  IEnumerable<StudyProgramModel>? StudyPrograms { get; set; }
        
        //todo: add them later
        /*
            public  IEnumerable<ModuleModel>? Modules { get; set; }   
            public  IEnumerable<MonthlyPlanningModel>? MonthlyPlannings { get; set; }
            public IEnumerable<PlannerTaskModel>? PlannerTasks { get; set; }
            public IEnumerable<WeeklyPlannerModel>? WeeklyPlans { get; set; }
            public IEnumerable<DailyPlannerModel>? DailyPlans { get; set; }
        */
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yasapp.Domain.Entities.StudyPlanning;

namespace yasapp.Domain.Entities.Masterdata
{
    public class Student : BaseEntity
    {

        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public DateOnly StartedAt { get; set; }
        public DateTime? FinishedAt { get; set; }

        public DateTime? PlannedEnd { get; set; }
        public DateTime? RealEnd { get; set; }

        public string? StudentMailAdress { get; set; }
        public string? RegistrationNumber { get; set; }
        public DateTime RegistrationValidFrom { get; set; }
        public DateTime RegistrationValidTo { get; set; }

        public virtual Collection<StudyProgram>? StudyPrograms { get; set; }
        public virtual Collection<Module>? Modules { get; set; }

        public virtual Collection<MonthlyPlanning>? MonthlyPlannings { get; set; }
        public virtual Collection<PlannerTask>? PlannerTasks { get; set; }
        public virtual Collection<WeeklyPlanner>? WeeklyPlans { get; set; }
        public virtual Collection<DailyPlanner>? DailyPlans { get; set; }
    }
}

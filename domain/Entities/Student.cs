using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yasapp.Domain.Entities
{
    public  class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NameOfStudi {  get; set; }
        
        public DateOnly StartedAt { get; set; }
        public DateTime? FinishedAt { get; set; }

        public DateTime? PlannedEnd {  get; set; }
        public DateTime? RealEnd { get; set; }


        public string? StudentMailAdress { get; set; }
        public string? RegistrationNumber { get; set; }
        public DateTime RegistrationValidFrom { get; set; }
        public DateTime RegistrationValidTo { get; set; }

        public virtual Collection<StudentModuleMapping>? Modules{ get; set; }
        public virtual Collection<PlannerTask>? PlannerTasks { get; set; }
        public virtual Collection<WeeklyPlanner>? WeeklyPlans { get; set; }
        public virtual Collection<DailyPlanner>? DailyPlans { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yasapp.Domain.Entities.StudyPlanning;

namespace Yasapp.Domain.Entities.Masterdata
{
    public class Student : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateOnly StartedAt { get; set; }
        public DateTime? FinishedAt { get; set; }

        public DateTime? PlannedEnd { get; set; }
        public DateTime? RealEnd { get; set; }

        public string? StudentMailAddress { get; set; }
        public string? RegistrationNumber { get; set; }
        public DateTime RegistrationValidFrom { get; set; }
        public DateTime RegistrationValidTo { get; set; }

        public Guid? UserId { get; set; }

        #region navigation
        public virtual Collection<StudyProgram>? StudyPrograms { get; set; }

        
        public virtual Collection<Module>? Modules { get; set; }
        public virtual Collection<MonthlyPlanner>? MonthlyPlans { get; set; }
        public virtual Collection<WeeklyPlanner>? WeeklyPlans { get; set; }
        public virtual Collection<DailyPlanner>? DailyPlans { get; set; }
        public virtual Collection<PlannerTask>? PlannerTasks { get; set; }

        #endregion navigation
    }
}
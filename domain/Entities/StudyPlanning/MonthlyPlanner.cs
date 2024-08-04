using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yasapp.Domain.Entities.Masterdata;

namespace yasapp.Domain.Entities.StudyPlanning
{
    public class MonthlyPlanner : BaseEntityWithStudent
    {
        [Required]
        public int StudyMonth { get; set; }

        [Required]
        DateOnly StudyMonthStart { get; set; }

        [Required]
        DateOnly StudyMonthEnd { get; set; }

        public ICollection <WeeklyPlanner>? WeeklyPlans { get; set; }
    }
}

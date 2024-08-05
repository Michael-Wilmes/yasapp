using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yasapp.Domain.Entities.Masterdata;

namespace Yasapp.Domain.Entities.StudyPlanning
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

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yasapp.Domain.Entities.Masterdata;

namespace Yasapp.Domain.Entities.StudyPlanning
{
    public class WeeklyPlanner : BaseEntityWithStudent
    {
        [Required]
        public DateTime WeekStart { get; set; }
        
        [Required]
        public DateTime WeekEnd { get; set; }

        public List<string> WeekGoals { get; set; }

        public virtual Collection<DailyPlanner>? DailyPlans { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yasapp.Domain.Entities
{
    public class WeeklyPlanner : BaseEntityWithStudent
    {
        public DateTime WeekStart {  get; set; }
        public DateTime WeekEnd { get; set; }

        public List<string> GlobalGoals { get; set; }

        public  virtual Collection<DailyPlanner>? Days { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yasapp.Shared.Models
{
    public  class  ModelBase
    {
        int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public String CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public String? UpdatedBy { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yasapp.Domain.Entities
{
    public  class Contact : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Remark { get; set; }
        
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Money
    {
        [Required]
        
        public long Amount { get; set; }

        [Required ]
        public String Name { get; set; }

    }
}

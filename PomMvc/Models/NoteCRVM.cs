using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PomMvc.Models
{
    public class NoteCRVM
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Note { get; set; }
    }
}

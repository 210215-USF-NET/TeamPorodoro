using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PomMvc.Models
{
    public class PomodoroCRVM
    {
        [DisplayName("UserName")]
        [Required]
        public string UserName { get; set; }
    }
}

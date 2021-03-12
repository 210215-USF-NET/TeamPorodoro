using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PomMvc.Models
{
    public class NoteCRVM
    {
        [DisplayName("Enter your Username:")]
        [Required]
        public string UserName { get; set; }
        [DisplayName("Enter your Note:")]
        [Required]
        public string Note { get; set; }
    }
}

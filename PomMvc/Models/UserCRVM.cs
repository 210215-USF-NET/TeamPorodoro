using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PomMvc.Models
{
    public class UserCRVM
    {
        public int Id { get; set; }
        [DisplayName("UserName")]
        [Required]
        public string UserUserName { get; set; }
        [DisplayName("First Name")]
        [Required]
        public string UserFirstName { get; set; }
        [DisplayName("Last Name")]
        [Required]
        public string UserLastName { get; set; }
    }
}

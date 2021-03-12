using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


/// <summary>
/// A Pomodoro Timer built in Java script.  Code for the timer was modified from
/// timer code on the following website:
/// https://css-tricks.com/how-to-create-an-animated-countdown-timer-with-html-css-and-javascript/
/// </summary>
namespace PomMvc.Models
{
    public class PomodoroCRVM
    {
        [DisplayName("UserName")]
        [Required]
        public string UserName { get; set; }
    }
}

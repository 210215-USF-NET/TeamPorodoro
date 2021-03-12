using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomModels
{
    public class Pomodoro
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public DateTime CreationTime { get; set; }
        public int PomodoroCounter { get; set; }
    }
}

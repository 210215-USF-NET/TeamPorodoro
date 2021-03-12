using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomDL
{
    class PomRepoDB : IPomRepo
    {
        private readonly PomDBContext _context;
        public PomRepoDB(PomDBContext context)
        {
            _context = context;
        }
    }
}

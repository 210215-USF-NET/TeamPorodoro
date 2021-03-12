using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PomModels;

namespace PomBL
{
    public interface IPomBL
    {
        User addUser(user newUser);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RecoveringDemo
{
    class Upholsterer:IRecoverable
    {
        public void Recover()
        {
            WriteLine("The furniture is on its way too looking better.");
        }
    }
}

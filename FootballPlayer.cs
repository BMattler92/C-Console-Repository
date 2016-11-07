using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RecoveringDemo
{
    class FootballPlayer:IRecoverable
    {
        public void Recover()
        { WriteLine("I dont know how a football player recovers but he is doing it."); }
    }
}

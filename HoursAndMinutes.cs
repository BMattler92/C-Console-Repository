using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class HoursAndMinutes
    {
        static void Main(string[] args)
        {
            int minutes=197;

            int hours = minutes / 60;
            int leftover = minutes % 60;

            Console.WriteLine(minutes + " minutes is " + hours + " hours and " + minutes + " minutes.");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItALeapYear
{
    public class Program
    {
        public bool IsItALeapYear(int yearPassed)
        {
            if ((yearPassed % 4 == 0 && yearPassed % 100 != 0) || (yearPassed % 400 == 0))
                return true;
            return false;

        }
        static void Main(string[] args)
        {
        }
    }
}

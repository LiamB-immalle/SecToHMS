using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecToUMS
{
    class Program
    {
        static void Main(string[] args)
        {
            SecToHMS b = new SecToHMS();

            b.SecToHoursMinsSecs(61);

            Console.WriteLine("{0} hours {1} minutes and {2} seconds", b.h, b.m, b.s);
        }
    }
}
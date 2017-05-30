using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecToUMS
{
    class Program
    {
        static void SecToHoursMinsSecs(int totalSeconds, out int uren, out int minuten, out int seconden)
        {
            int rest = 0;

            uren = totalSeconds / (60 * 60);
            rest = totalSeconds % (60 * 60);
            minuten = rest / 60;
            seconden = rest % 60;
        }

        static void Main(string[] args)
        {
            int h = 0;
            int m = 0;
            int s = 0;

            SecToHoursMinsSecs(54324561, out h, out m, out s);

            Console.WriteLine("{0} hours {1} minutes and {2} seconds", h, m, s);
        }
    }
}
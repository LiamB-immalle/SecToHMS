using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecToUMS
{
    struct HMSTime
    {
        public int Hours;
        public int Mins;
        public int Secs;
    }

    class Program
    {
        static HMSTime SecToHMS(int totalSeconds)
        {
            HMSTime a;
            int rest;

            a.Hours = totalSeconds / (60 * 60);
            rest = totalSeconds % (60 * 60);
            a.Mins = rest / 60;
            a.Secs = rest % 60;
            return a;
        }

        static void Main(string[] args)
        {
            HMSTime b = SecToHMS(25651);

            Console.WriteLine("Dat zijn {0} uren, {1} minuten en {2} seconden.", b.Hours, b.Mins, b.Secs);
        }
    }
}
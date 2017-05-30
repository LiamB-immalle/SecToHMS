using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecToUMS
{
    class SecToHMS
    {
        public int h = 0;
        public int m = 0;
        public int s = 0;

        public void SecToHoursMinsSecs(int totalSeconds)
        {
            int rest = 0;

            h = totalSeconds / (60 * 60);
            rest = totalSeconds % (60 * 60);
            m = rest / 60;
            s = rest % 60;
        }
    }
}

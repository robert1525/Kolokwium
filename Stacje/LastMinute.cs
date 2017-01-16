using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacje
{
    class LastMinute : Podroz
    {
        public override double KosztPoRabacie()
        {
            return koszt * 0.75d;
        }

        public override string ToString()
        {
            string output = "Podróż last minute:\n";
            foreach (var s in stacje)
                output += s.ToString() + '\n';
            return output + "Koszt po rabacie: " + KosztPoRabacie().ToString("2N");
        }
    }
}

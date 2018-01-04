using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ResiliencePowerCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //trinket set bonus = 5280 resilience
            double[] stats;
            CalculateResilience _calculator = new CalculateResilience(0.77, 1375);

            stats = _calculator.CalculateResilRating();
            Debug.WriteLine("");
            Debug.WriteLine("PvP Resilience: " + (Math.Round(stats[0] * 100, 2)) + "%");
            Debug.WriteLine("");
            Debug.WriteLine(stats[1] + "% damage reduction over baseline. (77%)");
            Debug.WriteLine(stats[2] + "% damage rd. over pvp baseline. (80%)");
            Debug.WriteLine("");

        }
    }
}

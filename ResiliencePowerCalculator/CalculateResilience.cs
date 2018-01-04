using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResiliencePowerCalculator
{
    class CalculateResilience
    {
        private double baseResil { get; set; }
        private double resilRating { get; set; }

        public CalculateResilience(double bR, double rR)
        {
            baseResil = bR;
            resilRating = rR;
        }

        public double[] CalculateResilRating()
        {
            double[] Stats = new double[3];
            double newResilience = ((35200 * baseResil) + resilRating) / (35200 + resilRating);
            double damageReduction = ((1-0.77) / (1-newResilience)) - 1;
            double damageReductionPvP = ((1 - 0.8) / (1 - newResilience)) - 1;

            Stats[0] = newResilience;
            Stats[1] = Math.Round(damageReduction * 100, 2);
            Stats[2] = Math.Round(damageReductionPvP * 100, 2);


            return Stats;
        }
    }
}

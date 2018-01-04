using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParryCalculator
{
    class CalculateParry
    {
        private double _baseParry { get; set;}
        private double _baseStrength { get; set; }
        private double _totalStrength { get; set; }
        private double _parryRating { get; set; }

        public CalculateParry(double bP, double bS, double tS, double pR)
        {
            _baseParry = bP;
            _baseStrength = bS;
            _totalStrength = tS;
            _parryRating = pR;
        }

        public double[] DoCalculation()
        {
            double k = 0.9560;
            double Cp = 65.631440;
            double oCP = 0.01523660;

            double[] stats = new double[2];
            double noDR = (_totalStrength / 952) + (_parryRating / 885);
            double prDR = _baseParry + (_baseStrength/952) + Math.Pow(( (1/235.5) + (k / ((_totalStrength / 952) + (_parryRating / 885)))), -1);

            stats[0] = (noDR + _baseParry + (_baseStrength / 952));
            stats[1] = prDR;

            return stats;
        }
    }
}

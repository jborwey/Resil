using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class CalculateDamageReduction
    {
        private double _baseResil { get; set; }
        private double _resilRating { get; set; }
        private string _metaGem { get; set; }
        private double _flatMagicDR = 1;
        private double _pvpBaseLine = 0.8;

        public CalculateDamageReduction(double bR, double rR, string mG)
        {
            _baseResil = bR;
            _resilRating = rR;
            _metaGem = mG;

            if (mG == "pvp")
            {
                _resilRating += 775;
            }
            else if(mG == "effulgent")
            {
                _flatMagicDR = 0.98;
            }
        }

        public double[] CalculateResilRating()
        {
            double[] stats = new double[4];
            double newResilience = ((35200 * _baseResil) + _resilRating) / (35200 + _resilRating);
            double damageReduction = ((1 - _baseResil) / ((1 - newResilience) * _flatMagicDR))  - 1;          
            double damageReductionPvP = (((1 - newResilience) * _flatMagicDR) / (1 - _pvpBaseLine)) - 1;

            if (newResilience > _pvpBaseLine)
            {           
                damageReductionPvP = ((1 - _pvpBaseLine)  / ((1 - newResilience) * _flatMagicDR)) - 1;
            }
           


            stats[0] = Math.Abs(damageReduction);
            stats[1] = Math.Abs(damageReductionPvP);
            stats[2] = newResilience;
            stats[3] = _resilRating;


            return stats;
        }
    }
}

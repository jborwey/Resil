using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class CalculateParry
    {
        private double _baseParry { get; set; }
        private double _baseStrength { get; set; }
        private double _totalStrength { get; set; }
        private double _parryRating { get; set; }
        private HashSet<string> _buffs { get; set; }

        public CalculateParry(double bP, double bS, double tS, double pR, bool flask, HashSet<string> buffs)
        {
            _baseParry = bP;
            _baseStrength = bS;
            _totalStrength = tS;
            _parryRating = pR;
            _buffs = buffs;

            if (flask) { _totalStrength += 500; }
            BuffStrength(_buffs);
        }

        public void BuffStrength(HashSet<string> buffs)
        {
            foreach(string buff in buffs)
            {
                if (buff == "motw") { _totalStrength *= 1.05; }
                else if (buff == "rotfc") { _totalStrength *= 1.15; }
                else if (buff == "yulon") { _totalStrength *= 1.20; }
                else if (buff == "nutrient") { _totalStrength *= 1.05; }
            }
        }

        public double[] DoCalculation()
        {
            double k = 0.9560;
            double Cp = 65.631440;
            double oCP = 0.01523660;

            double[] stats = new double[3];
            double noDR = (_totalStrength / 952) + (_parryRating / 885);
            double prDR = _baseParry + (_baseStrength / 952) + Math.Pow(((1 / 235.5) + (k / ((_totalStrength / 952) + (_parryRating / 885)))), -1);

            stats[0] = (noDR + _baseParry + (_baseStrength / 952));
            stats[1] = prDR;
            stats[2] = _totalStrength;

            return stats;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class CalculateHealing
    {
        private double _stamina { get; set; }
        private double _resilience { get; set; }

        public CalculateHealing(double stamina, double resilience)
        {
            _stamina = stamina;
            _resilience = resilience;
        }

        public double EffectiveHealth()
        {
            double health = _stamina * 14;
            return health / _resilience;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateParry calculateParry = new CalculateParry(3, 305, 36416, 1118);
            double[] stats = calculateParry.DoCalculation();

            Debug.WriteLine("");
            Debug.WriteLine("Parry Rating (before DR): " + (Math.Round(stats[0], 2)) + "%");
            Debug.WriteLine("Parry Rating (applied DR): " + (Math.Round(stats[1], 2)) + "%");
            Debug.WriteLine("Parry Rating (pvp Expertise): " + (Math.Round(stats[1], 2) - 6.00) + "%");
            Debug.WriteLine("");
        }
    }
}

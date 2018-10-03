using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLommeregner
{
    public class PhysicsFormulary
    {
        public const double gAcc = 9.82;
        public const double pi = Math.PI;
        public const double tau = 2 * pi;
        

        // Potential Energy
        public double PotentialEnergyE(double mass, double height)
        {
            
            double energy = gAcc * mass * height;
            return energy;
        }
        public double PotentialEnergyM(double energy, double height)
        {
            double mass = energy / (gAcc * height);
            return mass;
        }
        public double PotentialEnergyH(double energy, double mass)
        {
            double height = energy / (gAcc * mass);
            return height;
        }

    }
}

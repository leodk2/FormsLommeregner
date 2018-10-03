using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLommeregner
{
    public class PhysicsFormulary
    {
        public const double pi = 3.14;
        public const double g = 9.82;

        public double PotentialE(double m, double h)
        {
            double e = g * m * h;
            return e;
        }
    }
}

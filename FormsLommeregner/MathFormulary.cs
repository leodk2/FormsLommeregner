using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLommeregner
{
    public class MathFormulary
    {
        public const double gAcc = 9.82;
        public const double pi = Math.PI;
        public const double tau = 2 * pi;
        

    }

    public abstract class Formular2var
    {
        public string name;
        public string description;
        public abstract double Function();
        public abstract double FunctionTwo();
    }

    public class SphereCircumference : Formular2var
    {
        public
        public override double Function()
        {
            return 0;
        }

    }
}


using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLommeregner
{
    public class program
    {
        
    }

    public class MathFormulary
    {
        public const double gAcc = 9.82;
        public const double pi = Math.PI;
        public const double tau = 2 * pi;

        public List<Formular> formulars = new List<Formular>;

        public SphereCircumference sc = new SphereCircumference();

        public void addAll()
        {
            formulars.Add(sc);

        }

    }
    public abstract class Formular
    {

    }

    public abstract class Formular2var : Formular
    {
        //public abstract string Name();
        public abstract string Description { get; };
        public abstract string Name { get; }
        public abstract double Function(double a);
        public abstract double FunctionTwo(double a);
    }

    public class SphereCircumference : Formular2var
    {
        public override string Name { get { return "Omkreds af cirkel (Matematik)"} }
        public override string Description { get { "Find omkredsen på en cirkel" } }

        public override double Function(double radius)
        {
            double circ = 2 * radius * pi;
            return circ;
        }
        public override double FunctionTwo(double circ)
        {

            double radius = circ / (2 * pi);
            return 0;
        }

    }
}


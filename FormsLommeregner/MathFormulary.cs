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
        //public abstract string Name();
        public abstract string Description();
        public abstract string Name { get; }
        public abstract double Function(double a,double b );
        public abstract double FunctionTwo();
    }

    public class SphereCircumference : Formular2var
    {
        //Formular2var formular2Var;
        //Formular2var.name = "hej";
        public override string Name { get { return "omkreds af cirkel"} }
        Form1 form1 = new Form1();
       
        public override double Function()
        {
            return 0;
        }

    }
}


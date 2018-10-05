using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLommeregner
{

    public class Constants
    {
        // math
        public const double pi = Math.PI;
        public const double tau = 2 * pi;

        // physics
        public const double gAcc = 9.82;
    }

    public abstract class BaseFormulary
    {
        public BaseFormulary()
        {

        }

    }

    public abstract class BaseFormula
    {
        // name of formular
        public abstract string Name { get; }



    }

    // formular class for 2 unknown variables
    public abstract class Formular2var : BaseFormula
    {


        public int varCount = 2;
        // description of formular
        public abstract string Description { get; }

        // function to find main unknown variable
        public abstract double Function(double a);
        // function to find the second variable
        public abstract double FunctionTwo(double a);
    }
    
    // formular class for 2 unknown variables
    public abstract class Formular3var : BaseFormula
    {
        const double pi = PI;
        const double tau = 2 * PI;

        public int varCount = 2;
        // description of formular
        public abstract string Description { get; }

        // function to find main unknown variable
        public abstract double Function(double a);
        // function to find the second variable
        public abstract double FunctionTwo(double a);
    }

}

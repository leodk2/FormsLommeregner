using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLommeregner
{
    // why is this here? IDK
    public class program
    {
        
    }

    // math formulary main class
    public class MathFormulary
    {
        // constants
        // gravitational acceleration on earth
        public const double gAcc = 9.82;
        // pi
        public const double pi = Math.PI;
        // some other constant i haven't heard of
        public const double tau = 2 * pi;

        // create list of formulars
        public List<Formular> formulars = new List<Formular>;

        // function to add all formulars to formulars list
        public void addAll()
        {
            // add functions. NOTE: multiple functions can be added with one .Add()
            formulars.Add(new SphereCircumference);
        }

    }

    // parent formular class
    public abstract class Formular
    {

    }

    // formular class for 2 unknown variables
    public abstract class Formular2var : Formular
    {
        // name of formular
        public abstract string Name { get; }
        // description of formular
        public abstract string Description { get; };

        // function to find main unknown variable
        public abstract double Function(double a);
        // function to find the second variable
        public abstract double FunctionTwo(double a);
    }

    //  sphere circumference
    public class SphereCircumference : Formular2var
    {
        // set name
        public override string Name { get { return "Omkreds af cirkel (Matematik)"} }
        // set description
        public override string Description { get { "Find omkredsen på en cirkel" } }

        // find circumference parsing radius
        public override double Function(double radius)
        {
            // formula
            double circ = 2 * radius * pi;
            // return
            return circ;
        }
        // find radius parsing circumference
        public override double FunctionTwo(double circ)
        {
            // formula
            double radius = circ / (2 * pi);
            // return
            return radius;
        }

    }
}


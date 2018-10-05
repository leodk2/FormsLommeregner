using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLommeregner
{

    // math formulary main class
    public class MathFormulary
    {
        /// constants
        // gravitational acceleration on earth
        public const double gAcc = 9.82;
        // pi
        public const double pi = Math.PI;
        // Tau
        public const double tau = 2 * pi;

        // create list of formulars
        public List<BaseFormula> formulars = new List<BaseFormula>();
        

        // function to add all formulars to formulars list
        public void AddAll(Form1 form1)
        {
            // add functions. NOTE: multiple functions can be added with one .Add()
            formulars.Add(new SphereCircumference());
            formulars.Add(new SquareCircumference());
            TreeNode mathNode = new TreeNode("Matematik");
            
            foreach (BaseFormula formula in formulars)
            {
                //var addnodes = form1.funcList.Nodes.Add(formula.Name);
                //Console.OpenStandardOutput();
                //Console.WriteLine(addnodes);
                mathNode.Nodes.Add(formula.Name);
            }
            form1.funcList.Nodes.Add(mathNode);
            //var addChildNodes = addnodes.Nodes.Add("nigger")
            
        }

    }

    // parent formular class
    
    #region geometry
    //  sphere circumference
    public class SphereCircumference : Formular2var
    {
        // set name
        public override string Name { get { return "Omkreds af cirkel"; } }
        // set description
        public override string Description { get { return "Find omkredsen af en cirkel"; }}

        // find circumference parsing radius
        public override double Function(double radius)
        {
            // formula
            double circ = 2 * radius * MathFormulary.pi;
            // return
            return circ;
        }
        // find radius parsing circumference
        public override double FunctionTwo(double circ)
        {
            // formula
            double radius = circ / (2 * MathFormulary.pi);
            // return
            return radius;
        }

    }
    
    // square circumference
    public class SquareCircumference : Formular2var
    {
        public override string Name { get { return "Omkreds af kvadrat"; } }
        public override string Description { get { return "Find omkredsen af et kvadrat"; } }

        public override double Function(double sidelaengde)
        {
            double omkreds = sidelaengde * 4;
            return omkreds;
        }

        public override double FunctionTwo(double omkreds)
        {
            double sidelaengde = omkreds / 4;
            return sidelaengde;
        }
    }

    #endregion


}


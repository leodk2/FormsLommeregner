using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLommeregner
{
    public class PhysicsFormulary : BaseFormulary
    {
        // create list of formulars
        public List<BaseFormula> formulas = new List<BaseFormula>();

        // create treeNode accessible from outside !shouid be static in BaseFormulary
        public TreeNode treeNode = new TreeNode("Fysik");

        // function to add all formulars to formulars list
        public PhysicsFormulary() : base()
        {

            // add functions. NOTE: multiple functions can be added with one .Add()
            
            //formulas.Add(new PotentialEnergy());
            //formulars.Add(new Ohm());



            foreach (BaseFormula formula in formulas)
            {
                treeNode.Nodes.Add(formula.Name);
            }

            /*
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
            */
        }

        

    }
}

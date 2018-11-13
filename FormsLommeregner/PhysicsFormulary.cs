using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLommeregner
{
    public struct PhysicsFormularyStructs
    {
        public struct Subject{ string subject { get; } }

        public string name { get; }
        public string description { get; }
        public int varCount { get; }
    }
    public class PhysicsFormulary : BaseFormulary
    {
        /// constants
        // gravitational acceleration on earth
        public const double gAcc = 9.82;
        // pi
        public const double pi = Math.PI;
        // Tau
        public const double tau = 2 * pi;


        // create list of formulars

        public List<BaseFormula> formulas = new List<BaseFormula>();

        // create treeNode accessible from outside !shouid be static in BaseFormulary
        public TreeNode treeNode = new TreeNode("Fysik");

        // function to add all formulars to formulars list
        public PhysicsFormulary() : base()
        {
            formulas.Add(new PotentialEnergy());
            formulas.Add(new Spaending());
            formulas.Add(new )



            foreach (BaseFormula formula in formulas)
            {
                treeNode.Nodes.Add(formula.Name);
            }

            #region energy
        }
        public class PotentialEenrgyWStructs
        {

            
            
            
        }
        public class PotentialEnergy : Formular2var
        {
            //set name
            public override string Name { get { return "Potentiel energi"; } }
            //set number of variables
            public override int VarCount { get { return 3; } }
            //set description
            public override string Description { get { return "Beregn den potentielle energi"; } }
            readonly string[] vs = new string[] { "Energi", "Masse", "Højde" };
            public override string[] VarName { get { return vs; } }



            Formelsamling form1 = new Formelsamling();
            public override void Shared()
            {
                form1.FuncName.Text = Name;
                form1.Description.Text = Description;
                form1.Variables.Items.Clear();
                form1.Variables.Items.AddRange(VarName);
            }



            // Potential Energy
            public override double Function(double mass, double height)
            {

                double energy = gAcc * mass * height;
                return energy;
            }
            public override double FunctionTwo(double energy, double height)
            {
                double mass = energy / (gAcc * height);
                return mass;
            }
            public override double FunctionThree(double energy, double mass)
            {
                double height = energy / (gAcc * mass);
                return height;
            }

        }
        #endregion
        public class Spaending : Formular2var
        {
            public override string Name { get { return "Spændning"; } }
            public override int VarCount { get { return 3; } }
            public override string Description { get { return "Beregn spændingen ud fra modstand og strømstyrke"; } }
            readonly string[] vs = new string[] { "Spænding", "Modstand", "Strømstyrke" };
            public override string[] VarName { get { return vs; } }

            public override double Function(double modstand, double strømstyrke)
            {
                double spænding = modstand * strømstyrke;
                return spænding;
            }
            public override double FunctionTwo(double spænding, double strømstyrke)
            {
                double modstand = spænding / strømstyrke;
                return modstand;
            }
            public override double FunctionThree(double spændning, double modstand)
            {
                double strømstyrke = spændning / modstand;
                return strømstyrke;
            }

            Formelsamling form1 = new Formelsamling();
            public override void Shared()
            {
                form1.FuncName.Text = Name;
                form1.Description.Text = Description;
                form1.Variables.Items.Clear();
                form1.Variables.Items.AddRange(VarName);
            }
        }
    }
}
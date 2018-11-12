using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.InteropServices;

namespace FormsLommeregner
{
    public partial class Formelsamling : Form
    {
        public BaseFormula currentFormula;

        public Formelsamling()
        {
            
            InitializeComponent();
           


        }

        public void Print (string a)
        {

            Console.WriteLine(a);
        }
        public void Print(int b)
        {
            Console.WriteLine(b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            


        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public List<TextBox> textBoxes = new List<TextBox>();

        public void ShowMath()
        {
            SphereCircumference sphereCircumference = new SphereCircumference();
            //sphereCircumference.Shared();
            MathFormulary mathFormulary = new MathFormulary();

            // loop through all formulas in the MathFormulary
            foreach (BaseFormula formula in mathFormulary.formulas)
            {
                // if the current formula is the one selected
                if (formula.Name == funcList.SelectedNode.Text)
                {
                    // set the current formula as the currentFormula or the selected formula
                    currentFormula = formula;
                    sphereCircumference.Shared();

                   
                    for (int i = 0; i < formula.VarCount; i++)
                    {
                        textBoxes.Add(new TextBox());
                        int usableSpace = 656 / (formula.VarCount + 1);

                        TextBox text = new TextBox();
                        //text.Location = new Point(100, 100);
                        Formelsamling form1 = new Formelsamling();
                        form1.Controls.Add(text);
                        text.Visible = true;

                        textBoxes[textBoxes.Count - 1].Location = new Point(usableSpace * (i + 1), 200);
                    }
                    
                    foreach (TextBox txtBox in textBoxes)
                    {
                        Controls.Add(txtBox);
                    }
                }
                
                // get out of loop
                break;
            }
        }
        public void ShowPhysics()
        {
            PhysicsFormulary.PotentialEnergy potential = new PhysicsFormulary.PotentialEnergy();
            PhysicsFormulary physicsFormulary = new PhysicsFormulary();

            // loop through all formulas in the MathFormulary
            foreach (BaseFormula formula in physicsFormulary.formulas)
            {
                // if the current formula is the one selected
                if (formula.Name == funcList.SelectedNode.Text)
                {
                    
                    // set the current formula as the currentFormula or the selected formula
                    currentFormula = formula;
                    potential.Shared();
                    
                    
                }
                // get out of loop
                break;
            }
        }

        // when selecting a formula from the tree view
        private void funcList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            

            MathFormulary math = new MathFormulary();
                PhysicsFormulary physicsFormulary = new PhysicsFormulary();

            Print("checks " + e.Node.Text);
            foreach (BaseFormula formula in math.formulas)
            {
                if (formula.Name == e.Node.Text)
                {
                    Print("found");
                    BaseFormulary.TextboxPlacement(formula.VarCount, this);
                    break;
                }
            }
            /*
            if (e.Node.Name == "matematik")
            {
                Print("Matematik");
                ShowMath();
            }
            else if (funcList.Parent.Name.Equals(physicsFormulary.treeNode.Name))
            {
                ShowPhysics();
            }
            */
            
        }

        

        // when calculate button is hit
        private void Calc_Click(object sender, EventArgs e)
        {
            // if a formula is selected
            if (currentFormula != null)
            {
                // get variable from field 1
                var varValue = Convert.ToDouble(textBoxes[0].Text);
                
                // get current formula as formula2var to access certain functions
                Formula1var formul = currentFormula as Formula1var;

                // write result in result label
                Result.Text = formul.Function(varValue).ToString();
                
                // sanity check
                Console.WriteLine(formul.Function(varValue));
            }
        }
    }
}

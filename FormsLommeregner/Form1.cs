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
            //funcList.autoSize = true;
            Variables.Visible = false; Var2.Visible = false; Var1.Visible = false;
            TextBox text = new TextBox();
            Controls.Add(text);
            text.Location = new Point(600, 100);
            //text.Size = new Size(100, 100);
            //text.Text = "Hej";
            text.Visible = true;
            //text.Focus();



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
           // AllocConsole();
            


        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


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

                    List<TextBox> textBoxes = new List<TextBox>();
                    for (int i = 0; i < formula.VarCount; i++)
                    {
                        textBoxes.Add(new TextBox());
                        int usableSpace = 656 / (formula.VarCount + 1);

                        TextBox text = new TextBox();
                        //text.Location = new Point(100, 100);
                        Formelsamling form1 = new Formelsamling();
                        form1.Controls.Add(text);
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

                    List<TextBox> textBoxes = new List<TextBox>();
                    for (int i = 0; i < formula.VarCount; i++)
                    {
                        textBoxes.Add(new TextBox());
                        int usableSpace = 656 / (formula.VarCount + 1);

                        TextBox text = new TextBox();
                        //text.Location = new Point(100, 100);
                        Formelsamling form1 = new Formelsamling();
                        form1.Controls.Add(text);
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
        // when selecting a formula from the tree view
        private void funcList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MathFormulary math = new MathFormulary();
            PhysicsFormulary physicsFormulary = new PhysicsFormulary();
            if (funcList.Parent.Equals(math.treeNode))
            {
                ShowMath();
            }
            else if (funcList.Parent.Equals(physicsFormulary.treeNode))
            {
                ShowPhysics();
            }

        }

        // when calculate button is hit
        private void Calc_Click(object sender, EventArgs e)
        {
            // if a formula is selected
            if (currentFormula != null)
            {
                // get variable from field 1
                var varName = Convert.ToDouble(Var1.Text);
                
                // get current formula as formula2var to access certain functions
                Formula2var formul = currentFormula as Formula2var;

                // write result in result label
                Result.Text = formul.Function(varName).ToString();
                
                // sanity check
                Console.WriteLine(formul.Function(varName));
            }
        }
    }
}

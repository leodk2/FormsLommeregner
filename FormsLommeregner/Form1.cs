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
    public partial class Form1 : Form
    {
        public BaseFormula currentFormula;

        public Form1()
        {
            InitializeComponent();
            //funcList.autoSize = true;
            Variables.Visible = false; Var2.Visible = false; Var1.Visible = false;
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

        // when selecting a formula from the tree view
        private void funcList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // get mathformulary
            MathFormulary mathFormulary = new MathFormulary();

            // loop through all formulas in the MathFormulary
            foreach (BaseFormula formula in mathFormulary.formulas)
            {
                // if the current formula is the one selected
                if (formula.Name == funcList.SelectedNode.Text)
                {
                    // set the current formula as the currentFormula or the selected formula
                    currentFormula = formula;
                    
                    // get type of current formula, and do stuff based on the type
                    if (currentFormula.GetType() == typeof(Formula2var))
                    {
                        // do 2 var stuff
                        Var1.Visible = true;
                    }
                    else if (currentFormula.GetType() == typeof(Formular3var))
                    {
                        Var1.Visible = true; Var2.Visible = true;

                    }
                    
                    // get out of loop
                    break;
                }
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

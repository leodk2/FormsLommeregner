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
        public Form1()
        {
            InitializeComponent();
            //funcList.autoSize = true;
            
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

        private void funcList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Console.Write("1");
            Console.Write(Environment.NewLine);

            MathFormulary mathFormulary = new MathFormulary();
            Console.Write("2");
            Console.Write(Environment.NewLine);

            foreach (MathFormulary formula in mathFormulary.formulars)
            {
                Console.Write("3");
                Console.Write(Environment.NewLine);
                if (formula.Name == funcList.SelectedNode.Text)
                {

                    Console.Write("yeet");
                    Console.Write(Environment.NewLine);
                    //setupFields(formula);
                    break;
                }
            }

        }

        public void setupFields(MathFormulary formula)
        {
            int i = 0;
        }
    }
}

﻿using System;
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

        private void funcList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MathFormulary mathFormulary = new MathFormulary();

            foreach (BaseFormula formula in mathFormulary.formulas)
            {
                if (formula.Name == funcList.SelectedNode.Text)
                {
                    currentFormula = formula;
                    break;
                }
            }

        }

        public void setupFields(MathFormulary formula)
        {
            
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            if (currentFormula != null)
            {
                var varName = Convert.ToDouble(Var1.Text);
                Formula2var formul = currentFormula as Formula2var;
                Console.WriteLine(formul.Function(varName));
            }
        }
    }
}

﻿using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FormsLommeregner
{

    public class Constants
    {
        // math
        public const double pi = PI;
        public const double tau = 2 * pi;

        // physics
        public const double gAcc = 9.82;
    }

    public struct Baseformula
    {
        public string subject;
        public string name;
        public string description;
        public int varCount;
    }
    public abstract class BaseFormulary
    {
        public BaseFormulary()
        {

        }
        public static void TextboxPlacement(int VarCount, Form form1)
        {
            List<TextBox> textBoxes = new List<TextBox>();
            for (int i = 0; i < VarCount; i++)
            {
                textBoxes.Add(new TextBox());
                int usableSpace = 656 / (VarCount + 1);

                if (i == 0)
                {
                    TextBox text = new TextBox();
                    text.Location = new Point(100, 100);
                    text.Size = new Size(100, 50);
                    //Formelsamling form1 = new Formelsamling();
                    form1.Controls.Add(text);
                    text.Visible = true;
                    
                    textBoxes[textBoxes.Count-1].Location = new Point(usableSpace * (i + 1));
                }
                else
                {
                    textBoxes[textBoxes.Count-1].Location = new Point(usableSpace * i);
                }
            }
        }

    }

    public abstract class BaseFormula
    {
        // name of formular
        public abstract string Name { get; }
        public abstract int VarCount { get; }

    }

    // formular class for 2 unknown variables
    public abstract class Formula1var : BaseFormula
    {
        public int pixel = 656;
        public abstract void Shared();
        public abstract string[] VarName { get; }
        public override int VarCount { get { return 2; } }
        //the number of pixels for the space betweem the form or the treeview and the other side of the parent form is 656 pixeles. 
        //this WILL change if you change the size of the form or the place of the treeview
        

        
        // description of formular
        public abstract string Description { get; }

        // function to find main unknown variable
        public abstract double Function(double a);
        // function to find the second variable
        public abstract double FunctionTwo(double a);
    }
    
    // formular class for 2 unknown variables
    public abstract class Formular2var : BaseFormula
    {
        public abstract string[] VarName { get; } 
        const double pi = PI;
        const double tau = 2 * PI;

        public int varCount = 3;
        // description of formular
        public abstract string Description { get; }
        public abstract void Shared();

        // function to find main unknown variable
        public abstract double Function(double a, double b);
        // function to find the second variable
        public abstract double FunctionTwo(double a, double b);
        // function to find the third variable
        public abstract double FunctionThree(double a, double b);
    }

}

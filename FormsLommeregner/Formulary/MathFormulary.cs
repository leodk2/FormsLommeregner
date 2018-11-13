using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsLommeregner.Formulary.FormulaInterfaces;

namespace FormsLommeregner.Formulary.MathFormulary
{
    class CircleCircumference : IBaseFormula, IFormula2var
    {
        public string FormulaName { get { return "Cirkel omkreds"; } }
        public int VarCount { get { return 2; } }
        public List<string> Variables { get { return new List<string>() { "Radius", "Omkreds" }; } }

        public string var1Name { get { return "Radius"; } }
        public string var2Name { get { return "Omkreds"; } }

        // finds circumference
        public double equation1(double radius)
        {
            return radius; // WIP
        }
        // finds radius
        public double equation2(double circumference)
        {
            return circumference; // WIP
        }
    }
    
}

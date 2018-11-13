using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLommeregner.Formulary.FormulaInterfaces
{
    public interface IBaseFormula
    {
        string FormulaName { get; }
        int VarCount { get; }
        List<string> Variables { get; }
    }

    public interface IFormula2var
    {
        string var1Name { get; }
        string var2Name { get; }

        double equation1(double n);
        double equation2(double n);
    }

    interface IFormula3var
    {
        string var1Name { get; }
        string var2Name { get; }
        string var3Name { get; }

        double equation1(double n, double m);
        double equation2(double n, double m);
    }
}

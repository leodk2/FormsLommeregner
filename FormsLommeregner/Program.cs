using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormsLommeregner
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            Login login = new Login();
            InternetAndSecurity internetAndSecurity = new InternetAndSecurity();
            internetAndSecurity.Run();
                
            TreeNode[] treeNodes = new TreeNode[] { new MathFormulary().treeNode, new PhysicsFormulary().treeNode, };
            form.funcList.Nodes.AddRange(treeNodes);

            Application.Run(form);

        }
    }
}

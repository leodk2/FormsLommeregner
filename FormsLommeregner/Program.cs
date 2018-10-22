using System;
using System.Collections;
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


            //Form1 form = new Form1();
            //Login login = new Login();
            InternetAndSecurity internetAndSecurity = new InternetAndSecurity();
            internetAndSecurity.Run();

            if (internetAndSecurity.SqlReader("Uid", "kim@strandjaegervej.dk", "Code1", internetAndSecurity.sqlConnection))
            {
                Form1 form = new Form1();
                TreeNode[] treeNodes = new TreeNode[] { new MathFormulary().treeNode, new PhysicsFormulary().treeNode, };
                form.funcList.Nodes.AddRange(treeNodes);
                Application.Run(form);
            }
            else
            {
                Login login = new Login();
                Application.Run(login);
            }
                

            



            /*
            switch (form.funcList.SelectedNode.ToString())
            {
                case "cirkelomkreds":

                    break;


            }*/






















            

        }
    }
}

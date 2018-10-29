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
        static void Print(string a)
        {
            Console.WriteLine(a);
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //Form1 form = new Form1();
            //Login login = new Login();
            
            InternetAndSecurity internet = new InternetAndSecurity();
            internet.Run();

            SQL.SqlConnect();
            
           
           
                
           
           
            Login login = new Login();
            Formelsamling form = new Formelsamling();
            TreeNode[] treeNodes = new TreeNode[] { new MathFormulary().treeNode, new PhysicsFormulary().treeNode, };
            form.funcList.Nodes.AddRange(treeNodes);
            Application.Run(login);
            string email = login.EmailField.Text.ToLower();
            if (SQL.SqlReader(email, email, "Mac", SQL.sqlConnection))
            {
                Print("yeet");
            }
            else
            {
                Print("no yeet");
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

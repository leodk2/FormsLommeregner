using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLommeregner
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InternetAndSecurity.SqlReader("Uid", EmailField.Text, "Code1", InternetAndSecurity.sqlConnection))
            {
                this.Hide();
                Formelsamling formelsamling = new Formelsamling();
                TreeNode[] treeNodes = new TreeNode[] { new MathFormulary().treeNode, new PhysicsFormulary().treeNode, };
                formelsamling.funcList.Nodes.AddRange(treeNodes);
                formelsamling.Show();
                Console.WriteLine("did this");


            }
        }
    }
}

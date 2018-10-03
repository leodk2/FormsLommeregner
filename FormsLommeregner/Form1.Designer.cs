namespace FormsLommeregner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Var1 = new System.Windows.Forms.Label();
            this.Var2 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(113, 425);
            this.treeView1.TabIndex = 0;
            // 
            // Var1
            // 
            this.Var1.AutoSize = true;
            this.Var1.Location = new System.Drawing.Point(218, 189);
            this.Var1.Name = "Var1";
            this.Var1.Size = new System.Drawing.Size(29, 13);
            this.Var1.TabIndex = 1;
            this.Var1.Text = "Var1";
            // 
            // Var2
            // 
            this.Var2.AutoSize = true;
            this.Var2.Location = new System.Drawing.Point(309, 189);
            this.Var2.Name = "Var2";
            this.Var2.Size = new System.Drawing.Size(29, 13);
            this.Var2.TabIndex = 2;
            this.Var2.Text = "Var2";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(383, 219);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(37, 13);
            this.Result.TabIndex = 3;
            this.Result.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Var2);
            this.Controls.Add(this.Var1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label Var1;
        private System.Windows.Forms.Label Var2;
        private System.Windows.Forms.Label Result;
    }
}


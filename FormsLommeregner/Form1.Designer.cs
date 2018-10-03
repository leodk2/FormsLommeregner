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
            this.Result = new System.Windows.Forms.Label();
            this.FuncName = new System.Windows.Forms.Label();
            this.var1 = new System.Windows.Forms.Label();
            this.var2 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(113, 425);
            this.treeView1.TabIndex = 0;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Cambria Math", 20F);
            this.Result.Location = new System.Drawing.Point(132, 248);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(137, 151);
            this.Result.TabIndex = 3;
            this.Result.Text = "Result";
            // 
            // FuncName
            // 
            this.FuncName.AutoSize = true;
            this.FuncName.Font = new System.Drawing.Font("Cambria Math", 25F);
            this.FuncName.Location = new System.Drawing.Point(297, 9);
            this.FuncName.Name = "FuncName";
            this.FuncName.Size = new System.Drawing.Size(209, 190);
            this.FuncName.TabIndex = 4;
            this.FuncName.Text = "Function";
            // 
            // var1
            // 
            this.var1.AutoSize = true;
            this.var1.Font = new System.Drawing.Font("Cambria Math", 20F);
            this.var1.Location = new System.Drawing.Point(132, 116);
            this.var1.Name = "var1";
            this.var1.Size = new System.Drawing.Size(117, 151);
            this.var1.TabIndex = 5;
            this.var1.Text = "Var1";
            // 
            // var2
            // 
            this.var2.AutoSize = true;
            this.var2.Font = new System.Drawing.Font("Cambria Math", 20F);
            this.var2.Location = new System.Drawing.Point(540, 116);
            this.var2.Name = "var2";
            this.var2.Size = new System.Drawing.Size(117, 151);
            this.var2.TabIndex = 6;
            this.var2.Text = "Var2";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(566, 327);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(61, 13);
            this.Description.TabIndex = 7;
            this.Description.Text = "Beskrivelse";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.var2);
            this.Controls.Add(this.var1);
            this.Controls.Add(this.FuncName);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label FuncName;
        private System.Windows.Forms.Label var1;
        private System.Windows.Forms.Label var2;
        private System.Windows.Forms.Label Description;
    }
}


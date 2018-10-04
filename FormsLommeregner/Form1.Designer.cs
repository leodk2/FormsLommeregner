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
            this.funcList = new System.Windows.Forms.TreeView();
            this.Result = new System.Windows.Forms.Label();
            this.FuncName = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Var1 = new System.Windows.Forms.TextBox();
            this.Var2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // funcList
            // 
            this.funcList.Location = new System.Drawing.Point(13, 13);
            this.funcList.Name = "funcList";
            this.funcList.Size = new System.Drawing.Size(148, 425);
            this.funcList.TabIndex = 0;
            this.funcList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.funcList_AfterSelect);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Cambria Math", 20F);
            this.Result.Location = new System.Drawing.Point(197, 254);
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
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(566, 327);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(61, 13);
            this.Description.TabIndex = 7;
            this.Description.Text = "Beskrivelse";
            // 
            // Var1
            // 
            this.Var1.Location = new System.Drawing.Point(223, 199);
            this.Var1.Name = "Var1";
            this.Var1.Size = new System.Drawing.Size(100, 20);
            this.Var1.TabIndex = 8;
            // 
            // Var2
            // 
            this.Var2.Location = new System.Drawing.Point(527, 199);
            this.Var2.Name = "Var2";
            this.Var2.Size = new System.Drawing.Size(100, 20);
            this.Var2.TabIndex = 9;
            this.Var2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Var2);
            this.Controls.Add(this.Var1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.FuncName);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.funcList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label FuncName;
        public System.Windows.Forms.TreeView funcList;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox Var1;
        private System.Windows.Forms.TextBox Var2;
    }
}


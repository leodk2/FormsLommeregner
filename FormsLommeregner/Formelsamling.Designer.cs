﻿namespace FormsLommeregner
{
    partial class Formelsamling
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
            this.Calc = new System.Windows.Forms.Button();
            this.Variables = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // funcList
            // 
            this.funcList.Location = new System.Drawing.Point(12, 14);
            this.funcList.Name = "funcList";
            this.funcList.Size = new System.Drawing.Size(148, 425);
            this.funcList.TabIndex = 0;
            this.funcList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.funcList_AfterSelect);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Cambria Math", 20F);
            this.Result.Location = new System.Drawing.Point(345, 287);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(137, 151);
            this.Result.TabIndex = 3;
            this.Result.Text = "Result";
            // 
            // FuncName
            // 
            this.FuncName.AutoSize = true;
            this.FuncName.Font = new System.Drawing.Font("Cambria Math", 25F);
            this.FuncName.Location = new System.Drawing.Point(329, 9);
            this.FuncName.Name = "FuncName";
            this.FuncName.Size = new System.Drawing.Size(209, 190);
            this.FuncName.TabIndex = 4;
            this.FuncName.Text = "Function";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Cambria Math", 20F);
            this.Description.Location = new System.Drawing.Point(551, 249);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(196, 151);
            this.Description.TabIndex = 7;
            this.Description.Text = "Beskrivelse";
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(382, 299);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(75, 23);
            this.Calc.TabIndex = 10;
            this.Calc.Text = "Beregn";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // Variables
            // 
            this.Variables.FormattingEnabled = true;
            this.Variables.Location = new System.Drawing.Point(168, 287);
            this.Variables.Name = "Variables";
            this.Variables.Size = new System.Drawing.Size(121, 21);
            this.Variables.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // Formelsamling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Variables);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.FuncName);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.funcList);
            this.Name = "Formelsamling";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Result;
        public System.Windows.Forms.TreeView funcList;
        private System.Windows.Forms.Button Calc;
        public System.Windows.Forms.Label FuncName;
        public System.Windows.Forms.Label Description;
        public System.Windows.Forms.ComboBox Variables;
        private System.Windows.Forms.TextBox textBox1;
    }
}


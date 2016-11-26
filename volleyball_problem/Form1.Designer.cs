namespace volleyball_problem
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
            this.InputA = new System.Windows.Forms.TextBox();
            this.InputB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.InputC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputA
            // 
            this.InputA.Location = new System.Drawing.Point(73, 21);
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(100, 20);
            this.InputA.TabIndex = 0;
            this.InputA.TextChanged += new System.EventHandler(this.NumOnlyA);
            // 
            // InputB
            // 
            this.InputB.Location = new System.Drawing.Point(73, 47);
            this.InputB.Name = "InputB";
            this.InputB.Size = new System.Drawing.Size(100, 20);
            this.InputB.TabIndex = 1;
            this.InputB.TextChanged += new System.EventHandler(this.NumOnlyB);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nilai A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nilai B";
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(73, 73);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(100, 30);
            this.Btn.TabIndex = 4;
            this.Btn.Text = "Confirm";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            // 
            // InputC
            // 
            this.InputC.Enabled = false;
            this.InputC.Location = new System.Drawing.Point(73, 114);
            this.InputC.Name = "InputC";
            this.InputC.ReadOnly = true;
            this.InputC.Size = new System.Drawing.Size(100, 20);
            this.InputC.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 155);
            this.Controls.Add(this.InputC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputB);
            this.Controls.Add(this.InputA);
            this.Name = "Form1";
            this.Text = "VolleyBall Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputA;
        private System.Windows.Forms.TextBox InputB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputC;
    }
}


namespace Latihan_2_1
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
            this.MC1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UD2 = new System.Windows.Forms.DomainUpDown();
            this.UD1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.UD1)).BeginInit();
            this.SuspendLayout();
            // 
            // MC1
            // 
            this.MC1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.MC1.FirstDayOfWeek = System.Windows.Forms.Day.Saturday;
            this.MC1.Location = new System.Drawing.Point(18, 114);
            this.MC1.MaxSelectionCount = 3;
            this.MC1.Name = "MC1";
            this.MC1.TabIndex = 0;
            this.MC1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.ChangeBold);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(211, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bold";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Change);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 58);
            this.button2.TabIndex = 4;
            this.button2.Text = "Un-Bold";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Reset);
            // 
            // UD2
            // 
            this.UD2.Items.Add("January");
            this.UD2.Items.Add("February");
            this.UD2.Items.Add("March");
            this.UD2.Items.Add("April");
            this.UD2.Items.Add("May");
            this.UD2.Items.Add("June");
            this.UD2.Items.Add("July");
            this.UD2.Items.Add("August");
            this.UD2.Items.Add("September");
            this.UD2.Items.Add("October");
            this.UD2.Items.Add("November");
            this.UD2.Items.Add("December");
            this.UD2.Location = new System.Drawing.Point(38, 82);
            this.UD2.Name = "UD2";
            this.UD2.Size = new System.Drawing.Size(120, 20);
            this.UD2.TabIndex = 6;
            this.UD2.Text = "Month";
            this.UD2.SelectedItemChanged += new System.EventHandler(this.MonthChange);
            // 
            // UD1
            // 
            this.UD1.Location = new System.Drawing.Point(38, 44);
            this.UD1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.UD1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UD1.Name = "UD1";
            this.UD1.Size = new System.Drawing.Size(120, 20);
            this.UD1.TabIndex = 7;
            this.UD1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 443);
            this.Controls.Add(this.UD1);
            this.Controls.Add(this.UD2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MC1);
            this.Name = "Form1";
            this.Text = "Latihan_2_1";
            ((System.ComponentModel.ISupportInitialize)(this.UD1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar MC1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DomainUpDown UD2;
        private System.Windows.Forms.NumericUpDown UD1;
    }
}


namespace Latihan_1_1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Value2 = new System.Windows.Forms.Label();
            this.Value1 = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.Label();
            this.Scroll1 = new System.Windows.Forms.HScrollBar();
            this.Min = new System.Windows.Forms.Label();
            this.Scroll2 = new System.Windows.Forms.HScrollBar();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MinTahun = new System.Windows.Forms.Label();
            this.MaxTahun = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(260, 237);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MaxTahun);
            this.tabPage1.Controls.Add(this.MinTahun);
            this.tabPage1.Controls.Add(this.Value2);
            this.tabPage1.Controls.Add(this.Value1);
            this.tabPage1.Controls.Add(this.Max);
            this.tabPage1.Controls.Add(this.Scroll1);
            this.tabPage1.Controls.Add(this.Min);
            this.tabPage1.Controls.Add(this.Scroll2);
            this.tabPage1.Controls.Add(this.Date);
            this.tabPage1.ImageKey = "200 (1).gif";
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(252, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Value2
            // 
            this.Value2.AutoSize = true;
            this.Value2.Location = new System.Drawing.Point(6, 167);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(90, 13);
            this.Value2.TabIndex = 6;
            this.Value2.Text = "Value Scroll 2 = 0";
            // 
            // Value1
            // 
            this.Value1.AutoSize = true;
            this.Value1.Location = new System.Drawing.Point(6, 111);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(90, 13);
            this.Value1.TabIndex = 5;
            this.Value1.Text = "Value Scroll 1 = 0";
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Location = new System.Drawing.Point(163, 79);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(45, 13);
            this.Max.TabIndex = 4;
            this.Max.Text = "Max = 0";
            // 
            // Scroll1
            // 
            this.Scroll1.LargeChange = 1;
            this.Scroll1.Location = new System.Drawing.Point(3, 137);
            this.Scroll1.Name = "Scroll1";
            this.Scroll1.Size = new System.Drawing.Size(243, 17);
            this.Scroll1.TabIndex = 3;
            this.Scroll1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Change_1);
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Location = new System.Drawing.Point(39, 79);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(42, 13);
            this.Min.TabIndex = 2;
            this.Min.Text = "Min = 0";
            // 
            // Scroll2
            // 
            this.Scroll2.LargeChange = 1;
            this.Scroll2.Location = new System.Drawing.Point(3, 191);
            this.Scroll2.Name = "Scroll2";
            this.Scroll2.Size = new System.Drawing.Size(243, 17);
            this.Scroll2.TabIndex = 1;
            this.Scroll2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Change_2);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(3, 37);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(243, 20);
            this.Date.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.ImageKey = "200 (2).gif";
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(252, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "200 (1).gif");
            this.imageList1.Images.SetKeyName(1, "200 (2).gif");
            // 
            // MinTahun
            // 
            this.MinTahun.AutoSize = true;
            this.MinTahun.Location = new System.Drawing.Point(15, 12);
            this.MinTahun.Name = "MinTahun";
            this.MinTahun.Size = new System.Drawing.Size(94, 13);
            this.MinTahun.TabIndex = 7;
            this.MinTahun.Text = "Min Tahun = 2016";
            // 
            // MaxTahun
            // 
            this.MaxTahun.AutoSize = true;
            this.MaxTahun.Location = new System.Drawing.Point(137, 12);
            this.MaxTahun.Name = "MaxTahun";
            this.MaxTahun.Size = new System.Drawing.Size(97, 13);
            this.MaxTahun.TabIndex = 8;
            this.MaxTahun.Text = "Max Tahun = 2016";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.HScrollBar Scroll2;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label Value2;
        private System.Windows.Forms.Label Value1;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.HScrollBar Scroll1;
        private System.Windows.Forms.Label MaxTahun;
        private System.Windows.Forms.Label MinTahun;
    }
}


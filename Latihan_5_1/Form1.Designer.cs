namespace Latihan_5_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.CD1 = new System.Windows.Forms.ColorDialog();
            this.FD1 = new System.Windows.Forms.FontDialog();
            this.TS1 = new System.Windows.Forms.ToolStrip();
            this.TS_CBS = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_B = new System.Windows.Forms.ToolStripButton();
            this.TS_I = new System.Windows.Forms.ToolStripButton();
            this.TS_U = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_CBF = new System.Windows.Forms.ToolStripComboBox();
            this.TS_CBC = new System.Windows.Forms.ToolStripComboBox();
            this.IL1 = new System.Windows.Forms.ImageList(this.components);
            this.MS1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.RTB1 = new System.Windows.Forms.RichTextBox();
            this.Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.TS1.SuspendLayout();
            this.MS1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TS1
            // 
            this.TS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_CBS,
            this.toolStripSeparator2,
            this.TS_B,
            this.TS_I,
            this.TS_U,
            this.toolStripSeparator1,
            this.TS_CBF,
            this.TS_CBC});
            this.TS1.Location = new System.Drawing.Point(0, 24);
            this.TS1.Name = "TS1";
            this.TS1.Size = new System.Drawing.Size(391, 25);
            this.TS1.Stretch = true;
            this.TS1.TabIndex = 3;
            this.TS1.Text = "Tools";
            // 
            // TS_CBS
            // 
            this.TS_CBS.AutoCompleteCustomSource.AddRange(new string[] {
            "6",
            "7",
            "8",
            "10",
            "12",
            "14",
            "16",
            "32",
            "48",
            "84",
            "72"});
            this.TS_CBS.AutoSize = false;
            this.TS_CBS.Items.AddRange(new object[] {
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "24",
            "28",
            "32",
            "36",
            "48",
            "64",
            "72"});
            this.TS_CBS.Name = "TS_CBS";
            this.TS_CBS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TS_CBS.Size = new System.Drawing.Size(50, 23);
            this.TS_CBS.SelectedIndexChanged += new System.EventHandler(this.FontSize);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TS_B
            // 
            this.TS_B.AutoSize = false;
            this.TS_B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TS_B.CheckOnClick = true;
            this.TS_B.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TS_B.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_B.Image = ((System.Drawing.Image)(resources.GetObject("TS_B.Image")));
            this.TS_B.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.TS_B.Name = "TS_B";
            this.TS_B.Size = new System.Drawing.Size(23, 22);
            this.TS_B.Text = "B";
            this.TS_B.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.TS_B.ToolTipText = "Bold";
            this.TS_B.Click += new System.EventHandler(this.Bold);
            // 
            // TS_I
            // 
            this.TS_I.AutoSize = false;
            this.TS_I.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TS_I.CheckOnClick = true;
            this.TS_I.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TS_I.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_I.Image = ((System.Drawing.Image)(resources.GetObject("TS_I.Image")));
            this.TS_I.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.TS_I.Name = "TS_I";
            this.TS_I.Size = new System.Drawing.Size(23, 22);
            this.TS_I.Text = "I";
            this.TS_I.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.TS_I.ToolTipText = "Italic";
            this.TS_I.Click += new System.EventHandler(this.Italic);
            // 
            // TS_U
            // 
            this.TS_U.AutoSize = false;
            this.TS_U.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TS_U.CheckOnClick = true;
            this.TS_U.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TS_U.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_U.Image = ((System.Drawing.Image)(resources.GetObject("TS_U.Image")));
            this.TS_U.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.TS_U.Name = "TS_U";
            this.TS_U.Size = new System.Drawing.Size(23, 22);
            this.TS_U.Text = "U";
            this.TS_U.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.TS_U.Click += new System.EventHandler(this.Underline);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TS_CBF
            // 
            this.TS_CBF.Name = "TS_CBF";
            this.TS_CBF.Size = new System.Drawing.Size(121, 25);
            this.TS_CBF.SelectedIndexChanged += new System.EventHandler(this.FontName);
            // 
            // TS_CBC
            // 
            this.TS_CBC.Name = "TS_CBC";
            this.TS_CBC.Size = new System.Drawing.Size(121, 25);
            this.TS_CBC.SelectedIndexChanged += new System.EventHandler(this.FontColor);
            // 
            // IL1
            // 
            this.IL1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.IL1.ImageSize = new System.Drawing.Size(16, 16);
            this.IL1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MS1
            // 
            this.MS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.Setting});
            this.MS1.Location = new System.Drawing.Point(0, 0);
            this.MS1.Name = "MS1";
            this.MS1.Size = new System.Drawing.Size(391, 24);
            this.MS1.TabIndex = 5;
            this.MS1.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Open,
            this.Save,
            this.Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(152, 22);
            this.New.Text = "&New";
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(152, 22);
            this.Open.Text = "&Open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(152, 22);
            this.Save.Text = "&Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(152, 22);
            this.Exit.Text = "&Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // RTB1
            // 
            this.RTB1.AutoWordSelection = true;
            this.RTB1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.RTB1.Location = new System.Drawing.Point(0, 52);
            this.RTB1.Name = "RTB1";
            this.RTB1.Size = new System.Drawing.Size(391, 233);
            this.RTB1.TabIndex = 6;
            this.RTB1.Text = "";
            this.RTB1.TextChanged += new System.EventHandler(this.Check_Text);
            // 
            // Setting
            // 
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(61, 20);
            this.Setting.Text = "&Settings";
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 284);
            this.Controls.Add(this.RTB1);
            this.Controls.Add(this.TS1);
            this.Controls.Add(this.MS1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.MS1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TS1.ResumeLayout(false);
            this.TS1.PerformLayout();
            this.MS1.ResumeLayout(false);
            this.MS1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog CD1;
        private System.Windows.Forms.FontDialog FD1;
        private System.Windows.Forms.ToolStrip TS1;
        private System.Windows.Forms.ToolStripButton TS_U;
        private System.Windows.Forms.ToolStripButton TS_B;
        private System.Windows.Forms.ToolStripButton TS_I;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox TS_CBF;
        private System.Windows.Forms.ImageList IL1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox TS_CBC;
        private System.Windows.Forms.ToolStripComboBox TS_CBS;
        private System.Windows.Forms.MenuStrip MS1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.RichTextBox RTB1;
        private System.Windows.Forms.ToolStripMenuItem Setting;
    }
}


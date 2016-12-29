namespace DBS_POS
{
    partial class Registrasi
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
            this.RegClose = new System.Windows.Forms.Button();
            this.RegJudul = new System.Windows.Forms.Label();
            this.RegDate = new System.Windows.Forms.Label();
            this.RegData1 = new System.Windows.Forms.Label();
            this.RegData2 = new System.Windows.Forms.Label();
            this.RegData3 = new System.Windows.Forms.Label();
            this.RegGrid = new System.Windows.Forms.DataGridView();
            this.RegData4 = new System.Windows.Forms.Label();
            this.RegData5 = new System.Windows.Forms.Label();
            this.RegInput1 = new System.Windows.Forms.TextBox();
            this.RegInput2 = new System.Windows.Forms.TextBox();
            this.RegInput5 = new System.Windows.Forms.TextBox();
            this.RegInput4 = new System.Windows.Forms.TextBox();
            this.RegInput3 = new System.Windows.Forms.TextBox();
            this.RegInput9 = new System.Windows.Forms.TextBox();
            this.RegInput8 = new System.Windows.Forms.TextBox();
            this.RegInput7 = new System.Windows.Forms.TextBox();
            this.RegInput6 = new System.Windows.Forms.TextBox();
            this.RegData9 = new System.Windows.Forms.Label();
            this.RegData8 = new System.Windows.Forms.Label();
            this.RegData7 = new System.Windows.Forms.Label();
            this.RegData6 = new System.Windows.Forms.Label();
            this.RegBtnSave = new System.Windows.Forms.Button();
            this.RegBtnCan = new System.Windows.Forms.Button();
            this.RegBtnDel = new System.Windows.Forms.Button();
            this.RegBtnExit = new System.Windows.Forms.Button();
            this.RegInputDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.RegGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RegClose
            // 
            this.RegClose.Location = new System.Drawing.Point(650, 0);
            this.RegClose.Name = "RegClose";
            this.RegClose.Size = new System.Drawing.Size(30, 30);
            this.RegClose.TabIndex = 26;
            this.RegClose.Text = "X";
            this.RegClose.UseVisualStyleBackColor = true;
            this.RegClose.Click += new System.EventHandler(this.RegTutup);
            // 
            // RegJudul
            // 
            this.RegJudul.AutoSize = true;
            this.RegJudul.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.RegJudul.Location = new System.Drawing.Point(10, 10);
            this.RegJudul.Name = "RegJudul";
            this.RegJudul.Size = new System.Drawing.Size(72, 27);
            this.RegJudul.TabIndex = 0;
            this.RegJudul.Text = "Judul";
            this.RegJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegDate
            // 
            this.RegDate.AutoSize = true;
            this.RegDate.Location = new System.Drawing.Point(30, 70);
            this.RegDate.Name = "RegDate";
            this.RegDate.Size = new System.Drawing.Size(51, 15);
            this.RegDate.TabIndex = 1;
            this.RegDate.Text = "Tanggal";
            this.RegDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegData1
            // 
            this.RegData1.AutoSize = true;
            this.RegData1.Location = new System.Drawing.Point(30, 100);
            this.RegData1.Name = "RegData1";
            this.RegData1.Size = new System.Drawing.Size(40, 15);
            this.RegData1.TabIndex = 3;
            this.RegData1.Text = "Data1";
            this.RegData1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegData2
            // 
            this.RegData2.AutoSize = true;
            this.RegData2.Location = new System.Drawing.Point(30, 130);
            this.RegData2.Name = "RegData2";
            this.RegData2.Size = new System.Drawing.Size(40, 15);
            this.RegData2.TabIndex = 5;
            this.RegData2.Text = "Data2";
            this.RegData2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegData3
            // 
            this.RegData3.AutoSize = true;
            this.RegData3.Location = new System.Drawing.Point(30, 160);
            this.RegData3.Name = "RegData3";
            this.RegData3.Size = new System.Drawing.Size(40, 15);
            this.RegData3.TabIndex = 7;
            this.RegData3.Text = "Data3";
            this.RegData3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegGrid
            // 
            this.RegGrid.AllowUserToAddRows = false;
            this.RegGrid.AllowUserToDeleteRows = false;
            this.RegGrid.AllowUserToOrderColumns = true;
            this.RegGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegGrid.Location = new System.Drawing.Point(12, 244);
            this.RegGrid.Name = "RegGrid";
            this.RegGrid.ReadOnly = true;
            this.RegGrid.RowHeadersVisible = false;
            this.RegGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RegGrid.Size = new System.Drawing.Size(656, 224);
            this.RegGrid.TabIndex = 25;
            // 
            // RegData4
            // 
            this.RegData4.AutoSize = true;
            this.RegData4.Location = new System.Drawing.Point(30, 190);
            this.RegData4.Name = "RegData4";
            this.RegData4.Size = new System.Drawing.Size(40, 15);
            this.RegData4.TabIndex = 9;
            this.RegData4.Text = "Data4";
            this.RegData4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegData5
            // 
            this.RegData5.AutoSize = true;
            this.RegData5.Location = new System.Drawing.Point(30, 220);
            this.RegData5.Name = "RegData5";
            this.RegData5.Size = new System.Drawing.Size(40, 15);
            this.RegData5.TabIndex = 11;
            this.RegData5.Text = "Data5";
            this.RegData5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegInput1
            // 
            this.RegInput1.Location = new System.Drawing.Point(150, 97);
            this.RegInput1.MaxLength = 30;
            this.RegInput1.Name = "RegInput1";
            this.RegInput1.Size = new System.Drawing.Size(150, 21);
            this.RegInput1.TabIndex = 4;
            this.RegInput1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegKey);
            // 
            // RegInput2
            // 
            this.RegInput2.Location = new System.Drawing.Point(150, 127);
            this.RegInput2.MaxLength = 60;
            this.RegInput2.Name = "RegInput2";
            this.RegInput2.Size = new System.Drawing.Size(150, 21);
            this.RegInput2.TabIndex = 6;
            // 
            // RegInput5
            // 
            this.RegInput5.Location = new System.Drawing.Point(150, 217);
            this.RegInput5.MaxLength = 30;
            this.RegInput5.Name = "RegInput5";
            this.RegInput5.Size = new System.Drawing.Size(150, 21);
            this.RegInput5.TabIndex = 12;
            // 
            // RegInput4
            // 
            this.RegInput4.Location = new System.Drawing.Point(150, 187);
            this.RegInput4.MaxLength = 30;
            this.RegInput4.Name = "RegInput4";
            this.RegInput4.Size = new System.Drawing.Size(150, 21);
            this.RegInput4.TabIndex = 10;
            // 
            // RegInput3
            // 
            this.RegInput3.Location = new System.Drawing.Point(150, 157);
            this.RegInput3.MaxLength = 30;
            this.RegInput3.Name = "RegInput3";
            this.RegInput3.Size = new System.Drawing.Size(150, 21);
            this.RegInput3.TabIndex = 8;
            // 
            // RegInput9
            // 
            this.RegInput9.Location = new System.Drawing.Point(452, 159);
            this.RegInput9.MaxLength = 30;
            this.RegInput9.Name = "RegInput9";
            this.RegInput9.Size = new System.Drawing.Size(150, 21);
            this.RegInput9.TabIndex = 20;
            // 
            // RegInput8
            // 
            this.RegInput8.Location = new System.Drawing.Point(452, 129);
            this.RegInput8.MaxLength = 30;
            this.RegInput8.Name = "RegInput8";
            this.RegInput8.Size = new System.Drawing.Size(150, 21);
            this.RegInput8.TabIndex = 18;
            // 
            // RegInput7
            // 
            this.RegInput7.Location = new System.Drawing.Point(452, 99);
            this.RegInput7.MaxLength = 30;
            this.RegInput7.Name = "RegInput7";
            this.RegInput7.Size = new System.Drawing.Size(150, 21);
            this.RegInput7.TabIndex = 16;
            // 
            // RegInput6
            // 
            this.RegInput6.Location = new System.Drawing.Point(452, 69);
            this.RegInput6.MaxLength = 30;
            this.RegInput6.Name = "RegInput6";
            this.RegInput6.Size = new System.Drawing.Size(150, 21);
            this.RegInput6.TabIndex = 14;
            // 
            // RegData9
            // 
            this.RegData9.AutoSize = true;
            this.RegData9.Location = new System.Drawing.Point(332, 162);
            this.RegData9.Name = "RegData9";
            this.RegData9.Size = new System.Drawing.Size(40, 15);
            this.RegData9.TabIndex = 19;
            this.RegData9.Text = "Data9";
            this.RegData9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegData8
            // 
            this.RegData8.AutoSize = true;
            this.RegData8.Location = new System.Drawing.Point(332, 132);
            this.RegData8.Name = "RegData8";
            this.RegData8.Size = new System.Drawing.Size(40, 15);
            this.RegData8.TabIndex = 17;
            this.RegData8.Text = "Data8";
            this.RegData8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegData7
            // 
            this.RegData7.AutoSize = true;
            this.RegData7.Location = new System.Drawing.Point(332, 102);
            this.RegData7.Name = "RegData7";
            this.RegData7.Size = new System.Drawing.Size(40, 15);
            this.RegData7.TabIndex = 15;
            this.RegData7.Text = "Data7";
            this.RegData7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegData6
            // 
            this.RegData6.AutoSize = true;
            this.RegData6.Location = new System.Drawing.Point(332, 72);
            this.RegData6.Name = "RegData6";
            this.RegData6.Size = new System.Drawing.Size(40, 15);
            this.RegData6.TabIndex = 13;
            this.RegData6.Text = "Data6";
            this.RegData6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegBtnSave
            // 
            this.RegBtnSave.Location = new System.Drawing.Point(370, 190);
            this.RegBtnSave.Name = "RegBtnSave";
            this.RegBtnSave.Size = new System.Drawing.Size(70, 50);
            this.RegBtnSave.TabIndex = 21;
            this.RegBtnSave.Text = "&Simpan";
            this.RegBtnSave.UseVisualStyleBackColor = true;
            this.RegBtnSave.Click += new System.EventHandler(this.RegBtnSave_Click);
            // 
            // RegBtnCan
            // 
            this.RegBtnCan.Location = new System.Drawing.Point(446, 190);
            this.RegBtnCan.Name = "RegBtnCan";
            this.RegBtnCan.Size = new System.Drawing.Size(70, 50);
            this.RegBtnCan.TabIndex = 22;
            this.RegBtnCan.Text = "&Batal";
            this.RegBtnCan.UseVisualStyleBackColor = true;
            this.RegBtnCan.Click += new System.EventHandler(this.RegBtnCan_Click);
            // 
            // RegBtnDel
            // 
            this.RegBtnDel.Location = new System.Drawing.Point(522, 190);
            this.RegBtnDel.Name = "RegBtnDel";
            this.RegBtnDel.Size = new System.Drawing.Size(70, 50);
            this.RegBtnDel.TabIndex = 23;
            this.RegBtnDel.Text = "&Hapus";
            this.RegBtnDel.UseVisualStyleBackColor = true;
            this.RegBtnDel.Click += new System.EventHandler(this.RegBtnDel_Click);
            // 
            // RegBtnExit
            // 
            this.RegBtnExit.Location = new System.Drawing.Point(598, 190);
            this.RegBtnExit.Name = "RegBtnExit";
            this.RegBtnExit.Size = new System.Drawing.Size(70, 50);
            this.RegBtnExit.TabIndex = 24;
            this.RegBtnExit.Text = "&Keluar";
            this.RegBtnExit.UseVisualStyleBackColor = true;
            this.RegBtnExit.Click += new System.EventHandler(this.RegTutup);
            // 
            // RegInputDate
            // 
            this.RegInputDate.Checked = false;
            this.RegInputDate.CustomFormat = "dd-MM-yyyy";
            this.RegInputDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RegInputDate.Location = new System.Drawing.Point(150, 67);
            this.RegInputDate.Name = "RegInputDate";
            this.RegInputDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RegInputDate.Size = new System.Drawing.Size(150, 21);
            this.RegInputDate.TabIndex = 2;
            // 
            // Registrasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(680, 480);
            this.ControlBox = false;
            this.Controls.Add(this.RegInputDate);
            this.Controls.Add(this.RegBtnExit);
            this.Controls.Add(this.RegBtnDel);
            this.Controls.Add(this.RegBtnCan);
            this.Controls.Add(this.RegBtnSave);
            this.Controls.Add(this.RegInput9);
            this.Controls.Add(this.RegInput8);
            this.Controls.Add(this.RegInput7);
            this.Controls.Add(this.RegInput6);
            this.Controls.Add(this.RegData9);
            this.Controls.Add(this.RegData8);
            this.Controls.Add(this.RegData7);
            this.Controls.Add(this.RegData6);
            this.Controls.Add(this.RegInput5);
            this.Controls.Add(this.RegInput4);
            this.Controls.Add(this.RegInput3);
            this.Controls.Add(this.RegInput2);
            this.Controls.Add(this.RegInput1);
            this.Controls.Add(this.RegData5);
            this.Controls.Add(this.RegData4);
            this.Controls.Add(this.RegGrid);
            this.Controls.Add(this.RegData3);
            this.Controls.Add(this.RegData2);
            this.Controls.Add(this.RegData1);
            this.Controls.Add(this.RegDate);
            this.Controls.Add(this.RegJudul);
            this.Controls.Add(this.RegClose);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registrasi";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrasi";
            this.Load += new System.EventHandler(this.Registrasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RegGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegClose;
        private System.Windows.Forms.Label RegJudul;
        private System.Windows.Forms.Label RegDate;
        private System.Windows.Forms.Label RegData1;
        private System.Windows.Forms.Label RegData2;
        private System.Windows.Forms.Label RegData3;
        private System.Windows.Forms.DataGridView RegGrid;
        private System.Windows.Forms.Label RegData4;
        private System.Windows.Forms.Label RegData5;
        private System.Windows.Forms.TextBox RegInput1;
        private System.Windows.Forms.TextBox RegInput5;
        private System.Windows.Forms.TextBox RegInput4;
        private System.Windows.Forms.TextBox RegInput3;
        private System.Windows.Forms.TextBox RegInput9;
        private System.Windows.Forms.TextBox RegInput8;
        private System.Windows.Forms.TextBox RegInput7;
        private System.Windows.Forms.TextBox RegInput6;
        private System.Windows.Forms.Label RegData9;
        private System.Windows.Forms.Label RegData8;
        private System.Windows.Forms.Label RegData7;
        private System.Windows.Forms.Label RegData6;
        private System.Windows.Forms.Button RegBtnSave;
        private System.Windows.Forms.Button RegBtnCan;
        private System.Windows.Forms.Button RegBtnDel;
        private System.Windows.Forms.Button RegBtnExit;
        private System.Windows.Forms.DateTimePicker RegInputDate;
        private System.Windows.Forms.TextBox RegInput2;
    }
}
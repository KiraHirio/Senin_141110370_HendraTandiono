namespace DBS_POS
{
    partial class Main
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Registrasi = new System.Windows.Forms.ToolStripMenuItem();
            this.Transaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.Laporan = new System.Windows.Forms.ToolStripMenuItem();
            this.Utility = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.RegGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.RegBarang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RegCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.RegSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.RegPerkiraan = new System.Windows.Forms.ToolStripMenuItem();
            this.TransaksiJual = new System.Windows.Forms.ToolStripMenuItem();
            this.TransaksiBeli = new System.Windows.Forms.ToolStripMenuItem();
            this.TransaksiPakai = new System.Windows.Forms.ToolStripMenuItem();
            this.TransaksiOlah = new System.Windows.Forms.ToolStripMenuItem();
            this.TransaksiPenyesuaian = new System.Windows.Forms.ToolStripMenuItem();
            this.LaporanJual = new System.Windows.Forms.ToolStripMenuItem();
            this.LaporanBeli = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Registrasi,
            this.Transaksi,
            this.Laporan,
            this.Utility});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.Menu.Size = new System.Drawing.Size(664, 24);
            this.Menu.TabIndex = 0;
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(39, 20);
            this.File.Text = "&File";
            // 
            // Registrasi
            // 
            this.Registrasi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegCustomer,
            this.RegSupplier,
            this.toolStripSeparator1,
            this.RegBarang,
            this.RegGroup,
            this.RegPerkiraan});
            this.Registrasi.Name = "Registrasi";
            this.Registrasi.Size = new System.Drawing.Size(76, 20);
            this.Registrasi.Text = "&Registrasi";
            // 
            // Transaksi
            // 
            this.Transaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TransaksiJual,
            this.TransaksiBeli,
            this.TransaksiPakai,
            this.TransaksiOlah,
            this.TransaksiPenyesuaian});
            this.Transaksi.Name = "Transaksi";
            this.Transaksi.Size = new System.Drawing.Size(74, 20);
            this.Transaksi.Text = "&Transaksi";
            // 
            // Laporan
            // 
            this.Laporan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LaporanJual,
            this.LaporanBeli});
            this.Laporan.Name = "Laporan";
            this.Laporan.Size = new System.Drawing.Size(65, 20);
            this.Laporan.Text = "&Laporan";
            // 
            // Utility
            // 
            this.Utility.Name = "Utility";
            this.Utility.Size = new System.Drawing.Size(48, 20);
            this.Utility.Text = "&Utility";
            this.Utility.Visible = false;
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(152, 22);
            this.Exit.Text = "&Exit";
            this.Exit.Click += new System.EventHandler(this.Close);
            // 
            // RegGroup
            // 
            this.RegGroup.Name = "RegGroup";
            this.RegGroup.Size = new System.Drawing.Size(152, 22);
            this.RegGroup.Text = "&Group Barang";
            this.RegGroup.Visible = false;
            // 
            // RegBarang
            // 
            this.RegBarang.Name = "RegBarang";
            this.RegBarang.Size = new System.Drawing.Size(152, 22);
            this.RegBarang.Text = "&Barang";
            this.RegBarang.Click += new System.EventHandler(this.RegBarang_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // RegCustomer
            // 
            this.RegCustomer.Name = "RegCustomer";
            this.RegCustomer.Size = new System.Drawing.Size(152, 22);
            this.RegCustomer.Text = "&Customer";
            this.RegCustomer.Click += new System.EventHandler(this.RegCustomer_Click);
            // 
            // RegSupplier
            // 
            this.RegSupplier.Name = "RegSupplier";
            this.RegSupplier.Size = new System.Drawing.Size(152, 22);
            this.RegSupplier.Text = "&Supplier";
            this.RegSupplier.Click += new System.EventHandler(this.RegSupplier_Click);
            // 
            // RegPerkiraan
            // 
            this.RegPerkiraan.Name = "RegPerkiraan";
            this.RegPerkiraan.Size = new System.Drawing.Size(152, 22);
            this.RegPerkiraan.Text = "&Perkiraan";
            this.RegPerkiraan.Visible = false;
            // 
            // TransaksiJual
            // 
            this.TransaksiJual.Name = "TransaksiJual";
            this.TransaksiJual.Size = new System.Drawing.Size(179, 22);
            this.TransaksiJual.Text = "Pen&jualan";
            // 
            // TransaksiBeli
            // 
            this.TransaksiBeli.Name = "TransaksiBeli";
            this.TransaksiBeli.Size = new System.Drawing.Size(179, 22);
            this.TransaksiBeli.Text = "Pem&belian";
            // 
            // TransaksiPakai
            // 
            this.TransaksiPakai.Name = "TransaksiPakai";
            this.TransaksiPakai.Size = new System.Drawing.Size(179, 22);
            this.TransaksiPakai.Text = "&Pakai Stock";
            this.TransaksiPakai.Visible = false;
            // 
            // TransaksiOlah
            // 
            this.TransaksiOlah.Name = "TransaksiOlah";
            this.TransaksiOlah.Size = new System.Drawing.Size(179, 22);
            this.TransaksiOlah.Text = "&Olah Stock";
            this.TransaksiOlah.Visible = false;
            // 
            // TransaksiPenyesuaian
            // 
            this.TransaksiPenyesuaian.Name = "TransaksiPenyesuaian";
            this.TransaksiPenyesuaian.Size = new System.Drawing.Size(179, 22);
            this.TransaksiPenyesuaian.Text = "Pen&yesuaian Stock";
            this.TransaksiPenyesuaian.Visible = false;
            // 
            // LaporanJual
            // 
            this.LaporanJual.Name = "LaporanJual";
            this.LaporanJual.Size = new System.Drawing.Size(152, 22);
            this.LaporanJual.Text = "Pen&jualan";
            // 
            // LaporanBeli
            // 
            this.LaporanBeli.Name = "LaporanBeli";
            this.LaporanBeli.Size = new System.Drawing.Size(152, 22);
            this.LaporanBeli.Text = "Pem&belian";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 441);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBS Point of Sale";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Registrasi;
        private System.Windows.Forms.ToolStripMenuItem Transaksi;
        private System.Windows.Forms.ToolStripMenuItem Laporan;
        private System.Windows.Forms.ToolStripMenuItem Utility;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem RegCustomer;
        private System.Windows.Forms.ToolStripMenuItem RegSupplier;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem RegBarang;
        private System.Windows.Forms.ToolStripMenuItem RegGroup;
        private System.Windows.Forms.ToolStripMenuItem RegPerkiraan;
        private System.Windows.Forms.ToolStripMenuItem TransaksiJual;
        private System.Windows.Forms.ToolStripMenuItem TransaksiBeli;
        private System.Windows.Forms.ToolStripMenuItem TransaksiPakai;
        private System.Windows.Forms.ToolStripMenuItem TransaksiOlah;
        private System.Windows.Forms.ToolStripMenuItem TransaksiPenyesuaian;
        private System.Windows.Forms.ToolStripMenuItem LaporanJual;
        private System.Windows.Forms.ToolStripMenuItem LaporanBeli;
    }
}


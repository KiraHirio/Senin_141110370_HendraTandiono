using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_POS
{
    public partial class Registrasi : Form
    {
        public Registrasi()
        {
            InitializeComponent();
        }
        void CallSupplier()
        {
            RegJudul.Text = "Registrasi Supplier";
            RegInputDate.Value = DateTime.Now;

            RegData1.Text = "Kode";
            RegData2.Text = "Nama";
            RegInput2.MaxLength = 60;
            RegData3.Text = "Kota";
            RegData4.Text = "No Telepon";
            RegData5.Text = "Kode Pos";
            RegData6.Text = "Alamat";
            RegInput6.MaxLength = 120;
            RegInput6.Multiline = true;
            RegInput6.WordWrap = true;
            RegInput6.Height *= 3;

            RegData7.Visible = false;
            RegInput7.Visible = false;
            RegData8.Visible = false;
            RegInput8.Visible = false;
            RegData9.Visible = false;
            RegInput9.Visible = false;
        }
        void CallCustomer()
        {
            RegJudul.Text = "Registrasi Customer";
            RegInputDate.Value = DateTime.Now;

            RegData1.Text = "Kode";
            RegData2.Text = "Nama";
            RegInput2.MaxLength = 60;
            RegData3.Text = "Kota";
            RegData4.Text = "No Telepon";
            RegData5.Text = "Kode Pos";
            RegData6.Text = "Alamat";
            RegInput6.MaxLength = 120;

            RegInput6.Multiline = true;
            RegInput6.WordWrap = true;
            RegInput6.Height *= 3;

            RegData7.Visible = false;
            RegInput7.Visible = false;
            RegData8.Visible = false;
            RegInput8.Visible = false;
            RegData9.Visible = false;
            RegInput9.Visible = false;
        }
        void CallBarang()
        {
            RegJudul.Text = "Registrasi Barang";
            RegInputDate.Value = DateTime.Now;
            RegData1.Text = "Kode";
            RegData2.Text = "Nama";
            RegData3.Text = "Jumlah Awal";
            RegData4.Text = "Harga Hpp";
            RegData5.Text = "Harga Jual";

            RegData6.Visible = false;
            RegInput6.Visible = false;
            RegData7.Visible = false;
            RegInput7.Visible = false;
            RegData8.Visible = false;
            RegInput8.Visible = false;
            RegData9.Visible = false;
            RegInput9.Visible = false;
        }

        private void RegTutup(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registrasi_Load(object sender, EventArgs e)
        {
            if (MainForm.name == "Cust") { CallCustomer(); }else
            if (MainForm.name == "Supp") { CallSupplier(); }else
            if (MainForm.name == "Brg") { CallBarang(); }else
            { MessageBox.Show("Form Registrasi tersebut tidak tersedia!!!"); this.Close(); }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBS_POS
{
    public partial class Registrasi : Form
    {
        public string Query = "", Date1 = "", Date2 = "";
        public DateTime DTemp;
        public Registrasi()
        {
            InitializeComponent();
        }
        // Form Load
        void LoadSupplier()
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

            Query = "SELECT * FROM Supplier";
            Connection();
        }
        void LoadCustomer()
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

            Query = "SELECT * FROM Customer";
            Connection();
        }
        void LoadBarang()
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
             
            Query = "SELECT * FROM Barang";
            Connection();
        }
        // Form Call
        void CallSupplier() {
            Query = "SELECT * FROM `supplier` WHERE kode = \"" + RegInput1.Text + "\";";
            MainForm.con.Open();
            MySqlCommand sql = new MySqlCommand(Query, MainForm.con);
            MySqlDataReader DR = sql.ExecuteReader();
            if (DR.HasRows){
                DR.Read();
                RegInput2.Text = DR["nama"].ToString();
                RegInput3.Text = DR["awal"].ToString();
                RegInput4.Text = DR["kota"].ToString();
                RegInput5.Text = DR["notelp"].ToString();
                RegInput6.Text = DR["KodePos"].ToString();
                RegInput7.Text = DR["Alamat"].ToString();
            }
            else { }
            MainForm.con.Close();
        }
        void CallCustomer() {
            Query = "SELECT * FROM `customer` WHERE kode = \"" + RegInput1.Text + "\";";
            MainForm.con.Open();
            MySqlCommand sql = new MySqlCommand(Query, MainForm.con);
            MySqlDataReader DR = sql.ExecuteReader();
            if (DR.HasRows){
                DR.Read();
                RegInput2.Text = DR["nama"].ToString();
                RegInput3.Text = DR["awal"].ToString();
                RegInput4.Text = DR["kota"].ToString();
                RegInput5.Text = DR["notelp"].ToString();
                RegInput6.Text = DR["KodePos"].ToString();
                RegInput7.Text = DR["Alamat"].ToString();
            }
            else { }
            MainForm.con.Close();
        }
        void CallBarang() {
            Query = "SELECT * FROM `barang` WHERE kode = \"" + RegInput1.Text + "\";";
            MainForm.con.Open();
            MySqlCommand sql = new MySqlCommand(Query, MainForm.con);
            MySqlDataReader DR = sql.ExecuteReader();
            if (DR.HasRows){
                DR.Read();
                RegInput2.Text = DR["nama"].ToString();
                RegInput3.Text = DR["awal"].ToString();
                RegInput4.Text = DR["hpp"].ToString();
                RegInput5.Text = DR["harga"].ToString();
            }else{}
            MainForm.con.Close();
        }
        // Form Save
        void SaveSupplier() {
            DateUpd();
            Query = "INSERT INTO `supplier` (`kode`, `nama`, `kota`, `notelp`, `kodepos`, `alamat`, `DateAdd`, `DateMod`) VALUES (";
            Query = String.Concat(Query, "\"" + RegInput1.Text + "\", ");
            Query = String.Concat(Query, "\"" + RegInput2.Text + "\", ");
            Query = String.Concat(Query, "\"" + RegInput3.Text + "\", ");
            Query = String.Concat(Query, "\"" + RegInput4.Text + "\", ");
            Query = String.Concat(Query, "\"" + RegInput5.Text + "\", ");
            Query = String.Concat(Query, "\"" + Date1 + "\", ");
            Query = String.Concat(Query, "\"" + Date2 + "\");");
            RunQuery();
            MessageBox.Show("Data Telah Disimpan!!!");
            Cancel();
        }
        void SaveCustomer() {
            DateUpd();
            Query = "INSERT INTO `customer` (`kode`, `nama`, `kota`, `notelp`, `kodepos`, `alamat`, `DateAdd`, `DateMod`) VALUES (";
            Query = String.Concat(Query, "\"" + RegInput1.Text + "\", ");
            Query = String.Concat(Query, "\"" + RegInput2.Text + "\", ");
            Query = String.Concat(Query, "\"" + RegInput3.Text + "\", ");
            Query = String.Concat(Query, "\"" + RegInput4.Text + "\", ");
            Query = String.Concat(Query, "\"" + RegInput5.Text + "\", ");
            Query = String.Concat(Query, "\"" + RegInput6.Text + "\", ");
            Query = String.Concat(Query, "\"" + Date1 + "\", ");
            Query = String.Concat(Query, "\"" + Date2 + "\");");
            RunQuery();
            MessageBox.Show("Data Telah Disimpan!!!");
            Cancel();
        }
        void SaveBarang() {
            DateUpd();
            Query = "INSERT INTO `barang` (`kode`, `nama`,`awal`,`hpp`,`harga`,`DateAdd`,`DateMod`) VALUES (";
            Query = String.Concat(Query, "\"" + RegInput1.Text + "\", ");
            Query = String.Concat(Query, "\"" + RegInput2.Text + "\", ");
            Query = String.Concat(Query, "\"" + RegInput3.Text + "\", ");
            Query = String.Concat(Query, "\"" + RegInput4.Text + "\", ");
            Query = String.Concat(Query, "\"" + RegInput5.Text + "\", ");
            Query = String.Concat(Query, "\"" + Date1 + "\", ");
            Query = String.Concat(Query, "\"" + Date2 + "\");");
            RunQuery();
            MessageBox.Show("Data Telah Disimpan!!!");
            Cancel();
        }
        // Form Update
        void UpdateSupplier() {
            DateUpd();
            Query = "UPDATE `supplier` SET ";
            Query = String.Concat(Query, "`nama` = \"" + RegInput2.Text + "\", ");
            Query = String.Concat(Query, "`kota` = \"" + RegInput3.Text + "\", ");
            Query = String.Concat(Query, "`notelp` = \"" + RegInput4.Text + "\", ");
            Query = String.Concat(Query, "`kodepos` = \"" + RegInput5.Text + "\", ");
            Query = String.Concat(Query, "`alamat` = \"" + RegInput6.Text + "\", ");
            Query = String.Concat(Query, "`DateAdd` = \"" + Date1 + "\", ");
            Query = String.Concat(Query, "`DateMod` = \"" + Date2 + "\" ");
            Query = String.Concat(Query, "WHERE ");
            Query = String.Concat(Query, "`kode` = \"" + RegInput1.Text + "\";");
            RunQuery();
            MessageBox.Show("Data Telah Diupdate!!!");
            Cancel();
        }
        void UpdateCustomer() {
            DateUpd();
            Query = "UPDATE `customer` SET ";
            Query = String.Concat(Query, "`nama` = \"" + RegInput2.Text + "\", ");
            Query = String.Concat(Query, "`kota` = \"" + RegInput3.Text + "\", ");
            Query = String.Concat(Query, "`notelp` = \"" + RegInput4.Text + "\", ");
            Query = String.Concat(Query, "`kodepos` = \"" + RegInput5.Text + "\", ");
            Query = String.Concat(Query, "`alamat` = \"" + RegInput6.Text + "\", ");
            Query = String.Concat(Query, "`DateAdd` = \"" + Date1 + "\", ");
            Query = String.Concat(Query, "`DateMod` = \"" + Date2 + "\" ");
            Query = String.Concat(Query, "WHERE ");
            Query = String.Concat(Query, "`kode` = \"" + RegInput1.Text + "\";");
            RunQuery();
            MessageBox.Show("Data Telah Diupdate!!!");
            Cancel();
        }
        void UpdateBarang() {
            DateUpd();
            Query = "UPDATE `barang` SET ";
            Query = String.Concat(Query, "`nama` = \"" + RegInput2.Text + "\", ");
            Query = String.Concat(Query, "`awal` = \"" + RegInput3.Text + "\", ");
            Query = String.Concat(Query, "`hpp` = \"" + RegInput4.Text + "\", ");
            Query = String.Concat(Query, "`harga` = \"" + RegInput5.Text + "\", ");
            Query = String.Concat(Query, "`DateAdd` = \"" + Date1 + "\", ");
            Query = String.Concat(Query, "`DateMod` = \"" + Date2 + "\" ");
            Query = String.Concat(Query, "WHERE ");
            Query = String.Concat(Query, "`kode` = \"" + RegInput1.Text + "\";");
            RunQuery();
            MessageBox.Show("Data Telah Diupdate!!!");
            Cancel();
        }
        // Form Delete
        void DelSupplier() {
            Query = "DELETE FROM supplier WHERE kode = \"" + RegInput1.Text + "\";";
            RunQuery();
            MessageBox.Show("Data Supplier Telah Dihapus!!!");
            Cancel();
        }
        void DelCustomer() {
            Query = "DELETE FROM customer WHERE kode = \"" + RegInput1.Text + "\";";
            RunQuery();
            MessageBox.Show("Data Customer Telah Dihapus!!!");
            Cancel();
        }
        void DelBarang() {
            Query = "DELETE FROM barang WHERE kode = \"" + RegInput1.Text + "\";";
            RunQuery();
            MessageBox.Show("Data Barang Telah Dihapus!!!");
            Cancel();
        }
        // Form Others
        /*/        void CheckNum(object Sender, KeyPressEventArgs e){
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
                    // only allow one decimal point
                    if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) { e.Handled = true; }
                    int ntemp = (sender as TextBox).Text.Length - (sender as TextBox).Text.IndexOf('.');
                    if (char.IsDigit(e.KeyChar) && ntemp > 2 && ((sender as TextBox).Text.IndexOf('.') > -1)) { e.Handled = true; }
        }/*/
        void CheckData(){
            if (MainForm.name == "Brg"){Query = "SELECT DateAdd FROM `barang` WHERE kode = \"" + RegInput1.Text + "\";";}else
            if (MainForm.name == "Supp") { Query = "SELECT DateAdd FROM `supplier` WHERE kode = \"" + RegInput1.Text + "\";"; }else
            if (MainForm.name == "Cust") { Query = "SELECT DateAdd FROM `customer` WHERE kode = \"" + RegInput1.Text + "\";"; }
            MainForm.con.Open();
            MySqlCommand sql = new MySqlCommand(Query, MainForm.con);
            MySqlDataReader DR = sql.ExecuteReader();
            if (DR.HasRows){ MainForm.state = false; }
            MainForm.con.Close();
        }
        bool CheckInput()
        {
            bool XBool = true;
            if (MainForm.name == "Brg") {
                if (Rinput1()) { MessageBox.Show("Kode Barang Belum di Input!!!"); XBool = false; }else
                if (Rinput2()) { MessageBox.Show("Nama Barang Belum di Input!!!"); XBool = false; }
            }else if (MainForm.name == "Cust"){
                if (Rinput1()) { MessageBox.Show("Kode Customer Belum di Input!!!"); XBool = false; }else
                if (Rinput2()) { MessageBox.Show("Nama Customer Belum di Input!!!"); XBool = false; }
            }else if (MainForm.name == "Supp"){
                if (Rinput1()) { MessageBox.Show("Kode Supplier Belum di Input!!!"); XBool = false; }else
                if (Rinput2()) { MessageBox.Show("Nama Supplier Belum di Input!!!"); XBool = false; }
            }
            return XBool;
        }
        bool CheckInput2(){
            bool XBool = true;
            if (MainForm.name == "Brg") {
                if (Rinput1()) { MessageBox.Show("Kode Barang Belum di Input!!!"); XBool = false; }
            } else if (MainForm.name == "Cust"){
                if (Rinput1()) { MessageBox.Show("Kode Customer Belum di Input!!!"); XBool = false; }
            } else if (MainForm.name == "Supp"){
                if (Rinput1()) { MessageBox.Show("Kode Supplier Belum di Input!!!"); XBool = false; }
            } return XBool;
        }
        bool Rinput1() { if (string.IsNullOrWhiteSpace(RegInput1.Text)) { return true; } else { return false; } }
        bool Rinput2() { if (string.IsNullOrWhiteSpace(RegInput2.Text)) { return true; } else { return false; } }

        void DateUpd(){
            Date1 = RegInputDate.Value.Year.ToString() + "-";
            Date1 = String.Concat(Date1, RegInputDate.Value.Month.ToString() + "-");
            Date1 = String.Concat(Date1, RegInputDate.Value.Day.ToString());

            Date2 = RegInputDate.Value.Year.ToString() + "-";
            Date2 = String.Concat(Date2, RegInputDate.Value.Month.ToString() + "-");
            Date2 = String.Concat(Date2, RegInputDate.Value.Day.ToString());
                
            if (MainForm.name == "Brg"){Query = "SELECT DateAdd FROM `barang` WHERE kode = \"" + RegInput1.Text + "\";";}else
            if (MainForm.name == "Supp") { Query = "SELECT DateAdd FROM `supplier` WHERE kode = \"" + RegInput1.Text + "\";"; }else
            if (MainForm.name == "Cust") { Query = "SELECT DateAdd FROM `customer` WHERE kode = \"" + RegInput1.Text + "\";"; }
            
            MainForm.con.Open();
            MySqlCommand sql = new MySqlCommand(Query, MainForm.con);
            MySqlDataReader DR = sql.ExecuteReader();
            if (DR.HasRows) {
                DR.Read();
                DTemp = Convert.ToDateTime(DR["DateAdd"]);
                Date1 = DTemp.Year.ToString() + "-";
                Date1 = String.Concat(Date1, DTemp.Month.ToString()+"-");
                Date1 = String.Concat(Date1, DTemp.Day.ToString());
            }
            MainForm.con.Close();
        }
        void Cancel()
        {
            RegInputDate.Value = DateTime.Now;
            RegInput1.Text = "";
            RegInput2.Text = "";
            RegInput3.Text = "";
            RegInput4.Text = "";
            RegInput5.Text = "";
            RegInput6.Text = "";
            RegInput7.Text = "";
            RegInput8.Text = "";
            RegInput9.Text = "";
            
            if (MainForm.name == "Cust") { Query = "SELECT * FROM Customer";}
            else if (MainForm.name == "Supp") { Query = "SELECT * FROM Supplier";}
            else if (MainForm.name == "Brg") { Query = "SELECT * FROM Barang";}
            Connection();
        }
        void RunQuery() {
            MainForm.con.Open();
            MySqlCommand sql = new MySqlCommand(Query, MainForm.con);
            sql.ExecuteReader();
            MainForm.con.Close();
        }
        void Connection()
        {
            MainForm.con.Open();
            MySqlDataAdapter DA = new MySqlDataAdapter(Query, MainForm.con);
            DataTable table = new DataTable();
            DA.Fill(table);
            RegGrid.DataSource = table;
            MainForm.con.Close();
            RegGrid.Update();
            RegGrid.Refresh();
        }
        //
        private void RegTutup(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Registrasi_Load(object sender, EventArgs e)
        {
            if (MainForm.name == "Cust") { LoadCustomer(); }else
            if (MainForm.name == "Supp") { LoadSupplier(); }else
            if (MainForm.name == "Brg") { LoadBarang(); }else
            { MessageBox.Show("Form Registrasi tersebut tidak tersedia!!!"); this.Close(); }
        }
        private void RegBtnSave_Click(object sender, EventArgs e)
        {
            MainForm.state = true;
            if (CheckInput()){
            CheckData();
            if (MainForm.name == "Cust") { if (MainForm.state) { SaveCustomer(); }else{ UpdateCustomer(); }}else
            if (MainForm.name == "Supp") { if (MainForm.state) { SaveSupplier(); }else{ UpdateSupplier(); }}else
            if (MainForm.name == "Brg") { if (MainForm.state) { SaveBarang(); } else { UpdateBarang(); }}else
            { MessageBox.Show("Terjadi kesalahan Data Tidak dapat disimpan!!!"); Cancel(); }

            if (MainForm.name == "Cust") { Query = "SELECT * FROM Customer"; }
            else if (MainForm.name == "Supp") { Query = "SELECT * FROM Supplier"; }
            else if (MainForm.name == "Brg") { Query = "SELECT * FROM Barang"; }
            Connection();
            }
        }
        private void RegBtnCan_Click(object sender, EventArgs e){
            Cancel();
        }
        private void RegBtnDel_Click(object sender, EventArgs e)
        {
            if (CheckInput2())
            {
                if (MainForm.name == "Cust") { DelCustomer(); }else
                if (MainForm.name == "Supp") { DelSupplier(); }else
                if (MainForm.name == "Brg") { DelBarang(); }else
                { MessageBox.Show("Terjadi kesalahan Data Tidak dapat dihapus!!!"); Cancel(); }
                Connection();
            }
        }

        private void RegKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter){
                if (MainForm.name == "Cust") { CallCustomer(); }else
                if (MainForm.name == "Supp") { CallSupplier(); }else
                if (MainForm.name == "Brg") { CallBarang(); }else
                { MessageBox.Show("Terjadi kesalahan Data Tidak dapat dipanggil!!!"); Cancel(); }
            }
        }

        private void CheckN(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) { e.Handled = true; }
            int ntemp = (sender as TextBox).Text.Length - (sender as TextBox).Text.IndexOf('.');
            if (char.IsDigit(e.KeyChar) && ntemp > 2 && ((sender as TextBox).Text.IndexOf('.') > -1)) { e.Handled = true; }
        }
    }
}

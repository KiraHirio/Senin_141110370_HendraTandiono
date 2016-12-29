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

    public partial class Main : Form{
        void Connect(MySqlCommand sql,string Query)
        {
            MainForm.con.Open();
            sql = new MySqlCommand(Query, MainForm.con);
            sql.ExecuteReader();
            MainForm.con.Close();
        }
        void CreateSqlTable()
        {
            MySqlCommand sql;
            string Query = "";
            if (!System.IO.File.Exists("sql.txt")) { System.IO.File.Create("sql.txt").Close(); }
            Query = System.IO.File.ReadAllText("sql.txt");
            if (string.IsNullOrEmpty(Query)) {
                // CREATE DATABASE
                MainForm.sqlcon = new MySqlConnection("server=localhost;uid=root;password=;");
                Query = "CREATE DATABASE `dbspos` ;";
                MainForm.sqlcon.Open();
                sql = new MySqlCommand(Query, MainForm.sqlcon);
                sql.ExecuteReader();
                MainForm.sqlcon.Close();

                // CREATE TABLE
                MainForm.con = new MySqlConnection("server=localhost;user id=root; database=dbspos;");
                // Barang
                Query = "CREATE TABLE `barang` ( ";
                Query = String.Concat(Query, "`kode` VARCHAR(30) NOT NULL, ");
                Query = String.Concat(Query, "`nama` VARCHAR(60) NOT NULL, ");
                Query = String.Concat(Query, "`awal` DECIMAL(22,2) NOT NULL, ");
                Query = String.Concat(Query, "`hpp` DECIMAL(22,2) NOT NULL, ");
                Query = String.Concat(Query, "`harga` DECIMAL(22,2) NOT NULL, ");
                Query = String.Concat(Query, "`DateAdd` DATE NOT NULL, ");
                Query = String.Concat(Query, "`DateMod` DATE NOT NULL ");
                Query = String.Concat(Query, ");");
                Connect(sql,Query);
                // Customer
                Query = "CREATE TABLE `customer` ( ";
                Query = String.Concat(Query, "`kode` VARCHAR(30) NOT NULL, ");
                Query = String.Concat(Query, "`nama` VARCHAR(60) NOT NULL, ");
                Query = String.Concat(Query, "`kota` VARCHAR(60) NOT NULL, ");
                Query = String.Concat(Query, "`notelp` VARCHAR(18) NOT NULL, ");
                Query = String.Concat(Query, "`kodepos` VARCHAR(5) NOT NULL, ");
                Query = String.Concat(Query, "`alamat` VARCHAR(120) NOT NULL, ");
                Query = String.Concat(Query, "`DateAdd` DATE NOT NULL, ");
                Query = String.Concat(Query, "`DateMod` DATE NOT NULL ");
                Query = String.Concat(Query, ");");
                Connect(sql, Query);
                // Supplier
                Query = "CREATE TABLE `supplier` ( ";
                Query = String.Concat(Query, "`kode` VARCHAR(30) NOT NULL, ");
                Query = String.Concat(Query, "`nama` VARCHAR(60) NOT NULL, ");
                Query = String.Concat(Query, "`kota` VARCHAR(60) NOT NULL, ");
                Query = String.Concat(Query, "`notelp` VARCHAR(18) NOT NULL, ");
                Query = String.Concat(Query, "`kodepos` VARCHAR(5) NOT NULL, ");
                Query = String.Concat(Query, "`alamat` VARCHAR(120) NOT NULL, ");
                Query = String.Concat(Query, "`DateAdd` DATE NOT NULL, ");
                Query = String.Concat(Query, "`DateMod` DATE NOT NULL ");
                Query = String.Concat(Query, ");");
                Connect(sql, Query);

                System.IO.File.WriteAllText("sql.txt","dbspos");
            }
        }
        void CallForm(){
            MainForm.con = new MySqlConnection("server=localhost;user id=root;database=dbspos");
            Registrasi Form = new Registrasi();
            Form.ShowDialog();
            Form.Dispose();
            MainForm.con.Dispose();
            MainForm.state = false;
        }

        public Main() { InitializeComponent(); }

        private void Close(object sender, EventArgs e) { this.Close(); }

        private void RegCustomer_Click(object sender, EventArgs e){MainForm.name = "Cust"; CallForm();}
        private void RegSupplier_Click(object sender, EventArgs e){MainForm.name = "Supp";CallForm();}
        private void RegBarang_Click(object sender, EventArgs e){MainForm.name = "Brg";CallForm();}
        private void Main_Load(object sender, EventArgs e){CreateSqlTable();}

    }
    public static class MainForm
    {
        public static string name;
        public static bool state;
        public static MySqlConnection con,sqlcon;
    }
}

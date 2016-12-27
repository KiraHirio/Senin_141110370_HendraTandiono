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

    public partial class Main : Form{
        void CallForm(){
            Registrasi Form = new Registrasi();
            Form.ShowDialog();
            Form.Dispose();
        }
        public Main() { InitializeComponent(); }

        private void Close(object sender, EventArgs e) { this.Close(); }

        private void RegCustomer_Click(object sender, EventArgs e){
            MainForm.name = "Cust";
            CallForm();
        }

        private void RegSupplier_Click(object sender, EventArgs e){
            MainForm.name = "Supp";
            CallForm();
        }

        private void RegBarang_Click(object sender, EventArgs e){
            MainForm.name = "Brg";
            CallForm();
        }
    }
    public static class MainForm
    {
        public static string name;
    }
}

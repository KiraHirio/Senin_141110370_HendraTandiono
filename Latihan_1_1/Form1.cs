using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Change_0()
        {
            if (Scroll1.Value <= Scroll2.Value)
            {
                Min.Text = "Min = " + Scroll1.Value.ToString();
                Max.Text = "Max = " + Scroll2.Value.ToString();
                MinTahun.Text = "Min Tahun = " + (2016 - Scroll1.Value).ToString();
                MaxTahun.Text = "Max Tahun = " + (2016 + Scroll2.Value).ToString();
                /*
                Date.MinDate = Convert.ToDateTime("01/01/" + (2016 - Scroll1.Value).ToString());
                Date.MaxDate = Convert.ToDateTime("01/01/" + (2016 + Scroll2.Value).ToString());
                */
                Date.MinDate = DateTime.Today.AddYears(-Scroll1.Value);
                Date.MaxDate = DateTime.Today.AddYears(Scroll2.Value);
            }
            else
            {
                Min.Text = "Min = " + Scroll2.Value.ToString();
                Max.Text = "Max = " + Scroll1.Value.ToString();
                MinTahun.Text = "Min Tahun = " + (2016 - Scroll2.Value).ToString();
                MaxTahun.Text = "Max Tahun = " + (2016 + Scroll1.Value).ToString();
                /*
                Date.MinDate = Convert.ToDateTime("01/01/" + (2016 - Scroll2.Value).ToString());
                Date.MaxDate = Convert.ToDateTime("01/01/" + (2016 + Scroll1.Value).ToString());
                */
                Date.MinDate = DateTime.Today.AddYears(-Scroll2.Value);
                Date.MaxDate = DateTime.Today.AddYears(Scroll1.Value);
            }
        }

        private void Change_1(object sender, ScrollEventArgs e)
        {
            Value1.Text = "Value Scroll 1 = " + Scroll1.Value.ToString();
            Change_0();
        }
        private void Change_2(object sender, ScrollEventArgs e)
        {
            Value2.Text = "Value Scroll 2 = " + Scroll2.Value.ToString();
            Change_0();
        }
    }
}

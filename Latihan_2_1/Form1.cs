using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public string me = "", me1 = "", me2 = "", me3 = "";
        public void bold(DateTime Date1){
            me1 = Date1.Day.ToString();
            me2 = Date1.Month.ToString();
            me3 = Date1.Year.ToString();
            me = me2 + "/" + me1 + "/" + me3;
            MC1.AddBoldedDate(Convert.ToDateTime(me));
        }
        public Form1()
        {
            InitializeComponent();
            boldme();
        }

        private void Change(object sender, EventArgs e)
        {
            if (UD2.SelectedIndex == -1) { MessageBox.Show("Please Choose Month Before Bold The Date"); return; }
            string Day0 = UD1.Value.ToString(), Month0 = (UD2.SelectedIndex+1).ToString(), Year0 = DateTime.Today.Year.ToString();
            DateTime Date0 = Convert.ToDateTime(Month0 + "/" + Day0 + "/" + Year0);
            MC1.AddAnnuallyBoldedDate(Date0);
            MC1.UpdateBoldedDates();
        }
        private void ChangeBold(object sender, EventArgs e)
        {
            boldme();
        }
        public void boldme()
        {
            bool Feb = true;
            DateTime DT1 = MC1.SelectionStart.AddMonths(-4);
            DateTime DT2 = MC1.SelectionStart.AddMonths(4);
            string Day1 = "01", Month1 = DT1.Month.ToString(), Year1 = DT1.Year.ToString(),
                   Day2 = ""  , Month2 = DT2.Month.ToString(), Year2 = DT2.Year.ToString();

            if (DT2.Year % 100 != 0 && DT2.Year % 4 == 0 && DT2.Year % 400 == 0) { Feb = false; }

            for(int i = 1; i <= 12 ; i++ ){if (DT2.Month == i){
               if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12) { Day2 = "31"; }
               else if (i == 2 && Feb) { Day2 = "28"; } else if (i == 2) { Day2 = "29"; }
               else { Day2 = "30"; } break;
            }  }

            DateTime Date1 = Convert.ToDateTime(Month1+"/"+Day1+"/"+Year1);
            DateTime Date2 = Convert.ToDateTime(Month2+"/"+Day2+"/"+Year2);

            while(Date1 <= Date2){
                if (Date1.DayOfWeek == DayOfWeek.Sunday){  bold(Date1);}
                else if (Date1.DayOfWeek == DayOfWeek.Saturday) { bold(Date1); }
                else if (Date1.Day == 2 && Date1.Month == 10) { bold(Date1); }
                Date1 = Date1.AddDays(1);
            }
        }

        private void Reset(object sender, EventArgs e)
        {
            DateTime DT1 = MC1.SelectionRange.Start;
            DateTime DT2 = MC1.SelectionRange.End;
            while (DT1 <= DT2) { MC1.RemoveBoldedDate(DT1); DT1 = DT1.AddDays(1);}

            if (UD2.SelectedIndex == -1) { MessageBox.Show("Please Choose Month Before Un-Bold The Date"); return; }
            string Day0 = UD1.Value.ToString(), Month0 = (UD2.SelectedIndex + 1).ToString(), Year0 = DateTime.Today.Year.ToString();
            DateTime Date0 = Convert.ToDateTime(Month0 + "/" + Day0 + "/" + Year0);
            MC1.RemoveAnnuallyBoldedDate(Date0);
            MC1.UpdateBoldedDates();
        }

        private void MonthChange(object sender, EventArgs e)
        {
            int i = UD2.SelectedIndex+1;
            if(i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12){ UD1.Maximum = 31; }
            else if(i == 2 ){ UD1.Maximum = 29;}
            else {UD1.Maximum = 30;}
        }

        private void Messageme(object sender, DateRangeEventArgs e)
        {

            if (MC1.SelectionStart.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Hari Libur");
            }
            else
            {
                MessageBox.Show("Bukan Hari Libur");
            }
        }
     }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        public void Font_Style(Font xF,bool xB,bool xI,bool xU){

            if (xB == true && xI == true && xU == true) { RTB1.SelectionFont = new Font(xF, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); }
            else if (xB == true && xI == true && xU == false) { RTB1.SelectionFont = new Font(xF, FontStyle.Bold | FontStyle.Italic); }
            else if (xB == true && xI == false && xU == true) { RTB1.SelectionFont = new Font(xF, FontStyle.Bold | FontStyle.Underline); }
            else if (xB == false && xI == true && xU == true) { RTB1.SelectionFont = new Font(xF, FontStyle.Italic | FontStyle.Underline); }
            else if (xB == true && xI == false && xU == false) { RTB1.SelectionFont = new Font(xF, FontStyle.Bold); }
            else if (xB == false && xI == true && xU == false) { RTB1.SelectionFont = new Font(xF, FontStyle.Italic); }
            else if (xB == false && xI == false && xU == true) { RTB1.SelectionFont = new Font(xF, FontStyle.Underline); }
            else if (xB == false && xI == false && xU == false) { RTB1.SelectionFont = new Font(xF, FontStyle.Regular); }
            RTB1.Focus();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily f in FontFamily.Families) { TS_CBF.Items.Add(f.Name); }
            Type colorType = typeof(Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static |
                                  BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList) { this.TS_CBC.Items.Add(c.Name); }
            TS_CBF.SelectedIndex = TS_CBF.Items.IndexOf(RTB1.Font.FontFamily.Name.ToString());
            TS_CBS.SelectedIndex = 2;
            TS_CBC.SelectedIndex = 8;
        }

        private void FontSize(object sender, EventArgs e)
        {
            Font xF = RTB1.SelectionFont;
            FontFamily xFF = xF.FontFamily;
            int xFS = Convert.ToInt32(TS_CBS.Text);
            RTB1.SelectionFont = new Font(xFF, xFS, xF.Style);
            RTB1.Focus();
        }
        private void FontName(object sender, EventArgs e)
        {
            Font xF = RTB1.SelectionFont;
            int xFS = Convert.ToInt32(xF.Size);
            RTB1.SelectionFont = new Font(TS_CBF.Text, xFS, xF.Style);
            RTB1.Focus();
        }

        private void Bold(object sender, EventArgs e)
        {
            Font xF = RTB1.SelectionFont;
            bool xB = xF.Bold;
            bool xI = xF.Italic;
            bool xU = xF.Underline;
            if (RTB1.SelectionFont.Bold == true) { xB = false; } else { xB = true; }
            Font_Style(xF,xB, xI, xU);
        }

        private void Italic(object sender, EventArgs e)
        {
            Font xF = RTB1.SelectionFont;
            bool xB = xF.Bold;
            bool xI = xF.Italic;
            bool xU = xF.Underline;
            if (RTB1.SelectionFont.Italic == true) { xI = false; } else { xI = true; }
            Font_Style(xF, xB, xI, xU);
        }

        private void Underline(object sender, EventArgs e)
        {
            Font xF = RTB1.SelectionFont;
            bool xB = xF.Bold;
            bool xI = xF.Italic;
            bool xU = xF.Underline;
            if (RTB1.SelectionFont.Underline == true) { xU = false; } else { xU = true; }
            Font_Style(xF, xB, xI, xU);
        }

        private void FontColor(object sender, EventArgs e)
        {
            RTB1.SelectionColor = Color.FromName(TS_CBC.Text);
            RTB1.Focus();
        }

    }
}

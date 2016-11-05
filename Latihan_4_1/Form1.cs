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

namespace Latihan_4_1
{
    public partial class Form1 : Form
    {
        bool C = false;
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
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList) { this.TS_CBC.Items.Add(c.Name); }
//            TS_CBF.SelectedIndex = TS_CBF.Items.IndexOf(RTB1.Font.FontFamily.Name.ToString());
            TS_CBF.SelectedIndex = TS_CBF.Items.IndexOf("Times New Roman");
            TS_CBS.SelectedIndex = TS_CBS.Items.IndexOf("10");
            TS_CBC.SelectedIndex = TS_CBC.Items.IndexOf("Black");
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

        private void FontColor(object sender, EventArgs e){RTB1.SelectionColor = Color.FromName(TS_CBC.Text);RTB1.Focus();}

        public void Save_File()
        {
            SaveFileDialog S = new SaveFileDialog();
            S.Filter = "Rich Text Format |*.rtf;";
            if (S.ShowDialog() == DialogResult.OK)
            {
                RTB1.SaveFile(S.FileName);
                MessageBox.Show("File Saved.");
                C = false;
            }

        }
        private void Exit_Click(object sender, EventArgs e){this.Close();}

        private void New_Click(object sender, EventArgs e)
        {
            if (C){
                DialogResult D = MessageBox.Show("Do you want save Changes?",this.Text,MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);
                if (D == DialogResult.Yes) { Save_File(); }
            }
            C = false;
            RTB1.Text = "";
        }

        private void RTB1_C(object sender, EventArgs e){C = true;}

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog O = new OpenFileDialog();
            O.Filter = "Rich Text Format |*.rtf;";
            if (O.ShowDialog() == DialogResult.OK){
                if (C) {
                    DialogResult D = MessageBox.Show("Do You Want Save This File?",this.Text,MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);
                    if (D == DialogResult.OK) { Save_File(); }
                }
                RTB1.LoadFile(O.FileName);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
//            DialogResult D = MessageBox.Show("Do You Want Save This File?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            Save_File();            
        }

        private void Check_Text(object sender, EventArgs e)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static bool Valid(long A, long B)
        {
            if (A < 25) return false; // Jika Nilai A Lebih Kecil dari 25 Game Masih Berlanjut.
            if (A == 25) return B <= 23; // Jika Nilai B Melebihi Nilai A (2) Point Game Selesai.
            return B == (A - 2); // Jika Nilai A Lebih Besar Dari 25.
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            InputC.Text = "";
            long A = Convert.ToInt32(InputA.Text),
                B = Convert.ToInt32(InputB.Text),
                C = 0,
                M = 1000000007;

            if (A < B){
                A = Convert.ToInt32(InputB.Text);
                B = Convert.ToInt32(InputA.Text);
            }
            if (!Valid(A, B))
            {
                InputC.Text = "0";
            } // Dimana Ketentuan tidak mungkin dicari atau Game Sudah Selesai.
            else
            {
                InputC.Text = nck(Math.Min(A + B - 1, 47), Math.Min(A - 1, 24), M).ToString();
            }
        }
        static long F(long A, long M)
        {
            long C = 1;
            for (long i = 1; i <= A; i++){
                C = (C * i) % M;
            }
                return C;
        }
        static long gcd(long A, long B) { if (B == 0)return A; else return gcd(B,A%B); }
        static long MI(long A, long M)
        {
            long X = 0, Y = 1, m = 0, tmp = 0, times = 0;
            if (M <= 1 || gcd(A, M) != 1) return -1;
            m = M;
            while (A > 1)
            {
                times = A / M;
                tmp = M;
                M = A % M;
                A = tmp;
                tmp = X;
                X = Y - times * X;
                Y = tmp;
            }
            return (m + Y) % m;
        }
        static long nck(long A, long B, long M) {
            long C = 1;
            if (A < B) { C = A; A = B; B = C; C = 0; }
            if (A < 1 || B < 1) { return 1; }

            C = (C * F(A,M)) % M;
            C = (C * MI(F(A - B, M), M)) % M;
            C = (C * MI(F(B, M), M)) % M;
            return C;
        }

        private void NumOnlyA(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(InputA.Text, "[^0-9]"))
            {
                InputA.Text = InputA.Text.Remove(InputA.TextLength - 1);
            }
        }

        private void NumOnlyB(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(InputA.Text, "[^0-9]"))
            {
                InputA.Text = InputA.Text.Remove(InputA.TextLength - 1);
            }
        }
    }
}

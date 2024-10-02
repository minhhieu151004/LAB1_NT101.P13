using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Ceaser_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void btn_Playfair_Click(object sender, EventArgs e)
        {
            PlayFair f = new PlayFair();
            f.ShowDialog();
        }

        private void btn_Vingenere_Click(object sender, EventArgs e)
        {
            Vigenere f = new Vigenere();
            f.ShowDialog();
        }
    }
}

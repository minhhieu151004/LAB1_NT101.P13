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
    public partial class Vigenere : Form
    {
        public Vigenere()
        {
            InitializeComponent();
            
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (btnExcute.Text == "Encrypt")
            {
                btnExcute.Text = "Decrypt";
                label_1.Text = "Cyphertext";
                label_2.Text = "Plaintext";
            }
            else
            {
                btnExcute.Text = "Encrypt";
                label_1.Text = "Plaintext";
                label_2.Text = "Cyphertext";
            }
            string txt1 = rtbox_1.Text;
            rtbox_1.Text = rtbox_2.Text;
            rtbox_2.Text = txt1;
        }

        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int[] arrKey_toInt;
        private string Encrypt(int[] arrKey, string plainTxt)
        {
            string result = "";
            int index = 0;
            foreach (char x in plainTxt)
            {
                if (alphabet.Contains(x))
                {
                    if (index == arrKey.Length) index = 0;
                    int vitri = (alphabet.IndexOf(x)+ arrKey[index]) % 26;
                    result += alphabet[vitri];
                    index++;
                }
                else
                {
                    result += x;
                }
            }

            return result;
        }
        private string Decrypt(int[] arrKey, string cypherTxt)
        {
            string result = "";
            int index = 0;
            foreach (char x in cypherTxt)
            {
                if (alphabet.Contains(x))
                {
                    if (index == arrKey.Length) index = 0;
                    int vitri = (alphabet.IndexOf(x) - arrKey[index] +26) % 26;
                    result += alphabet[vitri];
                    index++;
                }
                else
                {
                    result += x;
                }
            }

            return result;
        }
        private void Excute()
        {
            if (!string.IsNullOrEmpty(tbxKey.Text))
            {
                string KEY = tbxKey.Text.ToUpper();
                arrKey_toInt = new int[KEY.Length];
                for (int i = 0; i < KEY.Length; i++)
                {
                    arrKey_toInt[i] = alphabet.IndexOf(KEY[i]);
                }
                if (btnExcute.Text == "Encrypt")
                {
                    rtbox_2.Text = Encrypt(arrKey_toInt, rtbox_1.Text.ToUpper());
                }
                else
                {
                    rtbox_2.Text = Decrypt(arrKey_toInt, rtbox_1.Text.ToUpper());
                }
            }
        }

        private void btnExcute_Click(object sender, EventArgs e)
        {
            Excute();
        }

        private void rtbox_1_TextChanged(object sender, EventArgs e)
        {
            Excute();
        }

        private void tbxKey_TextChanged(object sender, EventArgs e)
        {
            Excute();
        }
    }
}

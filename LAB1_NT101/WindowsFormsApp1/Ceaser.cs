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
    public partial class Form1 : Form
    {
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(btnExcute.Text == "Encrypt")
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

        private void rtbox_1_TextChanged(object sender, EventArgs e)
        {
            string result = "";
            if (String.IsNullOrEmpty(tbxKey.Text)) return;
            int key = Convert.ToInt32(tbxKey.Text);
            while (key < 0)
            {
                key += 26;
            }
            while (key > 25)
            {
                key -= 26;
            }
            if (btnExcute.Text == "Encrypt")
            {
                string plainText = rtbox_1.Text;
                foreach (char x in plainText)
                {
                    if (alphabet.Contains(x))
                    {
                        int index = alphabet.IndexOf(x);
                        if (index > 25)
                        {
                            result += alphabet[(index + key) % 26 + 26];
                        }
                        else result += alphabet[(index + key) % 26];
                    }
                    else
                    {
                        result += x;
                    }
                }
            }
            else
            {
                string cypherText = rtbox_1.Text;
                foreach (char x in cypherText)
                {
                    if (alphabet.Contains(x))
                    {
                        int index = alphabet.IndexOf(x);
                        if (index > 25)
                        {
                            result += alphabet[(index - key + 26) % 26 + 26];
                        }
                        else result += alphabet[(index - key + 26) % 26];
                    }
                    else
                    {
                        result += x;
                    }
                }
            }
            rtbox_2.Text = result;
        }

        private void btnExcute_Click(object sender, EventArgs e)
        {
            string result = "";
            if (String.IsNullOrEmpty(tbxKey.Text)) return;

            int key = Convert.ToInt32(tbxKey.Text);
            while (key < 0)
            {
                key += 26;
            }
            while (key > 25)
            {
                key -= 26;
            }

            if (btnExcute.Text == "Encrypt")
            {
                string plainText = rtbox_1.Text;
                foreach (char x in plainText)
                {
                    if (alphabet.Contains(x))
                    {
                        int index = alphabet.IndexOf(x);
                        if (index > 25)
                        {
                            result += alphabet[(index + key) % 26 + 26];
                        }
                        else result += alphabet[(index + key) % 26];
                    }
                    else
                    {
                        result += x;
                    }
                }
            }
            else
            {
                string cypherText = rtbox_1.Text;
                foreach (char x in cypherText)
                {
                    if (alphabet.Contains(x))
                    {
                        int index = alphabet.IndexOf(x);
                        if (index > 25)
                        {
                            result += alphabet[(index - key + 26) % 26 + 26];
                        }
                        else result += alphabet[(index - key + 26) % 26];
                    }
                    else
                    {
                        result += x;
                    }
                }
            }
            rtbox_2.Text = result;
        }
    }
}

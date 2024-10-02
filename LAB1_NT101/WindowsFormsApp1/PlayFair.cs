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
    public partial class PlayFair : Form
    {
        public PlayFair()
        {
            InitializeComponent();
        }

        string alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
        List<List<Label>> matrix;
        string matrixKEY_toString;

        public void CreateMatrix(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return;
            }
            pnMatrix.Controls.Clear();

            //Tạo mảng 5x5 chứa các label rỗng
            matrix = new List<List<Label>>();
            Label curentLb = null;
            for (int i = 0; i < 5; i++)
            {
                matrix.Add(new List<Label>());
                for (int j = 0; j < 5; j++)
                {
                    Label lb = new Label()
                    {
                        Width = 30,
                        Height = 30,
                        Size = new Size(30, 30),
                        Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                        BorderStyle = BorderStyle.FixedSingle,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    //Nếu là ô đầu tiên (0,0) currentLb = null
                    if(curentLb == null)
                    {
                        lb.Location = new Point(0, 0);
                    }
                    //Nếu là ô đầu hàng (i,0)
                    else if(j == 0)
                    {
                        lb.Location = new Point(0, curentLb.Bottom);
                    }
                    //Nếu là các ô còn lại 
                    else
                    {
                        lb.Location = new Point(curentLb.Right, curentLb.Top);
                    }

                    pnMatrix.Controls.Add(lb);
                    curentLb = lb;
                    matrix[i].Add(lb);
                }
            }

            //Thêm ký tự vào mảng dựa vào Key
            int row = 0, col = 0;
            string existChar = "";
            foreach (char x in key)
            {
                if (alphabet.Contains(x) && !existChar.Contains(x))
                {
                    matrix[row][col].Text = x.ToString();
                    col++;
                    if(col == 5)
                    {
                        col = 0;
                        row++;
                    }
                    existChar += x;
                }
            }

            foreach(char x in alphabet)
            {
                if (!existChar.Contains(x))
                {
                    matrix[row][col].Text = x.ToString();
                    col++;
                    if (col == 5)
                    {
                        col = 0;
                        row++;
                    }
                    existChar += x;
                }
            }
            matrixKEY_toString = existChar;
        }

        private void btnExcute_Click(object sender, EventArgs e)
        {
            Excute();
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

        private void tbxKey_TextChanged(object sender, EventArgs e)
        {
            string key = tbxKey.Text;
            if (string.IsNullOrEmpty(key))
            {
                pnMatrix.Hide();
            }
            else
            {
                CreateMatrix(key.ToUpper());
                pnMatrix.Show();
            }
            Excute();
        }

        private string Encrypt(string plaintxt, string matrix_toString)
        {
            string result ="";
            //Nếu độ dài lẻ thì thêm 'X' vào cuối chuỗi để tạo thành cặp kí tự
            if((plaintxt.Length % 2) == 1)
            {
                plaintxt += "X";
            }

            for(int i = 0; i < plaintxt.Length; i += 2)
            {
                Point point_1 = new Point();
                Point point_2 = new Point();

                char char_1 = plaintxt[i];
                char char_2 = plaintxt[i + 1];

                int viTri_1 = matrix_toString.IndexOf(char_1);
                point_1.X = viTri_1 % 5;
                point_1.Y = viTri_1 / 5;

                int viTri_2 = matrix_toString.IndexOf(char_2);
                point_2.X = viTri_2 % 5;
                point_2.Y = viTri_2 / 5;

                //TH: Cùng hàng
                if(point_1.Y == point_2.Y)
                {
                    point_1.X++;
                    point_2.X++;
                    if (point_1.X == 5) point_1.X = 0;
                    if (point_2.X == 5) point_2.X = 0;
                }
                //TH: Cùng cột
                else if(point_1.X == point_2.X)
                {
                    point_1.Y++;
                    point_2.Y++;
                    if (point_1.Y == 5) point_1.Y = 0;
                    if (point_2.Y == 5) point_2.Y = 0;
                }
                //TH: Khác hàng và cột
                else
                {
                    int tmp = point_1.X;
                    point_1.X = point_2.X;
                    point_2.X = tmp;
                }

                result += matrix[point_1.Y][point_1.X].Text;
                result += matrix[point_2.Y][point_2.X].Text;
            }

            return result;
        }
        private string Decrypt(string cyphertxt, string matrix_toString)
        {
            string result = "";
            //Nếu độ dài lẻ thì thêm 'X' vào cuối chuỗi để tạo thành cặp kí tự
            if ((cyphertxt.Length % 2) == 1)
            {
                cyphertxt += "X";
            }
            for (int i = 0; i < cyphertxt.Length; i += 2)
            {
                Point point_1 = new Point();
                Point point_2 = new Point();

                char char_1 = cyphertxt[i];
                char char_2 = cyphertxt[i + 1];

                int viTri_1 = matrix_toString.IndexOf(char_1);
                point_1.X = viTri_1 % 5;
                point_1.Y = viTri_1 / 5;

                int viTri_2 = matrix_toString.IndexOf(char_2);
                point_2.X = viTri_2 % 5;
                point_2.Y = viTri_2 / 5;

                //TH: Cùng hàng
                if (point_1.Y == point_2.Y)
                {
                    point_1.X--;
                    point_2.X--;
                    if (point_1.X <0) point_1.X = 4;
                    if (point_2.X <0) point_2.X = 4;
                }
                //TH: Cùng cột
                else if (point_1.X == point_2.X)
                {
                    point_1.Y--;
                    point_2.Y--;
                    if (point_1.Y <0) point_1.Y = 4;
                    if (point_2.Y <0) point_2.Y = 4;
                }
                //TH: Khác hàng và cột
                else
                {
                    int tmp = point_1.X;
                    point_1.X = point_2.X;
                    point_2.X = tmp;
                }

                result += matrix[point_1.Y][point_1.X].Text;
                result += matrix[point_2.Y][point_2.X].Text;
            }

            return result;
        }
        private void Excute()
        {
            if (btnExcute.Text == "Encrypt")
            {
                rtbox_2.Text = Encrypt(rtbox_1.Text, matrixKEY_toString);
            }
            else
            {
                rtbox_2.Text = Decrypt(rtbox_1.Text, matrixKEY_toString);
            }
        }
    }
}

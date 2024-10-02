
namespace WindowsFormsApp1
{
    partial class PlayFair
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbxKey = new System.Windows.Forms.TextBox();
            this.rtbox_1 = new System.Windows.Forms.RichTextBox();
            this.rtbox_2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.btnExcute = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.pnMatrix = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Playfair cipher ";
            // 
            // tbxKey
            // 
            this.tbxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxKey.Location = new System.Drawing.Point(84, 130);
            this.tbxKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxKey.Name = "tbxKey";
            this.tbxKey.Size = new System.Drawing.Size(236, 30);
            this.tbxKey.TabIndex = 10;
            this.tbxKey.TextChanged += new System.EventHandler(this.tbxKey_TextChanged);
            // 
            // rtbox_1
            // 
            this.rtbox_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbox_1.Location = new System.Drawing.Point(17, 263);
            this.rtbox_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbox_1.Name = "rtbox_1";
            this.rtbox_1.Size = new System.Drawing.Size(409, 370);
            this.rtbox_1.TabIndex = 11;
            this.rtbox_1.Text = "";
            // 
            // rtbox_2
            // 
            this.rtbox_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbox_2.Location = new System.Drawing.Point(485, 263);
            this.rtbox_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbox_2.Name = "rtbox_2";
            this.rtbox_2.ReadOnly = true;
            this.rtbox_2.Size = new System.Drawing.Size(409, 370);
            this.rtbox_2.TabIndex = 12;
            this.rtbox_2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Key :";
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1.Location = new System.Drawing.Point(19, 233);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(125, 27);
            this.label_1.TabIndex = 14;
            this.label_1.Text = "Plaintext";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_2.Location = new System.Drawing.Point(481, 233);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(151, 27);
            this.label_2.TabIndex = 15;
            this.label_2.Text = "Cyphertext";
            // 
            // btnExcute
            // 
            this.btnExcute.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcute.Location = new System.Drawing.Point(326, 126);
            this.btnExcute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcute.Name = "btnExcute";
            this.btnExcute.Size = new System.Drawing.Size(105, 43);
            this.btnExcute.TabIndex = 16;
            this.btnExcute.Text = "Encrypt";
            this.btnExcute.UseVisualStyleBackColor = true;
            this.btnExcute.Click += new System.EventHandler(this.btnExcute_Click);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(429, 415);
            this.btnChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(53, 46);
            this.btnChange.TabIndex = 17;
            this.btnChange.Text = "<=>";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // pnMatrix
            // 
            this.pnMatrix.Location = new System.Drawing.Point(635, 31);
            this.pnMatrix.Name = "pnMatrix";
            this.pnMatrix.Size = new System.Drawing.Size(200, 200);
            this.pnMatrix.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Matrix :";
            // 
            // PlayFair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 645);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnMatrix);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnExcute);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbox_2);
            this.Controls.Add(this.rtbox_1);
            this.Controls.Add(this.tbxKey);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PlayFair";
            this.Text = "PlayFair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxKey;
        private System.Windows.Forms.RichTextBox rtbox_1;
        private System.Windows.Forms.RichTextBox rtbox_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Button btnExcute;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Panel pnMatrix;
        private System.Windows.Forms.Label label3;
    }
}
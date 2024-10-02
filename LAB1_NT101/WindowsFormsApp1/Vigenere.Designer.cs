
namespace WindowsFormsApp1
{
    partial class Vigenere
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
            this.btnChange = new System.Windows.Forms.Button();
            this.btnExcute = new System.Windows.Forms.Button();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbox_2 = new System.Windows.Forms.RichTextBox();
            this.rtbox_1 = new System.Windows.Forms.RichTextBox();
            this.tbxKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(476, 295);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(58, 45);
            this.btnChange.TabIndex = 17;
            this.btnChange.Text = "<=>";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnExcute
            // 
            this.btnExcute.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcute.Location = new System.Drawing.Point(334, 62);
            this.btnExcute.Name = "btnExcute";
            this.btnExcute.Size = new System.Drawing.Size(136, 43);
            this.btnExcute.TabIndex = 16;
            this.btnExcute.Text = "Encrypt";
            this.btnExcute.UseVisualStyleBackColor = true;
            this.btnExcute.Click += new System.EventHandler(this.btnExcute_Click);
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_2.Location = new System.Drawing.Point(535, 113);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(151, 27);
            this.label_2.TabIndex = 15;
            this.label_2.Text = "Cyphertext";
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1.Location = new System.Drawing.Point(24, 113);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(125, 27);
            this.label_1.TabIndex = 14;
            this.label_1.Text = "Plaintext";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Key ";
            // 
            // rtbox_2
            // 
            this.rtbox_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbox_2.Location = new System.Drawing.Point(540, 143);
            this.rtbox_2.Name = "rtbox_2";
            this.rtbox_2.ReadOnly = true;
            this.rtbox_2.Size = new System.Drawing.Size(441, 441);
            this.rtbox_2.TabIndex = 12;
            this.rtbox_2.Text = "";
            // 
            // rtbox_1
            // 
            this.rtbox_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbox_1.Location = new System.Drawing.Point(29, 143);
            this.rtbox_1.Name = "rtbox_1";
            this.rtbox_1.Size = new System.Drawing.Size(441, 441);
            this.rtbox_1.TabIndex = 11;
            this.rtbox_1.Text = "";
            this.rtbox_1.TextChanged += new System.EventHandler(this.rtbox_1_TextChanged);
            // 
            // tbxKey
            // 
            this.tbxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxKey.Location = new System.Drawing.Point(86, 66);
            this.tbxKey.Name = "tbxKey";
            this.tbxKey.Size = new System.Drawing.Size(215, 30);
            this.tbxKey.TabIndex = 10;
            this.tbxKey.TextChanged += new System.EventHandler(this.tbxKey_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vigenere cipher ";
            // 
            // Vigenere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 596);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnExcute);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbox_2);
            this.Controls.Add(this.rtbox_1);
            this.Controls.Add(this.tbxKey);
            this.Controls.Add(this.label1);
            this.Name = "Vigenere";
            this.Text = "Vigenere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnExcute;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbox_2;
        private System.Windows.Forms.RichTextBox rtbox_1;
        private System.Windows.Forms.TextBox tbxKey;
        private System.Windows.Forms.Label label1;
    }
}
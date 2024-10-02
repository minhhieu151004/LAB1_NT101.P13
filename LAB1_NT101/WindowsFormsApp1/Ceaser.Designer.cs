
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caesar cipher ";
            // 
            // tbxKey
            // 
            this.tbxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxKey.Location = new System.Drawing.Point(76, 64);
            this.tbxKey.Name = "tbxKey";
            this.tbxKey.Size = new System.Drawing.Size(123, 28);
            this.tbxKey.TabIndex = 1;
            this.tbxKey.Text = "0";
            // 
            // rtbox_1
            // 
            this.rtbox_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbox_1.Location = new System.Drawing.Point(12, 145);
            this.rtbox_1.Name = "rtbox_1";
            this.rtbox_1.Size = new System.Drawing.Size(410, 513);
            this.rtbox_1.TabIndex = 2;
            this.rtbox_1.Text = "";
            this.rtbox_1.TextChanged += new System.EventHandler(this.rtbox_1_TextChanged);
            // 
            // rtbox_2
            // 
            this.rtbox_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbox_2.Location = new System.Drawing.Point(481, 145);
            this.rtbox_2.Name = "rtbox_2";
            this.rtbox_2.ReadOnly = true;
            this.rtbox_2.Size = new System.Drawing.Size(410, 513);
            this.rtbox_2.TabIndex = 3;
            this.rtbox_2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Key ";
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1.Location = new System.Drawing.Point(14, 115);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(125, 27);
            this.label_1.TabIndex = 5;
            this.label_1.Text = "Plaintext";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_2.Location = new System.Drawing.Point(476, 115);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(151, 27);
            this.label_2.TabIndex = 6;
            this.label_2.Text = "Cyphertext";
            // 
            // btnExcute
            // 
            this.btnExcute.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcute.Location = new System.Drawing.Point(241, 58);
            this.btnExcute.Name = "btnExcute";
            this.btnExcute.Size = new System.Drawing.Size(105, 43);
            this.btnExcute.TabIndex = 7;
            this.btnExcute.Text = "Encrypt";
            this.btnExcute.UseVisualStyleBackColor = true;
            this.btnExcute.Click += new System.EventHandler(this.btnExcute_Click);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(424, 404);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(53, 45);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "<=>";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 670);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnExcute);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbox_2);
            this.Controls.Add(this.rtbox_1);
            this.Controls.Add(this.tbxKey);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}


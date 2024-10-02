
namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.btn_Ceaser = new System.Windows.Forms.Button();
            this.btn_Playfair = new System.Windows.Forms.Button();
            this.btn_Vingenere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Ceaser
            // 
            this.btn_Ceaser.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ceaser.Location = new System.Drawing.Point(46, 42);
            this.btn_Ceaser.Name = "btn_Ceaser";
            this.btn_Ceaser.Size = new System.Drawing.Size(153, 71);
            this.btn_Ceaser.TabIndex = 0;
            this.btn_Ceaser.Text = "Caeser Cypher";
            this.btn_Ceaser.UseVisualStyleBackColor = true;
            this.btn_Ceaser.Click += new System.EventHandler(this.btn_Ceaser_Click);
            // 
            // btn_Playfair
            // 
            this.btn_Playfair.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Playfair.Location = new System.Drawing.Point(263, 42);
            this.btn_Playfair.Name = "btn_Playfair";
            this.btn_Playfair.Size = new System.Drawing.Size(153, 71);
            this.btn_Playfair.TabIndex = 1;
            this.btn_Playfair.Text = "Playfair Cypher";
            this.btn_Playfair.UseVisualStyleBackColor = true;
            this.btn_Playfair.Click += new System.EventHandler(this.btn_Playfair_Click);
            // 
            // btn_Vingenere
            // 
            this.btn_Vingenere.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vingenere.Location = new System.Drawing.Point(156, 149);
            this.btn_Vingenere.Name = "btn_Vingenere";
            this.btn_Vingenere.Size = new System.Drawing.Size(153, 71);
            this.btn_Vingenere.TabIndex = 2;
            this.btn_Vingenere.Text = "Vigenere Cypher";
            this.btn_Vingenere.UseVisualStyleBackColor = true;
            this.btn_Vingenere.Click += new System.EventHandler(this.btn_Vingenere_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 258);
            this.Controls.Add(this.btn_Vingenere);
            this.Controls.Add(this.btn_Playfair);
            this.Controls.Add(this.btn_Ceaser);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Ceaser;
        private System.Windows.Forms.Button btn_Playfair;
        private System.Windows.Forms.Button btn_Vingenere;
    }
}
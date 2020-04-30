namespace İkinciElSahaf
{
    partial class KitapTürEkleme
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kitaptur_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Türü";
            // 
            // btn_kitaptur_ekle
            // 
            this.btn_kitaptur_ekle.Location = new System.Drawing.Point(124, 91);
            this.btn_kitaptur_ekle.Name = "btn_kitaptur_ekle";
            this.btn_kitaptur_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_kitaptur_ekle.TabIndex = 2;
            this.btn_kitaptur_ekle.Text = "Ekle";
            this.btn_kitaptur_ekle.UseVisualStyleBackColor = true;
            this.btn_kitaptur_ekle.Click += new System.EventHandler(this.btn_kitaptur_ekle_Click);
            // 
            // KitapTürEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 188);
            this.Controls.Add(this.btn_kitaptur_ekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "KitapTürEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Türü Ekleme Sayfası";
            this.Load += new System.EventHandler(this.KitapTürEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kitaptur_ekle;
    }
}
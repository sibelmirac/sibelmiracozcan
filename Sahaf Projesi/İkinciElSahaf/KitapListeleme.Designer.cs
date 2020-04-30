namespace İkinciElSahaf
{
    partial class KitapListeleme
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
            this.txtBarkodAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.kitapturtxt = new System.Windows.Forms.TextBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SatışFiyattxt = new System.Windows.Forms.TextBox();
            this.Alışfiyattxt = new System.Windows.Forms.TextBox();
            this.Kitapadettxt = new System.Windows.Forms.TextBox();
            this.BaskıSayıtxt = new System.Windows.Forms.TextBox();
            this.Kitapadtxt = new System.Windows.Forms.TextBox();
            this.Yazartxt = new System.Windows.Forms.TextBox();
            this.Barkodtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboKitaptur = new System.Windows.Forms.ComboBox();
            this.comboYazar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYazarGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarkodAra
            // 
            this.txtBarkodAra.Location = new System.Drawing.Point(675, 52);
            this.txtBarkodAra.Name = "txtBarkodAra";
            this.txtBarkodAra.Size = new System.Drawing.Size(100, 20);
            this.txtBarkodAra.TabIndex = 59;
            this.txtBarkodAra.TextChanged += new System.EventHandler(this.txtBarkodAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Barkod Numarası ile Ara";
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(781, 87);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 57;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // kitapturtxt
            // 
            this.kitapturtxt.Location = new System.Drawing.Point(108, 113);
            this.kitapturtxt.Name = "kitapturtxt";
            this.kitapturtxt.ReadOnly = true;
            this.kitapturtxt.Size = new System.Drawing.Size(100, 20);
            this.kitapturtxt.TabIndex = 56;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(133, 309);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_guncelle.TabIndex = 55;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Satış Fiyatı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Alış Fiyatı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Kitap Adedi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Baskı Sayısı";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 50;
            this.label15.Text = "Yazar";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "Kitap Adı";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 116);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 48;
            this.label17.Text = "Kitap Türü";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "Barkod No";
            // 
            // SatışFiyattxt
            // 
            this.SatışFiyattxt.Location = new System.Drawing.Point(108, 269);
            this.SatışFiyattxt.Name = "SatışFiyattxt";
            this.SatışFiyattxt.Size = new System.Drawing.Size(100, 20);
            this.SatışFiyattxt.TabIndex = 47;
            // 
            // Alışfiyattxt
            // 
            this.Alışfiyattxt.Location = new System.Drawing.Point(108, 243);
            this.Alışfiyattxt.Name = "Alışfiyattxt";
            this.Alışfiyattxt.Size = new System.Drawing.Size(100, 20);
            this.Alışfiyattxt.TabIndex = 46;
            // 
            // Kitapadettxt
            // 
            this.Kitapadettxt.Location = new System.Drawing.Point(108, 217);
            this.Kitapadettxt.Name = "Kitapadettxt";
            this.Kitapadettxt.Size = new System.Drawing.Size(100, 20);
            this.Kitapadettxt.TabIndex = 45;
            // 
            // BaskıSayıtxt
            // 
            this.BaskıSayıtxt.Location = new System.Drawing.Point(108, 191);
            this.BaskıSayıtxt.Name = "BaskıSayıtxt";
            this.BaskıSayıtxt.Size = new System.Drawing.Size(100, 20);
            this.BaskıSayıtxt.TabIndex = 44;
            // 
            // Kitapadtxt
            // 
            this.Kitapadtxt.Location = new System.Drawing.Point(108, 139);
            this.Kitapadtxt.Name = "Kitapadtxt";
            this.Kitapadtxt.Size = new System.Drawing.Size(100, 20);
            this.Kitapadtxt.TabIndex = 43;
            // 
            // Yazartxt
            // 
            this.Yazartxt.Location = new System.Drawing.Point(108, 165);
            this.Yazartxt.Name = "Yazartxt";
            this.Yazartxt.ReadOnly = true;
            this.Yazartxt.Size = new System.Drawing.Size(100, 20);
            this.Yazartxt.TabIndex = 42;
            // 
            // Barkodtxt
            // 
            this.Barkodtxt.Location = new System.Drawing.Point(108, 87);
            this.Barkodtxt.Name = "Barkodtxt";
            this.Barkodtxt.Size = new System.Drawing.Size(100, 20);
            this.Barkodtxt.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(231, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 270);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comboKitaptur
            // 
            this.comboKitaptur.FormattingEnabled = true;
            this.comboKitaptur.Location = new System.Drawing.Point(654, 373);
            this.comboKitaptur.Name = "comboKitaptur";
            this.comboKitaptur.Size = new System.Drawing.Size(121, 21);
            this.comboKitaptur.TabIndex = 60;
            this.comboKitaptur.SelectedIndexChanged += new System.EventHandler(this.comboKitaptur_SelectedIndexChanged);
            // 
            // comboYazar
            // 
            this.comboYazar.FormattingEnabled = true;
            this.comboYazar.Location = new System.Drawing.Point(654, 400);
            this.comboYazar.Name = "comboYazar";
            this.comboYazar.Size = new System.Drawing.Size(121, 21);
            this.comboYazar.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Kitap Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Yazar";
            // 
            // btnYazarGuncelle
            // 
            this.btnYazarGuncelle.Location = new System.Drawing.Point(688, 427);
            this.btnYazarGuncelle.Name = "btnYazarGuncelle";
            this.btnYazarGuncelle.Size = new System.Drawing.Size(87, 23);
            this.btnYazarGuncelle.TabIndex = 64;
            this.btnYazarGuncelle.Text = "Yazar Güncelle";
            this.btnYazarGuncelle.UseVisualStyleBackColor = true;
            this.btnYazarGuncelle.Click += new System.EventHandler(this.btnYazarGuncelle_Click);
            // 
            // KitapListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 473);
            this.Controls.Add(this.btnYazarGuncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboYazar);
            this.Controls.Add(this.comboKitaptur);
            this.Controls.Add(this.txtBarkodAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.kitapturtxt);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.SatışFiyattxt);
            this.Controls.Add(this.Alışfiyattxt);
            this.Controls.Add(this.Kitapadettxt);
            this.Controls.Add(this.BaskıSayıtxt);
            this.Controls.Add(this.Kitapadtxt);
            this.Controls.Add(this.Yazartxt);
            this.Controls.Add(this.Barkodtxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KitapListeleme";
            this.Text = "Kitap Listeleme Sayfası";
            this.Load += new System.EventHandler(this.KitapListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarkodAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox kitapturtxt;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox SatışFiyattxt;
        private System.Windows.Forms.TextBox Alışfiyattxt;
        private System.Windows.Forms.TextBox Kitapadettxt;
        private System.Windows.Forms.TextBox BaskıSayıtxt;
        private System.Windows.Forms.TextBox Kitapadtxt;
        private System.Windows.Forms.TextBox Yazartxt;
        private System.Windows.Forms.TextBox Barkodtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboKitaptur;
        private System.Windows.Forms.ComboBox comboYazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYazarGuncelle;
    }
}
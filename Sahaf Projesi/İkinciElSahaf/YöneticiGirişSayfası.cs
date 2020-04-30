using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İkinciElSahaf
{
    public partial class YöneticiGirişSayfası : Form
    {
        public YöneticiGirişSayfası()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreGüncelle sifre = new SifreGüncelle();
            sifre.ShowDialog();
        }

        Kullanıcı_Formu k = new Kullanıcı_Formu();

        private void button1_Click(object sender, EventArgs e)
        {
            k.kullanıcı(txtKullanıcıAdı,txtSifre);
        }

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            k.yenikullanıcı(AdSoyadtxt,KullanıcıAdıtxt,Sifretxt,SifreTekrartxt,Sorutxt,Cevaptxt,groupBox2);
        }

        
    }
}

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
    public partial class SifreGüncelle : Form
    {
        public SifreGüncelle()
        {
            InitializeComponent();
        }

        Kullanıcı_Formu k = new Kullanıcı_Formu();


        private void btn_yenisifre_Click_1(object sender, EventArgs e)
        {
            k.şifre(AdSoyadtxt, KullanıcıAdıtxt, Sifretxt, SifreTekrartxt, Sorutxt, Cevaptxt, groupBox2);
        }


    }
}

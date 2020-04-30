using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace İkinciElSahaf
{
    public partial class ÜyeEkleme : Form
    {
        public ÜyeEkleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=mirac;Initial Catalog=ikinciel_sahaf;Integrated Security=True");

        private void KullanıcıEkleme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut= new SqlCommand("insert into müsteri_liste(tckimlikno,adsoyad,telefon,adres,email) values(@tckimlikno,@adsoyad,@telefon,@adres,@email)",baglanti);
            komut.Parameters.AddWithValue("@tckimlikno",txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad",txtAd.Text);
            komut.Parameters.AddWithValue("@telefon",txtTel.Text);
            komut.Parameters.AddWithValue("@adres",txtAdres.Text);
            komut.Parameters.AddWithValue("@email",txtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Kaydı Yapıldı");
            foreach (Control item in this.Controls)
        	{
                if (item is TextBox)
                {
                    item.Text="";
                }

		 
        	}
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

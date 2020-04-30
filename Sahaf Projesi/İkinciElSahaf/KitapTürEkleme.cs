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
    public partial class KitapTürEkleme : Form
    {
        public KitapTürEkleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=mirac;Initial Catalog=ikinciel_sahaf;Integrated Security=True");
        bool durum;
        private void kitapturengelle()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from kitap_tur", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBox1.Text == read["kitaptur"].ToString() || textBox1.Text == "") 
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void KitapTürEkleme_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_kitaptur_ekle_Click(object sender, EventArgs e)
        {
            kitapturengelle();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into kitap_tur(kitaptur) values('" + textBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                textBox1.Text = "";
                MessageBox.Show("Kitap Türü Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle Bir Tür Daha Önceden Eklenmiş", "Uyarı");
            }
            textBox1.Text = "";
            
        }
    }
}

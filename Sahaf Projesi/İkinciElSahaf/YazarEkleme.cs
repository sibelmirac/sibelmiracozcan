using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İkinciElSahaf
{
    public partial class YazarEkleme : Form
    {
        public YazarEkleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=mirac;Initial Catalog=ikinciel_sahaf;Integrated Security=True");
        bool durum;
        private void yazarengelle()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from yazarlar", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (comboBox1.Text==read["kitaptur"].ToString() && textBox1.Text == read["yazar"].ToString() ||comboBox1.Text=="" || textBox1.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            yazarengelle();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into yazarlar(kitaptur,yazar) values('" + comboBox1.Text + "','" + textBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yazar İsmi Eklendi"); 
            }
            else
            {
                MessageBox.Show("Yazar Daha Önceden Eklenmiş", "Uyarı");
            }
            
            textBox1.Text = "";
            comboBox1.Text = "";
        }
        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from kitap_tur", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["kitaptur"].ToString());
            }
            baglanti.Close();
        }

        private void YazarEkleme_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

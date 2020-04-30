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
    public partial class KitapEkleme : Form
    {
        public KitapEkleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=mirac;Initial Catalog=ikinciel_sahaf;Integrated Security=True");
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from kitap_liste", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkod.Text==read["barkodno"].ToString() || txtBarkod.Text=="")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void kitapturgetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from kitap_tur", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKitaptur.Items.Add(read["kitaptur"].ToString());
            }
            baglanti.Close();
        }

        private void KitapEkleme_Load(object sender, EventArgs e)
        {
            kitapturgetir();
        }



        private void btn_eklenecekkitap_Click(object sender, EventArgs e)
        {

            barkodkontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into kitap_liste(barkodno,kitaptur,kitapad,yazar,baskisayisi,kitapadedi,alisfiyat,satisfiyat,tarih) values(@barkodno,@kitaptur,@kitapad,@yazar,@baskisayisi,@kitapadedi,@alisfiyat,@satisfiyat,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtBarkod.Text);
                komut.Parameters.AddWithValue("@kitaptur", comboKitaptur.Text);
                komut.Parameters.AddWithValue("@kitapad", txtKitapad.Text);
                komut.Parameters.AddWithValue("@yazar", comboYazar.Text);
                komut.Parameters.AddWithValue("@baskisayisi", int.Parse(txtBaskıSayı.Text));
                komut.Parameters.AddWithValue("@kitapadedi", int.Parse(txtKitapAdet.Text));
                komut.Parameters.AddWithValue("@alisfiyat", double.Parse(txtAlışFiyat.Text));
                komut.Parameters.AddWithValue("@satisfiyat", double.Parse(txtSatışFiyat.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kitap Kaydı Yapıldı");   
            }
            else
            {
                MessageBox.Show("Barkod Numarası Daha Önceden Verilmiş","Uyarı");
            }
           
            comboYazar.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }

            }
        }



        private void txtYazar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboKitaptur_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboYazar.Items.Clear();
            comboYazar.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from yazarlar where kitaptur='"+comboKitaptur.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboYazar.Items.Add(read["yazar"].ToString());
            }
            baglanti.Close();
        }

        private void Barkodtxt_TextChanged(object sender, EventArgs e)
        {
            lblMiktar.Text = "";
            if (Barkodtxt.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }

            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from kitap_liste where barkodno like'" + Barkodtxt.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                kitapturtxt.Text = read["kitaptur"].ToString();
                Yazartxt.Text = read["yazar"].ToString();
                lblMiktar.Text = read["kitapadedi"].ToString();
                Kitapadtxt.Text = read["kitapad"].ToString();
                BaskıSayıtxt.Text = read["baskisayisi"].ToString();
                Alışfiyattxt.Text = read["alisfiyat"].ToString();
                SatışFiyattxt.Text = read["satisfiyat"].ToString();

            }
            baglanti.Close();
        }
        private void btn_stoktakikitap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kitap_liste set kitapadedi=kitapadedi+'" + int.Parse(Kitapadettxt.Text) + "' where barkodno='" + Barkodtxt.Text + "'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Stoktaki Kitaplara Ekleme Yapıldı");
        }

    }
}
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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=mirac;Initial Catalog=ikinciel_sahaf;Integrated Security=True");
        DataSet daset = new DataSet();

        private void sepetilistele()
        {
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select*from SepeteEklenenler", baglanti);
            adptr.Fill(daset,"SepeteEklenenler");
            dataGridView1.DataSource = daset.Tables["SepeteEklenenler"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ÜyeEkleme ekle = new ÜyeEkleme();
            ekle.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ÜyeListeleme liste = new ÜyeListeleme();
            liste.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KitapEkleme ekle = new KitapEkleme();
            ekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitapTürEkleme ekle = new KitapTürEkleme();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YazarEkleme ekle = new YazarEkleme();
            ekle.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            KitapListeleme ekle = new KitapListeleme();
            ekle.ShowDialog();
        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyat) from SepeteEklenenler", baglanti);
                lblGenelToplam.Text = komut.ExecuteScalar() + " TL ";
                baglanti.Close();
            }
            catch (Exception)
            {
                
                 ;
            }
        }
       
        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            sepetilistele();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.Text=="")
            {
                txtAdSoyad.Text = "";
                txtTel.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from müsteri_liste where tckimlikno like '" + txtTc.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtTel.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from kitap_liste where barkodno like '" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKitapAd.Text = read["kitapad"].ToString();
                txtSatışFiyat.Text = read["satisfiyat"].ToString();
            }
            baglanti.Close();
        }

        private void temizle()
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtKitapAdedi)
                        {
                            item.Text = "";
                        } 
                    }
                    
                }
            }
        }

        bool durum;
        private void barkodkontrol()
        {
         
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from SepeteEklenenler",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text==read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into SepeteEklenenler(tckimlikno,adsoyad,telefon,barkodno,kitapad,kitapadedi,satisfiyat,toplamfiyat,tarih) values(@tckimlikno,@adsoyad,@telefon,@barkodno,@kitapad,@kitapadedi,@satisfiyat,@toplamfiyat,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tckimlikno", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTel.Text);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kitapad", txtKitapAd.Text);
                komut.Parameters.AddWithValue("@kitapadedi", int.Parse(txtKitapAdedi.Text));
                komut.Parameters.AddWithValue("@satisfiyat", double.Parse(txtSatışFiyat.Text));
                komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(txtToplamFiyat.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update SepeteEklenenler kitapadedi=kitapadedi+ '" + int.Parse(txtKitapAdedi.Text) + "'where barkodno='" + txtBarkodNo.Text + "'", baglanti);
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update SepeteEklenenler toplamfiyat=kitapadedi*satisfiyat where barkodno='" + txtBarkodNo.Text + "'", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }

            txtBarkodNo.Text = "1";
            daset.Tables["SepeteEklenenler"].Clear();
            sepetilistele();
            hesapla();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtKitapAdedi)
                    {
                        item.Text = "";
                    }
                }

            }
        }

        private void txtKitapAdedi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtKitapAdedi.Text) * double.Parse(txtSatışFiyat.Text)).ToString();
            }
            catch (Exception)
            {
                
                ;
            }
        }

        private void txtSatışFiyat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (int.Parse(txtKitapAdedi.Text) * double.Parse(txtSatışFiyat.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from SepeteEklenenler where barkodno='"+dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sepetten Çıkarıldı");
            daset.Tables["SepeteEklenenler"].Clear();
            sepetilistele();
            hesapla();
        }

        private void btnSatisİptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from SepeteEklenenler", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sepetinizdeki Kitaplar Silindi");
            daset.Tables["SepeteEklenenler"].Clear();
            sepetilistele();
            hesapla();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            KitapSatışlarınıListeleme ekle = new KitapSatışlarınıListeleme();
            ekle.ShowDialog();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into kitap_satıs(tckimlikno,adsoyad,telefon,barkodno,kitapad,kitapadedi,satisfiyat,toplamfiyat,tarih) values(@tckimlikno,@adsoyad,@telefon,@barkodno,@kitapad,@kitapadedi,@satisfiyat,@toplamfiyat,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tckimlikno", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTel.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@kitapad", dataGridView1.Rows[i].Cells["kitapad"].Value.ToString());
                komut.Parameters.AddWithValue("@kitapadedi", int.Parse(dataGridView1.Rows[i].Cells["kitapadedi"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyat", double.Parse(dataGridView1.Rows[i].Cells["satisfiyat"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyat"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("update kitap_liste set kitapadedi=kitapadedi-'" + int.Parse(dataGridView1.Rows[i].Cells["kitapadedi"].Value.ToString()) + "' where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Satış Yapıldı");
                baglanti.Close();
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from SepeteEklenenler", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["SepeteEklenenler"].Clear();
            sepetilistele();
            hesapla();
        }

        
        
    }
    
}


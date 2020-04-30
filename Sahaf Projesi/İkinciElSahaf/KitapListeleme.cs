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
    public partial class KitapListeleme : Form
    {
        public KitapListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=mirac;Initial Catalog=ikinciel_sahaf;Integrated Security=True");
        DataSet daset = new DataSet();
        
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
        
        private void KitapListeleme_Load(object sender, EventArgs e)
        {
            KitapListele();
            kitapturgetir();
        }

        private void KitapListele()
        {
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select*from kitap_liste", baglanti);
            adptr.Fill(daset, "kitap_liste");
            dataGridView1.DataSource = daset.Tables["kitap_liste"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Barkodtxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            kitapturtxt.Text = dataGridView1.CurrentRow.Cells["kitaptur"].Value.ToString();
            Kitapadtxt.Text = dataGridView1.CurrentRow.Cells["kitapad"].Value.ToString();
            Yazartxt.Text = dataGridView1.CurrentRow.Cells["yazar"].Value.ToString();
            BaskıSayıtxt.Text = dataGridView1.CurrentRow.Cells["baskisayisi"].Value.ToString();
            Kitapadettxt.Text = dataGridView1.CurrentRow.Cells["kitapadedi"].Value.ToString();
            Alışfiyattxt.Text = dataGridView1.CurrentRow.Cells["alisfiyat"].Value.ToString();
            SatışFiyattxt.Text = dataGridView1.CurrentRow.Cells["satisfiyat"].Value.ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kitap_liste set kitapad=@kitapad, kitapadedi=@kitapadedi,baskisayisi=@baskisayisi,alisfiyat=@alisfiyat,satisfiyat=@satisfiyat where barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("barkodno", Barkodtxt.Text);
            komut.Parameters.AddWithValue("kitapad", Kitapadtxt.Text);
            komut.Parameters.AddWithValue("kitapadedi",int.Parse(Kitapadettxt.Text));
            komut.Parameters.AddWithValue("baskisayisi", int.Parse(BaskıSayıtxt.Text));
            komut.Parameters.AddWithValue("alisfiyat", double.Parse(Alışfiyattxt.Text));
            komut.Parameters.AddWithValue("satisfiyat", double.Parse(SatışFiyattxt.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Günceleme Yapıldı");
            daset.Tables["kitap_liste"].Clear();
            KitapListele();

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnYazarGuncelle_Click(object sender, EventArgs e)
        {
            if (Barkodtxt.Text!="")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update kitap_liste set kitaptur=@kitaptur, yazar=@yazar where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("barkodno", Barkodtxt.Text);
                komut.Parameters.AddWithValue("kitaptur", comboKitaptur.Text);
                komut.Parameters.AddWithValue("yazar", comboYazar.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Günceleme Yapıldı");
                daset.Tables["kitap_liste"].Clear();
                KitapListele();
            }
            else
            {
                MessageBox.Show("Barkod Numarası Yazılı Değil");
            }
            
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
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

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from kitap_liste where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["kitap_liste"].Clear();
            KitapListele();
            MessageBox.Show("Kitap Kaydı Silindi");
        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select*from kitap_liste where barkodno like '" + txtBarkodAra.Text + "%'", baglanti);
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        }
    }


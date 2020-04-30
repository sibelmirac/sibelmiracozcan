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
    public partial class ÜyeListeleme : Form
    {
        public ÜyeListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=mirac;Initial Catalog=ikinciel_sahaf;Integrated Security=True");
        DataSet daset = new DataSet();
        private void MüsteriListeleme_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select adsoyad from müsteri_liste", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["adsoyad"].ToString());
            }
            baglanti.Close();
        }

        private void Kayit_Goster()
        {
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select*from müsteri_liste where adsoyad='"+comboBox1.Text+"'", baglanti);
            adptr.Fill(daset, "müsteri_liste");
            dataGridView1.DataSource = daset.Tables["müsteri_liste"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["tckimlikno"].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update müsteri_liste set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tckimlikno=@tckimlikno", baglanti);
            komut.Parameters.AddWithValue("@tckimlikno", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAd.Text);
            komut.Parameters.AddWithValue("@telefon", txtTel.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["müsteri_liste"].Clear();
            Kayit_Goster();
            MessageBox.Show("Üye Kaydı Güncellendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from müsteri_liste where tckimlikno='" + dataGridView1.CurrentRow.Cells["tckimlikno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["müsteri_liste"].Clear();
            Kayit_Goster();
            MessageBox.Show("Üye Kaydı Silindi");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Kayit_Goster();
        }
    }
}

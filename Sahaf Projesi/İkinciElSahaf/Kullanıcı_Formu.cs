using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace İkinciElSahaf
{
    class Kullanıcı_Formu
    {
        SqlConnection baglanti = new SqlConnection("Data Source=mirac;Initial Catalog=ikinciel_sahaf;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        Anasayfa anasayfa = new Anasayfa();
        
        public SqlDataReader kullanıcı(TextBox kullanıcıadı, TextBox sifre)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText="select*from Kullanicilar1 where kullanici_adi='"+kullanıcıadı.Text+"'";
            read = komut.ExecuteReader();
            if (read.Read()==true)
            {
                if (sifre.Text==read["sifre"].ToString())
                {
                    MessageBox.Show("Giriş Başarılı");
                    anasayfa.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Şifrenizi Kontrol Ediniz", "Hata1");
                }
            }
            else
            {
                MessageBox.Show("Bilgilerinizi Kontrol Ediniz", "Hata2");
            }
            baglanti.Close();
            return read;
        }
        public void yenikullanıcı(TextBox adsoyad,TextBox kullanıcıadı,TextBox sifre, TextBox sifretekrar,TextBox soru,TextBox cevap,GroupBox grup)
        {
            if (sifre.Text==sifretekrar.Text)
            {
                baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "insert into Kullanicilar1 values('" + adsoyad.Text + "','" + kullanıcıadı.Text + "','" + sifre.Text + "','" + soru.Text + "','" + cevap.Text + "')";
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Eklendi");
                foreach (Control item in grup.Controls) if (item is TextBox) item.Text = "";
             }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor","Hata");
            }

        }

        public void şifre(TextBox adsoyad, TextBox kullanıcıadı, TextBox sifre, TextBox sifretekrar, TextBox soru, TextBox cevap, GroupBox grup)
        {
            if (sifre.Text==sifretekrar.Text)
            {
                baglanti.Open();
                komut = new SqlCommand("select*from Kullanicilar1 where kullanici_adi='" + kullanıcıadı.Text + "'", baglanti);
                read = komut.ExecuteReader();
                if (read.Read() == true)
                {
                    if (soru.Text == read["soru"].ToString() && cevap.Text == read["cevap"].ToString())
                    {
                        baglanti.Close();
                        baglanti.Open();
                        komut = new SqlCommand("update Kullanicilar1 set adsoyad='"+adsoyad.Text+"',sifre='"+sifre.Text+"' where kullanici_adi='"+kullanıcıadı.Text+"'",baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("İşlem Başarılıyla Gerçekleşti");
                        foreach (Control item in grup.Controls) if (item is TextBox) item.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı Dışındaki Bilgilerinizi Kontrol Ediniz", "Hata1");
                    }
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi Kontrol Ediniz", "Hata2");
                }
                baglanti.Close();
            }

            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor", "Hata3");
            }
        }
    }
}

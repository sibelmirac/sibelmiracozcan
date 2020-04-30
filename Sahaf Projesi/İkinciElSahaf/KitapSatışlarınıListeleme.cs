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
    public partial class KitapSatışlarınıListeleme : Form
    {
        public KitapSatışlarınıListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=mirac;Initial Catalog=ikinciel_sahaf;Integrated Security=True");
        DataSet daset = new DataSet();

        private void kitapsatislistele()
        {
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select *from kitap_satıs", baglanti);
            adptr.Fill(daset, "kitap_satıs");
            dataGridView1.DataSource = daset.Tables["kitap_satıs"];
            
            baglanti.Close();
        }

        private void KitapSatışlarınıListeleme_Load(object sender, EventArgs e)
        {
            kitapsatislistele();
        }
    }
}

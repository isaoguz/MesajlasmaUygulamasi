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
namespace MesajlasmaUygulamasi
{
    public partial class MesajDetay : Form
    {
        public MesajDetay()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-273NEV0;Initial Catalog=MesajlasmaUygulamasi1;Integrated Security=True");
        void gelenKutusu()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("Select *From TBL_MESAJLAR where ALICI="+numara,baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        
        }
        void gidenKutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select *From TBL_MESAJLAR where GONDEREN=" + numara, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

        }
        private void MesajDetay_Load(object sender, EventArgs e)
        {
            LblNumara.Text = numara;
            gelenKutusu();
            gidenKutusu();

            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select AD,SOYAD from TBL_KISILER where NUMARA =  "+numara,baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            baglanti.Close();



        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBL_MESAJLAR (GONDEREN,ALICI,BASLIK,ICERIK)" +
                "values(@p1,@p2,@p3,@p4)",baglanti);
            komut.Parameters.AddWithValue("@p1",numara);
            komut.Parameters.AddWithValue("@p2", MskAlıcı.Text);
            komut.Parameters.AddWithValue("@p3", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", RchMetin.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesajınız İletildi.");
            gidenKutusu();


        }
    }
}

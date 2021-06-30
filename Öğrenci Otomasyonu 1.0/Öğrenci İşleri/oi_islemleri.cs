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

namespace Öğrenci_Otomasyonu_1._0.Öğrenci_İşleri
{
    public partial class oi_islemleri : Form
    {
        public oi_islemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(ana_giris.baglantistring);
        DataTable tablo = new DataTable();

        //tema renklerini uygulama

        private void butonrenk(Button buton)
        {
            buton.BackColor = ThemeColor.PrimaryColor;
            buton.ForeColor = Color.White;
            buton.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
        }
        private void tablorenk(DataGridView tablo)
        {
            tablo.DefaultCellStyle.ForeColor = Color.White;
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    //MessageBox.Show(i + ".nagihoş");

                    tablo.Rows[i].DefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
                }

                else
                    tablo.Rows[i].DefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            }
        }

        //kayıtlı kullanıcıları listeleme

        private void oi_islemleri_Load(object sender, EventArgs e)
        {
            butonrenk(buttonyenile);
            butonrenk(ekle);
            butonrenk(buttonakademisyensilliste);
            butonrenk(buttonkullanıcısil);
            verilericek();
        }

        private void verilericek()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from ogrisleri_bilgi", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                dataGridView1.Rows.Add(oku["ID"], oku["kullanici_no"], oku["kullanici_ad_soyad"]);
            }
            baglanti.Close();
            tablorenk(dataGridView1);
        }

        private void buttonyenile_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select ID, kullanici_no, kullanici_ad_soyad from ogrisleri_bilgi", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

            tablorenk(dataGridView1);
        }

        //yeni kullanıcı ekleme

        private void ekle_Click(object sender, EventArgs e)
        {
            int j = 1;

            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select * from ogrisleri_bilgi", baglanti);
            SqlDataReader kayitoku = sorgu.ExecuteReader();
            while (kayitoku.Read())
            {
                j++;

            }
            baglanti.Close();


            string yazi = "insert into ogrisleri_bilgi (kullanici_no, kullanici_sifre, kullanici_ad_soyad) values (@no, @sifre, @ad)";
            SqlCommand komut = new SqlCommand(yazi, baglanti);
            komut.Parameters.AddWithValue("@no",  j);
            komut.Parameters.AddWithValue("@sifre", j.ToString());
            komut.Parameters.AddWithValue("@ad", textBox1.Text + " " + textBox2.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            j++;
            MessageBox.Show("Kullancı eklendi.");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1 != null && textBox2 != null)
            {
                ekle.Enabled = true;
            }
            else
                ekle.Enabled = false;
        }

        //kullanıcı silme

        private void buttonakademisyensilliste_Click(object sender, EventArgs e)
        {
            kullanıcısilliste.Items.Clear();
            baglanti.Open();
            SqlCommand sorgu5 = new SqlCommand("select kullanici_no from ogrisleri_bilgi", baglanti);
            SqlDataReader kayitoku5 = sorgu5.ExecuteReader();
            while (kayitoku5.Read())
            {
                kullanıcısilliste.Items.Add(kayitoku5["kullanici_no"]);

            }
            baglanti.Close();
        }

        private void kullanıcısilliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonkullanıcısil.Enabled = true;
        }

        private void buttonkullanıcısil_Click(object sender, EventArgs e)
        {
            string oino = kullanıcısilliste.SelectedItem.ToString();

            string yazi = "delete from ogrisleri_bilgi where kullanici_no=@kullanici_no1";
            SqlCommand komut = new SqlCommand(yazi, baglanti);
            komut.Parameters.AddWithValue("@kullanici_no1", oino);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            buttonkullanıcısil.Enabled = false;

            MessageBox.Show("Kullanıcı silindi");
        }
    }
}

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
    public partial class a_islemleri : Form
    {
        public a_islemleri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ana_giris.baglantistring);
        SqlConnection baglanti2 = new SqlConnection(ana_giris.baglantistring);
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

                    tablo.Rows[i].DefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
                }

                else
                    tablo.Rows[i].DefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            }
        }

        //kayıtlı akadmeisyenleri listeleme

        private void a_islemleri_Load(object sender, EventArgs e)
        {

            butonrenk(buttonlistele);
            butonrenk(ekle1);
            butonrenk(buttonakademisyensilliste);
            butonrenk(buttonakademisyensil);
            verilericek();
        }

        private void verilericek()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ID, akademisyen_no, akademisyen_ad_soyad, bolum from akademisyen_bilgi", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                dataGridView1.Rows.Add(oku["ID"], oku["bolum"], oku["akademisyen_no"], oku["akademisyen_ad_soyad"]);
            }
            baglanti.Close();
            tablorenk(dataGridView1);
        }

        //kayıtlı akadmeisyenleri filtreleyrek listeleme

        private void filtre_CheckedChanged(object sender, EventArgs e)
        {
            if (filtre.Checked == true)
            {
                liste1.Enabled = true;
                liste1.SelectedIndex = 0;
            }
            else if (filtre.Checked == false)
            {
                liste1.Enabled = false;
            }
        }

        private void buttonlistele_Click(object sender, EventArgs e)
        {
            if (filtre.Checked == true)
            {

                if (liste1.SelectedItem.ToString() != null)
                {
                    string bolumadi = liste1.SelectedItem.ToString();

                    tablo.Clear();
                    baglanti.Open();
                    SqlDataAdapter adtr = new SqlDataAdapter("select ID, akademisyen_no, akademisyen_ad_soyad, bolum from akademisyen_bilgi where bolum=@bolum1", baglanti);
                    adtr.SelectCommand.Parameters.AddWithValue("@bolum1", bolumadi);
                    adtr.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    baglanti.Close();

                }
                else
                    MessageBox.Show("hata");
            }
            else
            {
                tablo.Clear();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select ID, akademisyen_no, akademisyen_ad_soyad, bolum from akademisyen_bilgi", baglanti);
                //adtr.SelectCommand.Parameters.AddWithValue("@akts1", 5);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }

            tablorenk(dataGridView1);
        }

        //akademisyen ekleme

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ekle1.Enabled = true;
        }


        private void ekle1_Click(object sender, EventArgs e)
        {
            int bolumno, i = 1;
            if (textBox1 != null && textBox2 != null)
            {
                ekle.Enabled = true;
            }
            if (liste2.SelectedIndex == 0)
                bolumno = 101000;
            else if (liste2.SelectedIndex == 1)
                bolumno = 102000;
            else if (liste2.SelectedIndex == 2)
                bolumno = 103000;
            else if (liste2.SelectedIndex == 3)
                bolumno = 104000;
            else if (liste2.SelectedIndex == 4)
                bolumno = 105000;
            else
                bolumno = 106000;

            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select * from akademisyen_bilgi", baglanti);
            SqlDataReader kayitoku = sorgu.ExecuteReader();
            while (kayitoku.Read())
            {
                i++;

            }
            baglanti.Close();


            string yazi = "insert into akademisyen_bilgi (akademisyen_no, akademisyen_sifre, akademisyen_ad_soyad, bolum) values (@no, @sifre, @ad, @bolum)";
            SqlCommand komut = new SqlCommand(yazi, baglanti);
            komut.Parameters.AddWithValue("@no", bolumno * 2000 + i);
            komut.Parameters.AddWithValue("@sifre", (bolumno * 2000 + i).ToString());
            komut.Parameters.AddWithValue("@ad", textBox4.Text + " " + textBox3.Text);
            komut.Parameters.AddWithValue("@bolum", comboBox1.SelectedItem.ToString());
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Akademisyen eklendi.");
        }

        //akademisyen silme

        private void buttonakademisyensilliste_Click(object sender, EventArgs e)
        {
            akademisyensilliste.Items.Clear();
            baglanti.Open();
            SqlCommand sorgu5 = new SqlCommand("select akademisyen_no from akademisyen_bilgi", baglanti);
            SqlDataReader kayitoku5 = sorgu5.ExecuteReader();
            while (kayitoku5.Read())
            {
                akademisyensilliste.Items.Add(kayitoku5["akademisyen_no"]);

            }
            baglanti.Close();
        }

        private void akademisyensilliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonakademisyensil.Enabled = true;
        }

        private string akademisyenisimbulucu(int akno)
        {
            string isim = "";

            SqlCommand komut3 = new SqlCommand("select akademisyen_ad_soyad from akademisyen_bilgi where akademisyen_no=@akno1", baglanti2);
            komut3.Parameters.AddWithValue("@akno1", akno);
            baglanti2.Open();
            SqlDataReader oku3 = komut3.ExecuteReader();
            if (oku3.Read())
            {
                isim = oku3["akademisyen_ad_soyad"].ToString();
            }
            baglanti2.Close();
            return isim;
        }

        private int akademisyenidbulucu(int akno)
        {
            int id = 0;

            SqlCommand komut3 = new SqlCommand("select ID from akademisyen_bilgi where akademisyen_no=@akno1", baglanti2);
            komut3.Parameters.AddWithValue("@akno1", akno);
            baglanti2.Open();
            SqlDataReader oku3 = komut3.ExecuteReader();
            if (oku3.Read())
            {
                id = Convert.ToInt32(oku3["ID"]);
            }
            baglanti2.Close();
            return id;
        }

        private void buttonakademisyensil_Click(object sender, EventArgs e)
        {
            string akno = akademisyensilliste.SelectedItem.ToString();
            bool kontrol1=false, kontrol2 = false;

            SqlCommand komut1 = new SqlCommand("select akademisyen from dersler where akademisyen=@ad", baglanti);
            komut1.Parameters.AddWithValue("@ad", akademisyenisimbulucu(Convert.ToInt32(akno)));
            baglanti.Open();
            SqlDataReader oku1 = komut1.ExecuteReader();
            if (oku1.Read())
            {
                kontrol1 = true;
                MessageBox.Show("Seçilen akademisyen ders veriyor!");
            }
            baglanti.Close();

            SqlCommand komut2 = new SqlCommand("select danisman_id from ogrenci_bilgi where danisman_id=@no1", baglanti);
            komut2.Parameters.AddWithValue("@no1", akademisyenidbulucu(Convert.ToInt32(akno)));
            baglanti.Open();
            SqlDataReader oku2 = komut2.ExecuteReader();
            if (oku2.Read())
            {
                kontrol2 = true;
                MessageBox.Show("Seçili akadmeisyen danışman!!");
            }
            baglanti.Close();

            if (kontrol1 || kontrol2)
            {
                //MessageBox.Show("adam ders veriyor");
            }
            else
            {
                string yazi = "delete from akademisyen_bilgi where akademisyen_no=@akademisyen_no1";
                SqlCommand komut = new SqlCommand(yazi, baglanti);
                komut.Parameters.AddWithValue("@akademisyen_no1", akno);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                buttonakademisyensil.Enabled = false;

                MessageBox.Show("Akademisyen silindi.");
            }


        }
    }
}

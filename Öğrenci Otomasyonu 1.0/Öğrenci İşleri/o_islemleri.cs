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
    public partial class o_islemleri : Form
    {

        public o_islemleri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ana_giris.baglantistring);
        DataTable tablo = new DataTable();
        string dogum_tarihi;
        List<int> akademisyenidleri = new List<int>();

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

        //kayıtlı öğrencileri listeleme

        private void o_islemleri_Load(object sender, EventArgs e)
        {
            butonrenk(buttonlistele);
            butonrenk(ekle);
            butonrenk(ogrencisilliste);
            butonrenk(buttonogrencisil);
            verilericek();
            liste2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            danismanliste();

        }

        private void verilericek()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ID, bolum, ogrenci_no, ogrenci_ad_soyad, kayit_tarihi, sinif from ogrenci_bilgi", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                dataGridView1.Rows.Add(oku["ID"], oku["bolum"], oku["ogrenci_no"], oku["ogrenci_ad_soyad"], oku["kayit_tarihi"], oku["sinif"]);
            }
            baglanti.Close();
            tablorenk(dataGridView1);
        }

        //kayıtlı öğrencileri filtreleyerek listeleme

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
                    SqlDataAdapter adtr = new SqlDataAdapter("select ID, ogrenci_no, ogrenci_ad_soyad, bolum, kayit_tarihi, sinif from ogrenci_bilgi where bolum=@bolum1", baglanti);
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
                SqlDataAdapter adtr = new SqlDataAdapter("select ID, ogrenci_no, ogrenci_ad_soyad, bolum, kayit_tarihi, sinif from ogrenci_bilgi", baglanti);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }

            tablorenk(dataGridView1);

        }

        //yeni öğrenci ekleme

        private void danismanliste()
        {
            akademisyenidleri.Clear();
            comboBox_danisman.Items.Clear();
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from akademisyen_bilgi where bolum=@bolum1", baglanti);
            komut.Parameters.AddWithValue("@bolum1", liste2.SelectedItem.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox_danisman.Items.Add(oku["akademisyen_ad_soyad"].ToString());
                akademisyenidleri.Add(Convert.ToInt32(oku["ID"]));
            }

            baglanti.Close();
        }

        

        private void ekle_Click(object sender, EventArgs e)
        {
            int bolumno, i = 0;
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
            else 
                bolumno = 105000;

            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select * from ogrenci_bilgi", baglanti);
            SqlDataReader kayitoku = sorgu.ExecuteReader();
            while (kayitoku.Read())
            {
                i = Convert.ToInt32(kayitoku["ID"]);
            }
            baglanti.Close();

            
            string yazi = "insert into ogrenci_bilgi (ogrenci_no, ogrenci_sifre, ogrenci_ad_soyad, bolum, kayit_tarihi, sinif, kimlik_no, anne_ad, baba_ad, dogum_tarihi, danisman_id) values (@no, @sifre, @ad, @bolum, @kayittarihi, @sinif1, @kimlik1, @anne, @baba, @dogum, @danisman_id1)";
            SqlCommand komut = new SqlCommand(yazi, baglanti);
            komut.Parameters.AddWithValue("@no", bolumno * 1000 + i +1);
            komut.Parameters.AddWithValue("@sifre", (bolumno*1000+i+1).ToString());
            komut.Parameters.AddWithValue("@ad", textBox1.Text + " " + textBox2.Text);
            komut.Parameters.AddWithValue("@bolum", liste2.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@kayittarihi", DateTime.Now.ToShortDateString());
            komut.Parameters.AddWithValue("@sinif1", comboBox1.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@kimlik1", textBox_kimlikno.Text);
            komut.Parameters.AddWithValue("@anne", textBox_anne.Text);
            komut.Parameters.AddWithValue("@baba", textBox_baba.Text);
            komut.Parameters.AddWithValue("@dogum", dogum_tarihi);
            komut.Parameters.AddWithValue("@danisman_id1", akademisyenidleri[comboBox_danisman.SelectedIndex]);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Öğrenci eklendi.");
        }

        private void liste2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ekle.Enabled = true;
            danismanliste();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dogum_tarihi=dateTimePicker1.Value.ToShortDateString().ToString();
        }

        //kayıtlı öğrenci silme

        private void ogrencisilliste_Click(object sender, EventArgs e)
        {
            ogrencisillistee.Items.Clear();
            baglanti.Open();
            SqlCommand sorgu5 = new SqlCommand("select ogrenci_no from ogrenci_bilgi", baglanti);
            SqlDataReader kayitoku5 = sorgu5.ExecuteReader();
            while (kayitoku5.Read())
            {
                ogrencisillistee.Items.Add(kayitoku5["ogrenci_no"]);

            }
            baglanti.Close();
        }

        private void dersilmeliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonogrencisil.Enabled = true;
        }

        private void buttonogrencisil_Click(object sender, EventArgs e)
        {
            string ogrno = ogrencisillistee.SelectedItem.ToString();

            string yazi = "delete from ogrenci_bilgi where ogrenci_no=@ogrenci_no1";
            SqlCommand komut = new SqlCommand(yazi, baglanti);
            komut.Parameters.AddWithValue("@ogrenci_no1", ogrno);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            buttonogrencisil.Enabled = false;
        }

        
    }
}

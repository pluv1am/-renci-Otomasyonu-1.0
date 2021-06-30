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
    public partial class d_islemleri : Form
    {
        public d_islemleri()
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

        // kayıtlı derleri listeleme

        private void d_islemleri_Load(object sender, EventArgs e)
        {

            butonrenk(buttonlistele);
            butonrenk(ekle);
            butonrenk(button);
            butonrenk(buttonderssil);



            listebolum.SelectedIndex = 0;
            listeakts.SelectedIndex = 0;
            listesinif.SelectedIndex = 0;
            verileriyukle();

            baglanti.Open();
            SqlCommand sorgu2 = new SqlCommand("select * from akademisyen_bilgi", baglanti);
            SqlDataReader kayitoku2 = sorgu2.ExecuteReader();
            while (kayitoku2.Read())
            {
                listeakademisyen.Items.Add(kayitoku2["akademisyen_ad_soyad"]);

            }
            baglanti.Close();
            //listeakademisyen.SelectedIndex = 0;
        }

        private void verileriyukle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ID, ders_adi, ders_kodu, bolum, akts, sinif, akademisyen from dersler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                dataGridView1.Rows.Add(oku["ID"], oku["ders_adi"], oku["ders_kodu"], oku["bolum"], oku["akts"], oku["sinif"], oku["akademisyen"]);
            }
            baglanti.Close();
            tablorenk(dataGridView1);
        }

        //ders ekleme

        private void ekle_Click(object sender, EventArgs e)
        {
            int i = 1;
            string bolumno;
            
            if (listebolum.SelectedIndex == 0)
                bolumno = "BM";
            else if (listebolum.SelectedIndex == 1)
                bolumno = "EEM";
            else if (listebolum.SelectedIndex == 2)
                bolumno = "MM";
            else if (listebolum.SelectedIndex == 3)
                bolumno = "IM";
            else
                bolumno = "KM";

            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select * from dersler", baglanti);
            SqlDataReader kayitoku = sorgu.ExecuteReader();
            while (kayitoku.Read())
            {
                i++;

            }
            baglanti.Close();

            


            string yazi = "insert into dersler (ders_adi, ders_kodu, bolum, akts, sinif, akademisyen, ba, bb, cb, cc, dc, ff) values (@ad, @kod, @bolum, @akts,@sinif, @akademisyen, @ba, @bb, @cb, @cc, @dc, @ff)";
            SqlCommand komut = new SqlCommand(yazi, baglanti);
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("@kod", bolumno + (Convert.ToInt32(listesinif.SelectedItem)*100 + i).ToString());
            komut.Parameters.AddWithValue("@bolum", listebolum.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@akts", listeakts.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@sinif", listesinif.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@akademisyen", listeakademisyen.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@ba", 90);
            komut.Parameters.AddWithValue("@bb", 80);
            komut.Parameters.AddWithValue("@cb", 70);
            komut.Parameters.AddWithValue("@cc", 60);
            komut.Parameters.AddWithValue("@dc", 50);
            komut.Parameters.AddWithValue("@ff", 40);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ders eklendi.");
        }

        //filtre ile dersleri listeleme

        private void listeakademisyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ekle.Enabled = true;
        }


        private void buttonlistele_Click(object sender, EventArgs e)
        {
            if(filtrebolum.Checked != true && filtresinif.Checked != true && filtreakademisyen.Checked!=true)
            {
                tablo.Clear();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select ID, ders_adi, ders_kodu, bolum, akts, sinif, akademisyen from dersler", baglanti);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

                //tablorenk(dataGridView1);
            }

            else if (filtrebolum.Checked == true && filtresinif.Checked == true && filtreakademisyen.Checked == true)//1,2,3
            {
                string bolumadi = listebolum2.SelectedItem.ToString();
                string sinif = listesinif2.SelectedItem.ToString();
                string akademisyen = listeakademisyen2.SelectedItem.ToString();


                tablo.Clear();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select ID, ders_adi, ders_kodu, bolum, akts, sinif, akademisyen from dersler where bolum=@bolum1 and sinif=@sinif1 and akademisyen=@akademisyen1", baglanti);
                adtr.SelectCommand.Parameters.AddWithValue("@bolum1", bolumadi);
                adtr.SelectCommand.Parameters.AddWithValue("@sinif1", sinif);
                adtr.SelectCommand.Parameters.AddWithValue("@akademisyen1", akademisyen);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }



            else if (filtrebolum.Checked == true && filtresinif.Checked == true)//1,2
            {
                string bolumadi = listebolum2.SelectedItem.ToString();
                string sinif = listesinif2.SelectedItem.ToString();

                tablo.Clear();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select ID, ders_adi, ders_kodu, bolum, akts, sinif, akademisyen from dersler where bolum=@bolum1 and sinif=@sinif1", baglanti);
                adtr.SelectCommand.Parameters.AddWithValue("@bolum1", bolumadi);
                adtr.SelectCommand.Parameters.AddWithValue("@sinif1", sinif);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

            else if (filtrebolum.Checked == true && filtreakademisyen.Checked == true)//1,3
            {
                string bolumadi = listebolum2.SelectedItem.ToString();
                string akademisyen = listeakademisyen2.SelectedItem.ToString();

                tablo.Clear();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select ID, ders_adi, ders_kodu, bolum, akts, sinif, akademisyen from dersler where bolum=@bolum1 and akademisyen=@akademisyen1", baglanti);
                adtr.SelectCommand.Parameters.AddWithValue("@bolum1", bolumadi);
                adtr.SelectCommand.Parameters.AddWithValue("@akademisyen1", akademisyen);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

            else if (filtresinif.Checked == true && filtreakademisyen.Checked == true)//2,3
            {
                string sinif = listesinif2.SelectedItem.ToString();
                string akademisyen = listeakademisyen2.SelectedItem.ToString();

                tablo.Clear();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select ID, ders_adi, ders_kodu, bolum, akts, sinif, akademisyen from dersler where sinif=@sinif1 and akademisyen=@akademisyen1", baglanti);
                adtr.SelectCommand.Parameters.AddWithValue("@sinif1", sinif);
                adtr.SelectCommand.Parameters.AddWithValue("@akademisyen1", akademisyen);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

            

            else if (filtrebolum.Checked == true)//1
            {
                string bolumadi = listebolum2.SelectedItem.ToString();

                tablo.Clear();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select ID, ders_adi, ders_kodu, bolum, akts, sinif, akademisyen from dersler where bolum=@bolum1", baglanti);
                adtr.SelectCommand.Parameters.AddWithValue("@bolum1", bolumadi);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

            else if (filtresinif.Checked == true)//2
            {
                string sinif = listesinif2.SelectedItem.ToString();

                tablo.Clear();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select ID, ders_adi, ders_kodu, bolum, akts, sinif, akademisyen from dersler where sinif=@sinif1", baglanti);
                adtr.SelectCommand.Parameters.AddWithValue("@sinif1", sinif);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

            else //3
            {
                string akademisyen = listeakademisyen2.SelectedItem.ToString();

                tablo.Clear();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select ID, ders_adi, ders_kodu, bolum, akts, sinif, akademisyen from dersler where akademisyen=@akademisyen1", baglanti);
                adtr.SelectCommand.Parameters.AddWithValue("@akademisyen1", akademisyen);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

            tablorenk(dataGridView1);

        }

        private void filtreakademisyen_CheckedChanged(object sender, EventArgs e)
        {
            if (filtreakademisyen.Checked == true)
            {

                listeakademisyen2.Enabled = true;

                baglanti.Open();
                SqlCommand sorgu5 = new SqlCommand("select akademisyen_ad_soyad from akademisyen_bilgi", baglanti);
                SqlDataReader kayitoku5 = sorgu5.ExecuteReader();
                while (kayitoku5.Read())
                {
                    listeakademisyen2.Items.Add(kayitoku5["akademisyen_ad_soyad"]);

                }
                baglanti.Close();

                listeakademisyen2.SelectedIndex = 0;
            }
            else if (filtreakademisyen.Checked == false)
            {
                listeakademisyen2.Enabled = false;
            }
        }

        private void filtrebolum_CheckedChanged(object sender, EventArgs e)
        {
            if (filtrebolum.Checked == true)
            {
                listebolum2.Enabled = true;
                listebolum2.SelectedIndex = 0;
            }
            else if (filtrebolum.Checked == false)
            {
                listebolum2.Enabled = false;
            }
        }

        private void filtresinif_CheckedChanged(object sender, EventArgs e)
        {
            if (filtresinif.Checked == true)
            {
                listesinif2.Enabled = true;
                listesinif2.SelectedIndex = 0;
            }
            else if (filtresinif.Checked == false)
            {
                listesinif2.Enabled = false;
            }
        }



        private void butıonlistele_Click(object sender, EventArgs e)
        {
            dersilmeliste.Items.Clear();
            baglanti.Open();
            SqlCommand sorgu5 = new SqlCommand("select ders_kodu from dersler", baglanti);
            SqlDataReader kayitoku5 = sorgu5.ExecuteReader();
            while (kayitoku5.Read())
            {
                dersilmeliste.Items.Add(kayitoku5["ders_kodu"]);

            }
            baglanti.Close();
        }

        //ders silme

        private int dersidbulucu(string derskod)
        {
            int id=0;

            SqlCommand komut2 = new SqlCommand("select ID from dersler where ders_kodu=@kod", baglanti2);
            komut2.Parameters.AddWithValue("@kod", derskod);
            baglanti2.Open();
            SqlDataReader oku2 = komut2.ExecuteReader();
            if (oku2.Read())
            {
                id = Convert.ToInt32(oku2["ID"]);
            }
            baglanti2.Close();
            return id;
        }

        private void buttonderssil_Click(object sender, EventArgs e)
        {
            string derskodu = dersilmeliste.SelectedItem.ToString();
            bool kontrol1 = false, kontrol2 = false;

            SqlCommand komut3 = new SqlCommand("select * from ders_kayit where ders_id=@no", baglanti);
            komut3.Parameters.AddWithValue("@no", dersidbulucu(derskodu));
            baglanti.Open();
            SqlDataReader oku3 = komut3.ExecuteReader();
            if (oku3.Read())
            {
                kontrol1 = true;
                MessageBox.Show("Ders kaydı mevcut, dersi silemezsiniz.");
            }
            baglanti.Close();

            SqlCommand komut4 = new SqlCommand("select * from ders_on_kayit where ders_id=@no", baglanti);
            komut4.Parameters.AddWithValue("@no", dersidbulucu(derskodu));
            baglanti.Open();
            SqlDataReader oku4 = komut4.ExecuteReader();
            if (oku4.Read())
            {
                kontrol2 = true;
                MessageBox.Show("Ders ön kaydı mevcut, dersi silemezsiniz.");
            }
            baglanti.Close();


            if (kontrol1 == true || kontrol2 == true)
            {
            }

            else
            {
                string yazi = "delete from dersler where ders_kodu=@derskodu1";
                SqlCommand komut = new SqlCommand(yazi, baglanti);
                komut.Parameters.AddWithValue("@derskodu1", derskodu);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Ders silindi.");
            }

            

        }

        private void dersilmeliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonderssil.Enabled = true;
        }

    }
}

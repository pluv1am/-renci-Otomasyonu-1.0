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

namespace Öğrenci_Otomasyonu_1._0.Öğrenci
{
    public partial class ders_islemleri : Form
    {
        public ders_islemleri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ana_giris.baglantistring);
        int silinecekdersid;
        List<int> ogrencininalalmayacalistigidersler = new List<int>();
        List<string> durumlar = new List<string>();

        //tema renklerini uygulama

        private void butonrenk(Button buton)
        {
            buton.BackColor = ThemeColor.PrimaryColor;
            buton.ForeColor = Color.White;
            buton.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
        }
        private void tablorenk(DataGridView dataGridView1)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if(i%2==0)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor= ThemeColor.PrimaryColor;
                else
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            }
        }

        ////////////////////////////////// ders listele ////////////////////////////////////////////////////

        private void ders_islemleri_Load(object sender, EventArgs e)
        {
            
            butonrenk(buttonlistele); //buttonderseklelistele
            butonrenk(buttonderseklelistele);
            butonrenk(buttonderskayit);
            butonrenk(button1);
            butonrenk(button3);
            butonrenk(button2);
            
            derslerilistele();
            on_kayitlari_gor();
            
        }

        private void buttonlistele_Click(object sender, EventArgs e)
        {
            derslerilistele();
        }

        private void derslerilistele()
        {
            dataGridView1.Rows.Clear();
            List<int> dersler = new List<int>();
            dersler = ogrencihangiderslerialiyor();

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from dersler", baglanti);
            SqlDataReader oku2 = komut5.ExecuteReader();

            while (oku2.Read())
            {
                for (int i = 0; i < dersler.Count(); i++)
                {
                    {
                        if (Convert.ToInt32(oku2["ID"]) == dersler[i])
                        {
                            dataGridView1.Rows.Add(oku2["ders_adi"], oku2["ders_kodu"], oku2["bolum"], oku2["akts"], oku2["sinif"], oku2["akademisyen"]);
                        }
                    }
                }

            }
            baglanti.Close();
            tablorenk(dataGridView1);
        }

        private List<int> ogrencihangiderslerialiyor()
        {
            List<int> dersler = new List<int>();
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select ders_id from ders_kayit where ogrenci_no=@ogrno", baglanti);
            komut4.Parameters.AddWithValue("@ogrno", Convert.ToInt32(ogr_giris.ogrenci_no));
            SqlDataReader oku = komut4.ExecuteReader();
            while (oku.Read())
            {
                dersler.Add(Convert.ToInt32(oku["ders_id"]));
            }
            baglanti.Close();
            return dersler;
        }

        private List<int> on_kayitli_dersler()
        {
            List<int> dersler = new List<int>();
            durumlar.Clear();
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select ders_id, durum from ders_on_kayit where ogrenci_no=@ogrno", baglanti);
            komut4.Parameters.AddWithValue("@ogrno", Convert.ToInt32(ogr_giris.ogrenci_no));
            SqlDataReader oku = komut4.ExecuteReader();
            while (oku.Read())
            {
                durumlar.Add(oku["durum"].ToString());
                dersler.Add(Convert.ToInt32(oku["ders_id"]));
            }
            baglanti.Close();
            return dersler;
        }


        ////////////////////////////////// ders kayıt ////////////////////////////////////////////////////
        private void buttonderseklelistele_Click(object sender, EventArgs e)
        {
            on_kayitlari_gor();
            dersekleliste.Items.Clear();
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select ders_kodu from dersler where bolum=@bolumadi1", baglanti);
            sorgu.Parameters.AddWithValue("@bolumadi1", ogr_giris.ogrenci_bolum);
            SqlDataReader kayitoku = sorgu.ExecuteReader();
            while (kayitoku.Read())
            {
                dersekleliste.Items.Add(kayitoku["ders_kodu"]);

            }
            baglanti.Close();

            dersekleliste.Enabled = true;
            dersekleliste.SelectedIndex = 0;
        }

        private void dersekleliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonderskayit.Enabled = true;
        }
        //ön kayıt//

        private void buttonderskayit_Click(object sender, EventArgs e)
        {
            string yazi = "insert into ders_on_kayit (ogrenci_no, ders_id, danisman_id, durum) values (@ogrno, @dersno, @danismanno, @durum1)";
            string yazi1 = "select ogrenci_no, ders_id from ders_on_kayit where ogrenci_no=@ogrno1 and ders_id=@dersno1";
            Console.WriteLine(yazi1);
            string secilenders = dersekleliste.SelectedItem.ToString();
            int secilendersid = 0;

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select ID from dersler where ders_kodu=@derskodu1", baglanti);
            komut1.Parameters.AddWithValue("@derskodu1", secilenders);
            SqlDataReader oku = komut1.ExecuteReader();
            if (oku.Read())
            {
                secilendersid = Convert.ToInt32(oku["ID"]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand(yazi1, baglanti);
            komut3.Parameters.AddWithValue("@ogrno1", Convert.ToInt32(ogr_giris.ogrenci_no));
            komut3.Parameters.AddWithValue("@dersno1", secilendersid);
            SqlDataReader oku3 = komut3.ExecuteReader();

            if (oku3.Read())
            {
                MessageBox.Show("Bu derse zaten kayıtlısınız!");
                baglanti.Close();
            }

            else
            {
                baglanti.Close();
                SqlCommand komut2 = new SqlCommand(yazi, baglanti);
                komut2.Parameters.AddWithValue("@ogrno", Convert.ToInt32(ogr_giris.ogrenci_no));
                komut2.Parameters.AddWithValue("@dersno", secilendersid);
                komut2.Parameters.AddWithValue("@danismanno", ogr_giris.ogrenci_danisman_id);
                komut2.Parameters.AddWithValue("@durum1", "Danışman onayı bekleniyor");
                baglanti.Open();
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ders kaydı başarılı!");
                on_kayitlari_gor();
            }

            dersekleliste.Enabled = false;
            
        }

        private void on_kayitlari_gor()
        {
            dataGridView2.Rows.Clear();
            List<int> dersler = new List<int>();
            dersler = on_kayitli_dersler();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from dersler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                for(int i =0; i < dersler.Count; i++)
                {
                    if(Convert.ToInt32(oku["ID"]) == dersler[i])
                    {
                        dataGridView2.Rows.Add(oku["ders_adi"], oku["ders_kodu"], oku["akts"], oku["sinif"], oku["akademisyen"], durumlar[i]);
                    }
                }
            }
            tablorenk(dataGridView2);
            baglanti.Close();
        }

        ////////////////////////////////// ders silme ////////////////////////////////////////////////////
        /////////////////////////yeni ders silme

        private void button3_Click(object sender, EventArgs e)
        {

            List<int> dersler = new List<int>();
            dersler = on_kayitli_dersler();

            comboBox1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from dersler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                for (int i = 0; i < dersler.Count(); i++)
                {
                    {
                        if (Convert.ToInt32(oku["ID"]) == dersler[i])
                        {
                            comboBox1.Items.Add(oku["ders_kodu"]);
                        }
                    }
                }

            }
            baglanti.Close();
            comboBox1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            silinecekdersid = dersidbulucu(comboBox1.SelectedItem.ToString());
        }

        private int dersidbulucu(string derskodu)
        {
            int id;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ID from dersler where ders_kodu=@derskodu1", baglanti);
            komut.Parameters.AddWithValue("@derskodu1", derskodu);
            SqlDataReader oku = komut.ExecuteReader();
            oku.Read();
            id = Convert.ToInt32(oku["ID"]);
            baglanti.Close();

            return id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from ders_on_kayit where ders_id=@dersid1 and ogrenci_no=@ogrno1", baglanti);
            komut.Parameters.AddWithValue("@dersid1", silinecekdersid);
            komut.Parameters.AddWithValue("@ogrno1", ogr_giris.ogrenci_no);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ders silme başarılı!");

            on_kayitlari_gor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            derslerilistele();
            on_kayitlari_gor();
            tablorenk(dataGridView2);
        }
    }
}

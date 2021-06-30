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

namespace Öğrenci_Otomasyonu_1._0.Akademisyen
{
    public partial class danisman : Form
    {
        public danisman()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ana_giris.baglantistring);
        SqlConnection baglanti1 = new SqlConnection(ana_giris.baglantistring);
        SqlConnection baglanti2 = new SqlConnection(ana_giris.baglantistring);
        List<int> ogrenciler = new List<int>();
        List<int> onkayit_id = new List<int>();
        List<string> onkayit_durum = new List<string>();


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
                if (i % 2 == 0)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
                else
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            }
        }

        private void danisman_Load(object sender, EventArgs e)
        {
            butonrenk(button1);
            butonrenk(Yenile);
            butonrenk(button2);

            on_kayitlari_gor();

            tablorenk(dataGridView2);
        }

        //danışmanı olunan öğörencileirn ders onaylarını listeleme
        private List<int> on_kayitli_dersler()
        {

            List<int> dersler = new List<int>();
            onkayit_durum.Clear();
            onkayit_id.Clear();
            ogrenciler.Clear();
            dersler.Clear();
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select ID, ders_id, ogrenci_no, durum from ders_on_kayit where danisman_id=@danismanno and durum=@durum1", baglanti);
            komut4.Parameters.AddWithValue("@danismanno", Convert.ToInt32(akdmsyn_giris.akademisyen_id));
            komut4.Parameters.AddWithValue("@durum1", "Danışman onayı bekleniyor");
            SqlDataReader oku = komut4.ExecuteReader();
            while (oku.Read())
            {
                ogrenciler.Add(Convert.ToInt32(oku["ogrenci_no"]));
                dersler.Add(Convert.ToInt32(oku["ders_id"]));
                onkayit_id.Add(Convert.ToInt32(oku["ID"]));
                onkayit_durum.Add(oku["durum"].ToString());
            }
            baglanti.Close();
            return dersler;
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
                for (int i = 0; i < dersler.Count; i++)
                {
                    if (Convert.ToInt32(oku["ID"]) == dersler[i])
                    {
                        dataGridView2.Rows.Add(onkayit_id[i], ogrenciler[i], ogrenciisimbulucu(ogrenciler[i]), oku["ders_adi"], oku["ders_kodu"], oku["akts"], oku["sinif"], oku["akademisyen"], onkayit_durum[i]);
                    }
                }
            }
            baglanti.Close();
        }

        private string ogrenciisimbulucu(int no)
        {
            string ad;

            baglanti1.Open();

            SqlCommand komut = new SqlCommand("select ogrenci_ad_soyad from ogrenci_bilgi where ogrenci_no=@ogrno", baglanti1);
            komut.Parameters.AddWithValue("@ogrno", no);
            SqlDataReader oku = komut.ExecuteReader();
            oku.Read();
            ad = oku["ogrenci_ad_soyad"].ToString();
            baglanti1.Close();
            return ad;
        }

        private int dersidbulucu(string derskodu)
        {
            int id;

            baglanti2.Open();
            SqlCommand komut = new SqlCommand("select ID from dersler where ders_kodu=@derskodu", baglanti2);
            komut.Parameters.AddWithValue("@derskodu", derskodu);
            SqlDataReader oku = komut.ExecuteReader();
            oku.Read();
            id = Convert.ToInt32(oku["ID"]);
            baglanti2.Close();

            return id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> k_ogrenciler = new List<int>();
            List<int> k_dersler = new List<int>();

            int i = dataGridView2.SelectedRows.Count;
            int[] kaydedileceksatirlar = new int[i];

            if (dataGridView2.SelectedRows.Count > 0)
            {
                
                for (int j = 0; j < i; j++)
                {
                    kaydedileceksatirlar[j] = dataGridView2.SelectedRows[j].Index;
                }

                for (int k = 0; k < i; k++)
                {
                    k_ogrenciler.Add(Convert.ToInt32(dataGridView2.Rows[kaydedileceksatirlar[k]].Cells[1].Value));
                    k_dersler.Add(dersidbulucu(dataGridView2.Rows[kaydedileceksatirlar[k]].Cells[4].Value.ToString()));
                }

                for (int m = 0; m < i; m++)
                {
                    SqlCommand komut = new SqlCommand("insert into ders_kayit (ogrenci_no, ders_id, vize, final) values (@ogrno, @dersno, 0, 0)", baglanti);
                    komut.Parameters.AddWithValue("@ogrno", k_ogrenciler[m]);
                    komut.Parameters.AddWithValue("@dersno", k_dersler[m]);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }

                for (int n = 0; n < i; n++)
                {
                    SqlCommand komut = new SqlCommand("update ders_on_kayit set durum=@durum1 where ID=@no", baglanti);
                    komut.Parameters.AddWithValue("@no", dataGridView2.Rows[kaydedileceksatirlar[n]].Cells[0].Value);
                    komut.Parameters.AddWithValue("@durum1", "Danışman onayladı");
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                MessageBox.Show("Ders onayı başarılı!");
            }
            else
            {
                MessageBox.Show("Lütfen satır seçin!");
            }

            on_kayitlari_gor();
            tablorenk(dataGridView2);
        }

        private void Yenile_Click(object sender, EventArgs e)
        {
            on_kayitlari_gor();

            tablorenk(dataGridView2);
        }

        //ders_kayıt red

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> k_ogrenciler = new List<int>();
            List<int> k_dersler = new List<int>();

            int i = dataGridView2.SelectedRows.Count;

            if (dataGridView2.SelectedRows.Count > 0)
            {
                int[] kaydedileceksatirlar = new int[i];
                for (int j = 0; j < i; j++)
                {
                    kaydedileceksatirlar[j] = dataGridView2.SelectedRows[j].Index;
                }

                for (int k = 0; k < i; k++)
                {
                    k_ogrenciler.Add(Convert.ToInt32(dataGridView2.Rows[kaydedileceksatirlar[k]].Cells[1].Value));
                    k_dersler.Add(dersidbulucu(dataGridView2.Rows[kaydedileceksatirlar[k]].Cells[4].Value.ToString()));
                }

                

                for (int n = 0; n < i; n++)
                {
                    SqlCommand komut = new SqlCommand("update ders_on_kayit set durum=@durum1 where ID=@no", baglanti);
                    komut.Parameters.AddWithValue("@no", dataGridView2.Rows[kaydedileceksatirlar[n]].Cells[0].Value);
                    komut.Parameters.AddWithValue("@durum1", "Danışman reddetti");
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                MessageBox.Show("Ders reddi başarılı!");
            }
            else
            {
                MessageBox.Show("Lütfen satır seçin!");
            }

            on_kayitlari_gor();
            tablorenk(dataGridView2);
        }
    }
}

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
    public partial class Not_İslemleri : Form
    {
        public Not_İslemleri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ana_giris.baglantistring);
        DataTable tablo = new DataTable();
        List<int> vize1 = new List<int>();
        List<int> final1 = new List<int>();
        List<double> ortalama1 = new List<double>();
        List<string> harf1 = new List<string>();

        //tema renklerini uygulama

        private void tablorenk()
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
        private void butonrenk(Button buton)
        {
            buton.BackColor = ThemeColor.PrimaryColor;
            buton.ForeColor = Color.White;
            buton.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
        }
        private void Not_İslemleri_Load(object sender, EventArgs e)
        {
            notlarilistele();
            butonrenk(buttonlistele);
        }

        //notları listeleme

        private void buttonlistele_Click(object sender, EventArgs e)
        {
            notlarilistele();
        }

        private void notlarilistele()
        {
            dataGridView1.Rows.Clear();
            notlarigetir();
            
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
                            dataGridView1.Rows.Add(oku2["ders_adi"], oku2["ders_kodu"], oku2["akts"], oku2["sinif"], vize1[i], final1[i], ortalama1[i], harf1[i]);
                        }
                    }
                }

            }
            baglanti.Close();
            tablorenk();
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

        private void notlarigetir()
        {
            int j = 1;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select vize, final, harf_notu from ders_kayit where ogrenci_no=@ogrno1", baglanti);
            komut.Parameters.AddWithValue("@ogrno1", ogr_giris.ogrenci_no);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                vize1.Add(Convert.ToInt32(oku["vize"]));
                final1.Add(Convert.ToInt32(oku["final"]));
                ortalama1.Add(Convert.ToInt32(oku["vize"]) * 0.4 + Convert.ToInt32(oku["final"]) * 0.6);
                harf1.Add(oku["harf_notu"].ToString());
                j++;
            }
            baglanti.Close();
        }
    }
}

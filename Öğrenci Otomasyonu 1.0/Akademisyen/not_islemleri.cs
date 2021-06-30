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
    public partial class not_islemleri : Form
    {
        public not_islemleri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ana_giris.baglantistring);
        SqlConnection baglanti1 = new SqlConnection(ana_giris.baglantistring);
        SqlConnection baglanti2 = new SqlConnection(ana_giris.baglantistring);
        SqlConnection baglanti3 = new SqlConnection(ana_giris.baglantistring);
        SqlConnection baglanti4 = new SqlConnection(ana_giris.baglantistring);
        SqlConnection baglanti5 = new SqlConnection(ana_giris.baglantistring);
        SqlConnection baglanti6 = new SqlConnection(ana_giris.baglantistring);
        SqlConnection baglanti7 = new SqlConnection(ana_giris.baglantistring);
        List<int> id_liste = new List<int>();
        List<int> ders_id_liste = new List<int>();
        List<int> vize_liste = new List<int>();
        List<int> final_liste = new List<int>();
        List<int> harf_ba = new List<int>();
        List<int> harf_bb = new List<int>();
        List<int> harf_cb = new List<int>();
        List<int> harf_cc = new List<int>();
        List<int> harf_dc = new List<int>();
        List<int> harf_ff = new List<int>();

        int sira = 0;

        // ana menü ile uyumlu renklerin sayfadaki butonlara ve tablolara uygulamaya yarayan fonksiyonlar

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
                    tablo.Rows[i].DefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
                else
                    tablo.Rows[i].DefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            }
        }

        private void not_islemleri_Load(object sender, EventArgs e)
        {
            butonrenk(buttonlistele);
            butonrenk(notkaydet);
            butonrenk(button_ortalamalistele);
            verigetir1();
            verigetirortalamalar();
            harfleri_getir();
        }

        //akademisyenin verdiği derslerden biri seçerek saddece o dersi alan öğrencileri listelemeyi sağlayan filtre sistemi

        private void filtrebolum_CheckedChanged(object sender, EventArgs e)
        {
            if (filtrebolum.Checked == true)
            {
                listebolum.Items.Clear();
                listebolum.Enabled = true;


                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from dersler where akademisyen=@akademisyen1", baglanti);
                komut.Parameters.AddWithValue("@akademisyen1", akdmsyn_giris.akademisyen_ad_soyad);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listebolum.Items.Add(oku["ders_adi"].ToString());
                }
                baglanti.Close();
            }
            else
                listebolum.Enabled = false;

        }

        private void buttonlistele_Click(object sender, EventArgs e)
        {
            if (filtrebolum.Checked == true)
            {
                verigetir2();
            }
            else
            {
                verigetir1();
            }

        }

        private void verigetir1()
        {
            id_liste.Clear();
            ders_id_liste.Clear();
            sira = 0;

            dataGridView1.Rows.Clear();
            List<int> dersler = new List<int>();
            dersler = hocaningirdigidersler();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from ders_kayit", baglanti);
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {
                for (int i = 0; i < dersler.Count(); i++)
                {

                    if (Convert.ToInt32(oku["ders_id"]) == dersler[i])
                    {
                        id_liste.Add(Convert.ToInt32(oku["ID"]));
                        ders_id_liste.Add(Convert.ToInt32(oku["ders_id"]));
                        dataGridView1.Rows.Add(dersisimbulucu(Convert.ToInt32(oku["ders_id"])), derskodubulucu(Convert.ToInt32(oku["ders_id"])), oku["ogrenci_no"], ogrencisimbulucu(Convert.ToInt32(oku["ogrenci_no"])), oku["vize"], oku["final"], oku["ortalama"], oku["harf_notu"]);
                        sira++;
                    }

                }
            }
            baglanti.Close();
            tablorenk(dataGridView1);
        }

        private void verigetir2()
        {
            id_liste.Clear();
            ders_id_liste.Clear();
            sira = 0;

            dataGridView1.Rows.Clear();
            List<int> dersler = new List<int>();
            dersler = hocaningirdigidersler();
            string secilenders = listebolum.SelectedItem.ToString();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from ders_kayit where ders_id=@dersid1", baglanti);
            komut.Parameters.AddWithValue("@dersid1", dersidbulucu(secilenders).ToString());
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {
                for (int i = 0; i < dersler.Count(); i++)
                {

                    if (Convert.ToInt32(oku["ders_id"]) == dersler[i])
                    {
                        id_liste.Add(Convert.ToInt32(oku["ID"]));
                        ders_id_liste.Add(Convert.ToInt32(oku["ders_id"]));
                        dataGridView1.Rows.Add(dersisimbulucu(Convert.ToInt32(oku["ders_id"])), oku["ogrenci_no"], ogrencisimbulucu(Convert.ToInt32(oku["ogrenci_no"])), oku["vize"], oku["final"], oku["ortalama"], oku["harf_notu"]);
                        sira++;
                    }

                }
            }
            baglanti.Close();
            tablorenk(dataGridView1);
        }

        private void verigetirortalamalar()
        {
            dataGridView_ortalamalar.Rows.Clear();
            List<int> dersler = new List<int>();
            dersler = hocaningirdigidersler();
            int ogr_sayisi, gecerlidersid = dersler[0];
            double vortalama, fortalama, ortalama;



            for (int i = 0; i < dersler.Count(); i++)
            {
                baglanti.Open();
                ogr_sayisi = 0;
                vortalama = 0;
                fortalama = 0;
                ortalama = 0;

                SqlCommand komut = new SqlCommand("select * from ders_kayit where ders_id=@dersid1", baglanti);
                komut.Parameters.AddWithValue("@dersid1", dersler[i]);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    ogr_sayisi++;
                    vortalama += Convert.ToInt32(oku["vize"]);
                    fortalama += Convert.ToInt32(oku["final"]);
                    ortalama += Convert.ToInt32(oku["ortalama"]);
                    gecerlidersid = Convert.ToInt32(oku["ders_id"]);
                }
                vortalama /= ogr_sayisi;
                fortalama /= ogr_sayisi;
                ortalama /= ogr_sayisi;

                if (dersler[i] == gecerlidersid)
                {
                    dataGridView_ortalamalar.Rows.Add(dersisimbulucu(dersler[i]), ogr_sayisi, vortalama, fortalama, ortalama);
                }


                baglanti.Close();
                tablorenk(dataGridView_ortalamalar);

            }
        }

        // veritabanında bir tablodaki verileri kullanarak bir başka tablodaki verilere ulaşabilmeyi sağlayan fonksiyonlar

        private List<int> hocaningirdigidersler()
        {
            List<int> verilendersler = new List<int>();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ID from dersler where akademisyen=@akademisyen1", baglanti);
            komut.Parameters.AddWithValue("@akademisyen1", akdmsyn_giris.akademisyen_ad_soyad);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                verilendersler.Add(Convert.ToInt32(oku["ID"]));
            }
            baglanti.Close();
            return verilendersler;

        }

        private string ogrencisimbulucu(int ogrno)
        {
            string ad;
            baglanti1.Open();
            SqlCommand komut = new SqlCommand("select ogrenci_ad_soyad from ogrenci_bilgi where ogrenci_no=@ogrno1", baglanti1);
            komut.Parameters.AddWithValue("@ogrno1", ogrno);
            SqlDataReader oku = komut.ExecuteReader();
            oku.Read();
            ad = oku["ogrenci_ad_soyad"].ToString();
            baglanti1.Close();
            return ad;
        }

        private string dersisimbulucu(int dersid)
        {
            string ad;
            baglanti2.Open();
            SqlCommand komut = new SqlCommand("select ders_adi from dersler where ID=@dersid1", baglanti2);
            komut.Parameters.AddWithValue("@dersid1", dersid);
            SqlDataReader oku = komut.ExecuteReader();
            oku.Read();
            ad = oku["ders_adi"].ToString();
            baglanti2.Close();
            return ad;
        }

        private string derskodubulucu(int dersid)
        {
            string kod;
            baglanti5.Open();
            SqlCommand komut = new SqlCommand("select ders_kodu from dersler where ID=@dersid1", baglanti5);
            komut.Parameters.AddWithValue("@dersid1", dersid);
            SqlDataReader oku = komut.ExecuteReader();
            oku.Read();
            kod = oku["ders_kodu"].ToString();
            baglanti5.Close();
            return kod;
        }

        private int dersidbulucu(string dersadi)
        {
            int dersid;
            baglanti3.Open();
            SqlCommand komut = new SqlCommand("select * from dersler where ders_adi=@dersadi1", baglanti3);
            komut.Parameters.AddWithValue("@dersadi1", dersadi);
            SqlDataReader oku = komut.ExecuteReader();
            oku.Read();
            dersid = Convert.ToInt32(oku["ID"]);
            baglanti3.Close();
            return dersid;
        }

        private List<int> harfaraliklarinicekme(int dersid)
        {
            List<int> araliklar = new List<int>();
            baglanti4.Open();
            SqlCommand komut = new SqlCommand("select * from dersler where ID=@dersid1", baglanti4);
            komut.Parameters.AddWithValue("@dersid1", dersid);
            SqlDataReader oku = komut.ExecuteReader();
            oku.Read();
            araliklar.Add(Convert.ToInt32(oku["ba"]));
            araliklar.Add(Convert.ToInt32(oku["bb"]));
            araliklar.Add(Convert.ToInt32(oku["cb"]));
            araliklar.Add(Convert.ToInt32(oku["cc"]));
            araliklar.Add(Convert.ToInt32(oku["dc"]));
            araliklar.Add(Convert.ToInt32(oku["ff"]));
            baglanti4.Close();
            return araliklar;
        }

        private string harfnotubelirleme(int dersid, int vize, int final)
        {
            double ortalama = vize * 0.4 + final * 0.6;
            string harfnotu = "";
            List<int> araliklar = new List<int>();
            araliklar = harfaraliklarinicekme(dersid);
            for (int i = 0; i < araliklar.Count; i++)
            {
                //MessageBox.Show("ders id:" + dersid + " ," + (i+1) + ". aralığın alt sınırı:" + araliklar[i]);
            }
            if (ortalama >= araliklar[0])
                harfnotu = "AA";
            else if (ortalama >= araliklar[1])
                harfnotu = "BA";
            else if (ortalama >= araliklar[2])
                harfnotu = "BB";
            else if (ortalama >= araliklar[3])
                harfnotu = "CB";
            else if (ortalama >= araliklar[4])
                harfnotu = "CC";
            else if (ortalama >= araliklar[5])
                harfnotu = "DC";
            else
                harfnotu = "FF";

            return harfnotu;
        }

        //akademisyenin notları kaydetmesini sağlayan button

        private void notkaydet_Click(object sender, EventArgs e)
        {
            vize_liste.Clear();
            final_liste.Clear();
            string sorgu = "update ders_kayit set vize=@vize1 , final=@final1, harf_notu=@harfnotu where ID=@id1";

            for (int j = 0; j < sira; j++)
            {
                vize_liste.Add(Convert.ToInt32(dataGridView1.Rows[j].Cells[4].Value));
                final_liste.Add(Convert.ToInt32(dataGridView1.Rows[j].Cells[5].Value));
            }


            for (int i = 0; i < id_liste.Count(); i++)
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@id1", id_liste[i].ToString());
                komut.Parameters.AddWithValue("@vize1", vize_liste[i].ToString());
                komut.Parameters.AddWithValue("@final1", final_liste[i].ToString());
                komut.Parameters.AddWithValue("@harfnotu", harfnotubelirleme(ders_id_liste[i], vize_liste[i], final_liste[i]));
                komut.ExecuteNonQuery();
                baglanti.Close();
            }

            MessageBox.Show("Notlar başarı ile kaydedildi!");

        }

        //akademisyenin girdiği derslerin sınıf ortalamsın kontrol etmesini sağlayan bölüm

        private void button_ortalamalistele_Click(object sender, EventArgs e)
        {
            verigetirortalamalar();
        }

        // harf aralıklarını belirleme
        private int sinif_mevcudu_bulma(int ders_id)
        {
            int mevcut = 0;
            baglanti6.Open();
            SqlCommand komut = new SqlCommand("select * from ders_kayit where ders_id=@dersid", baglanti6);
            komut.Parameters.AddWithValue("@dersid", ders_id);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                mevcut++;
            }
            baglanti6.Close();
            return mevcut;
        }

        private double ortalama_bulma(int mevcut, int ders_id)
        {
            double ortalama = 0;

            baglanti7.Open();
            SqlCommand komut = new SqlCommand("select ortalama from ders_kayit where ders_id=@dersid", baglanti7);
            komut.Parameters.AddWithValue("@dersid", ders_id);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ortalama += Convert.ToDouble(oku["ortalama"]);
            }
            ortalama /= mevcut;
            baglanti7.Close();
            return ortalama;
        }
        private void harfleri_getir()
        {
            dataGridView_harfaraliklari.Rows.Clear();

            //foreach (var item in dersler)
            //{
            //    MessageBox.Show(item.ToString());
            //}



            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from dersler where akademisyen=@akademisyen1", baglanti);
            komut2.Parameters.AddWithValue("@akademisyen1", akdmsyn_giris.akademisyen_ad_soyad);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                dataGridView_harfaraliklari.Rows.Add(derskodubulucu(Convert.ToInt32(oku2["ID"])), dersisimbulucu(Convert.ToInt32(oku2["ID"])), sinif_mevcudu_bulma(Convert.ToInt32(oku2["ID"])), ortalama_bulma(sinif_mevcudu_bulma(Convert.ToInt32(oku2["ID"])), Convert.ToInt32(oku2["ID"])), oku2["ba"], oku2["bb"], oku2["cb"], oku2["cc"], oku2["dc"], oku2["ff"]);
            }



            baglanti.Close();

            tablorenk(dataGridView_harfaraliklari);
        }



        private void harfleri_kaydet()
        {
            harf_ba.Clear();
            harf_bb.Clear();
            harf_cb.Clear();
            harf_cc.Clear();
            harf_dc.Clear();
            harf_ff.Clear();

            List<int> dersidler = new List<int>();
            dersidler = hocaningirdigidersler();

            string sorgu = "update dersler set ba=@ba1 , bb=@bb1, cb=@cb1, cc=@cc1, dc=@dc1, ff=@ff1 where ID=@id1";
            //MessageBox.Show(dataGridView_harfaraliklari.Rows[j].Cells[8].Value + ", " + dataGridView_harfaraliklari.Rows[j].Cells[9].Value + ", " + dataGridView_harfaraliklari.Rows[j].Cells[10].Value + ", " + dataGridView_harfaraliklari.Rows[j].Cells[11].Value + ", " + dataGridView_harfaraliklari.Rows[j].Cells[12].Value + ", " + dataGridView_harfaraliklari.Rows[j].Cells[12].Value + ", " + dataGridView_harfaraliklari.Rows[j].Cells[13].Value + ", ");
            for (int j = 0; j < dataGridView_harfaraliklari.Rows.Count; j++)
            {
                harf_ba.Add(Convert.ToInt32(dataGridView_harfaraliklari.Rows[j].Cells[4].Value));
                harf_bb.Add(Convert.ToInt32(dataGridView_harfaraliklari.Rows[j].Cells[5].Value));
                harf_cb.Add(Convert.ToInt32(dataGridView_harfaraliklari.Rows[j].Cells[6].Value));
                harf_cc.Add(Convert.ToInt32(dataGridView_harfaraliklari.Rows[j].Cells[7].Value));
                harf_dc.Add(Convert.ToInt32(dataGridView_harfaraliklari.Rows[j].Cells[8].Value));
                harf_ff.Add(Convert.ToInt32(dataGridView_harfaraliklari.Rows[j].Cells[9].Value));
            }


            for (int i = 0; i < id_liste.Count(); i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@id1", dersidler[i].ToString());
                komut.Parameters.AddWithValue("@ba1", Convert.ToInt32(harf_ba[i]));
                komut.Parameters.AddWithValue("@bb1", Convert.ToInt32(harf_bb[i]));
                komut.Parameters.AddWithValue("@cb1", Convert.ToInt32(harf_cb[i]));
                komut.Parameters.AddWithValue("@cc1", Convert.ToInt32(harf_cc[i]));
                komut.Parameters.AddWithValue("@dc1", Convert.ToInt32(harf_dc[i]));
                komut.Parameters.AddWithValue("@ff1", Convert.ToInt32(harf_ff[i]));

                komut.ExecuteNonQuery();
                baglanti.Close();
            }

            MessageBox.Show("Notlar başarı ile kaydedildi!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            harfleri_kaydet();
            harfleri_getir();
        }
    }

}

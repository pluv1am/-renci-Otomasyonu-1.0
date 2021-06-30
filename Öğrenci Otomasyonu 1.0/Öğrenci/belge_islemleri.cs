using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using System.IO;
using Font = iTextSharp.text.Font;
using System.Data.SqlClient;

namespace Öğrenci_Otomasyonu_1._0.Öğrenci
{
    public partial class belge_islemleri : Form
    {
        public belge_islemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(ana_giris.baglantistring);
        SqlConnection baglanti2 = new SqlConnection(ana_giris.baglantistring);
        SqlConnection baglanti3 = new SqlConnection(ana_giris.baglantistring);
        SqlConnection baglanti4 = new SqlConnection(ana_giris.baglantistring);


        string path_ogrenci_belgesi;
        string path_transkript;
        int toplamakts;
        double agno, toplamm=0, harfnotu;

        List<string> derskodu = new List<string>();
        List<string> dersadi = new List<string>();
        List<string> dersakts = new List<string>();
        List<string> dersharfnotu = new List<string>();

        private void belge_islemleri_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;

            string path_kaynaklar = System.IO.Directory.GetCurrentDirectory();
            string path_belgeler = path_kaynaklar.Substring(0, path_kaynaklar.Length - 9) + "Belgeler\\";
            path_kaynaklar = path_kaynaklar.Substring(0, path_kaynaklar.Length - 9) + "Kaynaklar\\";
            path_ogrenci_belgesi = path_belgeler + ogr_giris.ogrenci_ad_soyad.Trim() + " Öğrenci Belgesi.pdf";
            string path_gazi = path_kaynaklar + "gazi.jpeg";
            string path_font = path_kaynaklar + "ARIALUNI.TTF";
            BaseFont bf = BaseFont.CreateFont(path_font, BaseFont.IDENTITY_H, BaseFont.EMBEDDED, Font.Bold);

            if (comboBox1.SelectedIndex == 0)
            {
                Document ogrenci_belgesi = new Document();
                PdfWriter.GetInstance(ogrenci_belgesi, new FileStream(path_ogrenci_belgesi, FileMode.Create));

                iTextSharp.text.Image gazi = iTextSharp.text.Image.GetInstance(path_gazi);
                gazi.ScaleToFit(100f, 100f);
                gazi.SpacingBefore = 200f;
                gazi.SpacingAfter = 200f;

                Paragraph belgetarihi = new Paragraph(DateTime.Now.ToShortDateString(), new Font(bf));
                Paragraph title = new Paragraph("T.C.\nYÜKSEKÖĞRETİM KURULU BAŞKANLIĞI\nANKARA", new Font(bf, 18f));
                Paragraph bosluk1 = new Paragraph("\n");
                Paragraph bosluk2 = new Paragraph("\n\n");
                Paragraph bosluk3 = new Paragraph("\n\n\n\n\n\n");

                Paragraph baslik = new Paragraph("Öğrenci Belgesi", new Font(bf, 15f));

                Paragraph tc = new Paragraph("T.C. Kimlik No                              : " + ogr_giris.ogrenci_kimlikno, new Font(bf));
                Paragraph ad = new Paragraph("Adı/Soyadı                                   : " + ogr_giris.ogrenci_ad_soyad, new Font(bf));
                Paragraph ana = new Paragraph("Anne Adı                                      : " + ogr_giris.ogrenci_anne_ad, new Font(bf));
                Paragraph baba = new Paragraph("Baba Adı                                     : " + ogr_giris.ogrenci_baba_ad, new Font(bf));
                Paragraph dogum = new Paragraph("Doğum Tarihi                              : " + ogr_giris.ogrenci_dogun_tarihi, new Font(bf));
                Paragraph egitim = new Paragraph("Eğitim Türü/Öğrenim Süresi        : Normal Öğretim/4", new Font(bf));
                Paragraph aktif = new Paragraph("Öğrencilik Durumu                      : Aktif", new Font(bf));
                Paragraph tarih = new Paragraph("Kayıt Tarihi                                  : " + ogr_giris.ogrenci_kayit_tarihi, new Font(bf));
                Paragraph sinif = new Paragraph("Sınıf                                             : " + ogr_giris.ogrenci_sinif, new Font(bf));
                Paragraph bolum = new Paragraph("Program                                       : Gazi Üniversitesi/Mühendislik Fakültesi/" + ogr_giris.ogrenci_bolum + " Bölümü/" + ogr_giris.ogrenci_bolum + " Programı", new Font(bf));

                Paragraph baslik2 = new Paragraph("İLGİLİ MAKAMA", new Font(bf, 16f));
                Paragraph metin2 = new Paragraph("Yukarıda kimlik bilgileri yer alan " + ogr_giris.ogrenci_ad_soyad + " isimli kişinin Gazi Üniversitesi " +
                    "tarafından yukarıda belirtilen programın kayıtlı öğrencisi olduğu bildirilmiştir.", new Font(bf));
                Paragraph metin3 = new Paragraph("* Öğrenciye ait bilgiler ilgili yükseköğretim kurumunun öğrenci işlerinden " +
                    "sorumlu biriminin 12.05.2021 itibariyle gönderdiği veriden derlenmiştir.\n**Yukarıdaki yazılı bilgilere " +
                    "ilişkin tereddüt yaşanması halinde ilgili yükseköğretim kurumunun öğrenci işlerinden sorumlu birimine " +
                    "başvurulması gerekmektedir.", new Font(bf, 8f));

                belgetarihi.Alignment = Element.ALIGN_RIGHT;
                title.Alignment = Element.ALIGN_CENTER;
                baslik.Alignment = Element.ALIGN_CENTER;
                baslik2.Alignment = Element.ALIGN_CENTER;

                ogrenci_belgesi.Open();
                ogrenci_belgesi.Add(gazi);
                ogrenci_belgesi.Add(belgetarihi);
                ogrenci_belgesi.Add(title);
                ogrenci_belgesi.Add(bosluk2);
                ogrenci_belgesi.Add(baslik);
                ogrenci_belgesi.Add(bosluk1);
                ogrenci_belgesi.Add(tc);
                ogrenci_belgesi.Add(ad);
                ogrenci_belgesi.Add(ana);
                ogrenci_belgesi.Add(baba);
                ogrenci_belgesi.Add(dogum);
                ogrenci_belgesi.Add(egitim);
                ogrenci_belgesi.Add(aktif);
                ogrenci_belgesi.Add(tarih);
                ogrenci_belgesi.Add(sinif);
                ogrenci_belgesi.Add(bolum);
                ogrenci_belgesi.Add(bosluk2);
                ogrenci_belgesi.Add(baslik2);
                ogrenci_belgesi.Add(bosluk2);
                ogrenci_belgesi.Add(metin2);
                ogrenci_belgesi.Add(bosluk3);
                ogrenci_belgesi.Add(metin3);
                ogrenci_belgesi.Close();

                linkLabel1.Visible = true;
                linkLabel1.Text = ogr_giris.ogrenci_ad_soyad.Trim() + " Öğrenci Belgesi.pdf";

            }
            else
            {
                sondurumlar();

                path_transkript = path_belgeler + ogr_giris.ogrenci_ad_soyad.Trim() + " Transkript.pdf";

                Document transkript = new Document();
                PdfWriter.GetInstance(transkript, new FileStream(path_transkript, FileMode.Create));

                Paragraph title = new Paragraph("GAZİ ÜNİVERSİTESİ", new Font(bf, 18f));
                Paragraph baslik_transkript = new Paragraph("TRANSKRİPT", new Font(bf));
                Paragraph bosluk1 = new Paragraph("\n");
                Paragraph bosluk2 = new Paragraph("\n\n");
                Paragraph bosluk3 = new Paragraph("\n\n\n\n\n\n");
                Paragraph tc = new Paragraph("T.C. Kimlik No                              : " + ogr_giris.ogrenci_kimlikno, new Font(bf));
                Paragraph ad = new Paragraph("Adı/Soyadı                                   : " + ogr_giris.ogrenci_ad_soyad, new Font(bf));
                Paragraph ana = new Paragraph("Anne Adı                                      : " + ogr_giris.ogrenci_anne_ad, new Font(bf));
                Paragraph baba = new Paragraph("Baba Adı                                     : " + ogr_giris.ogrenci_baba_ad, new Font(bf));
                Paragraph dogum = new Paragraph("Doğum Tarihi                              : " + ogr_giris.ogrenci_dogun_tarihi, new Font(bf));
                Paragraph bolum = new Paragraph("Program                                       : " + ogr_giris.ogrenci_bolum, new Font(bf));


                title.Alignment = Element.ALIGN_CENTER;
                baslik_transkript.Alignment = Element.ALIGN_CENTER;


                PdfPTable tablo = new PdfPTable(4);
                tablo.SetWidths(new int[] { 2, 5, 2, 2 });

                PdfPCell cell;
                cell = new PdfPCell(new Phrase("Dersler"));
                cell.Colspan = (4);
                tablo.AddCell(cell);

                tablo.AddCell("Ders Kodu");
                tablo.AddCell("Ders Adı");
                tablo.AddCell("AKTS");
                tablo.AddCell("Harf Notu");

                for (int i = 0; i < derskodu.Count; i++)
                {
                    harfnotu = 1;
                    tablo.AddCell(derskodu[i]);
                    tablo.AddCell(dersadi[i]);
                    tablo.AddCell(dersakts[i]);
                    tablo.AddCell(dersharfnotu[i]);
                    toplamakts += Convert.ToInt32(dersakts[i]);

                    if (dersharfnotu[i] == "AA")
                        harfnotu = 4;
                    else if (dersharfnotu[i] == "BA")
                        harfnotu = 3.5;
                    else if (dersharfnotu[i] == "BB")
                        harfnotu = 3;
                    else if (dersharfnotu[i] == "CB")
                        harfnotu = 2.5;
                    else if (dersharfnotu[i] == "CC")
                        harfnotu = 2;
                    else if (dersharfnotu[i] == "DC")
                        harfnotu = 1.5;
                    else
                        harfnotu = 0;

                    toplamm += harfnotu * Convert.ToDouble(dersakts[i]);

                }
                agno = toplamm / toplamakts;

                Paragraph sonuc = new Paragraph("\n                 Toplam akts: " + toplamakts + "     Ortalama: " + agno, new Font(bf));

                transkript.Open();
                transkript.Add(title);
                transkript.Add(baslik_transkript);
                transkript.Add(bosluk2);
                transkript.Add(tc);
                transkript.Add(ad);
                transkript.Add(ana);
                transkript.Add(baba);
                transkript.Add(dogum);
                transkript.Add(bolum);
                transkript.Add(bosluk2);
                transkript.Add(tablo);
                transkript.Add(sonuc);
                transkript.Close();

                linkLabel2.Visible = true;
                linkLabel2.Text = ogr_giris.ogrenci_ad_soyad.Trim() + " Transkript.pdf";
            }


        }

        private void sondurumlar()
        {
            dersadi.Clear();
            dersakts.Clear();
            dersharfnotu.Clear();
            derskodu.Clear();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ders_id, harf_notu from ders_kayit where ogrenci_no=@ogrno1", baglanti);
            komut.Parameters.AddWithValue("@ogrno1", ogr_giris.ogrenci_no);
            SqlDataReader oku = komut.ExecuteReader();
            
            while (oku.Read())
            {
                derskodu.Add(derskodubulucu(Convert.ToInt32(oku["ders_id"])));
                dersadi.Add(dersisimbulucu(Convert.ToInt32(oku["ders_id"])));
                dersakts.Add(dersaktsbulucu(Convert.ToInt32(oku["ders_id"])));
                dersharfnotu.Add(oku["harf_notu"].ToString());
            }
            baglanti.Close();
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
            baglanti3.Open();
            SqlCommand komut = new SqlCommand("select ders_kodu from dersler where ID=@dersid1", baglanti3);
            komut.Parameters.AddWithValue("@dersid1", dersid);
            SqlDataReader oku = komut.ExecuteReader();
            oku.Read();
            kod = oku["ders_kodu"].ToString();
            baglanti3.Close();
            return kod;
        }

        private string dersaktsbulucu(int dersid)
        {
            string akts;
            baglanti4.Open();
            SqlCommand komut = new SqlCommand("select akts from dersler where ID=@dersid1", baglanti4);
            komut.Parameters.AddWithValue("@dersid1", dersid);
            SqlDataReader oku = komut.ExecuteReader();
            oku.Read();
            akts = oku["akts"].ToString();
            baglanti4.Close();
            return akts;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(path_ogrenci_belgesi);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(path_transkript);
        }
    }
}

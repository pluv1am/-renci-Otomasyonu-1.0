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

namespace Öğrenci_Otomasyonu_1._0
{
    public partial class ogr_giris : Form
    {
        public ogr_giris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ana_giris.baglantistring);
        static public string ogrenci_id, ogrenci_no, ogrenci_sifre, ogrenci_ad_soyad, ogrenci_bolum, ogrenci_kayit_tarihi, ogrenci_sinif, ogrenci_kimlikno, ogrenci_anne_ad, ogrenci_baba_ad, ogrenci_dogun_tarihi;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //karakteri göster.
                textBox2_ogr_sifre.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                textBox2_ogr_sifre.PasswordChar = '*';
            }
        }

        static public int ogrenci_danisman_id;

        private void ogr_giris_Load(object sender, EventArgs e)
        {
            textBox2_ogr_sifre.PasswordChar = '*';
            tema();
        }

        //ana menüdeki renkleri alt forma uygulama

        private void tema()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            foreach (Control lbls in this.Controls)
            {
                if (lbls.GetType() == typeof(Label))
                {
                    Label lbl = (Label)lbls;
                    lbl.ForeColor = ThemeColor.SecondaryColor;
                }
            }
        }

        //öğrenci girişi

        private void button1_giris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select * from ogrenci_bilgi", baglanti);
            SqlDataReader kayitoku = sorgu.ExecuteReader();
            while (kayitoku.Read())
            {
                if (kayitoku["ogrenci_no"].ToString().Trim() == textBox1_ogr_no.Text && kayitoku["ogrenci_sifre"].ToString().Trim() == textBox2_ogr_sifre.Text)
                {
                    ogrenci_id = kayitoku["ID"].ToString().Trim();
                    ogrenci_no = kayitoku["ogrenci_no"].ToString().Trim();
                    ogrenci_ad_soyad = kayitoku["ogrenci_ad_soyad"].ToString();
                    ogrenci_bolum = kayitoku["bolum"].ToString();
                    ogrenci_sifre = kayitoku["ogrenci_sifre"].ToString();
                    ogrenci_kayit_tarihi = kayitoku["kayit_tarihi"].ToString();
                    ogrenci_sinif = kayitoku["sinif"].ToString();
                    ogrenci_kimlikno = kayitoku["kimlik_no"].ToString();
                    ogrenci_anne_ad = kayitoku["anne_ad"].ToString();
                    ogrenci_baba_ad = kayitoku["baba_ad"].ToString();
                    ogrenci_dogun_tarihi = kayitoku["dogum_tarihi"].ToString();
                    ogrenci_danisman_id = Convert.ToInt32(kayitoku["danisman_id"]);
                    this.Hide();
                    ogrenci_anasayfa link1 = new ogrenci_anasayfa();
                    link1.Show();
                }
                
            }
            baglanti.Close();
        }
    }
}

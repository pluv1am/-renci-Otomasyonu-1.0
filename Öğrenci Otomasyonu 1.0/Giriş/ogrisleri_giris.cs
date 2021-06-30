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
    public partial class ogrisleri_giris : Form
    {
        public ogrisleri_giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(ana_giris.baglantistring);
        static public string kullanici_id, kullanici_no, kullanici_sifre, kullanici_ad_soyad;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //karakteri göster.
                textBox2_kullanici_sifre.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                textBox2_kullanici_sifre.PasswordChar = '*';
            }
        }

        private void ogrisleri_giris_Load(object sender, EventArgs e)
        {
            textBox2_kullanici_sifre.PasswordChar = '*';
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
            label2.ForeColor = ThemeColor.SecondaryColor;
            label3.ForeColor = ThemeColor.SecondaryColor;
        }

        //öğrenci işleri girişi

        private void button1_giris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select * from ogrisleri_bilgi", baglanti);
            SqlDataReader kayitoku = sorgu.ExecuteReader();
            while (kayitoku.Read())
            {
                if (kayitoku["kullanici_no"].ToString().Trim() == textBox1_kullanici_no.Text && kayitoku["kullanici_sifre"].ToString().Trim() == textBox2_kullanici_sifre.Text)
                {
                    kullanici_id = kayitoku["ID"].ToString().Trim();
                    kullanici_no = kayitoku["kullanici_no"].ToString().Trim();
                    kullanici_ad_soyad = kayitoku["kullanici_ad_soyad"].ToString();
                    kullanici_sifre = kayitoku["kullanici_sifre"].ToString();
                    this.Hide();
                    ogrisleri_anasayfa link1 = new ogrisleri_anasayfa();
                    link1.Show();
                }

            }
            baglanti.Close();
        }
    }
}

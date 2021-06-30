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
    public partial class akdmsyn_giris : Form
    {
        public akdmsyn_giris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ana_giris.baglantistring);
        static public string akademisyen_id, akademisyen_no, akademisyen_sifre, akademisyen_ad_soyad, akademisyen_bolum;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //karakteri göster.
                textBox2_akdmsyn_sifre.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                textBox2_akdmsyn_sifre.PasswordChar = '*';
            }
        }

        private void akdmsyn_giris_Load(object sender, EventArgs e)
        {
            textBox2_akdmsyn_sifre.PasswordChar = '*';
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

        //akademisyen girişi

        private void button1_giris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select * from akademisyen_bilgi", baglanti);
            SqlDataReader kayitoku = sorgu.ExecuteReader();
            while (kayitoku.Read())
            {
                if (kayitoku["akademisyen_no"].ToString().Trim() == textBox1_akdmsyn_no.Text && kayitoku["akademisyen_sifre"].ToString().Trim() == textBox2_akdmsyn_sifre.Text)
                {
                    akademisyen_id = kayitoku["ID"].ToString().Trim();
                    akademisyen_no = kayitoku["akademisyen_no"].ToString().Trim();
                    akademisyen_ad_soyad = kayitoku["akademisyen_ad_soyad"].ToString();
                    akademisyen_bolum = kayitoku["bolum"].ToString();
                    akademisyen_sifre = kayitoku["akademisyen_sifre"].ToString();

                    this.Hide();
                    akademisyen_anasayfa link1 = new akademisyen_anasayfa();
                    link1.Show();
                }

            }
            baglanti.Close();
        }
    }
}

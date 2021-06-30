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
    public partial class ogrenci_sifre : Form
    {
        public ogrenci_sifre()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ana_giris.baglantistring);

        //tema renklerini uygulama
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

        private void ogrenci_sifre_Load(object sender, EventArgs e)
        {
            tema();
        }

        //şifrelerin uygunluğunu kotrol etme

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == ogr_giris.ogrenci_sifre.Trim())
            {
                label5.ForeColor = Color.Green;
                label5.Text = "Şifre doğru.";
            }
            else
            {
                label5.ForeColor = Color.Red;
                label5.Text = "Şifre yanlış.";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 8)
            {
                label6.ForeColor = Color.Red;
                label6.Text = "Şifre en az 8 karakter olmalı.";
            }
            else
            {
                label6.ForeColor = Color.Green;
                label6.Text = "Şifre uygun";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                if (textBox2.Text.Length < 8)
                {
                    label7.ForeColor = Color.Red;
                    label7.Text = "Şifreler uyuşuyor fakat 8 karakterden kısalar.";
                }
                else
                {
                    label7.ForeColor = Color.Green;
                    label7.Text = "Şifreler uyuşuyor.";
                }
                
            }
            else
            {
                label7.ForeColor = Color.Red;
                label7.Text = "Şifreler uyuşmuyor";
            }
        }

        //şifre uygunsa şifreyi değiştirme

        private void button_sifre_degistir_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == ogr_giris.ogrenci_sifre.Trim() && textBox2.Text!=null && textBox2.Text == textBox3.Text && textBox2.Text.Length >= 8)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update ogrenci_bilgi set ogrenci_sifre=@ogrsifre1 where ogrenci_no=@ogrno1", baglanti);
                komut.Parameters.AddWithValue("@ogrsifre1", textBox2.Text);
                komut.Parameters.AddWithValue("@ogrno1", ogr_giris.ogrenci_no);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Şifre başarı ile değiştirildi.");

                ogr_giris.ogrenci_sifre = textBox2.Text;
            }
            else
            {
                MessageBox.Show("Lütfen hataları düzeltin.");
            }
        }
    }
}

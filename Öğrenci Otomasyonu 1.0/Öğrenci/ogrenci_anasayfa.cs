using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Öğrenci_Otomasyonu_1._0
{
    public partial class ogrenci_anasayfa : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public ogrenci_anasayfa()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        SqlConnection baglanti = new SqlConnection(ana_giris.baglantistring);
        private void ogrenci_anasayfa_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Hoş Geldiniz " + ogr_giris.ogrenci_ad_soyad;
            anamenuyedonme();
            label2.Text += akademisyenisimbulucu(ogr_giris.ogrenci_danisman_id);
        }

        private string akademisyenisimbulucu(int id)
        {
            string ad;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from akademisyen_bilgi where ID=@id1", baglanti);
            komut.Parameters.AddWithValue("@id1", id);
            SqlDataReader oku = komut.ExecuteReader();
            oku.Read();
            ad = oku["akademisyen_ad_soyad"].ToString();
            baglanti.Close();
            return ad;
        }
        

        //formu hareket ettirme////////////////////////////////////////////////////////////////////////////////

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //tema renklerini ayarlama////////////////////////////////////////////////////////////////////////////////

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        //soldaki menüdeki aktif olan butonu ön plana çıkarma////////////////////////////////////////////////////////////////////////////////

        private void ActivateButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
                }
            }
        }


        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "Hoş Geldiniz " + ogr_giris.ogrenci_ad_soyad;
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;

        }

        //açık olan alt formu kapatıp ana menüye dönme////////////////////////////////////////////////////////////////////////////////

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            Reset();

            anamenuyedonme();
        }

        //ana panelde başka formları açma////////////////////////////////////////////////////////////////////////////////

        private void alt_form_acma(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void anamenuyedonme()
        {
            Öğrenci.ogrenci_duyuru duyuruform = new Öğrenci.ogrenci_duyuru();

            activeForm = duyuruform;
            duyuruform.TopLevel = false;
            duyuruform.FormBorderStyle = FormBorderStyle.None;
            duyuruform.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(duyuruform);
            this.panelDesktopPanel.Tag = duyuruform;
            duyuruform.BringToFront();
            duyuruform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alt_form_acma(new Öğrenci.ders_islemleri(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alt_form_acma(new Öğrenci.Not_İslemleri(), sender);
        }
        private void button1_belge_islemleri_Click(object sender, EventArgs e)
        {
            alt_form_acma(new Öğrenci.belge_islemleri(), sender);
        }

        private void button_sifre_islemleri_Click(object sender, EventArgs e)
        {
            alt_form_acma(new Öğrenci.mesajlar(), sender);
        }
        private void button_sifre_islemleri_Click_1(object sender, EventArgs e)
        {
            alt_form_acma(new Öğrenci.ogrenci_sifre(), sender);
        }

        //sağ üstteki butonlar, formu küçültme, tam ekran yapma ve kapatma tuşları////////////////////////////////////////////////////////////////////////////////

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        //sol alttaki saat////////////////////////////////////////////////////////////////////////////////

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            saat.Text = dt.ToLongDateString() + "\n\t" + dt.ToLongTimeString();
        }

        
    }
}

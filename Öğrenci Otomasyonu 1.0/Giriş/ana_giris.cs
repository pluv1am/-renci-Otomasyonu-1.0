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

namespace Öğrenci_Otomasyonu_1._0
{
    public partial class ana_giris : Form
    {
        public int aktifno;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        
        public ana_giris()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public static string path = System.IO.Directory.GetCurrentDirectory();
        //public static string path3 = "Data Source=LAPTOP-C3MP9PEV;Initial Catalog = Öğrenci_Otomasyonu_Veritabanı_v1.0; Integrated Security = True";
        public static string path2 = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"" + path + "\\Öğrenci Otomasyonu Veritabanı v1.0.mdf\";Integrated Security = True; Connect Timeout = 30";
        
        public static string baglantistring = path2;

        private void ana_giris_Load(object sender, EventArgs e)
        {
            anamenuyedonme();
        }

        //formu hareket ettirme////////////////////////////////////////////////////////////////////////////////

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
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
            lblTitle.Text = "Hoş Geldiniz";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
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
            lblTitle.Text = childForm.Text;
        }

        

        private void anamenuyedonme()
        {
            Giriş.ana_duyuru duyuruform = new Giriş.ana_duyuru();

            activeForm = duyuruform;
            duyuruform.TopLevel = false;
            duyuruform.FormBorderStyle = FormBorderStyle.None;
            duyuruform.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(duyuruform);
            this.panelDesktopPanel.Tag = duyuruform;
            duyuruform.BringToFront();
            duyuruform.Show();
            lblTitle.Text = "Duyurular";
        }

        private void ogrencigiris_Click(object sender, EventArgs e)
        {
            alt_form_acma(new ogr_giris(), sender);
        }

        private void akademisyengiris_Click(object sender, EventArgs e)
        {
            alt_form_acma(new akdmsyn_giris(), sender);
        }

        private void ogrenciislerigiris_Click(object sender, EventArgs e)
        {
            alt_form_acma(new ogrisleri_giris(), sender);
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

        //sağ üstteki butonlar, formu küçültme, tam ekran yapma ve kapatma tuşları////////////////////////////////////////////////////////////////////////////////

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

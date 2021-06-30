
namespace Öğrenci_Otomasyonu_1._0
{
    partial class akademisyen_anasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(akademisyen_anasayfa));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.sifre_islemleri = new System.Windows.Forms.Button();
            this.mesaj = new System.Windows.Forms.Button();
            this.danisman = new System.Windows.Forms.Button();
            this.saat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnminimize = new System.Windows.Forms.Button();
            this.btnmaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.sifre_islemleri);
            this.panelMenu.Controls.Add(this.mesaj);
            this.panelMenu.Controls.Add(this.danisman);
            this.panelMenu.Controls.Add(this.saat);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(293, 728);
            this.panelMenu.TabIndex = 1;
            // 
            // sifre_islemleri
            // 
            this.sifre_islemleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.sifre_islemleri.FlatAppearance.BorderSize = 0;
            this.sifre_islemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sifre_islemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sifre_islemleri.ForeColor = System.Drawing.Color.Gainsboro;
            this.sifre_islemleri.Location = new System.Drawing.Point(0, 320);
            this.sifre_islemleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sifre_islemleri.Name = "sifre_islemleri";
            this.sifre_islemleri.Size = new System.Drawing.Size(293, 74);
            this.sifre_islemleri.TabIndex = 7;
            this.sifre_islemleri.Text = "Şifre İşlemleri";
            this.sifre_islemleri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sifre_islemleri.UseVisualStyleBackColor = true;
            this.sifre_islemleri.Click += new System.EventHandler(this.sifre_islemleri_Click_1);
            // 
            // mesaj
            // 
            this.mesaj.Dock = System.Windows.Forms.DockStyle.Top;
            this.mesaj.FlatAppearance.BorderSize = 0;
            this.mesaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mesaj.ForeColor = System.Drawing.Color.Gainsboro;
            this.mesaj.Location = new System.Drawing.Point(0, 246);
            this.mesaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mesaj.Name = "mesaj";
            this.mesaj.Size = new System.Drawing.Size(293, 74);
            this.mesaj.TabIndex = 6;
            this.mesaj.Text = "Mesajlar";
            this.mesaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mesaj.UseVisualStyleBackColor = true;
            this.mesaj.Click += new System.EventHandler(this.sifre_islemleri_Click);
            // 
            // danisman
            // 
            this.danisman.Dock = System.Windows.Forms.DockStyle.Top;
            this.danisman.FlatAppearance.BorderSize = 0;
            this.danisman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.danisman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.danisman.ForeColor = System.Drawing.Color.Gainsboro;
            this.danisman.Location = new System.Drawing.Point(0, 172);
            this.danisman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.danisman.Name = "danisman";
            this.danisman.Size = new System.Drawing.Size(293, 74);
            this.danisman.TabIndex = 5;
            this.danisman.Text = "Danışman İşlemleri";
            this.danisman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.danisman.UseVisualStyleBackColor = true;
            this.danisman.Click += new System.EventHandler(this.button2_Click);
            // 
            // saat
            // 
            this.saat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saat.AutoSize = true;
            this.saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saat.ForeColor = System.Drawing.Color.Gainsboro;
            this.saat.Location = new System.Drawing.Point(16, 635);
            this.saat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(53, 20);
            this.saat.TabIndex = 4;
            this.saat.Text = "label2";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(0, 98);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 74);
            this.button1.TabIndex = 3;
            this.button1.Text = "Not İşlemleri";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnCloseChildForm);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(293, 98);
            this.panelLogo.TabIndex = 2;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCloseChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(293, 98);
            this.btnCloseChildForm.TabIndex = 2;
            this.btnCloseChildForm.Text = "Ana Menü";
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gazi Üniversitesi";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnminimize);
            this.panelTitleBar.Controls.Add(this.btnmaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panelTitleBar.Location = new System.Drawing.Point(293, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1368, 98);
            this.panelTitleBar.TabIndex = 3;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnminimize
            // 
            this.btnminimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimize.FlatAppearance.BorderSize = 0;
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnminimize.ForeColor = System.Drawing.Color.White;
            this.btnminimize.Location = new System.Drawing.Point(1244, -12);
            this.btnminimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(36, 37);
            this.btnminimize.TabIndex = 1;
            this.btnminimize.Text = "x";
            this.btnminimize.UseVisualStyleBackColor = true;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnmaximize
            // 
            this.btnmaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximize.FlatAppearance.BorderSize = 0;
            this.btnmaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmaximize.ForeColor = System.Drawing.Color.White;
            this.btnmaximize.Location = new System.Drawing.Point(1288, -12);
            this.btnmaximize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnmaximize.Name = "btnmaximize";
            this.btnmaximize.Size = new System.Drawing.Size(36, 37);
            this.btnmaximize.TabIndex = 2;
            this.btnmaximize.Text = "x";
            this.btnmaximize.UseVisualStyleBackColor = true;
            this.btnmaximize.Click += new System.EventHandler(this.btnmaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1332, -12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(584, 34);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOŞ GELDİNİZ";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(293, 98);
            this.panelDesktopPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1368, 630);
            this.panelDesktopPanel.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // akademisyen_anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 690);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1661, 728);
            this.Name = "akademisyen_anasayfa";
            this.Text = "akademisyen_anasayfa";
            this.Load += new System.EventHandler(this.akademisyen_anasayfa_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Button btnmaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button danisman;
        private System.Windows.Forms.Button mesaj;
        private System.Windows.Forms.Button sifre_islemleri;
    }
}
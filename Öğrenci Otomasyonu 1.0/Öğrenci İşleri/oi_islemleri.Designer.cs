
namespace Öğrenci_Otomasyonu_1._0.Öğrenci_İşleri
{
    partial class oi_islemleri
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonyenile = new System.Windows.Forms.Button();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.ekle = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblad = new System.Windows.Forms.Label();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.buttonakademisyensilliste = new System.Windows.Forms.Button();
            this.buttonkullanıcısil = new System.Windows.Forms.Button();
            this.kullanıcısilliste = new System.Windows.Forms.ComboBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1067, 554);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.dataGridView1);
            this.metroTabPage1.Controls.Add(this.panel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 12;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1059, 512);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Kullanıcı Listele";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.asd});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 123);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1059, 389);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "kullanici_no";
            this.Column2.HeaderText = "Kullanıcı No";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // asd
            // 
            this.asd.DataPropertyName = "kullanici_ad_soyad";
            this.asd.HeaderText = "Ad Soyad";
            this.asd.MinimumWidth = 6;
            this.asd.Name = "asd";
            this.asd.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonyenile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 123);
            this.panel1.TabIndex = 4;
            // 
            // buttonyenile
            // 
            this.buttonyenile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonyenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonyenile.Location = new System.Drawing.Point(480, 48);
            this.buttonyenile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonyenile.Name = "buttonyenile";
            this.buttonyenile.Size = new System.Drawing.Size(100, 28);
            this.buttonyenile.TabIndex = 3;
            this.buttonyenile.Text = "Yenile";
            this.buttonyenile.UseVisualStyleBackColor = true;
            this.buttonyenile.Click += new System.EventHandler(this.buttonyenile_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.ekle);
            this.metroTabPage2.Controls.Add(this.textBox2);
            this.metroTabPage2.Controls.Add(this.lblsoyad);
            this.metroTabPage2.Controls.Add(this.textBox1);
            this.metroTabPage2.Controls.Add(this.lblad);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 12;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1059, 512);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Kullanıcı Ekle";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 13;
            // 
            // ekle
            // 
            this.ekle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ekle.Enabled = false;
            this.ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ekle.Location = new System.Drawing.Point(485, 290);
            this.ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(161, 38);
            this.ekle.TabIndex = 3;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(485, 231);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblsoyad
            // 
            this.lblsoyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblsoyad.Location = new System.Drawing.Point(411, 231);
            this.lblsoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(55, 20);
            this.lblsoyad.TabIndex = 16;
            this.lblsoyad.Text = "Soyad";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(485, 174);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 26);
            this.textBox1.TabIndex = 1;
            // 
            // lblad
            // 
            this.lblad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblad.Location = new System.Drawing.Point(440, 177);
            this.lblad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(29, 20);
            this.lblad.TabIndex = 14;
            this.lblad.Text = "Ad";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.buttonakademisyensilliste);
            this.metroTabPage3.Controls.Add(this.buttonkullanıcısil);
            this.metroTabPage3.Controls.Add(this.kullanıcısilliste);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 12;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1059, 512);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Kullanıcı Sil";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 13;
            // 
            // buttonakademisyensilliste
            // 
            this.buttonakademisyensilliste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonakademisyensilliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonakademisyensilliste.Location = new System.Drawing.Point(291, 186);
            this.buttonakademisyensilliste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonakademisyensilliste.Name = "buttonakademisyensilliste";
            this.buttonakademisyensilliste.Size = new System.Drawing.Size(169, 73);
            this.buttonakademisyensilliste.TabIndex = 13;
            this.buttonakademisyensilliste.Text = "Kullanıcı Listele";
            this.buttonakademisyensilliste.UseVisualStyleBackColor = true;
            this.buttonakademisyensilliste.Click += new System.EventHandler(this.buttonakademisyensilliste_Click);
            // 
            // buttonkullanıcısil
            // 
            this.buttonkullanıcısil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonkullanıcısil.Enabled = false;
            this.buttonkullanıcısil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonkullanıcısil.Location = new System.Drawing.Point(589, 268);
            this.buttonkullanıcısil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonkullanıcısil.Name = "buttonkullanıcısil";
            this.buttonkullanıcısil.Size = new System.Drawing.Size(136, 49);
            this.buttonkullanıcısil.TabIndex = 12;
            this.buttonkullanıcısil.Text = "Kullanıcı Sil";
            this.buttonkullanıcısil.UseVisualStyleBackColor = true;
            this.buttonkullanıcısil.Click += new System.EventHandler(this.buttonkullanıcısil_Click);
            // 
            // kullanıcısilliste
            // 
            this.kullanıcısilliste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kullanıcısilliste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kullanıcısilliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcısilliste.FormattingEnabled = true;
            this.kullanıcısilliste.Location = new System.Drawing.Point(552, 208);
            this.kullanıcısilliste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kullanıcısilliste.Name = "kullanıcısilliste";
            this.kullanıcısilliste.Size = new System.Drawing.Size(212, 28);
            this.kullanıcısilliste.TabIndex = 11;
            this.kullanıcısilliste.SelectedIndexChanged += new System.EventHandler(this.kullanıcısilliste_SelectedIndexChanged);
            // 
            // oi_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.metroTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "oi_islemleri";
            this.Text = "oi_islemleri";
            this.Load += new System.EventHandler(this.oi_islemleri_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonyenile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn asd;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblad;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.Button buttonakademisyensilliste;
        private System.Windows.Forms.Button buttonkullanıcısil;
        private System.Windows.Forms.ComboBox kullanıcısilliste;
    }
}
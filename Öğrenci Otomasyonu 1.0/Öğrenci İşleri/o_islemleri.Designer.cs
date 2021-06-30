
namespace Öğrenci_Otomasyonu_1._0.Öğrenci_İşleri
{
    partial class o_islemleri
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
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayit_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asdasd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonlistele = new System.Windows.Forms.Button();
            this.filtre = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.liste1 = new System.Windows.Forms.ComboBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.comboBox_danisman = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_baba = new System.Windows.Forms.TextBox();
            this.label_baba = new System.Windows.Forms.Label();
            this.textBox_anne = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_kimlikno = new System.Windows.Forms.TextBox();
            this.label_kimlikno = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ekle = new System.Windows.Forms.Button();
            this.liste2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblad = new System.Windows.Forms.Label();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.ogrencisilliste = new System.Windows.Forms.Button();
            this.buttonogrencisil = new System.Windows.Forms.Button();
            this.ogrencisillistee = new System.Windows.Forms.ComboBox();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.dataGridView1);
            this.metroTabPage1.Controls.Add(this.panel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(792, 408);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Öğrenci Listele";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
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
            this.Column3,
            this.Column2,
            this.asd,
            this.kayit_tarihi,
            this.asdasd});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(792, 308);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "bolum";
            this.Column3.HeaderText = "Bölüm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ogrenci_no";
            this.Column2.HeaderText = "Öğrenci No";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // asd
            // 
            this.asd.DataPropertyName = "ogrenci_ad_soyad";
            this.asd.HeaderText = "Ad Soyad";
            this.asd.MinimumWidth = 6;
            this.asd.Name = "asd";
            this.asd.ReadOnly = true;
            // 
            // kayit_tarihi
            // 
            this.kayit_tarihi.DataPropertyName = "kayit_tarihi";
            this.kayit_tarihi.HeaderText = "Kayıt Tarihi";
            this.kayit_tarihi.MinimumWidth = 6;
            this.kayit_tarihi.Name = "kayit_tarihi";
            this.kayit_tarihi.ReadOnly = true;
            // 
            // asdasd
            // 
            this.asdasd.DataPropertyName = "sinif";
            this.asdasd.HeaderText = "Sinif";
            this.asdasd.MinimumWidth = 6;
            this.asdasd.Name = "asdasd";
            this.asdasd.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonlistele);
            this.panel1.Controls.Add(this.filtre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.liste1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 100);
            this.panel1.TabIndex = 3;
            // 
            // buttonlistele
            // 
            this.buttonlistele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonlistele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonlistele.Location = new System.Drawing.Point(529, 39);
            this.buttonlistele.Name = "buttonlistele";
            this.buttonlistele.Size = new System.Drawing.Size(75, 23);
            this.buttonlistele.TabIndex = 3;
            this.buttonlistele.Text = "Listele";
            this.buttonlistele.UseVisualStyleBackColor = true;
            this.buttonlistele.Click += new System.EventHandler(this.buttonlistele_Click);
            // 
            // filtre
            // 
            this.filtre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filtre.AutoSize = true;
            this.filtre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.filtre.Location = new System.Drawing.Point(192, 41);
            this.filtre.Name = "filtre";
            this.filtre.Size = new System.Drawing.Size(58, 21);
            this.filtre.TabIndex = 2;
            this.filtre.Text = "Filtre";
            this.filtre.UseVisualStyleBackColor = true;
            this.filtre.CheckedChanged += new System.EventHandler(this.filtre_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(290, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bölüm:";
            // 
            // liste1
            // 
            this.liste1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.liste1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.liste1.Enabled = false;
            this.liste1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.liste1.FormattingEnabled = true;
            this.liste1.Items.AddRange(new object[] {
            "Bilgisayar Mühendisliği",
            "Elektrik Elektronik Mühendisliği",
            "Makine Mühendisliği",
            "İnşaat Mühendisliği",
            "Kimya Mühendisliği"});
            this.liste1.Location = new System.Drawing.Point(347, 38);
            this.liste1.Name = "liste1";
            this.liste1.Size = new System.Drawing.Size(143, 24);
            this.liste1.TabIndex = 0;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(800, 450);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.comboBox_danisman);
            this.metroTabPage2.Controls.Add(this.label5);
            this.metroTabPage2.Controls.Add(this.dateTimePicker1);
            this.metroTabPage2.Controls.Add(this.textBox_baba);
            this.metroTabPage2.Controls.Add(this.label_baba);
            this.metroTabPage2.Controls.Add(this.textBox_anne);
            this.metroTabPage2.Controls.Add(this.label7);
            this.metroTabPage2.Controls.Add(this.label3);
            this.metroTabPage2.Controls.Add(this.textBox_kimlikno);
            this.metroTabPage2.Controls.Add(this.label_kimlikno);
            this.metroTabPage2.Controls.Add(this.comboBox1);
            this.metroTabPage2.Controls.Add(this.label2);
            this.metroTabPage2.Controls.Add(this.ekle);
            this.metroTabPage2.Controls.Add(this.liste2);
            this.metroTabPage2.Controls.Add(this.label4);
            this.metroTabPage2.Controls.Add(this.textBox2);
            this.metroTabPage2.Controls.Add(this.lblsoyad);
            this.metroTabPage2.Controls.Add(this.textBox1);
            this.metroTabPage2.Controls.Add(this.lblad);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(792, 408);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Öğrenci Ekle";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // comboBox_danisman
            // 
            this.comboBox_danisman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_danisman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_danisman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox_danisman.FormattingEnabled = true;
            this.comboBox_danisman.ItemHeight = 16;
            this.comboBox_danisman.Location = new System.Drawing.Point(364, 300);
            this.comboBox_danisman.Name = "comboBox_danisman";
            this.comboBox_danisman.Size = new System.Drawing.Size(121, 24);
            this.comboBox_danisman.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(287, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Danışman";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(364, 210);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox_baba
            // 
            this.textBox_baba.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_baba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_baba.Location = new System.Drawing.Point(364, 153);
            this.textBox_baba.Name = "textBox_baba";
            this.textBox_baba.Size = new System.Drawing.Size(121, 23);
            this.textBox_baba.TabIndex = 4;
            // 
            // label_baba
            // 
            this.label_baba.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_baba.AutoSize = true;
            this.label_baba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_baba.Location = new System.Drawing.Point(293, 156);
            this.label_baba.Name = "label_baba";
            this.label_baba.Size = new System.Drawing.Size(65, 17);
            this.label_baba.TabIndex = 22;
            this.label_baba.Text = "Baba Adı";
            // 
            // textBox_anne
            // 
            this.textBox_anne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_anne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_anne.Location = new System.Drawing.Point(364, 124);
            this.textBox_anne.Name = "textBox_anne";
            this.textBox_anne.Size = new System.Drawing.Size(121, 23);
            this.textBox_anne.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(293, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Anne Adı";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(265, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Doğum Tarihi";
            // 
            // textBox_kimlikno
            // 
            this.textBox_kimlikno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_kimlikno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_kimlikno.Location = new System.Drawing.Point(364, 182);
            this.textBox_kimlikno.Name = "textBox_kimlikno";
            this.textBox_kimlikno.Size = new System.Drawing.Size(121, 23);
            this.textBox_kimlikno.TabIndex = 5;
            // 
            // label_kimlikno
            // 
            this.label_kimlikno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_kimlikno.AutoSize = true;
            this.label_kimlikno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_kimlikno.Location = new System.Drawing.Point(250, 185);
            this.label_kimlikno.Name = "label_kimlikno";
            this.label_kimlikno.Size = new System.Drawing.Size(108, 17);
            this.label_kimlikno.TabIndex = 16;
            this.label_kimlikno.Text = "Kimlik Numarası";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 16;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(364, 270);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(320, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sınıf";
            // 
            // ekle
            // 
            this.ekle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ekle.Enabled = false;
            this.ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ekle.Location = new System.Drawing.Point(364, 330);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(121, 43);
            this.ekle.TabIndex = 10;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // liste2
            // 
            this.liste2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.liste2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.liste2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.liste2.FormattingEnabled = true;
            this.liste2.ItemHeight = 16;
            this.liste2.Items.AddRange(new object[] {
            "Bilgisayar Mühendisliği",
            "Elektrik Elektronik Mühendisliği",
            "Makine Mühendisliği",
            "İnşaat Mühendisliği",
            "Kimya Mühendisliği"});
            this.liste2.Location = new System.Drawing.Point(364, 240);
            this.liste2.Name = "liste2";
            this.liste2.Size = new System.Drawing.Size(121, 24);
            this.liste2.TabIndex = 12;
            this.liste2.SelectedIndexChanged += new System.EventHandler(this.liste2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(311, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bölüm";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(364, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 23);
            this.textBox2.TabIndex = 2;
            // 
            // lblsoyad
            // 
            this.lblsoyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblsoyad.Location = new System.Drawing.Point(308, 95);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(48, 17);
            this.lblsoyad.TabIndex = 9;
            this.lblsoyad.Text = "Soyad";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(364, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 1;
            // 
            // lblad
            // 
            this.lblad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblad.Location = new System.Drawing.Point(330, 69);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(25, 17);
            this.lblad.TabIndex = 7;
            this.lblad.Text = "Ad";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.ogrencisilliste);
            this.metroTabPage3.Controls.Add(this.buttonogrencisil);
            this.metroTabPage3.Controls.Add(this.ogrencisillistee);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 8;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(792, 408);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Öğrenci Sil";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 8;
            // 
            // ogrencisilliste
            // 
            this.ogrencisilliste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ogrencisilliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrencisilliste.Location = new System.Drawing.Point(220, 119);
            this.ogrencisilliste.Name = "ogrencisilliste";
            this.ogrencisilliste.Size = new System.Drawing.Size(127, 59);
            this.ogrencisilliste.TabIndex = 7;
            this.ogrencisilliste.Text = "Öğrencileri Listele";
            this.ogrencisilliste.UseVisualStyleBackColor = true;
            this.ogrencisilliste.Click += new System.EventHandler(this.ogrencisilliste_Click);
            // 
            // buttonogrencisil
            // 
            this.buttonogrencisil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonogrencisil.Enabled = false;
            this.buttonogrencisil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonogrencisil.Location = new System.Drawing.Point(444, 186);
            this.buttonogrencisil.Name = "buttonogrencisil";
            this.buttonogrencisil.Size = new System.Drawing.Size(98, 38);
            this.buttonogrencisil.TabIndex = 6;
            this.buttonogrencisil.Text = "Öğrenciyi sil";
            this.buttonogrencisil.UseVisualStyleBackColor = true;
            this.buttonogrencisil.Click += new System.EventHandler(this.buttonogrencisil_Click);
            // 
            // ogrencisillistee
            // 
            this.ogrencisillistee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ogrencisillistee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ogrencisillistee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrencisillistee.FormattingEnabled = true;
            this.ogrencisillistee.Location = new System.Drawing.Point(416, 137);
            this.ogrencisillistee.Name = "ogrencisillistee";
            this.ogrencisillistee.Size = new System.Drawing.Size(160, 24);
            this.ogrencisillistee.TabIndex = 5;
            this.ogrencisillistee.SelectedIndexChanged += new System.EventHandler(this.dersilmeliste_SelectedIndexChanged);
            // 
            // o_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "o_islemleri";
            this.Text = "o_islemleri";
            this.Load += new System.EventHandler(this.o_islemleri_Load);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox liste1;
        private System.Windows.Forms.CheckBox filtre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonlistele;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.ComboBox liste2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblad;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.Button ogrencisilliste;
        private System.Windows.Forms.Button buttonogrencisil;
        private System.Windows.Forms.ComboBox ogrencisillistee;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn asd;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayit_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn asdasd;
        private System.Windows.Forms.TextBox textBox_baba;
        private System.Windows.Forms.Label label_baba;
        private System.Windows.Forms.TextBox textBox_anne;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_kimlikno;
        private System.Windows.Forms.Label label_kimlikno;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_danisman;
        private System.Windows.Forms.Label label5;
    }
}
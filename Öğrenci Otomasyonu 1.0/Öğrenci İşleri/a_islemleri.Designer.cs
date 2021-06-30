
namespace Öğrenci_Otomasyonu_1._0.Öğrenci_İşleri
{
    partial class a_islemleri
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
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonlistele = new System.Windows.Forms.Button();
            this.filtre = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.liste1 = new System.Windows.Forms.ComboBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.ekle1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ekle = new System.Windows.Forms.Button();
            this.liste2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblad = new System.Windows.Forms.Label();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.buttonakademisyensilliste = new System.Windows.Forms.Button();
            this.buttonakademisyensil = new System.Windows.Forms.Button();
            this.akademisyensilliste = new System.Windows.Forms.ComboBox();
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
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(800, 450);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
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
            this.metroTabPage1.Text = "Akademisyen Listele";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(792, 308);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ID";
            this.Column4.HeaderText = "No";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "bolum";
            this.Column5.HeaderText = "Bölüm";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "akademisyen_no";
            this.Column6.HeaderText = "Akademisyen No";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "akademisyen_ad_soyad";
            this.Column7.HeaderText = "Ad Soyad";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
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
            this.panel1.TabIndex = 4;
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
            this.filtre.Location = new System.Drawing.Point(189, 40);
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
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.ekle1);
            this.metroTabPage2.Controls.Add(this.comboBox1);
            this.metroTabPage2.Controls.Add(this.label2);
            this.metroTabPage2.Controls.Add(this.textBox3);
            this.metroTabPage2.Controls.Add(this.label3);
            this.metroTabPage2.Controls.Add(this.textBox4);
            this.metroTabPage2.Controls.Add(this.label5);
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
            this.metroTabPage2.Text = "Akademisyen Ekle";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // ekle1
            // 
            this.ekle1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ekle1.Enabled = false;
            this.ekle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ekle1.Location = new System.Drawing.Point(364, 255);
            this.ekle1.Name = "ekle1";
            this.ekle1.Size = new System.Drawing.Size(121, 31);
            this.ekle1.TabIndex = 4;
            this.ekle1.Text = "Ekle";
            this.ekle1.UseVisualStyleBackColor = true;
            this.ekle1.Click += new System.EventHandler(this.ekle1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 16;
            this.comboBox1.Items.AddRange(new object[] {
            "Bilgisayar Mühendisliği",
            "Elektrik Elektronik Mühendisliği",
            "Makine Mühendisliği",
            "İnşaat Mühendisliği",
            "Kimya Mühendisliği"});
            this.comboBox1.Location = new System.Drawing.Point(364, 209);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(308, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Bölüm";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox3.Location = new System.Drawing.Point(364, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 23);
            this.textBox3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(308, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Soyad";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox4.Location = new System.Drawing.Point(364, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 23);
            this.textBox4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(330, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ad";
            // 
            // ekle
            // 
            this.ekle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ekle.Location = new System.Drawing.Point(364, 257);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(121, 31);
            this.ekle.TabIndex = 20;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            // 
            // liste2
            // 
            this.liste2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.liste2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.liste2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.liste2.FormattingEnabled = true;
            this.liste2.Items.AddRange(new object[] {
            "Bilgisayar Mühendisliği",
            "Elektrik Elektronik Mühendisliği",
            "Makine Mühendisliği",
            "İnşaat Mühendisliği",
            "Kimya Mühendisliği",
            "Tıp"});
            this.liste2.Location = new System.Drawing.Point(364, 209);
            this.liste2.Name = "liste2";
            this.liste2.Size = new System.Drawing.Size(121, 24);
            this.liste2.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(308, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Bölüm";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(364, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 23);
            this.textBox2.TabIndex = 17;
            // 
            // lblsoyad
            // 
            this.lblsoyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblsoyad.Location = new System.Drawing.Point(308, 170);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(48, 17);
            this.lblsoyad.TabIndex = 16;
            this.lblsoyad.Text = "Soyad";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(364, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 15;
            // 
            // lblad
            // 
            this.lblad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblad.Location = new System.Drawing.Point(330, 126);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(25, 17);
            this.lblad.TabIndex = 14;
            this.lblad.Text = "Ad";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.buttonakademisyensilliste);
            this.metroTabPage3.Controls.Add(this.buttonakademisyensil);
            this.metroTabPage3.Controls.Add(this.akademisyensilliste);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(792, 408);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Akademisyen Sil";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // buttonakademisyensilliste
            // 
            this.buttonakademisyensilliste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonakademisyensilliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonakademisyensilliste.Location = new System.Drawing.Point(218, 152);
            this.buttonakademisyensilliste.Name = "buttonakademisyensilliste";
            this.buttonakademisyensilliste.Size = new System.Drawing.Size(127, 59);
            this.buttonakademisyensilliste.TabIndex = 10;
            this.buttonakademisyensilliste.Text = "Akademisyen Listele";
            this.buttonakademisyensilliste.UseVisualStyleBackColor = true;
            this.buttonakademisyensilliste.Click += new System.EventHandler(this.buttonakademisyensilliste_Click);
            // 
            // buttonakademisyensil
            // 
            this.buttonakademisyensil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonakademisyensil.Enabled = false;
            this.buttonakademisyensil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonakademisyensil.Location = new System.Drawing.Point(442, 219);
            this.buttonakademisyensil.Name = "buttonakademisyensil";
            this.buttonakademisyensil.Size = new System.Drawing.Size(102, 40);
            this.buttonakademisyensil.TabIndex = 9;
            this.buttonakademisyensil.Text = "Akademisyen Sil";
            this.buttonakademisyensil.UseVisualStyleBackColor = true;
            this.buttonakademisyensil.Click += new System.EventHandler(this.buttonakademisyensil_Click);
            // 
            // akademisyensilliste
            // 
            this.akademisyensilliste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.akademisyensilliste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.akademisyensilliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.akademisyensilliste.FormattingEnabled = true;
            this.akademisyensilliste.Location = new System.Drawing.Point(414, 170);
            this.akademisyensilliste.Name = "akademisyensilliste";
            this.akademisyensilliste.Size = new System.Drawing.Size(160, 24);
            this.akademisyensilliste.TabIndex = 8;
            this.akademisyensilliste.SelectedIndexChanged += new System.EventHandler(this.akademisyensilliste_SelectedIndexChanged);
            // 
            // a_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "a_islemleri";
            this.Text = "a_islemleri";
            this.Load += new System.EventHandler(this.a_islemleri_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button buttonlistele;
        private System.Windows.Forms.CheckBox filtre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox liste1;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.ComboBox liste2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Button ekle1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.Button buttonakademisyensilliste;
        private System.Windows.Forms.Button buttonakademisyensil;
        private System.Windows.Forms.ComboBox akademisyensilliste;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
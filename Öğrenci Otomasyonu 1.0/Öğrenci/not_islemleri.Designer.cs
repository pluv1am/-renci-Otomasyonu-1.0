
namespace Öğrenci_Otomasyonu_1._0.Öğrenci
{
    partial class Not_İslemleri
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
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortalama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonlistele = new System.Windows.Forms.Button();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
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
            this.metroTabPage2.Controls.Add(this.dataGridView1);
            this.metroTabPage2.Controls.Add(this.panel1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(792, 408);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Not Listele";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column,
            this.Column2,
            this.Column4,
            this.Column5,
            this.vize,
            this.Final,
            this.ortalama,
            this.harf});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(792, 308);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column
            // 
            this.Column.DataPropertyName = "ders_adi";
            this.Column.HeaderText = "Ders Adı";
            this.Column.MinimumWidth = 6;
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ders_kodu";
            this.Column2.HeaderText = "Ders Kodu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "akts";
            this.Column4.HeaderText = "Akts";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "sinif";
            this.Column5.HeaderText = "Sınıf";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // vize
            // 
            this.vize.HeaderText = "Vize";
            this.vize.MinimumWidth = 6;
            this.vize.Name = "vize";
            this.vize.ReadOnly = true;
            // 
            // Final
            // 
            this.Final.HeaderText = "final";
            this.Final.MinimumWidth = 6;
            this.Final.Name = "Final";
            this.Final.ReadOnly = true;
            // 
            // ortalama
            // 
            this.ortalama.HeaderText = "ortalama";
            this.ortalama.MinimumWidth = 6;
            this.ortalama.Name = "ortalama";
            this.ortalama.ReadOnly = true;
            // 
            // harf
            // 
            this.harf.DataPropertyName = "harf_notu";
            this.harf.HeaderText = "Harf Notu";
            this.harf.MinimumWidth = 6;
            this.harf.Name = "harf";
            this.harf.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonlistele);
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
            this.buttonlistele.Location = new System.Drawing.Point(348, 32);
            this.buttonlistele.Name = "buttonlistele";
            this.buttonlistele.Size = new System.Drawing.Size(96, 37);
            this.buttonlistele.TabIndex = 7;
            this.buttonlistele.Text = "Listele";
            this.buttonlistele.UseVisualStyleBackColor = true;
            this.buttonlistele.Click += new System.EventHandler(this.buttonlistele_Click);
            // 
            // Not_İslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Not_İslemleri";
            this.Text = "Not_İslemleri";
            this.Load += new System.EventHandler(this.Not_İslemleri_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonlistele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn vize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Final;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalama;
        private System.Windows.Forms.DataGridViewTextBoxColumn harf;
    }
}
﻿
namespace Öğrenci_Otomasyonu_1._0
{
    partial class ogr_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogr_giris));
            this.textBox1_ogr_no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2_ogr_sifre = new System.Windows.Forms.TextBox();
            this.button1_giris = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1_ogr_no
            // 
            this.textBox1_ogr_no.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1_ogr_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1_ogr_no.Location = new System.Drawing.Point(607, 228);
            this.textBox1_ogr_no.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1_ogr_no.Name = "textBox1_ogr_no";
            this.textBox1_ogr_no.Size = new System.Drawing.Size(193, 34);
            this.textBox1_ogr_no.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(448, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci No:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(529, 293);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre:";
            // 
            // textBox2_ogr_sifre
            // 
            this.textBox2_ogr_sifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2_ogr_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox2_ogr_sifre.Location = new System.Drawing.Point(607, 293);
            this.textBox2_ogr_sifre.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2_ogr_sifre.Name = "textBox2_ogr_sifre";
            this.textBox2_ogr_sifre.Size = new System.Drawing.Size(193, 34);
            this.textBox2_ogr_sifre.TabIndex = 2;
            // 
            // button1_giris
            // 
            this.button1_giris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1_giris.FlatAppearance.BorderSize = 0;
            this.button1_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1_giris.Location = new System.Drawing.Point(628, 361);
            this.button1_giris.Margin = new System.Windows.Forms.Padding(4);
            this.button1_giris.Name = "button1_giris";
            this.button1_giris.Size = new System.Drawing.Size(152, 49);
            this.button1_giris.TabIndex = 3;
            this.button1_giris.Text = "Giriş";
            this.button1_giris.UseVisualStyleBackColor = true;
            this.button1_giris.Click += new System.EventHandler(this.button1_giris_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(807, 301);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Şifreyi göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ogr_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 639);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1_giris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2_ogr_sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_ogr_no);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ogr_giris";
            this.Text = "ÖĞRENCİ GİRİŞİ";
            this.Load += new System.EventHandler(this.ogr_giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1_ogr_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2_ogr_sifre;
        private System.Windows.Forms.Button button1_giris;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

namespace Öğrenci_Otomasyonu_1._0
{
    partial class akdmsyn_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(akdmsyn_giris));
            this.button1_giris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2_akdmsyn_sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_akdmsyn_no = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1_giris
            // 
            this.button1_giris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1_giris.FlatAppearance.BorderSize = 0;
            this.button1_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1_giris.Location = new System.Drawing.Point(568, 319);
            this.button1_giris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1_giris.Name = "button1_giris";
            this.button1_giris.Size = new System.Drawing.Size(152, 49);
            this.button1_giris.TabIndex = 3;
            this.button1_giris.Text = "Giriş";
            this.button1_giris.UseVisualStyleBackColor = true;
            this.button1_giris.Click += new System.EventHandler(this.button1_giris_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(469, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şifre:";
            // 
            // textBox2_akdmsyn_sifre
            // 
            this.textBox2_akdmsyn_sifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2_akdmsyn_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox2_akdmsyn_sifre.Location = new System.Drawing.Point(547, 251);
            this.textBox2_akdmsyn_sifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2_akdmsyn_sifre.Name = "textBox2_akdmsyn_sifre";
            this.textBox2_akdmsyn_sifre.Size = new System.Drawing.Size(193, 34);
            this.textBox2_akdmsyn_sifre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(327, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Akademisyen No:";
            // 
            // textBox1_akdmsyn_no
            // 
            this.textBox1_akdmsyn_no.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1_akdmsyn_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1_akdmsyn_no.Location = new System.Drawing.Point(547, 186);
            this.textBox1_akdmsyn_no.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1_akdmsyn_no.Name = "textBox1_akdmsyn_no";
            this.textBox1_akdmsyn_no.Size = new System.Drawing.Size(193, 34);
            this.textBox1_akdmsyn_no.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(747, 255);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Şifreyi göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // akdmsyn_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1_giris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2_akdmsyn_sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_akdmsyn_no);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "akdmsyn_giris";
            this.Text = "AKADEMİSYEN GİRİŞİ";
            this.Load += new System.EventHandler(this.akdmsyn_giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_giris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2_akdmsyn_sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_akdmsyn_no;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
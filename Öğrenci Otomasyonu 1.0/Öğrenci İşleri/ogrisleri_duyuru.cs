﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace Öğrenci_Otomasyonu_1._0.Öğrenci_İşleri
{
    public partial class ogrisleri_duyuru : Form
    {
        public ogrisleri_duyuru()
        {
            InitializeComponent();
        }

        private string link1, link2, link3, link4, link5;

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link3);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link4);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link5);
        }

        

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link2);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link1);
        }

        private void ogrisleri_duyuru_Paint(object sender, PaintEventArgs e)
        {
            Pen kalem = new Pen(Color.FromArgb(128, 128, 128), 4);
            e.Graphics.DrawLine(kalem, label1.Left + 2, label1.Bottom + 5, label1.Left + 85, label1.Bottom + 5);
            
            e.Graphics.DrawLine(kalem, label2.Left + 2, label2.Bottom + 5, label2.Left + 85, label2.Bottom + 5);

            e.Graphics.DrawLine(kalem, label3.Left + 2, label3.Bottom + 5, label3.Left + 85, label3.Bottom + 5);

            e.Graphics.DrawLine(kalem, label4.Left + 2, label4.Bottom + 5, label4.Left + 85, label4.Bottom + 5);

            e.Graphics.DrawLine(kalem, label5.Left + 2, label5.Bottom + 5, label5.Left + 85, label5.Bottom + 5);
        }

        private void ogrisleri_duyuru_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void ogrisleri_duyuru_Load(object sender, EventArgs e)
        {
            HtmlWeb site = new HtmlWeb();
            HtmlDocument document = site.Load("http://ogris.gazi.edu.tr/");

            string duyuru1tarih = document.DocumentNode.SelectSingleNode("/html/body/div/div/div[2]/div[1]/div[2]/div[1]/p").OuterHtml;
            string duyuru1 = WebUtility.HtmlDecode(document.DocumentNode.SelectSingleNode("/html/body/div/div/div[2]/div[1]/div[2]/div[2]/a").OuterHtml);

            string duyuru2tarih = WebUtility.HtmlDecode(document.DocumentNode.SelectSingleNode("/html/body/div/div/div[2]/div[1]/div[3]/div[1]/p").OuterHtml);
            string duyuru2 = WebUtility.HtmlDecode(document.DocumentNode.SelectSingleNode("/html/body/div/div/div[2]/div[1]/div[3]/div[2]/a").OuterHtml);

            string duyuru3tarih = WebUtility.HtmlDecode(document.DocumentNode.SelectSingleNode("/html/body/div/div/div[2]/div[1]/div[4]/div[1]/p").OuterHtml);
            string duyuru3 = WebUtility.HtmlDecode(document.DocumentNode.SelectSingleNode("/html/body/div/div/div[2]/div[1]/div[4]/div[2]/a").OuterHtml);

            string duyuru4tarih = WebUtility.HtmlDecode(document.DocumentNode.SelectSingleNode("/html/body/div/div/div[2]/div[1]/div[5]/div[1]/p").OuterHtml);
            string duyuru4 = WebUtility.HtmlDecode(document.DocumentNode.SelectSingleNode("/html/body/div/div/div[2]/div[1]/div[5]/div[2]/a").OuterHtml);

            string duyuru5tarih = WebUtility.HtmlDecode(document.DocumentNode.SelectSingleNode("/html/body/div/div/div[2]/div[1]/div[6]/div[1]/p").OuterHtml);
            string duyuru5 = WebUtility.HtmlDecode(document.DocumentNode.SelectSingleNode("/html/body/div/div/div[2]/div[1]/div[6]/div[2]/a").OuterHtml);


            label1.Text = tarihsecici(duyuru1tarih);
            link1 = linksecici(duyuru1);
            linkLabel1.Text = basliksecici(duyuru1);

            label2.Text = tarihsecici(duyuru2tarih);
            link2 = linksecici(duyuru2);
            linkLabel2.Text = basliksecici(duyuru2);

            label3.Text = tarihsecici(duyuru3tarih);
            link3 = linksecici(duyuru3);
            linkLabel3.Text = basliksecici(duyuru3);

            label4.Text = tarihsecici(duyuru4tarih);
            link4 = linksecici(duyuru4);
            linkLabel4.Text = basliksecici(duyuru4);

            label5.Text = tarihsecici(duyuru5tarih);
            link5 = linksecici(duyuru5);
            linkLabel5.Text = basliksecici(duyuru5);
        }

        private string tarihsecici(string duyurutarih)
        {
            string tarih;

            int baslangic = duyurutarih.IndexOf("<p>") + 3;
            int bitis = duyurutarih.Substring(baslangic).IndexOf("</p>");

            tarih = duyurutarih.Substring(baslangic, bitis).Trim();

            return tarih;
        }

        private string linksecici(string duyuru)
        {
            string link;

            int baslangic = duyuru.IndexOf("href=") + 6;
            int bitis = duyuru.Substring(baslangic).IndexOf("\" title");

            link = "http://ogris.gazi.edu.tr" + duyuru.Substring(baslangic, bitis).Trim().Replace("%27", "'");

            return link;
        }

        private string basliksecici(string duyuru)
        {
            string baslik;

            int baslangic = duyuru.IndexOf("title=") + 7;
            int bitis = duyuru.Substring(baslangic).IndexOf("\">");

            baslik = duyuru.Substring(baslangic, bitis).Trim();

            return baslik;
        }
    }
}

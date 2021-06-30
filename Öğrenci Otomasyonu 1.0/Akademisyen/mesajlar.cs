using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Öğrenci_Otomasyonu_1._0.Akademisyen
{
    public partial class mesajlar : Form
    {
        public mesajlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ana_giris.baglantistring);
        SqlConnection baglanti2 = new SqlConnection(ana_giris.baglantistring);
        SqlConnection baglanti3 = new SqlConnection(ana_giris.baglantistring);
        List<string> alicilistesi = new List<string>();
        List<int> gelenmesajid = new List<int>();
        List<int> gidenmesajid = new List<int>();
        string gonderen, alan, baslik, mesajj;
        string gonderen2, alan2, baslik2, mesajj2;
        int alici_id;
        private void butonrenk(Button buton)
        {
            buton.BackColor = ThemeColor.PrimaryColor;
            buton.ForeColor = Color.White;
            buton.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
        }
        private void labelrenk()
        {
            foreach (Control lbls in this.panel3.Controls)
            {
                if (lbls.GetType() == typeof(Label))
                {
                    Label lbl = (Label)lbls;
                    lbls.ForeColor = ThemeColor.SecondaryColor;
                }
            }
            foreach (Control lbls in this.panel4.Controls)
            {
                if (lbls.GetType() == typeof(Label))
                {
                    Label lbl = (Label)lbls;
                    lbls.ForeColor = ThemeColor.SecondaryColor;
                }
            }
            foreach (Control lbls in this.panel5.Controls)
            {
                if (lbls.GetType() == typeof(Label))
                {
                    Label lbl = (Label)lbls;
                    lbls.ForeColor = ThemeColor.SecondaryColor;
                }
            }
            foreach (Control lbls in this.metroTabPage3.Controls)
            {
                if (lbls.GetType() == typeof(Label))
                {
                    Label lbl = (Label)lbls;
                    lbls.ForeColor = ThemeColor.SecondaryColor;
                }
            }
        }
        private void tablorenk(DataGridView dataGridView1)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
                else
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            }
        }

        private void listerenk(ListView liste)
        {
            liste.ForeColor = Color.White;
            for (int i = 0; i < liste.Items.Count; i++)
            {
                if (i % 2 == 0)
                    liste.Items[i].BackColor = ThemeColor.PrimaryColor;
                else
                    liste.Items[i].BackColor = ThemeColor.SecondaryColor;
            }
        }

        //mesaj gönderme

        private void alicilistele()
        {
            alicilistesi.Clear();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ogrenci_no, ogrenci_ad_soyad from ogrenci_bilgi", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                alicilistesi.Add(oku["ogrenci_ad_soyad"].ToString() + "-" + oku["ogrenci_no"].ToString());
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select akademisyen_ad_soyad, akademisyen_no from akademisyen_bilgi", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                alicilistesi.Add(oku2["akademisyen_ad_soyad"].ToString() + "-" + oku2["akademisyen_no"].ToString());
            }
            baglanti.Close();

            for (int i = 0; i < alicilistesi.Count; i++)
            {
                listView1_alici.Items.Add(alicilistesi[i]);
            }

            listerenk(listView1_alici);
        }

        private void mesajlar_Load(object sender, EventArgs e)
        {
            labelrenk();
            butonrenk(button_mesajgonder);
            gelenkutusu();
            gidenkutusu();
            alicilistele();

        }

        private void button_mesajgonder_Click(object sender, EventArgs e)
        {
            if (listView1_alici.SelectedItems.Count == 1 && textBox1_mesaj_konu.Text != "" && richTextBox1_mesaj_mesaj.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into mesaj(gonderen_id, alici_id, mesaj_baslik, mesaj) values (@gonderen, @alici, @baslik, @icerik)", baglanti);
                komut.Parameters.AddWithValue("@gonderen", akdmsyn_giris.akademisyen_no);
                komut.Parameters.AddWithValue("@alici", alici_id);
                komut.Parameters.AddWithValue("@baslik", textBox1_mesaj_konu.Text);
                komut.Parameters.AddWithValue("@icerik", richTextBox1_mesaj_mesaj.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Mesaj Gönderildi");
            }
            else
            {
                MessageBox.Show("Bir alıcı seçin ve gerekli alanları doldurun!");
            }
        }

        private void listView1_alici_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listView1_alici.SelectedItems.Count > 0)
            {
                ListViewItem items = new ListViewItem();
                items = listView1_alici.SelectedItems[0];
                string kelime = items.SubItems[0].ToString();
                alici_id = Convert.ToInt32(kelime.Substring(kelime.Length - 11, 9));
            }

        }



        private void textBox_alici_TextChanged(object sender, EventArgs e)
        {
            if (textBox_alici.Text == "")
            {
                listView1_alici.Clear();
                alicilistele();
            }
            else
            {
                List<ListViewItem> sonuclar = new List<ListViewItem>();

                foreach (ListViewItem satir in listView1_alici.Items)
                {

                    string kelime = satir.SubItems[0].ToString();
                    kelime = kelime.Substring(18, kelime.Length - 20);

                    if (kelime.StartsWith(textBox_alici.Text))
                    {
                        sonuclar.Add(satir);
                    }

                }

                listView1_alici.Clear();

                foreach (ListViewItem item in sonuclar)
                {
                    string kelime = item.SubItems[0].ToString();
                    kelime = kelime.Substring(18, kelime.Length - 19);
                    listView1_alici.Items.Add(kelime);
                }
                listerenk(listView1_alici);
            }
        }

        



        //gelen mesajları listeleme

        private void gelenkutusu()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from mesaj where alici_id=@no1 order by ID desc", baglanti);
            komut.Parameters.AddWithValue("@no1", akdmsyn_giris.akademisyen_no);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                gelenmesajid.Add(Convert.ToInt32(oku["ID"]));
                dataGridView1.Rows.Add( isimbulma(Convert.ToInt32(oku["gonderen_id"])) +"\n" + oku["mesaj_baslik"].ToString());
                
            }
            baglanti.Close();
            tablorenk(dataGridView1);
        }


        private string isimbulma(int no)
        {
            string ad="";

            baglanti2.Open();
            SqlCommand komut = new SqlCommand("select ogrenci_ad_soyad from ogrenci_bilgi where ogrenci_no=@ogrno", baglanti2);
            komut.Parameters.AddWithValue("@ogrno", no);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ad = oku["ogrenci_ad_soyad"].ToString();
            }
            baglanti2.Close();

            baglanti2.Open();
            SqlCommand komut2 = new SqlCommand("select akademisyen_ad_soyad from akademisyen_bilgi where akademisyen_no=@akno", baglanti2);
            komut2.Parameters.AddWithValue("@akno", no);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ad = oku2["akademisyen_ad_soyad"].ToString();
            }
            baglanti2.Close();

            return ad;
        }

        private int bilgicekme(int info)
        {
            int id = 0;

            baglanti3.Open();
            SqlCommand komut = new SqlCommand("select * from mesaj where ID=@id1", baglanti3);
            komut.Parameters.AddWithValue("@id1", info);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                gonderen = isimbulma(Convert.ToInt32(oku["gonderen_id"]));
                alan = isimbulma(Convert.ToInt32(oku["alici_id"]));
                baslik = oku["mesaj_baslik"].ToString();
                mesajj = oku["mesaj"].ToString();
            }
            baglanti3.Close();
            return id;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int a = dataGridView1.SelectedRows[0].Index;
                bilgicekme(gelenmesajid[a]);
                gonderen_isim_mesajlar.Text = gonderen;
                alici_isim_gelenmesajlar.Text = alan;
                konu_gelenmesajlar.Text = baslik;
                richTextBox1.Text = mesajj;

            }
        }


        //gönderilen mesajlar

        private void gidenkutusu()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from mesaj where gonderen_id=@no1 order by ID desc", baglanti);
            komut.Parameters.AddWithValue("@no1", akdmsyn_giris.akademisyen_no);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                gidenmesajid.Add(Convert.ToInt32(oku["ID"]));
                dataGridView2.Rows.Add(isimbulma(Convert.ToInt32(oku["gonderen_id"])) + "\n" + oku["mesaj_baslik"].ToString());

            }
            baglanti.Close();
            tablorenk(dataGridView2);
        }

        private int bilgicekme2(int info)
        {
            int id = 0;

            baglanti3.Open();
            SqlCommand komut = new SqlCommand("select * from mesaj where ID=@id1", baglanti3);
            komut.Parameters.AddWithValue("@id1", info);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                gonderen2 = isimbulma(Convert.ToInt32(oku["gonderen_id"]));
                alan2 = isimbulma(Convert.ToInt32(oku["alici_id"]));
                baslik2 = oku["mesaj_baslik"].ToString();
                mesajj2 = oku["mesaj"].ToString();
            }
            baglanti3.Close();
            return id;
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int a = dataGridView2.SelectedRows[0].Index;
                bilgicekme2(gidenmesajid[a]);
                gonderen_isim_gonderlien_mesajlar.Text = gonderen2;
                alici_isim_gonderlien.Text = alan2;
                konu_gonderilen.Text = baslik2;
                mesaj_gonderilen.Text = mesajj2;
                
            }
        }


    }
}

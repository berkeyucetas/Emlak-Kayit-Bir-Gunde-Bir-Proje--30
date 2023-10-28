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

namespace Emlak_Kayıt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-LQE0JO3;Initial Catalog=emlak;Integrated Security=True");
        private void veriGöstter()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from bilgiler", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = oku["ID"].ToString();
                add.SubItems.Add(oku["site"].ToString());
                add.SubItems.Add(oku["blok"].ToString());
                add.SubItems.Add(oku["daire"].ToString());
                add.SubItems.Add(oku["esya"].ToString());
                add.SubItems.Add(oku["kat"].ToString());
                add.SubItems.Add(oku["metrekare"].ToString());
                add.SubItems.Add(oku["oda"].ToString());
                add.SubItems.Add(oku["satkira"].ToString());
                add.SubItems.Add(oku["fiyat"].ToString());
                add.SubItems.Add(oku["adsoyad"].ToString());
                add.SubItems.Add(oku["telefon"].ToString());
                add.SubItems.Add(oku["aciklama"].ToString());
                listView1.Items.Add(add);
            }
            baglanti.Close();
        }
        private void comboSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboSite.Text == "1BB SİTESİ")
            {
                group1bbSitesi.BackColor = Color.HotPink;
                group2bbSitesi.BackColor = Color.Peru;
                group3bbSitesi.BackColor = Color.Peru;
                group4bbSitesi.BackColor = Color.Peru;
                if (comboBlok.Text == "A BLOK")
                {
                    btn1bbA.BackColor = Color.Black;
                    btn1bbA.ForeColor = Color.Lime;
                }
                else if (comboBlok.Text == "B BLOK")
                {
                    btn1bbB.BackColor = Color.Black;
                    btn1bbB.ForeColor = Color.Lime;
                }
                else if (comboBlok.Text == "C BLOK")
                {
                    btn1bbC.BackColor = Color.Black;
                    btn1bbC.ForeColor = Color.Lime;
                }
                else if (comboBlok.Text == "D BLOK")
                {
                    btn1bbD.BackColor = Color.Black;
                    btn1bbD.ForeColor = Color.Lime;
                }
            }
            else if (comboSite.Text == "2BB SİTESİ")
            {
                group2bbSitesi.BackColor = Color.HotPink;
                group1bbSitesi.BackColor = Color.Peru;
                group3bbSitesi.BackColor = Color.Peru;
                group4bbSitesi.BackColor = Color.Peru;
            }
            else if (comboSite.Text == "3BB SİTESİ")
            {
                group3bbSitesi.BackColor = Color.HotPink;
                group2bbSitesi.BackColor = Color.Peru;
                group1bbSitesi.BackColor = Color.Peru;
                group4bbSitesi.BackColor = Color.Peru;
            }
            else if (comboSite.Text == "4BB SİTESİ")
            {
                group4bbSitesi.BackColor = Color.HotPink;
                group2bbSitesi.BackColor = Color.Peru;
                group3bbSitesi.BackColor = Color.Peru;
                group1bbSitesi.BackColor = Color.Peru;
            }
        }

        private void comboBlok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSite.Text == "1BB SİTESİ")
            {
                if (comboBlok.Text == "A BLOK")
                {
                    btn1bbA.BackColor = Color.Lime;
                    btn1bbA.ForeColor = Color.Black;
                    btn1bbB.BackColor= Color.White;
                    btn1bbC.BackColor= Color.White;
                    btn1bbD.BackColor= Color.White;
                }
                else if (comboBlok.Text == "B BLOK")
                {
                    btn1bbB.BackColor = Color.Lime;
                    btn1bbB.ForeColor = Color.Black;
                    btn1bbA.BackColor = Color.White;
                    btn1bbC.BackColor = Color.White;
                    btn1bbD.BackColor = Color.White;
                }
                else if (comboBlok.Text == "C BLOK")
                {
                    btn1bbC.BackColor = Color.Lime;
                    btn1bbC.ForeColor = Color.Black;
                    btn1bbB.BackColor = Color.White;
                    btn1bbA.BackColor = Color.White;
                    btn1bbD.BackColor = Color.White;
                }
                else if (comboBlok.Text == "D BLOK")
                {
                    btn1bbD.BackColor = Color.Lime;
                    btn1bbD.ForeColor = Color.Black;
                    btn1bbB.BackColor = Color.White;
                    btn1bbC.BackColor = Color.White;
                    btn1bbA.BackColor = Color.White;
                }
            }
            else if (comboSite.Text == "2BB SİTESİ")
            {
                if (comboBlok.Text == "A BLOK")
                {
                    btn2bbA.BackColor = Color.Lime;
                    btn2bbA.ForeColor = Color.Black;
                    btn2bbB.BackColor = Color.White;
                    btn2bbC.BackColor = Color.White;
                    btn2bbD.BackColor = Color.White;
                }
                else if (comboBlok.Text == "B BLOK")
                {
                    btn2bbB.BackColor = Color.Lime;
                    btn2bbB.ForeColor = Color.Black;
                    btn2bbA.BackColor = Color.White;
                    btn2bbC.BackColor = Color.White;
                    btn2bbD.BackColor = Color.White;
                }
                else if (comboBlok.Text == "C BLOK")
                {
                    btn2bbC.BackColor = Color.Lime;
                    btn2bbC.ForeColor = Color.Black;
                    btn2bbB.BackColor = Color.White;
                    btn2bbA.BackColor = Color.White;
                    btn2bbD.BackColor = Color.White;
                }
                else if (comboBlok.Text == "D BLOK")
                {
                    btn2bbD.BackColor = Color.Lime;
                    btn2bbD.ForeColor = Color.Black;
                    btn2bbB.BackColor = Color.White;
                    btn2bbC.BackColor = Color.White;
                    btn2bbA.BackColor = Color.White;
                }
            }
            else if (comboSite.Text == "3BB SİTESİ")
            {
                if (comboBlok.Text == "A BLOK")
                {
                    btn3bbA.BackColor = Color.Lime;
                    btn3bbA.ForeColor = Color.Black;
                    btn3bbB.BackColor = Color.White;
                    btn3bbC.BackColor = Color.White;
                    btn3bbD.BackColor = Color.White;
                }
                else if (comboBlok.Text == "B BLOK")
                {
                    btn3bbB.BackColor = Color.Lime;
                    btn3bbB.ForeColor = Color.Black;
                    btn3bbA.BackColor = Color.White;
                    btn3bbC.BackColor = Color.White;
                    btn3bbD.BackColor = Color.White;
                }
                else if (comboBlok.Text == "C BLOK")
                {
                    btn3bbC.BackColor = Color.Lime;
                    btn3bbC.ForeColor = Color.Black;
                    btn3bbB.BackColor = Color.White;
                    btn3bbA.BackColor = Color.White;
                    btn3bbD.BackColor = Color.White;
                }
                else if (comboBlok.Text == "D BLOK")
                {
                    btn3bbD.BackColor = Color.Lime;
                    btn3bbD.ForeColor = Color.Black;
                    btn3bbB.BackColor = Color.White;
                    btn3bbC.BackColor = Color.White;
                    btn3bbA.BackColor = Color.White;
                }
            }
            else if (comboSite.Text == "4BB SİTESİ")
            {
                if (comboBlok.Text == "A BLOK")
                {
                    btn4bbA.BackColor = Color.Lime;
                    btn4bbA.ForeColor = Color.Black;
                    btn4bbB.BackColor = Color.White;
                    btn4bbC.BackColor = Color.White;
                    btn4bbD.BackColor = Color.White;
                }
                else if (comboBlok.Text == "B BLOK")
                {
                    btn4bbB.BackColor = Color.Lime;
                    btn4bbB.ForeColor = Color.Black;
                    btn4bbA.BackColor = Color.White;
                    btn4bbC.BackColor = Color.White;
                    btn4bbD.BackColor = Color.White;
                }
                else if (comboBlok.Text == "C BLOK")
                {
                    btn4bbC.BackColor = Color.Lime;
                    btn4bbC.ForeColor = Color.Black;
                    btn4bbB.BackColor = Color.White;
                    btn4bbA.BackColor = Color.White;
                    btn4bbD.BackColor = Color.White;
                }
                else if (comboBlok.Text == "D BLOK")
                {
                    btn4bbD.BackColor = Color.Lime;
                    btn4bbD.ForeColor = Color.Black;
                    btn4bbB.BackColor = Color.White;
                    btn4bbC.BackColor = Color.White;
                    btn4bbA.BackColor = Color.White;
                }
            }
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            veriGöstter();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {            
            string ID =textID.Text;
            string site = comboSite.Text;
            string blok = comboBlok.Text;
            string daire = comboDaire.Text;
            string esya = comboEsya.Text;
            string kat = comboKat.Text;
            string metrekare = comboMetre.Text;          
            string oda = comboOda.Text;
            string satkira = comboSatKira.Text;
            string fiyat = comboFiyat.Text;
            string aciklama = textAcıklama.Text;
            string adsoyad = textAdSoyad.Text;
            string telefon = textTelefon.Text;

            string query = "INSERT INTO bilgiler (ID, site, blok, daire, esya, kat, metrekare, oda, satkira, fiyat, aciklama, adsoyad, telefon ) VALUES (@ID, @site, @blok, @daire, @esya, @kat, @metrekare, @oda, @satkira, @fiyat, @aciklama, @adsoyad, @telefon )";

            baglanti.Open();
            SqlCommand cmd = new SqlCommand(query, baglanti);

            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@site", site);
            cmd.Parameters.AddWithValue("@blok", blok);
            cmd.Parameters.AddWithValue("@daire", daire);
            cmd.Parameters.AddWithValue("@esya", esya);
            cmd.Parameters.AddWithValue("@kat", kat);
            cmd.Parameters.AddWithValue("@metrekare", metrekare);
            cmd.Parameters.AddWithValue("@oda", oda);
            cmd.Parameters.AddWithValue("@satkira", satkira);
            cmd.Parameters.AddWithValue("@fiyat", fiyat);
            cmd.Parameters.AddWithValue("@aciklama", aciklama);
            cmd.Parameters.AddWithValue("@adsoyad", adsoyad);
            cmd.Parameters.AddWithValue("@telefon", telefon);

            cmd.ExecuteNonQuery();

            baglanti.Close();
            veriGöstter();

            textID.Text = "";
            comboSite.Text = "";
            comboBlok.Text = "";
            comboDaire.Text = "";
            comboEsya.Text = "";
            comboKat.Text = "";
            comboMetre.Text = "";
            comboOda.Text = "";
            comboSatKira.Text = "";
            comboFiyat.Text = "";
            textAcıklama.Text = "";
            textAdSoyad.Text = "";
            textTelefon.Text = "";

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string ID = selectedItem.Text;

                baglanti.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM bilgiler WHERE ID=@ID", baglanti);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                listView1.Items.Remove(selectedItem);
                textID.Text = "";
                comboSite.Text = "";
                comboBlok.Text = "";
                comboDaire.Text = "";
                comboEsya.Text = "";
                comboKat.Text = "";
                comboMetre.Text = "";
                comboOda.Text = "";
                comboSatKira.Text = "";
                comboFiyat.Text = "";
                textAcıklama.Text = "";
                textAdSoyad.Text = "";
                textTelefon.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Yere Tıklayın..!");
            }
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string ID = textID.Text;
                string site = comboSite.Text;
                string blok = comboBlok.Text;
                string daire = comboDaire.Text;
                string esya = comboEsya.Text;
                string kat = comboKat.Text;
                string metrekare = comboMetre.Text;
                string oda = comboOda.Text;
                string satkira = comboSatKira.Text;
                string fiyat = comboFiyat.Text;
                string aciklama = textAcıklama.Text;
                string adsoyad = textAdSoyad.Text;
                string telefon = textTelefon.Text;

                baglanti.Open();
                SqlCommand cmd = new SqlCommand("UPDATE bilgiler SET ID=@ID, site=@site, blok=@blok, daire=@daire, esya=@esya, kat=@kat, metrekare=@metrekare, oda=@oda,  satkira=@satkira, fiyat=@fiyat, aciklama=@aciklama, adsoyad=@adsoyad, telefon=@telefon WHERE ID=@selectedID", baglanti);

                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@site", site);
                cmd.Parameters.AddWithValue("@blok", blok);
                cmd.Parameters.AddWithValue("@daire", daire);
                cmd.Parameters.AddWithValue("@esya", esya);
                cmd.Parameters.AddWithValue("@kat", kat);
                cmd.Parameters.AddWithValue("@metrekare", metrekare);
                cmd.Parameters.AddWithValue("@oda", oda);
                cmd.Parameters.AddWithValue("@satkira", satkira);
                cmd.Parameters.AddWithValue("@fiyat", fiyat);
                cmd.Parameters.AddWithValue("@aciklama", aciklama);
                cmd.Parameters.AddWithValue("@adsoyad", adsoyad);
                cmd.Parameters.AddWithValue("@telefon", telefon);

                ListViewItem selectedItem = listView1.SelectedItems[0];
                string selectedID = selectedItem.Text;

                cmd.Parameters.AddWithValue("@selectedID", selectedID);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                veriGöstter();
            }
            else
            {
                MessageBox.Show("Lütfen Güncelleme Yapmak İstediğiniz Yere Tıklayın..!");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            veriGöstter();
        }

        private void textID_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Boş alan bırakmadan doldurunuz..!");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textID.Text = "";
            comboSite.Text = "";
            comboBlok.Text = "";
            comboDaire.Text = "";
            comboEsya.Text = "";
            comboKat.Text = "";
            comboMetre.Text = "";
            comboOda.Text = "";
            comboSatKira.Text = "";
            comboFiyat.Text = "";
            textAcıklama.Text = "";
            textAdSoyad.Text = "";
            textTelefon.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                textID.Text = selectedItem.Text;
                comboSite.Text = selectedItem.SubItems[1].Text;
                comboBlok.Text = selectedItem.SubItems[2].Text;
                comboDaire.Text = selectedItem.SubItems[3].Text;
                comboEsya.Text = selectedItem.SubItems[4].Text;
                comboKat.Text = selectedItem.SubItems[5].Text;
                comboMetre.Text = selectedItem.SubItems[6].Text;
                comboOda.Text = selectedItem.SubItems[7].Text;
                comboSatKira.Text = selectedItem.SubItems[8].Text;
                comboFiyat.Text = selectedItem.SubItems[9].Text;
                textAdSoyad.Text = selectedItem.SubItems[10].Text;
                textTelefon.Text = selectedItem.SubItems[11].Text;
                textAcıklama.Text = selectedItem.SubItems[12].Text;               
                
            }
        }

        private void comboDaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDaire.SelectedIndex == 0) 
            {
                comboKat.SelectedIndex = 0; 
            }
            else if (comboDaire.SelectedIndex == 1) 
            {
                comboKat.SelectedIndex = 0; 
            }
            else if (comboDaire.SelectedIndex == 2) 
            {
                comboKat.SelectedIndex = 0; 
            }
            else if (comboDaire.SelectedIndex == 3)
            {
                comboKat.SelectedIndex = 0;
            }
            if (comboDaire.SelectedIndex == 4)
            {
                comboKat.SelectedIndex = 1;
            }
            else if (comboDaire.SelectedIndex == 5)
            {
                comboKat.SelectedIndex = 1;
            }
            else if (comboDaire.SelectedIndex == 6)
            {
                comboKat.SelectedIndex = 1;
            }
            else if (comboDaire.SelectedIndex == 7)
            {
                comboKat.SelectedIndex = 1;
            }
            if (comboDaire.SelectedIndex == 8)
            {
                comboKat.SelectedIndex = 2;
            }
            else if (comboDaire.SelectedIndex == 9)
            {
                comboKat.SelectedIndex = 2;
            }
            else if (comboDaire.SelectedIndex == 10)
            {
                comboKat.SelectedIndex = 2;
            }
            else if (comboDaire.SelectedIndex == 11)
            {
                comboKat.SelectedIndex = 2;
            }
            if (comboDaire.SelectedIndex == 12)
            {
                comboKat.SelectedIndex = 3;
            }
            else if (comboDaire.SelectedIndex == 13)
            {
                comboKat.SelectedIndex = 3;
            }
            else if (comboDaire.SelectedIndex == 14)
            {
                comboKat.SelectedIndex = 3;
            }
            else if (comboDaire.SelectedIndex == 15)
            {
                comboKat.SelectedIndex = 3;
            }
            if (comboDaire.SelectedIndex == 16)
            {
                comboKat.SelectedIndex = 4;
            }
            else if (comboDaire.SelectedIndex == 17)
            {
                comboKat.SelectedIndex = 4;
            }
            else if (comboDaire.SelectedIndex == 18)
            {
                comboKat.SelectedIndex = 4;
            }
            else if (comboDaire.SelectedIndex == 19)
            {
                comboKat.SelectedIndex = 4;
            }
            if (comboDaire.SelectedIndex == 20)
            {
                comboKat.SelectedIndex = 5;
            }
            else if (comboDaire.SelectedIndex == 21)
            {
                comboKat.SelectedIndex = 5;
            }
            else if (comboDaire.SelectedIndex == 22)
            {
                comboKat.SelectedIndex = 5;
            }
            else if (comboDaire.SelectedIndex == 23)
            {
                comboKat.SelectedIndex = 5;
            }
            if (comboDaire.SelectedIndex == 24)
            {
                comboKat.SelectedIndex = 6;
            }
            else if (comboDaire.SelectedIndex == 25)
            {
                comboKat.SelectedIndex = 6;
            }
            else if (comboDaire.SelectedIndex == 26)
            {
                comboKat.SelectedIndex = 6;
            }
            else if (comboDaire.SelectedIndex == 27)
            {
                comboKat.SelectedIndex = 6;
            }
            if (comboDaire.SelectedIndex == 28)
            {
                comboKat.SelectedIndex = 7;
            }
            else if (comboDaire.SelectedIndex == 29)
            {
                comboKat.SelectedIndex = 7;
            }
            else if (comboDaire.SelectedIndex == 30)
            {
                comboKat.SelectedIndex = 7;
            }
            else if (comboDaire.SelectedIndex == 31)
            {
                comboKat.SelectedIndex = 7;
            }
            if (comboDaire.SelectedIndex == 32)
            {
                comboKat.SelectedIndex = 8;
            }
            else if (comboDaire.SelectedIndex == 33)
            {
                comboKat.SelectedIndex = 8;
            }
            else if (comboDaire.SelectedIndex == 34)
            {
                comboKat.SelectedIndex = 8;
            }
            else if (comboDaire.SelectedIndex == 35)
            {
                comboKat.SelectedIndex = 8;
            }
            if (comboDaire.SelectedIndex == 36)
            {
                comboKat.SelectedIndex = 9;
            }
            else if (comboDaire.SelectedIndex == 37)
            {
                comboKat.SelectedIndex = 9;
            }
            else if (comboDaire.SelectedIndex == 38)
            {
                comboKat.SelectedIndex = 9;
            }
            else if (comboDaire.SelectedIndex == 39)
            {
                comboKat.SelectedIndex = 9;
            }
            if (comboDaire.SelectedIndex == 40)
            {
                comboKat.SelectedIndex = 10;
            }
            else if (comboDaire.SelectedIndex == 41)
            {
                comboKat.SelectedIndex = 10;
            }
            else if (comboDaire.SelectedIndex == 42)
            {
                comboKat.SelectedIndex = 10;
            }
            else if (comboDaire.SelectedIndex == 43)
            {
                comboKat.SelectedIndex = 10;
            }
            if (comboDaire.SelectedIndex == 44)
            {
                comboKat.SelectedIndex = 11;
            }
            else if (comboDaire.SelectedIndex == 45)
            {
                comboKat.SelectedIndex = 11;
            }
            else if (comboDaire.SelectedIndex == 46)
            {
                comboKat.SelectedIndex = 11;
            }
            else if (comboDaire.SelectedIndex == 47)
            {
                comboKat.SelectedIndex = 11;
            }
            if (comboDaire.SelectedIndex == 48)
            {
                comboKat.SelectedIndex = 12;
            }
            else if (comboDaire.SelectedIndex == 49)
            {
                comboKat.SelectedIndex = 12;
            }
            else if (comboDaire.SelectedIndex == 50)
            {
                comboKat.SelectedIndex = 12;
            }
            else if (comboDaire.SelectedIndex == 51)
            {
                comboKat.SelectedIndex = 12;
            }
        }
    }
}

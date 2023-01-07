using BLL;
using MetroFramework;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS
{
    public partial class Giris : MetroFramework.Forms.MetroForm
    {
        public Giris()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManagerGiris;
        }

        AnaForm anaform = new AnaForm();
        GirisBL grs = new GirisBL();
        private void Giris_Load(object sender, EventArgs e)
        {
            label_yetki_no.Visible = false;
            label_sifre.Visible = false;
            text_yetki_no.Visible = false;
            text_sifre.Visible = false;
            combobox_yetkiler.SelectedItem = "Yönetici";
        }

       

        private void combobox_yetkiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_yetki_no.Visible = true;
            label_sifre.Visible = true;
            text_yetki_no.Visible = true;
            text_sifre.Visible = true;

            if (combobox_yetkiler.SelectedItem=="Yönetici")
            {
                label_yetki_no.Text = "Kullanıcı Adı :";
            }
            else if(combobox_yetkiler.SelectedItem== "Öğretim Elemanı")
            {
                label_yetki_no.Text = "Sicil No :";
            }
            else if(combobox_yetkiler.SelectedItem == "Öğrenci")
            {
                label_yetki_no.Text = "Öğrenci No :";
            }
        }
       

        private void button_giris_Click(object sender, EventArgs e)
        {

            if (combobox_yetkiler.SelectedItem == "Yönetici" && text_yetki_no.Text == "admin" && text_sifre.Text == "123456789")
            {
                this.Hide();
                anaform.Show();
            }
            else if (combobox_yetkiler.SelectedItem == "Öğretim Elemanı")
            {
                try
                {

                    GirisBL gbl = new GirisBL();
                    OgretimElemanlariModel om = gbl.OgretimElemaniGiris(Convert.ToInt32(text_yetki_no.Text), Convert.ToString(text_sifre.Text));
                    if (om == null)
                    {
                        MetroMessageBox.Show(this, "Lütfen bilgilerinizi kontrol ediniz !", "Giriş Hatalı !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult r = MetroMessageBox.Show(this, "Bilgileriniz doğru sisteme yönlendiriliyorsunuz...", "Giriş Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (r ==DialogResult.OK)
                        {
                            this.Hide();
                            anaform.Show();
                        }
                       
                    }
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("Hatas");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Hata");
                }

            }            
            else if (combobox_yetkiler.SelectedItem == "Öğrenci")
            {
                try
                {

                    GirisBL gbl = new GirisBL();
                    OgrencilerModel om = gbl.OgrenciGiris(Convert.ToInt32(text_yetki_no.Text), Convert.ToString(text_sifre.Text));
                    if (om == null)
                    {
                        MessageBox.Show("Böyle Bir Kayıt Bulunamadı");
                    }
                    else
                    {
                        this.Hide();
                        anaform.Show();
                    }
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("Hatas");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Hata");
                }
            }

        }
    }
}

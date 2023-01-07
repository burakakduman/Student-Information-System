using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS
{
    public partial class Splash : MetroFramework.Forms.MetroForm
    {
        public Splash()
        {
           
            InitializeComponent();
        }
        int zaman = 6;
        private void Splash_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManagerSplash;
            timer_splash.Enabled = true;
            
        }

        private void timer_splash_Tick(object sender, EventArgs e)
        {
            zaman--;
            if (zaman == 6)
            {
                label_ozellikler.Text = "Öğrenciler yükleniyor...";
            }
            else if (zaman == 5)
            {
                label_ozellikler.Text = "Akademik Birimler yükleniyor...";
            }
            else if (zaman == 4)
            {
                label_ozellikler.Text = "Bölümler yükleniyor...";
            }
            else if (zaman == 3)
            {
                label_ozellikler.Text = "Öğrenci Verileri yükleniyor...";
            }
            else if (zaman == 2)
            {
                label_ozellikler.Text = "Öğretim Elemanları yükleniyor...";
            }
            else if (zaman == 1)
            {
                this.Hide();
                Giris frm = new Giris();
                frm.ShowDialog();
                timer_splash.Enabled = false;
            }
        }
    }
}

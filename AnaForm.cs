using BLL;
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
    public partial class AnaForm : MetroFramework.Forms.MetroForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        DataTable dt = null;
        

        private void AnaForm_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManagerAnaForm;
            AkademikBirimlerGridYukle();
            BolumlerGridYukle();
            DonemlerGridYukle();
            OgrencilerGridYukle();
            OgretimElemanlariGridYukle();
            OgretimElemanlariDerslerGridYukle();
            OgrenciDerslerGridYukle();
            grid_akademik_birimler.AutoGenerateColumns = false;
            grid_akademik_bolumler.AutoGenerateColumns = false;
            grid_akademik_donemler.AutoGenerateColumns = false;
            grid_akademik_ogrenciler.AutoGenerateColumns = false;
            grid_akademik_ogrenciler_dersler.AutoGenerateColumns = false;
            grid_akademik_ogretim_elemanlari.AutoGenerateColumns = false;
            grid_akademik_ogretim_elemanlari_dersler.AutoGenerateColumns = false;
            BirimListeDoldur();
            OgrenciBirimListeDoldur();
            OgretimElemaniBirimListeDoldur();
            OgrenciDersDonemListeDoldur();

        }
        #region Akademik Birimler-Birim Islemleri
        int akademikbirimid;
        int akademikbirimid2;
        string akademikbirimadi;
        
        void AkademikBirimlerGridYukle()
        {
            try
            {
                AkademikBirimlerBL abbl = new AkademikBirimlerBL();
                dt = abbl.AkademikBirimlerTablosuGetir();
                grid_akademik_birimler.DataSource = dt;
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                AkademikBirimlerModel abm = new AkademikBirimlerModel { Ad = text_birim_adi.Text.Trim() };
                AkademikBirimlerBL abbl = new AkademikBirimlerBL();
                abbl.AkademikBirimEkle(abm);
                AkademikBirimlerGridYukle();
                BirimListeDoldur();
                OgrenciBirimListeDoldur();
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }
           

        }
        private void button_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                AkademikBirimlerModel abm = new AkademikBirimlerModel { AkademikBirimID = akademikbirimid, Ad = text_birim_adi.Text.Trim() };
                AkademikBirimlerBL abbl = new AkademikBirimlerBL();

                abbl.AkademikBirimGuncelle(abm);
                text_birim_adi.Text = String.Empty;
                AkademikBirimlerGridYukle();
                BirimListeDoldur();
                OgrenciBirimListeDoldur();
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            try
            {
                AkademikBirimlerModel abm = new AkademikBirimlerModel { Ad = akademikbirimadi };
                AkademikBirimlerBL abbl = new AkademikBirimlerBL();
                abbl.AkademikBirimSil(abm);
                AkademikBirimlerGridYukle();
                BirimListeDoldur();
                OgrenciBirimListeDoldur();
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }
            
        }

       

        private void grid_akademik_birimler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                akademikbirimid = Convert.ToInt32(grid_akademik_birimler.CurrentRow.Cells["ID"].Value);
                akademikbirimadi = grid_akademik_birimler.CurrentRow.Cells["Ad"].Value.ToString();
                text_birim_adi.Text = akademikbirimadi;
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        #endregion 

        #region Akademik Birimler-Bolum Islemleri
        int bolumid;
        string bolumad;
        void BirimListeDoldur()
        {
            BolumlerBL bbl = new BolumlerBL();//SinifBL sınıfından sb adında yeni bir nesne türetildi.
            combo_akademik_birim.DisplayMember = "Ad";//Combobox üzerinde görünecek olan alan berlirlendi.
            combo_akademik_birim.ValueMember = "AkademikBirimID";//Combobox üzerinde görünen alanın arka planda alacağı değerin alanı belirlendi.
            combo_akademik_birim.DataSource = bbl.BirimListesiDoldur();//Data Source olarak SinifListesiDoldur metodu çağırıldı.
        }
        void BolumlerGridYukle()
        {
            try
            {
                BolumlerBL bbl = new BolumlerBL();
                dt = bbl.BolumlerTablosuGetir();
                grid_akademik_bolumler.DataSource = dt;
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }

        }
       

        private void button_bolum_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                BolumlerModel bm = new BolumlerModel {BolumID=bolumid, BolumAd = text_bolum_adi.Text.Trim().ToString() ,AkademikBirimID=Convert.ToInt32( combo_akademik_birim.SelectedIndex+1) };
                BolumlerBL bbl = new BolumlerBL();
                bbl.BolumEkle(bm);
                BolumlerGridYukle();
                BirimListeDoldur();
                OgrenciBirimListeDoldur();
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button_bolum_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                BolumlerModel bm = new BolumlerModel {BolumID=bolumid, BolumAd = text_bolum_adi.Text.Trim().ToString(), AkademikBirimID = Convert.ToInt32(combo_akademik_birim.SelectedIndex+1) };
                BolumlerBL bbl = new BolumlerBL();
                bbl.BolumGuncelle(bm);
                text_bolum_adi.Text = String.Empty;
                BolumlerGridYukle();
                BirimListeDoldur();
                OgrenciBirimListeDoldur();
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void button_bolum_sil_Click(object sender, EventArgs e)
        {
            try
            {
                BolumlerModel bm = new BolumlerModel { BolumID=bolumid };
                BolumlerBL bbl = new BolumlerBL();
                bbl.BolumSil(bm);
                BolumlerGridYukle();
                BirimListeDoldur();
                OgrenciBirimListeDoldur();
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void grid_akademik_bolumler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                bolumid = Convert.ToInt32(grid_akademik_bolumler.CurrentRow.Cells["Bid"].Value);
                bolumad = grid_akademik_bolumler.CurrentRow.Cells["BolumAd"].Value.ToString();
                text_bolum_adi.Text = bolumad;
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Akademik Birimler-Donem Islemleri
        int donemno;
        string donemid;
        string donemad;
        void DonemlerGridYukle()
        {
            try
            {
                DonemlerBL dbl = new DonemlerBL();
                dt = dbl.DonemlerTablosuGetir();
                grid_akademik_donemler.DataSource = dt;
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button_donem_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                DonemlerModel dm = new DonemlerModel { DonemID = text_donem_no.Text.Trim().ToString() ,DonemAd = text_donem_ad.Text.Trim().ToString() };
                DonemlerBL dbl = new DonemlerBL();
                dbl.DonemEkle(dm);
                DonemlerGridYukle();
                BirimListeDoldur();
                OgrenciBirimListeDoldur();
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button_donem_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                DonemlerModel dm = new DonemlerModel { DonemNo = donemno, DonemID = text_donem_no.Text, DonemAd = text_donem_ad.Text };
                DonemlerBL dbl = new DonemlerBL();
                dbl.DonemGuncelle(dm);
                text_donem_no.Text = String.Empty;
                text_donem_ad.Text = String.Empty;
                
                DonemlerGridYukle();
                BirimListeDoldur();
                OgrenciBirimListeDoldur();
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button_donem_sil_Click(object sender, EventArgs e)
        {
            try
            {
                DonemlerModel bm = new DonemlerModel {DonemNo=donemno};
                DonemlerBL dbl = new DonemlerBL();
                dbl.BolumSil(bm);
                DonemlerGridYukle();
                BirimListeDoldur();
                OgrenciBirimListeDoldur();
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void grid_akademik_donemler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                donemno = Convert.ToInt32(grid_akademik_donemler.CurrentRow.Cells["DonemNo"].Value);
              
                donemid = grid_akademik_donemler.CurrentRow.Cells["DonemID"].Value.ToString();
           
                donemad = grid_akademik_donemler.CurrentRow.Cells["DonemAd"].Value.ToString();
              
                text_donem_ad.Text = donemad;
                text_donem_no.Text = donemid;
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Akademik Birimler-Ogrenci Islemleri-Kayıtlar

        int ogrid;
        void OgrencilerGridYukle()
        {
            try
            {
                OgrencilerBL obl = new OgrencilerBL();
                dt = obl.OgrencilerTablosuGetir();
                grid_akademik_ogrenciler.DataSource = dt;
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }

        }
        private void button_ogrenci_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                OgrencilerModel om = new OgrencilerModel { No = Convert.ToInt32(text_ogrenci_no.Text.Trim()), Ad = text_ogrenci_adi.Text.Trim().ToString(), Soyad = text_ogrenci_soyadi.Text.Trim().ToString(),BolumID=Convert.ToInt32(combo_akademik_ogrenci_bolum.SelectedValue) ,Sifre=text_ogrenci_sifre.Text.Trim().ToString()};
                OgrencilerBL obl = new OgrencilerBL();
                obl.OgrenciEkle(om);
                OgrencilerGridYukle();
                BirimListeDoldur();
                OgrenciBirimListeDoldur();
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button_ogrenci_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                OgrencilerModel om = new OgrencilerModel { OgrID=ogrid,No=Convert.ToInt32(text_ogrenci_no.Text.Trim()),Ad=text_ogrenci_adi.Text.Trim().ToString(),Soyad=text_ogrenci_soyadi.Text.Trim().ToString(),BolumID=Convert.ToInt32(combo_akademik_ogrenci_bolum.SelectedValue) ,Sifre=text_ogrenci_sifre.Text.Trim().ToString()};
                OgrencilerBL obl = new OgrencilerBL();
                obl.OgrenciGuncelle(om);
                text_ogrenci_no.Text = String.Empty;
                text_ogrenci_adi.Text = String.Empty;
                text_ogrenci_soyadi.Text = String.Empty;
                text_ogrenci_sifre.Text = String.Empty;

                OgrencilerGridYukle();
                BirimListeDoldur();
                OgrenciBirimListeDoldur();
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button_ogrenci_sil_Click(object sender, EventArgs e)
        {
            try
            {
                OgrencilerModel om = new OgrencilerModel { OgrID=ogrid};
                OgrencilerBL obl = new OgrencilerBL();
                obl.OgrenciSil(om);
                OgrencilerGridYukle();
                BirimListeDoldur();
                OgrenciBirimListeDoldur();
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void grid_akademik_ogrenciler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
        void OgrenciBirimListeDoldur()
        {
            OgrencilerBL obl = new OgrencilerBL();//SinifBL sınıfından sb adında yeni bir nesne türetildi.
            combo_akademik_ogrenci_birim.DisplayMember = "Ad";//Combobox üzerinde görünecek olan alan berlirlendi.
            combo_akademik_ogrenci_birim.ValueMember = "AkademikBirimID";//Combobox üzerinde görünen alanın arka planda alacağı değerin alanı belirlendi.
            combo_akademik_ogrenci_birim.DataSource = obl.BirimListesiDoldur();//Data Source olarak SinifListesiDoldur metodu çağırıldı.
        }
        private void combo_akademik_ogrenci_birim_SelectedIndexChanged(object sender, EventArgs e)
        {
            BolumlerModel bm = new BolumlerModel { AkademikBirimID = Convert.ToInt32(combo_akademik_ogrenci_birim.SelectedValue) };
            OgrencilerBL obl = new OgrencilerBL();//SinifBL sınıfından sb adında yeni bir nesne türetildi.
            combo_akademik_ogrenci_bolum.DisplayMember = "BolumAd";//Combobox üzerinde görünecek olan alan berlirlendi.
            combo_akademik_ogrenci_bolum.ValueMember = "BolumID";//Combobox üzerinde görünen alanın arka planda alacağı değerin alanı belirlendi.
            combo_akademik_ogrenci_bolum.DataSource = obl.BolumListesiDoldur(bm);//Data Source olarak SinifListesiDoldur metodu çağırıldı.
        }

        private void grid_akademik_ogrenciler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ogrid = Convert.ToInt32(grid_akademik_ogrenciler.CurrentRow.Cells["OgrID"].Value);
        }

        #endregion
        #region Akademik Birimler-Ogrenci Islemleri-Dersler
        void OgrenciDerslerGridYukle()
        {
            try
            {
                DerslerBL dbl = new DerslerBL();
                dt = dbl.DerslerTablosuGetir();
                grid_akademik_ogrenciler_dersler.DataSource = dt;
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }

        }
        void OgrenciDersDonemListeDoldur()
        {
            DerslerBL dbl = new DerslerBL();//SinifBL sınıfından sb adında yeni bir nesne türetildi.
            combo_ogrenci_ders_donem.DisplayMember = "DonemID"+ "DonemAd";//Combobox üzerinde görünecek olan alan berlirlendi.
            combo_ogrenci_ders_donem.ValueMember = "DonemAd";//Combobox üzerinde görünen alanın arka planda alacağı değerin alanı belirlendi.
            combo_ogrenci_ders_donem.DataSource = dbl.DonemListesiDoldur();//Data Source olarak SinifListesiDoldur metodu çağırıldı.
        }

        #endregion


        #region Akademik Birimler-Ogretim Elemani Islemleri-Kayıt
        int oeid;
        void OgretimElemanlariGridYukle()
        {
            try
            {
                OgretimElemanlariBL oebl = new OgretimElemanlariBL();
                dt = oebl.OgretimElemanlariTablosuGetir();
                grid_akademik_ogretim_elemanlari.DataSource = dt;
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }

        }
        private void button_ogretim_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                OgretimElemanlariModel oem = new OgretimElemanlariModel { Adi=text_ogretim_adi.Text.Trim().ToString(),Soyad=text_ogretim_soyadi.Text.Trim().ToString(),TC=Convert.ToInt32(text_ogretim_tc.Text.Trim()),BolumID=Convert.ToInt32(combo_ogretim_bolum.SelectedValue),SicilNo=Convert.ToInt32(text_ogretim_sicil.Text),Sifre=text_ogretim_sifre.Text.Trim().ToString()};
                OgretimElemanlariBL oebl = new OgretimElemanlariBL();
                oebl.OgretimElemaniEkle(oem);
                OgretimElemanlariGridYukle();
                BirimListeDoldur();
                OgrenciBirimListeDoldur();
                text_ogretim_adi.Text = String.Empty;
                text_ogretim_soyadi.Text = String.Empty;
                text_ogretim_tc.Text = String.Empty;
                text_ogretim_sicil.Text = String.Empty;
                text_ogretim_sifre.Text = String.Empty;
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button_ogretim_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                OgretimElemanlariModel oem = new OgretimElemanlariModel {OEID=oeid, Adi=text_ogretim_adi.Text.Trim().ToString(),Soyad=text_ogretim_soyadi.Text.Trim().ToString(),TC=Convert.ToInt32(text_ogretim_tc.Text.Trim().ToString()),BolumID=Convert.ToInt32(combo_ogretim_bolum.SelectedValue),SicilNo=Convert.ToInt32(text_ogretim_sicil.Text.Trim()),Sifre=text_ogretim_sifre.Text.Trim().ToString()};
                OgretimElemanlariBL oebl = new OgretimElemanlariBL();
                oebl.OgretimElemaniGuncelle(oem);
                text_ogretim_adi.Text = String.Empty;
                text_ogretim_soyadi.Text = String.Empty;
                text_ogretim_tc.Text = String.Empty;
                text_ogretim_sicil.Text = String.Empty;
                text_ogretim_sifre.Text = String.Empty;
                OgretimElemanlariGridYukle();
                OgrencilerGridYukle();
                BirimListeDoldur();
                OgrenciBirimListeDoldur();
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button_ogretim_sil_Click(object sender, EventArgs e)
        {
            try
            {
                OgretimElemanlariModel oem = new OgretimElemanlariModel {OEID=oeid };
                OgretimElemanlariBL oebl = new OgretimElemanlariBL();
                oebl.OgretimElemaniSil(oem);
                OgretimElemanlariGridYukle();
                OgrencilerGridYukle();
                BirimListeDoldur();
                OgrenciBirimListeDoldur();
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
        void OgretimElemaniBirimListeDoldur()
        {
            OgretimElemanlariBL oebl = new OgretimElemanlariBL();//SinifBL sınıfından sb adında yeni bir nesne türetildi.
            combo_ogretim_birim.DisplayMember = "Ad";//Combobox üzerinde görünecek olan alan berlirlendi.
            combo_ogretim_birim.ValueMember = "AkademikBirimID";//Combobox üzerinde görünen alanın arka planda alacağı değerin alanı belirlendi.
            combo_ogretim_birim.DataSource = oebl.BirimListesiDoldur();//Data Source olarak SinifListesiDoldur metodu çağırıldı.
        }
        private void combo_ogretim_birim_SelectedIndexChanged(object sender, EventArgs e)
        {
            BolumlerModel bm = new BolumlerModel { AkademikBirimID = Convert.ToInt32(combo_ogretim_birim.SelectedValue) };
            OgretimElemanlariBL oem = new OgretimElemanlariBL();//SinifBL sınıfından sb adında yeni bir nesne türetildi.
            combo_ogretim_bolum.DisplayMember = "BolumAd";//Combobox üzerinde görünecek olan alan berlirlendi.
            combo_ogretim_bolum.ValueMember = "BolumID";//Combobox üzerinde görünen alanın arka planda alacağı değerin alanı belirlendi.
            combo_ogretim_bolum.DataSource = oem.BolumListesiDoldur(bm);//Data Source olarak SinifListesiDoldur metodu çağırıldı.
        }

        private void grid_akademik_ogretim_elemanlari_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            oeid = Convert.ToInt32(grid_akademik_ogretim_elemanlari.CurrentRow.Cells["OEID"].Value);

        }
        #endregion

        #region Akademik Birimler-Ogretim Elemanani Islemleri-Dersler
        void OgretimElemanlariDerslerGridYukle()
        {
            try
            {
                OgretimElemaniDerslerBL oedbl = new OgretimElemaniDerslerBL();
                dt = oedbl.OgretimElemaniDerslerTablosuGetir();
                grid_akademik_ogretim_elemanlari_dersler.DataSource = dt;
            }
            catch (SqlException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion


    }
}

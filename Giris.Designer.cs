namespace OBS
{
    partial class Giris
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
            this.components = new System.ComponentModel.Container();
            this.metroStyleManagerGiris = new MetroFramework.Components.MetroStyleManager(this.components);
            this.label_yetki = new MetroFramework.Controls.MetroLabel();
            this.combobox_yetkiler = new MetroFramework.Controls.MetroComboBox();
            this.label_yetki_no = new MetroFramework.Controls.MetroLabel();
            this.label_sifre = new MetroFramework.Controls.MetroLabel();
            this.text_yetki_no = new MetroFramework.Controls.MetroTextBox();
            this.text_sifre = new MetroFramework.Controls.MetroTextBox();
            this.button_giris = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerGiris)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManagerGiris
            // 
            this.metroStyleManagerGiris.Owner = this;
            this.metroStyleManagerGiris.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_yetki
            // 
            this.label_yetki.AutoSize = true;
            this.label_yetki.Location = new System.Drawing.Point(23, 71);
            this.label_yetki.Name = "label_yetki";
            this.label_yetki.Size = new System.Drawing.Size(94, 19);
            this.label_yetki.TabIndex = 0;
            this.label_yetki.Text = "Yetkilendirme :";
            // 
            // combobox_yetkiler
            // 
            this.combobox_yetkiler.FormattingEnabled = true;
            this.combobox_yetkiler.ItemHeight = 23;
            this.combobox_yetkiler.Items.AddRange(new object[] {
            "Yönetici",
            "Öğretim Elemanı",
            "Öğrenci"});
            this.combobox_yetkiler.Location = new System.Drawing.Point(124, 66);
            this.combobox_yetkiler.Name = "combobox_yetkiler";
            this.combobox_yetkiler.Size = new System.Drawing.Size(121, 29);
            this.combobox_yetkiler.TabIndex = 1;
            this.combobox_yetkiler.UseSelectable = true;
            this.combobox_yetkiler.SelectedIndexChanged += new System.EventHandler(this.combobox_yetkiler_SelectedIndexChanged);
            // 
            // label_yetki_no
            // 
            this.label_yetki_no.AutoSize = true;
            this.label_yetki_no.Location = new System.Drawing.Point(24, 111);
            this.label_yetki_no.Name = "label_yetki_no";
            this.label_yetki_no.Size = new System.Drawing.Size(64, 19);
            this.label_yetki_no.TabIndex = 2;
            this.label_yetki_no.Text = "Yetki No :";
            // 
            // label_sifre
            // 
            this.label_sifre.AutoSize = true;
            this.label_sifre.Location = new System.Drawing.Point(24, 150);
            this.label_sifre.Name = "label_sifre";
            this.label_sifre.Size = new System.Drawing.Size(42, 19);
            this.label_sifre.TabIndex = 3;
            this.label_sifre.Text = "Şifre :";
            // 
            // text_yetki_no
            // 
            // 
            // 
            // 
            this.text_yetki_no.CustomButton.Image = null;
            this.text_yetki_no.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.text_yetki_no.CustomButton.Name = "";
            this.text_yetki_no.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.text_yetki_no.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.text_yetki_no.CustomButton.TabIndex = 1;
            this.text_yetki_no.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.text_yetki_no.CustomButton.UseSelectable = true;
            this.text_yetki_no.CustomButton.Visible = false;
            this.text_yetki_no.Lines = new string[0];
            this.text_yetki_no.Location = new System.Drawing.Point(124, 111);
            this.text_yetki_no.MaxLength = 32767;
            this.text_yetki_no.Name = "text_yetki_no";
            this.text_yetki_no.PasswordChar = '\0';
            this.text_yetki_no.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_yetki_no.SelectedText = "";
            this.text_yetki_no.SelectionLength = 0;
            this.text_yetki_no.SelectionStart = 0;
            this.text_yetki_no.ShortcutsEnabled = true;
            this.text_yetki_no.Size = new System.Drawing.Size(121, 23);
            this.text_yetki_no.TabIndex = 4;
            this.text_yetki_no.UseSelectable = true;
            this.text_yetki_no.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.text_yetki_no.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // text_sifre
            // 
            // 
            // 
            // 
            this.text_sifre.CustomButton.Image = null;
            this.text_sifre.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.text_sifre.CustomButton.Name = "";
            this.text_sifre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.text_sifre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.text_sifre.CustomButton.TabIndex = 1;
            this.text_sifre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.text_sifre.CustomButton.UseSelectable = true;
            this.text_sifre.CustomButton.Visible = false;
            this.text_sifre.Lines = new string[0];
            this.text_sifre.Location = new System.Drawing.Point(124, 150);
            this.text_sifre.MaxLength = 32767;
            this.text_sifre.Name = "text_sifre";
            this.text_sifre.PasswordChar = '\0';
            this.text_sifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_sifre.SelectedText = "";
            this.text_sifre.SelectionLength = 0;
            this.text_sifre.SelectionStart = 0;
            this.text_sifre.ShortcutsEnabled = true;
            this.text_sifre.Size = new System.Drawing.Size(121, 23);
            this.text_sifre.TabIndex = 5;
            this.text_sifre.UseSelectable = true;
            this.text_sifre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.text_sifre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button_giris
            // 
            this.button_giris.Highlight = true;
            this.button_giris.Location = new System.Drawing.Point(24, 181);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(221, 33);
            this.button_giris.TabIndex = 6;
            this.button_giris.Text = "Giriş";
            this.button_giris.UseSelectable = true;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 219);
            this.Controls.Add(this.button_giris);
            this.Controls.Add(this.text_sifre);
            this.Controls.Add(this.text_yetki_no);
            this.Controls.Add(this.label_sifre);
            this.Controls.Add(this.label_yetki_no);
            this.Controls.Add(this.combobox_yetkiler);
            this.Controls.Add(this.label_yetki);
            this.Name = "Giris";
            this.Text = "Kullanıcı Girişi";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerGiris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManagerGiris;
        private MetroFramework.Controls.MetroLabel label_yetki;
        private MetroFramework.Controls.MetroComboBox combobox_yetkiler;
        private MetroFramework.Controls.MetroTextBox text_sifre;
        private MetroFramework.Controls.MetroTextBox text_yetki_no;
        private MetroFramework.Controls.MetroLabel label_sifre;
        private MetroFramework.Controls.MetroLabel label_yetki_no;
        private MetroFramework.Controls.MetroButton button_giris;
    }
}
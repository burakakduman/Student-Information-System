namespace OBS
{
    partial class Splash
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
            this.metroStyleManagerSplash = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroProgressSpinner3 = new MetroFramework.Controls.MetroProgressSpinner();
            this.label_ozellikler = new MetroFramework.Controls.MetroLabel();
            this.timer_splash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManagerSplash
            // 
            this.metroStyleManagerSplash.Owner = this;
            this.metroStyleManagerSplash.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroProgressSpinner3
            // 
            this.metroProgressSpinner3.Location = new System.Drawing.Point(175, 73);
            this.metroProgressSpinner3.Maximum = 100;
            this.metroProgressSpinner3.Name = "metroProgressSpinner3";
            this.metroProgressSpinner3.Size = new System.Drawing.Size(38, 40);
            this.metroProgressSpinner3.TabIndex = 13;
            this.metroProgressSpinner3.UseSelectable = true;
            this.metroProgressSpinner3.Value = 50;
            // 
            // label_ozellikler
            // 
            this.label_ozellikler.AutoSize = true;
            this.label_ozellikler.Location = new System.Drawing.Point(8, 157);
            this.label_ozellikler.Name = "label_ozellikler";
            this.label_ozellikler.Size = new System.Drawing.Size(0, 0);
            this.label_ozellikler.TabIndex = 14;
            // 
            // timer_splash
            // 
            this.timer_splash.Interval = 1000;
            this.timer_splash.Tick += new System.EventHandler(this.timer_splash_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 186);
            this.Controls.Add(this.label_ozellikler);
            this.Controls.Add(this.metroProgressSpinner3);
            this.Name = "Splash";
            this.Text = "Öğrenci Bilgi Sistemi";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerSplash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManagerSplash;
        private MetroFramework.Controls.MetroLabel label_ozellikler;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner3;
        private System.Windows.Forms.Timer timer_splash;
    }
}
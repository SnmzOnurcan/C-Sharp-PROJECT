namespace rastgele_sayi_ornegi1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.button_baslat = new DevExpress.XtraEditors.SimpleButton();
            this.button_durdur = new DevExpress.XtraEditors.SimpleButton();
            this.listBox_cift = new DevExpress.XtraEditors.ListBoxControl();
            this.listBox_tek = new DevExpress.XtraEditors.ListBoxControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_cift_sayilarin_ortalamasi = new DevExpress.XtraEditors.SimpleButton();
            this.button_tek_sayilarin_ortalamasi = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.listBox_cift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBox_tek)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl2.Appearance.Font")));
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // button_baslat
            // 
            this.button_baslat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            resources.ApplyResources(this.button_baslat, "button_baslat");
            this.button_baslat.Name = "button_baslat";
            this.button_baslat.Click += new System.EventHandler(this.button_baslat_Click);
            // 
            // button_durdur
            // 
            this.button_durdur.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            resources.ApplyResources(this.button_durdur, "button_durdur");
            this.button_durdur.Name = "button_durdur";
            this.button_durdur.Click += new System.EventHandler(this.button_durdur_Click);
            // 
            // listBox_cift
            // 
            this.listBox_cift.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("listBox_cift.Appearance.Font")));
            this.listBox_cift.Appearance.Options.UseFont = true;
            this.listBox_cift.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.listBox_cift, "listBox_cift");
            this.listBox_cift.Name = "listBox_cift";
            // 
            // listBox_tek
            // 
            this.listBox_tek.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("listBox_tek.Appearance.Font")));
            this.listBox_tek.Appearance.Options.UseFont = true;
            this.listBox_tek.CausesValidation = false;
            this.listBox_tek.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.listBox_tek, "listBox_tek");
            this.listBox_tek.Name = "listBox_tek";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_cift_sayilarin_ortalamasi
            // 
            this.button_cift_sayilarin_ortalamasi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            resources.ApplyResources(this.button_cift_sayilarin_ortalamasi, "button_cift_sayilarin_ortalamasi");
            this.button_cift_sayilarin_ortalamasi.Name = "button_cift_sayilarin_ortalamasi";
            this.button_cift_sayilarin_ortalamasi.Click += new System.EventHandler(this.button_cift_sayilarin_ortalamasi_Click);
            // 
            // button_tek_sayilarin_ortalamasi
            // 
            this.button_tek_sayilarin_ortalamasi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            resources.ApplyResources(this.button_tek_sayilarin_ortalamasi, "button_tek_sayilarin_ortalamasi");
            this.button_tek_sayilarin_ortalamasi.Name = "button_tek_sayilarin_ortalamasi";
            this.button_tek_sayilarin_ortalamasi.Click += new System.EventHandler(this.button_tek_sayilarin_ortalamasi_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl3.Appearance.Font")));
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl4.Appearance.Font")));
            resources.ApplyResources(this.labelControl4, "labelControl4");
            this.labelControl4.Name = "labelControl4";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.Controls.Add(this.listBox_tek);
            this.Controls.Add(this.listBox_cift);
            this.Controls.Add(this.button_durdur);
            this.Controls.Add(this.button_tek_sayilarin_ortalamasi);
            this.Controls.Add(this.button_cift_sayilarin_ortalamasi);
            this.Controls.Add(this.button_baslat);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBox_cift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBox_tek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton button_baslat;
        private DevExpress.XtraEditors.SimpleButton button_durdur;
        private DevExpress.XtraEditors.ListBoxControl listBox_cift;
        private DevExpress.XtraEditors.ListBoxControl listBox_tek;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SimpleButton button_cift_sayilarin_ortalamasi;
        private DevExpress.XtraEditors.SimpleButton button_tek_sayilarin_ortalamasi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}


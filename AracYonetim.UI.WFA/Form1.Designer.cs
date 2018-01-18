namespace AracYonetim.UI.WFA
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarkaAdi = new System.Windows.Forms.TextBox();
            this.txtKurulus = new System.Windows.Forms.TextBox();
            this.txtUlke = new System.Windows.Forms.TextBox();
            this.txtKurucu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbMarkaLogo = new System.Windows.Forms.PictureBox();
            this.lstMarkalar = new System.Windows.Forms.ListBox();
            this.btnMarkaKaydet = new System.Windows.Forms.Button();
            this.lstAraclar = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.pbAraclar = new System.Windows.Forms.PictureBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.cmbYakit = new System.Windows.Forms.ComboBox();
            this.cmbVites = new System.Windows.Forms.ComboBox();
            this.btnAracKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMarkaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kuruluş yılı";
            // 
            // txtMarkaAdi
            // 
            this.txtMarkaAdi.Location = new System.Drawing.Point(110, 28);
            this.txtMarkaAdi.Name = "txtMarkaAdi";
            this.txtMarkaAdi.Size = new System.Drawing.Size(105, 20);
            this.txtMarkaAdi.TabIndex = 2;
            // 
            // txtKurulus
            // 
            this.txtKurulus.Location = new System.Drawing.Point(110, 54);
            this.txtKurulus.Name = "txtKurulus";
            this.txtKurulus.Size = new System.Drawing.Size(105, 20);
            this.txtKurulus.TabIndex = 3;
            // 
            // txtUlke
            // 
            this.txtUlke.Location = new System.Drawing.Point(110, 86);
            this.txtUlke.Name = "txtUlke";
            this.txtUlke.Size = new System.Drawing.Size(105, 20);
            this.txtUlke.TabIndex = 4;
            // 
            // txtKurucu
            // 
            this.txtKurucu.Location = new System.Drawing.Point(110, 115);
            this.txtKurucu.Name = "txtKurucu";
            this.txtKurucu.Size = new System.Drawing.Size(105, 20);
            this.txtKurucu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ülke";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kurucusu";
            // 
            // pbMarkaLogo
            // 
            this.pbMarkaLogo.Location = new System.Drawing.Point(28, 141);
            this.pbMarkaLogo.Name = "pbMarkaLogo";
            this.pbMarkaLogo.Size = new System.Drawing.Size(214, 185);
            this.pbMarkaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMarkaLogo.TabIndex = 9;
            this.pbMarkaLogo.TabStop = false;
            this.pbMarkaLogo.Click += new System.EventHandler(this.pbMarkaLogo_Click);
            // 
            // lstMarkalar
            // 
            this.lstMarkalar.FormattingEnabled = true;
            this.lstMarkalar.Location = new System.Drawing.Point(272, 28);
            this.lstMarkalar.Name = "lstMarkalar";
            this.lstMarkalar.Size = new System.Drawing.Size(158, 355);
            this.lstMarkalar.TabIndex = 10;
            this.lstMarkalar.SelectedIndexChanged += new System.EventHandler(this.lstMarkalar_SelectedIndexChanged);
            // 
            // btnMarkaKaydet
            // 
            this.btnMarkaKaydet.Location = new System.Drawing.Point(120, 332);
            this.btnMarkaKaydet.Name = "btnMarkaKaydet";
            this.btnMarkaKaydet.Size = new System.Drawing.Size(122, 51);
            this.btnMarkaKaydet.TabIndex = 11;
            this.btnMarkaKaydet.Text = "marka kaydet";
            this.btnMarkaKaydet.UseVisualStyleBackColor = true;
            this.btnMarkaKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstAraclar
            // 
            this.lstAraclar.FormattingEnabled = true;
            this.lstAraclar.Location = new System.Drawing.Point(436, 28);
            this.lstAraclar.Name = "lstAraclar";
            this.lstAraclar.Size = new System.Drawing.Size(172, 355);
            this.lstAraclar.TabIndex = 12;
            this.lstAraclar.SelectedIndexChanged += new System.EventHandler(this.lstAraclar_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(614, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "üretim yılı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(618, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "yakıt tipi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(618, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "vites tipi";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(669, 32);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(128, 20);
            this.txtModel.TabIndex = 17;
            // 
            // pbAraclar
            // 
            this.pbAraclar.Location = new System.Drawing.Point(630, 149);
            this.pbAraclar.Name = "pbAraclar";
            this.pbAraclar.Size = new System.Drawing.Size(180, 177);
            this.pbAraclar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAraclar.TabIndex = 18;
            this.pbAraclar.TabStop = false;
            this.pbAraclar.Click += new System.EventHandler(this.pbAraclar_Click);
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(673, 61);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(128, 20);
            this.txtYil.TabIndex = 19;
            // 
            // cmbYakit
            // 
            this.cmbYakit.FormattingEnabled = true;
            this.cmbYakit.Location = new System.Drawing.Point(673, 93);
            this.cmbYakit.Name = "cmbYakit";
            this.cmbYakit.Size = new System.Drawing.Size(124, 21);
            this.cmbYakit.TabIndex = 20;
            // 
            // cmbVites
            // 
            this.cmbVites.FormattingEnabled = true;
            this.cmbVites.Location = new System.Drawing.Point(673, 122);
            this.cmbVites.Name = "cmbVites";
            this.cmbVites.Size = new System.Drawing.Size(124, 21);
            this.cmbVites.TabIndex = 21;
            // 
            // btnAracKaydet
            // 
            this.btnAracKaydet.Location = new System.Drawing.Point(647, 332);
            this.btnAracKaydet.Name = "btnAracKaydet";
            this.btnAracKaydet.Size = new System.Drawing.Size(122, 39);
            this.btnAracKaydet.TabIndex = 22;
            this.btnAracKaydet.Text = "araç  kaydet";
            this.btnAracKaydet.UseVisualStyleBackColor = true;
            this.btnAracKaydet.Click += new System.EventHandler(this.btnAracKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 452);
            this.Controls.Add(this.btnAracKaydet);
            this.Controls.Add(this.cmbVites);
            this.Controls.Add(this.cmbYakit);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.pbAraclar);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstAraclar);
            this.Controls.Add(this.btnMarkaKaydet);
            this.Controls.Add(this.lstMarkalar);
            this.Controls.Add(this.pbMarkaLogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKurucu);
            this.Controls.Add(this.txtUlke);
            this.Controls.Add(this.txtKurulus);
            this.Controls.Add(this.txtMarkaAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMarkaLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAraclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarkaAdi;
        private System.Windows.Forms.TextBox txtKurulus;
        private System.Windows.Forms.TextBox txtUlke;
        private System.Windows.Forms.TextBox txtKurucu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbMarkaLogo;
        private System.Windows.Forms.ListBox lstMarkalar;
        private System.Windows.Forms.Button btnMarkaKaydet;
        private System.Windows.Forms.ListBox lstAraclar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.PictureBox pbAraclar;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.ComboBox cmbYakit;
        private System.Windows.Forms.ComboBox cmbVites;
        private System.Windows.Forms.Button btnAracKaydet;
    }
}


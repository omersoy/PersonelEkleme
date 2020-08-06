namespace FormOdev
{
    partial class frmPersonel
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFotoSec = new System.Windows.Forms.Button();
            this.btnFotoKaldir = new System.Windows.Forms.Button();
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblDTarihi = new System.Windows.Forms.Label();
            this.lblKanGrubu = new System.Windows.Forms.Label();
            this.lblIseGirme = new System.Windows.Forms.Label();
            this.lblIstenCikis = new System.Windows.Forms.Label();
            this.lblNetMaas = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.tbxTC = new System.Windows.Forms.TextBox();
            this.dtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtIseGirme = new System.Windows.Forms.DateTimePicker();
            this.dtIstenCikma = new System.Windows.Forms.DateTimePicker();
            this.tbxNetMaas = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cbxKanGrubu = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.odevFormAppDataSet = new FormOdev.odevFormAppDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new FormOdev.odevFormAppDataSetTableAdapters.EmployeeTableAdapter();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odevFormAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 260);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnFotoSec
            // 
            this.btnFotoSec.Location = new System.Drawing.Point(17, 283);
            this.btnFotoSec.Margin = new System.Windows.Forms.Padding(4);
            this.btnFotoSec.Name = "btnFotoSec";
            this.btnFotoSec.Size = new System.Drawing.Size(223, 28);
            this.btnFotoSec.TabIndex = 1;
            this.btnFotoSec.Text = "Fotoğraf Seç";
            this.btnFotoSec.UseVisualStyleBackColor = true;
            this.btnFotoSec.Click += new System.EventHandler(this.btnFotoSec_Click);
            // 
            // btnFotoKaldir
            // 
            this.btnFotoKaldir.Location = new System.Drawing.Point(16, 319);
            this.btnFotoKaldir.Margin = new System.Windows.Forms.Padding(4);
            this.btnFotoKaldir.Name = "btnFotoKaldir";
            this.btnFotoKaldir.Size = new System.Drawing.Size(223, 28);
            this.btnFotoKaldir.TabIndex = 2;
            this.btnFotoKaldir.Text = "Fotoğrafı Kaldır";
            this.btnFotoKaldir.UseVisualStyleBackColor = true;
            this.btnFotoKaldir.Click += new System.EventHandler(this.btnFotoKaldir_Click);
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(249, 16);
            this.lblIsim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(36, 17);
            this.lblIsim.TabIndex = 3;
            this.lblIsim.Text = "İsim:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(249, 47);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(52, 17);
            this.lblSoyad.TabIndex = 4;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(248, 81);
            this.lblTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(96, 17);
            this.lblTC.TabIndex = 5;
            this.lblTC.Text = "T.C. Kimlik No";
            // 
            // lblDTarihi
            // 
            this.lblDTarihi.AutoSize = true;
            this.lblDTarihi.Location = new System.Drawing.Point(249, 113);
            this.lblDTarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDTarihi.Name = "lblDTarihi";
            this.lblDTarihi.Size = new System.Drawing.Size(93, 17);
            this.lblDTarihi.TabIndex = 6;
            this.lblDTarihi.Text = "Doğum Tarihi";
            // 
            // lblKanGrubu
            // 
            this.lblKanGrubu.AutoSize = true;
            this.lblKanGrubu.Location = new System.Drawing.Point(248, 154);
            this.lblKanGrubu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKanGrubu.Name = "lblKanGrubu";
            this.lblKanGrubu.Size = new System.Drawing.Size(77, 17);
            this.lblKanGrubu.TabIndex = 7;
            this.lblKanGrubu.Text = "Kan Grubu";
            // 
            // lblIseGirme
            // 
            this.lblIseGirme.AutoSize = true;
            this.lblIseGirme.Location = new System.Drawing.Point(248, 188);
            this.lblIseGirme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIseGirme.Name = "lblIseGirme";
            this.lblIseGirme.Size = new System.Drawing.Size(108, 17);
            this.lblIseGirme.TabIndex = 8;
            this.lblIseGirme.Text = "İşe Girme Tarihi";
            // 
            // lblIstenCikis
            // 
            this.lblIstenCikis.AutoSize = true;
            this.lblIstenCikis.Location = new System.Drawing.Point(248, 225);
            this.lblIstenCikis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIstenCikis.Name = "lblIstenCikis";
            this.lblIstenCikis.Size = new System.Drawing.Size(111, 17);
            this.lblIstenCikis.TabIndex = 9;
            this.lblIstenCikis.Text = "İşten Çıkış Tarihi";
            // 
            // lblNetMaas
            // 
            this.lblNetMaas.AutoSize = true;
            this.lblNetMaas.Location = new System.Drawing.Point(249, 258);
            this.lblNetMaas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNetMaas.Name = "lblNetMaas";
            this.lblNetMaas.Size = new System.Drawing.Size(68, 17);
            this.lblNetMaas.TabIndex = 10;
            this.lblNetMaas.Text = "Net Maaş";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(249, 295);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(45, 17);
            this.lblAdres.TabIndex = 11;
            this.lblAdres.Text = "Adres";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(484, 16);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(261, 22);
            this.tbxName.TabIndex = 12;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(484, 43);
            this.tbxSurname.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(261, 22);
            this.tbxSurname.TabIndex = 13;
            // 
            // tbxTC
            // 
            this.tbxTC.Location = new System.Drawing.Point(484, 81);
            this.tbxTC.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTC.MaxLength = 11;
            this.tbxTC.Name = "tbxTC";
            this.tbxTC.Size = new System.Drawing.Size(261, 22);
            this.tbxTC.TabIndex = 14;
            this.tbxTC.TextChanged += new System.EventHandler(this.tbxTC_TextChanged);
            this.tbxTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTC_KeyPress);
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.Location = new System.Drawing.Point(484, 114);
            this.dtDogumTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Size = new System.Drawing.Size(265, 22);
            this.dtDogumTarihi.TabIndex = 15;
            // 
            // dtIseGirme
            // 
            this.dtIseGirme.Location = new System.Drawing.Point(484, 188);
            this.dtIseGirme.Margin = new System.Windows.Forms.Padding(4);
            this.dtIseGirme.Name = "dtIseGirme";
            this.dtIseGirme.Size = new System.Drawing.Size(265, 22);
            this.dtIseGirme.TabIndex = 17;
            // 
            // dtIstenCikma
            // 
            this.dtIstenCikma.Enabled = false;
            this.dtIstenCikma.Location = new System.Drawing.Point(484, 220);
            this.dtIstenCikma.Margin = new System.Windows.Forms.Padding(4);
            this.dtIstenCikma.Name = "dtIstenCikma";
            this.dtIstenCikma.Size = new System.Drawing.Size(265, 22);
            this.dtIstenCikma.TabIndex = 18;
            // 
            // tbxNetMaas
            // 
            this.tbxNetMaas.Location = new System.Drawing.Point(484, 258);
            this.tbxNetMaas.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNetMaas.Name = "tbxNetMaas";
            this.tbxNetMaas.Size = new System.Drawing.Size(261, 22);
            this.tbxNetMaas.TabIndex = 19;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(484, 295);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(513, 158);
            this.txtAdress.TabIndex = 20;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(776, 462);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(223, 28);
            this.btnEkle.TabIndex = 21;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(776, 511);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(223, 28);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cbxKanGrubu
            // 
            this.cbxKanGrubu.FormattingEnabled = true;
            this.cbxKanGrubu.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.cbxKanGrubu.Location = new System.Drawing.Point(484, 155);
            this.cbxKanGrubu.Margin = new System.Windows.Forms.Padding(4);
            this.cbxKanGrubu.Name = "cbxKanGrubu";
            this.cbxKanGrubu.Size = new System.Drawing.Size(261, 24);
            this.cbxKanGrubu.TabIndex = 23;
            this.cbxKanGrubu.SelectedIndexChanged += new System.EventHandler(this.cbxKanGrubu_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // odevFormAppDataSet
            // 
            this.odevFormAppDataSet.DataSetName = "odevFormAppDataSet";
            this.odevFormAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.odevFormAppDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(77, 394);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(46, 17);
            this.lblID.TabIndex = 24;
            this.lblID.Text = "label1";
            this.lblID.Visible = false;
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cbxKanGrubu);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.tbxNetMaas);
            this.Controls.Add(this.dtIstenCikma);
            this.Controls.Add(this.dtIseGirme);
            this.Controls.Add(this.dtDogumTarihi);
            this.Controls.Add(this.tbxTC);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblNetMaas);
            this.Controls.Add(this.lblIstenCikis);
            this.Controls.Add(this.lblIseGirme);
            this.Controls.Add(this.lblKanGrubu);
            this.Controls.Add(this.lblDTarihi);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblIsim);
            this.Controls.Add(this.btnFotoKaldir);
            this.Controls.Add(this.btnFotoSec);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPersonel";
            this.Text = "Personel Formu";
            this.Load += new System.EventHandler(this.frmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odevFormAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFotoSec;
        private System.Windows.Forms.Button btnFotoKaldir;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblDTarihi;
        private System.Windows.Forms.Label lblKanGrubu;
        private System.Windows.Forms.Label lblIseGirme;
        private System.Windows.Forms.Label lblIstenCikis;
        private System.Windows.Forms.Label lblNetMaas;
        private System.Windows.Forms.Label lblAdres;
        public System.Windows.Forms.TextBox tbxName;
        public System.Windows.Forms.TextBox tbxSurname;
        public System.Windows.Forms.TextBox tbxTC;
        public System.Windows.Forms.DateTimePicker dtDogumTarihi;
        public System.Windows.Forms.DateTimePicker dtIseGirme;
        public System.Windows.Forms.DateTimePicker dtIstenCikma;
        public System.Windows.Forms.TextBox tbxNetMaas;
        public System.Windows.Forms.TextBox txtAdress;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.ComboBox cbxKanGrubu;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private odevFormAppDataSet odevFormAppDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private odevFormAppDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        public System.Windows.Forms.Label lblID;
    }
}


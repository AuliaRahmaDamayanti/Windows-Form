namespace LatihanWinForm
{
    partial class FrmListMahasiswa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.Nama = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jeniskelamin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.txtTempatLahir = new System.Windows.Forms.TextBox();
            this.rdoPerempuan = new System.Windows.Forms.RadioButton();
            this.rdoLakilaki = new System.Windows.Forms.RadioButton();
            this.mskNpm = new System.Windows.Forms.MaskedTextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwMahasiswa = new System.Windows.Forms.ListView();
            this.btnTutup = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Controls.Add(this.Nama);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.jeniskelamin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpTanggalLahir);
            this.groupBox1.Controls.Add(this.txtTempatLahir);
            this.groupBox1.Controls.Add(this.rdoPerempuan);
            this.groupBox1.Controls.Add(this.rdoLakilaki);
            this.groupBox1.Controls.Add(this.mskNpm);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Data Mahasiswa ]";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(106, 62);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(100, 20);
            this.txtNama.TabIndex = 7;
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(15, 65);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(35, 13);
            this.Nama.TabIndex = 7;
            this.Nama.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tanggal Lahir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tempat Lahir";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // jeniskelamin
            // 
            this.jeniskelamin.AutoSize = true;
            this.jeniskelamin.Location = new System.Drawing.Point(9, 114);
            this.jeniskelamin.Name = "jeniskelamin";
            this.jeniskelamin.Size = new System.Drawing.Size(71, 13);
            this.jeniskelamin.TabIndex = 7;
            this.jeniskelamin.Text = "Jenis Kelamin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "NPM";
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.CustomFormat = "dd/MM/yyyy";
            this.dtpTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalLahir.Location = new System.Drawing.Point(106, 187);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(142, 20);
            this.dtpTanggalLahir.TabIndex = 5;
            // 
            // txtTempatLahir
            // 
            this.txtTempatLahir.Location = new System.Drawing.Point(106, 148);
            this.txtTempatLahir.Name = "txtTempatLahir";
            this.txtTempatLahir.Size = new System.Drawing.Size(142, 20);
            this.txtTempatLahir.TabIndex = 4;
            // 
            // rdoPerempuan
            // 
            this.rdoPerempuan.AutoSize = true;
            this.rdoPerempuan.Location = new System.Drawing.Point(186, 114);
            this.rdoPerempuan.Name = "rdoPerempuan";
            this.rdoPerempuan.Size = new System.Drawing.Size(79, 17);
            this.rdoPerempuan.TabIndex = 3;
            this.rdoPerempuan.TabStop = true;
            this.rdoPerempuan.Text = "Perempuan";
            this.rdoPerempuan.UseVisualStyleBackColor = true;
            // 
            // rdoLakilaki
            // 
            this.rdoLakilaki.AutoSize = true;
            this.rdoLakilaki.Location = new System.Drawing.Point(94, 114);
            this.rdoLakilaki.Name = "rdoLakilaki";
            this.rdoLakilaki.Size = new System.Drawing.Size(70, 17);
            this.rdoLakilaki.TabIndex = 2;
            this.rdoLakilaki.TabStop = true;
            this.rdoLakilaki.Text = "Laki - laki";
            this.rdoLakilaki.UseVisualStyleBackColor = true;
            // 
            // mskNpm
            // 
            this.mskNpm.Location = new System.Drawing.Point(106, 19);
            this.mskNpm.Mask = "##.##.####";
            this.mskNpm.Name = "mskNpm";
            this.mskNpm.Size = new System.Drawing.Size(100, 20);
            this.mskNpm.TabIndex = 1;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(30, 278);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(175, 278);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 7;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvwMahasiswa);
            this.groupBox2.Location = new System.Drawing.Point(289, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 380);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[ Daftar Mahasiswa ]";
            // 
            // lvwMahasiswa
            // 
            this.lvwMahasiswa.Location = new System.Drawing.Point(6, 28);
            this.lvwMahasiswa.Name = "lvwMahasiswa";
            this.lvwMahasiswa.Size = new System.Drawing.Size(397, 346);
            this.lvwMahasiswa.TabIndex = 6;
            this.lvwMahasiswa.UseCompatibleStateImageBehavior = false;
            this.lvwMahasiswa.SelectedIndexChanged += new System.EventHandler(this.lvwMahasiswa_SelectedIndexChanged);
            this.lvwMahasiswa.DoubleClick += new System.EventHandler(this.lvwMahasiswa_DoubleClick);
            // 
            // btnTutup
            // 
            this.btnTutup.Location = new System.Drawing.Point(602, 415);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(75, 23);
            this.btnTutup.TabIndex = 7;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // FrmListMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmListMahasiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Mahasiswa";
            this.Load += new System.EventHandler(this.FrmListMahasiswa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label jeniskelamin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.TextBox txtTempatLahir;
        private System.Windows.Forms.RadioButton rdoPerempuan;
        private System.Windows.Forms.RadioButton rdoLakilaki;
        private System.Windows.Forms.MaskedTextBox mskNpm;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvwMahasiswa;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label Nama;
    }
}
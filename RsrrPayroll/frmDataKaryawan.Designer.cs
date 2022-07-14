
namespace RsrrPayroll
{
    partial class frmDataKaryawan
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
            this.nama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.form = new System.Windows.Forms.Panel();
            this.jTanggungan = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.tgllhr = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.nik = new System.Windows.Forms.TextBox();
            this.alamat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nohp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bagian = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.profesi = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.statusKerja = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.statusKaryawan = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.statusPernikahan = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.jk = new System.Windows.Forms.ComboBox();
            this.pilih = new System.Windows.Forms.Panel();
            this.hapusPend = new System.Windows.Forms.Button();
            this.tmbPend = new System.Windows.Forms.Button();
            this.listPendidikan = new System.Windows.Forms.DataGridView();
            this.hapusJabatan = new System.Windows.Forms.Button();
            this.tmbJab = new System.Windows.Forms.Button();
            this.listJabatan = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpan = new System.Windows.Forms.Button();
            this.batal = new System.Windows.Forms.Button();
            this.form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jTanggungan)).BeginInit();
            this.pilih.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listPendidikan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listJabatan)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nama
            // 
            this.nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(16, 79);
            this.nama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(167, 24);
            this.nama.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "NIK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Jenis Kelamin";
            // 
            // form
            // 
            this.form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.form.Controls.Add(this.jTanggungan);
            this.form.Controls.Add(this.label11);
            this.form.Controls.Add(this.tgllhr);
            this.form.Controls.Add(this.label8);
            this.form.Controls.Add(this.nik);
            this.form.Controls.Add(this.alamat);
            this.form.Controls.Add(this.label9);
            this.form.Controls.Add(this.email);
            this.form.Controls.Add(this.label7);
            this.form.Controls.Add(this.nohp);
            this.form.Controls.Add(this.label4);
            this.form.Controls.Add(this.nama);
            this.form.Controls.Add(this.label6);
            this.form.Controls.Add(this.label5);
            this.form.Controls.Add(this.bagian);
            this.form.Controls.Add(this.label15);
            this.form.Controls.Add(this.profesi);
            this.form.Controls.Add(this.label14);
            this.form.Controls.Add(this.statusKerja);
            this.form.Controls.Add(this.label13);
            this.form.Controls.Add(this.statusKaryawan);
            this.form.Controls.Add(this.label12);
            this.form.Controls.Add(this.statusPernikahan);
            this.form.Controls.Add(this.label10);
            this.form.Controls.Add(this.jk);
            this.form.Controls.Add(this.label1);
            this.form.Location = new System.Drawing.Point(9, 8);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(394, 397);
            this.form.TabIndex = 5;
            // 
            // jTanggungan
            // 
            this.jTanggungan.Location = new System.Drawing.Point(219, 81);
            this.jTanggungan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jTanggungan.Name = "jTanggungan";
            this.jTanggungan.Size = new System.Drawing.Size(119, 20);
            this.jTanggungan.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(216, 64);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Jumlah Tanggungan";
            // 
            // tgllhr
            // 
            this.tgllhr.Location = new System.Drawing.Point(16, 189);
            this.tgllhr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tgllhr.Name = "tgllhr";
            this.tgllhr.Size = new System.Drawing.Size(135, 20);
            this.tgllhr.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tanggal Lahir";
            // 
            // nik
            // 
            this.nik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nik.Location = new System.Drawing.Point(16, 27);
            this.nik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nik.Name = "nik";
            this.nik.ReadOnly = true;
            this.nik.Size = new System.Drawing.Size(167, 24);
            this.nik.TabIndex = 23;
            this.nik.Text = "Auto";
            // 
            // alamat
            // 
            this.alamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat.Location = new System.Drawing.Point(16, 244);
            this.alamat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.alamat.Multiline = true;
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(167, 72);
            this.alamat.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 229);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Alamat";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(219, 353);
            this.email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(167, 24);
            this.email.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 338);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Email";
            // 
            // nohp
            // 
            this.nohp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nohp.Location = new System.Drawing.Point(16, 353);
            this.nohp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nohp.MaxLength = 14;
            this.nohp.Name = "nohp";
            this.nohp.Size = new System.Drawing.Size(167, 24);
            this.nohp.TabIndex = 19;
            this.nohp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nohp_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "No Hp";
            // 
            // bagian
            // 
            this.bagian.BackColor = System.Drawing.Color.Silver;
            this.bagian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bagian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bagian.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagian.FormattingEnabled = true;
            this.bagian.Items.AddRange(new object[] {
            "LAKI - LAKI",
            "PEREMPUAN"});
            this.bagian.Location = new System.Drawing.Point(219, 298);
            this.bagian.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bagian.Name = "bagian";
            this.bagian.Size = new System.Drawing.Size(167, 26);
            this.bagian.TabIndex = 12;
            this.bagian.DropDown += new System.EventHandler(this.bagian_DropDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(216, 283);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Bagian";
            // 
            // profesi
            // 
            this.profesi.BackColor = System.Drawing.Color.Silver;
            this.profesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profesi.FormattingEnabled = true;
            this.profesi.Items.AddRange(new object[] {
            "LAKI - LAKI",
            "PEREMPUAN"});
            this.profesi.Location = new System.Drawing.Point(219, 244);
            this.profesi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profesi.Name = "profesi";
            this.profesi.Size = new System.Drawing.Size(167, 26);
            this.profesi.TabIndex = 12;
            this.profesi.DropDown += new System.EventHandler(this.profesi_DropDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(216, 229);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Profesi";
            // 
            // statusKerja
            // 
            this.statusKerja.BackColor = System.Drawing.Color.Silver;
            this.statusKerja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusKerja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusKerja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusKerja.FormattingEnabled = true;
            this.statusKerja.Items.AddRange(new object[] {
            "AKTIF",
            "CUTI MELAHIRKAN",
            "TIDAK AKTIF"});
            this.statusKerja.Location = new System.Drawing.Point(219, 189);
            this.statusKerja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusKerja.Name = "statusKerja";
            this.statusKerja.Size = new System.Drawing.Size(167, 26);
            this.statusKerja.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(216, 174);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Status Kerja";
            // 
            // statusKaryawan
            // 
            this.statusKaryawan.BackColor = System.Drawing.Color.Silver;
            this.statusKaryawan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusKaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusKaryawan.FormattingEnabled = true;
            this.statusKaryawan.Items.AddRange(new object[] {
            "Training",
            "Kontrak",
            "Tetap",
            "Outsourcing"});
            this.statusKaryawan.Location = new System.Drawing.Point(219, 133);
            this.statusKaryawan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusKaryawan.Name = "statusKaryawan";
            this.statusKaryawan.Size = new System.Drawing.Size(167, 26);
            this.statusKaryawan.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(216, 118);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Status Karyawan";
            // 
            // statusPernikahan
            // 
            this.statusPernikahan.BackColor = System.Drawing.Color.Silver;
            this.statusPernikahan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusPernikahan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusPernikahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusPernikahan.FormattingEnabled = true;
            this.statusPernikahan.Items.AddRange(new object[] {
            "Lajang",
            "Menikah",
            "Cerai Hidup",
            "Cerai Mati"});
            this.statusPernikahan.Location = new System.Drawing.Point(219, 27);
            this.statusPernikahan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusPernikahan.Name = "statusPernikahan";
            this.statusPernikahan.Size = new System.Drawing.Size(167, 26);
            this.statusPernikahan.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Status Pernikahan";
            // 
            // jk
            // 
            this.jk.BackColor = System.Drawing.Color.Silver;
            this.jk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jk.FormattingEnabled = true;
            this.jk.Items.AddRange(new object[] {
            "LAKI - LAKI",
            "PEREMPUAN"});
            this.jk.Location = new System.Drawing.Point(16, 133);
            this.jk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jk.Name = "jk";
            this.jk.Size = new System.Drawing.Size(112, 26);
            this.jk.TabIndex = 12;
            // 
            // pilih
            // 
            this.pilih.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pilih.Controls.Add(this.hapusPend);
            this.pilih.Controls.Add(this.tmbPend);
            this.pilih.Controls.Add(this.listPendidikan);
            this.pilih.Controls.Add(this.hapusJabatan);
            this.pilih.Controls.Add(this.tmbJab);
            this.pilih.Controls.Add(this.listJabatan);
            this.pilih.Location = new System.Drawing.Point(407, 8);
            this.pilih.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pilih.Name = "pilih";
            this.pilih.Size = new System.Drawing.Size(414, 397);
            this.pilih.TabIndex = 6;
            // 
            // hapusPend
            // 
            this.hapusPend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hapusPend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapusPend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapusPend.Location = new System.Drawing.Point(259, 4);
            this.hapusPend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hapusPend.Name = "hapusPend";
            this.hapusPend.Size = new System.Drawing.Size(149, 30);
            this.hapusPend.TabIndex = 25;
            this.hapusPend.Text = "Hapus Pendidikan";
            this.hapusPend.UseVisualStyleBackColor = true;
            this.hapusPend.Click += new System.EventHandler(this.hapusPend_Click);
            // 
            // tmbPend
            // 
            this.tmbPend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tmbPend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tmbPend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmbPend.Location = new System.Drawing.Point(3, 4);
            this.tmbPend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tmbPend.Name = "tmbPend";
            this.tmbPend.Size = new System.Drawing.Size(252, 30);
            this.tmbPend.TabIndex = 25;
            this.tmbPend.Text = "Tambah Pendidikan";
            this.tmbPend.UseVisualStyleBackColor = true;
            this.tmbPend.Click += new System.EventHandler(this.tmbPend_Click);
            // 
            // listPendidikan
            // 
            this.listPendidikan.AllowUserToAddRows = false;
            this.listPendidikan.AllowUserToDeleteRows = false;
            this.listPendidikan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPendidikan.Location = new System.Drawing.Point(3, 38);
            this.listPendidikan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listPendidikan.Name = "listPendidikan";
            this.listPendidikan.ReadOnly = true;
            this.listPendidikan.RowHeadersWidth = 62;
            this.listPendidikan.RowTemplate.Height = 28;
            this.listPendidikan.Size = new System.Drawing.Size(405, 135);
            this.listPendidikan.TabIndex = 24;
            this.listPendidikan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listPendidikan_CellClick);
            // 
            // hapusJabatan
            // 
            this.hapusJabatan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hapusJabatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapusJabatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapusJabatan.Location = new System.Drawing.Point(259, 220);
            this.hapusJabatan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hapusJabatan.Name = "hapusJabatan";
            this.hapusJabatan.Size = new System.Drawing.Size(149, 30);
            this.hapusJabatan.TabIndex = 23;
            this.hapusJabatan.Text = "Hapus Jabatan";
            this.hapusJabatan.UseVisualStyleBackColor = true;
            this.hapusJabatan.Click += new System.EventHandler(this.hapusJabatan_Click);
            // 
            // tmbJab
            // 
            this.tmbJab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tmbJab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tmbJab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmbJab.Location = new System.Drawing.Point(3, 220);
            this.tmbJab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tmbJab.Name = "tmbJab";
            this.tmbJab.Size = new System.Drawing.Size(252, 30);
            this.tmbJab.TabIndex = 23;
            this.tmbJab.Text = "Tambah Jabatan";
            this.tmbJab.UseVisualStyleBackColor = true;
            this.tmbJab.Click += new System.EventHandler(this.tmbJab_Click);
            // 
            // listJabatan
            // 
            this.listJabatan.AllowUserToAddRows = false;
            this.listJabatan.AllowUserToDeleteRows = false;
            this.listJabatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listJabatan.Location = new System.Drawing.Point(3, 255);
            this.listJabatan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listJabatan.Name = "listJabatan";
            this.listJabatan.ReadOnly = true;
            this.listJabatan.RowHeadersWidth = 62;
            this.listJabatan.RowTemplate.Height = 28;
            this.listJabatan.Size = new System.Drawing.Size(405, 138);
            this.listJabatan.TabIndex = 0;
            this.listJabatan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listJabatan_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.simpan);
            this.panel2.Controls.Add(this.batal);
            this.panel2.Location = new System.Drawing.Point(9, 409);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 42);
            this.panel2.TabIndex = 23;
            // 
            // simpan
            // 
            this.simpan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simpan.Location = new System.Drawing.Point(674, 6);
            this.simpan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(131, 29);
            this.simpan.TabIndex = 20;
            this.simpan.Text = "Simpan";
            this.simpan.UseVisualStyleBackColor = true;
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // batal
            // 
            this.batal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batal.Location = new System.Drawing.Point(16, 6);
            this.batal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.batal.Name = "batal";
            this.batal.Size = new System.Drawing.Size(124, 29);
            this.batal.TabIndex = 21;
            this.batal.Text = "Batal";
            this.batal.UseVisualStyleBackColor = true;
            this.batal.Click += new System.EventHandler(this.batal_Click);
            // 
            // frmDataKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 454);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pilih);
            this.Controls.Add(this.form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDataKaryawan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmDataKaryawan_Load);
            this.form.ResumeLayout(false);
            this.form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jTanggungan)).EndInit();
            this.pilih.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listPendidikan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listJabatan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel form;
        private System.Windows.Forms.TextBox nik;
        private System.Windows.Forms.ComboBox jk;
        private System.Windows.Forms.Panel pilih;
        private System.Windows.Forms.DateTimePicker tgllhr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nohp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown jTanggungan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox statusKerja;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox statusKaryawan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox statusPernikahan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox bagian;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox profesi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.Button batal;
        private System.Windows.Forms.Button tmbJab;
        private System.Windows.Forms.DataGridView listJabatan;
        private System.Windows.Forms.Button tmbPend;
        private System.Windows.Forms.DataGridView listPendidikan;
        private System.Windows.Forms.Button hapusPend;
        private System.Windows.Forms.Button hapusJabatan;
    }
}
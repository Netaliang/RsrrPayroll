
namespace RsrrPayroll
{
    partial class frmGajiPokok
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.list = new System.Windows.Forms.DataGridView();
            this.panel = new System.Windows.Forms.Panel();
            this.tambah = new System.Windows.Forms.Button();
            this.hapus = new System.Windows.Forms.Button();
            this.batal = new System.Windows.Forms.Button();
            this.gaji = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pendidikan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.jenis = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.masa = new System.Windows.Forms.ComboBox();
            this.periode = new System.Windows.Forms.GroupBox();
            this.tahun = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bulan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.panel.SuspendLayout();
            this.periode.SuspendLayout();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.AllowUserToAddRows = false;
            this.list.AllowUserToDeleteRows = false;
            this.list.AllowUserToResizeColumns = false;
            this.list.AllowUserToResizeRows = false;
            this.list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.list.DefaultCellStyle = dataGridViewCellStyle2;
            this.list.Location = new System.Drawing.Point(241, 12);
            this.list.Name = "list";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.list.Size = new System.Drawing.Size(706, 523);
            this.list.TabIndex = 0;
            this.list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_CellClick);
            this.list.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.list_CellFormatting);
            this.list.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.list_EditingControlShowing);
            this.list.Sorted += new System.EventHandler(this.list_Sorted);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.tambah);
            this.panel.Controls.Add(this.hapus);
            this.panel.Controls.Add(this.batal);
            this.panel.Controls.Add(this.gaji);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.pendidikan);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.jenis);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.masa);
            this.panel.Controls.Add(this.periode);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(223, 523);
            this.panel.TabIndex = 1;
            // 
            // tambah
            // 
            this.tambah.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambah.Location = new System.Drawing.Point(113, 432);
            this.tambah.Margin = new System.Windows.Forms.Padding(2);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(101, 44);
            this.tambah.TabIndex = 20;
            this.tambah.Text = "Tambah";
            this.tambah.UseVisualStyleBackColor = true;
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // hapus
            // 
            this.hapus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapus.Location = new System.Drawing.Point(16, 480);
            this.hapus.Margin = new System.Windows.Forms.Padding(2);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(198, 29);
            this.hapus.TabIndex = 22;
            this.hapus.Text = "Hapus";
            this.hapus.UseVisualStyleBackColor = true;
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // batal
            // 
            this.batal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batal.Location = new System.Drawing.Point(16, 432);
            this.batal.Margin = new System.Windows.Forms.Padding(2);
            this.batal.Name = "batal";
            this.batal.Size = new System.Drawing.Size(93, 44);
            this.batal.TabIndex = 21;
            this.batal.Text = "Batal";
            this.batal.UseVisualStyleBackColor = true;
            this.batal.Click += new System.EventHandler(this.batal_Click);
            // 
            // gaji
            // 
            this.gaji.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaji.Location = new System.Drawing.Point(16, 331);
            this.gaji.Margin = new System.Windows.Forms.Padding(2);
            this.gaji.Name = "gaji";
            this.gaji.Size = new System.Drawing.Size(190, 24);
            this.gaji.TabIndex = 19;
            this.gaji.TextChanged += new System.EventHandler(this.gaji_TextChanged);
            this.gaji.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gaji_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 316);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Gaji Pokok";
            // 
            // pendidikan
            // 
            this.pendidikan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pendidikan.BackColor = System.Drawing.Color.Silver;
            this.pendidikan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pendidikan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pendidikan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendidikan.FormattingEnabled = true;
            this.pendidikan.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA/SMK",
            "D1",
            "D2",
            "D3",
            "D4",
            "S1",
            "S2"});
            this.pendidikan.Location = new System.Drawing.Point(16, 273);
            this.pendidikan.Margin = new System.Windows.Forms.Padding(2);
            this.pendidikan.Name = "pendidikan";
            this.pendidikan.Size = new System.Drawing.Size(190, 26);
            this.pendidikan.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Pendidikan";
            // 
            // jenis
            // 
            this.jenis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jenis.BackColor = System.Drawing.Color.Silver;
            this.jenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jenis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenis.FormattingEnabled = true;
            this.jenis.Items.AddRange(new object[] {
            "Training",
            "Kontrak",
            "Tetap",
            "Outsourcing"});
            this.jenis.Location = new System.Drawing.Point(16, 153);
            this.jenis.Margin = new System.Windows.Forms.Padding(2);
            this.jenis.Name = "jenis";
            this.jenis.Size = new System.Drawing.Size(190, 26);
            this.jenis.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Jenis Karyawan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Masa Kerja";
            // 
            // masa
            // 
            this.masa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masa.BackColor = System.Drawing.Color.Silver;
            this.masa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.masa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.masa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masa.FormattingEnabled = true;
            this.masa.Items.AddRange(new object[] {
            "0-3 bulan",
            "3-12 bulan",
            "1-3 tahun",
            ">3-6 tahun",
            ">6-9 tahun",
            ">9-12 tahun",
            ">12-15 tahun",
            ">15-18 tahun",
            ">18-21 tahun",
            ">22-25 tahun"});
            this.masa.Location = new System.Drawing.Point(16, 211);
            this.masa.Margin = new System.Windows.Forms.Padding(2);
            this.masa.Name = "masa";
            this.masa.Size = new System.Drawing.Size(190, 26);
            this.masa.TabIndex = 14;
            // 
            // periode
            // 
            this.periode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.periode.Controls.Add(this.tahun);
            this.periode.Controls.Add(this.label2);
            this.periode.Controls.Add(this.bulan);
            this.periode.Controls.Add(this.label3);
            this.periode.Location = new System.Drawing.Point(12, 12);
            this.periode.Margin = new System.Windows.Forms.Padding(2);
            this.periode.Name = "periode";
            this.periode.Padding = new System.Windows.Forms.Padding(2);
            this.periode.Size = new System.Drawing.Size(194, 110);
            this.periode.TabIndex = 8;
            this.periode.TabStop = false;
            this.periode.Text = "Periode Gaji";
            // 
            // tahun
            // 
            this.tahun.BackColor = System.Drawing.Color.Silver;
            this.tahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tahun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tahun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tahun.FormattingEnabled = true;
            this.tahun.Location = new System.Drawing.Point(44, 21);
            this.tahun.Margin = new System.Windows.Forms.Padding(2);
            this.tahun.Name = "tahun";
            this.tahun.Size = new System.Drawing.Size(133, 26);
            this.tahun.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tahun";
            // 
            // bulan
            // 
            this.bulan.BackColor = System.Drawing.Color.Silver;
            this.bulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bulan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bulan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulan.FormattingEnabled = true;
            this.bulan.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.bulan.Location = new System.Drawing.Point(41, 69);
            this.bulan.Margin = new System.Windows.Forms.Padding(2);
            this.bulan.Name = "bulan";
            this.bulan.Size = new System.Drawing.Size(135, 26);
            this.bulan.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bulan";
            // 
            // frmGajiPokok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 547);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.list);
            this.Name = "frmGajiPokok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gaji Pokok";
            this.Load += new System.EventHandler(this.frmGajiPokok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.periode.ResumeLayout(false);
            this.periode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView list;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox periode;
        private System.Windows.Forms.ComboBox tahun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox bulan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox jenis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox masa;
        private System.Windows.Forms.TextBox gaji;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox pendidikan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.Button batal;
    }
}
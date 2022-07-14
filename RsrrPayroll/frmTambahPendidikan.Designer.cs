
namespace RsrrPayroll
{
    partial class frmTambahPendidikan
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
            this.jenjang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.masuk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keluar = new System.Windows.Forms.TextBox();
            this.simpan = new System.Windows.Forms.Button();
            this.batal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nama
            // 
            this.nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(15, 75);
            this.nama.Margin = new System.Windows.Forms.Padding(2);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(167, 24);
            this.nama.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Nama Sekolah";
            // 
            // jenjang
            // 
            this.jenjang.BackColor = System.Drawing.Color.Silver;
            this.jenjang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jenjang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jenjang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenjang.FormattingEnabled = true;
            this.jenjang.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA/SMK",
            "D1",
            "D2",
            "D3",
            "D4",
            "S1",
            "S2"});
            this.jenjang.Location = new System.Drawing.Point(13, 24);
            this.jenjang.Margin = new System.Windows.Forms.Padding(2);
            this.jenjang.Name = "jenjang";
            this.jenjang.Size = new System.Drawing.Size(170, 26);
            this.jenjang.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Jenjang Pendidikan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tahun Masuk";
            // 
            // masuk
            // 
            this.masuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masuk.Location = new System.Drawing.Point(15, 128);
            this.masuk.Margin = new System.Windows.Forms.Padding(2);
            this.masuk.Name = "masuk";
            this.masuk.Size = new System.Drawing.Size(167, 24);
            this.masuk.TabIndex = 21;
            this.masuk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.masuk_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tahun Keluar";
            // 
            // keluar
            // 
            this.keluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keluar.Location = new System.Drawing.Point(15, 184);
            this.keluar.Margin = new System.Windows.Forms.Padding(2);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(167, 24);
            this.keluar.TabIndex = 21;
            this.keluar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keluar_KeyPress);
            // 
            // simpan
            // 
            this.simpan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simpan.Location = new System.Drawing.Point(102, 5);
            this.simpan.Margin = new System.Windows.Forms.Padding(2);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(84, 24);
            this.simpan.TabIndex = 24;
            this.simpan.Text = "Simpan";
            this.simpan.UseVisualStyleBackColor = true;
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // batal
            // 
            this.batal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batal.Location = new System.Drawing.Point(7, 5);
            this.batal.Margin = new System.Windows.Forms.Padding(2);
            this.batal.Name = "batal";
            this.batal.Size = new System.Drawing.Size(91, 24);
            this.batal.TabIndex = 25;
            this.batal.Text = "Batal";
            this.batal.UseVisualStyleBackColor = true;
            this.batal.Click += new System.EventHandler(this.batal_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.jenjang);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nama);
            this.panel1.Controls.Add(this.keluar);
            this.panel1.Controls.Add(this.masuk);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 226);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.batal);
            this.panel2.Controls.Add(this.simpan);
            this.panel2.Location = new System.Drawing.Point(8, 238);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 36);
            this.panel2.TabIndex = 27;
            // 
            // frmTambahPendidikan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(211, 280);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTambahPendidikan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tambah Pendidikan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox jenjang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox masuk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keluar;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.Button batal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
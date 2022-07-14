
namespace RsrrPayroll
{
    partial class frmTmbPotongan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textnama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jp = new System.Windows.Forms.TextBox();
            this.ket = new System.Windows.Forms.TextBox();
            this.batal = new System.Windows.Forms.Button();
            this.simpan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textnama);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.jp);
            this.panel1.Controls.Add(this.ket);
            this.panel1.Location = new System.Drawing.Point(8, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 220);
            this.panel1.TabIndex = 28;
            // 
            // textnama
            // 
            this.textnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnama.Location = new System.Drawing.Point(11, 27);
            this.textnama.Margin = new System.Windows.Forms.Padding(2);
            this.textnama.Name = "textnama";
            this.textnama.Size = new System.Drawing.Size(167, 24);
            this.textnama.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Potongan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Keterangan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Jumlah Potongan";
            // 
            // jp
            // 
            this.jp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jp.Location = new System.Drawing.Point(11, 159);
            this.jp.Margin = new System.Windows.Forms.Padding(2);
            this.jp.Name = "jp";
            this.jp.Size = new System.Drawing.Size(167, 24);
            this.jp.TabIndex = 21;
            this.jp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keluar_KeyPress);
            // 
            // ket
            // 
            this.ket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ket.Location = new System.Drawing.Point(11, 80);
            this.ket.Margin = new System.Windows.Forms.Padding(2);
            this.ket.Multiline = true;
            this.ket.Name = "ket";
            this.ket.Size = new System.Drawing.Size(167, 53);
            this.ket.TabIndex = 21;
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.batal);
            this.panel2.Controls.Add(this.simpan);
            this.panel2.Location = new System.Drawing.Point(8, 231);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 36);
            this.panel2.TabIndex = 29;
            // 
            // frmTmbPotongan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(211, 274);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTmbPotongan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tambah Potongan";
            this.Load += new System.EventHandler(this.frmTmbPotongan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox jp;
        private System.Windows.Forms.TextBox ket;
        private System.Windows.Forms.Button batal;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textnama;
    }
}
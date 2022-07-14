
namespace RsrrPayroll
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gajiPokokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tunjanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karyawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jabatanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bagianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intensifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penggajianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slipGajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tgl = new System.Windows.Forms.ToolStripStatusLabel();
            this.wlc = new System.Windows.Forms.ToolStripStatusLabel();
            this.jam = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.dashboardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gajiPokokToolStripMenuItem,
            this.tunjanganToolStripMenuItem,
            this.karyawanToolStripMenuItem,
            this.jabatanToolStripMenuItem,
            this.bagianToolStripMenuItem,
            this.profesiToolStripMenuItem,
            this.intensifToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // gajiPokokToolStripMenuItem
            // 
            this.gajiPokokToolStripMenuItem.Name = "gajiPokokToolStripMenuItem";
            this.gajiPokokToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.gajiPokokToolStripMenuItem.Text = "Gaji Pokok";
            this.gajiPokokToolStripMenuItem.Click += new System.EventHandler(this.gajiPokokToolStripMenuItem_Click);
            // 
            // tunjanganToolStripMenuItem
            // 
            this.tunjanganToolStripMenuItem.Name = "tunjanganToolStripMenuItem";
            this.tunjanganToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.tunjanganToolStripMenuItem.Text = "Tunjangan";
            this.tunjanganToolStripMenuItem.Click += new System.EventHandler(this.tunjanganToolStripMenuItem_Click);
            // 
            // karyawanToolStripMenuItem
            // 
            this.karyawanToolStripMenuItem.Name = "karyawanToolStripMenuItem";
            this.karyawanToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.karyawanToolStripMenuItem.Text = "Karyawan";
            this.karyawanToolStripMenuItem.Click += new System.EventHandler(this.karyawanToolStripMenuItem_Click);
            // 
            // jabatanToolStripMenuItem
            // 
            this.jabatanToolStripMenuItem.Name = "jabatanToolStripMenuItem";
            this.jabatanToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.jabatanToolStripMenuItem.Text = "Jabatan";
            this.jabatanToolStripMenuItem.Click += new System.EventHandler(this.jabatanToolStripMenuItem_Click);
            // 
            // bagianToolStripMenuItem
            // 
            this.bagianToolStripMenuItem.Name = "bagianToolStripMenuItem";
            this.bagianToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.bagianToolStripMenuItem.Text = "Bagian";
            this.bagianToolStripMenuItem.Click += new System.EventHandler(this.bagianToolStripMenuItem_Click);
            // 
            // profesiToolStripMenuItem
            // 
            this.profesiToolStripMenuItem.Name = "profesiToolStripMenuItem";
            this.profesiToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.profesiToolStripMenuItem.Text = "Profesi";
            this.profesiToolStripMenuItem.Click += new System.EventHandler(this.profesiToolStripMenuItem_Click);
            // 
            // intensifToolStripMenuItem
            // 
            this.intensifToolStripMenuItem.Name = "intensifToolStripMenuItem";
            this.intensifToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.intensifToolStripMenuItem.Text = "Insentif";
            this.intensifToolStripMenuItem.Click += new System.EventHandler(this.intensifToolStripMenuItem_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penggajianToolStripMenuItem});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(73, 22);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // penggajianToolStripMenuItem
            // 
            this.penggajianToolStripMenuItem.Name = "penggajianToolStripMenuItem";
            this.penggajianToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.penggajianToolStripMenuItem.Text = "Penggajian";
            this.penggajianToolStripMenuItem.Click += new System.EventHandler(this.penggajianToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slipGajiToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // slipGajiToolStripMenuItem
            // 
            this.slipGajiToolStripMenuItem.Name = "slipGajiToolStripMenuItem";
            this.slipGajiToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.slipGajiToolStripMenuItem.Text = "Slip Gaji";
            this.slipGajiToolStripMenuItem.Click += new System.EventHandler(this.slipGajiToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tgl,
            this.wlc,
            this.jam});
            this.statusStrip1.Location = new System.Drawing.Point(0, 549);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tgl
            // 
            this.tgl.Name = "tgl";
            this.tgl.Size = new System.Drawing.Size(416, 17);
            this.tgl.Spring = true;
            this.tgl.Text = "tanggal";
            // 
            // wlc
            // 
            this.wlc.Name = "wlc";
            this.wlc.Size = new System.Drawing.Size(416, 17);
            this.wlc.Spring = true;
            this.wlc.Text = "welcome";
            // 
            // jam
            // 
            this.jam.Name = "jam";
            this.jam.Size = new System.Drawing.Size(416, 17);
            this.jam.Spring = true;
            this.jam.Text = "jam";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 571);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MdiChildActivate += new System.EventHandler(this.Form1_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gajiPokokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tunjanganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem karyawanToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tgl;
        private System.Windows.Forms.ToolStripStatusLabel wlc;
        private System.Windows.Forms.ToolStripStatusLabel jam;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem jabatanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bagianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penggajianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intensifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slipGajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
    }
}


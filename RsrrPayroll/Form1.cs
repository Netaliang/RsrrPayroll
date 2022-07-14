using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RsrrPayroll
{
    public partial class Form1 : Form
    {
        dashboard dh;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            tgl.Text = DateTime.Now.ToLongDateString();
            jam.Text = DateTime.Now.ToLongTimeString();
            wlc.Text = app.user + "[" + app.role + "]";

            //picBox.Location = new Point(
            //    this.ClientSize.Width / 2 - picBox.Size.Width / 2,
            //    this.ClientSize.Height / 2 - picBox.Size.Height / 2);
            //picBox.Anchor = AnchorStyles.None;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tgl.Text = DateTime.Now.ToLongDateString();
            jam.Text = DateTime.Now.ToLongTimeString();
        }

        private void gajiPokokToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool open = false;

            foreach (Form frm in this.MdiChildren)
            {
                //iterate through
                if (frm.Name == "frmGajiPokok")
                {
                    if(frm.WindowState == FormWindowState.Minimized)
                    {
                        frm.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        frm.BringToFront();
                    }
                    open = true;
                    break;
                }
                
            }


            if (open == false)
            {
                //if (dh != null)
                //{
                //    dh.Close();

                //}
                frmGajiPokok gp = new frmGajiPokok();
                gp.MdiParent = this;
                gp.WindowState = FormWindowState.Maximized;

                gp.Show();
            }

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            tgl.Text = DateTime.Now.ToLongDateString();
            jam.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (app.role == "ADMIN")
            {
                masterToolStripMenuItem.Visible = true;
                transaksiToolStripMenuItem.Visible = true;
                reportToolStripMenuItem.Visible = true;
            }
            else
            {
                masterToolStripMenuItem.Visible = false;
                transaksiToolStripMenuItem.Visible = true;
                reportToolStripMenuItem.Visible = false;
            }
            dh = new dashboard();

            dh.MdiParent = this;
            dh.WindowState = FormWindowState.Maximized;
            //dh.ControlBox = false;
            //dh.MaximizeBox = false;
            //dh.MinimizeBox = false;
            dh.Show();
            //foreach (Control ctl in this.Controls)
            //{
            //    try
            //    {
            //       Control Mdi = (MdiClient)ctl;

            //        Mdi.BackColor = Color.White;
            //    }
            //    catch (Exception a)
            //    {
            //    }
            //}
        }

        private void tunjanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;

            foreach (Form frm in this.MdiChildren)
            {
                //iterate through
                if (frm.Name == "frmTunjangan")
                {
                    if (frm.WindowState == FormWindowState.Minimized)
                    {
                        frm.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        frm.BringToFront();
                    }
                    open = true;
                    break;
                }

            }


            if (open == false)
            {
                //if (dh != null)
                //{
                //    dh.Close();

                //}

                frmTunjangan tj = new frmTunjangan();
                tj.MdiParent = this;
                tj.WindowState = FormWindowState.Maximized;

                tj.Show();
            }
        }

        private void jabatanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;

            foreach (Form frm in this.MdiChildren)
            {
                //iterate through
                if (frm.Name == "frmJabatan")
                {
                    if (frm.WindowState == FormWindowState.Minimized)
                    {
                        //frm.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        frm.BringToFront();
                    }
                    open = true;
                    break;
                }

            }


            if (open == false)
            {
                //if (dh != null)
                //{
                //    dh.Close();

                //}
                frmJabatan jb = new frmJabatan();
                jb.MdiParent = this;

                jb.Show();
            }
        }

        private void karyawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;

            foreach (Form frm in this.MdiChildren)
            {
                //iterate through
                if (frm.Name == "frmKaryawan")
                {
                    if (frm.WindowState == FormWindowState.Minimized)
                    {
                        frm.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        frm.BringToFront();
                    }
                    open = true;
                    break;
                }

            }


            if (open == false)
            {
                //if (dh != null)
                //{
                //    dh.Close();

                //}
                frmKaryawan kw = new frmKaryawan();
                kw.MdiParent = this;
                kw.WindowState = FormWindowState.Maximized;


                kw.Show();
            }
        }

        private void bagianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;

            foreach (Form frm in this.MdiChildren)
            {
                //iterate through
                if (frm.Name == "frmBagian")
                {
                    if (frm.WindowState == FormWindowState.Minimized)
                    {
                        frm.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        frm.BringToFront();
                    }
                    open = true;
                    break;
                }

            }


            if (open == false)
            {
                //if (dh != null)
                //{
                //    dh.Close();

                //}
                frmBagian bg = new frmBagian();
                bg.MdiParent = this;


                bg.Show();
            }
        }

        private void profesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;

            foreach (Form frm in this.MdiChildren)
            {
                //iterate through
                if (frm.Name == "frmProfesi")
                {
                    if (frm.WindowState == FormWindowState.Minimized)
                    {
                        frm.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        frm.BringToFront();
                    }
                    open = true;
                    break;
                }

            }


            if (open == false)
            {
                //if (dh != null)
                //{
                //    dh.Close();

                //}
                frmProfesi bg = new frmProfesi();
                bg.MdiParent = this;

                bg.Show();
            }
        }

        private void penggajianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;

            foreach (Form frm in this.MdiChildren)
            {
                //iterate through
                if (frm.Name == "frmPilihKaryawan")
                {
                    if (frm.WindowState == FormWindowState.Minimized)
                    {
                        frm.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        frm.BringToFront();
                    }
                    open = true;
                    break;
                }

            }


            if (open == false)
            {
                //if (dh != null)
                //{
                //    dh.Close();

                //}
                frmPilihKaryawan p = new frmPilihKaryawan();
                p.MdiParent = this;
                p.WindowState = FormWindowState.Maximized;


                p.Show();
            }
        }

        private void intensifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;

            foreach (Form frm in this.MdiChildren)
            {
                //iterate through
                if (frm.Name == "frmIntensif")
                {
                    if (frm.WindowState == FormWindowState.Minimized)
                    {
                        frm.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        frm.BringToFront();
                    }
                    open = true;
                    break;
                }

            }


            if (open == false)
            {
                //if (dh != null)
                //{
                //    dh.Close();

                //}
                frmIntensif tj = new frmIntensif();
                tj.MdiParent = this;
                tj.WindowState = FormWindowState.Maximized;

                tj.Show();
            }
        }

        private void slipGajiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCetakSlip bg = new frmCetakSlip();


            bg.ShowDialog();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool open = false;
            

            foreach (Form frm in this.MdiChildren)
            {
                //iterate through
                if (frm.Name == "dashboard")
                {
                    if (frm.WindowState == FormWindowState.Minimized)
                    {
                        frm.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        frm.BringToFront();
                    }
                    open = true;
                    break;
                }

            }


            if (open == false)
            {
                dh = new dashboard();

                dh.MdiParent = this;
                dh.WindowState = FormWindowState.Maximized;
                dh.Show();
            }
           
        }

        private void Form1_MdiChildActivate(object sender, EventArgs e)
        {
            //app.info(this.MdiChildren.Length.ToString());
        }
    }
}

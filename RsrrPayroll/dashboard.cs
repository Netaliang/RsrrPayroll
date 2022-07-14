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
    public partial class dashboard : Form
    {
        string[] hari = { "Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu" };
        string[] bulan = { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "Nopember", "Desember" };

      
        public dashboard()
        {
            InitializeComponent();
            label1.Text = hari[(int)DateTime.Today.DayOfWeek] + ", " + DateTime.Now.Day.ToString() + " " + bulan[DateTime.Today.Month] + " " + DateTime.Now.Year.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            string period = DateTime.Now.Month.ToString("d2") + DateTime.Now.Year.ToString();

            jk.Text = db.count("select * from tbl_karyawan").ToString();
            jkt.Text = db.count("select * from tbl_karyawan where statusKaryawan='Training'").ToString();
            jkk.Text = db.count("select * from tbl_karyawan where statusKaryawan='Kontrak'").ToString();
            jko.Text = db.count("select * from tbl_karyawan where statusKaryawan='Outsourcing'").ToString();
            jktt.Text = db.count("select * from tbl_karyawan where statusKaryawan='Tetap'").ToString();
            string t = db.getValue("select sum(totalGaji) as total from tbl_penggajian where periodeGaji='" + period + "'", "total");
            if (t == "")
            {
                total.Text = "Rp.0";

            }
            else
            {
                total.Text = "Rp."+t.ToRupiah();

            }
            chart1.Series["Series1"].Points.AddXY("Laki-Laki", db.count("select * from tbl_karyawan where jk='L'"));
            chart1.Series["Series1"].Points.AddXY("Perepuan", db.count("select * from tbl_karyawan where jk='P'"));

            int sd = 0;
            int smp = 0;
            int sma = 0;
            int d1 = 0;
            int d2 = 0;
            int d3 = 0;
            int d4 = 0;
            int s1 = 0;
            int s2 = 0;

            DataTable tabel = db.get("select * from tbl_karyawan");


            foreach(DataRow row in tabel.Rows)
            {
                string p = db.getValue("select * from tbl_riwayatpendidikan where nik='"+row["nik"].ToString()+"' order by keluar desc", "jenjang");

                if (p == "SD")
                {
                    sd++;
                }else if (p == "SMP")
                {
                    smp++;
                }
                else if (p == "SMA/SMK")
                {
                    sma++;
                }
                else if (p == "D1")
                {
                    d1++;
                }
                else if (p == "D2")
                {
                    d2++;
                }
                else if (p == "D3")
                {
                    d3++;
                }
                else if (p == "D4")
                {
                    d4++;
                }
                else if (p == "S1")
                {
                    s1++;
                }
                else if (p == "S2")
                {
                    s2++;
                }
            }
            chart2.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart2.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chart2.Series["Pendidikan"].Points.AddXY("SD", sd);
            chart2.Series["Pendidikan"].Points[0].Color = Color.Green;

            chart2.Series["Pendidikan"].Points.AddXY("SMP", smp);
            chart2.Series["Pendidikan"].Points[1].Color = Color.Blue;

            chart2.Series["Pendidikan"].Points.AddXY("SMA/SMK", sma);
            chart2.Series["Pendidikan"].Points[2].Color = Color.Yellow;

            chart2.Series["Pendidikan"].Points.AddXY("D1", d1);
            chart2.Series["Pendidikan"].Points[3].Color = Color.Red;

            chart2.Series["Pendidikan"].Points.AddXY("D2", d2);
            chart2.Series["Pendidikan"].Points[4].Color = Color.Purple;

            chart2.Series["Pendidikan"].Points.AddXY("D3", d3);
            chart2.Series["Pendidikan"].Points[5].Color = Color.Magenta;

            chart2.Series["Pendidikan"].Points.AddXY("D4", d4);
            chart2.Series["Pendidikan"].Points[6].Color = Color.Pink;

            chart2.Series["Pendidikan"].Points.AddXY("S1", s1);
            chart2.Series["Pendidikan"].Points[7].Color = Color.BlueViolet;

            chart2.Series["Pendidikan"].Points.AddXY("S2", s2);
            chart2.Series["Pendidikan"].Points[8].Color = Color.Black;




        }
    }
}

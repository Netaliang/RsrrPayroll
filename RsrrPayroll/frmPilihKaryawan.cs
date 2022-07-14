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
    public partial class frmPilihKaryawan : Form
    {
        String[] masaKerja = { "0-3 bulan", "3-12 bulan", "1-3 tahun", ">3-6 tahun", ">6-9 tahun", ">9-12 tahun", ">12-15 tahun", ">15-18 tahun", ">18-21 tahun", ">22-25 tahun" };

        DataGridViewTextBoxColumn col;


        void showData()
        {
            list.view("select * from vw_karyawan where nik like '%" + cari.Text + "%' or nama like '%" + cari.Text + "%'  or profesi like '%" + cari.Text + "%' or Bagian like '%" + cari.Text + "%' order by seq asc");

        }

        void addedColumn()
        {
            col = new DataGridViewTextBoxColumn();
            col.Name = "m";
            col.HeaderText = "Masa Kerja";
            
            list.Columns.Add(col);

        }

        void loadColumn()
        {
            DataTable dt = db.get("select * from tbl_gajipokok");
            DataTable pend = db.get("select * from tbl_riwayatpendidikan");
            for (int i = 0; i < list.Rows.Count; i++)
            {
                //string p = db.getValue("select * from tbl_riwayatpendidikan where nik='" + list.Rows[i].Cells[0].Value + "' order by keluar desc", "jenjang");
                DataRow p = pend.Select("nik='" + list.Rows[i].Cells["nik"].Value.ToString() + "'","keluar desc").FirstOrDefault();
                DataRow dr = dt.Select("statusKaryawan='" + list.Rows[i].Cells["statusKaryawan"].Value.ToString() + "' and pendidikan='" + p["jenjang"].ToString() + "'").FirstOrDefault();
                list.Rows[i].Cells["m"].Value = masaKerja[Convert.ToInt32(dr["masaKerja"].ToString())];
            }
        }

        public frmPilihKaryawan()
        {
            InitializeComponent();
            showData();
            addedColumn();

            list.Columns[14].Visible = false;
            list.Columns[2].Visible = false;
            list.Columns[3].Visible = false;
            list.Columns[4].Visible = false;
            list.Columns[5].Visible = false;
            list.Columns[6].Visible = false;
            list.Columns[7].Visible = false;
            list.Columns[8].Visible = false;
            list.Columns[9].Visible = false;

            list.Columns[0].HeaderText = "NIK";
            list.Columns[1].HeaderText = "Nama";
            list.Columns[10].HeaderText = "Profesi";
            list.Columns[11].HeaderText = "Bagian";
            list.Columns[12].HeaderText = "Status Karyawan";
            list.Columns[13].HeaderText = "Status Kerja";
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            showData();
            loadColumn();
        }

        private void list_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.list.Columns[e.ColumnIndex].Name == "jk")
            {
                e.Value = e.Value.ToString() == "L" ? "LAKI - LAKI" : "PEREMPUAN";
            }
        }

        private void list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow d = list.Rows[e.RowIndex];
                frmPenggajian a = new frmPenggajian();
                a.nikParam = d.Cells["nik"].Value.ToString();
                a.namaParam = d.Cells["nama"].Value.ToString();
                a.profesiParam = d.Cells["profesi"].Value.ToString();
                a.statusKaryawanParam = d.Cells["statusKaryawan"].Value.ToString();
                a.bagianParam = d.Cells["Bagian"].Value.ToString();
                a.ShowDialog();
                if (a.DialogResult == DialogResult.Yes)
                {
                    showData();
                    loadColumn();
                }
            }
            catch (Exception ex)
            {
                //app.error(ex.ToString());
                list.ClearSelection();
            }
        }

        private void frmPilihKaryawan_Load(object sender, EventArgs e)
        {
            loadColumn();
        }
    }
}

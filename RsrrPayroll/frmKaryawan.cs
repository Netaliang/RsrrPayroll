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
    public partial class frmKaryawan : Form
    {
        public string id, nama = "";

        void showData()
        {
            list.view("select * from vw_karyawan where nik like '%" + cari.Text + "%' or nama like '%" + cari.Text + "%' or alamat like '%" + cari.Text + "%' or nohp like '%" + cari.Text + "%' or email like '%" + cari.Text + "%' or profesi like '%" + cari.Text + "%' or Bagian like '%" + cari.Text + "%' order by seq asc");

        }

        public frmKaryawan()
        {
            InitializeComponent();
            showData();

            list.Columns[14].Visible = false;
            list.Columns[0].HeaderText = "NIK";
            list.Columns[1].HeaderText = "Nama";
            list.Columns[2].HeaderText = "Tanggal Lahir";
            list.Columns[3].HeaderText = "Jenis Kelamin";
            list.Columns[4].HeaderText = "Alamat";
            list.Columns[5].HeaderText = "No Hp";
            list.Columns[6].HeaderText = "Email";
            list.Columns[7].HeaderText = "Status Pernikahan";
            list.Columns[8].HeaderText = "Jumlah Tanggungan";
            list.Columns[9].HeaderText = "Tanggal Masuk";
            list.Columns[10].HeaderText = "Profesi";
            list.Columns[11].HeaderText = "Bagian";
            list.Columns[12].HeaderText = "Status Karyawan";
            list.Columns[13].HeaderText = "Status Kerja";
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            showData();
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
                frmDataKaryawan a = new frmDataKaryawan();
                a.edit = true;
                a.nikParam = d.Cells["nik"].Value.ToString();
                a.ShowDialog();
                if (a.DialogResult == DialogResult.Yes)
                {
                    showData();
                }
            }
            catch (Exception ex)
            {
                list.ClearSelection();
            }
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            frmDataKaryawan a = new frmDataKaryawan();
            a.ShowDialog();
            if (a.DialogResult == DialogResult.OK)
            {
                showData();
            }
        }
    }
}

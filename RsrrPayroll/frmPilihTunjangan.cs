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
    public partial class frmPilihTunjangan : Form
    {

        public string id, nama,nominal,jenis = "";

        void showData()
        {
            list.view("select * from tbl_tunjangan where status='AKTIF' and periode like '%" + cari.Text + "%' or nama like '%" + cari.Text + "%' or jenis like '%" + cari.Text + "%'");
        }


        public frmPilihTunjangan()
        {
            InitializeComponent();
            showData();
            list.Columns[5].Visible = false;
            list.Columns[0].HeaderText = "ID";
            list.Columns[1].HeaderText = "Periode";
            list.Columns[2].HeaderText = "Nama Tunjangan";
            list.Columns[3].HeaderText = "Nominal";
            list.Columns[4].HeaderText = "Jenis";
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            showData();
        }

        private void list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow d = list.Rows[e.RowIndex];
                id = d.Cells["id"].Value.ToString();
                nama = d.Cells["nama"].Value.ToString();
                nominal = d.Cells["nominal"].Value.ToString();
                jenis = d.Cells["jenis"].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                list.ClearSelection();
            }
        }
    }
}

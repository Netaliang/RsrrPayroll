using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RsrrPayroll.Data;

namespace RsrrPayroll
{
    public partial class frmPilihJabatan : Form
    {

        public Jabatan data;

        private void cari_TextChanged(object sender, EventArgs e)
        {
            showData();
        }

        private void list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow d = list.Rows[e.RowIndex];
                data.id = d.Cells["id"].Value.ToString();
                data.nama = d.Cells["nama"].Value.ToString();
                data.tunjangan = d.Cells["idTunjangan"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                list.ClearSelection();
            }
        }

        void showData()
        {
            list.view("select * from tbl_jabatan where status='AKTIF' and nama like '%" + cari.Text + "%'");
        }

        public frmPilihJabatan()
        {
            InitializeComponent();
            data = new Jabatan();
            showData();
            list.Columns[2].Visible = false;
            list.Columns[3].Visible = false;
            list.Columns[0].HeaderText = "ID";
            list.Columns[1].HeaderText = "Nama";
        }
    }
}

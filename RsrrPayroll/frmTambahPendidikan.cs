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
    public partial class frmTambahPendidikan : Form
    {
        public Pendidikan data;

        public frmTambahPendidikan()
        {
            InitializeComponent();
            data = new Pendidikan();
        }

        private void batal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void masuk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.numberOnly();
        }

        private void keluar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.numberOnly();
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            data.nama = nama.Text;
            data.jenjang = jenjang.SelectedItem.ToString();
            data.masuk = Convert.ToInt32(masuk.Text);
            data.keluar = Convert.ToInt32(keluar.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

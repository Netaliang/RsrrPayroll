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
    public partial class frmTmbPotongan : Form
    {
        public string potongan,keterangan,nominal="";

        public frmTmbPotongan()
        {
            InitializeComponent();
            //textnama.Focus();

        }

        private void keluar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.numberOnly();
        }

        private void frmTmbPotongan_Load(object sender, EventArgs e)
        {
            textnama.Select();

        }

        private void batal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            if (panel1.valid())
            {
                app.warn("Mohon Lengkapi Data");
            }
            else
            {
                potongan = textnama.Text;
                keterangan = ket.Text;
                nominal = jp.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

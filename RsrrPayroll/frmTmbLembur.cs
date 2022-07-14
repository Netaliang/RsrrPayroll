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
    public partial class frmTmbLembur : Form
    {
        public string keterangan= "";
        public int nominal=0;

        private void jp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.numberOnly();
        }

        private void frmTmbLembur_Load(object sender, EventArgs e)
        {
            ket.Select();
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
                keterangan = ket.Text;
                nominal = Convert.ToInt32(jp.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public frmTmbLembur()
        {
            InitializeComponent();
        }
    }
}

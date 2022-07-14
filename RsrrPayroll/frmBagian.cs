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
    public partial class frmBagian : Form
    {
        void showData()
        {
            list.view("select * from tbl_bagian order by id asc");
        }

        string id()
        {
            return db.idBagian();
        }

        public frmBagian()
        {
            InitializeComponent();
            showData();
            list.ClearSelection();
        }

        private void batal_Click(object sender, EventArgs e)
        {
            showData();
            panel.clear();
            list.ClearSelection();
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            if (panel.valid())
            {
                app.warn("Moohon Lengkapi Input Data Bagian");
            }
            else
            {
                if (app.question("Tambahkan Bagian?"))
                {
                    string idBG = id();
                    if (db.query("Insert into tbl_bagian values('" + idBG + "','" + nama.Text + "')"))
                    {
                        app.info("Berhasil Menambahkan Bagian ");
                        panel.clear();
                        showData();
                        list.ClearSelection();
                    }
                }
                else
                {
                    app.info("Batal Menambahkan Bagian");
                    panel.clear();
                    showData();
                    list.ClearSelection();
                }
            }
        }
    }
}

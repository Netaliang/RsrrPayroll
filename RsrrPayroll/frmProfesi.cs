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
    public partial class frmProfesi : Form
    {

        void showData()
        {
            list.view("select * from tbl_profesi order by id asc");
        }

        string id()
        {
            return db.idProfesi();
        } 
        public frmProfesi()
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
                app.warn("Moohon Lengkapi Input Data Profesi");
            }
            else
            {
                if (app.question("Tambahkan Profesi?"))
                {
                    string idBG = id();
                    if (db.query("Insert into tbl_profesi values('" + idBG + "','" + nama.Text + "')"))
                    {
                        app.info("Berhasil Menambahkan Profesi ");
                        panel.clear();
                        showData();
                        list.ClearSelection();
                    }
                }
                else
                {
                    app.info("Batal Menambahkan Profesi");
                    panel.clear();
                    showData();
                    list.ClearSelection();
                }
            }
        }
    }
}

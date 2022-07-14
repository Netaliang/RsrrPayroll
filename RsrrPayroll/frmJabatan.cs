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
    public partial class frmJabatan : Form
    {
        DataGridViewComboBoxColumn cbx;
        string idSelected = "";

        void showData()
        {
            list.view("select * from tbl_jabatan order by id asc");
        }

        void combo()
        {
            cbx = new DataGridViewComboBoxColumn();
            cbx.Name = "action";
            cbx.HeaderText = "Action";
            cbx.FlatStyle = FlatStyle.Flat;
            cbx.Items.Add("AKTIF");
            cbx.Items.Add("NONAKTIF");
            list.Columns.Add(cbx);

        }

        void loadCombo()
        {

            for (int i = 0; i < list.Rows.Count; i++)
            {

                list.Rows[i].Cells["action"].Value = list.Rows[i].Cells["status"].Value;
            }
        }

        string id()
        {

            return db.idJabatan();

        }

        public frmJabatan()
        {
            InitializeComponent();
            showData();
            combo();

            list.ClearSelection();

            hapus.off();
            list.Columns[3].Visible = false;
            list.Columns[0].HeaderText = "ID";
            list.Columns[1].HeaderText = "Nama Jabatan";
            list.Columns[2].HeaderText = "Tunjangan";
        }

        private void frmJabatan_Load(object sender, EventArgs e)
        {
            loadCombo();
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            if(db.count("select * from tbl_rincianjabatan where idjabatan='" + idSelected + "'") == 0)
            {
                if (app.question("Hapus Jabatan ?"))
                {
                    if (db.query("delete from tbl_jabatan where id='" + idSelected + "'"))
                    {
                        app.info("Hapus Jabatan Berhasil");
                        showData();
                        loadCombo();
                        panel.clear();
                        hapus.off();
                        app.enabled(new List<Control> { nama, pilih, tambah }, true);
                        list.ClearSelection();
                    }
                }
            }
            else
            {
                app.warn("Data Tidak Dapat Dihapus");
            }
            
        }

        private void batal_Click(object sender, EventArgs e)
        {
            showData();
            loadCombo();
            panel.clear();
            hapus.off();
            app.enabled(new List<Control> {nama, pilih, tambah }, true);
            list.ClearSelection();
        }

        private void list_Sorted(object sender, EventArgs e)
        {
            loadCombo();
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            if (panel.valid())
            {
                app.warn("Moohon Lengkapi Input Data Jabatan");
            }
            else
            {
                if (app.question("Tambahkan Jabatan?"))
                {
                    string idJB = id();
                    if (db.query("Insert into tbl_jabatan values('" + idJB + "','" + nama.Text + "','" + tj.Text.Split('-')[0] + "','AKTIF')"))
                    {
                        app.info("Berhasil Menambahkan Jabatan ");
                        panel.clear();
                        showData();
                        loadCombo();
                    }
                }
                else
                {
                    app.info("Batal Menambahkan Jabatan");
                    panel.clear();
                    showData();
                    loadCombo();
                }
            }
        }

        private void list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow d = list.Rows[e.RowIndex];
                idSelected = d.Cells["id"].Value.ToString();
                hapus.on();
                app.enabled(new List<Control> { nama, pilih, tambah }, false);
            }
            catch (Exception ex)
            {
                loadCombo();
            }
        }

        private void list_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.list.Columns[e.ColumnIndex].Name == "idTunjangan")
            {
                e.Value = db.getValue("select * from tbl_tunjangan where id='"+e.Value.ToString()+"'","nominal").ToRupiah();
            }
        }

        private void list_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                ComboBox com = (ComboBox)(e.Control);
                com.SelectionChangeCommitted -= status;
                com.SelectionChangeCommitted += status;
            }
            catch (Exception ex)
            {
            }
        }

        private void status(object sender, EventArgs e)
        {
            try
            {
                ComboBox com = (ComboBox)sender;
                if (app.question(com.Text.ToLower() + "kan?"))
                {
                    if (db.query("update tbl_jabatan set status='" + com.Text.ToUpper() + "' where id='" + idSelected + "'"))
                    {
                        showData();
                        loadCombo();

                        hapus.off();
                        app.enabled(new List<Control> {nama, pilih, tambah }, true);
                    }
                }

            }
            catch (Exception ex)
            {
                app.error(ex.ToString());
            }
        }

        private void pilih_Click(object sender, EventArgs e)
        {
            frmPilihTunjangan a = new frmPilihTunjangan();
            a.ShowDialog();
            if (a.DialogResult == DialogResult.OK)
            {
                tj.Text = a.id + "-" + a.nama;
            }
        }


        //Pilih Tunjangan
    }
}

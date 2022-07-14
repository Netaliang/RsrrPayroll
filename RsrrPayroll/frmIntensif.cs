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
    public partial class frmIntensif : Form
    {

        DataGridViewComboBoxColumn cbx;
        string idSelected = "";


        void fillComboTahun()
        {

            int mulai = 2015;
            int now = DateTime.Now.Year;
            tahun.Items.Add(mulai);


            while (mulai != now)
            {
                mulai++;
                tahun.Items.Add(mulai);
            }
        }

        void showData()
        {
            list.view("select * from tbl_intensif order by id asc");
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

            return db.idIntensif();

        }

        public frmIntensif()
        {
            InitializeComponent();
            fillComboTahun();
            showData();
            combo();

            list.ClearSelection();

            hapus.off();
            list.Columns[5].Visible = false;
            list.Columns[0].HeaderText = "ID";
            list.Columns[1].HeaderText = "Periode";
            list.Columns[2].HeaderText = "Nama Insentif";
            list.Columns[3].HeaderText = "Nominal";
            list.Columns[4].HeaderText = "Jenis";
        }

        private void frmIntensif_Load(object sender, EventArgs e)
        {
            loadCombo();
        }

        private void nominal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.numberOnly();
        }

        private void nominal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (nominal.Text != "")
                {
                    nominal.Text = string.Format("{0:n0}", double.Parse(nominal.Text));
                    nominal.SelectionStart = nominal.Text.Length;
                }
                else
                {
                    //textBox4.Clear();
                    //textBox4.Text.Substring(textBox4.Text.Length-1);
                }
            }
            catch
            {


            }
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            if(db.count("select * from tbl_rincianintensif where idIntensif='" + idSelected + "'") == 0)
            {
                if (app.question("Hapus Insentif ?"))
                {
                    if (db.query("delete from tbl_intensif where id='" + idSelected + "'"))
                    {
                        app.info("Hapus Insentif Berhasil");
                        showData();
                        loadCombo();
                        periode.clear();
                        panel.clear();
                        hapus.off();
                        periode.on();
                        app.enabled(new List<Control> { jenis, nama, nominal, tambah }, true);
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
            periode.clear();
            panel.clear();
            hapus.off();
            periode.on();
            app.enabled(new List<Control> { jenis, nama, nominal, tambah }, true);
            list.ClearSelection();
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            if (periode.valid())
            {
                app.warn("Mohon Lengkapi Input Periode");
            }
            else if (panel.valid())
            {
                app.warn("Moohon Lengkapi Input Data Insentif");
            }
            else
            {
                if (app.question("Tambahkan Insentif?"))
                {
                    string period = bulan.SelectedItem.ToString() + tahun.SelectedItem.ToString();

                    string idIntensif = id();
                    if (db.query("Insert into tbl_intensif values('" + idIntensif + "','" + period + "','" + nama.Text + "','" + nominal.Text.ToAngka() + "','" + jenis.SelectedItem.ToString() + "','AKTIF')"))
                    {
                        //db.query("update tbl_gajipokok set statusgaji='NONAKTIF' where statuskaryawan='" + kat + "' and pendidikan='" + pend + "'");

                        app.info("Berhasil Menambahkan Insentif ");
                        periode.clear();
                        panel.clear();
                        showData();
                        loadCombo();
                    }
                }
                else
                {
                    app.info("Batal Menambahkan Insentif");
                    periode.clear();
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
                periode.off();
                app.enabled(new List<Control> { jenis, nama, nominal, tambah }, false);
            }
            catch (Exception ex)
            {
                loadCombo();
            }
        }

        private void list_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.list.Columns[e.ColumnIndex].Name == "nominal")
            {
                e.Value = e.Value.ToString().ToRupiah();
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
                    if (db.query("update tbl_intensif set status='" + com.Text.ToUpper() + "' where id='" + idSelected + "'"))
                    {
                        showData();
                        loadCombo();

                        hapus.off();
                        periode.on();
                        app.enabled(new List<Control> { jenis, nama, nominal, tambah }, true);
                    }
                }

            }
            catch (Exception ex)
            {
                app.error(ex.ToString());
            }
        }

        private void list_Sorted(object sender, EventArgs e)
        {
            loadCombo();
        }
    }
}

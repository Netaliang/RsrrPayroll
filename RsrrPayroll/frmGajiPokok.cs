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
    public partial class frmGajiPokok : Form
    {
        String[] masaKerja = { "0-3 bulan","3-12 bulan","1-3 tahun",">3-6 tahun",">6-9 tahun",">9-12 tahun",">12-15 tahun",">15-18 tahun",">18-21 tahun",">22-25 tahun" };
        DataGridViewComboBoxColumn cbx;
        string idSelected = "";
        //string pend = "";
        //string kat = "";

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
            list.view("select * from tbl_gajiPokok order by id asc");
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

                list.Rows[i].Cells["action"].Value = list.Rows[i].Cells["statusgaji"].Value;
            }
        }

        string id(string p,string j)
        {
            

            return db.idGaji(p, j);

        }

        public frmGajiPokok()
        {
            InitializeComponent();
            fillComboTahun();
            showData();
            combo();

            list.ClearSelection();

            hapus.off();
            list.Columns[6].Visible = false;
            list.Columns[0].HeaderText = "ID";
            list.Columns[1].HeaderText = "Periode";
            list.Columns[2].HeaderText = "Status Karyawan";
            list.Columns[3].HeaderText = "Masa Kerja";
            list.Columns[4].HeaderText = "Pendidikan";
            list.Columns[5].HeaderText = "Gaji";
        }

        private void gaji_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.numberOnly();
        }

        private void gaji_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (gaji.Text != "")
                {
                    gaji.Text = string.Format("{0:n0}", double.Parse(gaji.Text));
                    gaji.SelectionStart = gaji.Text.Length;
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
            if(db.count("select * from tbl_penggajian where idGajiPokok='"+ idSelected + "'") == 0) 
            {
                if (app.question("Hapus Gaji ?"))
                {
                    if (db.query("delete from tbl_gajipokok where id='" + idSelected + "'"))
                    {
                        app.info("Hapus Gaji Berhasil");
                        showData();
                        loadCombo();
                        periode.clear();
                        panel.clear();
                        hapus.off();
                        periode.on();
                        app.enabled(new List<Control> { jenis, masa, pendidikan, gaji, tambah }, true);
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
            app.enabled(new List<Control> { jenis,masa,pendidikan,gaji,tambah }, true);
            list.ClearSelection();
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            if (periode.valid())
            {
                app.warn("Mohon Lengkapi Input Periode");
            }
            else if(panel.valid())
            {
                app.warn("Moohon Lengkapi Input Data Gaji");
            }
            else
            {
                if (app.question("Tambahkan Gaji?"))
                {
                    string period = bulan.SelectedItem.ToString() + tahun.SelectedItem.ToString();

                    string idGaji = id(pendidikan.SelectedItem.ToString(), jenis.SelectedItem.ToString());
                    if (db.query("Insert into tbl_gajipokok values('" + idGaji + "','" + period + "','" + jenis.SelectedItem.ToString() + "','" + masa.SelectedIndex + "','" + pendidikan.SelectedItem.ToString() + "','" + gaji.Text.ToAngka() + "','AKTIF')"))
                    {
                        //db.query("update tbl_gajipokok set statusgaji='NONAKTIF' where statuskaryawan='" + kat + "' and pendidikan='" + pend + "'");

                        app.info("Berhasil Menambahkan Gaji ");
                        periode.clear();
                        panel.clear();
                        showData();
                        loadCombo();
                    }
                }
                else
                {
                    app.info("Batal Menambahkan Gaji");
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
                //pend = d.Cells["pendidikan"].Value.ToString();
                //kat = d.Cells["statuskaryawan"].Value.ToString();
                hapus.on();
                periode.off();
                app.enabled(new List<Control> { jenis, masa, pendidikan, gaji, tambah }, false);
            }
            catch (Exception ex)
            {
                loadCombo();
            }

        }

        private void list_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (this.list.Columns[e.ColumnIndex].Index == 4)
            {
                int a = Convert.ToInt32(e.Value);
                e.Value = masaKerja[a];
            }

            if (this.list.Columns[e.ColumnIndex].Name == "gaji")
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
                if (app.question(com.Text.ToLower()+"kan?"))
                {
                    //app.info(pend + " " + kat);
                    //db.query("update tbl_gajipokok set statusgaji='NONAKTIF' where statuskaryawan='" + kat + "' and pendidikan='" + pend + "'");
                    if (db.query("update tbl_gajipokok set statusgaji='" + com.Text.ToUpper() + "' where id='" + idSelected + "'"))
                    {
                        showData();
                        loadCombo();

                        hapus.off();
                        periode.on();
                        app.enabled(new List<Control> { jenis, masa, pendidikan, gaji, tambah }, true);
                    }
                }

            }
            catch (Exception ex)
            {
                app.error(ex.ToString());
            }
        }

        private void frmGajiPokok_Load(object sender, EventArgs e)
        {
            loadCombo();
        }

        private void list_Sorted(object sender, EventArgs e)
        {
            loadCombo();
        }
    }
}

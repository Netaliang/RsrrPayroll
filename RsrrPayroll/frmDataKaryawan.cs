using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RsrrPayroll.Data;

namespace RsrrPayroll
{
    public partial class frmDataKaryawan : Form
    {
        public string nikParam = "";
        public bool edit = false;
        private DataTable pendidikan;
        private DataTable jabatan;

        private List<Pendidikan> listP;
        private List<Jabatan> listJ;

        private List<string> deletedP;
        private List<Jabatan> deletedJ;

        private List<string> defP;
        private List<string> defJ;

        private string paramPendidikan = "";
        private string paramJabatan = "";

        void GenTablePendidikan()
        {
            pendidikan = new DataTable();
            pendidikan.Columns.Add("Jenjang");
            pendidikan.Columns.Add("Instansi");
            pendidikan.Columns.Add("Masuk");
            pendidikan.Columns.Add("Keluar");
            listPendidikan.DataSource = pendidikan;
            listPendidikan.AllowUserToAddRows = false;
            listPendidikan.AllowUserToDeleteRows = false;
            listPendidikan.AllowUserToOrderColumns = false;
            listPendidikan.Columns[0].HeaderText = "Jenjang Pendidikan";
            listPendidikan.Columns[1].HeaderText = "Nama Sekolah";
            listPendidikan.Columns[2].HeaderText = "Tahun Masuk";
            listPendidikan.Columns[3].HeaderText = "Tahun Keluar";
        }

        void GenTableJabatan()
        {
            jabatan = new DataTable();
            jabatan.Columns.Add("ID");
            jabatan.Columns.Add("Nama");
            jabatan.Columns.Add("tunjangan");
            listJabatan.DataSource = jabatan;
            listJabatan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listJabatan.AllowUserToAddRows = false;
            listJabatan.AllowUserToDeleteRows = false;
            listJabatan.AllowUserToOrderColumns = false;
            listJabatan.Columns[2].Visible = false;
            listJabatan.Columns[0].HeaderText = "ID Jabatan";
            listJabatan.Columns[1].HeaderText = "Nama Jabatan";
          
        }

        void def()
        {
            hapusJabatan.off();
            hapusPend.off();
            listJabatan.ClearSelection();
            listPendidikan.ClearSelection();
            nama.Focus();
            tmbJab.on();
            tmbPend.on();
        }

        string id()
        {
            string hbd = tgllhr.Value.Year.ToString() + tgllhr.Value.Month.ToString("d2") + tgllhr.Value.Day.ToString("d2");
            string masuk = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString("d2");
            string jkel = "PEREMPUAN";
            if(jk.SelectedItem.ToString()== "PEREMPUAN")
            {
                jkel = "2";
            }
            else
            {
                jkel = "1";
            }

            return db.nik(hbd, masuk, jkel);
        }

        int seq()
        {
            DataTable kar = db.get("select * from tbl_karyawan order by seq desc");

            if (kar.Rows.Count == 0)
            {
                return 1;
            }
            else
            {
                return Convert.ToInt32(kar.Rows[0][14]) + 1;
            }
        }

        void editMode()
        {
            nik.Text = nikParam;
            DataTable k = db.get("select * from tbl_karyawan where nik='" + nikParam + "'");
            nama.Text = k.Rows[0]["nama"].ToString();
            DateTime recTime = Convert.ToDateTime(Convert.ToDateTime(k.Rows[0]["tgllhr"]).ToString("yyyy-MM-dd HH:mm:ss"));
            tgllhr.Value = DateTime.ParseExact(recTime.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            jk.SelectedItem = k.Rows[0]["jk"].ToString() == "L" ? "LAKI - LAKI" : "PEREMPUAN";
            alamat.Text = k.Rows[0]["alamat"].ToString();
            nohp.Text = k.Rows[0]["nohp"].ToString();
            email.Text = k.Rows[0]["email"].ToString();
            jTanggungan.Value = Convert.ToInt32(k.Rows[0]["jumlahTanggungan"].ToString());
            statusPernikahan.SelectedItem = k.Rows[0]["statusPernikahan"].ToString();
            statusKaryawan.SelectedItem = k.Rows[0]["statusKaryawan"].ToString();
            statusKerja.SelectedItem = k.Rows[0]["statusKerja"].ToString();
            bagian.view("select * from tbl_bagian", "nama", "id");
            profesi.view("select * from tbl_profesi", "nama", "id");
            bagian.SelectedValue = k.Rows[0]["idBagian"].ToString();
            profesi.SelectedValue = k.Rows[0]["idProfesi"].ToString();

            DataTable p = db.get("select * from tbl_riwayatpendidikan where nik='" + nikParam + "'");
            foreach(DataRow row in p.Rows)
            {
                defP.Add(row[2].ToString());
                pendidikan.Rows.Add(row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
            }

            DataTable j = db.get("select * from vw_jabatan where nik='" + nikParam + "'");
            foreach (DataRow row in j.Rows)
            {
                defJ.Add(row[2].ToString());
                jabatan.Rows.Add(row[2].ToString(), row[3].ToString(), row[4].ToString());
            }

        }

        public frmDataKaryawan()
        {
            InitializeComponent();
            GenTablePendidikan();
            GenTableJabatan();
            def();
            defP = new List<string>();
            defJ = new List<string>();
        }

        private void tmbPend_Click(object sender, EventArgs e)
        {
            frmTambahPendidikan a = new frmTambahPendidikan();
            a.ShowDialog();
            if (a.DialogResult == DialogResult.OK)
            {
                Pendidikan data = a.data;

                int count = pendidikan.Select("Jenjang='" + data.jenjang + "'").Length;

                if(count == 0)
                {
                    pendidikan.Rows.Add(data.jenjang, data.nama, data.masuk, data.keluar);

                    if (edit == true)
                    {
                        listP.Add(data);

                        foreach(string dele in deletedP)
                        {
                            if (dele == data.jenjang)
                            {
                                deletedP.Remove(dele);
                                break;
                            }
                        }

                        foreach (string i in defP)
                        {
                            if (i == data.jenjang)
                            {
                                listP.Remove(data);
                                break;
                            }
                        }
                    }
                }
                else
                {
                    app.warn("Jenjang Pendidikan Sudah Ditambahkan");
                }

               
            }
        }

        private void tmbJab_Click(object sender, EventArgs e)
        {
            frmPilihJabatan a = new frmPilihJabatan();
            a.ShowDialog();
            if (a.DialogResult == DialogResult.OK)
            {
                Jabatan data = a.data;

                int count = jabatan.Select("ID='" + data.id + "'").Length;

                if (count == 0)
                {
                    jabatan.Rows.Add(data.id, data.nama, data.tunjangan);

                    if (edit == true)
                    {
                        listJ.Add(data);

                        foreach (Jabatan del in deletedJ)
                        {
                            if(del.id == data.id)
                            {
                                deletedJ.Remove(del);
                                break;
                            }
                        }

                        foreach (string i in defJ)
                        {
                            if (i == data.id)
                            {
                                listJ.Remove(data);
                                break;
                            }
                        }

                    }
                }
                else
                {
                    app.warn("Jabatan Sudah Ditambahkan");
                }

            }
        }

        private void nohp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.numberOnly();
        }

        private void batal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            this.Close();
        }

        private void simpan_Click(object sender, EventArgs e)
        {


            if(edit == false)
            {
                if (form.valid())
                {
                    app.warn("Mohon Priksa Dan Lengkapi Data Yang Kurang");
                }
                else if(pendidikan.Rows.Count==0)
                {
                    app.warn("Mohon Lengkapi Data Pendidikan");
                }
                else if (!email.Text.email())
                {
                    app.warn("Eamil Tidak Valid");
                }
                else
                {
                    if (app.question("Tambahkan Karyawan"))
                    {
                        try
                        {

                            string idKar = id();
                            
                            if (db.query("Insert into tbl_karyawan values('" + idKar + "','" +nama.Text + "','" + tgllhr.Value.ToString("yyyy-MM-dd") + "','" + jk.SelectedItem.ToString().Substring(0,1) + "','" + alamat.Text + "','" + nohp.Text + "','" + email.Text + "','" + statusPernikahan.SelectedItem.ToString() + "','" + jTanggungan.Value.ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + profesi.SelectedValue.ToString() + "','" + bagian.SelectedValue.ToString() + "','" + statusKaryawan.SelectedItem.ToString() + "','" + statusKerja.SelectedItem.ToString() + "','" + seq().ToString() + "')"))
                            {
                                DataTable tunjangan = db.get("select * from tbl_tunjangan where jenis='Tetap'");

                                foreach(DataRow row in tunjangan.Rows)
                                {
                                    db.query("insert into tbl_rinciantunjangan(nik,idTunjangan) values('" + idKar + "','" + row["id"].ToString() + "')");

                                }

                                for (int i = 0; i < listPendidikan.Rows.Count; i++)
                                {
                                    db.query("insert into tbl_riwayatpendidikan(nik,jenjang,namasekolah,masuk,keluar) values('" + idKar + "','" + listPendidikan.Rows[i].Cells[0].Value.ToString() + "','" + listPendidikan.Rows[i].Cells[1].Value.ToString() + "','" + listPendidikan.Rows[i].Cells[2].Value.ToString() + "','" + listPendidikan.Rows[i].Cells[3].Value.ToString() + "')");
                                }

                                for (int i = 0; i < listJabatan.Rows.Count; i++)
                                {
                                    db.query("insert into tbl_rincianjabatan(nik,idjabatan) values('" + idKar + "','" + listJabatan.Rows[i].Cells[0].Value.ToString() + "')");
                                    db.query("insert into tbl_rinciantunjangan(nik,idTunjangan) values('" + idKar + "','" + listJabatan.Rows[i].Cells[2].Value.ToString() + "')");

                                }

                                app.info("Berhasil Menambahkan Karyawan ");
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            app.error(ex.ToString());
                            this.DialogResult = DialogResult.Yes;
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                if (form.valid())
                {
                    app.warn("Mohon Priksa Dan Lengkapi Data Yang Kurang");
                }
                else if (pendidikan.Rows.Count == 0)
                {
                    app.warn("Mohon Lengkapi Data Pendidikan");
                }
                else if (!email.Text.email())
                {
                    app.warn("Eamil Tidak Valid");
                }
                else
                {
                    if (app.question("Simpan Perubahan Data Karyawan"))
                    {
                        try
                        {
                            //if (db.query("Insert into tbl_karyawan values('" + idKar + "','" + nama.Text + "','" + tgllhr.Value.ToString("yyyy-MM-dd") + "','" + jk.SelectedItem.ToString().Substring(0, 1) + "','" + alamat.Text + "','" + nohp.Text + "','" + email.Text + "','" + statusPernikahan.SelectedItem.ToString() + "','" + jTanggungan.Value.ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + profesi.SelectedValue.ToString() + "','" + bagian.SelectedValue.ToString() + "','" + statusKaryawan.SelectedItem.ToString() + "','" + statusKerja.SelectedItem.ToString() + "','" + seq().ToString() + "')"))

                            if (db.query("update tbl_karyawan set nama='"+nama.Text+ "',tgllhr='" + tgllhr.Value.ToString("yyyy-MM-dd") + "',jk='" + jk.SelectedItem.ToString().Substring(0, 1) + "',alamat='" + alamat.Text + "',nohp='" + nohp.Text + "',email='" + email.Text + "',statusPernikahan='" + statusPernikahan.SelectedItem.ToString() + "',jumlahTanggungan='" + jTanggungan.Value.ToString() + "',idProfesi='" + profesi.SelectedValue.ToString() + "',idBagian='" + bagian.SelectedValue.ToString() + "',statusKaryawan='" + statusKaryawan.SelectedItem.ToString() + "',statusKerja='" + statusKerja.SelectedItem.ToString() + "' where nik='" + nik.Text+"'"))
                            {


                                if (deletedP.Count != 0)
                                {
                                    for (int i = 0; i < deletedP.Count; i++)
                                    {
                                        db.query("delete from tbl_riwayatpendidikan where nik='" + nik.Text + "' and jenjang='" + deletedP[i] + "'");
                                    }
                                }

                                if (deletedJ.Count != 0)
                                {
                                    for (int i = 0; i < deletedJ.Count; i++)
                                    {
                                        db.query("delete from tbl_rincianjabatan where nik='" + nik.Text + "' and idJabatan='" + deletedJ[i].id.ToString() + "'");
                                        db.query("delete from tbl_rinciantunjangan where nik='" + nik.Text + "' and idTunjangan='" + deletedJ[i].tunjangan.ToString() + "'");
                                    }
                                }

                                if (listP.Count != 0)
                                {
                                    for (int i = 0; i < listP.Count; i++)
                                    {
                                        db.query("insert into tbl_riwayatpendidikan(nik,jenjang,namasekolah,masuk,keluar) values('" + nik.Text + "','" + listP[i].jenjang.ToString() + "','" + listP[i].nama.ToString() + "','" + listP[i].masuk.ToString() + "','" + listP[i].keluar.ToString() + "')");
                                    }
                                }

                                if (listJ.Count != 0)
                                {
                                    for (int i = 0; i < listJ.Count; i++)
                                    {
                                        db.query("insert into tbl_rincianjabatan(nik,idjabatan) values('" + nik.Text + "','" + listJ[i].id.ToString() + "')");
                                        db.query("insert into tbl_rinciantunjangan(nik,idTunjangan) values('" + nik.Text + "','" + listJ[i].tunjangan.ToString() + "')");

                                    }
                                }

                                app.info("Berhasil Merubah Data Karyawan ");
                                this.DialogResult = DialogResult.Yes;
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            app.error(ex.ToString());
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
            }
           
            
        }

        private void bagian_DropDown(object sender, EventArgs e)
        {
            bagian.view("select * from tbl_bagian", "nama", "id");
        }

        private void profesi_DropDown(object sender, EventArgs e)
        {
            profesi.view("select * from tbl_profesi", "nama", "id");

        }

        private void listPendidikan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow d = listPendidikan.Rows[e.RowIndex];
                paramPendidikan = d.Cells["Jenjang"].Value.ToString();
                tmbPend.off();
                hapusPend.on();
               
            }
            catch (Exception ex)
            {
                listPendidikan.ClearSelection();
            }
        }

        private void listJabatan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow d = listJabatan.Rows[e.RowIndex];
                paramJabatan = d.Cells["ID"].Value.ToString();
                tmbJab.off();
                hapusJabatan.on();
            }
            catch (Exception ex)
            {
                listJabatan.ClearSelection();
            }
        }

        private void hapusPend_Click(object sender, EventArgs e)
        {
            if(app.question("Hapus Pendidikan"))
            {
                if (paramPendidikan != "")
                {
                    DataRow dr = pendidikan.Select("Jenjang='" + paramPendidikan + "'").FirstOrDefault();
                    string jenjangP = dr["Jenjang"].ToString();

                    pendidikan.Rows.Remove(dr);
                    if (edit == true)
                    {

                        deletedP.Add(jenjangP);
                        foreach (Pendidikan add in listP)
                        {
                            if (add.jenjang == jenjangP)
                            {
                                listP.Remove(add);
                                break;
                            }
                        }

                    }

                }
                else
                {
                    app.info("Mohon Pilih Data Yang Akan Dihapus Terlebih Dahulu");
                }
                def();
            }
            else
            {
                def();
            }
        }

        private void hapusJabatan_Click(object sender, EventArgs e)
        {
            if (app.question("Hapus Jabatan"))
            {
                if (paramJabatan != "")
                {
                    DataRow dr = jabatan.Select("ID='" + paramJabatan + "'").FirstOrDefault();
                    Jabatan del = new Jabatan();
                    del.id = dr["ID"].ToString();
                    del.nama = dr["Nama"].ToString();
                    del.tunjangan = dr["tunjangan"].ToString();

                    jabatan.Rows.Remove(dr);
                    if (edit ==  true)
                    {
                        
                        deletedJ.Add(del);
                        foreach (Jabatan add in listJ)
                        {
                            if (add.id == del.id)
                            {
                                listJ.Remove(add);
                                break;
                            }
                        }

                    }
                }
                else
                {
                    app.info("Mohon Pilih Data Yang Akan Dihapus Terlebih Dahulu");
                }
                def();
            }
            else
            {
                def();
            }
        }

        private void frmDataKaryawan_Load(object sender, EventArgs e)
        {
            if (edit == true)
            {
                editMode();
                listP = new List<Pendidikan>();
                listJ = new List<Jabatan>();
                deletedP = new List<string>();
                deletedJ = new List<Jabatan>();
            }
        }
    }
}

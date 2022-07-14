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
    public partial class frmPenggajian : Form
    {
        string g = "";
        string idGaji = "";
        public string nikParam = "";
        public string namaParam = "";
        public string profesiParam = "";
        public string statusKaryawanParam = "";
        public string bagianParam = "";

        private int totalPotonganP = 0;
        private int totalTunjanganP = 0;
        private int totalIntensifP = 0;
        private int totalGajiP = 0;

        private string paramTunjangan = "";
        private List<string> listT;
        private List<string> defT;
        private List<string> deletedT;
        private DataTable tjg;


        private string paramIntensif = "";
        private List<string> listI;
        private List<string> defI;
        private List<string> deletedI;
        private DataTable ins;


        private string paramPotongan = "";
        private List<Potongan> listP;
        private List<string> deletedP;
        private DataTable ptg;

        int cTunjangan, cIntensif, cPotongan = 0;

        private string ketLembur;
        private int totalLembur;

        private string metode = "Transfer";

        void GenTableTunjangan()
        {
            tjg = new DataTable();
            tjg.Columns.Add("nik");
            tjg.Columns.Add("id");
            tjg.Columns.Add("nama");
            tjg.Columns.Add("nominal");
            tjg.Columns.Add("jenis");

            listTunjangan.DataSource = tjg;
            listTunjangan.AllowUserToAddRows = false;
            listTunjangan.AllowUserToDeleteRows = false;
            listTunjangan.AllowUserToOrderColumns = false;
            listTunjangan.Columns[0].Visible = false;
            listTunjangan.Columns[1].HeaderText = "ID";
            listTunjangan.Columns[2].HeaderText = "Nama Tunjangan";
            listTunjangan.Columns[3].HeaderText = "Jumlah Tunjangan";
            listTunjangan.Columns[4].HeaderText = "Jenis Tunjangan";
        }
        
        void GenTableIntesif()
        {
            ins = new DataTable();
            ins.Columns.Add("nik");
            ins.Columns.Add("id");
            ins.Columns.Add("nama");
            ins.Columns.Add("nominal");
            ins.Columns.Add("jenis");

            listIntensif.DataSource = ins;
            listIntensif.AllowUserToAddRows = false;
            listIntensif.AllowUserToDeleteRows = false;
            listIntensif.AllowUserToOrderColumns = false;
            listIntensif.Columns[0].Visible = false;
            listIntensif.Columns[1].HeaderText = "ID";
            listIntensif.Columns[2].HeaderText = "Nama Tunjangan";
            listIntensif.Columns[3].HeaderText = "Jumlah Tunjangan";
            listIntensif.Columns[4].HeaderText = "Jenis Tunjangan";
        }

        void GenTablePotongan()
        {
            ptg = new DataTable();
            ptg.Columns.Add("nik");
            ptg.Columns.Add("nama");
            ptg.Columns.Add("keterangan");
            ptg.Columns.Add("nominal");
            ptg.Columns.Add("param");
            ptg.Columns.Add("periode");

            listPotongan.DataSource = ptg;
            listPotongan.AllowUserToAddRows = false;
            listPotongan.AllowUserToDeleteRows = false;
            listPotongan.AllowUserToOrderColumns = false;
            listPotongan.Columns[0].Visible = false;
            listPotongan.Columns[4].Visible = false;
            listPotongan.Columns[1].HeaderText = "Nama";
            listPotongan.Columns[2].HeaderText = "Keterangan";
            listPotongan.Columns[3].HeaderText = "Nominal";
            listPotongan.Columns[5].HeaderText = "Periode";
        }


        void total()
        {
            totalPotonganP = 0;
            totalTunjanganP = 0;
            totalIntensifP = 0;

            foreach (DataGridViewRow row in listTunjangan.Rows)
            {
                totalTunjanganP += Convert.ToInt32(row.Cells[3].Value.ToString());
            }

            foreach (DataGridViewRow row in listIntensif.Rows)
            {
                totalIntensifP += Convert.ToInt32(row.Cells[3].Value.ToString());
            }

            foreach (DataGridViewRow row in listPotongan.Rows)
            {
                totalPotonganP += Convert.ToInt32(row.Cells[3].Value.ToString());
            }

            totalGajiP = Convert.ToInt32(gapok.Text) + totalTunjanganP + totalIntensifP + totalLembur - totalPotonganP;
            totalPotongan.Text = "Rp."+totalPotonganP.ToString().ToRupiah();
            totalTunjangan.Text = "Rp." + totalTunjanganP.ToString().ToRupiah();
            totalIntensif.Text = "Rp." + totalIntensifP.ToString().ToRupiah();
            label8.Text = "Rp." + totalLembur.ToString().ToRupiah();

            totalGaji.Text = "Rp." + totalGajiP.ToString().ToRupiah();
        }

        void loadDataTunjangan()
        {
            DataTable data = db.get("select nik,idTunjangan,nama,nominal,jenis from vw_tunjangan where nik='" + nik.Text + "'");

            foreach(DataRow row in data.Rows)
            {
                defT.Add(row[1].ToString());
                tjg.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
                cTunjangan++;
            }
        }

        void loadDataIntensif()
        {
            ins.Rows.Clear();
            DataTable data = db.get("select nik,idIntensif,nama,nominal,jenis from vw_intensif where nik='" + nik.Text + "'");

            foreach (DataRow row in data.Rows)
            {
                defI.Add(row[1].ToString());
                ins.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
                cIntensif++;
            }
        }

        void loadDataPotongan()
        {
            ptg.Rows.Clear();
            DataTable data = db.get("select * from tbl_potongan where nik='" + nik.Text + "' and periode='"+ DateTime.Now.Month.ToString("d2") + DateTime.Now.Year.ToString() + "'");

            foreach (DataRow row in data.Rows)
            {
                ptg.Rows.Add(row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());
                cPotongan++;
            }
        }

        void def()
        {
            //tmbTunjagan.on();
            //tmbPotongan.on();
            //tmbIntensif.on();
            //hapusTunjangan.off();
            //hapusPotongan.off();
            //hapusIntensif.off();
            paramIntensif = "";
            paramPotongan = "";
            paramTunjangan = "";
        }

        public frmPenggajian()
        {
            InitializeComponent();
            listT = new List<string>();
            defT = new List<string>();
            deletedT = new List<string>();
            listI = new List<string>();
            defI = new List<string>();
            deletedI = new List<string>();
            listP = new List<Potongan>();
            deletedP = new List<string>();
            GenTableTunjangan();
            GenTableIntesif();
            GenTablePotongan();
            def();
            ketLembur = "-";
            totalLembur = 0;
        }

        void setIDGaji()
        {
            idGaji = db.getValue("select * from tbl_gajipokok where statusKaryawan='" + statusKaryawanParam + "' and pendidikan='" + pendidikan.Text + "' and statusGaji='AKTIF' order by periode desc", "id");

        }

        private void frmPenggajian_Load(object sender, EventArgs e)
        {
            nik.Text = nikParam;
            nama.Text = namaParam;
            profesi.Text = profesiParam;
            statusKaryawan.Text = statusKaryawanParam;
            bagian.Text = bagianParam;
            string p = db.getValue("select * from tbl_riwayatpendidikan where nik='" + nik.Text + "' order by keluar desc", "jenjang");
            pendidikan.Text = p;
            listJabatan.view("select nama as Jabatan from vw_jabatan where nik='" + nikParam + "'");
            dgaji.Checked = true;
            g = db.getValue("select * from tbl_gajipokok where statusKaryawan='" + statusKaryawanParam + "' and pendidikan='" + p + "' and statusGaji='AKTIF' order by periode desc", "gaji");
            gapok.Text = g;
            if (gapok.Text == "")
            {
                dgaji.Checked = false;
                gapok.ReadOnly = false;
                gapok.Focus();
            }


            DataTable table = db.get("select * from tbl_penggajian where nik='" + nik.Text + "'");
            string period = DateTime.Now.Month.ToString("d2") + DateTime.Now.Year.ToString();
            DataRow row = table.Select("periodeGaji='" + period + "'").FirstOrDefault();
            if (row == null)
            {
                totalLembur = 0;
                ketLembur = "-";
                nm.Checked = true;
                radioButton2.Checked = false;
            }
            else
            {
                totalLembur = Convert.ToInt32(row["totalLembur"].ToString());
                ketLembur = row["ketLembur"].ToString();
                if (row["gapok"].ToString() != g)
                {
                    gapok.Text = row["gapok"].ToString();
                }

                if (row["metode"].ToString() == "Cash")
                {
                    radioButton2.Checked = true;
                }
                else
                {
                    nm.Checked = true;
                }
            }

           

            loadDataTunjangan();
            loadDataIntensif();
            loadDataPotongan();

            setIDGaji();

            //label7.Text = idGaji;

            total();

        }


        private void dgaji_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgaji.Checked)
                {
                    gapok.Text = g;
                    gapok.ReadOnly = true;
                }
                else
                {
                    gapok.Text = "0";
                    gapok.ReadOnly = false;
                    gapok.Focus();
                }
            }
            catch (Exception ex)
            {
                app.error(ex.ToString());
            }
            
        }

        private void tmbTunjagan_Click(object sender, EventArgs e)
        {
            frmPilihTunjangan a = new frmPilihTunjangan();
            a.ShowDialog();
            if (a.DialogResult == DialogResult.OK)
            {
                int count = tjg.Select("id='" + a.id + "'").Length;


                if (count == 0)
                {
                    listT.Add(a.id);
                    tjg.Rows.Add(nik.Text,a.id,a.nama,a.nominal,a.jenis);

                    foreach (string dele in deletedT)
                    {
                        if (dele == a.id)
                        {
                            deletedT.Remove(dele);
                            break;
                        }
                    }

                    foreach (string i in defT)
                    {
                        if (i == a.id)
                        {
                            listT.Remove(a.id);
                            break;
                        }
                    }


                    total();
                }
                else
                {
                    app.warn("Tunjangan Sudah Ditambahkan");
                }
            }
        }

        private void batal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            this.Close();
        }

        //jangan lupa ini ya kalau edit karyawan
        private void button1_Click(object sender, EventArgs e)
        {
            frmDataKaryawan a = new frmDataKaryawan();
            a.edit = true;
            a.nikParam = nik.Text;
            a.ShowDialog();
            if (a.DialogResult == DialogResult.Yes)
            {
                DataTable k = db.get("select * from vw_karyawan where nik='" + nikParam + "'");
                nik.Text = nikParam;
                nama.Text = k.Rows[0]["nama"].ToString();
                profesi.Text = k.Rows[0]["profesi"].ToString();
                statusKaryawan.Text = k.Rows[0]["statusKaryawan"].ToString();
                bagian.Text = k.Rows[0]["Bagian"].ToString();
                string p = db.getValue("select * from tbl_riwayatpendidikan where nik='" + nik.Text + "' order by keluar desc", "jenjang");
                pendidikan.Text = p;
                listJabatan.view("select nama as Jabatan from vw_jabatan where nik='" + nikParam + "'");
                dgaji.Checked = true;

                g = db.getValue("select * from tbl_gajipokok where statusKaryawan='" + statusKaryawanParam + "' and pendidikan='" + p + "' and statusGaji='AKTIF' order by periode desc", "gaji");
                gapok.Text = g;
                if (gapok.Text == "")
                {
                    dgaji.Checked = false;
                    gapok.ReadOnly = false;
                    gapok.Focus();
                }

                tjg.Rows.Clear();

                loadDataTunjangan();
                loadDataIntensif();
                //loadDataPotongan();

                setIDGaji();


                total();
            }
        }

        private void listTunjangan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow d = listTunjangan.Rows[e.RowIndex];
                paramTunjangan = d.Cells["id"].Value.ToString();
                //tmbTunjagan.off();
                //hapusTunjangan.on();

            }
            catch (Exception ex)
            {
                listTunjangan.ClearSelection();
            }
        }

        private void hapusTunjangan_Click(object sender, EventArgs e)
        {
            if (app.question("Hapus Tunjangan"))
            {
                if (paramTunjangan != "")
                {
                    DataRow dr = tjg.Select("id='" + paramTunjangan + "'").FirstOrDefault();
                    string i = dr["id"].ToString();

                    tjg.Rows.Remove(dr);

                    deletedT.Add(i);
                    foreach (string add in listT)
                    {
                        if (add == i)
                        {
                            listT.Remove(add);
                            break;
                        }
                    }

                    total();

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

        private void tmbIntensif_Click(object sender, EventArgs e)
        {
            frmPilihIntensif a = new frmPilihIntensif();
            a.ShowDialog();
            if (a.DialogResult == DialogResult.OK)
            {
                int count = ins.Select("id='" + a.id + "'").Length;

                if (count == 0)
                {
                    listI.Add(a.id);
                    ins.Rows.Add(nik.Text, a.id, a.nama, a.nominal, a.jenis);

                    foreach (string dele in deletedI)
                    {
                        if (dele == a.id)
                        {
                            deletedI.Remove(dele);
                            break;
                        }
                    }

                    foreach (string i in defI)
                    {
                        if (i == a.id)
                        {
                            listI.Remove(a.id);
                            break;
                        }
                    }


                    total();
                }
                else
                {
                    app.warn("Intensif Sudah Ditambahkan");
                }
            }
        }

        private void hapusIntensif_Click(object sender, EventArgs e)
        {
            if (app.question("Hapus Intensif"))
            {
                if (paramIntensif != "")
                {
                    DataRow dr = ins.Select("id='" + paramIntensif + "'").FirstOrDefault();
                    string i = dr["id"].ToString();

                    ins.Rows.Remove(dr);

                    deletedI.Add(i);
                    foreach (string add in listI)
                    {
                        if (add == i)
                        {
                            listI.Remove(add);
                            break;
                        }
                    }
                    total();
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

        private void listIntensif_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow d = listIntensif.Rows[e.RowIndex];
                paramIntensif = d.Cells["id"].Value.ToString();
                //tmbIntensif.off();
                //hapusIntensif.on();

            }
            catch (Exception ex)
            {
                listTunjangan.ClearSelection();
            }
        }

        private void tmbPotongan_Click(object sender, EventArgs e)
        {
            frmTmbPotongan a = new frmTmbPotongan();
            a.ShowDialog();
            if (a.DialogResult == DialogResult.OK)
            {
                Potongan pt = new Potongan();
                pt.nik = nik.Text;
                pt.nama = a.potongan;
                pt.keterangan = a.keterangan;
                pt.nominal = a.nominal;
                pt.param = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
                pt.periode = DateTime.Now.Month.ToString("d2") + DateTime.Now.Year.ToString();
                listP.Add(pt);
                ptg.Rows.Add(pt.nik,pt.nama,pt.keterangan,pt.nominal,pt.param,pt.periode);
                total();
            }
        }

        private void hapusPotongan_Click(object sender, EventArgs e)
        {
            if (app.question("Hapus Potongan"))
            {
                if (paramPotongan != "")
                {
                    DataRow dr = ptg.Select("param='" + paramPotongan + "'").FirstOrDefault();
                    string prm = dr["param"].ToString();

                    ptg.Rows.Remove(dr);

                    deletedP.Add(prm);
                    foreach (Potongan add in listP)
                    {
                        if (add.param == prm)
                        {
                            listP.Remove(add);
                            break;
                        }
                    }
                    total();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmTmbLembur a = new frmTmbLembur();
            a.ShowDialog();
            if (a.DialogResult == DialogResult.OK)
            {
                ketLembur = a.keterangan;
                totalLembur = a.nominal;
                total();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ketLembur = "-";
            totalLembur = 0;
            total();
        }

        private void gapok_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.numberOnly();
        }

        private void gapok_TextChanged(object sender, EventArgs e)
        {
            if (gapok.Text == "")
            {
                gapok.Text = "0";
                total();

            }
            else
            {
                total();

            }
        }

        private void listPotongan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow d = listPotongan.Rows[e.RowIndex];
                paramPotongan = d.Cells["param"].Value.ToString();
                //tmbPotongan.off();
                //hapusPotongan.on();
            }
            catch (Exception ex)
            {
                listTunjangan.ClearSelection();
            }
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            if (app.question("Simpan Data Penggajian"))
            {
                try
                {
                    if (nm.Checked)
                    {
                        metode = "Transfer";
                    }
                    else
                    {
                        metode = "Cash";
                    }


                    string sql = "";
                    DataTable table = db.get("select * from tbl_penggajian where nik='" + nik.Text + "'");
                    string period = DateTime.Now.Month.ToString("d2") + DateTime.Now.Year.ToString();
                    DataRow row = table.Select("periodeGaji='" + period + "'").FirstOrDefault();
                    if (row == null)
                    {
                        sql = "INSERT INTO tbl_penggajian(nik, idGajiPokok, periodeGaji, totalTunjangan, totalIntensif, totalPotongan, totalGaji, ketLembur,totalLembur,gapok,metode) VALUES('"+nik.Text+"','"+idGaji+"','"+period+"','"+totalTunjanganP.ToString()+"','"+totalIntensifP.ToString()+"','"+totalPotonganP.ToString()+"','"+totalGajiP.ToString()+ "','" + ketLembur.ToString() + "','" + totalLembur.ToString() + "','" + gapok.Text.ToString() + "','" + metode + "')";
                    }
                    else
                    {
                        sql = "update tbl_penggajian set idGajiPokok='"+idGaji+ "',totalTunjangan='"+totalTunjanganP.ToString()+ "',totalIntensif='"+totalIntensifP.ToString()+ "',totalPotongan='" + totalPotonganP.ToString() + "',totalGaji='" + totalGajiP.ToString() + "',ketLembur='" + ketLembur.ToString() + "',totalLembur='" + totalLembur.ToString() + "',gapok='" + gapok.Text.ToString() + "',metode='" + metode + "' where nik='" + nik.Text+ "' and periodeGaji='"+period+"'";
                    }


                    if (db.query(sql))
                    {

                        if (deletedT.Count != 0)
                        {
                            for (int i = 0; i < deletedT.Count; i++)
                            {
                                db.query("delete from tbl_rinciantunjangan where nik='" + nik.Text + "' and idTunjangan='"+deletedT[i]+"'");
                            }
                        }

                        if (deletedI.Count != 0)
                        {
                            for (int i = 0; i < deletedI.Count; i++)
                            {
                                db.query("delete from tbl_rincianintensif where nik='" + nik.Text + "' and idIntensif='" + deletedI[i] + "'");
                            }
                        }

                        if (deletedP.Count != 0)
                        {
                            for (int i = 0; i < deletedP.Count; i++)
                            {
                                db.query("delete from tbl_potongan where nik='" + nik.Text + "' and param='" + deletedP[i]+ "'");
                            }
                        }


                        if (cTunjangan == 0)
                        {
                            for (int i = 0; i < listTunjangan.Rows.Count; i++)
                            {
                                db.query("insert into tbl_rinciantunjangan(nik,idTunjangan) values('" + nik.Text + "','" + listTunjangan.Rows[i].Cells[1].Value.ToString() + "')");
                            }
                        }
                        else
                        {
                            for (int i = 0; i < listT.Count; i++)
                            {
                                db.query("insert into tbl_rinciantunjangan(nik,idTunjangan) values('" + nik.Text + "','" + listT[i].ToString() + "')");
                            }
                        }

                        if (cIntensif == 0)
                        {
                            for (int i = 0; i < listIntensif.Rows.Count; i++)
                            {
                                db.query("insert into tbl_rincianintensif(nik,idIntensif) values('" + nik.Text + "','" + listIntensif.Rows[i].Cells[1].Value.ToString() + "')");
                            }
                        }
                        else
                        {
                            for (int i = 0; i < listI.Count; i++)
                            {
                                db.query("insert into tbl_rincianintensif(nik,idIntensif) values('" + nik.Text + "','" + listI[i].ToString() + "')");
                            }
                        }

                        if (cPotongan == 0)
                        {
                            for (int i = 0; i < listPotongan.Rows.Count; i++)
                            {
                                db.query("INSERT INTO tbl_potongan(nik, nama, keterangan, nominal, param, periode) VALUES ('"+nik.Text+"','"+ listPotongan.Rows[i].Cells[1].Value.ToString() + "','" + listPotongan.Rows[i].Cells[2].Value.ToString() + "','" + listPotongan.Rows[i].Cells[3].Value.ToString() + "','" + listPotongan.Rows[i].Cells[4].Value.ToString() + "','" + period + "')");
                            }
                        }
                        else
                        {
                            for (int i = 0; i < listP.Count; i++)
                            {
                                db.query("INSERT INTO tbl_potongan(nik, nama, keterangan, nominal, param, periode) VALUES ('" + nik.Text + "','" + listP[i].nama.ToString() + "','" + listP[i].keterangan.ToString() + "','" + listP[i].nominal.ToString() + "','" + listP[i].param.ToString() + "','" + period + "')");
                            }
                        }

                        //Simpan Gaji
                        this.DialogResult = DialogResult.Yes;
                        app.info("Data Gaji Tersimpan");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    app.error(ex.Message.ToString());
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
            }
            
        }
    }
}

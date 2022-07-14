using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace RsrrPayroll
{
    public static class db
    {
        public static MySqlConnection conn;
        public static MySqlCommand cmd;
        public static MySqlDataReader dr;
        public static MySqlDataAdapter da;
        public static DataTable dt;
        public static DataSet ds;

        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "datasource=localhost;port=3306;username=root;password=;database=payrollrsrr;";
            return connection;
        }

        public static void open()
        {
            conn = GetConnection();
            conn.Open();
        }

        public static void close()
        {
            conn = GetConnection();
            conn.Close();
        }


        public static Boolean query(string sql)
        {
            open();
            try
            {
                cmd = new MySqlCommand(sql, conn);

                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                app.error(ex.ToString());
                return false;
            }
            finally
            {
                close();
                cmd.Dispose();
            }
        }

        public static DataTable get(string sql)
        {
            open();
            try
            {
                cmd = new MySqlCommand(sql, conn);

                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                app.error(ex.ToString());
                return null;
            }
            finally
            {
                close();
                cmd.Dispose();
            }
        }

        public static string getValue(string sql, string col)
        {
            open();
            try
            {
                cmd = new MySqlCommand(sql, conn);

                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    return dr[col].ToString();
                }
                else
                {
                    return "";
                }


            }
            catch (Exception ex)
            {
                app.error(ex.ToString());
                return "";
            }
            finally
            {
                close();
                cmd.Dispose();
            }
        }

        public static string idGaji(string p,string j)
        {

            string kdPendidikan, kdJenis = "";

            if (p == "SMP")
            {
                kdPendidikan = "MP";
            }
            else
            {
                kdPendidikan = p.Substring(0, 2);
            }


            if (j == "Training")
            {
                kdJenis = "TR";
            }
            else if (j == "Kontrak")
            {
                kdJenis = "KT";
            }
            else if (j == "Tetap")
            {
                kdJenis = "TP";
            }
            else if (j == "Outsourcing")
            {
                kdJenis = "OS";
            }

            open();
            try
            {
                cmd = new MySqlCommand("select * from tbl_gajipokok where pendidikan='"+p+"' and statuskaryawan='"+j+"' order by id desc",conn);

                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    string a = dr[0].ToString().Substring(4);
                    int b = Convert.ToInt32(a) + 1;
                    return kdPendidikan + kdJenis + b.ToString("d4");
                }
                else
                {
                    return kdPendidikan + kdJenis + "0001";
                }


            }
            catch (Exception ex)
            {
                app.error(ex.ToString());
                return "";
            }
            finally
            {
                close();
                cmd.Dispose();
            }
        }

        public static string idTunjangan()
        {
            open();
            try
            {
                cmd = new MySqlCommand("select * from tbl_tunjangan order by id desc", conn);

                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    string a = dr[0].ToString().Substring(2);
                    int b = Convert.ToInt32(a) + 1;
                    return "TJ" + b.ToString("d4");
                }
                else
                {
                    return "TJ"+ "0001";
                }


            }
            catch (Exception ex)
            {
                app.error(ex.ToString());
                return "";
            }
            finally
            {
                close();
                cmd.Dispose();
            }
        }

        public static string idIntensif()
        {
            open();
            try
            {
                cmd = new MySqlCommand("select * from tbl_intensif order by id desc", conn);

                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    string a = dr[0].ToString().Substring(2);
                    int b = Convert.ToInt32(a) + 1;
                    return "IN" + b.ToString("d4");
                }
                else
                {
                    return "IN" + "0001";
                }


            }
            catch (Exception ex)
            {
                app.error(ex.ToString());
                return "";
            }
            finally
            {
                close();
                cmd.Dispose();
            }
        }

        public static string idJabatan()
        {
            open();
            try
            {
                cmd = new MySqlCommand("select * from tbl_jabatan order by id desc", conn);

                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    string a = dr[0].ToString().Substring(2);
                    int b = Convert.ToInt32(a) + 1;
                    return "JB" + b.ToString("d4");
                }
                else
                {
                    return "JB" + "0001";
                }


            }
            catch (Exception ex)
            {
                app.error(ex.ToString());
                return "";
            }
            finally
            {
                close();
                cmd.Dispose();
            }
        }


        public static string idBagian()
        {
            open();
            try
            {
                cmd = new MySqlCommand("select * from tbl_bagian order by id desc", conn);

                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    string a = dr[0].ToString().Substring(2);
                    int b = Convert.ToInt32(a) + 1;
                    return "BG" + b.ToString("d4");
                }
                else
                {
                    return "BG" + "0001";
                }
            }
            catch (Exception ex)
            {
                app.error(ex.ToString());
                return "";
            }
            finally
            {
                close();
                cmd.Dispose();
            }
        }

        public static string idProfesi()
        {
            open();
            try
            {
                cmd = new MySqlCommand("select * from tbl_profesi order by id desc", conn);

                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    string a = dr[0].ToString().Substring(2);
                    int b = Convert.ToInt32(a) + 1;
                    return "PF" + b.ToString("d4");
                }
                else
                {
                    return "PF" + "0001";
                }
            }
            catch (Exception ex)
            {
                app.error(ex.ToString());
                return "";
            }
            finally
            {
                close();
                cmd.Dispose();
            }
        }


        public static void view(this ComboBox cbx, string sql, string colD, string colV)
        {
            open();
            try
            {
                cmd = new MySqlCommand(sql, conn);

                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                cbx.DataSource = dt;
                cbx.ValueMember = colV;
                cbx.DisplayMember = colD;
            }
            catch (Exception ex)
            {
                app.error(ex.ToString());
            }
            finally
            {
                close();
                cmd.Dispose();
            }
        }

        public static void view(this DataGridView c, string sql)
        {
            open();
            try
            {
                cmd = new MySqlCommand(sql, conn);

                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();

                da.Fill(dt);

                c.DataSource = dt;
                c.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                c.AllowUserToAddRows = false;
                c.AllowUserToDeleteRows = false;
                c.AllowUserToOrderColumns = false;
                c.Refresh();


            }
            catch (Exception ex)
            {
                app.error(ex.ToString());
            }
            finally
            {
                close();
                cmd.Dispose();
            }
        }

        public static Boolean emailExist(this string email, string table)
        {
            open();
            try
            {
                int cek = get("select * from " + table + " where Email='" + email + "'").Rows.Count;

                if (cek > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                app.error(ex.ToString());
                return false;
            }
            finally
            {
                close();
                cmd.Dispose();
            }
        }

        public static Boolean hpExist(this string email, string table)
        {
            open();
            try
            {
                int cek = get("select * from " + table + " where Handphone='" + email + "'").Rows.Count;

                if (cek > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                app.error(ex.ToString());
                return false;
            }
            finally
            {
                close();
                cmd.Dispose();
            }
        }


        public static string nik(string tglLhr, string tglMasuk, string jkel)
        {
            open();
            try
            {
                cmd = new MySqlCommand("select * from tbl_karyawan order by seq desc", conn);

                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    int b = Convert.ToInt32(dr[14]) + 1;
                    return tglLhr + tglMasuk + jkel + b.ToString("d4");
                }
                else
                {
                    return tglLhr + tglMasuk + jkel + "0001";
                }


            }
            catch (Exception ex)
            {
                app.error(ex.ToString());
                return "";
            }
            finally
            {
                close();
                cmd.Dispose();
            }
        }

        public static int count(string sql)
        {
            return get(sql).Rows.Count;
        }
    }
}

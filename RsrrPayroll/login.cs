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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            pass.UseSystemPasswordChar = true;
        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            if (show.Checked)
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;
            }
        }

        private void blogin_Click(object sender, EventArgs e)
        {
            if (user.Text == "")
            {
                app.info("Masukan Username");
                user.Focus();
            }
            else if (pass.Text == "")
            {
                app.info("Masukan Password");
                pass.Focus();
            }
            else
            {
                DataTable userD = db.get("select * from login where username='" + user.Text + "' and password='" + pass.Text + "'");
                if (userD.Rows.Count > 0)
                {
                    foreach (DataRow dr in userD.Rows)
                    {
                        app.id = dr["id"].ToString();
                        app.user = dr["username"].ToString();
                        app.role = dr["role"].ToString();
                    }
                    Form1 main = new Form1();

                    main.Show();
                    this.Hide();
                }
                else
                {
                    app.info("Username Atau Password Yang Anda Masukan Salah");
                }
            }
        }
    }
}

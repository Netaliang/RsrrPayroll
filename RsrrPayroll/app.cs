using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using System.IO;
using System.Globalization;
using System.Net.Mail;

namespace RsrrPayroll
{
    public static class app
    {
        public static string id, user, role = "";
        

        public static Regex pass = new Regex("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{2,25}$");

        public static string random(int l)
        {
            Random ran = new Random();
            string c = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(c, l).Select(s => s[ran.Next(s.Length)]).ToArray());
        }

        public static void visible(List<Control> list, Boolean state)
        {
            foreach (Control c in list)
            {
                c.Visible = state;
            }
        }

        public static void enabled(List<Control> list, Boolean state)
        {
            foreach (Control c in list)
            {
                c.Enabled = state;
            }
        }

        public static string ToRupiah(this string angka)
        {
            return string.Format("{0:n0}", double.Parse(angka.ToString()));
        }

        public static string ToAngka(this string angka)
        {
            return angka.Replace(".", "");
        }

        public static void numberOnly(this KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        public static void charOnly(this KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        public static void on(this Control c)
        {
            c.Enabled = true;
        }

        public static void off(this Control c)
        {
            c.Enabled = false;
        }

        public static void open(this Panel main, UserControl form)
        {
            foreach (Control c in main.Controls)
            {
                if (c.Name != "login" && c.Name != "profil")
                {
                    main.Controls.Remove(c);
                }
            }

            main.Controls.Add(form);
            form.Show();
        }

        public static void set(this Panel nav, Button btn)
        {
            foreach (Button b in nav.Controls)
            {
                if (b == btn)
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                    btn.FlatAppearance.BorderColor = btn.BackColor;
                }
                else
                {
                    b.BackColor = Color.FromName("Highlight");
                    b.ForeColor = Color.White;
                    b.FlatAppearance.BorderColor = b.BackColor;
                }
            }
        }

        public static Boolean email(this string input)
        {
            try
            {
                MailAddress mail = new MailAddress(input);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static Boolean valid(this Control form)
        {
            Boolean kosong = false;
            foreach (Control c in form.Controls)
            {
                if (c is TextBox)
                {
                    if (((TextBox)c).Text == "")
                    {
                        kosong = true;
                        break;
                    }
                }
                if (c is ComboBox)
                {
                    if (((ComboBox)c).Text == "" || ((ComboBox)c).Text == "" || ((ComboBox)c).Text == "" || ((ComboBox)c).SelectedItem == "" || ((ComboBox)c).SelectedIndex == null)
                    {
                        kosong = true;
                        break;
                    }
                }
                //if (c is NumericUpDown)
                //{
                //    if (((NumericUpDown)c).Value == 0)
                //    {
                //        kosong = true;
                //        break;
                //    }
                //}

                if (c is DateTimePicker)
                {
                    string v1 = ((DateTimePicker)c).Value.Year.ToString() + ((DateTimePicker)c).Value.Month.ToString("d2") + ((DateTimePicker)c).Value.Day.ToString("d2");
                    string v2 = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString("d2") + DateTime.Now.Day.ToString("d2");
                    if (v1 == v2)
                    {
                        kosong = true;
                        break;
                    }
                }

            }
            return kosong;
        }

        public static void clear(this Control form)
        {
            foreach (Control c in form.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedItem = null;
                }
                if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0;
                }
                if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }

            }
        }

        public static Boolean question(string msg)
        {
            if (MessageBox.Show(msg, "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void info(string msg)
        {
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void warn(string msg)
        {
            MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void error(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

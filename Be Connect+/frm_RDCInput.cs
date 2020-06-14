using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Be_Connect_
{
    public partial class frm_RDCInput : Form
    {
        public frm_RDCInput()
        {
            InitializeComponent();
        }
        frm_RemoteDesktop aa = new frm_RemoteDesktop();
        public static string user = "";
        public static string password = "";
        private void frm_RDCInput_Load(object sender, EventArgs e)
        {
            txt_Password.Text = "";
            txt_Password.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Checkpass.Checked)
            {
                txt_Password.PasswordChar = '\0';
                txt_Password.Focus();
                cb_Checkpass.Tag = "Click to Hide";
            }
            else
            {
                txt_Password.PasswordChar = '●';
                txt_Password.Focus();
                cb_Checkpass.Tag = "Click to Show";
            }
        }

        private void Tooltip(object sender, EventArgs e)
        {
         new ToolTip().Show(((Control)sender).Tag.ToString(), ((Control)sender), ((Control)sender).Width + 5, ((Control)sender).Height + 5, 600);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "")
            {
                MessageBox.Show("Username can't be blank","Be Connect+ - Enter username",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
            else
            {
                password = txt_Password.Text.Trim();
                user = txt_Username.Text.Trim();
                aa.Show();
                aa.WindowState = FormWindowState.Normal;
            }
        }
    }
}

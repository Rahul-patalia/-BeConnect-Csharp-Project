using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Be_Connect_
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            panel1.Location = new Point(390,0);
        }
        ToolTip tp = new ToolTip();

        OleDbConnection CONN = null;
        string PATH = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\server\BCA\B1516_040\BCA5-SEM(34)\Project\Database\db_Login.accdb";
        
        
        public bool Login(string Username, string Password)
        {
            string QRY = "SELECT * FROM tbl_Login WHERE Username='" + Username + "' AND Password='" + Password + "'";
            CONN = new OleDbConnection(PATH);
            CONN.Open();
            OleDbCommand cmd = new OleDbCommand(QRY, CONN);
            OleDbDataReader Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                if (Username == Dr["Username"].ToString() && Password == Dr["Password"].ToString())
                {
                    return true;
                }
            }
            CONN.Close();
            CONN.Dispose();
            cmd.Dispose();
            return false;
        }  

        private void MouseHover(object sender, EventArgs e)
        {
            if (((Control)sender).Text == "X")
            {
                ((Control)sender).BackColor = Color.Red;
                ((Control)sender).ForeColor = Color.White;
            }
            else if (((Control)sender).Text == "—")
            {
                ((Control)sender).BackColor = Color.FromArgb(55, 71, 79);
                ((Control)sender).ForeColor = Color.White;
            }
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            if (((Control)sender).Text == "X")
            {
                ((Control)sender).BackColor = Color.Transparent;
                ((Control)sender).ForeColor = Color.Black;
            }
            else if (((Control)sender).Text == "—")
            {
                ((Control)sender).BackColor = Color.Transparent;
                ((Control)sender).ForeColor = Color.Black;
            }
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            if (((Control)sender).Tag == "txt_ID")
            {
                if (((Control)sender).Text == "Enter Your ID")
                { ((Control)sender).Text = ""; }
            }
            else if (((Control)sender).Tag == "txt_Password")
            {
                if (chck_show_hide.Checked)
                {
                    txt_Password.PasswordChar = '\0';
                }
                else
                {
                    txt_Password.PasswordChar = '●';
                    chck_show_hide.Enabled = true;
                    chck_show_hide.Checked = false;
                    tp.Show("Click to Show Password !", chck_show_hide, 0, 20, 800);
                    if (((Control)sender).Text == "Enter Your Password")
                    { ((Control)sender).Text = ""; }
                }
            }
        }

        private void chck_show_hide_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_show_hide.Checked)
            {
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                if (txt_Password.Text != "")
                {
                    if (txt_Password.Text == "Enter Your Password")
                    {
                        txt_Password.PasswordChar = '\0';
                        txt_Password.Text = "Enter Your Password";
                    }
                    else { txt_Password.PasswordChar = '●'; }
                }
            }
        }

        private void chck_show_hide_MouseHover(object sender, EventArgs e)
        {
            if (chck_show_hide.Checked)
            {
                tp.Show("Click to Hide Password !", chck_show_hide, 0, 25, 800);
            }
            else 
            {
                tp.Show("Click to Show Password !", chck_show_hide, 0, 25, 800);
            }
        }

        private void txt_ID_Leave_1(object sender, EventArgs e)
        {
            if (((Control)sender).Tag == "txt_ID")
            {
                if (((Control)sender).Text == "")
                { ((Control)sender).Text = "Enter Your ID"; }
            }
            else if (((Control)sender).Tag == "txt_Password")
            {
                if (((Control)sender).Text == "")
                {
                    txt_Password.PasswordChar = '\0';
                    ((Control)sender).Text = "Enter Your Password";
                    chck_show_hide.Enabled = false;
                }
                chck_show_hide.Checked = false;     
            }
        }

        private void lbl_Exit_Click_1(object sender, EventArgs e)
        {
            if (((Control)sender).Text == "X")
            {
                Application.Exit();
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text.Trim() == "Enter Your ID" && txt_Password.Text.Trim() == "Enter Your Password")
            {
                if (MessageBox.Show("Enter Your Username And Password to Login", "Be Connect+ - Empty fields not acceptable", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
            else
            {
                if (Login(txt_ID.Text.Trim(), txt_Password.Text.Trim()))
                {
                    this.Hide();
                    this.Cursor = Cursors.WaitCursor;
                    if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                    {
                        new Frm_Main0().Show();
                    }
                    else 
                    {
                        if (MessageBox.Show("You are not connect to a network", "Network not Detected", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                        {
                            Application.Restart();
                        }
                        else { Application.Exit(); }
                    }
                }
                else
                {
                    if (MessageBox.Show("Username and Password doesn't match! \nPlease try again....", "Be Connect+ - Incorrect Username and Password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void btn_newlogin_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            for (int i = 390; i >= 0; i=i-10)
            {
                panel1.Location = new Point(i,panel1.Location.Y);
                System.Threading.Thread.Sleep(10);
                if (panel1.Location.X == 10)
                { show(true); }
            }
            System.Threading.Thread.EndThreadAffinity();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.None;
            show(false);
            label5.Visible = true;
            for (int i = 0; i <= 400; i = i + 20)
            {
                panel1.Location = new Point(i, panel1.Location.Y);
                System.Threading.Thread.Sleep(10);
            }
            System.Threading.Thread.EndThreadAffinity();
        }

        void show(bool b)
        {
            pictureBox2.Visible = b;
            btn_Back.Visible = b;
            label2.Visible = b;
            label3.Visible = b;
            label4.Visible = b;
            txt_newuser.Visible = b;
            txt_newpass.Visible = b;
            txt_Email.Visible = b;
            btn_Signin.Visible = b;
            btn_Clear.Visible = b;
        }

        private void btn_Signin_Click(object sender, EventArgs e)
        {
            string QRY = "INSERT INTO tbl_Login values('"+txt_newuser.Text.Trim()+"','"+txt_newpass.Text.Trim()+"','"+txt_Email.Text.Trim()+"')";
            CONN = new OleDbConnection(PATH);
            OleDbCommand cmd = new OleDbCommand(QRY, CONN);
            CONN.Open();
            cmd.ExecuteNonQuery();
            CONN.Close();
            CONN.Dispose();
            cmd.Dispose();
            txt_ID.Text = txt_newuser.Text.Trim();
            txt_Password.Text = txt_newpass.Text.Trim();
            button3_Click(sender, e);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_newpass.Clear();
            txt_newuser.Clear();
            txt_Email.Clear();
        }
        
    }
}

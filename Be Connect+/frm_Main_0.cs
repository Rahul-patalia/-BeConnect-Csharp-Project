using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using MSTSCLib;

namespace Be_Connect_
{
    public partial class Frm_Main0 : Form
    {
        public Frm_Main0()
        {
            InitializeComponent();
        }
        frm_Chat c = null;
        frm_Home H = null;
        frm_About A = null;
        frm_FileTrans F = null;
        frm_RDCInput R = null;
        
        //================================ User Define Methods =================================
        void loadForms(Form x)
        {
            this.Cursor = Cursors.WaitCursor;
            foreach (Form un in this.panel2.Controls)
            {
                un.Close();
            }
            x.MdiParent = this;
            x.TopLevel = false;
            x.AutoScroll = true;
            x.Size = panel2.Size;
            panel2.Controls.Add(x);
            x.Show();
            this.Cursor = Cursors.Default;
        }

        
        
        //================================ End of User Define Methods =================================

        //================================ Events & Stuff =================================

        private void btn_Chat_Click(object sender, EventArgs e)
        {
            if (frm_Home.Username != null)
            {
                c = new frm_Chat();
                c.lbl_Username.Text = frm_Home.Username;
                loadForms(c);
                lbl_SelectedTab.Text = "Chat";
            }
            else
            {
                MessageBox.Show("Please select user for \"Chat\" ", "Be connect+ - Select user to chat with", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        public void btn_Home_Click(object sender, EventArgs e)
        {
            H = new frm_Home();
            loadForms(H);
            lbl_SelectedTab.Text = "Home";
        }

        private void btn_RemoteDesk_Click(object sender, EventArgs e)
        {
            if (frm_Home.Username != null)
            {
                lbl_SelectedTab.Text = "Remote Desktop Connection";
                R = new frm_RDCInput();
                loadForms(R);
                R.Size = new System.Drawing.Size(435, 238);
                R.lbl_User.Text = frm_Home.Username;
                this.Cursor = Cursors.Default;
            }
            else
            {
                MessageBox.Show("Please select user for \"Remote Desktop Connection\" ", "Be connect+ - User not Selected", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private void btn_FileTransh_Click(object sender, EventArgs e)
        {
            if (frm_Home.Username != null)
            {
                F = new frm_FileTrans();
                loadForms(F);
                lbl_SelectedTab.Text = "File Transfer";
            }
            else 
            {
                MessageBox.Show("Please select user for \"File Transfer\" ", "Be connect+ - User not Selected", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            A = new frm_About();
            loadForms(A);
            lbl_SelectedTab.Text = "About";
        }
        
        private void frm_Resize(object sender, EventArgs e)
        {
            if (((Control)sender).Text == "—")
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (((Control)sender).Text == "||")
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    btn_Resize.Text = "=";
                    this.WindowState = FormWindowState.Maximized;
                    lbl_SelectedTab.Location = new Point(panel3.Width / 2, 7);
                    
                    foreach (Form un in this.panel2.Controls)
                    {
                        un.WindowState = FormWindowState.Maximized;
                        un.Size = panel2.Size;
                    }
                }
            }
            else if (((Control)sender).Text == "=")
            {
                this.WindowState = FormWindowState.Normal;
                btn_Resize.Text = "||";
                lbl_SelectedTab.Location = new Point(panel3.Width / 2, 7);
                if (lbl_SelectedTab.Text == btn_Chat.Tag.ToString())
                {
                    c.WindowState = FormWindowState.Normal;
                    c.Size = panel2.Size;
                }
                else if (lbl_SelectedTab.Text == btn_FileTransh.Tag.ToString())
                {
                    F.WindowState = FormWindowState.Normal;
                    F.frm_FileTrans_Resize(sender, e);
                    F.Size = panel2.Size;
                }
                else if (lbl_SelectedTab.Text == btn_Home.Tag.ToString())
                {
                    H.WindowState = FormWindowState.Normal;
                    H.Size = panel2.Size;
                }
                else if (lbl_SelectedTab.Text == btn_About.Tag.ToString())
                {
                    A.WindowState = FormWindowState.Normal;
                    A.Size = panel2.Size;
                }

            }
            else
            {
                Application.Exit();
            }
        }
        
        private void Mouseleave(object sender, EventArgs e)
        {
            if (((Control)sender).Text == "X")
            {
                ((Control)sender).BackColor = Color.Transparent;
            }
            else { ((Control)sender).BackColor = Color.Transparent; }
        }
        
        private void show_Tooltip(object sender, EventArgs e)
        {
            new ToolTip().Show(((Control)sender).Tag.ToString(), (Control)sender, (((Control)sender).Height / 2)+26, ((Control)sender).Width + 2, 600);
        }

        private void Frm_Main0_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            btn_Home_Click(sender, e);
            lbl_SelectedTab.Location = new Point(panel3.Width / 2 - lbl_SelectedTab.Width / 2, panel3.Height / 2 - lbl_SelectedTab.Height / 2);
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            if (((Control)sender).Text == "X")
            {
                ((Control)sender).BackColor = Color.Red;
                ((Control)sender).Tag = "Close";
            }
            else 
            {
                if (((Control)sender).Text == "||")
                {
                    ((Control)sender).Tag = "Maximize";
                    ((Control)sender).BackColor = Color.FromArgb(160, 160, 160);
                }
                else if (((Control)sender).Text == "=")
                {
                    ((Control)sender).Tag = "Restore Down";
                    ((Control)sender).BackColor = Color.FromArgb(160, 160, 160);
                }
                else
                {
                    ((Control)sender).Tag = "Minimize";
                    ((Control)sender).BackColor = Color.FromArgb(160, 160, 160);
                }
            }
        }

        //================================ End of Events & Stuff =================================
 
    }
}

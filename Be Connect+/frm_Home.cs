using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation; 

namespace Be_Connect_
{
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }
        public static string Username = null;
        public static IPAddress Userip = null;
        public static string MyInput = "";
        
        private void frm_Home_Load(object sender, EventArgs e)
        {
            Username = null;
            lbl_Username.Text = Environment.UserName;
            lbl_PCname.Text = "PC Name: " + Environment.MachineName;
            lbl_IPAddress.Text = "IP Address: " + System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList[0].ToString();
            
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                lbl_Status.Text = "Network Status : Connected";
            }
            else lbl_Status.Text = "Network Status : Disconnected";
            string Domain = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
            if (Domain == "")
            {
                lbl_Domain.Text = "Domain : None";
            }
            else { lbl_Domain.Text = "Domain : "+Domain; }
            LoadIPaddress();
            bool flag=true;
            for (int i = 0; i <= DGV_LoadUsers.Rows.Count - 1; i++)
            {
                if (DGV_LoadUsers.Rows[i].Cells[0].Value.ToString() == Environment.MachineName)
                {
                    flag = false;
                }
            }
            if (flag)
            {
                MessageBox.Show("You won't be able to access features\n please turn on \"Network Discovery\"","Be Connect+ - Network Discovery issue",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        string pcname,ipaddr;
        void LoadIPaddress()
        {
            this.Cursor = Cursors.WaitCursor;
            Process netUtility = new Process();
            netUtility.StartInfo.FileName = "net.exe";
            netUtility.StartInfo.CreateNoWindow = true;
            netUtility.StartInfo.Arguments = "view";
            netUtility.StartInfo.RedirectStandardOutput = true;
            netUtility.StartInfo.UseShellExecute = false;
            netUtility.StartInfo.RedirectStandardError = true;
            netUtility.Start();

            StreamReader streamReader = new StreamReader(netUtility.StandardOutput.BaseStream, netUtility.StandardOutput.CurrentEncoding);

            string line = "";

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line.StartsWith("\\"))
                {
                    try
                    {
                        pcname = line.Substring(2).Substring(0, line.Substring(2).IndexOf(" "));
                        ipaddr = Dns.GetHostByName(pcname).AddressList[0].ToString();
                        DGV_LoadUsers.Rows.Add(pcname, ipaddr);
                    }
                    catch
                    {
                        MessageBox.Show("\""+pcname+"\" is shutdown and creating network issues..\n Please restart system...","Be Connect+ - Network Issue",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }

            streamReader.Close();
            netUtility.WaitForExit(1);
            DGV_LoadUsers.ClearSelection();
            this.Cursor = Cursors.Default;
        }

        public void frm_Home_Resize(object sender, EventArgs e)
        {
            label1.Location = new Point(panel1.Width / 2 - label1.Width / 2, label1.Location.Y);
            label3.Location = new Point(panel3.Width / 2 - label1.Width / 2, label3.Location.Y);
        }
        private void DGV_LoadUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Username = DGV_LoadUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                Userip = IPAddress.Parse(DGV_LoadUsers.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
        }
        
        private void DGV_LoadUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
            if (DGV_LoadUsers.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
               (new frm_InputForm()).ShowDialog();              
               ((DataGridViewTextBoxCell)DGV_LoadUsers.Rows[e.RowIndex].Cells[2]).Value = MyInput;
            }
        }
    }
}

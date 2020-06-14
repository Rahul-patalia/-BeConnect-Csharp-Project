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
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;


namespace Be_Connect_
{
    public partial class frm_Chat : Form
    {
        
        public frm_Chat()
        {
            InitializeComponent();
        }

        Socket socket;
        EndPoint Local, Remote;
        byte[] Buffer;

        //================================ User Define Methods =================================

        public void Re_size()
        {
            try
            {
                if (this.Height == 522)
                {
                    splitContainer1.SplitterDistance = panel2.Height * 9;
                }
                else { splitContainer1.SplitterDistance = panel2.Height * 14; }
                Rchtxt_Chat.Height = splitContainer1.Panel1.Height - 70;
                Rchtxt_Chat.Width = splitContainer1.Panel1.Width - 74;
                txt_Placeholder.Height = splitContainer1.Panel2.Height - 60;
                txt_Placeholder.Width = splitContainer1.Panel2.Width - 164;
                btn_Send.Location = new Point(txt_Placeholder.Width + 54, this.btn_Send.Location.Y);
            }
            catch { }
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;

                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                //richTextBox.AppendText(Environment.NewLine + msg);
                //richTextBox.SelectionAlignment = HorizontalAlignment.Right;

                if (Rchtxt_Chat.Text == "")
                {
                    Rchtxt_Chat.SelectionColor = Color.Green; 
                    Rchtxt_Chat.AppendText(Environment.NewLine + frm_Home.Username + " : " + receivedMessage.Trim());
                    Rchtxt_Chat.SelectionAlignment = HorizontalAlignment.Left;
                }
                else
                {
                    Rchtxt_Chat.SelectionColor = Color.Green; 
                    Rchtxt_Chat.AppendText(Environment.NewLine + frm_Home.Username + " : " + receivedMessage.Trim());
                    Rchtxt_Chat.SelectionAlignment = HorizontalAlignment.Left;
                }
                Buffer = new byte[1500];
                socket.BeginReceiveFrom(Buffer, 0, Buffer.Length, SocketFlags.None, ref Remote, new AsyncCallback(MessageCallBack), Buffer);
            }
            catch (InvalidOperationException) 
            { 
                MessageBox.Show("Check your connection", "Be Connect+ - Users are not connected", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void frm_Chat_Load(object sender, EventArgs e)
        {
            lbl_Username.Location = new Point(0, panel2.Height / 4);
            lbl_Username.Text = frm_Home.Username;
            Re_size();
            socket  = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        }
        
        private void frm_Chat_Resize(object sender, EventArgs e)
        {
            Re_size();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                btn_Send_Click(sender, e);                
                txt_Placeholder.Multiline = false;
                txt_Placeholder.Multiline = true;
            }            
        }
        
        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (tn_Connect.Text == "Disconnect")
            {
                if (txt_Placeholder.Text != "")
                {
                    ASCIIEncoding aEncoding = new ASCIIEncoding();
                    byte[] Sendmsg = new byte[1500];
                    Sendmsg = aEncoding.GetBytes(txt_Placeholder.Text);
                    socket.Send(Sendmsg);

                    if (Rchtxt_Chat.Text == "")
                    {
                        Rchtxt_Chat.SelectionColor = Color.Red;
                        Rchtxt_Chat.AppendText(Environment.NewLine + Dns.GetHostName() + " : " + txt_Placeholder.Text.Trim());
                        Rchtxt_Chat.SelectionAlignment = HorizontalAlignment.Right;

                    }
                    else
                    {
                        Rchtxt_Chat.SelectionColor = Color.Red;
                        Rchtxt_Chat.AppendText(Environment.NewLine + Dns.GetHostName() + " : " + txt_Placeholder.Text.Trim());
                        Rchtxt_Chat.SelectionAlignment = HorizontalAlignment.Right;
                    }
                }
                else
                {
                    MessageBox.Show("Enter any Message to send","Be Connect+ - No Message typed",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                txt_Placeholder.Lines = null;
                txt_Placeholder.Clear();
                txt_Placeholder.Focus();
                
                Rchtxt_Chat.SelectionStart = Rchtxt_Chat.Text.Length;
                Rchtxt_Chat.ScrollToCaret();
            }
            else
            {
                MessageBox.Show("Please click Connect button", "Be Connect+ - Users not connected", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void tn_Connect_Click(object sender, EventArgs e)
        {
            if (tn_Connect.Text == "Connect")
            {
                try
                {

                    Local = new IPEndPoint(Dns.GetHostEntry(Dns.GetHostName()).AddressList[1], Convert.ToInt32("80"));
                    socket.Bind(Local);

                    Remote = new IPEndPoint(frm_Home.Userip, Convert.ToInt32("80"));
                    socket.Connect(Remote);

                    Buffer = new byte[1500];
                    socket.BeginReceiveFrom(Buffer, 0, Buffer.Length, SocketFlags.None, ref Remote, new AsyncCallback(MessageCallBack), Buffer);

                    tn_Connect.ForeColor = Color.LimeGreen;
                    tn_Connect.Text = "Disconnect";
                }
                catch
                {
                    MessageBox.Show("Kindly select user first from \"HOME\" tab", "Be connect+ - Select user to chat with", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

                Local = new IPEndPoint(Dns.GetHostEntry(Dns.GetHostName()).AddressList[1], Convert.ToInt32("80"));
                socket.Bind(Local);

                Remote = new IPEndPoint(frm_Home.Userip, Convert.ToInt32("80"));
                socket.Connect(Remote);

                Buffer = new byte[1500];
                socket.BeginReceiveFrom(Buffer, 0, Buffer.Length, SocketFlags.None, ref Remote, new AsyncCallback(MessageCallBack), Buffer);

                tn_Connect.ForeColor = Color.Red;
                tn_Connect.Text = "Connect";
            }
        }
    }
}

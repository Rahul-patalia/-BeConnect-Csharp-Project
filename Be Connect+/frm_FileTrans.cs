using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Be_Connect_
{
    public partial class frm_FileTrans : Form
    {
        public frm_FileTrans()
        {
            InitializeComponent();
        }
        string[] Drives = Directory.GetLogicalDrives();
        
        private void frm_FileTrans_Load(object sender, EventArgs e)
        {
            try
            {
                //Starts Server
                TCPServer obj_server = new TCPServer();
                System.Threading.Thread obj_thread = new System.Threading.Thread(obj_server.StartServer);
                obj_thread.Start();
            }
            catch (Exception e1) { e1.Message.ToString(); }

            lblFileTransfer.Location = new Point(lblFileTransfer.Location.X,panel1.Height/2-lblFileTransfer.Height/2);
            lblFileTransfer.Text += " ("+frm_Home.Username+")";
           
            User_Drives.Focus();
            User_Drives.Nodes.Add("My Computer","My Computer",14,14);
            for (int i = 0; i < Drives.Length - 1; i++)
            {
                Fillnodes(User_Drives.Nodes.Add(Drives[i], Drives[i], 0, 0));
            }
        }

        void Fillnodes(TreeNode node)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DirectoryInfo DI = new DirectoryInfo(node.FullPath);
                DirectoryInfo[] dInfo = DI.GetDirectories()
                .Where(di => !di.Attributes.HasFlag(FileAttributes.System))
                .Where(di => !di.Attributes.HasFlag(FileAttributes.Hidden))
                .ToArray();
                Fillfiles(node);
                foreach (DirectoryInfo di in dInfo)
                {
                    node.Nodes.Add(di.Name, di.Name, 1, 1).Nodes.Add("");
                }
            }
            catch {}
            this.Cursor = Cursors.Default;
        }

        void Fillfiles(TreeNode node)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DirectoryInfo DI = new DirectoryInfo(node.FullPath);
                foreach (var filles in DI.GetFiles())
                {
                    if (filles.ToString().ToLower().Contains(".txt") || filles.ToString().ToLower().Contains(".log") || filles.ToString().ToLower().Contains(".riv") || filles.ToString().ToLower().Contains(".ini"))
                    {
                        node.Nodes.Add(filles.ToString(), filles.ToString(), 2, 2);
                    }
                    else if (filles.ToString().ToLower().Contains(".jpg") || filles.ToString().ToLower().Contains(".png") || filles.ToString().ToLower().Contains(".ico"))
                    {
                        node.Nodes.Add(filles.ToString(), filles.ToString(), 6, 6);
                    }
                    else if (filles.ToString().ToLower().Contains((".mkv")) || filles.ToString().ToLower().Contains(".webm") || filles.ToString().ToLower().Contains(".flv") ||
                             filles.ToString().ToLower().Contains(".vob") || filles.ToString().ToLower().Contains(".gif") || filles.ToString().ToLower().Contains(".avi") ||
                             filles.ToString().ToLower().Contains(".mp4") || filles.ToString().ToLower().Contains(".m4v") | filles.ToString().ToLower().Contains(".3gp"))
                    {
                        node.Nodes.Add(filles.ToString(), filles.ToString(), 8, 8);
                    }
                    else if (filles.ToString().ToLower().Contains(".exe"))
                    {
                        node.Nodes.Add(filles.ToString(), filles.ToString(), 3, 3);
                    }
                    else if (filles.ToString().ToLower().Contains(".bat") || filles.ToString().ToLower().Contains(".info"))
                    {
                        node.Nodes.Add(filles.ToString(), filles.ToString(), 5, 5);
                    }
                    else if (filles.ToString().ToLower().Contains(".iso"))
                    {
                        node.Nodes.Add(filles.ToString(), filles.ToString(), 4, 4);
                    }
                    else if (filles.ToString().ToLower().Contains(".zip") || filles.ToString().ToLower().Contains(".rar") || filles.ToString().ToLower().Contains(".7z"))
                    {
                        node.Nodes.Add(filles.ToString(), filles.ToString(), 10, 10);
                    }
                    else if (filles.ToString().ToLower().Contains(".word") || filles.ToString().ToLower().Contains(".rtf"))
                    {
                        node.Nodes.Add(filles.ToString(), filles.ToString(), 9, 9);
                    }
                    else if (filles.ToString().ToLower().Contains(".pdf"))
                    {
                        node.Nodes.Add(filles.ToString(), filles.ToString(), 11, 11);
                    }
                    else if (filles.ToString().ToLower().Contains(".html") || filles.ToString().ToLower().Contains(".php") || filles.ToString().ToLower().Contains(".jsp") || filles.ToString().ToLower().Contains(".com"))
                    {
                        node.Nodes.Add(filles.ToString(), filles.ToString(), 13, 13);
                    }
                    else
                    {
                        node.Nodes.Add(filles.ToString(), filles.ToString(), 12, 12);
                    }
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message.ToString()); }
            this.Cursor = Cursors.Default;
        }

        private void User_Drives_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "")
            {
                e.Node.Nodes.Clear();
                Fillnodes(e.Node);
            }
        }

        private void User_Drives_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Node.Text.Contains("."))
                {
                    System.Diagnostics.Process.Start(e.Node.FullPath);
                }
            }
            catch
            {
                MessageBox.Show("File not found.");
            }
        }

        private void User_Drives_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (User_Drives.SelectedNode.Text.Contains("."))
                    {
                        System.Diagnostics.Process.Start(User_Drives.SelectedNode.FullPath);
                    }
                }
                catch
                {
                    MessageBox.Show("File not found.");
                }
            }
        }        

        public void frm_FileTrans_Resize(object sender, EventArgs e)
        {
            User_Drives.Height = this.Height - 120;
            pb_upload.Width = panel2.Width - 164;
            btn_SendFile.Location = new Point(pb_upload.Width + 54, this.btn_SendFile.Location.Y);
        }

        private void btn_SendFile_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (lbl_Path.Text != "")
            {
                String selected_file = User_Drives.SelectedNode.FullPath;
                String file_name = Path.GetFileName(selected_file);
                try
                {
                    FileStream fs = new FileStream(selected_file, FileMode.Open);
                    TcpClient tc = new TcpClient(frm_Home.Userip.ToString(), 6868);
                    NetworkStream ns = tc.GetStream();
                    byte[] data_tosend = CreateDataPacket(Encoding.UTF8.GetBytes("125"), Encoding.UTF8.GetBytes(file_name));
                    ns.Write(data_tosend, 0, data_tosend.Length);
                    ns.Flush();
                    Boolean loop_break = false;
                    while (true)
                    {
                        if (ns.ReadByte() == 2)
                        {
                            byte[] cmd_buff = new byte[3];
                            ns.Read(cmd_buff, 0, cmd_buff.Length);
                            byte[] recv_data = ReadStream(ns);
                            switch (Convert.ToInt32(Encoding.UTF8.GetString(cmd_buff)))
                            {
                                case 126:
                                    long recv_file_pointer = long.Parse(Encoding.UTF8.GetString(recv_data));
                                    if (recv_file_pointer != fs.Length)
                                    {
                                        fs.Seek(recv_file_pointer, SeekOrigin.Begin);
                                        int temp_buff_length = (int)(fs.Length - recv_file_pointer < 20000 ? fs.Length - recv_file_pointer : 20000);
                                        byte[] temp_buff = new byte[temp_buff_length];
                                        fs.Read(temp_buff, 0, temp_buff.Length);
                                        byte[] data_to_send = CreateDataPacket(Encoding.UTF8.GetBytes("127"), temp_buff);
                                        ns.Write(data_to_send, 0, data_to_send.Length);
                                        ns.Flush();
                                        //Shows Progressbar Value
                                        pb_upload.Value = (int)Math.Ceiling((double)recv_file_pointer / (double)fs.Length * 100);
                                    }
                                    else
                                    {
                                        byte[] data_to_send = CreateDataPacket(Encoding.UTF8.GetBytes("128"), Encoding.UTF8.GetBytes("Close"));
                                        ns.Write(data_to_send, 0, data_to_send.Length);
                                        ns.Flush();
                                        fs.Close();
                                        loop_break = true;
                                        MessageBox.Show("File Successfully sent to "+frm_Home.Username+"", "Be Connect+ - File Sent",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                        pb_upload.Value = 0;
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (loop_break == true)
                        {
                            ns.Close();
                            lbl_Path.Visible = false;
                            break;
                        }
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Please select a file", "Be Connect+ - File not selected", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                //Directly goes to Home if following two exceptions occures
                catch (Exception Ex)
                {
                    if (Ex is NullReferenceException || Ex is IOException)
                    {
                        if (MessageBox.Show("Please select a user to send file", "Be Connect+ - User not selected", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                        {

                        }
                    }
                    else if (Ex is SocketException)
                    {
                        MessageBox.Show("User : "+frm_Home.Username+" is not currently using this service","Be Connect+ - User not Connected",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Kindly, First select file to be sent","Be Connect+ - File not selected");
            }
            this.Cursor = Cursors.Default;
               
        }
             

        public byte[] ReadStream(NetworkStream ns)
        {
            byte[] data_buff = null;

            int b = 0;
            String buff_length = "";
            while ((b = ns.ReadByte()) != 4)
            {
                buff_length += (char)b;
            }
            int data_length = Convert.ToInt32(buff_length);
            data_buff = new byte[data_length];
            int byte_read = 0;
            int byte_offset = 0;
            while (byte_offset < data_length)
            {
                byte_read = ns.Read(data_buff, byte_offset, data_length - byte_offset);
                byte_offset += byte_read;
            }

            return data_buff;
        }
        private byte[] CreateDataPacket(byte[] cmd, byte[] data)
        {
            byte[] initialize = new byte[1];
            initialize[0] = 2;
            byte[] separator = new byte[1];
            separator[0] = 4;
            byte[] datalength = Encoding.UTF8.GetBytes(Convert.ToString(data.Length));
            MemoryStream ms = new MemoryStream();
            ms.Write(initialize, 0, initialize.Length);
            ms.Write(cmd, 0, cmd.Length);
            ms.Write(datalength, 0, datalength.Length);
            ms.Write(separator, 0, separator.Length);
            ms.Write(data, 0, data.Length);
            return ms.ToArray();
        }

        private void User_Drives_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lbl_Path.Text = "Selected File : "+User_Drives.SelectedNode.FullPath;
        }

    }
    
    class TCPServer
    {
        TcpListener obj_server;
        public TCPServer()
        {
            obj_server = new TcpListener(IPAddress.Parse(System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList[0].ToString()), 6868);
        }

        public void StartServer()
        {
            try
            {
                obj_server.Start();
            
                while (true)
                {
                    TcpClient tc = obj_server.AcceptTcpClient();
                    SocketHandler obj_handler = new SocketHandler(tc);
                    System.Threading.Thread obj_thread = new System.Threading.Thread(obj_handler.ProcessSocketRequest);
                    obj_thread.Start();
                }
            }
            catch (Exception e) { e.Message.ToString(); }
            
        }

        class SocketHandler
        {
            NetworkStream ns;
            public SocketHandler(TcpClient tc)
            {
                ns = tc.GetStream();
            }

            public void ProcessSocketRequest()
            {
                FileStream fs = null;
                long current_file_pointer = 0;
                Boolean loop_break = false;
                while (true)
                {
                    if (ns.ReadByte() == 2)
                    {
                        byte[] cmd_buff = new byte[3];
                        ns.Read(cmd_buff, 0, cmd_buff.Length);
                        byte[] recv_data = ReadStream();
                        switch (Convert.ToInt32(Encoding.UTF8.GetString(cmd_buff)))
                        {
                            case 125:
                                {
                                    //Destination File Path
                                    fs = new FileStream(@"C:\" + Encoding.UTF8.GetString(recv_data), FileMode.Create);
                                    byte[] data_to_send = CreateDataPacket(Encoding.UTF8.GetBytes("126"), Encoding.UTF8.GetBytes(Convert.ToString(current_file_pointer)));
                                    ns.Write(data_to_send, 0, data_to_send.Length);
                                    ns.Flush();
                                }
                                break;
                            case 127:
                                {
                                    fs.Seek(current_file_pointer, SeekOrigin.Begin);
                                    fs.Write(recv_data, 0, recv_data.Length);
                                    current_file_pointer = fs.Position;
                                    byte[] data_to_send = CreateDataPacket(Encoding.UTF8.GetBytes("126"), Encoding.UTF8.GetBytes(Convert.ToString(current_file_pointer)));
                                    ns.Write(data_to_send, 0, data_to_send.Length);
                                    ns.Flush();
                                }
                                break;
                            case 128:
                                {
                                    fs.Close();
                                    loop_break = true;
                                    MessageBox.Show("File Successfully received", "Be Connect+ - File Sent",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    if (loop_break == true)
                    {
                        ns.Close();
                        break;
                    }
                }
            }

            public byte[] ReadStream()
            {
                byte[] data_buff = null;

                int b = 0;
                String buff_length = "";
                while ((b = ns.ReadByte()) != 4)
                {
                    buff_length += (char)b;
                }
                int data_length = Convert.ToInt32(buff_length);
                data_buff = new byte[data_length];
                int byte_read = 0;
                int byte_offset = 0;
                while (byte_offset < data_length)
                {
                    byte_read = ns.Read(data_buff, byte_offset, data_length - byte_offset);
                    byte_offset += byte_read;
                }

                return data_buff;
            }

            private byte[] CreateDataPacket(byte[] cmd, byte[] data)
            {
                byte[] initialize = new byte[1];
                initialize[0] = 2;
                byte[] separator = new byte[1];
                separator[0] = 4;
                byte[] datalength = Encoding.UTF8.GetBytes(Convert.ToString(data.Length));
                MemoryStream ms = new MemoryStream();
                ms.Write(initialize, 0, initialize.Length);
                ms.Write(cmd, 0, cmd.Length);
                ms.Write(datalength, 0, datalength.Length);
                ms.Write(separator, 0, separator.Length);
                ms.Write(data, 0, data.Length);
                return ms.ToArray();
            }
        }
    }
}

namespace Be_Connect_
{
    partial class frm_FileTrans
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FileTrans));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFileTransfer = new System.Windows.Forms.Label();
            this.User_Drives = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Path = new System.Windows.Forms.Label();
            this.btn_SendFile = new System.Windows.Forms.Button();
            this.pb_upload = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(190)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.lblFileTransfer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 40);
            this.panel1.TabIndex = 1;
            // 
            // lblFileTransfer
            // 
            this.lblFileTransfer.AutoSize = true;
            this.lblFileTransfer.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblFileTransfer.Location = new System.Drawing.Point(3, 9);
            this.lblFileTransfer.Name = "lblFileTransfer";
            this.lblFileTransfer.Size = new System.Drawing.Size(138, 17);
            this.lblFileTransfer.TabIndex = 0;
            this.lblFileTransfer.Text = "Select File to Send";
            // 
            // User_Drives
            // 
            this.User_Drives.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User_Drives.Dock = System.Windows.Forms.DockStyle.Top;
            this.User_Drives.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Drives.ImageIndex = 0;
            this.User_Drives.ImageList = this.imageList1;
            this.User_Drives.ItemHeight = 25;
            this.User_Drives.Location = new System.Drawing.Point(0, 40);
            this.User_Drives.Name = "User_Drives";
            this.User_Drives.SelectedImageIndex = 0;
            this.User_Drives.Size = new System.Drawing.Size(664, 400);
            this.User_Drives.TabIndex = 2;
            this.User_Drives.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.User_Drives_BeforeExpand);
            this.User_Drives.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.User_Drives_AfterSelect);
            this.User_Drives.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.User_Drives_NodeMouseDoubleClick);
            this.User_Drives.KeyDown += new System.Windows.Forms.KeyEventHandler(this.User_Drives_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "drive");
            this.imageList1.Images.SetKeyName(1, "folder");
            this.imageList1.Images.SetKeyName(2, "notepad");
            this.imageList1.Images.SetKeyName(3, "exe");
            this.imageList1.Images.SetKeyName(4, "ISO");
            this.imageList1.Images.SetKeyName(5, "bat");
            this.imageList1.Images.SetKeyName(6, "Image");
            this.imageList1.Images.SetKeyName(7, "music");
            this.imageList1.Images.SetKeyName(8, "video");
            this.imageList1.Images.SetKeyName(9, "word");
            this.imageList1.Images.SetKeyName(10, "zipped");
            this.imageList1.Images.SetKeyName(11, "PDF");
            this.imageList1.Images.SetKeyName(12, "Unknown");
            this.imageList1.Images.SetKeyName(13, "Web");
            this.imageList1.Images.SetKeyName(14, "Computer");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbl_Path);
            this.panel2.Controls.Add(this.btn_SendFile);
            this.panel2.Controls.Add(this.pb_upload);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 80);
            this.panel2.TabIndex = 11;
            // 
            // lbl_Path
            // 
            this.lbl_Path.AutoSize = true;
            this.lbl_Path.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Path.Location = new System.Drawing.Point(16, 53);
            this.lbl_Path.Name = "lbl_Path";
            this.lbl_Path.Size = new System.Drawing.Size(0, 18);
            this.lbl_Path.TabIndex = 14;
            // 
            // btn_SendFile
            // 
            this.btn_SendFile.BackColor = System.Drawing.Color.Lime;
            this.btn_SendFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SendFile.BackgroundImage")));
            this.btn_SendFile.FlatAppearance.BorderSize = 0;
            this.btn_SendFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SendFile.Location = new System.Drawing.Point(603, 16);
            this.btn_SendFile.Name = "btn_SendFile";
            this.btn_SendFile.Size = new System.Drawing.Size(46, 43);
            this.btn_SendFile.TabIndex = 11;
            this.btn_SendFile.UseVisualStyleBackColor = false;
            this.btn_SendFile.Click += new System.EventHandler(this.btn_SendFile_Click);
            // 
            // pb_upload
            // 
            this.pb_upload.Location = new System.Drawing.Point(12, 16);
            this.pb_upload.Name = "pb_upload";
            this.pb_upload.Size = new System.Drawing.Size(585, 23);
            this.pb_upload.TabIndex = 13;
            // 
            // frm_FileTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.User_Drives);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_FileTrans";
            this.Tag = "File Transfer";
            this.Text = "File Transfer";
            this.Load += new System.EventHandler(this.frm_FileTrans_Load);
            this.Resize += new System.EventHandler(this.frm_FileTrans_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView User_Drives;
        private System.Windows.Forms.Label lblFileTransfer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar pb_upload;
        private System.Windows.Forms.Button btn_SendFile;
        private System.Windows.Forms.Label lbl_Path;

    }
}
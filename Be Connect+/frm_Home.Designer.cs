namespace Be_Connect_
{
    partial class frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Domain = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_IPAddress = new System.Windows.Forms.Label();
            this.lbl_PCname = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DGV_LoadUsers = new System.Windows.Forms.DataGridView();
            this.User_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LoadUsers)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Domain);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Status);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_IPAddress);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_PCname);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Username);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DGV_LoadUsers);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(885, 522);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(190)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 61);
            this.panel1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F);
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Be Connect+ User Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Domain
            // 
            this.lbl_Domain.AutoSize = true;
            this.lbl_Domain.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Domain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Domain.Font = new System.Drawing.Font("Verdana", 11F);
            this.lbl_Domain.Location = new System.Drawing.Point(39, 456);
            this.lbl_Domain.Name = "lbl_Domain";
            this.lbl_Domain.Size = new System.Drawing.Size(40, 18);
            this.lbl_Domain.TabIndex = 34;
            this.lbl_Domain.Text = "Test";
            this.lbl_Domain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Status.Font = new System.Drawing.Font("Verdana", 11F);
            this.lbl_Status.Location = new System.Drawing.Point(39, 403);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(40, 18);
            this.lbl_Status.TabIndex = 33;
            this.lbl_Status.Text = "Test";
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_IPAddress
            // 
            this.lbl_IPAddress.AutoSize = true;
            this.lbl_IPAddress.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IPAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_IPAddress.Font = new System.Drawing.Font("Verdana", 11F);
            this.lbl_IPAddress.Location = new System.Drawing.Point(39, 350);
            this.lbl_IPAddress.Name = "lbl_IPAddress";
            this.lbl_IPAddress.Size = new System.Drawing.Size(40, 18);
            this.lbl_IPAddress.TabIndex = 32;
            this.lbl_IPAddress.Text = "Test";
            this.lbl_IPAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_PCname
            // 
            this.lbl_PCname.AutoSize = true;
            this.lbl_PCname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PCname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_PCname.Font = new System.Drawing.Font("Verdana", 11F);
            this.lbl_PCname.Location = new System.Drawing.Point(39, 297);
            this.lbl_PCname.Name = "lbl_PCname";
            this.lbl_PCname.Size = new System.Drawing.Size(40, 18);
            this.lbl_PCname.TabIndex = 31;
            this.lbl_PCname.Text = "Test";
            this.lbl_PCname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Username
            // 
            this.lbl_Username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Username.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Username.Font = new System.Drawing.Font("Verdana", 11F);
            this.lbl_Username.Location = new System.Drawing.Point(62, 248);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(166, 18);
            this.lbl_Username.TabIndex = 30;
            this.lbl_Username.Text = "Test";
            this.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // DGV_LoadUsers
            // 
            this.DGV_LoadUsers.AllowUserToAddRows = false;
            this.DGV_LoadUsers.AllowUserToDeleteRows = false;
            this.DGV_LoadUsers.AllowUserToOrderColumns = true;
            this.DGV_LoadUsers.AllowUserToResizeColumns = false;
            this.DGV_LoadUsers.AllowUserToResizeRows = false;
            this.DGV_LoadUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_LoadUsers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DGV_LoadUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(190)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_LoadUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_LoadUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_LoadUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_Name,
            this.IP_Address});
            this.DGV_LoadUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGV_LoadUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_LoadUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_LoadUsers.Location = new System.Drawing.Point(0, 61);
            this.DGV_LoadUsers.Name = "DGV_LoadUsers";
            this.DGV_LoadUsers.RowHeadersVisible = false;
            this.DGV_LoadUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_LoadUsers.ShowEditingIcon = false;
            this.DGV_LoadUsers.Size = new System.Drawing.Size(584, 461);
            this.DGV_LoadUsers.TabIndex = 40;
            this.DGV_LoadUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_LoadUsers_CellClick);
            this.DGV_LoadUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_LoadUsers_CellContentClick);
            // 
            // User_Name
            // 
            this.User_Name.HeaderText = "Name";
            this.User_Name.Name = "User_Name";
            // 
            // IP_Address
            // 
            this.IP_Address.HeaderText = "IP Address";
            this.IP_Address.Name = "IP_Address";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(190)))), ((int)(((byte)(81)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 61);
            this.panel3.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Verdana", 14F);
            this.label3.Location = new System.Drawing.Point(31, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "List of Connected Users";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 522);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Home";
            this.Text = "frm_Home";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.Resize += new System.EventHandler(this.frm_Home_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LoadUsers)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_Domain;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_IPAddress;
        private System.Windows.Forms.Label lbl_PCname;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView DGV_LoadUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP_Address;
    }
}
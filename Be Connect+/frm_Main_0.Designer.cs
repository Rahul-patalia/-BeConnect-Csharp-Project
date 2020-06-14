namespace Be_Connect_
{
    partial class Frm_Main0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main0));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_Becnn = new System.Windows.Forms.Label();
            this.lbl_SelectedTab = new System.Windows.Forms.Label();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Resize = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_About = new System.Windows.Forms.Button();
            this.btn_FileTransh = new System.Windows.Forms.Button();
            this.btn_RemoteDesk = new System.Windows.Forms.Button();
            this.btn_Chat = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.panel3.Controls.Add(this.label_Becnn);
            this.panel3.Controls.Add(this.lbl_SelectedTab);
            this.panel3.Controls.Add(this.btn_Minimize);
            this.panel3.Controls.Add(this.btn_Resize);
            this.panel3.Controls.Add(this.btn_Exit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(938, 33);
            this.panel3.TabIndex = 14;
            // 
            // label_Becnn
            // 
            this.label_Becnn.AutoSize = true;
            this.label_Becnn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Becnn.ForeColor = System.Drawing.Color.White;
            this.label_Becnn.Location = new System.Drawing.Point(3, 7);
            this.label_Becnn.Name = "label_Becnn";
            this.label_Becnn.Size = new System.Drawing.Size(114, 18);
            this.label_Becnn.TabIndex = 6;
            this.label_Becnn.Text = "Be Connect+";
            this.label_Becnn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SelectedTab
            // 
            this.lbl_SelectedTab.AutoSize = true;
            this.lbl_SelectedTab.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectedTab.ForeColor = System.Drawing.Color.White;
            this.lbl_SelectedTab.Location = new System.Drawing.Point(306, 0);
            this.lbl_SelectedTab.Name = "lbl_SelectedTab";
            this.lbl_SelectedTab.Size = new System.Drawing.Size(0, 18);
            this.lbl_SelectedTab.TabIndex = 5;
            this.lbl_SelectedTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.AutoSize = true;
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.ForeColor = System.Drawing.Color.White;
            this.btn_Minimize.Location = new System.Drawing.Point(830, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(36, 33);
            this.btn_Minimize.TabIndex = 4;
            this.btn_Minimize.Text = "—";
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.frm_Resize);
            this.btn_Minimize.MouseEnter += new System.EventHandler(this.ChangeColor);
            this.btn_Minimize.MouseLeave += new System.EventHandler(this.Mouseleave);
            this.btn_Minimize.MouseHover += new System.EventHandler(this.show_Tooltip);
            // 
            // btn_Resize
            // 
            this.btn_Resize.AutoSize = true;
            this.btn_Resize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Resize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Resize.FlatAppearance.BorderSize = 0;
            this.btn_Resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Resize.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Resize.ForeColor = System.Drawing.Color.White;
            this.btn_Resize.Location = new System.Drawing.Point(866, 0);
            this.btn_Resize.Name = "btn_Resize";
            this.btn_Resize.Size = new System.Drawing.Size(36, 33);
            this.btn_Resize.TabIndex = 3;
            this.btn_Resize.Tag = "";
            this.btn_Resize.Text = "||";
            this.btn_Resize.UseVisualStyleBackColor = false;
            this.btn_Resize.Click += new System.EventHandler(this.frm_Resize);
            this.btn_Resize.MouseEnter += new System.EventHandler(this.ChangeColor);
            this.btn_Resize.MouseLeave += new System.EventHandler(this.Mouseleave);
            this.btn_Resize.MouseHover += new System.EventHandler(this.show_Tooltip);
            // 
            // btn_Exit
            // 
            this.btn_Exit.AutoSize = true;
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(902, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(36, 33);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.frm_Resize);
            this.btn_Exit.MouseEnter += new System.EventHandler(this.ChangeColor);
            this.btn_Exit.MouseLeave += new System.EventHandler(this.Mouseleave);
            this.btn_Exit.MouseHover += new System.EventHandler(this.show_Tooltip);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.btn_About);
            this.panel1.Controls.Add(this.btn_FileTransh);
            this.panel1.Controls.Add(this.btn_RemoteDesk);
            this.panel1.Controls.Add(this.btn_Chat);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 522);
            this.panel1.TabIndex = 17;
            // 
            // btn_About
            // 
            this.btn_About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(190)))), ((int)(((byte)(81)))));
            this.btn_About.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_About.BackgroundImage")));
            this.btn_About.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_About.FlatAppearance.BorderSize = 0;
            this.btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_About.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_About.ForeColor = System.Drawing.Color.Black;
            this.btn_About.Location = new System.Drawing.Point(0, 208);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(55, 52);
            this.btn_About.TabIndex = 10;
            this.btn_About.Tag = "About";
            this.btn_About.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_About.UseVisualStyleBackColor = false;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            this.btn_About.MouseHover += new System.EventHandler(this.show_Tooltip);
            // 
            // btn_FileTransh
            // 
            this.btn_FileTransh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(190)))), ((int)(((byte)(81)))));
            this.btn_FileTransh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_FileTransh.BackgroundImage")));
            this.btn_FileTransh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_FileTransh.FlatAppearance.BorderSize = 0;
            this.btn_FileTransh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FileTransh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FileTransh.ForeColor = System.Drawing.Color.Black;
            this.btn_FileTransh.Location = new System.Drawing.Point(0, 156);
            this.btn_FileTransh.Name = "btn_FileTransh";
            this.btn_FileTransh.Size = new System.Drawing.Size(55, 52);
            this.btn_FileTransh.TabIndex = 9;
            this.btn_FileTransh.Tag = "File Transfer";
            this.btn_FileTransh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_FileTransh.UseVisualStyleBackColor = false;
            this.btn_FileTransh.Click += new System.EventHandler(this.btn_FileTransh_Click);
            this.btn_FileTransh.MouseHover += new System.EventHandler(this.show_Tooltip);
            // 
            // btn_RemoteDesk
            // 
            this.btn_RemoteDesk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(190)))), ((int)(((byte)(81)))));
            this.btn_RemoteDesk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_RemoteDesk.BackgroundImage")));
            this.btn_RemoteDesk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_RemoteDesk.FlatAppearance.BorderSize = 0;
            this.btn_RemoteDesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoteDesk.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoteDesk.ForeColor = System.Drawing.Color.Black;
            this.btn_RemoteDesk.Location = new System.Drawing.Point(0, 104);
            this.btn_RemoteDesk.Name = "btn_RemoteDesk";
            this.btn_RemoteDesk.Size = new System.Drawing.Size(55, 52);
            this.btn_RemoteDesk.TabIndex = 8;
            this.btn_RemoteDesk.Tag = "Remote Desktop Connection";
            this.btn_RemoteDesk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_RemoteDesk.UseVisualStyleBackColor = false;
            this.btn_RemoteDesk.Click += new System.EventHandler(this.btn_RemoteDesk_Click);
            this.btn_RemoteDesk.MouseHover += new System.EventHandler(this.show_Tooltip);
            // 
            // btn_Chat
            // 
            this.btn_Chat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(190)))), ((int)(((byte)(81)))));
            this.btn_Chat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Chat.BackgroundImage")));
            this.btn_Chat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Chat.FlatAppearance.BorderSize = 0;
            this.btn_Chat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Chat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chat.ForeColor = System.Drawing.Color.Black;
            this.btn_Chat.Location = new System.Drawing.Point(0, 52);
            this.btn_Chat.Name = "btn_Chat";
            this.btn_Chat.Size = new System.Drawing.Size(55, 52);
            this.btn_Chat.TabIndex = 7;
            this.btn_Chat.Tag = "Chat";
            this.btn_Chat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Chat.UseVisualStyleBackColor = false;
            this.btn_Chat.Click += new System.EventHandler(this.btn_Chat_Click);
            this.btn_Chat.MouseHover += new System.EventHandler(this.show_Tooltip);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(190)))), ((int)(((byte)(81)))));
            this.btn_Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Home.BackgroundImage")));
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.Black;
            this.btn_Home.Location = new System.Drawing.Point(0, 0);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Padding = new System.Windows.Forms.Padding(4);
            this.btn_Home.Size = new System.Drawing.Size(55, 52);
            this.btn_Home.TabIndex = 6;
            this.btn_Home.Tag = "Home";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            this.btn_Home.MouseHover += new System.EventHandler(this.show_Tooltip);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(55, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 522);
            this.panel2.TabIndex = 26;
            // 
            // Frm_Main0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 555);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Frm_Main0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Be Connect+ - Home";
            this.Load += new System.EventHandler(this.Frm_Main0_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Button btn_FileTransh;
        private System.Windows.Forms.Button btn_RemoteDesk;
        private System.Windows.Forms.Button btn_Chat;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Resize;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Label lbl_SelectedTab;
        private System.Windows.Forms.Label label_Becnn;
        public System.Windows.Forms.Panel panel2;


    }
}
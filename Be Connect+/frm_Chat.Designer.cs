namespace Be_Connect_
{
    partial class frm_Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Chat));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tn_Connect = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Rchtxt_Chat = new System.Windows.Forms.RichTextBox();
            this.txt_Placeholder = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(190)))), ((int)(((byte)(81)))));
            this.panel2.Controls.Add(this.tn_Connect);
            this.panel2.Controls.Add(this.lbl_Username);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 40);
            this.panel2.TabIndex = 2;
            // 
            // tn_Connect
            // 
            this.tn_Connect.Dock = System.Windows.Forms.DockStyle.Right;
            this.tn_Connect.FlatAppearance.BorderSize = 0;
            this.tn_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tn_Connect.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tn_Connect.ForeColor = System.Drawing.Color.Red;
            this.tn_Connect.Location = new System.Drawing.Point(558, 0);
            this.tn_Connect.Name = "tn_Connect";
            this.tn_Connect.Size = new System.Drawing.Size(106, 40);
            this.tn_Connect.TabIndex = 6;
            this.tn_Connect.Text = "Connect";
            this.tn_Connect.UseVisualStyleBackColor = true;
            this.tn_Connect.Click += new System.EventHandler(this.tn_Connect_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(6, 9);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(42, 18);
            this.lbl_Username.TabIndex = 2;
            this.lbl_Username.Text = "User";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.Rchtxt_Chat);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel2.Controls.Add(this.txt_Placeholder);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Send);
            this.splitContainer1.Size = new System.Drawing.Size(664, 482);
            this.splitContainer1.SplitterDistance = 370;
            this.splitContainer1.TabIndex = 4;
            // 
            // Rchtxt_Chat
            // 
            this.Rchtxt_Chat.BackColor = System.Drawing.Color.White;
            this.Rchtxt_Chat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rchtxt_Chat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Rchtxt_Chat.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rchtxt_Chat.ForeColor = System.Drawing.Color.Red;
            this.Rchtxt_Chat.Location = new System.Drawing.Point(39, 32);
            this.Rchtxt_Chat.Name = "Rchtxt_Chat";
            this.Rchtxt_Chat.ReadOnly = true;
            this.Rchtxt_Chat.Size = new System.Drawing.Size(590, 290);
            this.Rchtxt_Chat.TabIndex = 0;
            this.Rchtxt_Chat.Text = "";
            // 
            // txt_Placeholder
            // 
            this.txt_Placeholder.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Placeholder.Location = new System.Drawing.Point(29, 26);
            this.txt_Placeholder.Multiline = true;
            this.txt_Placeholder.Name = "txt_Placeholder";
            this.txt_Placeholder.Size = new System.Drawing.Size(500, 58);
            this.txt_Placeholder.TabIndex = 4;
            this.txt_Placeholder.WordWrap = false;
            this.txt_Placeholder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.Color.Lime;
            this.btn_Send.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Send.BackgroundImage")));
            this.btn_Send.FlatAppearance.BorderSize = 0;
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Send.Location = new System.Drawing.Point(558, 26);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(46, 43);
            this.btn_Send.TabIndex = 6;
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // frm_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 522);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Chat";
            this.RightToLeftLayout = true;
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.frm_Chat_Load);
            this.Resize += new System.EventHandler(this.frm_Chat_Resize);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox Rchtxt_Chat;
        private System.Windows.Forms.TextBox txt_Placeholder;
        private System.Windows.Forms.Button btn_Send;
        public System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Button tn_Connect;
    }
}
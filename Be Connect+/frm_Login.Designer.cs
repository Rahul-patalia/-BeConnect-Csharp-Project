namespace Be_Connect_
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.lbl_Exit = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Minimize = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_ID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_Password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chck_show_hide = new MaterialSkin.Controls.MaterialCheckBox();
            this.btn_Login = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Signin = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_newpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_newuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btn_newlogin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Exit.Depth = 0;
            this.lbl_Exit.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Exit.Location = new System.Drawing.Point(365, 1);
            this.lbl_Exit.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_Exit.Size = new System.Drawing.Size(26, 27);
            this.lbl_Exit.TabIndex = 1;
            this.lbl_Exit.Text = "X";
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click_1);
            this.lbl_Exit.MouseEnter += new System.EventHandler(this.MouseHover);
            this.lbl_Exit.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // lbl_Minimize
            // 
            this.lbl_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Minimize.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Minimize.Location = new System.Drawing.Point(339, 1);
            this.lbl_Minimize.Name = "lbl_Minimize";
            this.lbl_Minimize.Padding = new System.Windows.Forms.Padding(4);
            this.lbl_Minimize.Size = new System.Drawing.Size(26, 27);
            this.lbl_Minimize.TabIndex = 4;
            this.lbl_Minimize.Text = "—";
            this.lbl_Minimize.Click += new System.EventHandler(this.lbl_Exit_Click_1);
            this.lbl_Minimize.MouseEnter += new System.EventHandler(this.MouseHover);
            this.lbl_Minimize.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(116, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txt_ID
            // 
            this.txt_ID.Depth = 0;
            this.txt_ID.Hint = "";
            this.txt_ID.Location = new System.Drawing.Point(32, 302);
            this.txt_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.PasswordChar = '\0';
            this.txt_ID.SelectedText = "";
            this.txt_ID.SelectionLength = 0;
            this.txt_ID.SelectionStart = 0;
            this.txt_ID.Size = new System.Drawing.Size(330, 23);
            this.txt_ID.TabIndex = 6;
            this.txt_ID.Tag = "txt_ID";
            this.txt_ID.Text = "Enter Your ID";
            this.txt_ID.UseSystemPasswordChar = false;
            this.txt_ID.Enter += new System.EventHandler(this.MouseEnter);
            this.txt_ID.Leave += new System.EventHandler(this.txt_ID_Leave_1);
            // 
            // txt_Password
            // 
            this.txt_Password.Depth = 0;
            this.txt_Password.Hint = "";
            this.txt_Password.Location = new System.Drawing.Point(32, 349);
            this.txt_Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '\0';
            this.txt_Password.SelectedText = "";
            this.txt_Password.SelectionLength = 0;
            this.txt_Password.SelectionStart = 0;
            this.txt_Password.Size = new System.Drawing.Size(330, 23);
            this.txt_Password.TabIndex = 7;
            this.txt_Password.Tag = "txt_Password";
            this.txt_Password.Text = "Enter Your Password";
            this.txt_Password.UseSystemPasswordChar = false;
            this.txt_Password.Enter += new System.EventHandler(this.MouseEnter);
            this.txt_Password.Leave += new System.EventHandler(this.txt_ID_Leave_1);
            // 
            // chck_show_hide
            // 
            this.chck_show_hide.AutoSize = true;
            this.chck_show_hide.Depth = 0;
            this.chck_show_hide.Enabled = false;
            this.chck_show_hide.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_show_hide.Location = new System.Drawing.Point(339, 350);
            this.chck_show_hide.Margin = new System.Windows.Forms.Padding(0);
            this.chck_show_hide.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_show_hide.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_show_hide.Name = "chck_show_hide";
            this.chck_show_hide.Ripple = false;
            this.chck_show_hide.Size = new System.Drawing.Size(21, 20);
            this.chck_show_hide.TabIndex = 8;
            this.chck_show_hide.UseVisualStyleBackColor = true;
            this.chck_show_hide.CheckedChanged += new System.EventHandler(this.chck_show_hide_CheckedChanged);
            this.chck_show_hide.MouseHover += new System.EventHandler(this.chck_show_hide_MouseHover);
            // 
            // btn_Login
            // 
            this.btn_Login.Depth = 0;
            this.btn_Login.Location = new System.Drawing.Point(319, 422);
            this.btn_Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Primary = true;
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 9;
            this.btn_Login.Text = "log in";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.btn_Signin);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_newpass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_newuser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(390, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 444);
            this.panel1.TabIndex = 10;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Location = new System.Drawing.Point(0, 421);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(64, 23);
            this.btn_Back.TabIndex = 12;
            this.btn_Back.Text = "< Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(116, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(215, 379);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(62, 23);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Visible = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Signin
            // 
            this.btn_Signin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btn_Signin.FlatAppearance.BorderSize = 0;
            this.btn_Signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Signin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Signin.ForeColor = System.Drawing.Color.White;
            this.btn_Signin.Location = new System.Drawing.Point(283, 379);
            this.btn_Signin.Name = "btn_Signin";
            this.btn_Signin.Size = new System.Drawing.Size(73, 23);
            this.btn_Signin.TabIndex = 8;
            this.btn_Signin.Text = "Sign up";
            this.btn_Signin.UseVisualStyleBackColor = false;
            this.btn_Signin.Visible = false;
            this.btn_Signin.Click += new System.EventHandler(this.btn_Signin_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Verdana", 9F);
            this.txt_Email.Location = new System.Drawing.Point(134, 351);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(224, 22);
            this.txt_Email.TabIndex = 7;
            this.txt_Email.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F);
            this.label4.Location = new System.Drawing.Point(16, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-Mail Address : ";
            this.label4.Visible = false;
            // 
            // txt_newpass
            // 
            this.txt_newpass.Font = new System.Drawing.Font("Verdana", 9F);
            this.txt_newpass.Location = new System.Drawing.Point(134, 314);
            this.txt_newpass.Name = "txt_newpass";
            this.txt_newpass.Size = new System.Drawing.Size(224, 22);
            this.txt_newpass.TabIndex = 5;
            this.txt_newpass.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F);
            this.label3.Location = new System.Drawing.Point(46, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password : ";
            this.label3.Visible = false;
            // 
            // txt_newuser
            // 
            this.txt_newuser.Font = new System.Drawing.Font("Verdana", 9F);
            this.txt_newuser.Location = new System.Drawing.Point(134, 274);
            this.txt_newuser.Name = "txt_newuser";
            this.txt_newuser.Size = new System.Drawing.Size(224, 22);
            this.txt_newuser.TabIndex = 3;
            this.txt_newuser.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F);
            this.label2.Location = new System.Drawing.Point(44, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username : ";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 17F);
            this.label1.Location = new System.Drawing.Point(86, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create New User";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(392, 444);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 31;
            this.lineShape1.X2 = 357;
            this.lineShape1.Y1 = 60;
            this.lineShape1.Y2 = 60;
            // 
            // btn_newlogin
            // 
            this.btn_newlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btn_newlogin.FlatAppearance.BorderSize = 0;
            this.btn_newlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newlogin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btn_newlogin.ForeColor = System.Drawing.Color.White;
            this.btn_newlogin.Location = new System.Drawing.Point(0, 421);
            this.btn_newlogin.Name = "btn_newlogin";
            this.btn_newlogin.Size = new System.Drawing.Size(126, 23);
            this.btn_newlogin.TabIndex = 0;
            this.btn_newlogin.Text = "Create new user";
            this.btn_newlogin.UseVisualStyleBackColor = false;
            this.btn_newlogin.Click += new System.EventHandler(this.btn_newlogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(190)))), ((int)(((byte)(81)))));
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 16);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(199, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Be Connect+ - Log in ";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.chck_show_hide);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Minimize);
            this.Controls.Add(this.lbl_Exit);
            this.Controls.Add(this.btn_newlogin);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login to Beconnect+";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_Exit;
        private System.Windows.Forms.Label lbl_Minimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_ID;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Password;
        private MaterialSkin.Controls.MaterialCheckBox chck_show_hide;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_newlogin;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_newpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_newuser;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Signin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label5;




    }
}


namespace Be_Connect_
{
    partial class frm_RDCInput
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
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_User = new System.Windows.Forms.Label();
            this.cb_Checkpass = new System.Windows.Forms.CheckBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Verdana", 9F);
            this.txt_Password.Location = new System.Drawing.Point(150, 109);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '●';
            this.txt_Password.Size = new System.Drawing.Size(208, 22);
            this.txt_Password.TabIndex = 0;
            this.txt_Password.Tag = "Enter Password";
            this.txt_Password.MouseHover += new System.EventHandler(this.Tooltip);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F);
            this.label1.Location = new System.Drawing.Point(28, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Password :";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(419, 204);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 24;
            this.lineShape1.X2 = 398;
            this.lineShape1.Y1 = 61;
            this.lineShape1.Y2 = 61;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9F);
            this.button1.Location = new System.Drawing.Point(324, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.Location = new System.Drawing.Point(28, 22);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(371, 29);
            this.lbl_User.TabIndex = 4;
            this.lbl_User.Text = "User Name";
            this.lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_Checkpass
            // 
            this.cb_Checkpass.AutoSize = true;
            this.cb_Checkpass.FlatAppearance.BorderSize = 0;
            this.cb_Checkpass.Font = new System.Drawing.Font("Verdana", 8F);
            this.cb_Checkpass.Location = new System.Drawing.Point(364, 113);
            this.cb_Checkpass.Name = "cb_Checkpass";
            this.cb_Checkpass.Size = new System.Drawing.Size(15, 14);
            this.cb_Checkpass.TabIndex = 5;
            this.cb_Checkpass.Tag = "Click to Show";
            this.cb_Checkpass.UseVisualStyleBackColor = true;
            this.cb_Checkpass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.cb_Checkpass.MouseHover += new System.EventHandler(this.Tooltip);
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Verdana", 9F);
            this.txt_Username.Location = new System.Drawing.Point(150, 81);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(208, 22);
            this.txt_Username.TabIndex = 0;
            this.txt_Username.Tag = "Enter Username";
            this.txt_Username.MouseHover += new System.EventHandler(this.Tooltip);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F);
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Username :";
            // 
            // frm_RDCInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(190)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(419, 204);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Checkpass);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_RDCInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Be Connect+ - Enter Credential For Remote Desktop";
            this.Load += new System.EventHandler(this.frm_RDCInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cb_Checkpass;
        public System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label label2;
    }
}
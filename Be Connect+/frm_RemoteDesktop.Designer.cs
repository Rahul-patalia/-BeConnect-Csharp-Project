namespace Be_Connect_
{
    partial class frm_RemoteDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RemoteDesktop));
            this.RDC = new AxMSTSCLib.AxMsTscAxNotSafeForScripting();
            ((System.ComponentModel.ISupportInitialize)(this.RDC)).BeginInit();
            this.SuspendLayout();
            // 
            // RDC
            // 
            this.RDC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RDC.Enabled = true;
            this.RDC.Location = new System.Drawing.Point(0, 0);
            this.RDC.Name = "RDC";
            this.RDC.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("RDC.OcxState")));
            this.RDC.Size = new System.Drawing.Size(1129, 541);
            this.RDC.TabIndex = 3;
            // 
            // frm_RemoteDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1129, 541);
            this.Controls.Add(this.RDC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_RemoteDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "frm_RemoteDesktop";
            this.Text = "Be Connect+ - Remote Desktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frm_RemoteDesktop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RDC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxMSTSCLib.AxMsTscAxNotSafeForScripting RDC;

    }
}
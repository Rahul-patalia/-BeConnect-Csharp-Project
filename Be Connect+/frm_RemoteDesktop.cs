using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSTSCLib;

namespace Be_Connect_
{
    public partial class frm_RemoteDesktop : Form
    {
        public frm_RemoteDesktop()
        {
            InitializeComponent();
        }

        private void frm_RemoteDesktop_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                RDC.Server = "server";
                RDC.UserName = frm_Home.Username +"\\"+ frm_RDCInput.user.ToString();
                IMsTscNonScriptable secured = (IMsTscNonScriptable)RDC.GetOcx();
                secured.ClearTextPassword = frm_RDCInput.password.ToString();
                RDC.Connect();
                this.Cursor = Cursors.Default;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }
    }
}


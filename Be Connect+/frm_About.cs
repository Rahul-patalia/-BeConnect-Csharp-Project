using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Be_Connect_
{
    public partial class frm_About : Form
    {
        public frm_About()
        {
            InitializeComponent();
        }

        public void autosize()
        {
            label9.Location = new Point(this.Width / 2 - label9.Location.X / 2, label9.Location.Y);
        }

        private void frm_About_Load(object sender, EventArgs e)
        {
            autosize();
        }

    }
}

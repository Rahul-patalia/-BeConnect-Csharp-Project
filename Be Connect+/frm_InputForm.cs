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
    public partial class frm_InputForm : Form
    {
        public frm_InputForm()
        {
            InitializeComponent();
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_Home.MyInput = textBox1.Text;
            this.Close();
        }

        private void frm_InputForm_Load(object sender, EventArgs e)
        {

        }
    }
}

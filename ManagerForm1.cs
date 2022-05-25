using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moogabox
{
    public partial class ManagerForm1 : Form
    {
        public ManagerForm1()
        {
            InitializeComponent();
        }

        private void Btn_Stock_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ManagerForm3 M_frm3 = new ManagerForm3();
            M_frm3.ShowDialog();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form0 frm0 = new Form0();
            frm0.ShowDialog();
            Application.Exit();
        }
    }
}

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
    public partial class ManagerForm3 : Form
    {
        public ManagerForm3()
        {
            InitializeComponent();
        }

        private void Btn_StoreStock_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ManagerForm4 M_frm4 = new ManagerForm4();
            M_frm4.ShowDialog();
            Application.Exit();
        }

        private void Btn_WarehouseStock_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ManagerForm5 M_frm5 = new ManagerForm5();
            M_frm5.ShowDialog();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ManagerForm1 M_frm1 = new ManagerForm1();
            M_frm1.ShowDialog();
            Application.Exit();
        }
    }
}

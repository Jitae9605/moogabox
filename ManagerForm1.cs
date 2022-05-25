using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace moogabox
{
    public partial class ManagerForm1 : Form
    {
        public ManagerForm1()
        {
            InitializeComponent();
        }

        private void Btn_Sale_Click(object sender, EventArgs e)  //  매출관리 버튼 클릭시 매출관리창으로 이동
        {
            ManagerForm2 newManagerForm2 = new ManagerForm2();
            newManagerForm2.ShowDialog();
        }

        private void ManagerForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
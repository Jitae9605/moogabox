using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace moogabox
{
    public partial class Form5 : Form
    {
        private string Constr = "Server=(local);database=MoogaBox;" +
                "Integrated Security=true"; //SQL 연결문자열
        public Form5()
        {
            InitializeComponent();
        }
        int count = 0;
        public int Hall_Num { get; set; }
        string joasuk = "";

        private void Form5_Load(object sender, EventArgs e)
        {
            var Conn = new SqlConnection(Constr);
            Conn.Open();

            var Comm = new SqlCommand("Select MvName,Hall,StartTime from TmpReservation", Conn);
            var myRead = Comm.ExecuteReader();
            if (myRead.Read())
            {
                this.lblName.Text = myRead[0].ToString();
                this.lblTime.Text = myRead[2].ToString();
                this.lblhall.Text = myRead[1].ToString();
            }
            myRead.Close();

            Conn.Close();
            MessageBox.Show("최대 선택 좌석은 4개입니다.", "주의사항",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void btnA1_Click_1(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "A01\n";
                btnA1.BackColor = Color.Red;
                count++;
                joasuk += "A01,";

            }
           else if(count >= 4)
            {
                MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

        }
        private void btnA2_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "A02\n";
                btnA2.BackColor = Color.Red;
                count++;
                joasuk += "A02,";
            }
            else if (count >= 4)
            {
                MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "A03\n";
                btnA3.BackColor = Color.Red;
                count++;
                joasuk += "A03,";
            }
            else if (count >= 4)
            {
                MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "A04\n";
                btnA4.BackColor = Color.Red;
                count++;
                joasuk += "A04,";
            }
            else if (count >= 4)
            {
                MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "A05\n";
                btnA5.BackColor = Color.Red;
                count++;
                joasuk += "A05,";
            }
            else if (count >= 4)
            {
                MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void btnB1_Click_1(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "B01\n";
                btnB1.BackColor = Color.Red;
                count++;
                joasuk += "B01,";
            }
            else if (count >= 4)
            {
                MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "B02\n";
                btnB2.BackColor = Color.Red;
                count++;
                joasuk += "B02,";
            }
            else if (count >= 4)
            {
                MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "B03\n";
                btnB3.BackColor = Color.Red;
                count++;
                joasuk += "B03,";
            }
            else if (count >= 4)
            {
                MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "B04\n";
                btnB4.BackColor = Color.Red;
                count++;
                joasuk += "B04,";
            }
            else if (count >= 4)
            {
                MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "B05\n";
                btnB5.BackColor = Color.Red;
                count++;
                joasuk += "B05,";
            }
            else if (count >= 4)
            {
                MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "C01\n";
                btnC1.BackColor = Color.Red;
                count++;
                joasuk += "C01,";
            }
            else if (count >= 4)
            {
                MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "C02\n";
                btnC2.BackColor = Color.Red;
                count++;
                joasuk += "C02,";
            }
            else if (count >= 4)
            {
                MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "C03\n";
                btnC3.BackColor = Color.Red;
                count++;
                joasuk += "C03,";
            }
            else if (count >= 4)
            {
                MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "C04\n";
                btnC4.BackColor = Color.Red;
                count++;
                joasuk += "C04,";
            }
            else if (count >= 4)
            {
                MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         }

        private void btnC5_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "C05\n";
                btnC5.BackColor = Color.Red;
                count++;
                joasuk += "C05,";
            }
            else if (count >= 4)
            {
                MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "D01\n";
                btnD1.BackColor = Color.Red;
                count++;
                joasuk += "D01,";
            }
            else if (count >= 4)
            {
                MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         }

        private void btnD2_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "D02\n";
                btnD2.BackColor = Color.Red;
                count++;
                joasuk += "D02,";
            }
            else if (count >= 4)
            {
                MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         }

        private void btnD3_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "D03\n";
                btnD3.BackColor = Color.Red;
                count++;
                joasuk += "D03,";
            }
            else if (count >= 4)
            {
                MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "D04\n";
                btnD4.BackColor = Color.Red;
                count++;
                joasuk += "D04,";
            }
            else if (count >= 4)
            {
                MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnD5_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "D05\n";
                btnD5.BackColor = Color.Red;
                count++;
                joasuk += "D05,";
            }
            else if (count >= 4)
            {
                MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnPeople_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnA1.BackColor = SystemColors.Control;
            btnA2.BackColor = SystemColors.Control;
            btnA3.BackColor = SystemColors.Control;
            btnA4.BackColor = SystemColors.Control;
            btnA5.BackColor = SystemColors.Control;
            btnB1.BackColor = SystemColors.Control;
            btnB2.BackColor = SystemColors.Control;
            btnB3.BackColor = SystemColors.Control;
            btnB4.BackColor = SystemColors.Control;
            btnB5.BackColor = SystemColors.Control;
            btnC1.BackColor = SystemColors.Control;
            btnC2.BackColor = SystemColors.Control;
            btnC3.BackColor = SystemColors.Control;
            btnC4.BackColor = SystemColors.Control;
            btnC5.BackColor = SystemColors.Control;
            btnD1.BackColor = SystemColors.Control;
            btnD2.BackColor = SystemColors.Control;
            btnD3.BackColor = SystemColors.Control;
            btnD4.BackColor = SystemColors.Control;
            btnD5.BackColor = SystemColors.Control;

            label2.Text = "";
            label3.Text = "";
            count = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //첫 창으로 이동
            var Conn = new SqlConnection(Constr);
            Conn.Open();

            var Comm = new SqlCommand("delete from TmpReservation", Conn);
            Comm.ExecuteNonQuery();

            Conn.Close();

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //label2.Text
            var Conn = new SqlConnection(Constr);
            Conn.Open();

            string Tmp_text = joasuk;
            char sp = ',';

            string[] strtmp = Tmp_text.Split(sp);

            int hallnum = Convert.ToInt32(this.lblhall.Text);

            for (int i = 0; i < strtmp.Length; i++)
            {
                string sql = "update Theater set Eempty = " + 1 + "where SeatNum ='" + strtmp[i] + "' and ThNum =" + hallnum + "";
                var Comm = new SqlCommand(sql, Conn);
                Comm.ExecuteNonQuery();
            }

            string Sql = "update TmpReservation set SeatNum ="
                                  + "@SeatNum" + " select hall from TmpReservation where Hall =" + hallnum + "";

            var Com = new SqlCommand(Sql, Conn);
            Com.Parameters.Add("@SeatNum", SqlDbType.NVarChar, 20);
            Com.Parameters["@SeatNum"].Value = this.label2.Text;
            int insertRowCnt = Com.ExecuteNonQuery();


            //다음창으로 이동
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }
    }
}

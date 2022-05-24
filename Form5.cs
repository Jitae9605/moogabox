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
        private string Constr = "Server=210.119.12.69; Uid=User1;Pwd=1234;database=MoogaBox;" + "Integrated Security=false"; //SQL 연결문자열
        public Form5()
        {
            InitializeComponent();
        }
        int count = 0;

        private void Form5_Load(object sender, EventArgs e)
        {
            MessageBox.Show("최대 선택 좌석은 4개입니다.", "주의사항",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void btnA1_Click_1(object sender, EventArgs e)
        {
            if (count < 4)
            {
                label2.Text += "A1\n";
                btnA1.BackColor = Color.Red;
                count++;
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
                label2.Text += "A2\n";
                btnA2.BackColor = Color.Red;
                count++;
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
                label2.Text += "A3\n";
                btnA3.BackColor = Color.Red;
                count++;
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
                label2.Text += "A4\n";
                btnA4.BackColor = Color.Red;
                count++;
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
                label2.Text += "A5\n";
                btnA5.BackColor = Color.Red;
                count++;
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
                label2.Text += "B1\n";
                btnB1.BackColor = Color.Red;
                count++;
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
                label2.Text += "B2\n";
                btnB2.BackColor = Color.Red;
                count++;
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
                label2.Text += "B3\n";
                btnB3.BackColor = Color.Red;
                count++;
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
                label2.Text += "B4\n";
                btnB4.BackColor = Color.Red;
                count++;
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
                label2.Text += "B5\n";
                btnB5.BackColor = Color.Red;
                count++;
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
                label2.Text += "C1\n";
                btnC1.BackColor = Color.Red;
                count++;
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
                label2.Text += "C2\n";
                btnC2.BackColor = Color.Red;
                count++;
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
                label2.Text += "C3\n";
                btnC3.BackColor = Color.Red;
                count++;
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
                label2.Text += "C4\n";
                btnC4.BackColor = Color.Red;
                count++;
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
                label2.Text += "C5\n";
                btnC5.BackColor = Color.Red;
                count++;
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
                label2.Text += "D1\n";
                btnD1.BackColor = Color.Red;
                count++;
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
                label2.Text += "D2\n";
                btnD2.BackColor = Color.Red;
                count++;
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
                label2.Text += "D3\n";
                btnD3.BackColor = Color.Red;
                count++;
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
                label2.Text += "D4\n";
                btnD4.BackColor = Color.Red;
                count++;
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
                label2.Text += "D5\n";
                btnD5.BackColor = Color.Red;
                count++;
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



            //다음창으로 이동
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }
    }
}

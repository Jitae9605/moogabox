﻿using System;
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
    //SQL에서 시간불러와서 DateCompare함수 이용해서 구하기.
    //btnTime01.Enabled = false;
    public partial class Form4 : Form
    {
        private SqlConnection Con;
        public Form4()
        {
            InitializeComponent();
        }
        private int EduNum = 0;
        private void Form4_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection();
            Con.ConnectionString = "Server=(local);database=MoogaBox;" +
                "Integrated Security=true";
            Con.Open();

            string Nowtime = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분");
            lblTime.Text = Nowtime;

            Btn_enabled();


        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }
        // 범죄도시 2
        private void btnTime01_Click(object sender, EventArgs e)
        {
            var Comm01 = new SqlCommand("select * from Movie where MvNum='CC01'", Con);

            var myRead01 = Comm01.ExecuteReader();
            if (myRead01.Read())
            {
                this.name.Text = myRead01[0].ToString();
                this.time.Text = myRead01[2].ToString();
                pbMovie.Image = pbMovie1.Image;
            }
            myRead01.Close();

            string InsertSql = string.Format("insert into Mvname, Hall,StartTime TmpReservation select Mvname,Hall,StartTime from Movie");
            var Com = new SqlCommand(InsertSql, Con);

            groupBox1.Visible = true;

        }

        private void btnTime02_Click(object sender, EventArgs e)
        {
            var Comm01 = new SqlCommand("select * from Movie where MvNum='CC02'", Con);
            var myRead01 = Comm01.ExecuteReader();
            if (myRead01.Read())
            {
                this.name.Text = myRead01[0].ToString();
                this.time.Text = myRead01[2].ToString();
                pbMovie.Image = pbMovie1.Image;
            }
            myRead01.Close();

            groupBox1.Visible = true;

        }

        private void btnTime03_Click(object sender, EventArgs e)
        {
            var Comm01 = new SqlCommand("select * from Movie where MvNum='CC03'", Con);
            var myRead01 = Comm01.ExecuteReader();
            if (myRead01.Read())
            {
                this.name.Text = myRead01[0].ToString();
                this.time.Text = myRead01[2].ToString();
                pbMovie.Image = pbMovie1.Image;
            }
            myRead01.Close();

            groupBox1.Visible = true;

        }

        private void btnTime04_Click(object sender, EventArgs e)
        {
            var Comm01 = new SqlCommand("select * from Movie where MvNum='CC04'", Con);
            var myRead01 = Comm01.ExecuteReader();
            if (myRead01.Read())
            {
                this.name.Text = myRead01[0].ToString();
                this.time.Text = myRead01[2].ToString();
                pbMovie.Image = pbMovie1.Image;
            }
            myRead01.Close();

            groupBox1.Visible = true;
        }

        private void btnTime05_Click(object sender, EventArgs e)
        {
            var Comm01 = new SqlCommand("select * from Movie where MvNum='CC05'", Con);
            var myRead01 = Comm01.ExecuteReader();
            if (myRead01.Read())
            {
                this.name.Text = myRead01[0].ToString();
                this.time.Text = myRead01[2].ToString();
                pbMovie.Image = pbMovie1.Image;
            }
            myRead01.Close();

            groupBox1.Visible = true;
        }

        private void btnTime06_Click(object sender, EventArgs e)
        {
            var Comm01 = new SqlCommand("select * from Movie where MvNum='CC06'", Con);
            var myRead01 = Comm01.ExecuteReader();
            if (myRead01.Read())
            {
                this.name.Text = myRead01[0].ToString();
                this.time.Text = myRead01[2].ToString();
                pbMovie.Image = pbMovie1.Image;
            }
            myRead01.Close();

            groupBox1.Visible = true;
        }

        //닥터스트레인지
        private void btnTime07_Click(object sender, EventArgs e)
        {
            var Comm01 = new SqlCommand("select * from Movie where MvNum='DR01'", Con);
            var myRead01 = Comm01.ExecuteReader();
            if (myRead01.Read())
            {
                this.name.Text = myRead01[0].ToString();
                this.time.Text = myRead01[2].ToString();
                pbMovie.Image = pbMovie2.Image;
            }
            myRead01.Close();

            groupBox1.Visible = true;
        }

        private void btnTime08_Click(object sender, EventArgs e)
        {
            var Comm01 = new SqlCommand("select * from Movie where MvNum='DR02'", Con);
            var myRead01 = Comm01.ExecuteReader();
            if (myRead01.Read())
            {
                this.name.Text = myRead01[0].ToString();
                this.time.Text = myRead01[2].ToString();
                pbMovie.Image = pbMovie2.Image;
            }
            myRead01.Close();

            groupBox1.Visible = true;
        }

        private void btnTime09_Click(object sender, EventArgs e)
        {
            var Comm01 = new SqlCommand("select * from Movie where MvNum='DR03'", Con);
            var myRead01 = Comm01.ExecuteReader();
            if (myRead01.Read())
            {
                this.name.Text = myRead01[0].ToString();
                this.time.Text = myRead01[2].ToString();
                pbMovie.Image = pbMovie2.Image;
            }
            myRead01.Close();

            groupBox1.Visible = true;
        }

        private void btnTime010_Click(object sender, EventArgs e)
        {
            var Comm01 = new SqlCommand("select * from Movie where MvNum='DR04'", Con);
            var myRead01 = Comm01.ExecuteReader();
            if (myRead01.Read())
            {
                this.name.Text = myRead01[0].ToString();
                this.time.Text = myRead01[2].ToString();
                pbMovie.Image = pbMovie2.Image;
            }
            myRead01.Close();

            groupBox1.Visible = true;
        }

        private void btnTime11_Click(object sender, EventArgs e)
        {
            var Comm01 = new SqlCommand("select * from Movie where MvNum='DR05'", Con);
            var myRead01 = Comm01.ExecuteReader();
            if (myRead01.Read())
            {
                this.name.Text = myRead01[0].ToString();
                this.time.Text = myRead01[2].ToString();
                pbMovie.Image = pbMovie2.Image;
            }
            myRead01.Close();

            groupBox1.Visible = true;
        }

        private void btnTime12_Click(object sender, EventArgs e)
        {
            var Comm01 = new SqlCommand("select * from Movie where MvNum='DR06'", Con);
            var myRead01 = Comm01.ExecuteReader();
            if (myRead01.Read())
            {
                this.name.Text = myRead01[0].ToString();
                this.time.Text = myRead01[2].ToString();
                pbMovie.Image = pbMovie2.Image;
            }
            myRead01.Close();

            groupBox1.Visible = true;
        }

        private void btnTime13_Click(object sender, EventArgs e)
        {
            var Comm01 = new SqlCommand("select * from Movie where MvNum='DR07'", Con);
            var myRead01 = Comm01.ExecuteReader();
            if (myRead01.Read())
            {
                this.name.Text = myRead01[0].ToString();
                this.time.Text = myRead01[2].ToString();
                pbMovie.Image = pbMovie2.Image;
            }
            myRead01.Close();

            groupBox1.Visible = true;
        }

        //쥬라기월드 -도미니언
        private void btnTime15_Click(object sender, EventArgs e)
        {
            var Comm01 = new SqlCommand("select * from Movie where MvNum='JW01'", Con);
            var myRead01 = Comm01.ExecuteReader();
            if (myRead01.Read())
            {
                this.name.Text = myRead01[0].ToString();
                this.time.Text = myRead01[2].ToString();
                pbMovie.Image = pbMovie3.Image;
            }
            myRead01.Close();

            groupBox1.Visible = true;

        }

        private void btnTime16_Click(object sender, EventArgs e)
        {
            var Comm01 = new SqlCommand("select * from Movie where MvNum='JW02'", Con);
            var myRead01 = Comm01.ExecuteReader();
            if (myRead01.Read())
            {
                this.name.Text = myRead01[0].ToString();
                this.time.Text = myRead01[2].ToString();
                pbMovie.Image = pbMovie3.Image;
            }
            myRead01.Close();

            groupBox1.Visible = true;
        }

        private void btnTime17_Click(object sender, EventArgs e)
        {
            var Comm01 = new SqlCommand("select * from Movie where MvNum='JW03'", Con);
            var myRead01 = Comm01.ExecuteReader();
            if (myRead01.Read())
            {
                this.name.Text = myRead01[0].ToString();
                this.time.Text = myRead01[2].ToString();
                pbMovie.Image = pbMovie3.Image;
            }
            myRead01.Close();

            groupBox1.Visible = true;
        }

        private void btnTime18_Click(object sender, EventArgs e)
        {
            var Comm01 = new SqlCommand("select * from Movie where MvNum='JW04'", Con);
            var myRead01 = Comm01.ExecuteReader();
            if (myRead01.Read())
            {
                this.name.Text = myRead01[0].ToString();
                this.time.Text = myRead01[2].ToString();
                pbMovie.Image = pbMovie3.Image;
            }
            myRead01.Close();

            groupBox1.Visible = true;
        }

        private void btnTime19_Click(object sender, EventArgs e)
        {
            var Comm01 = new SqlCommand("select * from Movie where MvNum='JW05'", Con);
            var myRead01 = Comm01.ExecuteReader();
            if (myRead01.Read())
            {
                this.name.Text = myRead01[0].ToString();
                this.time.Text = myRead01[2].ToString();
                pbMovie.Image = pbMovie3.Image;
            }
            myRead01.Close();

            groupBox1.Visible = true;
        }

        private void btnTime20_Click(object sender, EventArgs e)
        {
            var Comm01 = new SqlCommand("select * from Movie where MvNum='JW06'", Con);
            var myRead01 = Comm01.ExecuteReader();
            if (myRead01.Read())
            {
                this.name.Text = myRead01[0].ToString();
                this.time.Text = myRead01[2].ToString();
                pbMovie.Image = pbMovie3.Image;
            }
            myRead01.Close();

            groupBox1.Visible = true;
        }



        private void bntOK_Click(object sender, EventArgs e)
        {
            //지정한 영화이름과 영화품번, 시간이 TmpReservation으로 들어간다



            //좌석창으로 이동
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();

        }

        private void pbMovie1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_enabled()
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //첫 창으로 이동
            var Comm = new SqlCommand("delete from TmpReservation", Con);
            Comm.ExecuteNonQuery();

            Con.Close();

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

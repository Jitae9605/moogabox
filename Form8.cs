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
using System.Configuration;
using moogabox;

namespace WinFormsApp1
{

	public partial class Form8 : Form
	{
		string Constr = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
		
		public Form8()
		{
			InitializeComponent();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			var Conn = new SqlConnection(Constr);
			Conn.Open();

			var Comm = new SqlCommand("delete from TmpReservation", Conn);
			Comm.ExecuteNonQuery();

			Conn.Close();

			Form1 form1 = new Form1();
			form1.Show();
			this.Hide();
		}

		private void Form8_Load(object sender, EventArgs e)
		{

			DataLoad();

		}
		private void DataLoad()
		{
			var Conn = new SqlConnection(Constr);
			Conn.Open();

			string InsertSql = string.Format("insert into Reservation select * from TmpReservation");
			var Com = new SqlCommand(InsertSql, Conn);
			Com.ExecuteNonQuery();

			var Comm = new SqlCommand("Select ID from TmpReservation", Conn);
			var myRead = Comm.ExecuteReader();
			string CurCustomerID = "";

			if (myRead.Read())
			{
				CurCustomerID = myRead[0].ToString();
			}
			myRead.Close();

			int a = 0;
			string TmpRsvCode = DateTime.Now.ToString("yyyy") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd") + a.ToString("0000");

			InsertSql = "update Reservation set RsvCode = " + TmpRsvCode + "where ID = " + CurCustomerID;

			Com = new SqlCommand(InsertSql, Conn);
			Com.ExecuteNonQuery();

			Comm = new SqlCommand("Select MvName, StartTime, Hall, SeatNum, RsvCode from Reservation", Conn);
			
			myRead = Comm.ExecuteReader();
			if (myRead.Read())
			{
				this.txtMovie.Text = myRead[0].ToString();
				this.txtTime.Text = myRead[1].ToString();
				this.txtHallNum.Text = myRead[2].ToString();
				this.txtSeatNum.Text = myRead[3].ToString();
				this.txtNum.Text = myRead[4].ToString();
			}
			myRead.Close();

			Conn.Close();
		}

		private void Form8_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}

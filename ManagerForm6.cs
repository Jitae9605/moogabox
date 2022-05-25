using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WMPLib;


namespace moogabox
{
    public partial class ManagerForm6 : Form
    {
        Timer timer1 = new Timer();
        public ManagerForm6()
        {
            InitializeComponent();

            timer1.Interval = 50;
            timer1.Tick += timer2_Tick;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            timer1.Start();

            ////////////////////
            try
            {
				var CurrentDirectory = Directory.GetCurrentDirectory();
				string newPath = Path.GetFullPath(Path.Combine(CurrentDirectory, @"..\..\Media\Popcorn.mp4"));
				axWindowsMediaPlayer1.URL = newPath;
                axWindowsMediaPlayer1.uiMode = "none";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value++;
                label1.Text = progressBar1.Value.ToString();
               
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}

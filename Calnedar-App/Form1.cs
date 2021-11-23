using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calnedar_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;

            //Lets get the firts day of the month


            DateTime startofthemonth = new DateTime(now.Year, now.Month, 1);
            //get the count of days of the month
            int days = DateTime.DaysInMonth(now.Year, now.Month);
            // convert the startof the month to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            //MessageBox.Show(dayoftheweek.ToString());
            //first a blank usercontrol will be created
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlForm ucblank = new UserControlForm();
                ucblank.TopLevel = false;
                daycontainer.Controls.Add(ucblank);
                ucblank.Show();
            }
            //usercontrol for days
            for(int i=1; i<=days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.TopLevel = false;
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
                //ucblank.Show();
            }
        }

        private void button_Previous_Click(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_next_Click(object sender, EventArgs e)
        {

        }
    }
}

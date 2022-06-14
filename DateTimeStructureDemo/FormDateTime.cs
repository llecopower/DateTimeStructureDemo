using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeStructureDemo
{
    public partial class FormDateTime : Form
    {
        public FormDateTime()
        {
            InitializeComponent();
        }

        private void FormDateTime_Load(object sender, EventArgs e)
        {
            


        }

        private void buttonNow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The property now gets the current OS date and time", "Current Date and time");
            DateTime currentDateTime = DateTime.Now;
            textBoxNow.Text = currentDateTime.ToString();
        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The property Today gets the currentdate", "Current Date");
            DateTime currentDateTime = DateTime.Today;
            textBoxToday.Text = currentDateTime.ToString();

        }

        private void buttonMonth_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The property Month gets the current Month", "Current Month");
            DateTime currentDateTime = DateTime.Today;
            textBoxMonth.Text = currentDateTime.Month.ToString();
        }

        private void buttonDay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The property Day gets the current OS date", "Current Day");
            DateTime currentDateTime = DateTime.Today;
            textBoxDay.Text = currentDateTime.Day.ToString();
        }

        private void buttonYear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The property Year gets the current OS date", "Current Year");
            DateTime currentDateTime = DateTime.Today;
            textBoxYear.Text = currentDateTime.Year.ToString();
        }

        private void buttonLongDate_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Convert Date and Time value to String \n" +
                             "that includes the day of the week name, \n" +
                             "the month name, the day of the month, and the year", "Long Date");
            DateTime currentDateTime = DateTime.Today;
            textBoxLongDate.Text = currentDateTime.ToLongDateString();

        }

        private void buttonShortDate_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Convert Date and Time value to String \n" +
                             "that includes the day of the week name, \n" +
                             "the month name, the day of the month, and the year", "Short Date");
            DateTime currentDateTime = DateTime.Today;
            textBoxShortDate.Text = currentDateTime.ToShortDateString();

        }

        private void buttonLongTime_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Convert Date and Time value to String \n" +
                             "that includes the day of the week name, \n" +
                             "the month name, the day of the month, and the year", "Long Date");
            DateTime currentDateTime = DateTime.Today;
            textBoxLongTime.Text = currentDateTime.ToLongTimeString();
        }

        private void buttonShortTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Convert Date and Time value to String \n" +
                            "that includes the day of the week name, \n" +
                            "the month name, the day of the month, and the year", "Short Date");
            DateTime currentDateTime = DateTime.Today;
            textBoxShortTime.Text = currentDateTime.ToShortTimeString();
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            FormOperation oForm = new FormOperation();
            oForm.ShowDialog();
        }

        private void buttonDayOfWeek_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The property Day of the week gets the current OS date", "Current Day of the week");
            DateTime currentDateTime = DateTime.Now;
            textBoxDayOfWeek.Text = currentDateTime.DayOfWeek.ToString();

        }

        private void buttonDayOfYear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The property Number of Day of the year gets the current OS date", "Current Day of the year");
            DateTime currentDateTime = DateTime.Now;
            textBoxDayOfYear.Text = currentDateTime.DayOfYear.ToString();
        }

        private void buttonTimeOfDay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The property Time of the Day gets the current OS time of the day", "Current Time of the day");
            DateTime currentDateTime = DateTime.Now;
            textBoxTimeOfDay.Text = currentDateTime.TimeOfDay.ToString();
        }

       


    }
}

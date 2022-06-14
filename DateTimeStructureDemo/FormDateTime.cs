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
          
        }

        private void buttonMonth_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonDay_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonYear_Click(object sender, EventArgs e)
        {
        
        }

        private void buttonLongDate_Click(object sender, EventArgs e)
        {

         

        }

        private void buttonShortDate_Click(object sender, EventArgs e)
        {

        }

        private void buttonLongTime_Click(object sender, EventArgs e)
        {

          

        }

        private void buttonShortTime_Click(object sender, EventArgs e)
        {

        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {

        }

        private void buttonDayOfWeek_Click(object sender, EventArgs e)
        {


        }

        private void buttonDayOfYear_Click(object sender, EventArgs e)
        {

        }

        private void buttonTimeOfDay_Click(object sender, EventArgs e)
        {

        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session4_1
{
    public partial class frmFuelEconomy: Form
    {
        public frmFuelEconomy()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double miles, gallons, mpg;
            if (double.TryParse(txtMiles.Text, out miles))
            {
                if (double.TryParse(txtGallons.Text, out gallons))
                {
                    mpg = miles / gallons;
                    txtMpg.Text = mpg.ToString("n1");
                }
                else
                {
                    MessageBox.Show("Invalid Input for Gallons");
                }
            }
            else
            {
                MessageBox.Show("Invalid Input for Miles");
            }
        }
    }
}

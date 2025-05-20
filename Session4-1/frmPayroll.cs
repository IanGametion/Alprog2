using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Session4_1
{
    public partial class frmPayroll: Form
    {
        public frmPayroll()
        {
            InitializeComponent();
            lblGrossPlay.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHourlyPayRate.Clear();
            txtHoursWorked.Clear();
            lblGrossPlay.Text = "";
            txtHoursWorked.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Application.CurrentCulture = new CultureInfo("en-US");
            try
            {
                const decimal BASE_HOURS = 40m;
                const decimal OT_MULTIPLIER = 1.5m;

                decimal hoursWorked;
                decimal hourlyPayRate;
                decimal basePay;
                decimal overTimeHours;
                decimal overTimePay;
                decimal grossPay;

                hoursWorked = decimal.Parse(txtHoursWorked.Text);
                hourlyPayRate = decimal.Parse(txtHourlyPayRate.Text);

                if (hoursWorked > BASE_HOURS)
                {
                    basePay = hourlyPayRate * BASE_HOURS;
                    overTimeHours = hoursWorked - BASE_HOURS;
                    overTimePay = overTimeHours * hourlyPayRate * OT_MULTIPLIER;
                    grossPay = basePay + overTimePay;
                }
                else
                    grossPay = hoursWorked * hourlyPayRate;
                lblGrossPlay.Text = grossPay.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

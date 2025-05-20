using System;
using System.Windows.Forms;

namespace Session4_1
{
    public partial class frmLoanQualifier : Form
    {
        public frmLoanQualifier()
        {
            InitializeComponent();
            lblDecision.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSalary.Clear();
            txtYearsJob.Clear();
            lblDecision.Text = "";
            txtSalary.Focus();
        }

        private void btnCheckQualify_Click(object sender, EventArgs e)
        {
            Application.CurrentCulture = new System.Globalization.CultureInfo("em-US");
            try
            {
                const decimal MINIMUM_SALARY = 4000m;
                const int MINIMUM_YEARS_ON_JOB = 2;

                decimal salary;
                int yearsOnJob;
                salary = decimal.Parse(txtSalary.Text);
                yearsOnJob = int.Parse(txtYearsJob.Text);
                if (salary >= MINIMUM_SALARY)
                {
                    if (yearsOnJob >= MINIMUM_YEARS_ON_JOB)
                    {
                        lblDecision.Text = "You qualify for the loan.";
                    }
                    else
                        lblDecision.Text = "Minimum years at the current job is not met.";
                }
                else
                    lblDecision.Text = "Minimum salary requirememnt at current job is not met.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

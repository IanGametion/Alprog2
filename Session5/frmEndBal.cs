using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session5
{
    public partial class frmEndBal: Form
    {
        public frmEndBal()
        {
            InitializeComponent();
            lblEndBal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStartBal.Clear();
            txtMonths.Clear();
            lblEndBal.Text = "";
            txtStartBal.Focus();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            const decimal INTEREST_RATE = 0.005m;

            decimal balance;
            int months;
            int count = 1;

            if (decimal.TryParse(txtStartBal.Text, out balance))
            {
                if (int.TryParse(txtMonths.Text, out months))
                {
                    while (count <= months)
                    {
                        balance += (INTEREST_RATE * balance);
                        lstDetails.Items.Add("The ending balance " + "for month " + count + " is " + balance.ToString("c"));
                        count++;
                    }
                    lblEndBal.Text = balance.ToString("c");
                }
                else
                {
                    MessageBox.Show("Invalid value for months");
                }
            }
            else
            {
                MessageBox.Show("Invalid value for starting balance");
            }
        }
    }
}

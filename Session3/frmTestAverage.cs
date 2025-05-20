using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session3
{
    public partial class frmTestAverage: Form
    {
        public frmTestAverage()
        {
            InitializeComponent();
            lblOutputAvg.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTest1.Clear();
            txtTest2.Clear();
            txtTest3.Clear();
            lblOutputAvg.Text = "";
            txtTest1.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                const double HIGH_SCORE = 95.0;
                double test1, test2, test3, average;
                test1 = double.Parse(txtTest1.Text);
                test2 = double.Parse(txtTest2.Text);
                test3 = double.Parse(txtTest3.Text);
                average = (test1 + test2 + test3) / 3.0;
                lblOutputAvg.Text = average.ToString("n1");

                if (average > HIGH_SCORE)
                {
                    MessageBox.Show("Congratulations!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

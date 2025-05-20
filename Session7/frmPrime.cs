using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session7
{
    public partial class frmPrime : Form
    {
        public frmPrime()
        {
            InitializeComponent();
        }

        private bool isPrime(int n)
        {
            if (n <= 1)
                return false;

            if (n == 2 || n == 3)
                return true;

            if (n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i <= Math.Sqrt(n); i = i + 6)
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;

            return true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int chknumber = Convert.ToInt32(txtNumber.Text);
            bool statPrime = isPrime(Convert.ToInt32(txtNumber.Text));
            if (statPrime)
                MessageBox.Show("The " + txtNumber.Text + " is a prime number");
            else
                MessageBox.Show("The " + txtNumber.Text + " is not a prime number");
            for (int i = 1; i <= chknumber; i++)
            {
                if (statPrime = isPrime(i))
                    lstPrime.Items.Add(i);
            }
        }
    }
}

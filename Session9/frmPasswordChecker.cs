using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session9
{
    public partial class frmPasswordChecker : Form
    {
        public frmPasswordChecker()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private int numUpperCase(string pass)
        {
            int upperCase = 0;
            foreach (char ch in pass)
                if (char.IsUpper(ch))
                    upperCase++;
            return upperCase;
        }

        private int numLowerCase(string pass)
        {
            int lowerCase = 0;
            foreach (char ch in pass)
                if (char.IsLower(ch))
                    lowerCase++;
            return lowerCase;
        }

        private int numDigit(string pass)
        {
            int digits = 0;
            foreach (char ch in pass)
                if (char.IsDigit(ch))
                    digits++;
            return digits;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 8;
            string password = txtPassword.Text;
            if (password.Length >= MIN_LENGTH && numUpperCase(password) >= 1 && numLowerCase(password) >= 1 && numDigit(password) >= 1)
                MessageBox.Show("The password is valid");
            else
                MessageBox.Show("The password does not meet the requirements");
        }
    }
}

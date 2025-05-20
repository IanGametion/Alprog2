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
    public partial class frmTelephoneForm : Form
    {
        public frmTelephoneForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTelenum.Clear();
        }

        private bool isValidNumber(string phonenum)
        {
            const int VALID_LENGTH = 10;
            bool valid = true;
            if (phonenum.Length != VALID_LENGTH)
            {
                foreach (char ch in phonenum)
                    if (!char.IsDigit(ch))
                        valid = false;
            }
            else
                valid = false;
            return valid;
        }

        private void formatTele(ref string phonenum)
        {
            phonenum = phonenum.Insert(0, "(");
            phonenum = phonenum.Insert(4, ")");
            phonenum = phonenum.Insert(8, "-");
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            string inputPhone = txtTelenum.Text.Trim();
            if (isValidNumber(inputPhone))
            {
                formatTele(ref inputPhone);
                MessageBox.Show(inputPhone);
            }
            else
                MessageBox.Show("Invalid input");
        }
    }
}

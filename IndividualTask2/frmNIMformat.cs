using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualTask2
{
    public partial class frmNIMformat : Form
    {
        public frmNIMformat()
        {
            InitializeComponent();
        }

        // 412024013 Christian
        private bool isValidNumber(string nim)
        {
            const int VALID_LENGTH = 9;
            bool valid = true;
            if (nim.Length != VALID_LENGTH)
                valid = false;
            else
                foreach (char ch in nim)
                    if (!char.IsDigit(ch))
                        valid = false;
            return valid;
        }

        private void formatNim(ref string nim)
        {
            nim = nim.Insert(2, "-");
            nim = nim.Insert(7, "-");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNIM.Clear();
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            string inputNIM = txtNIM.Text.Trim();
            if (isValidNumber(inputNIM))
            {
                formatNim(ref inputNIM);
                MessageBox.Show(inputNIM);
            }
            else
                MessageBox.Show("Invalid input, only numbers please.");
        }
    }
}

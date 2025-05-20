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
    public partial class frmCompareString: Form
    {
        public frmCompareString()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string nameOne = String.Empty;
            string nameTwo = String.Empty;
            nameOne = txtName1.Text;
            nameTwo = txtName2.Text;

            if (String.Compare(nameOne, nameTwo) == 0) 
            {
                lblResult.Text = nameOne + " and " + nameTwo + " are equal";
            }
            else
            {
                lblResult.Text = nameOne + " and " + nameTwo + " are not equal";
            }
        }
    }
}

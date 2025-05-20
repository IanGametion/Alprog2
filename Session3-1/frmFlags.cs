using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session3_1
{
    public partial class frmFlags: Form
    {
        public frmFlags()
        {
            InitializeComponent();
            lblCountry.Text = "";
        }

        private void pbJerman_Click(object sender, EventArgs e)
        {
            lblCountry.Text = "Jerman";
        }

        private void pbRusia_Click(object sender, EventArgs e)
        {
            lblCountry.Text = "Rusia";
        }

        private void pbJepang_Click(object sender, EventArgs e)
        {
            lblCountry.Text = "Jepang";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            pbJerman.Visible = true;
            pbRusia.Visible = true;
            pbJepang.Visible = true;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            pbJerman.Visible = false;
            pbRusia.Visible = false;
            pbJepang.Visible = false;
        }
    }
}

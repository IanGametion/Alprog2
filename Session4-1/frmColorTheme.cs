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
    public partial class frmColorTheme: Form
    {
        public frmColorTheme()
        {
            InitializeComponent();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (cbForeground.Checked)
            {
                if (rbYellow.Checked) groupBox1.ForeColor = Color.Yellow;
                else if (rbRed.Checked) groupBox1.ForeColor = Color.Red;
                else if (rbWhite.Checked) groupBox1.ForeColor = Color.White;
                else groupBox1.ForeColor = SystemColors.ControlText;
            }
            if (cbBackground.Checked)
            {
                if (rbYellow.Checked) groupBox1.BackColor = Color.Yellow;
                else if (rbRed.Checked) groupBox1.BackColor = Color.Red;
                else if (rbWhite.Checked) groupBox1.BackColor = Color.White;
                else groupBox1.BackColor = SystemColors.Control;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rbNormal.Checked = true;
            cbForeground.Checked = false;
            cbBackground.Checked = false;
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.BackColor = SystemColors.Control;
        }

        private void rbYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbForeground.Checked) groupBox1.ForeColor = Color.Yellow;
            if (cbBackground.Checked) groupBox1.BackColor = Color.Yellow;
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (cbForeground.Checked) groupBox1.ForeColor = Color.Red;
            if (cbBackground.Checked) groupBox1.BackColor = Color.Red;
        }

        private void rbWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (cbForeground.Checked) groupBox1.ForeColor = Color.White;
            if (cbBackground.Checked) groupBox1.BackColor = Color.White;
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbForeground.Checked) groupBox1.ForeColor = SystemColors.ControlText;
            if (cbBackground.Checked) groupBox1.BackColor = SystemColors.Control;
        }
    }
}

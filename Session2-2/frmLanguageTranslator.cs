using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2_2
{
    public partial class frmLanguageTrans: Form
    {
        public frmLanguageTrans()
        {
            InitializeComponent();
        }
        private void btnItalian1_Click(object sender, EventArgs e)
        {
            lblTranslation1.Text = "Buongiorno";
            lblTranslation1.ForeColor = Color.Red;
        }
        private void btnSpanish1_Click(object sender, EventArgs e)
        {
            lblTranslation1.Text = "Buenos Dias";
            lblTranslation1.ForeColor = Color.Orange;
        }
        private void btnGerman1_Click(object sender, EventArgs e)
        {
            lblTranslation1.Text = "Guten Morgen";
            lblTranslation1.ForeColor = Color.Brown;
        }
    }
}

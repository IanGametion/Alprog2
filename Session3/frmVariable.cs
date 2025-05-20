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
    public partial class frmVariable: Form
    {
        public frmVariable()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            int angka1, angka2, hasil ;
            angka1 = 100;
            angka2 = 50;
            hasil = angka1 + angka2; //(angka1 + angka2) / 2 Hasil BEDA
            label1.Text = hasil.ToString("c");
        }
    }
}

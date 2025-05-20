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
    public partial class frmInputData: Form
    {
        public frmInputData()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNIM.Clear();
            txtNama.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string nim, nama, info_mhs;
            nim = txtNIM.Text;
            nama = txtNama.Text;
            info_mhs = "Nama saya adalah " + nama + ", dengan NIM " + nim;
            MessageBox.Show(info_mhs);
        }
    }
}

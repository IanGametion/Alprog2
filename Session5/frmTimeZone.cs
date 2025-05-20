using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session5
{
    public partial class frmTimeZone: Form
    {
        public frmTimeZone()
        {
            InitializeComponent();
            lblTimeZone.Text = "";
            //isiLstbox();
        }

        private void isiLstbox()
        {
            lstCity.Items.Clear();
            lstCity.Items.Add("Bandung");
            lstCity.Items.Add("Bogor");
            lstCity.Items.Add("Sukabumi");
            lstCity.Items.Add("Denpasar");
            lstCity.Items.Add("Yogyakarta");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string City;
            if (lstCity.SelectedIndex != -1)
            {
                City = lstCity.SelectedItem.ToString();
                switch(City)
                {
                    case "Tokyo":
                        lblTimeZone.Text = "UTC +9";
                        break;
                    case "Jakarta":
                        lblTimeZone.Text = "UTC +7";
                        break;
                    case "Singapore":
                        lblTimeZone.Text = "UTC +8";
                        break;
                    case "Kuala Lumpur":
                        lblTimeZone.Text = "UTC +8";
                        break;
                    case "Seoul":
                        lblTimeZone.Text = "UTC +9";
                        break;
                }
                MessageBox.Show(lstCity.SelectedIndex.ToString());
            }
            else
            {
                MessageBox.Show("Select a city");
            }
        }
    }
}

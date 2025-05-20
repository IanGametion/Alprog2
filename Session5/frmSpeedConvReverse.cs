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
    public partial class frmSpeedConvReverse: Form
    {
        public frmSpeedConvReverse()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            const int START_SPEED = 60;
            const int END_SPEED = 130;
            const int INTERVAL = 10;
            const double CONVERSION_FACTOR = 0.6214;

            int kph;
            double mph;

            for (kph = START_SPEED; kph <= END_SPEED; kph += INTERVAL)
            {
                mph = kph * CONVERSION_FACTOR;
                lstOutput.Items.Add(kph + " KPH is the same as mph " + mph);
            }
        }
    }
}

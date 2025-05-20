using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session7
{
    public partial class frmLights : Form
    {
        public frmLights()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //void method
        private void turnLightOn()
        {
            pbLightOn.Visible = true;
            pbLightOff.Visible = false;
            lblState.Text = "ON";
        }

        private void turnLightOff()
        {
            pbLightOn.Visible = false;
            pbLightOff.Visible = true;
            lblState.Text = "OFF";
        }

        //value-returning method
        private bool onLight()
        {
            pbLightOn.Visible = true;
            pbLightOff.Visible = false;
            lblState.Text = "ON";
            return true;
        }

        private bool offLight()
        {
            pbLightOn.Visible = false;
            pbLightOff.Visible = true;
            lblState.Text = "OFF";
            return false;
        }

        bool state;
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            //if (lblState.Text == "OFF")
            //{
            //    turnLightOn();
            //}
            //else
            //{
            //    turnLightOff();
            //}

            if (state == false)
            {
                state = onLight();
            }
            else
            {
                state = offLight();
            }
        }

        private void frmLights_Load(object sender, EventArgs e)
        {
            state = offLight();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session8
{
    public partial class frmLottery : Form
    {
        public frmLottery()
        {
            InitializeComponent();
            lblFirst.Text = "";
            lblSecond.Text = "";
            lblThird.Text = "";
            lblFourth.Text = "";
            lblFifth.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clearlbl()
        {
            lblFirst.Text = string.Empty;
            lblSecond.Text = string.Empty;
            lblThird.Text = string.Empty;
            lblFourth.Text = string.Empty;
            lblFifth.Text = string.Empty;
        }

        private void frmLottery_Load(object sender, EventArgs e)
        {
            Clearlbl();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            const int SIZE = 5;
            int[] lotteryNums = new int[SIZE];
            Random rand = new Random();

            for (int i = 0; i < lotteryNums.Length; i++)
            {
                lotteryNums[i] = rand.Next(100);
            }
            lblFirst.Text = lotteryNums[0].ToString();
            lblSecond.Text = lotteryNums[1].ToString();
            lblThird.Text = lotteryNums[2].ToString();
            lblFourth.Text = lotteryNums[3].ToString();
            lblFifth.Text = lotteryNums[4].ToString();

            string valueLot = string.Empty;
            foreach (int i in lotteryNums)
            {
                valueLot += Convert.ToString(i);
                listBox1.Items.Add(i);
            }
            listBox1.Items.Add("====");
            if (lotteryNums[0] == lotteryNums[1] && lotteryNums[0] == lotteryNums[2] && lotteryNums[0] == lotteryNums[3] && lotteryNums[0] == lotteryNums[4])
            {
                MessageBox.Show("Duplicate numbers found. Please try again.");
                pictureBox1.Image = Image.FromFile("C:\\Users\\IanGametion\\source\\repos\\Session8\\Resources\\gamblecore-gambling.gif");
            }
            else
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\IanGametion\\source\\repos\\Session8\\Resources\\gamblecore-stickman.gif");
            }
        }
    }
}

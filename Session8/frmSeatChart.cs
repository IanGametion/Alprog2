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
    public partial class frmSeatChart : Form
    {
        public frmSeatChart()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSeatChart_Load(object sender, EventArgs e)
        {
            lblPrice.Text = string.Empty;
        }

        private void btnDispPrice_Click(object sender, EventArgs e)
        {
            int row, col;
            const int MAX_ROW = 5;
            const int MAX_COL = 3;
            decimal[,]prices ={{450m,450m,450m,450m,450m },
                {425m,425m,425m,425m,425m },
                {400m,400m,400m,400m,400m },
                {375m,375m,375m,375m,375m },
                {375m,375m,375m,375m,375m },
                {350m,350m,350m,350m,350m },
            };
            if(int.TryParse(txtRow.Text, out row))
            {
                if (int.TryParse(txtColumn.Text, out col))
                {
                    if (row >= 0 && row <= MAX_ROW)
                    {
                        if (col >= 0 && col <= MAX_COL)
                        {
                            lblPrice.Text = prices[row, col].ToString("c");
                            MessageBox.Show("Anda pesan baris ke " + row + "kolom ke " + col);
                        }
                        else
                            MessageBox.Show("Column must be 0 through " + MAX_COL);
                    }
                    else
                        MessageBox.Show("Row must be 0 through " + MAX_ROW);
                }
                else
                    MessageBox.Show("Enter an integer for the column");
            }
            else
                MessageBox.Show("Enter an integer for the row");
        }
    }
}

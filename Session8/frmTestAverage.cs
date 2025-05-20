using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Session8
{
    public partial class frmTestAverage : Form
    {
        public frmTestAverage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearForm()
        {
            lblAverage.Text = "";
            lblHIghest.Text = "";
            lblLowest.Text = "";
            lstScores.Items.Clear();
        }

        private int[] getScores()
        {
            try
            {
                const int SIZE = 5;
                int[] scores = new int[SIZE];
                int idx = 0;
                StreamReader inputFile;

                inputFile = File.OpenText("TestScores.txt");
                while (!inputFile.EndOfStream && idx < scores.Length)
                {
                    scores[idx] = int.Parse(inputFile.ReadLine());
                    idx++;
                }
                inputFile.Close();
                return scores;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return Array.Empty<int>();
            }
        }

        private int Highest(int[] inpArr)
        {
            int highest = inpArr[0];
            for (int idx = 1; idx < inpArr.Length; idx++)
            {
                if (inpArr[idx] > highest)
                    highest = inpArr[idx];
            }
            return highest;
        }

        private int Lowest(int[] inpArr)
        {
            int lowest = inpArr[0];
            for (int idx = 1; idx < inpArr.Length; idx++)
            {
                if (inpArr[idx] < lowest)
                    lowest = inpArr[idx];
            }
            return lowest;
        }

        private decimal Average(int[] inpArr)
        {
            int total = 0;
            decimal average;
            for (int idx = 1;idx < inpArr.Length; idx++)
            {
                total += inpArr[idx];
            }
            average = Convert.ToDecimal(total) / Convert.ToDecimal(inpArr.Length);
            return average;
        }

        private void frmTestAverage_Load(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnGetScores_Click(object sender, EventArgs e)
        {
            const int SIZE = 5;
            int[] scores = new int[SIZE];
            scores = getScores();
            foreach (int value in scores)
                lstScores.Items.Add(value);

            lblHIghest.Text = Highest(scores).ToString();
            lblLowest.Text = Lowest(scores).ToString();
            lblAverage.Text = Average(scores).ToString();
        }

        private void ReadScores(List<int> valueScore)
        {
            try
            {
                StreamReader inputFile = File.OpenText("TestScores.txt");
                    while (!inputFile.EndOfStream)
                        valueScore.Add(int.Parse(inputFile.ReadLine()));
                    inputFile.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayScores(List<int> valueScore)
        {
            foreach (int score in valueScore)
                lstScoreTest.Items.Add(score);
        }

        private decimal Avg(List<int> valueScore)
        {
            int total = 0;
            decimal average;
            foreach (int score in valueScore)
            {
                total += score;
            }
            average = Convert.ToDecimal(total) / Convert.ToDecimal(valueScore.Count);
            return average;
        }

        private int aboveAvg(List<int> valueScore)
        {
            int numAbove = 0;
            decimal avg = Avg(valueScore);
            foreach (int score in valueScore)
            {
                if (score > avg)
                    numAbove++;
            }
            return numAbove;
        }

        private int belowAvg(List<int> valueScore)
        {
            int numBelow = 0;
            decimal avg = Avg(valueScore);
            foreach (int score in valueScore)
            {
                if (score > avg)
                    numBelow++;
            }
            return numBelow;
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            decimal avgScore;
            int numAbove, numBelow;

            List<int> ScoreList = new List<int>();
            ReadScores(ScoreList);
            DisplayScores(ScoreList);
            avgScore = Avg(ScoreList);
            numAbove = aboveAvg(ScoreList);
            numBelow = belowAvg(ScoreList);
            lblAvg.Text = avgScore.ToString("n1");
            lblAboveAvg.Text = numAbove.ToString();
            lblBelowAvg.Text = numBelow.ToString();
        }
    }
}

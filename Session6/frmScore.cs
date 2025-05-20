using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace Session6
{
    public partial class frmScore: Form
    {
        public frmScore()
        {
            InitializeComponent();
        }

        string nameFile = "Score.txt";

        private void clearForm()
        {
            lblAverage.Text = string.Empty;
            lstScore.Items.Clear();
        }

        private bool FileExists(string fileName)
        {
            if (!File.Exists(fileName))
            {
                btnCreate.Enabled = true;
                btnAdd.Enabled = false;
                btnShowScore.Enabled = false;
                txtScore.Enabled = false;
                return false;
            }
            else
            {
                btnCreate.Enabled = false;
                btnAdd.Enabled = true;
                btnShowScore.Enabled = true;
                txtScore.Enabled = true;
                return true;
            }
        }
        private void printData()
        {
            try
            {
                string score;
                StreamReader inputFile;
                inputFile = File.OpenText(nameFile);
                lstScore.Items.Clear();
                while (!inputFile.EndOfStream)
                {
                    score = inputFile.ReadLine();
                    lstScore.Items.Add(score);
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmScore_Load(object sender, EventArgs e)
        {
            clearForm();
            FileExists(nameFile);
            printData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.CreateText(nameFile);
                outputFile.WriteLine(txtScore.Text);
                outputFile.Close();
                if (FileExists(nameFile))
                    MessageBox.Show("Create File Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //validasi text box tidak diisi
            if (!string.IsNullOrEmpty(txtScore.Text))
            {
                //validasi text box harus diisi dengan numerik (0-100)
                int score = Int32.Parse(txtScore.Text);
                if (score >= 0 && score <= 100)
                {
                    try
                    {
                        StreamWriter outputFile;
                        outputFile = File.AppendText(nameFile);
                        outputFile.WriteLine(txtScore.Text);
                        outputFile.Close();
                        lstScore.Items.Add(txtScore.Text);
                        MessageBox.Show("The score was written");
                        txtScore.Clear();
                        txtScore.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Please Fill the score in between 0 - 100");
            }
            else
                MessageBox.Show("Please fill the score");
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowScore_Click(object sender, EventArgs e)
        {
            try
            {
                //string score;
                int total = 0;
                //StreamReader inputFile;
                //inputFile = File.OpenText(nameFile);
                //lstScore.Items.Clear();
                //while (!inputFile.EndOfStream)
                //{
                //score = inputFile.ReadLine();
                //lstScore.Items.Add(score);
                //total = total + Convert.ToInt32(score);
                //}
                //inputFile.Close();
                if (lstScore.Items.Count > 0)
                {
                    for (int i = 0; i < lstScore.Items.Count; i++)
                        total = total + Convert.ToInt32(lstScore.Items[i]);
                    total = total / lstScore.Items.Count;
                    lblAverage.Text = total.ToString();
                }
                else
                    MessageBox.Show("Empty data, please fill the score first");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //LIMITKAN KEYBOARD UNTUK HANYA BISA NUMERIK
        private void txtScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

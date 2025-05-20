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
    public partial class frmArrayArgument : Form
    {
        public frmArrayArgument()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setToZero(int[] inpArr)
        {
            for (int idx = 0; idx < inpArr.Length; idx++)
            {
                inpArr[idx] = 0;
            }
        }

        private void setToVal(int[] inpArr, ListBox lstBox)
        {
            foreach (int nums in inpArr)
            {
                lstBox.Items.Add(nums);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int[] numbers = {1,2,3};
            lstOutput.Items.Clear();
            lstOutput.Items.Add("The arrays's original contents: ");
            setToVal(numbers, lstOutput);
            setToZero(numbers);
            lstOutput.Items.Add("===============================");
            lstOutput.Items.Add("After calling setToZero: ");
            foreach (int num in numbers)
            {
                lstOutput.Items.Add(num);
            }
        }

        private void btnCopyArr_Click(object sender, EventArgs e)
        {
            const int SIZE = 5;
            int[] arrOne = new int[SIZE] {5,10,15,20,25};
            int[] arrTwo = new int[SIZE];

            foreach (int one in arrOne)
                lstArray1.Items.Add(one);

            //versi copy dari array ke array
            //int idx = 0;
            //while (idx < arrOne.Length)
            //{
            //    arrTwo[idx] = arrOne[idx];
            //    idx++;
            //}

            //versi copy dari Listbox ke array
            for (int i = 0; i < lstArray1.Items.Count; i++)
                arrTwo[i] = Convert.ToInt32(lstArray1.Items[i].ToString());

            foreach (int two in arrTwo)
                lstArray2.Items.Add(two);
        }

        private void copyLstToArr(ListBox lstBox, int[] arr)
        {
            for (int i = 0; i < lstBox.Items.Count; i++)
                arr[i] = Convert.ToInt32(lstBox.Items[i].ToString());
        }

        private void btnCompareArr_Click(object sender, EventArgs e)
        {
            int[] arrSatu = new int[5];
            int[] arrDua = new int[5];
            bool equalArray = false;
            copyLstToArr(lstArray1, arrSatu);
            copyLstToArr(lstArray2, arrDua);

            //Syarat 1: Membandingkan ukuran array, harus sama
            if (arrSatu.Length == arrDua.Length)
                equalArray = true;
            else 
                equalArray = false;

            //Syarat 2: Nilai per index harus sama
            for (int idx = 0; idx < arrSatu.Length & equalArray; idx++)
            {
                if (arrSatu[idx] != arrDua[idx])
                    equalArray = false;
            }

            if (equalArray)
                MessageBox.Show("Same");
            else
                MessageBox.Show("Different");
        }
    }
}

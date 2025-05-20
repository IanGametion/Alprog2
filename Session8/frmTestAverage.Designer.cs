namespace Session8
{
    partial class frmTestAverage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGetScores = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblLowest = new System.Windows.Forms.Label();
            this.lblHIghest = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstScores = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetList = new System.Windows.Forms.Button();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblBelowAvg = new System.Windows.Forms.Label();
            this.lblAboveAvg = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lstScoreTest = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnGetScores);
            this.groupBox1.Controls.Add(this.lblAverage);
            this.groupBox1.Controls.Add(this.lblLowest);
            this.groupBox1.Controls.Add(this.lblHIghest);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstScores);
            this.groupBox1.Location = new System.Drawing.Point(39, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Scores";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(22, 311);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGetScores
            // 
            this.btnGetScores.Location = new System.Drawing.Point(21, 282);
            this.btnGetScores.Name = "btnGetScores";
            this.btnGetScores.Size = new System.Drawing.Size(75, 23);
            this.btnGetScores.TabIndex = 7;
            this.btnGetScores.Text = "Get Scores";
            this.btnGetScores.UseVisualStyleBackColor = true;
            this.btnGetScores.Click += new System.EventHandler(this.btnGetScores_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage.Location = new System.Drawing.Point(97, 203);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(157, 23);
            this.lblAverage.TabIndex = 6;
            this.lblAverage.Text = "label4";
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLowest
            // 
            this.lblLowest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLowest.Location = new System.Drawing.Point(97, 131);
            this.lblLowest.Name = "lblLowest";
            this.lblLowest.Size = new System.Drawing.Size(157, 23);
            this.lblLowest.TabIndex = 5;
            this.lblLowest.Text = "label4";
            this.lblLowest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHIghest
            // 
            this.lblHIghest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHIghest.Location = new System.Drawing.Point(97, 59);
            this.lblHIghest.Name = "lblHIghest";
            this.lblHIghest.Size = new System.Drawing.Size(157, 23);
            this.lblHIghest.TabIndex = 4;
            this.lblHIghest.Text = "label4";
            this.lblHIghest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Average Scores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lowest Scores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Highest Scores";
            // 
            // lstScores
            // 
            this.lstScores.FormattingEnabled = true;
            this.lstScores.Location = new System.Drawing.Point(495, 28);
            this.lstScores.Name = "lstScores";
            this.lstScores.Size = new System.Drawing.Size(163, 342);
            this.lstScores.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGetList);
            this.groupBox2.Controls.Add(this.lblAvg);
            this.groupBox2.Controls.Add(this.lblBelowAvg);
            this.groupBox2.Controls.Add(this.lblAboveAvg);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lstScoreTest);
            this.groupBox2.Location = new System.Drawing.Point(39, 420);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 395);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test Scores";
            // 
            // btnGetList
            // 
            this.btnGetList.Location = new System.Drawing.Point(21, 282);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(75, 23);
            this.btnGetList.TabIndex = 7;
            this.btnGetList.Text = "Get Scores";
            this.btnGetList.UseVisualStyleBackColor = true;
            this.btnGetList.Click += new System.EventHandler(this.btnGetList_Click);
            // 
            // lblAvg
            // 
            this.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAvg.Location = new System.Drawing.Point(97, 203);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(157, 23);
            this.lblAvg.TabIndex = 6;
            this.lblAvg.Text = "label6";
            this.lblAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBelowAvg
            // 
            this.lblBelowAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBelowAvg.Location = new System.Drawing.Point(97, 131);
            this.lblBelowAvg.Name = "lblBelowAvg";
            this.lblBelowAvg.Size = new System.Drawing.Size(157, 23);
            this.lblBelowAvg.TabIndex = 5;
            this.lblBelowAvg.Text = "label5";
            this.lblBelowAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAboveAvg
            // 
            this.lblAboveAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAboveAvg.Location = new System.Drawing.Point(97, 59);
            this.lblAboveAvg.Name = "lblAboveAvg";
            this.lblAboveAvg.Size = new System.Drawing.Size(157, 23);
            this.lblAboveAvg.TabIndex = 4;
            this.lblAboveAvg.Text = "label4";
            this.lblAboveAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Average Scores";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Number of Scores Below";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Number of Scores above";
            // 
            // lstScoreTest
            // 
            this.lstScoreTest.FormattingEnabled = true;
            this.lstScoreTest.Location = new System.Drawing.Point(296, 28);
            this.lstScoreTest.Name = "lstScoreTest";
            this.lstScoreTest.Size = new System.Drawing.Size(163, 342);
            this.lstScoreTest.TabIndex = 0;
            // 
            // frmTestAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 827);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTestAverage";
            this.Text = "frmTestAverage";
            this.Load += new System.EventHandler(this.frmTestAverage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblLowest;
        private System.Windows.Forms.Label lblHIghest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGetScores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGetList;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label lblBelowAvg;
        private System.Windows.Forms.Label lblAboveAvg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstScoreTest;
    }
}
namespace Session8
{
    partial class frmLottery
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblThird = new System.Windows.Forms.Label();
            this.lblFourth = new System.Windows.Forms.Label();
            this.lblFifth = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirst.Location = new System.Drawing.Point(75, 72);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(75, 42);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "label1";
            this.lblFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecond
            // 
            this.lblSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecond.Location = new System.Drawing.Point(147, 72);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(75, 42);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Text = "label2";
            this.lblSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThird
            // 
            this.lblThird.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThird.Location = new System.Drawing.Point(219, 72);
            this.lblThird.Name = "lblThird";
            this.lblThird.Size = new System.Drawing.Size(75, 42);
            this.lblThird.TabIndex = 2;
            this.lblThird.Text = "label3";
            this.lblThird.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFourth
            // 
            this.lblFourth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFourth.Location = new System.Drawing.Point(291, 72);
            this.lblFourth.Name = "lblFourth";
            this.lblFourth.Size = new System.Drawing.Size(75, 42);
            this.lblFourth.TabIndex = 3;
            this.lblFourth.Text = "label4";
            this.lblFourth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFifth
            // 
            this.lblFifth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFifth.Location = new System.Drawing.Point(362, 72);
            this.lblFifth.Name = "lblFifth";
            this.lblFifth.Size = new System.Drawing.Size(75, 42);
            this.lblFifth.TabIndex = 4;
            this.lblFifth.Text = "label5";
            this.lblFifth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(85, 137);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(121, 40);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate Numbers";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(362, 137);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Noto Sans SC Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lets go gambling!!!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Session8.Properties.Resources.Screenshot_2025_05_06_114809;
            this.pictureBox1.Location = new System.Drawing.Point(448, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(75, 212);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(114, 186);
            this.listBox1.TabIndex = 9;
            // 
            // frmLottery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 427);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblFifth);
            this.Controls.Add(this.lblFourth);
            this.Controls.Add(this.lblThird);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.Name = "frmLottery";
            this.Text = "Lottery Number";
            this.Load += new System.EventHandler(this.frmLottery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblThird;
        private System.Windows.Forms.Label lblFourth;
        private System.Windows.Forms.Label lblFifth;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}


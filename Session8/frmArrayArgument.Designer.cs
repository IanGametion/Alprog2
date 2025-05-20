namespace Session8
{
    partial class frmArrayArgument
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
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstArray1 = new System.Windows.Forms.ListBox();
            this.lstArray2 = new System.Windows.Forms.ListBox();
            this.btnCopyArr = new System.Windows.Forms.Button();
            this.btnCompareArr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(12, 12);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(167, 264);
            this.lstOutput.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(201, 223);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(115, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(201, 252);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 24);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstArray1
            // 
            this.lstArray1.FormattingEnabled = true;
            this.lstArray1.Location = new System.Drawing.Point(333, 12);
            this.lstArray1.Name = "lstArray1";
            this.lstArray1.Size = new System.Drawing.Size(120, 199);
            this.lstArray1.TabIndex = 3;
            // 
            // lstArray2
            // 
            this.lstArray2.FormattingEnabled = true;
            this.lstArray2.Location = new System.Drawing.Point(459, 12);
            this.lstArray2.Name = "lstArray2";
            this.lstArray2.Size = new System.Drawing.Size(120, 199);
            this.lstArray2.TabIndex = 4;
            // 
            // btnCopyArr
            // 
            this.btnCopyArr.Location = new System.Drawing.Point(333, 223);
            this.btnCopyArr.Name = "btnCopyArr";
            this.btnCopyArr.Size = new System.Drawing.Size(120, 23);
            this.btnCopyArr.TabIndex = 5;
            this.btnCopyArr.Text = "Copy Array";
            this.btnCopyArr.UseVisualStyleBackColor = true;
            this.btnCopyArr.Click += new System.EventHandler(this.btnCopyArr_Click);
            // 
            // btnCompareArr
            // 
            this.btnCompareArr.Location = new System.Drawing.Point(459, 223);
            this.btnCompareArr.Name = "btnCompareArr";
            this.btnCompareArr.Size = new System.Drawing.Size(120, 23);
            this.btnCompareArr.TabIndex = 6;
            this.btnCompareArr.Text = "Compare Array";
            this.btnCompareArr.UseVisualStyleBackColor = true;
            this.btnCompareArr.Click += new System.EventHandler(this.btnCompareArr_Click);
            // 
            // frmArrayArgument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 303);
            this.Controls.Add(this.btnCompareArr);
            this.Controls.Add(this.btnCopyArr);
            this.Controls.Add(this.lstArray2);
            this.Controls.Add(this.lstArray1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lstOutput);
            this.Name = "frmArrayArgument";
            this.Text = "Array Argument";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstArray1;
        private System.Windows.Forms.ListBox lstArray2;
        private System.Windows.Forms.Button btnCopyArr;
        private System.Windows.Forms.Button btnCompareArr;
    }
}
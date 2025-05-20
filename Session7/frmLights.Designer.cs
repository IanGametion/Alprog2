namespace Session7
{
    partial class frmLights
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
            this.lblState = new System.Windows.Forms.Label();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbLightOff = new System.Windows.Forms.PictureBox();
            this.pbLightOn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLightOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLightOn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblState
            // 
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblState.Location = new System.Drawing.Point(121, 398);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(212, 42);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "label1";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(121, 455);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(112, 59);
            this.btnSwitch.TabIndex = 3;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(258, 455);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbLightOff
            // 
            this.pbLightOff.Image = global::Session7.Properties.Resources.lightbulb_off;
            this.pbLightOff.Location = new System.Drawing.Point(396, 35);
            this.pbLightOff.Name = "pbLightOff";
            this.pbLightOff.Size = new System.Drawing.Size(249, 354);
            this.pbLightOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLightOff.TabIndex = 1;
            this.pbLightOff.TabStop = false;
            // 
            // pbLightOn
            // 
            this.pbLightOn.Image = global::Session7.Properties.Resources.lightbulb_on;
            this.pbLightOn.Location = new System.Drawing.Point(51, 35);
            this.pbLightOn.Name = "pbLightOn";
            this.pbLightOn.Size = new System.Drawing.Size(249, 354);
            this.pbLightOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLightOn.TabIndex = 0;
            this.pbLightOn.TabStop = false;
            // 
            // frmLights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 636);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.pbLightOff);
            this.Controls.Add(this.pbLightOn);
            this.Name = "frmLights";
            this.Text = "Lights";
            this.Load += new System.EventHandler(this.frmLights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLightOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLightOn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLightOn;
        private System.Windows.Forms.PictureBox pbLightOff;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnExit;
    }
}


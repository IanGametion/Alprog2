namespace Session3_1
{
    partial class frmFlags
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
            this.label1 = new System.Windows.Forms.Label();
            this.pbJerman = new System.Windows.Forms.PictureBox();
            this.pbRusia = new System.Windows.Forms.PictureBox();
            this.pbJepang = new System.Windows.Forms.PictureBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbJerman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRusia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJepang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click a flag to see the name of the country";
            // 
            // pbJerman
            // 
            this.pbJerman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbJerman.Image = global::Session3_1.Properties.Resources.jerman;
            this.pbJerman.Location = new System.Drawing.Point(43, 69);
            this.pbJerman.Name = "pbJerman";
            this.pbJerman.Size = new System.Drawing.Size(100, 50);
            this.pbJerman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbJerman.TabIndex = 1;
            this.pbJerman.TabStop = false;
            this.pbJerman.Click += new System.EventHandler(this.pbJerman_Click);
            // 
            // pbRusia
            // 
            this.pbRusia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRusia.Image = global::Session3_1.Properties.Resources.rusia;
            this.pbRusia.Location = new System.Drawing.Point(149, 69);
            this.pbRusia.Name = "pbRusia";
            this.pbRusia.Size = new System.Drawing.Size(100, 50);
            this.pbRusia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRusia.TabIndex = 2;
            this.pbRusia.TabStop = false;
            this.pbRusia.Click += new System.EventHandler(this.pbRusia_Click);
            // 
            // pbJepang
            // 
            this.pbJepang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbJepang.Image = global::Session3_1.Properties.Resources.jepang;
            this.pbJepang.Location = new System.Drawing.Point(255, 69);
            this.pbJepang.Name = "pbJepang";
            this.pbJepang.Size = new System.Drawing.Size(100, 50);
            this.pbJepang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbJepang.TabIndex = 3;
            this.pbJepang.TabStop = false;
            this.pbJepang.Click += new System.EventHandler(this.pbJepang_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(43, 141);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(312, 58);
            this.lblCountry.TabIndex = 4;
            this.lblCountry.Text = "label2";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(43, 214);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 41);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show Flag";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(255, 214);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(100, 41);
            this.btnHide.TabIndex = 6;
            this.btnHide.Text = "Hide Flag";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // frmFlags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 294);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.pbJepang);
            this.Controls.Add(this.pbRusia);
            this.Controls.Add(this.pbJerman);
            this.Controls.Add(this.label1);
            this.Name = "frmFlags";
            this.Text = "Flags";
            ((System.ComponentModel.ISupportInitialize)(this.pbJerman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRusia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJepang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbJerman;
        private System.Windows.Forms.PictureBox pbRusia;
        private System.Windows.Forms.PictureBox pbJepang;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
    }
}


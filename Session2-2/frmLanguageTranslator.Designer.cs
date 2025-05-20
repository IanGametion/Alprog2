namespace Session2_2
{
    partial class frmLanguageTrans
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
            this.btnItalian1 = new System.Windows.Forms.Button();
            this.btnSpanish1 = new System.Windows.Forms.Button();
            this.btnGerman1 = new System.Windows.Forms.Button();
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.lblTranslation1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnItalian1
            // 
            this.btnItalian1.Location = new System.Drawing.Point(70, 166);
            this.btnItalian1.Name = "btnItalian1";
            this.btnItalian1.Size = new System.Drawing.Size(75, 23);
            this.btnItalian1.TabIndex = 0;
            this.btnItalian1.Text = "Italian";
            this.btnItalian1.UseVisualStyleBackColor = true;
            this.btnItalian1.Click += new System.EventHandler(this.btnItalian1_Click);
            // 
            // btnSpanish1
            // 
            this.btnSpanish1.Location = new System.Drawing.Point(151, 166);
            this.btnSpanish1.Name = "btnSpanish1";
            this.btnSpanish1.Size = new System.Drawing.Size(75, 23);
            this.btnSpanish1.TabIndex = 1;
            this.btnSpanish1.Text = "Spanish";
            this.btnSpanish1.UseVisualStyleBackColor = true;
            this.btnSpanish1.Click += new System.EventHandler(this.btnSpanish1_Click);
            // 
            // btnGerman1
            // 
            this.btnGerman1.Location = new System.Drawing.Point(232, 166);
            this.btnGerman1.Name = "btnGerman1";
            this.btnGerman1.Size = new System.Drawing.Size(75, 23);
            this.btnGerman1.TabIndex = 2;
            this.btnGerman1.Text = "German";
            this.btnGerman1.UseVisualStyleBackColor = true;
            this.btnGerman1.Click += new System.EventHandler(this.btnGerman1_Click);
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.Location = new System.Drawing.Point(70, 63);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(282, 16);
            this.lblInstruction1.TabIndex = 3;
            this.lblInstruction1.Text = "Select a language and I will say Good Morning";
            // 
            // lblTranslation1
            // 
            this.lblTranslation1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTranslation1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranslation1.Location = new System.Drawing.Point(73, 93);
            this.lblTranslation1.Name = "lblTranslation1";
            this.lblTranslation1.Size = new System.Drawing.Size(309, 52);
            this.lblTranslation1.TabIndex = 4;
            this.lblTranslation1.Text = "label2";
            this.lblTranslation1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLanguageTrans
            // 
            this.ClientSize = new System.Drawing.Size(576, 291);
            this.Controls.Add(this.lblTranslation1);
            this.Controls.Add(this.lblInstruction1);
            this.Controls.Add(this.btnGerman1);
            this.Controls.Add(this.btnSpanish1);
            this.Controls.Add(this.btnItalian1);
            this.Name = "frmLanguageTrans";
            this.Text = "Language Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnItalian;
        private System.Windows.Forms.Button btnSpanish;
        private System.Windows.Forms.Button btnGerman;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblTranslation;
        private System.Windows.Forms.Button btnItalian1;
        private System.Windows.Forms.Button btnSpanish1;
        private System.Windows.Forms.Button btnGerman1;
        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.Label lblTranslation1;
    }
}


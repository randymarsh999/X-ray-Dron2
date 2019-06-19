
    partial class frmMOptions
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
            this.txtComposition = new System.Windows.Forms.TextBox();
            this.txtSampleNumber = new System.Windows.Forms.TextBox();
            this.txtTempSint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDensityExp = new System.Windows.Forms.TextBox();
            this.p_exp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIntensivityArbInterval = new System.Windows.Forms.ComboBox();
            this.cmbSavingType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtComposition
            // 
            this.txtComposition.Location = new System.Drawing.Point(19, 21);
            this.txtComposition.Name = "txtComposition";
            this.txtComposition.Size = new System.Drawing.Size(117, 20);
            this.txtComposition.TabIndex = 0;
            this.txtComposition.Text = "K20";
            this.txtComposition.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSampleNumber
            // 
            this.txtSampleNumber.Location = new System.Drawing.Point(19, 63);
            this.txtSampleNumber.Name = "txtSampleNumber";
            this.txtSampleNumber.Size = new System.Drawing.Size(117, 20);
            this.txtSampleNumber.TabIndex = 1;
            this.txtSampleNumber.Text = "1";
            // 
            // txtTempSint
            // 
            this.txtTempSint.Location = new System.Drawing.Point(19, 102);
            this.txtTempSint.Name = "txtTempSint";
            this.txtTempSint.Size = new System.Drawing.Size(117, 20);
            this.txtTempSint.TabIndex = 2;
            this.txtTempSint.Text = "1200";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Composition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sample number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "tempSint";
            // 
            // txtDensityExp
            // 
            this.txtDensityExp.Location = new System.Drawing.Point(19, 138);
            this.txtDensityExp.Name = "txtDensityExp";
            this.txtDensityExp.Size = new System.Drawing.Size(117, 20);
            this.txtDensityExp.TabIndex = 6;
            this.txtDensityExp.Text = "4.45";
            // 
            // p_exp
            // 
            this.p_exp.AutoSize = true;
            this.p_exp.Location = new System.Drawing.Point(16, 122);
            this.p_exp.Name = "p_exp";
            this.p_exp.Size = new System.Drawing.Size(39, 13);
            this.p_exp.TabIndex = 7;
            this.p_exp.Text = "p_exp.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Interval, arb";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // cmbIntensivityArbInterval
            // 
            this.cmbIntensivityArbInterval.FormattingEnabled = true;
            this.cmbIntensivityArbInterval.Items.AddRange(new object[] {
            "200",
            "400",
            "1000"});
            this.cmbIntensivityArbInterval.Location = new System.Drawing.Point(159, 39);
            this.cmbIntensivityArbInterval.Name = "cmbIntensivityArbInterval";
            this.cmbIntensivityArbInterval.Size = new System.Drawing.Size(121, 21);
            this.cmbIntensivityArbInterval.TabIndex = 10;
            this.cmbIntensivityArbInterval.Text = "1000";
            // 
            // cmbSavingType
            // 
            this.cmbSavingType.FormattingEnabled = true;
            this.cmbSavingType.Items.AddRange(new object[] {
            "Text",
            "SQL file"});
            this.cmbSavingType.Location = new System.Drawing.Point(159, 101);
            this.cmbSavingType.Name = "cmbSavingType";
            this.cmbSavingType.Size = new System.Drawing.Size(121, 21);
            this.cmbSavingType.TabIndex = 12;
            this.cmbSavingType.Text = "Text";
            this.cmbSavingType.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Saving type";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // frmMOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 167);
            this.Controls.Add(this.cmbSavingType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbIntensivityArbInterval);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.p_exp);
            this.Controls.Add(this.txtDensityExp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTempSint);
            this.Controls.Add(this.txtSampleNumber);
            this.Controls.Add(this.txtComposition);
            this.Name = "frmMOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Measurment options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtComposition;
        public System.Windows.Forms.TextBox txtSampleNumber;
        public System.Windows.Forms.TextBox txtTempSint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDensityExp;
        private System.Windows.Forms.Label p_exp;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cmbIntensivityArbInterval;
    public System.Windows.Forms.ComboBox cmbSavingType;
    private System.Windows.Forms.Label label5;
}

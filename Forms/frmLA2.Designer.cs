//namespace RshExample.Forms
//{
    partial class frmLA2
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
            this.txtSAMPLE_FREQ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBufSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSAMPLE_FREQ
            // 
            this.txtSAMPLE_FREQ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSAMPLE_FREQ.Location = new System.Drawing.Point(122, 10);
            this.txtSAMPLE_FREQ.Name = "txtSAMPLE_FREQ";
            this.txtSAMPLE_FREQ.Size = new System.Drawing.Size(100, 26);
            this.txtSAMPLE_FREQ.TabIndex = 0;
            this.txtSAMPLE_FREQ.Text = "200000";
            this.txtSAMPLE_FREQ.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "f, Hz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Timer, ms";
            // 
            // txtTimer
            // 
            this.txtTimer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTimer.Location = new System.Drawing.Point(122, 42);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(100, 26);
            this.txtTimer.TabIndex = 2;
            this.txtTimer.Text = "115";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Buffer size, value";
            // 
            // txtBufSize
            // 
            this.txtBufSize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBufSize.Location = new System.Drawing.Point(122, 74);
            this.txtBufSize.Name = "txtBufSize";
            this.txtBufSize.Size = new System.Drawing.Size(100, 26);
            this.txtBufSize.TabIndex = 4;
            this.txtBufSize.Text = "512";
            // 
            // frmLA2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 109);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBufSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSAMPLE_FREQ);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLA2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LA2USB_Options";
            this.Load += new System.EventHandler(this.FrmLA2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtSAMPLE_FREQ;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    public System.Windows.Forms.TextBox txtTimer;
    private System.Windows.Forms.Label label3;
    public System.Windows.Forms.TextBox txtBufSize;
}
//}
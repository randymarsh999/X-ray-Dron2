namespace StartStop
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnMeas = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lA2USBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measurmentOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chMeas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.measTimer = new System.Windows.Forms.Timer(this.components);
            this.lStatus = new System.Windows.Forms.Label();
            this.sDlg = new System.Windows.Forms.SaveFileDialog();
            this.dGridTempMeas = new System.Windows.Forms.DataGridView();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.txtSAMPLE_FREQ = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtBufSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chMeas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridTempMeas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMeas
            // 
            this.btnMeas.Location = new System.Drawing.Point(22, 350);
            this.btnMeas.Name = "btnMeas";
            this.btnMeas.Size = new System.Drawing.Size(75, 23);
            this.btnMeas.TabIndex = 0;
            this.btnMeas.Text = "Meas";
            this.btnMeas.UseVisualStyleBackColor = true;
            this.btnMeas.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(822, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lA2USBToolStripMenuItem,
            this.measurmentOptionsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // lA2USBToolStripMenuItem
            // 
            this.lA2USBToolStripMenuItem.Name = "lA2USBToolStripMenuItem";
            this.lA2USBToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.lA2USBToolStripMenuItem.Text = "LA2USB";
            this.lA2USBToolStripMenuItem.Click += new System.EventHandler(this.lA2USBToolStripMenuItem_Click);
            // 
            // measurmentOptionsToolStripMenuItem
            // 
            this.measurmentOptionsToolStripMenuItem.Name = "measurmentOptionsToolStripMenuItem";
            this.measurmentOptionsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.measurmentOptionsToolStripMenuItem.Text = "Measurment options";
            this.measurmentOptionsToolStripMenuItem.Click += new System.EventHandler(this.measurmentOptionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // chMeas
            // 
            chartArea2.Name = "ChartArea1";
            this.chMeas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chMeas.Legends.Add(legend2);
            this.chMeas.Location = new System.Drawing.Point(34, 44);
            this.chMeas.Name = "chMeas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chMeas.Series.Add(series2);
            this.chMeas.Size = new System.Drawing.Size(754, 279);
            this.chMeas.TabIndex = 2;
            this.chMeas.Text = "chart1";
            // 
            // measTimer
            // 
            this.measTimer.Interval = 200;
            this.measTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(115, 355);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(65, 13);
            this.lStatus.TabIndex = 3;
            this.lStatus.Tag = "text";
            this.lStatus.Text = "Status: Stop";
            // 
            // sDlg
            // 
            this.sDlg.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            this.sDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.sDlg_FileOk);
            // 
            // dGridTempMeas
            // 
            this.dGridTempMeas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridTempMeas.Location = new System.Drawing.Point(186, 350);
            this.dGridTempMeas.Name = "dGridTempMeas";
            this.dGridTempMeas.Size = new System.Drawing.Size(602, 177);
            this.dGridTempMeas.TabIndex = 4;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(265, 327);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 5;
            this.txtTemp.Text = "300";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Tag = "text";
            this.label1.Text = "Current temp.:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTimer
            // 
            this.txtTimer.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.txtTimer.Location = new System.Drawing.Point(22, 543);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(100, 20);
            this.txtTimer.TabIndex = 7;
            this.txtTimer.Text = "115";
            this.txtTimer.TextChanged += new System.EventHandler(this.TxtTimer_TextChanged);
            // 
            // txtSAMPLE_FREQ
            // 
            this.txtSAMPLE_FREQ.Location = new System.Drawing.Point(165, 543);
            this.txtSAMPLE_FREQ.Name = "txtSAMPLE_FREQ";
            this.txtSAMPLE_FREQ.Size = new System.Drawing.Size(100, 20);
            this.txtSAMPLE_FREQ.TabIndex = 8;
            this.txtSAMPLE_FREQ.Text = "250000";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(34, 442);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // txtBufSize
            // 
            this.txtBufSize.Location = new System.Drawing.Point(310, 543);
            this.txtBufSize.Name = "txtBufSize";
            this.txtBufSize.Size = new System.Drawing.Size(100, 20);
            this.txtBufSize.TabIndex = 10;
            this.txtBufSize.Text = "512";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 11;
            this.label2.Tag = "text";
            this.label2.Text = "Timer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Tag = "text";
            this.label3.Text = "f, Hz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 13;
            this.label4.Tag = "text";
            this.label4.Text = "Buffer_Size";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 591);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBufSize);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtSAMPLE_FREQ);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.dGridTempMeas);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.chMeas);
            this.Controls.Add(this.btnMeas);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DRON2";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chMeas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridTempMeas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMeas;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chMeas;
        private System.Windows.Forms.Timer measTimer;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sDlg;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lA2USBToolStripMenuItem;
        private System.Windows.Forms.DataGridView dGridTempMeas;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem measurmentOptionsToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.TextBox txtSAMPLE_FREQ;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtBufSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
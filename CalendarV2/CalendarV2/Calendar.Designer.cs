namespace CalendarV2
{
    partial class Calendar
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
            this.flPnlGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.fpPanelDaylbl = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSun = new System.Windows.Forms.Label();
            this.lbMon = new System.Windows.Forms.Label();
            this.lblTue = new System.Windows.Forms.Label();
            this.lblWed = new System.Windows.Forms.Label();
            this.lblThu = new System.Windows.Forms.Label();
            this.lblFri = new System.Windows.Forms.Label();
            this.lblSat = new System.Windows.Forms.Label();
            this.lblDispMY = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timerOneSec = new System.Windows.Forms.Timer(this.components);
            this.ttPopup = new System.Windows.Forms.ToolTip(this.components);
            this.fpPanelDaylbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // flPnlGrid
            // 
            this.flPnlGrid.Location = new System.Drawing.Point(12, 225);
            this.flPnlGrid.Margin = new System.Windows.Forms.Padding(10);
            this.flPnlGrid.Name = "flPnlGrid";
            this.flPnlGrid.Size = new System.Drawing.Size(423, 332);
            this.flPnlGrid.TabIndex = 0;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrev.Location = new System.Drawing.Point(342, 125);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(42, 30);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNext.Location = new System.Drawing.Point(389, 125);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(42, 30);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // fpPanelDaylbl
            // 
            this.fpPanelDaylbl.Controls.Add(this.lblSun);
            this.fpPanelDaylbl.Controls.Add(this.lbMon);
            this.fpPanelDaylbl.Controls.Add(this.lblTue);
            this.fpPanelDaylbl.Controls.Add(this.lblWed);
            this.fpPanelDaylbl.Controls.Add(this.lblThu);
            this.fpPanelDaylbl.Controls.Add(this.lblFri);
            this.fpPanelDaylbl.Controls.Add(this.lblSat);
            this.fpPanelDaylbl.Location = new System.Drawing.Point(12, 162);
            this.fpPanelDaylbl.Name = "fpPanelDaylbl";
            this.fpPanelDaylbl.Size = new System.Drawing.Size(423, 60);
            this.fpPanelDaylbl.TabIndex = 2;
            // 
            // lblSun
            // 
            this.lblSun.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSun.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSun.Location = new System.Drawing.Point(2, 2);
            this.lblSun.Margin = new System.Windows.Forms.Padding(2);
            this.lblSun.Name = "lblSun";
            this.lblSun.Size = new System.Drawing.Size(54, 44);
            this.lblSun.TabIndex = 0;
            this.lblSun.Text = "Sun";
            this.lblSun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMon
            // 
            this.lbMon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMon.ForeColor = System.Drawing.SystemColors.Control;
            this.lbMon.Location = new System.Drawing.Point(60, 2);
            this.lbMon.Margin = new System.Windows.Forms.Padding(2);
            this.lbMon.Name = "lbMon";
            this.lbMon.Size = new System.Drawing.Size(54, 44);
            this.lbMon.TabIndex = 0;
            this.lbMon.Text = "Mon";
            this.lbMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTue
            // 
            this.lblTue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTue.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTue.Location = new System.Drawing.Point(118, 2);
            this.lblTue.Margin = new System.Windows.Forms.Padding(2);
            this.lblTue.Name = "lblTue";
            this.lblTue.Size = new System.Drawing.Size(54, 44);
            this.lblTue.TabIndex = 0;
            this.lblTue.Text = "Tue";
            this.lblTue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWed
            // 
            this.lblWed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWed.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWed.Location = new System.Drawing.Point(176, 2);
            this.lblWed.Margin = new System.Windows.Forms.Padding(2);
            this.lblWed.Name = "lblWed";
            this.lblWed.Size = new System.Drawing.Size(54, 44);
            this.lblWed.TabIndex = 0;
            this.lblWed.Text = "Wed";
            this.lblWed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThu
            // 
            this.lblThu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThu.ForeColor = System.Drawing.SystemColors.Control;
            this.lblThu.Location = new System.Drawing.Point(234, 2);
            this.lblThu.Margin = new System.Windows.Forms.Padding(2);
            this.lblThu.Name = "lblThu";
            this.lblThu.Size = new System.Drawing.Size(54, 44);
            this.lblThu.TabIndex = 0;
            this.lblThu.Text = "Thu";
            this.lblThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFri
            // 
            this.lblFri.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFri.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFri.Location = new System.Drawing.Point(292, 2);
            this.lblFri.Margin = new System.Windows.Forms.Padding(2);
            this.lblFri.Name = "lblFri";
            this.lblFri.Size = new System.Drawing.Size(54, 44);
            this.lblFri.TabIndex = 0;
            this.lblFri.Text = "Fri";
            this.lblFri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSat
            // 
            this.lblSat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSat.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSat.Location = new System.Drawing.Point(350, 2);
            this.lblSat.Margin = new System.Windows.Forms.Padding(2);
            this.lblSat.Name = "lblSat";
            this.lblSat.Size = new System.Drawing.Size(54, 44);
            this.lblSat.TabIndex = 0;
            this.lblSat.Text = "Sat";
            this.lblSat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDispMY
            // 
            this.lblDispMY.AutoSize = true;
            this.lblDispMY.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispMY.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDispMY.Location = new System.Drawing.Point(21, 129);
            this.lblDispMY.Name = "lblDispMY";
            this.lblDispMY.Size = new System.Drawing.Size(186, 29);
            this.lblDispMY.TabIndex = 3;
            this.lblDispMY.Text = "December 2022";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTime.Location = new System.Drawing.Point(21, 35);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(234, 43);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "00:00:00 PM";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDate.Location = new System.Drawing.Point(24, 78);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(120, 19);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Friday, 6, 2022";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // timerOneSec
            // 
            this.timerOneSec.Enabled = true;
            this.timerOneSec.Interval = 500;
            this.timerOneSec.Tick += new System.EventHandler(this.timerOneSec_Tick);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(446, 605);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDispMY);
            this.Controls.Add(this.fpPanelDaylbl);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.flPnlGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.fpPanelDaylbl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPnlGrid;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.FlowLayoutPanel fpPanelDaylbl;
        private System.Windows.Forms.Label lblSun;
        private System.Windows.Forms.Label lbMon;
        private System.Windows.Forms.Label lblTue;
        private System.Windows.Forms.Label lblWed;
        private System.Windows.Forms.Label lblThu;
        private System.Windows.Forms.Label lblFri;
        private System.Windows.Forms.Label lblSat;
        private System.Windows.Forms.Label lblDispMY;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timerOneSec;
        private System.Windows.Forms.ToolTip ttPopup;

    }
}


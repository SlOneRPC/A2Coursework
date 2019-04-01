namespace A2CourseWork.Gui.ViewBooking
{
    partial class ByDate
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnreport = new System.Windows.Forms.Button();
            this.revenuelbl = new System.Windows.Forms.Label();
            this.amountlbl = new System.Windows.Forms.Label();
            this.weeklbl = new System.Windows.Forms.Label();
            this.week3rbtn = new System.Windows.Forms.RadioButton();
            this.week5rbtn = new System.Windows.Forms.RadioButton();
            this.week2rbtn = new System.Windows.Forms.RadioButton();
            this.week4rbtn = new System.Windows.Forms.RadioButton();
            this.week1rbtn = new System.Windows.Forms.RadioButton();
            this.WeekView = new System.Windows.Forms.DataGridView();
            this.monthscbx = new System.Windows.Forms.ComboBox();
            this.yearcbx = new System.Windows.Forms.ComboBox();
            this.KidsView = new System.Windows.Forms.DataGridView();
            this.titlebox = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.PictureBox();
            this.Canceled = new System.Windows.Forms.CheckBox();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeekView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KidsView)).BeginInit();
            this.titlebox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.Canceled);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.week3rbtn);
            this.panel3.Controls.Add(this.week5rbtn);
            this.panel3.Controls.Add(this.week2rbtn);
            this.panel3.Controls.Add(this.week4rbtn);
            this.panel3.Controls.Add(this.week1rbtn);
            this.panel3.Controls.Add(this.WeekView);
            this.panel3.Controls.Add(this.monthscbx);
            this.panel3.Controls.Add(this.yearcbx);
            this.panel3.Controls.Add(this.KidsView);
            this.panel3.Controls.Add(this.titlebox);
            this.panel3.Location = new System.Drawing.Point(162, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(806, 509);
            this.panel3.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Select Week:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 24);
            this.label7.TabIndex = 29;
            this.label7.Text = "Select Year:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Select Month:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnreport);
            this.panel5.Controls.Add(this.revenuelbl);
            this.panel5.Controls.Add(this.amountlbl);
            this.panel5.Controls.Add(this.weeklbl);
            this.panel5.Location = new System.Drawing.Point(7, 290);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(228, 212);
            this.panel5.TabIndex = 24;
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.Gray;
            this.btnreport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.Location = new System.Drawing.Point(21, 165);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(171, 42);
            this.btnreport.TabIndex = 18;
            this.btnreport.Text = "Generate report";
            this.btnreport.UseVisualStyleBackColor = false;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // revenuelbl
            // 
            this.revenuelbl.AutoSize = true;
            this.revenuelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenuelbl.ForeColor = System.Drawing.Color.White;
            this.revenuelbl.Location = new System.Drawing.Point(3, 60);
            this.revenuelbl.Name = "revenuelbl";
            this.revenuelbl.Size = new System.Drawing.Size(172, 24);
            this.revenuelbl.TabIndex = 27;
            this.revenuelbl.Text = "Estimated revenue:";
            // 
            // amountlbl
            // 
            this.amountlbl.AutoSize = true;
            this.amountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountlbl.ForeColor = System.Drawing.Color.White;
            this.amountlbl.Location = new System.Drawing.Point(3, 36);
            this.amountlbl.Name = "amountlbl";
            this.amountlbl.Size = new System.Drawing.Size(152, 24);
            this.amountlbl.TabIndex = 26;
            this.amountlbl.Text = "Booking amount:";
            // 
            // weeklbl
            // 
            this.weeklbl.AutoSize = true;
            this.weeklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklbl.ForeColor = System.Drawing.Color.White;
            this.weeklbl.Location = new System.Drawing.Point(3, 12);
            this.weeklbl.Name = "weeklbl";
            this.weeklbl.Size = new System.Drawing.Size(64, 24);
            this.weeklbl.TabIndex = 25;
            this.weeklbl.Text = "Week:";
            // 
            // week3rbtn
            // 
            this.week3rbtn.AutoSize = true;
            this.week3rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.week3rbtn.ForeColor = System.Drawing.Color.White;
            this.week3rbtn.Location = new System.Drawing.Point(165, 184);
            this.week3rbtn.Name = "week3rbtn";
            this.week3rbtn.Size = new System.Drawing.Size(77, 24);
            this.week3rbtn.TabIndex = 23;
            this.week3rbtn.Text = "Week3";
            this.week3rbtn.UseVisualStyleBackColor = true;
            this.week3rbtn.CheckedChanged += new System.EventHandler(this.week2rbtn_CheckedChanged);
            // 
            // week5rbtn
            // 
            this.week5rbtn.AutoSize = true;
            this.week5rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.week5rbtn.ForeColor = System.Drawing.Color.White;
            this.week5rbtn.Location = new System.Drawing.Point(90, 206);
            this.week5rbtn.Name = "week5rbtn";
            this.week5rbtn.Size = new System.Drawing.Size(77, 24);
            this.week5rbtn.TabIndex = 22;
            this.week5rbtn.Text = "Week5";
            this.week5rbtn.UseVisualStyleBackColor = true;
            this.week5rbtn.CheckedChanged += new System.EventHandler(this.week2rbtn_CheckedChanged);
            // 
            // week2rbtn
            // 
            this.week2rbtn.AutoSize = true;
            this.week2rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.week2rbtn.ForeColor = System.Drawing.Color.White;
            this.week2rbtn.Location = new System.Drawing.Point(90, 184);
            this.week2rbtn.Name = "week2rbtn";
            this.week2rbtn.Size = new System.Drawing.Size(77, 24);
            this.week2rbtn.TabIndex = 21;
            this.week2rbtn.Text = "Week2";
            this.week2rbtn.UseVisualStyleBackColor = true;
            this.week2rbtn.CheckedChanged += new System.EventHandler(this.week2rbtn_CheckedChanged);
            // 
            // week4rbtn
            // 
            this.week4rbtn.AutoSize = true;
            this.week4rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.week4rbtn.ForeColor = System.Drawing.Color.White;
            this.week4rbtn.Location = new System.Drawing.Point(7, 206);
            this.week4rbtn.Name = "week4rbtn";
            this.week4rbtn.Size = new System.Drawing.Size(77, 24);
            this.week4rbtn.TabIndex = 20;
            this.week4rbtn.Text = "Week4";
            this.week4rbtn.UseVisualStyleBackColor = true;
            this.week4rbtn.CheckedChanged += new System.EventHandler(this.week2rbtn_CheckedChanged);
            // 
            // week1rbtn
            // 
            this.week1rbtn.AutoSize = true;
            this.week1rbtn.Checked = true;
            this.week1rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.week1rbtn.ForeColor = System.Drawing.Color.White;
            this.week1rbtn.Location = new System.Drawing.Point(7, 184);
            this.week1rbtn.Name = "week1rbtn";
            this.week1rbtn.Size = new System.Drawing.Size(77, 24);
            this.week1rbtn.TabIndex = 19;
            this.week1rbtn.TabStop = true;
            this.week1rbtn.Text = "Week1";
            this.week1rbtn.UseVisualStyleBackColor = true;
            this.week1rbtn.CheckedChanged += new System.EventHandler(this.week2rbtn_CheckedChanged);
            // 
            // WeekView
            // 
            this.WeekView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.WeekView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.WeekView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeekView.Location = new System.Drawing.Point(241, 229);
            this.WeekView.Name = "WeekView";
            this.WeekView.Size = new System.Drawing.Size(557, 273);
            this.WeekView.TabIndex = 18;
            // 
            // monthscbx
            // 
            this.monthscbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthscbx.FormattingEnabled = true;
            this.monthscbx.Location = new System.Drawing.Point(5, 131);
            this.monthscbx.Name = "monthscbx";
            this.monthscbx.Size = new System.Drawing.Size(210, 28);
            this.monthscbx.TabIndex = 17;
            this.monthscbx.SelectedIndexChanged += new System.EventHandler(this.monthscbx_SelectedIndexChanged);
            // 
            // yearcbx
            // 
            this.yearcbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearcbx.FormattingEnabled = true;
            this.yearcbx.Location = new System.Drawing.Point(5, 78);
            this.yearcbx.Name = "yearcbx";
            this.yearcbx.Size = new System.Drawing.Size(212, 28);
            this.yearcbx.TabIndex = 14;
            this.yearcbx.SelectedIndexChanged += new System.EventHandler(this.yearcbx_SelectedIndexChanged);
            // 
            // KidsView
            // 
            this.KidsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KidsView.Location = new System.Drawing.Point(241, 58);
            this.KidsView.Name = "KidsView";
            this.KidsView.Size = new System.Drawing.Size(557, 165);
            this.KidsView.TabIndex = 5;
            // 
            // titlebox
            // 
            this.titlebox.BackColor = System.Drawing.Color.Black;
            this.titlebox.Controls.Add(this.label5);
            this.titlebox.Location = new System.Drawing.Point(1, 0);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(835, 52);
            this.titlebox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(306, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "View Booking";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Select Month:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Select Year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Week:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(320, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Viewbooking - Date";
            // 
            // btnback
            // 
            this.btnback.Image = global::A2CourseWork.Properties.Resources.circled_left_2;
            this.btnback.Location = new System.Drawing.Point(96, 498);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(51, 51);
            this.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnback.TabIndex = 4;
            this.btnback.TabStop = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Canceled
            // 
            this.Canceled.AutoSize = true;
            this.Canceled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Canceled.ForeColor = System.Drawing.Color.White;
            this.Canceled.Location = new System.Drawing.Point(7, 260);
            this.Canceled.Name = "Canceled";
            this.Canceled.Size = new System.Drawing.Size(183, 24);
            this.Canceled.TabIndex = 31;
            this.Canceled.Text = "Show ONLY canceled";
            this.Canceled.UseVisualStyleBackColor = true;
            this.Canceled.CheckedChanged += new System.EventHandler(this.Canceled_CheckedChanged);
            // 
            // ByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 568);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.panel3);
            this.Name = "ByDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ByDate";
            this.Load += new System.EventHandler(this.ByDate_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.btnback, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeekView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KidsView)).EndInit();
            this.titlebox.ResumeLayout(false);
            this.titlebox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView KidsView;
        private System.Windows.Forms.Panel titlebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView WeekView;
        private System.Windows.Forms.ComboBox monthscbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox yearcbx;
        private System.Windows.Forms.RadioButton week3rbtn;
        private System.Windows.Forms.RadioButton week5rbtn;
        private System.Windows.Forms.RadioButton week2rbtn;
        private System.Windows.Forms.RadioButton week4rbtn;
        private System.Windows.Forms.RadioButton week1rbtn;
        private System.Windows.Forms.PictureBox btnback;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label weeklbl;
        private System.Windows.Forms.Label revenuelbl;
        private System.Windows.Forms.Label amountlbl;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Canceled;
    }
}
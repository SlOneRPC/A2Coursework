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
            this.btnsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.KidsView = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnweek1 = new System.Windows.Forms.Button();
            this.btnweek2 = new System.Windows.Forms.Button();
            this.btnweek3 = new System.Windows.Forms.Button();
            this.btnweek4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.yearcbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthscbx = new System.Windows.Forms.ComboBox();
            this.WeekView = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KidsView)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeekView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.WeekView);
            this.panel3.Controls.Add(this.monthscbx);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.yearcbx);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnweek4);
            this.panel3.Controls.Add(this.btnweek3);
            this.panel3.Controls.Add(this.btnweek2);
            this.panel3.Controls.Add(this.btnweek1);
            this.panel3.Controls.Add(this.btnsearch);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.KidsView);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(172, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(806, 509);
            this.panel3.TabIndex = 3;
            // 
            // btnsearch
            // 
            this.btnsearch.Enabled = false;
            this.btnsearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(3, 454);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(212, 48);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
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
            // KidsView
            // 
            this.KidsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KidsView.Location = new System.Drawing.Point(241, 58);
            this.KidsView.Name = "KidsView";
            this.KidsView.Size = new System.Drawing.Size(557, 165);
            this.KidsView.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(835, 52);
            this.panel4.TabIndex = 4;
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
            // btnweek1
            // 
            this.btnweek1.BackColor = System.Drawing.Color.Gray;
            this.btnweek1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnweek1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnweek1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnweek1.ForeColor = System.Drawing.Color.White;
            this.btnweek1.Location = new System.Drawing.Point(3, 184);
            this.btnweek1.Name = "btnweek1";
            this.btnweek1.Size = new System.Drawing.Size(212, 48);
            this.btnweek1.TabIndex = 9;
            this.btnweek1.Text = "Week 1";
            this.btnweek1.UseVisualStyleBackColor = false;
            // 
            // btnweek2
            // 
            this.btnweek2.BackColor = System.Drawing.Color.Gray;
            this.btnweek2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnweek2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnweek2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnweek2.ForeColor = System.Drawing.Color.White;
            this.btnweek2.Location = new System.Drawing.Point(3, 238);
            this.btnweek2.Name = "btnweek2";
            this.btnweek2.Size = new System.Drawing.Size(212, 48);
            this.btnweek2.TabIndex = 10;
            this.btnweek2.Text = "Week 2";
            this.btnweek2.UseVisualStyleBackColor = false;
            // 
            // btnweek3
            // 
            this.btnweek3.BackColor = System.Drawing.Color.Gray;
            this.btnweek3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnweek3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnweek3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnweek3.ForeColor = System.Drawing.Color.White;
            this.btnweek3.Location = new System.Drawing.Point(3, 292);
            this.btnweek3.Name = "btnweek3";
            this.btnweek3.Size = new System.Drawing.Size(212, 48);
            this.btnweek3.TabIndex = 11;
            this.btnweek3.Text = "Week 3";
            this.btnweek3.UseVisualStyleBackColor = false;
            // 
            // btnweek4
            // 
            this.btnweek4.BackColor = System.Drawing.Color.Gray;
            this.btnweek4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnweek4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnweek4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnweek4.ForeColor = System.Drawing.Color.White;
            this.btnweek4.Location = new System.Drawing.Point(3, 346);
            this.btnweek4.Name = "btnweek4";
            this.btnweek4.Size = new System.Drawing.Size(212, 48);
            this.btnweek4.TabIndex = 12;
            this.btnweek4.Text = "Week 4";
            this.btnweek4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 48);
            this.button1.TabIndex = 13;
            this.button1.Text = "Week 5";
            this.button1.UseVisualStyleBackColor = false;
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
            // WeekView
            // 
            this.WeekView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeekView.Location = new System.Drawing.Point(241, 229);
            this.WeekView.Name = "WeekView";
            this.WeekView.Size = new System.Drawing.Size(557, 273);
            this.WeekView.TabIndex = 18;
            // 
            // ByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 568);
            this.Controls.Add(this.panel3);
            this.Name = "ByDate";
            this.Text = "ByDate";
            this.Load += new System.EventHandler(this.ByDate_Load);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KidsView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeekView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView KidsView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView WeekView;
        private System.Windows.Forms.ComboBox monthscbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox yearcbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnweek4;
        private System.Windows.Forms.Button btnweek3;
        private System.Windows.Forms.Button btnweek2;
        private System.Windows.Forms.Button btnweek1;
    }
}
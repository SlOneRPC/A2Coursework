namespace A2CourseWork.Gui
{
    partial class CrecheMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrecheMenu));
            this.btnwaiting = new System.Windows.Forms.Button();
            this.btnbookingsview = new System.Windows.Forms.Button();
            this.btnbydate = new System.Windows.Forms.Button();
            this.Timelbl = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnstaff = new System.Windows.Forms.Button();
            this.btnbooking = new System.Windows.Forms.Button();
            this.titlepxb = new System.Windows.Forms.PictureBox();
            this.groupsbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.titlepxb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnwaiting
            // 
            this.btnwaiting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnwaiting.Image = global::A2CourseWork.Properties.Resources.waiting;
            this.btnwaiting.Location = new System.Drawing.Point(700, 182);
            this.btnwaiting.Name = "btnwaiting";
            this.btnwaiting.Size = new System.Drawing.Size(166, 162);
            this.btnwaiting.TabIndex = 14;
            this.btnwaiting.UseVisualStyleBackColor = true;
            this.btnwaiting.Click += new System.EventHandler(this.btnwaiting_Click);
            // 
            // btnbookingsview
            // 
            this.btnbookingsview.BackgroundImage = global::A2CourseWork.Properties.Resources.ViewBooking;
            this.btnbookingsview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbookingsview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbookingsview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbookingsview.Location = new System.Drawing.Point(286, 355);
            this.btnbookingsview.Name = "btnbookingsview";
            this.btnbookingsview.Size = new System.Drawing.Size(166, 162);
            this.btnbookingsview.TabIndex = 15;
            this.btnbookingsview.UseVisualStyleBackColor = true;
            this.btnbookingsview.Click += new System.EventHandler(this.btnbookingsview_Click);
            // 
            // btnbydate
            // 
            this.btnbydate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbydate.Image = ((System.Drawing.Image)(resources.GetObject("btnbydate.Image")));
            this.btnbydate.Location = new System.Drawing.Point(700, 355);
            this.btnbydate.Name = "btnbydate";
            this.btnbydate.Size = new System.Drawing.Size(166, 162);
            this.btnbydate.TabIndex = 16;
            this.btnbydate.UseVisualStyleBackColor = true;
            this.btnbydate.Click += new System.EventHandler(this.btnbydate_Click);
            // 
            // Timelbl
            // 
            this.Timelbl.AutoSize = true;
            this.Timelbl.BackColor = System.Drawing.Color.Transparent;
            this.Timelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelbl.ForeColor = System.Drawing.Color.White;
            this.Timelbl.Location = new System.Drawing.Point(861, 540);
            this.Timelbl.Name = "Timelbl";
            this.Timelbl.Size = new System.Drawing.Size(43, 20);
            this.Timelbl.TabIndex = 17;
            this.Timelbl.Text = "Time";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(757, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Current Time:";
            // 
            // btnstaff
            // 
            this.btnstaff.BackgroundImage = global::A2CourseWork.Properties.Resources.staff;
            this.btnstaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstaff.Location = new System.Drawing.Point(497, 182);
            this.btnstaff.Name = "btnstaff";
            this.btnstaff.Size = new System.Drawing.Size(166, 162);
            this.btnstaff.TabIndex = 13;
            this.btnstaff.UseVisualStyleBackColor = true;
            this.btnstaff.Click += new System.EventHandler(this.btnstaff_Click);
            // 
            // btnbooking
            // 
            this.btnbooking.BackgroundImage = global::A2CourseWork.Properties.Resources.booking;
            this.btnbooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbooking.Location = new System.Drawing.Point(286, 182);
            this.btnbooking.Name = "btnbooking";
            this.btnbooking.Size = new System.Drawing.Size(166, 162);
            this.btnbooking.TabIndex = 12;
            this.btnbooking.UseVisualStyleBackColor = true;
            this.btnbooking.Click += new System.EventHandler(this.btnbooking_Click);
            // 
            // titlepxb
            // 
            this.titlepxb.BackColor = System.Drawing.Color.Red;
            this.titlepxb.Image = global::A2CourseWork.Properties.Resources.creche1;
            this.titlepxb.Location = new System.Drawing.Point(93, 44);
            this.titlepxb.Name = "titlepxb";
            this.titlepxb.Size = new System.Drawing.Size(875, 110);
            this.titlepxb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titlepxb.TabIndex = 2;
            this.titlepxb.TabStop = false;
            // 
            // groupsbtn
            // 
            this.groupsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupsbtn.Location = new System.Drawing.Point(497, 358);
            this.groupsbtn.Name = "groupsbtn";
            this.groupsbtn.Size = new System.Drawing.Size(166, 162);
            this.groupsbtn.TabIndex = 20;
            this.groupsbtn.Text = "Groups placeholder";
            this.groupsbtn.UseVisualStyleBackColor = true;
            this.groupsbtn.Click += new System.EventHandler(this.groupsbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(755, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Current time:";
            // 
            // CrecheMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(980, 568);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupsbtn);
            this.Controls.Add(this.Timelbl);
            this.Controls.Add(this.btnbydate);
            this.Controls.Add(this.btnbookingsview);
            this.Controls.Add(this.btnwaiting);
            this.Controls.Add(this.btnstaff);
            this.Controls.Add(this.btnbooking);
            this.Controls.Add(this.titlepxb);
            this.Name = "CrecheMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrecheMenu";
            this.Load += new System.EventHandler(this.CrecheMenu_Load);
            this.Controls.SetChildIndex(this.titlepxb, 0);
            this.Controls.SetChildIndex(this.btnbooking, 0);
            this.Controls.SetChildIndex(this.btnstaff, 0);
            this.Controls.SetChildIndex(this.btnwaiting, 0);
            this.Controls.SetChildIndex(this.btnbookingsview, 0);
            this.Controls.SetChildIndex(this.btnbydate, 0);
            this.Controls.SetChildIndex(this.Timelbl, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.groupsbtn, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.titlepxb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox titlepxb;
        private System.Windows.Forms.Button btnbooking;
        private System.Windows.Forms.Button btnstaff;
        private System.Windows.Forms.Button btnwaiting;
        private System.Windows.Forms.Button btnbookingsview;
        private System.Windows.Forms.Button btnbydate;
        private System.Windows.Forms.Label Timelbl;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button groupsbtn;
        private System.Windows.Forms.Label label5;
    }
}
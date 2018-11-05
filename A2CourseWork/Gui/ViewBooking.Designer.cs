namespace A2CourseWork.Gui
{
    partial class ViewBooking
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Homelbl = new System.Windows.Forms.Label();
            this.homepbx = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minbtn = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.PictureBox();
            this.titlelbl = new System.Windows.Forms.Label();
            this.booking1pnl = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.kidslist = new System.Windows.Forms.ListBox();
            this.btnview = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homepbx)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            this.booking1pnl.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.Homelbl);
            this.panel2.Controls.Add(this.homepbx);
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 569);
            this.panel2.TabIndex = 7;
            // 
            // Homelbl
            // 
            this.Homelbl.AutoSize = true;
            this.Homelbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homelbl.ForeColor = System.Drawing.Color.White;
            this.Homelbl.Location = new System.Drawing.Point(19, 80);
            this.Homelbl.Name = "Homelbl";
            this.Homelbl.Size = new System.Drawing.Size(51, 19);
            this.Homelbl.TabIndex = 1;
            this.Homelbl.Text = "Home";
            // 
            // homepbx
            // 
            this.homepbx.Image = global::A2CourseWork.Properties.Resources.homebtn;
            this.homepbx.Location = new System.Drawing.Point(7, 3);
            this.homepbx.Name = "homepbx";
            this.homepbx.Size = new System.Drawing.Size(76, 72);
            this.homepbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homepbx.TabIndex = 0;
            this.homepbx.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.minbtn);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.titlelbl);
            this.panel1.Location = new System.Drawing.Point(87, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 41);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // minbtn
            // 
            this.minbtn.Image = global::A2CourseWork.Properties.Resources.minbutton;
            this.minbtn.Location = new System.Drawing.Point(805, 0);
            this.minbtn.Name = "minbtn";
            this.minbtn.Size = new System.Drawing.Size(41, 38);
            this.minbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minbtn.TabIndex = 3;
            this.minbtn.TabStop = false;
            this.minbtn.Click += new System.EventHandler(this.minbtn_Click);
            // 
            // btnexit
            // 
            this.btnexit.Image = global::A2CourseWork.Properties.Resources.exitbutton;
            this.btnexit.Location = new System.Drawing.Point(852, 0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(41, 38);
            this.btnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnexit.TabIndex = 2;
            this.btnexit.TabStop = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.BackColor = System.Drawing.Color.Transparent;
            this.titlelbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.Location = new System.Drawing.Point(7, 9);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(407, 25);
            this.titlelbl.TabIndex = 1;
            this.titlelbl.Text = "Woodside Community - Creche - Bookings";
            // 
            // booking1pnl
            // 
            this.booking1pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.booking1pnl.Controls.Add(this.btnview);
            this.booking1pnl.Controls.Add(this.kidslist);
            this.booking1pnl.Controls.Add(this.panel4);
            this.booking1pnl.Location = new System.Drawing.Point(404, 62);
            this.booking1pnl.Name = "booking1pnl";
            this.booking1pnl.Size = new System.Drawing.Size(355, 459);
            this.booking1pnl.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.label13);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(352, 64);
            this.panel4.TabIndex = 10;
            // 
            // kidslist
            // 
            this.kidslist.BackColor = System.Drawing.Color.Gray;
            this.kidslist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kidslist.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kidslist.ForeColor = System.Drawing.Color.White;
            this.kidslist.FormattingEnabled = true;
            this.kidslist.ItemHeight = 26;
            this.kidslist.Location = new System.Drawing.Point(25, 80);
            this.kidslist.Name = "kidslist";
            this.kidslist.Size = new System.Drawing.Size(315, 288);
            this.kidslist.TabIndex = 11;
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.Gray;
            this.btnview.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.Location = new System.Drawing.Point(25, 374);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(315, 51);
            this.btnview.TabIndex = 14;
            this.btnview.Text = "View Booking";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(129, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Bookings";
            // 
            // btnback
            // 
            this.btnback.Image = global::A2CourseWork.Properties.Resources.circled_left_2;
            this.btnback.Location = new System.Drawing.Point(99, 505);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(51, 51);
            this.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnback.TabIndex = 15;
            this.btnback.TabStop = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(271, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(611, 470);
            this.panel3.TabIndex = 16;
            this.panel3.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(3, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(619, 64);
            this.panel5.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(246, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "View booking";
            // 
            // ViewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(980, 568);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.booking1pnl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBooking";
            this.Text = "ViewBooking";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homepbx)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            this.booking1pnl.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Homelbl;
        private System.Windows.Forms.PictureBox homepbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minbtn;
        private System.Windows.Forms.PictureBox btnexit;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Panel booking1pnl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox kidslist;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox btnback;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
    }
}
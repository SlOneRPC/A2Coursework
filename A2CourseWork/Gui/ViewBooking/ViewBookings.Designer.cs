namespace A2CourseWork.Gui
{
    partial class ViewBookings
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
            this.bookingpnl1 = new System.Windows.Forms.Panel();
            this.btncheck = new System.Windows.Forms.Button();
            this.kidslistbox = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bookingpnl2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.bookinglistbox = new System.Windows.Forms.ListBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.agelbl = new System.Windows.Forms.Label();
            this.doblbl = new System.Windows.Forms.Label();
            this.snamelbl = new System.Windows.Forms.Label();
            this.fnamelbl = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.discountlbl = new System.Windows.Forms.Label();
            this.agegrouplbl = new System.Windows.Forms.Label();
            this.totalpricelbl = new System.Windows.Forms.Label();
            this.daysbookedlbl = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.PictureBox();
            this.btnreport = new System.Windows.Forms.Button();
            this.bookingpnl1.SuspendLayout();
            this.bookingpnl2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingpnl1
            // 
            this.bookingpnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookingpnl1.Controls.Add(this.btncheck);
            this.bookingpnl1.Controls.Add(this.kidslistbox);
            this.bookingpnl1.Controls.Add(this.panel4);
            this.bookingpnl1.Location = new System.Drawing.Point(393, 80);
            this.bookingpnl1.Name = "bookingpnl1";
            this.bookingpnl1.Size = new System.Drawing.Size(309, 440);
            this.bookingpnl1.TabIndex = 11;
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.Color.Gray;
            this.btncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.Location = new System.Drawing.Point(15, 372);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(280, 50);
            this.btncheck.TabIndex = 2;
            this.btncheck.Text = "View Booking";
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // kidslistbox
            // 
            this.kidslistbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kidslistbox.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kidslistbox.FormattingEnabled = true;
            this.kidslistbox.ItemHeight = 23;
            this.kidslistbox.Location = new System.Drawing.Point(15, 65);
            this.kidslistbox.Name = "kidslistbox";
            this.kidslistbox.Size = new System.Drawing.Size(280, 301);
            this.kidslistbox.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 59);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bookings";
            // 
            // bookingpnl2
            // 
            this.bookingpnl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookingpnl2.Controls.Add(this.panel7);
            this.bookingpnl2.Controls.Add(this.panel6);
            this.bookingpnl2.Controls.Add(this.panel5);
            this.bookingpnl2.Location = new System.Drawing.Point(253, 52);
            this.bookingpnl2.Name = "bookingpnl2";
            this.bookingpnl2.Size = new System.Drawing.Size(601, 467);
            this.bookingpnl2.TabIndex = 12;
            this.bookingpnl2.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btndelete);
            this.panel7.Controls.Add(this.btnadd);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.bookinglistbox);
            this.panel7.Location = new System.Drawing.Point(308, 60);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(290, 401);
            this.panel7.TabIndex = 2;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Gray;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(146, 344);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(113, 31);
            this.btndelete.TabIndex = 16;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Gray;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(19, 344);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(113, 31);
            this.btnadd.TabIndex = 15;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Weeks booked:";
            // 
            // bookinglistbox
            // 
            this.bookinglistbox.BackColor = System.Drawing.Color.Gray;
            this.bookinglistbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookinglistbox.Font = new System.Drawing.Font("Lucida Sans Unicode", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookinglistbox.ForeColor = System.Drawing.Color.White;
            this.bookinglistbox.FormattingEnabled = true;
            this.bookinglistbox.ItemHeight = 21;
            this.bookinglistbox.Location = new System.Drawing.Point(19, 49);
            this.bookinglistbox.Name = "bookinglistbox";
            this.bookinglistbox.Size = new System.Drawing.Size(240, 275);
            this.bookinglistbox.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Location = new System.Drawing.Point(3, 60);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(299, 404);
            this.panel6.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.agelbl);
            this.panel9.Controls.Add(this.doblbl);
            this.panel9.Controls.Add(this.snamelbl);
            this.panel9.Controls.Add(this.fnamelbl);
            this.panel9.Location = new System.Drawing.Point(11, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(283, 168);
            this.panel9.TabIndex = 6;
            // 
            // agelbl
            // 
            this.agelbl.AutoSize = true;
            this.agelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agelbl.ForeColor = System.Drawing.Color.White;
            this.agelbl.Location = new System.Drawing.Point(2, 126);
            this.agelbl.Name = "agelbl";
            this.agelbl.Size = new System.Drawing.Size(42, 20);
            this.agelbl.TabIndex = 4;
            this.agelbl.Text = "Age:";
            // 
            // doblbl
            // 
            this.doblbl.AutoSize = true;
            this.doblbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doblbl.ForeColor = System.Drawing.Color.White;
            this.doblbl.Location = new System.Drawing.Point(3, 96);
            this.doblbl.Name = "doblbl";
            this.doblbl.Size = new System.Drawing.Size(48, 20);
            this.doblbl.TabIndex = 3;
            this.doblbl.Text = "DOB:";
            // 
            // snamelbl
            // 
            this.snamelbl.AutoSize = true;
            this.snamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snamelbl.ForeColor = System.Drawing.Color.White;
            this.snamelbl.Location = new System.Drawing.Point(3, 66);
            this.snamelbl.Name = "snamelbl";
            this.snamelbl.Size = new System.Drawing.Size(78, 20);
            this.snamelbl.TabIndex = 2;
            this.snamelbl.Text = "Surname:";
            // 
            // fnamelbl
            // 
            this.fnamelbl.AutoSize = true;
            this.fnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnamelbl.ForeColor = System.Drawing.Color.White;
            this.fnamelbl.Location = new System.Drawing.Point(2, 36);
            this.fnamelbl.Name = "fnamelbl";
            this.fnamelbl.Size = new System.Drawing.Size(86, 20);
            this.fnamelbl.TabIndex = 1;
            this.fnamelbl.Text = "Forename:";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.btnreport);
            this.panel8.Controls.Add(this.discountlbl);
            this.panel8.Controls.Add(this.agegrouplbl);
            this.panel8.Controls.Add(this.totalpricelbl);
            this.panel8.Controls.Add(this.daysbookedlbl);
            this.panel8.Location = new System.Drawing.Point(11, 179);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(283, 216);
            this.panel8.TabIndex = 5;
            // 
            // discountlbl
            // 
            this.discountlbl.AutoSize = true;
            this.discountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountlbl.ForeColor = System.Drawing.Color.White;
            this.discountlbl.Location = new System.Drawing.Point(7, 80);
            this.discountlbl.Name = "discountlbl";
            this.discountlbl.Size = new System.Drawing.Size(133, 20);
            this.discountlbl.TabIndex = 7;
            this.discountlbl.Text = "Discount Applied:";
            // 
            // agegrouplbl
            // 
            this.agegrouplbl.AutoSize = true;
            this.agegrouplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agegrouplbl.ForeColor = System.Drawing.Color.White;
            this.agegrouplbl.Location = new System.Drawing.Point(7, 30);
            this.agegrouplbl.Name = "agegrouplbl";
            this.agegrouplbl.Size = new System.Drawing.Size(91, 20);
            this.agegrouplbl.TabIndex = 6;
            this.agegrouplbl.Text = "Age Group:";
            // 
            // totalpricelbl
            // 
            this.totalpricelbl.AutoSize = true;
            this.totalpricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpricelbl.ForeColor = System.Drawing.Color.White;
            this.totalpricelbl.Location = new System.Drawing.Point(7, 105);
            this.totalpricelbl.Name = "totalpricelbl";
            this.totalpricelbl.Size = new System.Drawing.Size(87, 20);
            this.totalpricelbl.TabIndex = 4;
            this.totalpricelbl.Text = "Total Price:";
            // 
            // daysbookedlbl
            // 
            this.daysbookedlbl.AutoSize = true;
            this.daysbookedlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysbookedlbl.ForeColor = System.Drawing.Color.White;
            this.daysbookedlbl.Location = new System.Drawing.Point(7, 55);
            this.daysbookedlbl.Name = "daysbookedlbl";
            this.daysbookedlbl.Size = new System.Drawing.Size(108, 20);
            this.daysbookedlbl.TabIndex = 3;
            this.daysbookedlbl.Text = "Days Booked:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(3, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(597, 57);
            this.panel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Child Details:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "More information:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(255, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "View Kid";
            // 
            // btnback
            // 
            this.btnback.Image = global::A2CourseWork.Properties.Resources.circled_left_2;
            this.btnback.Location = new System.Drawing.Point(110, 505);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(51, 51);
            this.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnback.TabIndex = 4;
            this.btnback.TabStop = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.Gray;
            this.btnreport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.Location = new System.Drawing.Point(6, 164);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(171, 42);
            this.btnreport.TabIndex = 17;
            this.btnreport.Text = "Generate report";
            this.btnreport.UseVisualStyleBackColor = false;
            // 
            // ViewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(980, 568);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.bookingpnl2);
            this.Controls.Add(this.bookingpnl1);
            this.Name = "ViewBookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBookings";
            this.Load += new System.EventHandler(this.ViewBookings_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.bookingpnl1, 0);
            this.Controls.SetChildIndex(this.bookingpnl2, 0);
            this.Controls.SetChildIndex(this.btnback, 0);
            this.bookingpnl1.ResumeLayout(false);
            this.bookingpnl2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel bookingpnl1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.ListBox kidslistbox;
        private System.Windows.Forms.PictureBox btnback;
        private System.Windows.Forms.Panel bookingpnl2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label totalpricelbl;
        private System.Windows.Forms.Label daysbookedlbl;
        private System.Windows.Forms.Label snamelbl;
        private System.Windows.Forms.Label fnamelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox bookinglistbox;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label doblbl;
        private System.Windows.Forms.Label agegrouplbl;
        private System.Windows.Forms.Label agelbl;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label discountlbl;
        private System.Windows.Forms.Button btnreport;
    }
}
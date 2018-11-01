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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Homelbl = new System.Windows.Forms.Label();
            this.homepbx = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minbtn = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.PictureBox();
            this.titlelbl = new System.Windows.Forms.Label();
            this.Timemainlbl = new System.Windows.Forms.PictureBox();
            this.btnbooking = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Timelbl = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homepbx)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timemainlbl)).BeginInit();
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
            this.panel2.TabIndex = 5;
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
            this.homepbx.Click += new System.EventHandler(this.homepbx_Click);
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
            this.panel1.TabIndex = 6;
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
            this.titlelbl.Size = new System.Drawing.Size(302, 25);
            this.titlelbl.TabIndex = 1;
            this.titlelbl.Text = "Woodside Community - Creche";
            // 
            // Timemainlbl
            // 
            this.Timemainlbl.BackColor = System.Drawing.Color.Red;
            this.Timemainlbl.Image = global::A2CourseWork.Properties.Resources.creche1;
            this.Timemainlbl.Location = new System.Drawing.Point(93, 44);
            this.Timemainlbl.Name = "Timemainlbl";
            this.Timemainlbl.Size = new System.Drawing.Size(875, 110);
            this.Timemainlbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Timemainlbl.TabIndex = 2;
            this.Timemainlbl.TabStop = false;
            // 
            // btnbooking
            // 
            this.btnbooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbooking.Location = new System.Drawing.Point(286, 182);
            this.btnbooking.Name = "btnbooking";
            this.btnbooking.Size = new System.Drawing.Size(166, 162);
            this.btnbooking.TabIndex = 12;
            this.btnbooking.UseVisualStyleBackColor = true;
            this.btnbooking.Click += new System.EventHandler(this.btnbooking_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(497, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 162);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(700, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 162);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(385, 359);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 162);
            this.button5.TabIndex = 15;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(612, 359);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 162);
            this.button6.TabIndex = 16;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Timelbl
            // 
            this.Timelbl.AutoSize = true;
            this.Timelbl.BackColor = System.Drawing.Color.Transparent;
            this.Timelbl.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelbl.ForeColor = System.Drawing.Color.White;
            this.Timelbl.Location = new System.Drawing.Point(861, 540);
            this.Timelbl.Name = "Timelbl";
            this.Timelbl.Size = new System.Drawing.Size(46, 19);
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
            this.label1.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(757, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Current Time:";
            // 
            // CrecheMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(980, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Timelbl);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnbooking);
            this.Controls.Add(this.Timemainlbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrecheMenu";
            this.Text = "CrecheMenu";
            this.Load += new System.EventHandler(this.CrecheMenu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homepbx)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timemainlbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Homelbl;
        private System.Windows.Forms.PictureBox homepbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minbtn;
        private System.Windows.Forms.PictureBox btnexit;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.PictureBox Timemainlbl;
        private System.Windows.Forms.Button btnbooking;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label Timelbl;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label1;
    }
}
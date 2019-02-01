namespace A2CourseWork.Gui
{
    partial class AddEditStaff
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stafflist = new System.Windows.Forms.ListBox();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupcbx = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.messagelbl = new System.Windows.Forms.Label();
            this.error5 = new System.Windows.Forms.Label();
            this.error4 = new System.Windows.Forms.Label();
            this.error3 = new System.Windows.Forms.Label();
            this.error2 = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Postcodetxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Addresstxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TeleNotxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Surnametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fnametxt = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Timelbl = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homepbx)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).BeginInit();
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
            this.titlelbl.Size = new System.Drawing.Size(368, 25);
            this.titlelbl.TabIndex = 1;
            this.titlelbl.Text = "Woodside Community - Creche - Staff";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.btnremove);
            this.panel3.Controls.Add(this.btnadd);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.stafflist);
            this.panel3.Controls.Add(this.searchtxt);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(181, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 467);
            this.panel3.TabIndex = 9;
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.Gray;
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(184, 415);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(113, 31);
            this.btnremove.TabIndex = 15;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Gray;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(16, 415);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(113, 31);
            this.btnadd.TabIndex = 14;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Staff Member";
            // 
            // stafflist
            // 
            this.stafflist.BackColor = System.Drawing.Color.Silver;
            this.stafflist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stafflist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stafflist.FormattingEnabled = true;
            this.stafflist.ItemHeight = 20;
            this.stafflist.Location = new System.Drawing.Point(16, 143);
            this.stafflist.Name = "stafflist";
            this.stafflist.ScrollAlwaysVisible = true;
            this.stafflist.Size = new System.Drawing.Size(281, 262);
            this.stafflist.TabIndex = 2;
            this.stafflist.SelectedIndexChanged += new System.EventHandler(this.stafflist_SelectedIndexChanged);
            // 
            // searchtxt
            // 
            this.searchtxt.BackColor = System.Drawing.Color.Silver;
            this.searchtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxt.Location = new System.Drawing.Point(18, 96);
            this.searchtxt.Multiline = true;
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(281, 38);
            this.searchtxt.TabIndex = 1;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.label13);
            this.panel4.Location = new System.Drawing.Point(2, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(671, 58);
            this.panel4.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(124, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "Staff";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.groupcbx);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.btncancel);
            this.panel5.Controls.Add(this.messagelbl);
            this.panel5.Controls.Add(this.error5);
            this.panel5.Controls.Add(this.error4);
            this.panel5.Controls.Add(this.error3);
            this.panel5.Controls.Add(this.error2);
            this.panel5.Controls.Add(this.error1);
            this.panel5.Controls.Add(this.btnupdate);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.Postcodetxt);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.Addresstxt);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.TeleNotxt);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.Surnametxt);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.fnametxt);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(561, 47);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(326, 486);
            this.panel5.TabIndex = 10;
            // 
            // groupcbx
            // 
            this.groupcbx.BackColor = System.Drawing.Color.Silver;
            this.groupcbx.Enabled = false;
            this.groupcbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupcbx.FormattingEnabled = true;
            this.groupcbx.Location = new System.Drawing.Point(90, 383);
            this.groupcbx.Name = "groupcbx";
            this.groupcbx.Size = new System.Drawing.Size(202, 28);
            this.groupcbx.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(26, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "Group";
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Gray;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(191, 424);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(113, 31);
            this.btncancel.TabIndex = 26;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Visible = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // messagelbl
            // 
            this.messagelbl.AutoSize = true;
            this.messagelbl.BackColor = System.Drawing.Color.Transparent;
            this.messagelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagelbl.ForeColor = System.Drawing.Color.Lime;
            this.messagelbl.Location = new System.Drawing.Point(26, 458);
            this.messagelbl.Name = "messagelbl";
            this.messagelbl.Size = new System.Drawing.Size(66, 18);
            this.messagelbl.TabIndex = 25;
            this.messagelbl.Text = "Success";
            this.messagelbl.Visible = false;
            // 
            // error5
            // 
            this.error5.AutoSize = true;
            this.error5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error5.ForeColor = System.Drawing.Color.Red;
            this.error5.Location = new System.Drawing.Point(90, 316);
            this.error5.Name = "error5";
            this.error5.Size = new System.Drawing.Size(17, 24);
            this.error5.TabIndex = 24;
            this.error5.Text = "*";
            this.error5.Visible = false;
            // 
            // error4
            // 
            this.error4.AutoSize = true;
            this.error4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error4.ForeColor = System.Drawing.Color.Red;
            this.error4.Location = new System.Drawing.Point(128, 253);
            this.error4.Name = "error4";
            this.error4.Size = new System.Drawing.Size(17, 24);
            this.error4.TabIndex = 23;
            this.error4.Text = "*";
            this.error4.Visible = false;
            // 
            // error3
            // 
            this.error3.AutoSize = true;
            this.error3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error3.ForeColor = System.Drawing.Color.Red;
            this.error3.Location = new System.Drawing.Point(161, 182);
            this.error3.Name = "error3";
            this.error3.Size = new System.Drawing.Size(17, 24);
            this.error3.TabIndex = 22;
            this.error3.Text = "*";
            this.error3.Visible = false;
            // 
            // error2
            // 
            this.error2.AutoSize = true;
            this.error2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error2.ForeColor = System.Drawing.Color.Red;
            this.error2.Location = new System.Drawing.Point(94, 119);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(17, 24);
            this.error2.TabIndex = 21;
            this.error2.Text = "*";
            this.error2.Visible = false;
            // 
            // error1
            // 
            this.error1.AutoSize = true;
            this.error1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error1.ForeColor = System.Drawing.Color.Red;
            this.error1.Location = new System.Drawing.Point(102, 57);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(17, 24);
            this.error1.TabIndex = 20;
            this.error1.Text = "*";
            this.error1.Visible = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Gray;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(23, 424);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(113, 31);
            this.btnupdate.TabIndex = 5;
            this.btnupdate.Text = "Save";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Postcode";
            // 
            // Postcodetxt
            // 
            this.Postcodetxt.BackColor = System.Drawing.Color.Silver;
            this.Postcodetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Postcodetxt.Enabled = false;
            this.Postcodetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Postcodetxt.Location = new System.Drawing.Point(23, 340);
            this.Postcodetxt.Multiline = true;
            this.Postcodetxt.Name = "Postcodetxt";
            this.Postcodetxt.Size = new System.Drawing.Size(281, 38);
            this.Postcodetxt.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Home Address";
            // 
            // Addresstxt
            // 
            this.Addresstxt.BackColor = System.Drawing.Color.Silver;
            this.Addresstxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Addresstxt.Enabled = false;
            this.Addresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresstxt.Location = new System.Drawing.Point(23, 279);
            this.Addresstxt.Multiline = true;
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(281, 38);
            this.Addresstxt.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telephone Number";
            // 
            // TeleNotxt
            // 
            this.TeleNotxt.BackColor = System.Drawing.Color.Silver;
            this.TeleNotxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeleNotxt.Enabled = false;
            this.TeleNotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeleNotxt.Location = new System.Drawing.Point(23, 209);
            this.TeleNotxt.Multiline = true;
            this.TeleNotxt.Name = "TeleNotxt";
            this.TeleNotxt.Size = new System.Drawing.Size(281, 38);
            this.TeleNotxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Surname";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Surnametxt
            // 
            this.Surnametxt.BackColor = System.Drawing.Color.Silver;
            this.Surnametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Surnametxt.Enabled = false;
            this.Surnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surnametxt.Location = new System.Drawing.Point(23, 143);
            this.Surnametxt.Multiline = true;
            this.Surnametxt.Name = "Surnametxt";
            this.Surnametxt.Size = new System.Drawing.Size(281, 38);
            this.Surnametxt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Forename";
            // 
            // fnametxt
            // 
            this.fnametxt.BackColor = System.Drawing.Color.Silver;
            this.fnametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnametxt.Enabled = false;
            this.fnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnametxt.Location = new System.Drawing.Point(23, 82);
            this.fnametxt.Multiline = true;
            this.fnametxt.Name = "fnametxt";
            this.fnametxt.Size = new System.Drawing.Size(281, 38);
            this.fnametxt.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(2, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(671, 58);
            this.panel6.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(87, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Add/Edit Staff";
            // 
            // btnback
            // 
            this.btnback.Image = global::A2CourseWork.Properties.Resources.circled_left_2;
            this.btnback.Location = new System.Drawing.Point(99, 505);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(51, 51);
            this.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnback.TabIndex = 11;
            this.btnback.TabStop = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(790, 545);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Current Time:";
            // 
            // Timelbl
            // 
            this.Timelbl.AutoSize = true;
            this.Timelbl.BackColor = System.Drawing.Color.Transparent;
            this.Timelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelbl.ForeColor = System.Drawing.Color.White;
            this.Timelbl.Location = new System.Drawing.Point(894, 545);
            this.Timelbl.Name = "Timelbl";
            this.Timelbl.Size = new System.Drawing.Size(43, 20);
            this.Timelbl.TabIndex = 19;
            this.Timelbl.Text = "Time";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // AddEditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(980, 568);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Timelbl);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEditStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditStaff";
            this.Load += new System.EventHandler(this.AddEditStaff_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homepbx)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).EndInit();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox stafflist;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Addresstxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TeleNotxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Surnametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fnametxt;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Postcodetxt;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label error5;
        private System.Windows.Forms.Label error4;
        private System.Windows.Forms.Label error3;
        private System.Windows.Forms.Label error2;
        private System.Windows.Forms.Label error1;
        private System.Windows.Forms.Label messagelbl;
        private System.Windows.Forms.PictureBox btnback;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Timelbl;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.ComboBox groupcbx;
        private System.Windows.Forms.Label label10;
    }
}
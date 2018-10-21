namespace A2CourseWork.Gui
{
    partial class Default
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.titlelbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.minbtn = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.Homelbl);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 569);
            this.panel2.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.minbtn);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.titlelbl);
            this.panel1.Location = new System.Drawing.Point(89, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 41);
            this.panel1.TabIndex = 2;
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.BackColor = System.Drawing.Color.Transparent;
            this.titlelbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.Location = new System.Drawing.Point(7, 9);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(121, 25);
            this.titlelbl.TabIndex = 1;
            this.titlelbl.Text = "FormName ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::A2CourseWork.Properties.Resources.homebtn;
            this.pictureBox2.Location = new System.Drawing.Point(7, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
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
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(980, 568);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Default";
            this.Text = "Default";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Homelbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minbtn;
        private System.Windows.Forms.PictureBox btnexit;
        private System.Windows.Forms.Label titlelbl;
    }
}
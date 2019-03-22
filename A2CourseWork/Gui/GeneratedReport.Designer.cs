namespace A2CourseWork.Gui
{
    partial class GeneratedReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.crecheData = new A2CourseWork.CrecheData();
            this.crecheDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new A2CourseWork.CrecheDataTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.crecheData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crecheDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable1BindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "A2CourseWork.CrecheReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(66, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(367, 268);
            this.reportViewer1.TabIndex = 0;
            // 
            // crecheData
            // 
            this.crecheData.DataSetName = "CrecheData";
            this.crecheData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crecheDataBindingSource
            // 
            this.crecheDataBindingSource.DataSource = this.crecheData;
            this.crecheDataBindingSource.Position = 0;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.crecheData;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.crecheData;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // GeneratedReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 344);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GeneratedReport";
            this.Text = "GeneratedReport";
            this.Load += new System.EventHandler(this.GeneratedReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crecheData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crecheDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource crecheDataBindingSource;
        private CrecheData crecheData;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private CrecheDataTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    }
}
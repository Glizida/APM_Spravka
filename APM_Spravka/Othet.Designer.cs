namespace APM_Spravka
{
    partial class Othet
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nzzGtRxVKLDataSet = new APM_Spravka.nzzGtRxVKLDataSet();
            this.Rasdel2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Rasdel2TableAdapter = new APM_Spravka.nzzGtRxVKLDataSetTableAdapters.Rasdel2TableAdapter();
            this.DoxodTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DoxodTableTableAdapter = new APM_Spravka.nzzGtRxVKLDataSetTableAdapters.DoxodTableTableAdapter();
            this.DoxodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DoxodTableAdapter = new APM_Spravka.nzzGtRxVKLDataSetTableAdapters.DoxodTableAdapter();
            this.VznosiTabl1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VznosiTabl1TableAdapter = new APM_Spravka.nzzGtRxVKLDataSetTableAdapters.VznosiTabl1TableAdapter();
            this.VznosiTabl2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VznosiTabl2TableAdapter = new APM_Spravka.nzzGtRxVKLDataSetTableAdapters.VznosiTabl2TableAdapter();
            this.VznosiTabl3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VznosiTabl3TableAdapter = new APM_Spravka.nzzGtRxVKLDataSetTableAdapters.VznosiTabl3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nzzGtRxVKLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rasdel2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoxodTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoxodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VznosiTabl1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VznosiTabl2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VznosiTabl3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoScroll = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Rasdel2BindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.DoxodTableBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.DoxodBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.VznosiTabl1BindingSource;
            reportDataSource5.Name = "DataSet5";
            reportDataSource5.Value = this.VznosiTabl2BindingSource;
            reportDataSource6.Name = "DataSet6";
            reportDataSource6.Value = this.VznosiTabl3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "APM_Spravka.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // nzzGtRxVKLDataSet
            // 
            this.nzzGtRxVKLDataSet.DataSetName = "nzzGtRxVKLDataSet";
            this.nzzGtRxVKLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Rasdel2BindingSource
            // 
            this.Rasdel2BindingSource.DataMember = "Rasdel2";
            this.Rasdel2BindingSource.DataSource = this.nzzGtRxVKLDataSet;
            // 
            // Rasdel2TableAdapter
            // 
            this.Rasdel2TableAdapter.ClearBeforeFill = true;
            // 
            // DoxodTableBindingSource
            // 
            this.DoxodTableBindingSource.DataMember = "DoxodTable";
            this.DoxodTableBindingSource.DataSource = this.nzzGtRxVKLDataSet;
            // 
            // DoxodTableTableAdapter
            // 
            this.DoxodTableTableAdapter.ClearBeforeFill = true;
            // 
            // DoxodBindingSource
            // 
            this.DoxodBindingSource.DataMember = "Doxod";
            this.DoxodBindingSource.DataSource = this.nzzGtRxVKLDataSet;
            // 
            // DoxodTableAdapter
            // 
            this.DoxodTableAdapter.ClearBeforeFill = true;
            // 
            // VznosiTabl1BindingSource
            // 
            this.VznosiTabl1BindingSource.DataMember = "VznosiTabl1";
            this.VznosiTabl1BindingSource.DataSource = this.nzzGtRxVKLDataSet;
            // 
            // VznosiTabl1TableAdapter
            // 
            this.VznosiTabl1TableAdapter.ClearBeforeFill = true;
            // 
            // VznosiTabl2BindingSource
            // 
            this.VznosiTabl2BindingSource.DataMember = "VznosiTabl2";
            this.VznosiTabl2BindingSource.DataSource = this.nzzGtRxVKLDataSet;
            // 
            // VznosiTabl2TableAdapter
            // 
            this.VznosiTabl2TableAdapter.ClearBeforeFill = true;
            // 
            // VznosiTabl3BindingSource
            // 
            this.VznosiTabl3BindingSource.DataMember = "VznosiTabl3";
            this.VznosiTabl3BindingSource.DataSource = this.nzzGtRxVKLDataSet;
            // 
            // VznosiTabl3TableAdapter
            // 
            this.VznosiTabl3TableAdapter.ClearBeforeFill = true;
            // 
            // Othet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Othet";
            this.Text = "Othet";
            this.Load += new System.EventHandler(this.Othet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nzzGtRxVKLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rasdel2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoxodTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoxodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VznosiTabl1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VznosiTabl2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VznosiTabl3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Rasdel2BindingSource;
        private nzzGtRxVKLDataSet nzzGtRxVKLDataSet;
        private System.Windows.Forms.BindingSource DoxodTableBindingSource;
        private System.Windows.Forms.BindingSource DoxodBindingSource;
        private System.Windows.Forms.BindingSource VznosiTabl1BindingSource;
        private System.Windows.Forms.BindingSource VznosiTabl2BindingSource;
        private System.Windows.Forms.BindingSource VznosiTabl3BindingSource;
        private nzzGtRxVKLDataSetTableAdapters.Rasdel2TableAdapter Rasdel2TableAdapter;
        private nzzGtRxVKLDataSetTableAdapters.DoxodTableTableAdapter DoxodTableTableAdapter;
        private nzzGtRxVKLDataSetTableAdapters.DoxodTableAdapter DoxodTableAdapter;
        private nzzGtRxVKLDataSetTableAdapters.VznosiTabl1TableAdapter VznosiTabl1TableAdapter;
        private nzzGtRxVKLDataSetTableAdapters.VznosiTabl2TableAdapter VznosiTabl2TableAdapter;
        private nzzGtRxVKLDataSetTableAdapters.VznosiTabl3TableAdapter VznosiTabl3TableAdapter;
    }
}
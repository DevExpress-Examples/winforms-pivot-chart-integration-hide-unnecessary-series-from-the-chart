namespace WindowsApplication53
{
    partial class Form1
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.fiedName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldValue = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAverage = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.DataMember = "Data";
            this.pivotGridControl1.DataSource = this.dataSet1;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fiedName,
            this.fieldDate,
            this.fieldValue,
            this.fieldCount,
            this.fieldAverage,
            this.fieldDate1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText;
            this.pivotGridControl1.OptionsChartDataSource.ProvideDataByColumns = false;
            this.pivotGridControl1.OptionsChartDataSource.SelectionOnly = false;
            this.pivotGridControl1.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.RowArea;
            this.pivotGridControl1.OptionsDataField.AreaIndex = 1;
            this.pivotGridControl1.Size = new System.Drawing.Size(336, 292);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.CustomChartDataSourceRows += new DevExpress.XtraPivotGrid.PivotCustomChartDataSourceRowsEventHandler(this.pivotGridControl1_CustomChartDataSourceRows);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3});
            this.dataTable1.TableName = "Data";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Name";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Date";
            this.dataColumn2.DataType = typeof(System.DateTime);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Value";
            this.dataColumn3.DataType = typeof(decimal);
            // 
            // fiedName
            // 
            this.fiedName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fiedName.AreaIndex = 0;
            this.fiedName.Caption = "Products";
            this.fiedName.FieldName = "Name";
            this.fiedName.Name = "fiedName";
            // 
            // fieldDate
            // 
            this.fieldDate.AreaIndex = 0;
            this.fieldDate.Caption = "Year";
            this.fieldDate.FieldName = "Date";
            this.fieldDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldDate.Name = "fieldDate";
            this.fieldDate.UnboundFieldName = "fieldDate";
            this.fieldDate.Visible = false;
            // 
            // fieldValue
            // 
            this.fieldValue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldValue.AreaIndex = 0;
            this.fieldValue.Caption = "Sales";
            this.fieldValue.FieldName = "Value";
            this.fieldValue.Name = "fieldValue";
            // 
            // fieldCount
            // 
            this.fieldCount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCount.AreaIndex = 2;
            this.fieldCount.Caption = "Quantitiy";
            this.fieldCount.FieldName = "Value";
            this.fieldCount.Name = "fieldCount";
            this.fieldCount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // fieldAverage
            // 
            this.fieldAverage.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldAverage.AreaIndex = 1;
            this.fieldAverage.Caption = "Average";
            this.fieldAverage.FieldName = "Value";
            this.fieldAverage.Name = "fieldAverage";
            this.fieldAverage.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            // 
            // fieldDate1
            // 
            this.fieldDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldDate1.AreaIndex = 0;
            this.fieldDate1.Caption = "Date";
            this.fieldDate1.FieldName = "Date";
            this.fieldDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date;
            this.fieldDate1.Name = "fieldDate1";
            this.fieldDate1.UnboundFieldName = "fieldDate1";
            this.fieldDate1.ValueFormat.FormatString = "dd MMM";
            this.fieldDate1.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pivotGridControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chartControl1);
            this.splitContainer1.Size = new System.Drawing.Size(796, 292);
            this.splitContainer1.SplitterDistance = 336;
            this.splitContainer1.TabIndex = 1;
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.pivotGridControl1;
            xyDiagram1.AxisX.Label.Staggered = true;
            xyDiagram1.AxisX.Title.Text = "Date";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Title.Text = "Sales Average Quantitiy";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartControl1.Legend.MaxVerticalPercentage = 30D;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Series";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chartControl1.SeriesTemplate.SeriesDataMember = "Series";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chartControl1.Size = new System.Drawing.Size(456, 292);
            this.chartControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 292);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private DevExpress.XtraPivotGrid.PivotGridField fiedName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDate;
        private DevExpress.XtraPivotGrid.PivotGridField fieldValue;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCount;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAverage;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDate1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}


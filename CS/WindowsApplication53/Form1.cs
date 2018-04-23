using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;

namespace WindowsApplication53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateTable();
            pivotGridControl1.RefreshData();
            pivotGridControl1.BestFit();

            pivotGridControl1.OptionsChartDataSource.ShowColumnGrandTotals = false;

            chartControl1.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Line);
            
                        
        }
        private void PopulateTable()
        {
            DataTable myTable = dataSet1.Tables["Data"];
            myTable.Rows.Add(new object[] {"Aaa", DateTime.Today, 7});
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddDays(4), 6 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today, 12 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddDays(2), 14 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today, 11 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddDays(2), 10 });

            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddDays(4), 7 });
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddDays(2), 2 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddDays(2), 3 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddDays(4), 1 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddDays(2), 8 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddDays(4), 22 });
        }

        private void pivotGridControl1_Click(object sender, EventArgs e)
        {

        }

        string hidingString = "HideThisValue";
        private void pivotGridControl1_CustomChartDataSourceData(object sender, DevExpress.XtraPivotGrid.PivotCustomChartDataSourceDataEventArgs e)
        {
            if (e.ItemDataMember == DevExpress.XtraPivotGrid.PivotChartItemDataMember.Series && e.FieldValueInfo != null)
            {

                if (!ShouldChartThisSeries(e.FieldValueInfo))
                    e.Value = hidingString;
                else
                    e.Value = e.FieldValueInfo.DataField.ToString();
            }
        }

        private bool ShouldChartThisSeries(DevExpress.XtraPivotGrid.PivotFieldValueEventArgs valueInfo)
        {
            if (valueInfo.ValueType == DevExpress.XtraPivotGrid.PivotGridValueType.GrandTotal && !Equals(valueInfo.Field, fieldCount))
                return true;
            return false;
        }

        private void chartControl1_BoundDataChanged(object sender, EventArgs e)
        {
            ChartControl chart = (ChartControl)sender;
            foreach (Series s in chart.Series )
            {
                if (s.Name == hidingString)
                    s.Visible = false;
            }
            
        }


    }
}
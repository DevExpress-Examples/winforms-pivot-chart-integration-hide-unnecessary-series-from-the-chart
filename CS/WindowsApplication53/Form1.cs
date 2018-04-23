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

        private void pivotGridControl1_CustomChartDataSourceRows(object sender, DevExpress.XtraPivotGrid.PivotCustomChartDataSourceRowsEventArgs e)
        {
            for (int i = e.Rows.Count  - 1; i >= 0; i--)
            {
                if (!Object.Equals( e.Rows[i].RowValueInfo.DataField,  fieldValue) )
                    e.Rows.RemoveAt(i);
               
            }
        }

       


    }
}
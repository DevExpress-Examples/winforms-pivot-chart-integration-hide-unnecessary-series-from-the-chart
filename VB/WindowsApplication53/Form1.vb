Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace WindowsApplication53

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            PopulateTable()
            pivotGridControl1.RefreshData()
            pivotGridControl1.BestFit()
            chartControl1.SeriesTemplate.ChangeView(ViewType.Line)
        End Sub

        Private Sub PopulateTable()
            Dim myTable As DataTable = dataSet1.Tables("Data")
            myTable.Rows.Add(New Object() {"Aaa", Date.Today, 7})
            myTable.Rows.Add(New Object() {"Aaa", Date.Today.AddDays(4), 6})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today, 12})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today.AddDays(2), 14})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today, 11})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today.AddDays(2), 10})
            myTable.Rows.Add(New Object() {"Aaa", Date.Today.AddDays(4), 7})
            myTable.Rows.Add(New Object() {"Aaa", Date.Today.AddDays(2), 2})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today.AddDays(2), 3})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today.AddDays(4), 1})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today.AddDays(2), 8})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today.AddDays(4), 22})
        End Sub

        Private Sub pivotGridControl1_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub pivotGridControl1_CustomChartDataSourceRows(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomChartDataSourceRowsEventArgs)
            For i As Integer = e.Rows.Count - 1 To 0 Step -1
                If Not Equals(e.Rows(i).RowValueInfo.DataField, fieldValue) Then e.Rows.RemoveAt(i)
            Next
        End Sub
    End Class
End Namespace

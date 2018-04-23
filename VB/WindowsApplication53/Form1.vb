Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraCharts

Namespace WindowsApplication53
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			PopulateTable()
			pivotGridControl1.RefreshData()
			pivotGridControl1.BestFit()

			pivotGridControl1.OptionsChartDataSource.ShowColumnGrandTotals = False

			chartControl1.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Line)


		End Sub
		Private Sub PopulateTable()
			Dim myTable As DataTable = dataSet1.Tables("Data")
			myTable.Rows.Add(New Object() {"Aaa", DateTime.Today, 7})
			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddDays(4), 6 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today, 12 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddDays(2), 14 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today, 11 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddDays(2), 10 })

			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddDays(4), 7 })
			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddDays(2), 2 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddDays(2), 3 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddDays(4), 1 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddDays(2), 8 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddDays(4), 22 })
		End Sub

		Private Sub pivotGridControl1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pivotGridControl1.Click

		End Sub

		Private hidingString As String = "HideThisValue"
		Private Sub pivotGridControl1_CustomChartDataSourceData(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomChartDataSourceDataEventArgs) Handles pivotGridControl1.CustomChartDataSourceData
			If e.ItemDataMember = DevExpress.XtraPivotGrid.PivotChartItemDataMember.Series AndAlso e.FieldValueInfo IsNot Nothing Then

				If (Not ShouldChartThisSeries(e.FieldValueInfo)) Then
					e.Value = hidingString
				Else
					e.Value = e.FieldValueInfo.DataField.ToString()
				End If
			End If
		End Sub

		Private Function ShouldChartThisSeries(ByVal valueInfo As DevExpress.XtraPivotGrid.PivotFieldValueEventArgs) As Boolean
			If valueInfo.ValueType = DevExpress.XtraPivotGrid.PivotGridValueType.GrandTotal AndAlso (Not Equals(valueInfo.Field, fieldCount)) Then
				Return True
			End If
			Return False
		End Function

		Private Sub chartControl1_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chartControl1.BoundDataChanged
			Dim chart As ChartControl = CType(sender, ChartControl)
			For Each s As Series In chart.Series
				If s.Name = hidingString Then
					s.Visible = False
				End If
			Next s

		End Sub


	End Class
End Namespace
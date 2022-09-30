<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3188)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->

# WinForms - How to hide unnecessary series from the chart (Pivot - Chart Integration) 

This example demonstrates how handle the [PivotGridControl.CustomChartDataSourceRows](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomChartDataSourceRows) event to hide unnecessary series from the Chart control connected to the Pivot Grid.

![Pivot Grid - Chart integration](images/pivotgrid.png)

## Files to Review

* [Form1.cs](./CS/WindowsApplication53/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication53/Form1.vb))
* [Program.cs](./CS/WindowsApplication53/Program.cs) (VB: [Program.vb](./VB/WindowsApplication53/Program.vb))
<!-- default file list end -->

## Example Overview

The Pivot Grid supplies data to the attached Chart control in the form of a simple table. Each row of this table is a single Pivot Grid cell. From this row (the `PivotChartDataSourceRow` object), you can get cell values, the argument object generated from the corresponding field value, and the series name generated from the opposite field values. For each record, you can also obtain information about a Pivot Grid cell to which this record corresponds. The example demonstrates how to modify the Chart data source table to hide speicifed Chart series.

## Documentation

[Integrate the Pivot Grid with the Chart Control](https://docs.devexpress.com/WindowsForms/8748/controls-and-libraries/pivot-grid/data-analysis/integration-with-the-chart-control)

## More Examples 
-[WinForms - How to visualize Pivot Grid Data in the Chart Control](https://github.com/DevExpress-Examples/winforms-visualize-pivot-grid-data-in-chart)
- [WinForms - Customize Pivot Grid's Data before Displaying it in the Chart Control](https://github.com/DevExpress-Examples/customize-pivot-grid-controls-data-before-displaying-it-in-a-chart-control-e2214)
- [WinForms - Print a Document that Contains Pivot and Chart Controls](https://github.com/DevExpress-Examples/winforms-print-pivot-and-chart-controls)





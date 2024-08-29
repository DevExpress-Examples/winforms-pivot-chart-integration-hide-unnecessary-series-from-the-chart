<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579731/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3188)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms - How to Hide Unnecessary Series from the Chart (Pivot Grid - Chart Integration)

This example demonstrates how to handle the [PivotGridControl.CustomChartDataSourceRows](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomChartDataSourceRows) event to hide unnecessary series from the Chart control connected to the Pivot Grid.

![Pivot Grid - Chart integration](images/pivotgrid.png)

## Example Overview

The `CustomChartDataSourceRows` event parameter’s [e.Rows](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotCustomChartDataSourceRowsEventArgs.Rows) property allows you to access data that is passed to the Chart. The Pivot Grid supplies data to the attached Chart control in the form of a simple table. Each row of this table is a single Pivot Grid cell. You can use the [PivotChartDataSourceRowBase.Argument](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotChartDataSourceRowBase.Argument), [PivotChartDataSourceRowBase.Series](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotChartDataSourceRowBase.Series), and [PivotChartDataSourceRowBase.Value](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotChartDataSourceRowBase.Value) properties to obtain and modify values contained in the current row (the `PivotChartDataSourceRow` object). For each record, you can also obtain information about the Pivot Grid cell to which this record corresponds. The example demonstrates how to modify the Chart data source table to hide the specifed Chart series.

## Files to Review

* [Form1.cs](./CS/WindowsApplication53/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication53/Form1.vb))
* [Program.cs](./CS/WindowsApplication53/Program.cs) (VB: [Program.vb](./VB/WindowsApplication53/Program.vb))

## Documentation

[Integrate the Pivot Grid with the Chart Control](https://docs.devexpress.com/WindowsForms/8748/controls-and-libraries/pivot-grid/data-analysis/integration-with-the-chart-control)

## More Examples 
- [WinForms - How to visualize Pivot Grid Data in the Chart Control](https://github.com/DevExpress-Examples/winforms-visualize-pivot-grid-data-in-chart)
- [WinForms - Customize Pivot Grid's Data before Displaying it in the Chart Control](https://github.com/DevExpress-Examples/customize-pivot-grid-controls-data-before-displaying-it-in-a-chart-control-e2214)
- [WinForms - Print a Document that Contains Pivot and Chart Controls](https://github.com/DevExpress-Examples/winforms-print-pivot-and-chart-controls)




<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivot-chart-integration-hide-unnecessary-series-from-the-chart&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivot-chart-integration-hide-unnecessary-series-from-the-chart&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

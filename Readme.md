<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579731/12.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3188)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication53/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication53/Form1.vb))
* [Program.cs](./CS/WindowsApplication53/Program.cs) (VB: [Program.vb](./VB/WindowsApplication53/Program.vb))
<!-- default file list end -->
# Pivot Chart integration - How to hide unnecessary series from the chart.


<p>This example demonstrates how to hide unnecessary <a href="http://documentation.devexpress.com/#XtraCharts/CustomDocument6167"><u>Series</u></a> from the chart connected  to Pivot Grid control.   It is created with the XtraPivotGrid control for WinForms, however it is possible to use the same approach with other platforms ( ASP.NET, MVC, WPF, and Silverlight ).<br />
The pivot grid control provides information to the attached chart in the form of a simple table. Each row of this table represents single pivot grid cell. From this row, you can get cell values, the argument object generated from the corresponding <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument1694"><u>Field Value</u></a> and the series name generated from the opposite <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument1694"><u>Field Values</u></a>. In addition, it provides an API to get detailed information about the corresponding cell. The attached solution demonstrates how to modify the chart datasource table to achieve the required result.</p>


<h3>Description</h3>

<p>Starting from version 11.2, it is possible to hide unnecessary series by removing corresponding rows from the chart datasource via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomChartDataSourceRowstopic">CustomChartDataSourceRows</a> event.</p>

<br/>



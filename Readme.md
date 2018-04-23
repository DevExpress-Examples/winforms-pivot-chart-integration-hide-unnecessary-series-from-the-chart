# Pivot Chart integration - How to hide unnecessary series from the chart.


<p>This example demonstrates how to hide unnecessary <a href="http://documentation.devexpress.com/#XtraCharts/CustomDocument6167"><u>Series</u></a> from the chart connected  to Pivot Grid control.   It is created with the XtraPivotGrid control for WinForms, however it is possible to use the same approach with other platforms ( ASP.NET, MVC, WPF, and Silverlight ).<br />
The pivot grid control provides information to the attached chart in the form of a simple table. Each row of this table represents single pivot grid cell. From this row, you can get cell values, the argument object generated from the corresponding <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument1694"><u>Field Value</u></a> and the series name generated from the opposite <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument1694"><u>Field Values</u></a>. In addition, it provides an API to get detailed information about the corresponding cell. The attached solution demonstrates how to modify the chart datasource table to achieve the required result.</p>


<h3>Description</h3>

<p>This example demonstrates how to hide unnecessary series from a chart. It is necessary to perform two following steps to accomplish this task: </p><p>1. Handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomChartDataSourceDatatopic"><u>PivotGridControl.CustomChartDataSourceData</u></a> event and replace an unnecessary series name with some dummy string ( &quot;HideMe&quot; ); <br />
2. Using the <a href="http://documentation.devexpress.com/#XtraCharts/DevExpressXtraChartsChartControl_BoundDataChangedtopic"><u>ChartControl.BoundDataChanged</u></a> event hide the &quot;HideMe&quot; series from the chart.</p><p>Starting from version 12.1, it is possible to hide unnecessary series easier by removing corresponding rows from the chart datasource object directly via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomChartDataSourceRowstopic"><u>CustomChartDataSourceRows</u></a><u> </u>event.</p><p><br />
</p>

<br/>



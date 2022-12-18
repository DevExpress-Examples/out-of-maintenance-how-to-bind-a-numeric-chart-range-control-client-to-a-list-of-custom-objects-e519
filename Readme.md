<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128568763/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5193)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/BindNumericChartClientToItemList/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/BindNumericChartClientToItemList/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/BindNumericChartClientToItemList/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/BindNumericChartClientToItemList/MainWindow.xaml.vb))
<!-- default file list end -->
# How to bind a numeric chart range control client to a list of custom objects


<p>This example shows how to bind a numeric chart range control client to a <strong>System.Collections.Generic.List</strong> containing <strong>NumericItem</strong> objects.</p><p>Each <strong>NumericItem </strong>object contains <strong>Argument</strong> and <strong>Value</strong> properties, to which a numeric chart range control client is bound via its <a href="https://help.devexpress.com/#WPF/DevExpressXpfChartsRangeControlClientChartRangeControlClient_ArgumentDataMembertopic"><u>ChartRangeControlClient.ArgumentDataMember</u></a> and <a href="https://help.devexpress.com/#WPF/DevExpressXpfChartsRangeControlClientChartRangeControlClient_ValueDataMembertopic"><u>ChartRangeControlClient.ValueDataMember</u></a> properties. </p><p>Note that the numeric chart client sorts data from a list of <strong>NumericItem</strong> objects by arguments in the ascending order (when the <strong>ChartRangeControlClient.ArgumentDataMember</strong> property is specified). If you wish  to see data in the order in which points have been added to the list, do not use  the <strong>ChartRangeControlClient.ArgumentDataMember</strong> property. <br />
</p><p>See also:</p><p>- <a href="https://www.devexpress.com/Support/Center/CodeCentral/ViewExample.aspx?exampleId=E5110"><u>How to bind a numeric chart range control client to an array of integers</u></a>;</p><p>- <a href="https://www.devexpress.com/Support/Center/CodeCentral/ViewExample.aspx?exampleId=E5190"><u>How to bind a numeric chart range control client to a point collection</u></a></p>

<br/>



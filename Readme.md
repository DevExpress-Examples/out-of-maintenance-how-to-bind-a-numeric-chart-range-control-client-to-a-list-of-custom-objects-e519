# How to bind a numeric chart range control client to a list of custom objects


<p>This example shows how to bind a numeric chart range control client to a <strong>System.Collections.Generic.List</strong> containing <strong>NumericItem</strong> objects.</p><p>Each <strong>NumericItem </strong>object contains <strong>Argument</strong> and <strong>Value</strong> properties, to which a numeric chart range control client is bound via its <a href="https://help.devexpress.com/#WPF/DevExpressXpfChartsRangeControlClientChartRangeControlClient_ArgumentDataMembertopic"><u>ChartRangeControlClient.ArgumentDataMember</u></a> and <a href="https://help.devexpress.com/#WPF/DevExpressXpfChartsRangeControlClientChartRangeControlClient_ValueDataMembertopic"><u>ChartRangeControlClient.ValueDataMember</u></a> properties. </p><p>Note that the numeric chart client sorts data from a list of <strong>NumericItem</strong> objects by arguments in the ascending order (when the <strong>ChartRangeControlClient.ArgumentDataMember</strong> property is specified). If you wish  to see data in the order in which points have been added to the list, do not use  the <strong>ChartRangeControlClient.ArgumentDataMember</strong> property. <br />
</p><p>See also:</p><p>- <a href="https://www.devexpress.com/Support/Center/CodeCentral/ViewExample.aspx?exampleId=E5110"><u>How to bind a numeric chart range control client to an array of integers</u></a>;</p><p>- <a href="https://www.devexpress.com/Support/Center/CodeCentral/ViewExample.aspx?exampleId=E5190"><u>How to bind a numeric chart range control client to a point collection</u></a></p>

<br/>



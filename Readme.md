<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128604428/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T317193)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ColumnBreakExample/Form1.cs) (VB: [Form1.vb](./VB/ColumnBreakExample/Form1.vb))
* [XtraReport1.cs](./CS/ColumnBreakExample/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/ColumnBreakExample/XtraReport1.vb))
<!-- default file list end -->
# Page Builder - MultiColumn - How to start a new column


This example illustrates how to start a new column (in <strong>MultiColumn</strong> mode) after a certain number of records if the column direction is set to "Down Then Across".<br><br>Use the <strong>Band.PageBrea</strong>k property or the <strong>XRPageBreak</strong> control. To 'activate' a page break at certain positions only, apply a formatting rule (<strong>Visible = true</strong>) with the following condition to <strong>XRPageBreak:</strong><br><strong>([DataSource.CurrentRowIndex] + 1) % [Parameters.paramRecCount] == 0  And [DataSource.CurrentRowIndex] < [DataSource.RowCount] - 1</strong>

<br/>



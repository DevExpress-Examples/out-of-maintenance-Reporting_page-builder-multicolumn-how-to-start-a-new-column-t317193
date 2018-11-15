<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ColumnBreakExample/Form1.cs) (VB: [Form1.vb](./VB/ColumnBreakExample/Form1.vb))
* [XtraReport1.cs](./CS/ColumnBreakExample/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/ColumnBreakExample/XtraReport1.vb))
<!-- default file list end -->
# Page Builder - MultiColumn - How to start a new column


This example illustrates how to start a new column (in <strong>MultiColumn</strong> mode) after a certain number of records if the column direction is set to "Down Then Across".<br><br>Use the <strong>Band.PageBrea</strong>k property or the <strong>XRPageBreak</strong> control. To 'activate' a page break at certain positions only, apply a formatting rule (<strong>Visible = true</strong>) with the following condition to <strong>XRPageBreak:</strong><br><strong>([DataSource.CurrentRowIndex] + 1) % [Parameters.paramRecCount] == 0  And [DataSource.CurrentRowIndex] < [DataSource.RowCount] - 1</strong>

<br/>



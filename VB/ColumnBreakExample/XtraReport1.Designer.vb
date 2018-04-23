Namespace ColumnBreakExample
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
			Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
			Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.xrControlStyle2 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.paramRecCount = New DevExpress.XtraReports.Parameters.Parameter()
			Me.xrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
			Me.formattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageBreak1, Me.xrLabel2, Me.xrLabel1})
			Me.Detail.EvenStyleName = "xrControlStyle1"
			Me.Detail.HeightF = 62.74996F
			Me.Detail.KeepTogether = True
			Me.Detail.MultiColumn.ColumnCount = 3
			Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
			Me.Detail.Name = "Detail"
			Me.Detail.OddStyleName = "xrControlStyle2"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.HeightF = 100F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.HeightF = 100F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "ColumnBreakExample.Properties.Settings.nwindConnectionString"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			tableQuery1.Name = "CategoryProducts"
			tableInfo1.Name = "CategoryProducts"
			columnInfo1.Name = "ProductName"
			columnInfo2.Name = "CategoryName"
			columnInfo3.Name = "Picture"
			tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3})
			tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1})
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CategoryProducts.CategoryName")})
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(215F, 23F)
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CategoryProducts.ProductName")})
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 22.99999F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(215F, 23F)
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' xrControlStyle1
			' 
			Me.xrControlStyle1.BackColor = System.Drawing.Color.Pink
			Me.xrControlStyle1.Name = "xrControlStyle1"
			Me.xrControlStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			' 
			' xrControlStyle2
			' 
			Me.xrControlStyle2.BackColor = System.Drawing.Color.PowderBlue
			Me.xrControlStyle2.Name = "xrControlStyle2"
			Me.xrControlStyle2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			' 
			' paramRecCount
			' 
			Me.paramRecCount.Description = "Records Per Column"
			Me.paramRecCount.Name = "paramRecCount"
			Me.paramRecCount.Type = GetType(Integer)
			Me.paramRecCount.ValueInfo = "5"
			' 
			' xrPageBreak1
			' 
			Me.xrPageBreak1.FormattingRules.Add(Me.formattingRule1)
			Me.xrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 60.74994F)
			Me.xrPageBreak1.Name = "xrPageBreak1"
			Me.xrPageBreak1.Visible = False
			' 
			' formattingRule1
			' 
			Me.formattingRule1.Condition = "([DataSource.CurrentRowIndex] + 1) % [Parameters.paramRecCount] == 0  And [DataSo" & "urce.CurrentRowIndex] < [DataSource.RowCount] - 1"
			' 
			' 
			' 
			Me.formattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.True
			Me.formattingRule1.Name = "formattingRule1"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.DataMember = "CategoryProducts"
			Me.DataSource = Me.sqlDataSource1
			Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() { Me.formattingRule1})
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.paramRecCount})
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.xrControlStyle1, Me.xrControlStyle2})
			Me.Version = "15.1"
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
		Private formattingRule1 As DevExpress.XtraReports.UI.FormattingRule
		Private xrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
		Private xrControlStyle2 As DevExpress.XtraReports.UI.XRControlStyle
		Private paramRecCount As DevExpress.XtraReports.Parameters.Parameter
	End Class
End Namespace

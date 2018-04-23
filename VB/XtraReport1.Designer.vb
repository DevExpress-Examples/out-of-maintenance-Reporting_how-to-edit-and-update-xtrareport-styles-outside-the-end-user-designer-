Imports Microsoft.VisualBasic
Imports System
Namespace RepStyleSheets
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.nwindDataSet1 = New RepStyleSheets.nwindDataSet()
			Me.categoriesTableAdapter = New RepStyleSheets.nwindDataSetTableAdapters.CategoriesTableAdapter()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox1, Me.xrLabel2, Me.xrLabel1})
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPictureBox1
			' 
			Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture", "")})
			resources.ApplyResources(Me.xrPictureBox1, "xrPictureBox1")
			Me.xrPictureBox1.Name = "xrPictureBox1"
			Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description", "")})
			resources.ApplyResources(Me.xrLabel2, "xrLabel2")
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName", "")})
			resources.ApplyResources(Me.xrLabel1, "xrLabel1")
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.StylePriority.UseForeColor = False
			' 
			' PageHeader
			' 
			Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3})
			Me.PageHeader.Height = 47
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel3
			' 
			resources.ApplyResources(Me.xrLabel3, "xrLabel3")
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.StylePriority.UseFont = False
			' 
			' PageFooter
			' 
			Me.PageFooter.Height = 30
			Me.PageFooter.Name = "PageFooter"
			Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter})
			Me.DataAdapter = Me.categoriesTableAdapter
			Me.DataMember = "Categories"
			Me.DataSource = Me.nwindDataSet1
			Me.ExportOptions.Csv.EncodingType = (CType(resources.GetObject("XtraReport1.ExportOptions.Csv.EncodingType"), DevExpress.XtraPrinting.EncodingType))
			Me.ExportOptions.Html.CharacterSet = resources.GetString("XtraReport1.ExportOptions.Html.CharacterSet")
			Me.ExportOptions.Html.Title = resources.GetString("XtraReport1.ExportOptions.Html.Title")
			Me.ExportOptions.Mht.CharacterSet = resources.GetString("XtraReport1.ExportOptions.Mht.CharacterSet")
			Me.ExportOptions.Mht.Title = resources.GetString("XtraReport1.ExportOptions.Mht.Title")
			Me.ExportOptions.Pdf.DocumentOptions.Application = resources.GetString("XtraReport1.ExportOptions.Pdf.DocumentOptions.Application")
			Me.ExportOptions.Pdf.DocumentOptions.Author = resources.GetString("XtraReport1.ExportOptions.Pdf.DocumentOptions.Author")
			Me.ExportOptions.Pdf.DocumentOptions.Keywords = resources.GetString("XtraReport1.ExportOptions.Pdf.DocumentOptions.Keywords")
			Me.ExportOptions.Pdf.DocumentOptions.Subject = resources.GetString("XtraReport1.ExportOptions.Pdf.DocumentOptions.Subject")
			Me.ExportOptions.Pdf.DocumentOptions.Title = resources.GetString("XtraReport1.ExportOptions.Pdf.DocumentOptions.Title")
			Me.ExportOptions.Text.EncodingType = (CType(resources.GetObject("XtraReport1.ExportOptions.Text.EncodingType"), DevExpress.XtraPrinting.EncodingType))
			Me.ExportOptions.Xls.SheetName = resources.GetString("XtraReport1.ExportOptions.Xls.SheetName")
			Me.Version = "8.2"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private nwindDataSet1 As nwindDataSet
		Private categoriesTableAdapter As RepStyleSheets.nwindDataSetTableAdapters.CategoriesTableAdapter
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
	End Class
End Namespace

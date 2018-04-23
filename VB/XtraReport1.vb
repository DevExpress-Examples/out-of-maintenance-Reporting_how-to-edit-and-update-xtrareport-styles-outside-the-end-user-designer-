Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace RepStyleSheets
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()

			CreateCustomStyles()
		End Sub

		Public Sub CreateCustomStyles()
			Dim style1 As New XRControlStyle()
			Dim style2 As New XRControlStyle()

			style1.Name = "style1"
			style1.BackColor = Color.AliceBlue
			style2.Name = "style2"
			style2.BackColor = Color.Chocolate

			StyleSheet.Add(style1)
			StyleSheet.Add(style2)
		End Sub

		Friend Sub ApplayStyles()
			Try
				xrLabel2.Styles.EvenStyle = StyleSheet(0)
				xrLabel2.Styles.OddStyle = StyleSheet(1)
				CreateDocument()
			Catch ex As Exception
				System.Windows.Forms.MessageBox.Show(ex.Message)
			End Try
		End Sub

		Public Sub ResetStyles()
			xrLabel2.Styles.EvenStyle = Nothing
			xrLabel2.Styles.OddStyle = Nothing
			StyleSheet.Clear()
			CreateDocument()
		End Sub

	End Class
End Namespace

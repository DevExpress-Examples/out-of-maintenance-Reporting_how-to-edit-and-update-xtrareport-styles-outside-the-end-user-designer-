Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.Design
Imports DevExpress.XtraReports.UserDesigner
Imports System.Reflection
Imports System.ComponentModel.Design
Imports DevExpress.XtraReports.UI

Namespace RepStyleSheets
	Partial Public Class Form1
		Inherits Form
		Private report As XtraReport1

		Public Sub New()
			InitializeComponent()

			report = New XtraReport1()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			report.ApplayStyles()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim designerForm As New XRDesignFormEx()
			designerForm.OpenReport(report)
			designerForm.DesignPanel.ExecCommand(ReportCommand.ShowPreviewTab)
			designerForm.ShowDialog()
			designerForm.OpenReport(CType(Nothing, XtraReport))
			designerForm.Dispose()
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				report.StyleSheet.SaveToFile(saveFileDialog1.FileName)
			End If
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				report.StyleSheet.LoadFromFile(openFileDialog1.FileName)
			End If

			report.ApplayStyles()
		End Sub

		Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button4.Click
			report.ResetStyles()
		End Sub

		Private Sub button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button5.Click
			Dim designerForm As New XRDesignFormEx()
			designerForm.OpenReport(report)

			Dim ssef As New StyleSheetEditorForm(report, Nothing)

			ssef.ShowDialog()

			designerForm.OpenReport(CType(Nothing, XtraReport))
			designerForm.Dispose()
		End Sub
	End Class
End Namespace
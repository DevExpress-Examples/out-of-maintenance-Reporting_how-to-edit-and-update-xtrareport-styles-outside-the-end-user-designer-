Imports Microsoft.VisualBasic
Imports System
Namespace RepStyleSheets
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
			Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
			Me.button3 = New System.Windows.Forms.Button()
			Me.button4 = New System.Windows.Forms.Button()
			Me.button5 = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(91, 12)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(111, 23)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Show Report"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(91, 41)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(111, 23)
			Me.button2.TabIndex = 1
			Me.button2.Text = "Save StyleSheet"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' openFileDialog1
			' 
			Me.openFileDialog1.FileName = "openFileDialog1"
			' 
			' button3
			' 
			Me.button3.Location = New System.Drawing.Point(91, 70)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(111, 23)
			Me.button3.TabIndex = 2
			Me.button3.Text = "Load StyleSheet"
			Me.button3.UseVisualStyleBackColor = True
'			Me.button3.Click += New System.EventHandler(Me.button3_Click);
			' 
			' button4
			' 
			Me.button4.Location = New System.Drawing.Point(91, 99)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(111, 23)
			Me.button4.TabIndex = 3
			Me.button4.Text = "Reset StyleSheet"
			Me.button4.UseVisualStyleBackColor = True
'			Me.button4.Click += New System.EventHandler(Me.button4_Click);
			' 
			' button5
			' 
			Me.button5.Location = New System.Drawing.Point(91, 128)
			Me.button5.Name = "button5"
			Me.button5.Size = New System.Drawing.Size(111, 23)
			Me.button5.TabIndex = 4
			Me.button5.Text = "Edit StyleSheet"
			Me.button5.UseVisualStyleBackColor = True
'			Me.button5.Click += New System.EventHandler(Me.button5_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(292, 266)
			Me.Controls.Add(Me.button5)
			Me.Controls.Add(Me.button4)
			Me.Controls.Add(Me.button3)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
		Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
		Private WithEvents button3 As System.Windows.Forms.Button
		Private WithEvents button4 As System.Windows.Forms.Button
		Private WithEvents button5 As System.Windows.Forms.Button
	End Class
End Namespace


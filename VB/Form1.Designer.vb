' Developer Express Code Central Example:
' How to perform drag-and-drop operation in a custom manner
' 
' This example illustrates how to perform the drag-and-drop operation in case of a
' ListBox drag-and-drop source. Since there is no built-in capability to
' accomplish this task, you should perform the drag-and-drop operation in a custom
' manner. To do this, use the following RichEditControl events: DragEnter,
' DragOver, DragDrop. Most part of the work is performed in the DragOver event
' handler. Here, you should update the RichEditControl.Document.CaretPosition
' property value according to the current mouse position (use the approach from
' the How to: Obtain the Document Position under the Mouse Cursor
' (ms-help://DevExpress.NETv10.2/DevExpress.WindowsForms/CustomDocument6012.htm))
' help section for this purpose). Also, you might want to draw a custom insertion
' marker in this event handler. Otherwise, you can use the standard caret. In
' latter case, just call the RichEditControl.Focus() method in the control's
' DragEnter event handler. Finally, note how the RichEditControl.ScrollToCaret
' Method
' (ms-help://DevExpress.NETv10.2/DevExpress.WindowsForms/DevExpressXtraRichEditRichEditControl_ScrollToCarettopic.htm)
' is used to scroll the document to the caret position if you move the caret
' outside of the visible document area.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2943


Imports Microsoft.VisualBasic
Imports System
Namespace RichListDragDrop
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
			Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.listBox1 = New System.Windows.Forms.ListBox()
			Me.SuspendLayout()
			' 
			' richEditControl1
			' 
			Me.richEditControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.richEditControl1.Location = New System.Drawing.Point(142, 10)
			Me.richEditControl1.Margin = New System.Windows.Forms.Padding(2)
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Size = New System.Drawing.Size(364, 267)
			Me.richEditControl1.TabIndex = 0
			Me.richEditControl1.Text = "richEditControl1"
'			Me.richEditControl1.DragOver += New System.Windows.Forms.DragEventHandler(Me.richEditControl1_DragOver);
'			Me.richEditControl1.DragDrop += New System.Windows.Forms.DragEventHandler(Me.richEditControl1_DragDrop);
'			Me.richEditControl1.DragEnter += New System.Windows.Forms.DragEventHandler(Me.richEditControl1_DragEnter);
			' 
			' listBox1
			' 
			Me.listBox1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.listBox1.FormattingEnabled = True
			Me.listBox1.Items.AddRange(New Object() { "Item1", "Item2", "Item3", "Item4", "Item5", "Item6", "Item7"})
			Me.listBox1.Location = New System.Drawing.Point(12, 12)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(120, 264)
			Me.listBox1.TabIndex = 1
'			Me.listBox1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.listBox1_MouseDown);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(515, 288)
			Me.Controls.Add(Me.listBox1)
			Me.Controls.Add(Me.richEditControl1)
			Me.Margin = New System.Windows.Forms.Padding(2)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private WithEvents listBox1 As System.Windows.Forms.ListBox
	End Class
End Namespace

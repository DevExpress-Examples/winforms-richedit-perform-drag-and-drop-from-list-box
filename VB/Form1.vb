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
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit.Utils
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichListDragDrop
	Partial Public Class Form1
		Inherits Form
		Private richEditGraphics As Graphics = Nothing
		Private customDragDropTarget As Boolean = False

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub listBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles listBox1.MouseDown
			If listBox1.Items.Count = 0 Then
				Return
			End If

			customDragDropTarget = True

			Dim index As Integer = listBox1.IndexFromPoint(e.X, e.Y)
			Dim item As String = listBox1.Items(index).ToString()
			Dim dde1 As DragDropEffects = DoDragDrop(item, DragDropEffects.Copy)

			customDragDropTarget = False
		End Sub

		Private Sub richEditControl1_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles richEditControl1.DragEnter
			If e.Data.GetDataPresent(DataFormats.StringFormat) Then
				e.Effect = DragDropEffects.Copy
			End If
		End Sub

		Private Sub richEditControl1_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles richEditControl1.DragOver
			If (Not customDragDropTarget) Then
				Return
			End If

			Dim docPoint As Point = Units.PixelsToDocuments(richEditControl1.PointToClient(Form.MousePosition), richEditControl1.DpiX, richEditControl1.DpiY)

			Dim pos As DocumentPosition = richEditControl1.GetPositionFromPoint(docPoint)
			If pos Is Nothing Then
				Return
			End If
			Dim rect As Rectangle = Units.DocumentsToPixels(richEditControl1.GetBoundsFromPosition(pos), richEditControl1.DpiX, richEditControl1.DpiY)

			richEditControl1.Document.CaretPosition = pos

			If richEditGraphics Is Nothing Then
				richEditGraphics = richEditControl1.CreateGraphics()
			End If

			rect.Width = 2
			richEditControl1.Refresh()
			richEditGraphics.FillRectangle(Brushes.Blue, rect)
			richEditControl1.ScrollToCaret()
		End Sub

		Private Sub richEditControl1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles richEditControl1.DragDrop
			If (Not customDragDropTarget) Then
				Return
			End If

			Dim text As String = CStr(e.Data.GetData(DataFormats.StringFormat))

			richEditControl1.Document.InsertText(richEditControl1.Document.CaretPosition, text)
		End Sub
	End Class
End Namespace
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
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace RichListDragDrop
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub
	End Class
End Namespace
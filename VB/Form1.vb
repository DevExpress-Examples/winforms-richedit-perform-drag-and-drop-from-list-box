Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Office.Utils

Namespace RichListDragDrop

    Public Partial Class Form1
        Inherits Form

        Private richEditGraphics As Graphics = Nothing

        Private customDragDropTarget As Boolean = False

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub listBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            If listBox1.Items.Count = 0 Then Return
            customDragDropTarget = True
            Dim index As Integer = listBox1.IndexFromPoint(e.X, e.Y)
            Dim item As String = listBox1.Items(index).ToString()
            Dim dde1 As DragDropEffects = DoDragDrop(item, DragDropEffects.Copy)
            customDragDropTarget = False
        End Sub

        Private Sub richEditControl1_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data.GetDataPresent(DataFormats.StringFormat) Then e.Effect = DragDropEffects.Copy
        End Sub

        Private Sub richEditControl1_DragOver(ByVal sender As Object, ByVal e As DragEventArgs)
            If Not customDragDropTarget Then Return
            Dim docPoint As Point = Units.PixelsToDocuments(richEditControl1.PointToClient(MousePosition), richEditControl1.DpiX, richEditControl1.DpiY)
            Dim pos As DocumentPosition = richEditControl1.GetPositionFromPoint(docPoint)
            If pos Is Nothing Then Return
            Dim rect As Rectangle = Units.DocumentsToPixels(richEditControl1.GetBoundsFromPosition(pos), richEditControl1.DpiX, richEditControl1.DpiY)
            richEditControl1.Document.CaretPosition = pos
            If richEditGraphics Is Nothing Then richEditGraphics = richEditControl1.CreateGraphics()
            rect.Width = 2
            richEditControl1.Refresh()
            richEditGraphics.FillRectangle(Brushes.Blue, rect)
            richEditControl1.ScrollToCaret()
        End Sub

        Private Sub richEditControl1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
            If Not customDragDropTarget Then Return
            Dim text As String = CStr(e.Data.GetData(DataFormats.StringFormat))
            richEditControl1.Document.InsertText(richEditControl1.Document.CaretPosition, text)
        End Sub
    End Class
End Namespace

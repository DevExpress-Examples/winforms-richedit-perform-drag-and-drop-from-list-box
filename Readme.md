# How to perform drag-and-drop operation in a custom manner


<p>This example illustrates how to perform the drag-and-drop operation in case of a ListBox drag-and-drop source. Since there is no built-in capability to accomplish this task, you should perform the drag-and-drop operation in a custom manner. To do this, use the following RichEditControl events: DragEnter, DragOver, DragDrop. Most part of the work is performed in the DragOver event handler. Here, you should update the RichEditControl.Document.CaretPosition property value according to the current mouse position (use the approach from the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument6012"><u>How to: Obtain the Document Position under the Mouse Cursor</u></a>) help section for this purpose). Also, you might want to draw a custom insertion marker in this event handler. Otherwise, you can use the standard caret. In latter case, just call the RichEditControl.Focus() method in the control's DragEnter event handler. Finally, note how the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_ScrollToCarettopic"><u>RichEditControl.ScrollToCaret Method</u></a> is used to scroll the document to the caret position if you move the caret outside of the visible document area. </p>

<br/>



<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128610939/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2943)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Rich Text Editor for WinForms - How to Perform Drag-and-Drop from a List Box

This example illustrates how to perform the drag-and-drop operation in case of a list box.

To do this, handle the following RichEditControl events:

* `DragEnter`
* `DragOver`
* `DragDrop`

In the DragOver event handler, update the [RichEditControl.Document.CaretPosition](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.Document.CaretPosition) property value according to the current mouse position. Also, you might want to draw a custom insertion marker in this event handler.

If you use the standard caret, call the `RichEditControl.Focus()` method in the `DragEnter` event handler. Use the [RichEditControl.ScrollToCaret](https://docs.devexpress.com/WindowsForms/devexpress.xtrarichedit.richeditcontrol.scrolltocaret.overloads) method to scroll the document to the caret position if you move the caret outside of the visible document area.

## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))

## Documentation

* [How to: Obtain the Document Position under the Mouse Cursor](https://docs.devexpress.com/WindowsForms/6012/controls-and-libraries/rich-text-editor/examples/text/how-to-obtain-the-document-position-under-the-mouse-pointer)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-perform-drag-and-drop-from-list-box&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-perform-drag-and-drop-from-list-box&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

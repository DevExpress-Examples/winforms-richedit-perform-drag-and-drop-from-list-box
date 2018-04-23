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
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("RichListDragDrop")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("-")>
<Assembly: AssemblyProduct("RichListDragDrop")>
<Assembly: AssemblyCopyright("Copyright - 2011")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("c786303d-0bda-402d-a30d-05a81c480fb0")>

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
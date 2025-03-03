Option Compare Database
Option Explicit

' Function to save the category to the Categories table
Sub SaveCategory()
    Dim db As DAO.Database
    Dim rs As DAO.Recordset
    Dim categoryName As String
    Dim descriptions As String
    Dim createBy As String
    Dim status As Boolean
    Dim createDate As Date
    
    ' Get the values from the form controls
    categoryName = Me.txtName.Value
    descriptions = Me.txtDescriptions.Value
    createBy = 1 ' Default value for new records
    status = 1 ' Default value for new records
    createDate = Now() ' Set the current date and time
    
    ' Check if the category name is empty
    If IsNull(categoryName) Or categoryName = "" Then
        MsgBox "Please enter a category name.", vbExclamation
        Exit Sub
    End If
    
    ' Open the Categories table
    Set db = CurrentDb()
    Set rs = db.OpenRecordset("Categories", dbOpenDynaset)
    
    ' Add a new record to the Categories table
    rs.AddNew
    rs!name = categoryName
    rs!descriptions = descriptions
    rs!created_date = createDate
    rs!created_by = createBy
    rs!status = status
    rs!is_deleted = False ' Default value for new records
    rs.Update
    
    ' Close the recordset and database
    rs.Close
    Set rs = Nothing
    Set db = Nothing
    
    ' Clear the form controls
    Me.txtName.Value = ""
    Me.txtDescriptions.Value = ""
    
    ' Display a success message
    MsgBox "Category saved successfully.", vbInformation
End Sub

' Event handler for the Save button click event
Private Sub btnSave_Click()
    SaveCategory
End Sub

' Optional: Event handler for form load event to set focus on the text box
Private Sub Form_Load()
    Me.txtName.SetFocus
End Sub

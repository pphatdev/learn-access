Option Compare Database
Option Explicit

' Function to save the brand to the Brands table
Sub SaveBrand()
    Dim db As DAO.Database
    Dim rs As DAO.Recordset
    Dim brandName As String
    Dim descriptions As String
    Dim createBy As String
    Dim status As Boolean
    Dim createDate As Date
    
    ' Get the values from the form controls
    brandName = Me.txtName.Value
    descriptions = Me.txtDescriptions.Value
    createBy = 1 ' Default value for new records
    status = 1 ' Default value for new records
    createDate = Now() ' Set the current date and time
    
    ' Check if the brand name is empty
    If IsNull(brandName) Or brandName = "" Then
        MsgBox "Please enter a brand name.", vbExclamation
        Exit Sub
    End If
    
    ' Open the Brands table
    Set db = CurrentDb()
    Set rs = db.OpenRecordset("Brands", dbOpenDynaset)
    
    ' Add a new record to the Brands table
    rs.AddNew
    rs!name = brandName
    rs!descriptions = descriptions
    rs!create_date = createDate
    rs!create_by = createBy
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
    Me.txtCreateBy.Value = ""
    Me.chkStatus.Value = False
    
    ' Display a success message
    MsgBox "Brand saved successfully.", vbInformation
End Sub

' Event handler for the Save button click event
Private Sub btnSave_Click()
    SaveBrand
End Sub

' Optional: Event handler for form load event to set focus on the text box
Private Sub Form_Load()
    Me.txtName.SetFocus
End Sub


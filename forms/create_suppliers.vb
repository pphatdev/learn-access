Option Compare Database
Option Explicit

' Function to save the supplier to the Suppliers table
Sub SaveSupplier()
    Dim db As DAO.Database
    Dim rs As DAO.Recordset
    Dim supplierName As String
    Dim contactName As String
    Dim phoneNumber As String
    Dim email As String
    Dim website As String
    Dim address As String
    Dim createdBy As String
    Dim status As Boolean
    Dim createdDate As Date
    
    ' Get the values from the form controls
    supplierName = Me.txtName.Value
    contactName = Me.txtContactName.Value
    phoneNumber = Me.txtPhoneNumber.Value
    email = Me.txtEmail.Value
    website = Me.txtWebsite.Value
    address = Me.txtAddress.Value
    createdBy = 1 ' Default value for new records
    
    ' Check if the supplier name is empty
    If IsNull(supplierName) Or supplierName = "" Then
        MsgBox "Please enter a supplier name.", vbExclamation
        Exit Sub
    End If
    
    ' Open the Suppliers table
    Set db = CurrentDb()
    Set rs = db.OpenRecordset("Suppliers", dbOpenDynaset)
    
    ' Add a new record to the Suppliers table
    rs.AddNew
    rs!name = supplierName
    rs!contact_name = contactName
    rs!phone_number = phoneNumber
    rs!email = email
    rs!website = website
    rs!address = address
    rs!created_date = Now() ' Set the current date and time
    rs!created_by = createdBy
    rs!status = True ' Default value for new records
    rs!is_deleted = False ' Default value for new records
    rs.Update
    
    ' Close the recordset and database
    rs.Close
    Set rs = Nothing
    Set db = Nothing
    
    ' Clear the form controls
    Me.txtName.Value = ""
    Me.txtContactName.Value = ""
    Me.txtPhoneNumber.Value = ""
    Me.txtEmail.Value = ""
    Me.txtWebsite.Value = ""
    Me.txtAddress.Value = ""
    
    ' Display a success message
    MsgBox "Supplier saved successfully.", vbInformation
End Sub

' Event handler for the Save button click event
Private Sub btnSave_Click()
    SaveSupplier
End Sub

' Optional: Event handler for form load event to set focus on the text box
Private Sub Form_Load()
    Me.txtName.SetFocus
End Sub
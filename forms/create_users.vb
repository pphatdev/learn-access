Option Compare Database
Option Explicit

' Function to save the user to the Users and user_details tables
Sub SaveUser()
    Dim db As DAO.Database
    Dim rs As DAO.Recordset


    ' Personal Information
    Dim firstName As String
    Dim lastName As String
    Dim fullName As String
    Dim pod As String
    Dim bod As Date
    ' Account Information
    Dim username As String
    Dim password As String
    ' Contact Information
    Dim email As String
    Dim phone As String
    Dim address As String
    ' Staff Information
    Dim idCard As String
    Dim role As String

    ' Personal Information Fields
    If IsNull(Me.txtFirstName.Value) Or Trim(Me.txtFirstName.Value) = "" Then
        MsgBox "Please enter First Name", vbExclamation
        Me.txtFirstName.SetFocus
        Exit Sub
    End If
    firstName = Me.txtFirstName.Value

    If IsNull(Me.txtLastName.Value) Or Trim(Me.txtLastName.Value) = "" Then
        MsgBox "Please enter Last Name", vbExclamation
        Me.txtLastName.SetFocus
        Exit Sub
    End If
    lastName = Me.txtLastName.Value
    
    fullName = firstName & " " & lastName

    If IsNull(Me.txtPod.Value) Or Trim(Me.txtPod.Value) = "" Then
        MsgBox "Please enter Place of Birth", vbExclamation
        Me.txtPod.SetFocus
        Exit Sub
    End If
    pod = Me.txtPod.Value

    If IsNull(Me.txtDob.Value) Then
        MsgBox "Please enter Date of Birth", vbExclamation
        Me.txtDob.SetFocus
        Exit Sub
    End If
    bod = Me.txtDob.Value

    ' Account Information Fields
    If IsNull(Me.txtPassword.Value) Or Trim(Me.txtPassword.Value) = "" Then
        MsgBox "Please enter Password", vbExclamation
        Me.txtPassword.SetFocus
        Exit Sub
    End If
    password = Me.txtPassword.Value

    ' Contact Information Fields
    If IsNull(Me.txtEmail.Value) Or Trim(Me.txtEmail.Value) = "" Then
        MsgBox "Please enter Email", vbExclamation
        Me.txtEmail.SetFocus
        Exit Sub
    End If
    email = Me.txtEmail.Value

    If IsNull(Me.txtPhone.Value) Or Trim(Me.txtPhone.Value) = "" Then
        MsgBox "Please enter Phone Number", vbExclamation
        Me.txtPhone.SetFocus
        Exit Sub
    End If
    phone = Me.txtPhone.Value

    If IsNull(Me.txtAddress.Value) Or Trim(Me.txtAddress.Value) = "" Then
        MsgBox "Please enter Address", vbExclamation
        Me.txtAddress.SetFocus
        Exit Sub
    End If
    address = Me.txtAddress.Value

    ' Staff Information Fields
    If IsNull(Me.txtIdCard.Value) Or Trim(Me.txtIdCard.Value) = "" Then
        MsgBox "Please enter ID Card Number", vbExclamation
        Me.txtIdCard.SetFocus
        Exit Sub
    End If
    idCard = Me.txtIdCard.Value

    If IsNull(Me.txtRole.Value) Or Trim(Me.txtRole.Value) = "" Then
        MsgBox "Please enter Role", vbExclamation
        Me.txtRole.SetFocus
        Exit Sub
    End If
    role = Me.txtRole.Value

    ' Add a new record to the Users table and User_Details table
    Set db = CurrentDb()
    Set rs = db.OpenRecordset("Users", dbOpenDynaset)
    
    rs.AddNew
    rs!username = email
    rs!email = email
    rs!phone_number = phone
    rs!full_name = fullName
    rs!password = password
    rs!role = role
    rs!created_by = 1 ' Default value for new records
    rs!created_date = Now()
    rs!is_deleted = False
    rs!status = True
    rs.Update

    ' Add a new record to the User_Details table
    Set rs = db.OpenRecordset("User_Details", dbOpenDynaset)

    rs.AddNew
    rs!first_name = firstName
    rs!last_name = lastName
    rs!hire_date = Now()
    rs!pob = pod
    rs!dob = bod
    rs!id_card = idCard
    rs!address = address
    rs!user_id = DMax("id", "Users")
    rs!created_date = Now()
    rs!status = True
    rs!is_deleted = False
    rs.Update


    ' Close the recordset and database
    rs.Close
    Set rs = Nothing
    Set db = Nothing

    ' Clear the form controls
    Me.txtFirstName.Value = ""
    Me.txtLastName.Value = ""
    Me.txtPod.Value = ""
    Me.txtDob.Value = ""
    Me.txtEmail.Value = ""
    Me.txtPhone.Value = ""
    Me.txtAddress.Value = ""
    Me.txtIdCard.Value = ""
    Me.txtRole.Value = ""
    Me.txtPassword.Value = ""

    ' Display a success message
    MsgBox "User saved successfully.", vbInformation
    
End Sub

' Event handler for the Save button click event
Private Sub btnSave_Click()
    SaveUser
End Sub

' Optional: Event handler for form load event to set focus on the text box
Private Sub Form_Load()
    Me.txtFirstName.SetFocus
End Sub
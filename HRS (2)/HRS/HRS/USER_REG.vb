Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions


Public Class USER_REG
    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer

    Dim cs As String = "Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True"
    Public Shared Function GetUniqueKey(ByVal maxSize As Integer) As String
        Dim chars As Char() = New Char(61) {}
        chars = "123456789".ToCharArray()
        Dim data As Byte() = New Byte(0) {}
        Dim crypto As New RNGCryptoServiceProvider()
        crypto.GetNonZeroBytes(data)
        data = New Byte(maxSize - 1) {}
        crypto.GetNonZeroBytes(data)
        Dim result As New StringBuilder(maxSize)
        For Each b As Byte In data
            result.Append(chars(b Mod (chars.Length)))
        Next
        Return result.ToString()
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles canbutton.Click
        Me.Close()
        HOME.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles resbutton.Click
        uidtxt.Text = ""
        passtxt.Text = ""
        addcombo.Text = ""
        unametxt.Text = ""
        contxt.Text = ""
        emailtxt.Text = ""
        fnametxt.Text = ""
        lnametxt.Text = ""


    End Sub

    Private Sub regbutton_Click(sender As Object, e As EventArgs) Handles regbutton.Click
        If Len(Trim(fnametxt.Text)) = 0 Then


            MessageBox.Show("Please enter FIRST NAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            fnametxt.Focus()
            Exit Sub
        End If
        If Len(Trim(lnametxt.Text)) = 0 Then
            MessageBox.Show("Please enter LAST NAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lnametxt.Focus()
            Exit Sub
        End If


        If Len(Trim(addcombo.Text)) = 0 Then
            MessageBox.Show("Please enter ADDRESS", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addcombo.Focus()
            Exit Sub
        End If
        If Len(Trim(unametxt.Text)) = 0 Then
            MessageBox.Show("Please enter USER_NAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            unametxt.Focus()
            Exit Sub
        End If


        If Len(Trim(contxt.Text)) = 0 Then
            MessageBox.Show("Please enter user PHONE NO.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            contxt.Focus()
            Exit Sub
        End If

        If Len(Trim(emailtxt.Text)) = 0 Then
            MessageBox.Show("Please enter EMAIL ADDRESS", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            emailtxt.Focus()
            Exit Sub
        End If

        If Len(Trim(passtxt.Text)) = 0 Then
            MessageBox.Show("Please enter PASSWORD", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            passtxt.Focus()
            Exit Sub
        End If
        myconnection = New SqlConnection("Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True")
        myconnection.Open()
        Dim mycommand As New SqlCommand(("SELECT * FROM USER_REG WHERE USERNAME= '" & unametxt.Text & "'"), myconnection)
        Dim dap As New SqlDataAdapter
        Dim ds As New Data.DataSet
        dap.SelectCommand = mycommand
        mycommand.ExecuteNonQuery()
        ds.Clear()
        dap.Fill(ds, "USER_REG")


        If ds.Tables(0).Rows.Count > 0 Then
            MessageBox.Show("USERNAME NOT AVAILABLE")

        ElseIf Len(Trim(contxt.Text)) = 10 Then
            uidtxt.Text = "" & GetUniqueKey(7)
            myconnection = New SqlConnection("Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True")

            myconnection.Open()
            Dim cb As String = "insert into USER_REG ([USER_ID],[FIRST_NAME],[LAST_NAME],[ADDRESS],[PHONE_NO],[EMAIL_ID],[USERNAME],[PASSWORD]) values ('" & uidtxt.Text & "','" & fnametxt.Text & "','" & lnametxt.Text & "','" & addcombo.Text & "','" & contxt.Text & "','" & emailtxt.Text & "','" & unametxt.Text & "','" & passtxt.Text & "') "
            mycommand = New SqlCommand(cb)
            mycommand.Connection = myconnection
            mycommand.ExecuteNonQuery()
            myconnection.Close()

            MessageBox.Show("THANKYOU FOR REGISTERING" & ra)
            myconnection.Close()
        End If

        Me.ResetText()
        Me.Close()
        HOME.Show()

    End Sub
End Class
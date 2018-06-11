Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class HOME

    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer
    Private Sub loginbutton_Click(sender As Object, e As EventArgs) Handles loginbutton.Click

        myconnection = New SqlConnection("Data Source=LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True")
        mycommand = New SqlCommand(" Select * from USER_REG where USERNAME= @USERNAME AND PASSWORD = @PASSWORD", myconnection)
        mycommand.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = unametext.Text
        mycommand.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = passstext.Text

        Dim adapter As New SqlDataAdapter(mycommand)
        Dim table As New DataTable()
        adapter.Fill(table)
        If Len(Trim(unametext.Text)) = 0 Then
            MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            unametext.Focus()
            Exit Sub
        End If

        If Len(Trim(passstext.Text)) = 0 Then
            MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            passstext.Focus()
            Exit Sub
        End If

        If unametext.Text = "ADMIN" And passstext.Text = "ADMIN" Then
            Me.Hide()
            Me.ResetText()
            ADMIN_HOME.Show()

        ElseIf table.Rows.Count() <= 0 Then
            MessageBox.Show("Username or Password are invalid")

        Else
            MessageBox.Show("Login Successfull")

            Me.Hide()
            USER_HOME.Show()
        End If

    End Sub

    Private Sub resetbutton_Click(sender As Object, e As EventArgs) Handles resetbutton.Click
        unametext.Text = "" And
           passstext.Text = ""
    End Sub

    Private Sub signupbutton_Click(sender As Object, e As EventArgs) Handles signupbutton.Click
        USER_REG.Show()
    End Sub
End Class

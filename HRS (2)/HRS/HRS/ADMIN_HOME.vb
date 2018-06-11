Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class ADMIN_HOME

    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer

    Dim cs As String = "Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True"


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles resetbutton.Click
        rtypetxt.Text = ""
        rnotxt.Text = ""
        ratetxt.Text = ""
    End Sub

    Private Sub savebutton_Click(sender As Object, e As EventArgs) Handles savebutton.Click
        If Len(Trim(rtypetxt.Text)) = 0 Then


            MessageBox.Show("Please enter Room type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rtypetxt.Focus()
            Exit Sub
        End If
        If Len(Trim(rnotxt.Text)) = 0 Then
            MessageBox.Show("Please enter Room No", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rnotxt.Focus()
            Exit Sub
        End If

        myconnection = New SqlConnection("Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True")

        myconnection.Open()
        Dim cb As String = "insert into ROOM_DETAILS ([ROOM_TYPE],[ROOM_NO],[RATE],[AVAILABILITY]) values ('" & rtypetxt.Text & "','" & rnotxt.Text & "','" & ratetxt.Text & "','AVAILABLE') "
        mycommand = New SqlCommand(cb)
        mycommand.Connection = myconnection
        mycommand.ExecuteNonQuery()
        myconnection.Close()
        MessageBox.Show("ROOM ADDED SUCCESSFULLY" & ra)
        myconnection.Close()
        Me.Show()
        Dim str As String = "Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim com As String = "select * from ROOM_DETAILS"
        Dim adpt As New SqlDataAdapter(com, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "ROOM_DETAILS")
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub ADMIN_HOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = TimeOfDay.ToString("H:mm:ss")

        Dim str As String = "Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim com As String = "select * from ROOM_DETAILS"
        Dim adpt As New SqlDataAdapter(com, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "ROOM_DETAILS")
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub rtypetxt_textchamged(sender As Object, e As EventArgs) Handles rtypetxt.SelectedIndexChanged

        If rtypetxt.Text = "NON/AC DELUXE" Then
            ratetxt.Text = "100"
        End If

        If rtypetxt.Text = "A/C DELUXE" Then
            ratetxt.Text = "200"
        End If

        If rtypetxt.Text = "QUEENS SUITE" Then
            ratetxt.Text = "400"
        End If

        If rtypetxt.Text = "KINGS SUITE" Then
            ratetxt.Text = "800"
        End If

        If rtypetxt.Text = "PRESIDENTIAL SUITE" Then
            ratetxt.Text = "1000"
        End If
    End Sub

    Private Sub BOOKINGHISTORYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOOKINGHISTORYToolStripMenuItem.Click

    End Sub

    Private Sub RESTAURANTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESTAURANTToolStripMenuItem.Click
        GUEST_LIST.Show()
    End Sub
End Class
Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class USER_BOOKINGS
    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer

    Dim cs As String = "Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True"
    Private Sub USER_BOOKINGS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim com As String = "select * from BOOKING1 where USERNAME='" & USER_HOME.Label1.Text & "'"
        Dim adpt As New SqlDataAdapter(com, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "BOOKING1")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
        Me.Hide()
        Me.Show()
        Me.unametxt.Text = dr.Cells(16).Value.ToString()
        Me.rnotxt.Text = dr.Cells(6).Value.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myconnection = New SqlConnection("Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True")

        myconnection.Open()

        Dim cb1 As String = "DELETE FROM BOOKING1 WHERE [USERNAME]= '" & unametxt.Text & "'"
        mycommand = New SqlCommand(cb1)
        mycommand.Connection = myconnection
        mycommand.ExecuteNonQuery()

        myconnection.Close()
        myconnection = New SqlConnection("Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True")

        myconnection.Open()

        Dim cb2 As String = "UPDATE ROOM_DETAILS SET [AVAILABILITY]='AVAILABLE'WHERE [ROOM_NO]= '" & rnotxt.Text & "'"
        mycommand = New SqlCommand(cb2)
        mycommand.Connection = myconnection
        mycommand.ExecuteNonQuery()
        MessageBox.Show("RESERVATION CANCELLED SUCCESSFULLY" & ra)
        myconnection.Close()

        Me.Refresh()

        Me.Refresh()
        Dim str As String = "Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim com As String = "select * from BOOKING1 where USERNAME='" & USER_HOME.Label1.Text & "'"
        Dim adpt As New SqlDataAdapter(com, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "BOOKING1")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class
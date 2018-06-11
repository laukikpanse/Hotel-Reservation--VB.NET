Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions
Public Class GUEST_LIST
    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer

    Dim cs As String = "Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True"
    Private Sub GUEST_LIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim com As String = "select * from BOOKING1"
        Dim adpt As New SqlDataAdapter(com, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "BOOKING1")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class
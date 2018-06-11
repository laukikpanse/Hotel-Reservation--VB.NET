Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions


Public Class USER_HOME
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

    Private Sub USER_HOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = HOME.unametext.Text



        Dim str As String = "Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim com As String = "select * from ROOM_DETAILS WHERE AVAILABILITY='AVAILABLE'"
        Dim adpt As New SqlDataAdapter(com, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "ROOM_DETAILS")
        DataGridView1.DataSource = ds.Tables(0)


        Dim str1 As String = "Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True"
        Dim con1 As New SqlConnection(str1)
        Dim com1 As String = "select * from USER_REG where USERNAME='" & Label1.Text & "'"
        Dim adpt1 As New SqlDataAdapter(com1, con1)
        Dim ds1 As New DataSet()
        adpt1.Fill(ds1, "USER_REG")
        DataGridView2.DataSource = ds1.Tables(0)



    End Sub

    Private Sub importbutton_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub DataGridView2_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.RowHeaderMouseClick
        Dim dr As DataGridViewRow = DataGridView2.SelectedRows(0)
        Me.Hide()
        Me.Show()
        Me.fnametext.Text = dr.Cells(1).Value.ToString()
        Me.lnametext.Text = dr.Cells(2).Value.ToString()
        Me.addtext.Text = dr.Cells(3).Value.ToString()
        Me.context.Text = dr.Cells(4).Value.ToString()
        Me.emailtxt.Text = dr.Cells(5).Value.ToString()
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
        Me.Hide()
        Me.Show()
        Me.rtypetxt.Text = dr.Cells(0).Value.ToString()
        Me.rnotxt.Text = dr.Cells(1).Value.ToString()
        Me.ratetxt.Text = dr.Cells(2).Value.ToString()

    End Sub

    Private Sub guesttxt_textchanged(sender As Object, e As EventArgs) Handles guesttxt.TextChanged
        If Len(Trim(cintxt.Text)) = 0 Then
            MessageBox.Show("Please Select Check-In Date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cintxt.Focus()
            Exit Sub
        End If
        If Len(Trim(couttxt.Text)) = 0 Then
            MessageBox.Show("Please Select Check-Out Date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            couttxt.Focus()
            Exit Sub
        End If

        If (guesttxt.Text > 2) And rtypetxt.Text = "NON/AC DELUXE" Then
            extgtxt.Text = (guesttxt.Text - 2)

            totaltxt.Text = (ratetxt.Text * daytxt.Text)
            taxtxt.Text = (totaltxt.Text * 0.07)
            guestchrgtxt.Text = (extgtxt.Text * 50)
            nettxt.Text = (totaltxt.Text + +taxtxt.Text + +guestchrgtxt.Text)

        ElseIf guesttxt.Text = "2" And rtypetxt.Text = "A/C DELUXE" Then
            extgtxt.Text = (guesttxt.Text - 2)
            totaltxt.Text = (ratetxt.Text * daytxt.Text)
            taxtxt.Text = (totaltxt.Text * 0.07)
            guestchrgtxt.Text = (extgtxt.Text * 50)
            nettxt.Text = (totaltxt.Text + +taxtxt.Text + +guestchrgtxt.Text)

        Else
            totaltxt.Text = (ratetxt.Text * daytxt.Text)
            taxtxt.Text = (totaltxt.Text * 0.07)
            nettxt.Text = (totaltxt.Text + +taxtxt.Text)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles daytxt.TextChanged

    End Sub

    Private Sub couttxt_ValueChanged(sender As Object, e As EventArgs) Handles couttxt.ValueChanged
        Dim t1 As DateTime = DateTime.Parse(cintxt.Text)
        Dim t2 As DateTime = DateTime.Parse(couttxt.Text)
        Dim ts As TimeSpan = t1.Subtract(t2)

        daytxt.Text = DateDiff(DateInterval.Day, t1, t2).ToString

    End Sub

    Private Sub guesttxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles guesttxt.SelectedIndexChanged

    End Sub

    Private Sub resbutton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub confbutton_Click(sender As Object, e As EventArgs) Handles confbutton.Click
        If Len(Trim(fnametext.Text)) = 0 Then


            MessageBox.Show("Please select your name first", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            fnametext.Focus()
            Exit Sub
        End If
        If Len(Trim(rtypetxt.Text)) = 0 Then
            MessageBox.Show("Please select ROOM type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rtypetxt.Focus()
            Exit Sub
        End If


        If Len(Trim(cintxt.Text)) = 0 Then
            MessageBox.Show("Please Select Check-In Date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cintxt.Focus()
            Exit Sub
        End If
        If Len(Trim(couttxt.Text)) = 0 Then
            MessageBox.Show("Please Select Check-Out Date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            couttxt.Focus()
            Exit Sub
        End If


        If Len(Trim(guesttxt.Text)) = 0 Then
            MessageBox.Show("Please select no. of Guests", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            guesttxt.Focus()
            Exit Sub
        End If

        myconnection = New SqlConnection("Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True")


        myconnection.Open()
        Dim cb As String = "insert into BOOKING ([FIRST_NAME],[LAST_NAME],[ADDRESS],[EMAIL_ID],[CONTACT],[ROOM_TYPE],[ROOM_NO],[CHECKIN],[CHECKOUT],[TOTAL_GUESTS],[EXTRAGUESTS],[TOTAL_DAY],[TOTAL],[GUESTCHARGE],[TAX],[NETTOTAL],[USERNAME]) values ('" & fnametext.Text & "','" & lnametext.Text & "','" & addtext.Text & "','" & emailtxt.Text & "','" & context.Text & "','" & rtypetxt.Text & "','" & rnotxt.Text & "','" & cintxt.Text & "','" & couttxt.Text & "','" & guesttxt.Text & "','" & extgtxt.Text & "','" & daytxt.Text & "','" & totaltxt.Text & "','" & guestchrgtxt.Text & "','" & taxtxt.Text & "','" & nettxt.Text & "','" & Label1.Text & "') "
        mycommand = New SqlCommand(cb)
        mycommand.Connection = myconnection
        mycommand.ExecuteNonQuery()
        myconnection.Close()
        MessageBox.Show("RESERVATION DONE SUCCESSFULLY" & ra)
        myconnection.Close()



        myconnection = New SqlConnection("Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True")

        myconnection.Open()

        Dim cb1 As String = "UPDATE ROOM_DETAILS SET [AVAILABILITY]='RESERVED'WHERE [ROOM_NO]= '" & rnotxt.Text & "'"
        mycommand = New SqlCommand(cb1)
        mycommand.Connection = myconnection
        mycommand.ExecuteNonQuery()

        myconnection.Close()

        Me.Refresh()

        myconnection = New SqlConnection("Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True")


        myconnection.Open()
        Dim cb2 As String = "insert into BOOKING1 ([FIRST_NAME],[LAST_NAME],[ADDRESS],[EMAIL_ID],[CONTACT],[ROOM_TYPE],[ROOM_NO],[CHECKIN],[CHECKOUT],[TOTAL_GUESTS],[EXTRA_GUESTS],[TOTAL_DAY],[TOTAL],[GUESTCHARGE],[TAX],[NETTOTAL],[USERNAME]) values ('" & fnametext.Text & "','" & lnametext.Text & "','" & addtext.Text & "','" & emailtxt.Text & "','" & context.Text & "','" & rtypetxt.Text & "','" & rnotxt.Text & "','" & cintxt.Text & "','" & couttxt.Text & "','" & guesttxt.Text & "','" & extgtxt.Text & "','" & daytxt.Text & "','" & totaltxt.Text & "','" & guestchrgtxt.Text & "','" & taxtxt.Text & "','" & nettxt.Text & "','" & Label1.Text & "') "
        mycommand = New SqlCommand(cb2)
        mycommand.Connection = myconnection
        mycommand.ExecuteNonQuery()
        myconnection.Close()


        Me.Show()

        Dim str As String = "Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim com As String = "select * from ROOM_DETAILS WHERE AVAILABILITY='AVAILABLE'"
        Dim adpt As New SqlDataAdapter(com, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "ROOM_DETAILS")
        DataGridView1.DataSource = ds.Tables(0)


        Dim str1 As String = "Data Source= LAUKIK-PC\MSSQLSERVER1;Initial Catalog=HRS;Integrated Security=True"
        Dim con1 As New SqlConnection(str1)
        Dim com1 As String = "select * from USER_REG where USERNAME='" & Label1.Text & "'"
        Dim adpt1 As New SqlDataAdapter(com1, con1)
        Dim ds1 As New DataSet()
        adpt1.Fill(ds1, "USER_REG")
        DataGridView2.DataSource = ds1.Tables(0)



    End Sub

    Private Sub SEERESERVATIONSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SEERESERVATIONSToolStripMenuItem.Click
        USER_BOOKINGS.Show()
    End Sub
    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Me.Show()
    End Sub
End Class
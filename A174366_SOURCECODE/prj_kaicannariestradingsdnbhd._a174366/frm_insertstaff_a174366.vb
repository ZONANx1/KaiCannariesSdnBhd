Public Class frm_insertstaff_a174366
    Private Sub frm_insertstaff_a174366_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A174366"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_insertstaff.DataSource = mydatatable

    End Sub
    Private Sub clear_fields()

        txt_insertstaff_id.Text = ""
        txt_insertstaff_name.Text = ""
        txt_insertstaff_num.Text = ""
        txt_insertstaff_email.Text = ""

    End Sub

    Private Sub btn_insertstaff_Click(sender As Object, e As EventArgs) Handles btn_insertstaff.Click

        Dim mysql As String = "INSERT INTO TBL_STAFF_A174366 VALUES ('" & txt_insertstaff_id.Text & "','" & txt_insertstaff_name.Text & "'," & txt_insertstaff_num.Text & ",'" & txt_insertstaff_email.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()


            refresh_grid()
            clear_fields()
        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try




    End Sub

    Private Sub btn_backinsert_staff_Click(sender As Object, e As EventArgs) Handles btn_backinsert_staff.Click
        frm_mainmenu_a174366.Show()
        Me.Hide()
    End Sub
End Class
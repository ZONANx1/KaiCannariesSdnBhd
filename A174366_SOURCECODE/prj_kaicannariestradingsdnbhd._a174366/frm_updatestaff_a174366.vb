Public Class frm_updatestaff_a174366
    Dim current_code As String
    Private Sub frm_updatestaff_a174366_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()
    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A174366"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_updatestaff.DataSource = mydatatable

    End Sub
    Private Sub clear_fields()
        txt_updatestaff_id.Text = ""
        txt_updatestaff_name.Text = ""
        txt_updatestaff_num.Text = ""
        txt_updatestaff_email.Text = ""

    End Sub
    Private Sub get_current_code()
        Dim current_row As Integer = grd_updatestaff.CurrentRow.Index
        current_code = grd_updatestaff(0, current_row).Value
        txt_updatestaff_id.Text = current_code
        txt_updatestaff_name.Text = grd_updatestaff(1, current_row).Value
        txt_updatestaff_num.Text = grd_updatestaff(2, current_row).Value
        txt_updatestaff_email.Text = grd_updatestaff(3, current_row).Value
    End Sub

    Private Sub grd_updatestaff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_updatestaff.CellClick
        get_current_code()
    End Sub

    Private Sub btn_updatestaff_Click(sender As Object, e As EventArgs) Handles btn_updatestaff.Click
        run_sql_command("UPDATE TBL_STAFF_A174366 SET FLD_STAFF_NAME ='" &
        txt_updatestaff_name.Text & "' WHERE FLD_STAFF_ID ='" & current_code & "'")

        run_sql_command("UPDATE TBL_STAFF_A174366 SET FLD_STAFF_NUM ='" &
        txt_updatestaff_num.Text & "' WHERE FLD_STAFF_ID ='" & current_code & "'")

        run_sql_command("UPDATE TBL_STAFF_A174366 SET FLD_STAFF_EMAIL ='" &
        txt_updatestaff_email.Text & "' WHERE FLD_STAFF_ID ='" & current_code & "'")
        Beep()
        MsgBox("You have successfully updated the staff """ & current_code & """.")
        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub btn_deletestaff_Click(sender As Object, e As EventArgs) Handles btn_deletestaff.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the staff """ & current_code & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_STAFF_A174366 WHERE FLD_STAFF_ID ='" & current_code & "'")

            Beep()
            MsgBox("The staff """ & current_code & """ has been successfully deleted.")
            refresh_grid()
            clear_fields()
            get_current_code()

        End If
    End Sub

    Private Sub btn_backupdate_staff_Click(sender As Object, e As EventArgs) Handles btn_backupdate_staff.Click
        frm_mainmenu_a174366.Show()
        Me.Hide()
    End Sub
End Class
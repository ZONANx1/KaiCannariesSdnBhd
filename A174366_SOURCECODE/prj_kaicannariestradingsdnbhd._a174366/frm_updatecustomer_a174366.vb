Public Class frm_updatecustomer_a174366
    Dim current_code As String
    Private Sub frm_updatecustomer_a174366_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()
    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A174366"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_updatecustomer.DataSource = mydatatable

    End Sub
    Private Sub clear_fields()
        txt_updatecustomer_id.Text = ""
        txt_updatecustomer_name.Text = ""
        txt_updatecustomer_num.Text = ""
        txt_updatecustomer_email.Text = ""

    End Sub
    Private Sub get_current_code()
        Dim current_row As Integer = grd_updatecustomer.CurrentRow.Index
        current_code = grd_updatecustomer(0, current_row).Value
        txt_updatecustomer_id.Text = current_code
        txt_updatecustomer_name.Text = grd_updatecustomer(1, current_row).Value
        txt_updatecustomer_num.Text = grd_updatecustomer(2, current_row).Value
        txt_updatecustomer_email.Text = grd_updatecustomer(3, current_row).Value
    End Sub

    Private Sub grd_updatecustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_updatecustomer.CellClick
        get_current_code()
    End Sub

    Private Sub btn_updatecustomer_Click(sender As Object, e As EventArgs) Handles btn_updatecustomer.Click
        run_sql_command("UPDATE TBL_CUSTOMER_A174366 SET FLD_CUSTOMER_NAME ='" &
        txt_updatecustomer_name.Text & "' WHERE FLD_CUSTOMER_ID ='" & current_code & "'")

        run_sql_command("UPDATE TBL_CUSTOMER_A174366 SET FLD_CUSTOMER_NUM ='" &
        txt_updatecustomer_num.Text & "' WHERE FLD_CUSTOMER_ID ='" & current_code & "'")

        run_sql_command("UPDATE TBL_CUSTOMER_A174366 SET FLD_CUSTOMER_EMAIL ='" &
        txt_updatecustomer_email.Text & "' WHERE FLD_CUSTOMER_ID ='" & current_code & "'")
        Beep()
        MsgBox("You have successfully updated the customer """ & current_code & """.")
        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub btn_deletecustomer_Click(sender As Object, e As EventArgs) Handles btn_deletecustomer.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the customer """ & current_code & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_CUSTOMER_A174366 WHERE FLD_CUSTOMER_ID ='" & current_code & "'")

            Beep()
            MsgBox("The customer """ & current_code & """ has been successfully deleted.")
            refresh_grid()
            clear_fields()
            get_current_code()

        End If
    End Sub

    Private Sub btn_backupdate_customer_Click(sender As Object, e As EventArgs) Handles btn_backupdate_customer.Click
        frm_mainmenu_a174366.Show()
        Me.Hide()
    End Sub
End Class

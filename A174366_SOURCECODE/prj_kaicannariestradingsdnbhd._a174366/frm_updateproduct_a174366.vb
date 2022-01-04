Public Class frm_updateproduct_a174366
    Dim current_code As String
    Private Sub frm_updateproduct_a174366_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()
    End Sub
    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A174366"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_updateproduct.DataSource = mydatatable

    End Sub
    Private Sub clear_fields()
        txt_updateproduct_id.Text = ""
        txt_updateproduct_name.Text = ""
        txt_updateprice.Text = ""
        txt_updatebrand.Text = ""
        txt_updatelabelled.Text = ""
        txt_updatenet_weight.Text = ""
        txt_updatequantity.Text = ""
    End Sub
    Private Sub get_current_code()
        Dim current_row As Integer = grd_updateproduct.CurrentRow.Index
        current_code = grd_updateproduct(0, current_row).Value
        txt_updateproduct_id.Text = current_code
        txt_updateproduct_name.Text = grd_updateproduct(1, current_row).Value
        txt_updateprice.Text = grd_updateproduct(2, current_row).Value
        txt_updatebrand.Text = grd_updateproduct(3, current_row).Value
        txt_updatelabelled.Text = grd_updateproduct(4, current_row).Value
        txt_updatenet_weight.Text = grd_updateproduct(5, current_row).Value
        txt_updatequantity.Text = grd_updateproduct(6, current_row).Value
    End Sub

    Private Sub grd_updateproduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_updateproduct.CellClick
        get_current_code()
    End Sub

    Private Sub btn_updateproduct_Click(sender As Object, e As EventArgs) Handles btn_updateproduct.Click
        run_sql_command("UPDATE TBL_PRODUCTS_A174366 SET FLD_PRODUCT_NAME='" &
        txt_updateproduct_name.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")

        run_sql_command("UPDATE TBL_PRODUCTS_A174366 SET FLD_PRICE=" &
        txt_updateprice.Text & " WHERE FLD_PRODUCT_ID='" & current_code & "'")

        run_sql_command("UPDATE TBL_PRODUCTS_A174366 SET FLD_BRAND='" &
        txt_updatebrand.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")

        run_sql_command("UPDATE TBL_PRODUCTS_A174366 SET FLD_LABELLED='" &
        txt_updatelabelled.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")

        run_sql_command("UPDATE TBL_PRODUCTS_A174366 SET FLD_NET_WEIGHT='" &
        txt_updatenet_weight.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")

        run_sql_command("UPDATE TBL_PRODUCTS_A174366 SET FLD_QUANTITY='" &
        txt_updatequantity.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")
        Beep()
        MsgBox("You have successfully updated the product """ & current_code & """.")
        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub btn_deleteproduct_Click(sender As Object, e As EventArgs) Handles btn_deleteproduct.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & current_code & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_PRODUCTS_A174366 WHERE FLD_PRODUCT_ID ='" & current_code & "'")

            Beep()
            MsgBox("The product """ & current_code & """ has been successfully deleted.")
            refresh_grid()
            clear_fields()
            get_current_code()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_backupdate_product.Click
        frm_mainmenu_a174366.Show()
        Me.Hide()
    End Sub
End Class
Public Class frm_mainmenu_a174366
    Private Sub frm_mainmenu_a174366_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim current_date As String = Date.Now
        lbl_date.Text = current_date
    End Sub

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        frm_product_a174366.Show()
        Me.Hide()

    End Sub
    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        frm_customer_a174366.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exitmenu_Click(sender As Object, e As EventArgs) Handles btn_exitmenu.Click
        End
    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_staff_a174366.Show()
        Me.Hide()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_order_a174366.Show()
        Me.Hide()
    End Sub

    Private Sub btn_catalogue_Click(sender As Object, e As EventArgs) Handles btn_catalogue.Click
        frm_productdetails_a174366.Show()
        Me.Hide()
    End Sub

    Private Sub btn_insertmainmenu_product_Click(sender As Object, e As EventArgs) Handles btn_insertmainmenu_product.Click
        frm_insertproduct_a174366.Show()
        Me.Hide()
    End Sub

    Private Sub btn_updatemainmenu_product_Click(sender As Object, e As EventArgs) Handles btn_updatemainmenu_product.Click
        frm_updateproduct_a174366.Show()
        Me.Hide()
    End Sub

    Private Sub btn_insertmainmenu_customer_Click(sender As Object, e As EventArgs) Handles btn_insertmainmenu_customer.Click
        frm_insertcustomer_a174366.Show()
        Me.Hide()
    End Sub

    Private Sub btn_updatemainmenu_customer_Click(sender As Object, e As EventArgs) Handles btn_updatemainmenu_customer.Click
        frm_updatecustomer_a174366.Show()
        Me.Hide()
    End Sub

    Private Sub btn_insertmainmenu_staff_Click(sender As Object, e As EventArgs) Handles btn_insertmainmenu_staff.Click
        frm_insertstaff_a174366.Show()
        Me.Hide()
    End Sub

    Private Sub btn_updatemainmenu_staff_Click(sender As Object, e As EventArgs) Handles btn_updatemainmenu_staff.Click
        frm_updatestaff_a174366.Show()
        Me.Hide()
    End Sub

    Private Sub btn_makeorder_Click(sender As Object, e As EventArgs) Handles btn_makeorder.Click
        frm_makeorder_a174366.Show()
        Me.Hide()
    End Sub

    Private Sub btn_orderdata_Click(sender As Object, e As EventArgs) Handles btn_orderdata.Click
        frm_orderdata_a174366.Show()
        Me.Hide()
    End Sub
End Class
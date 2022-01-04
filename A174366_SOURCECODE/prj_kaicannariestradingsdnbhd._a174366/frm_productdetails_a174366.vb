Public Class frm_productdetails_a174366
    Private Sub frm_productdetails_a174366_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A174366"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_product_id.DataSource = mydatatable
        lst_product_id.DisplayMember = "FLD_PRODUCT_ID"
        refresh_text(lst_product_id.Text)

    End Sub
    Private Sub refresh_text(matric As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A174366 WHERE FLD_PRODUCT_ID='" &
        matric & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        txt_product_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_product_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        txt_labelled.Text = mydatatable.Rows(0).Item("FLD_LABELLED")
        txt_net_weight.Text = mydatatable.Rows(0).Item("FLD_NET_WEIGHT")
        txt_quantity.Text = mydatatable.Rows(0).Item("FLD_QUANTITY")
        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_product_id.Text & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub

    Private Sub lst_product_id_MouseClick(sender As Object, e As EventArgs) Handles lst_product_id.MouseClick

        refresh_text(lst_product_id.Text)

    End Sub

    Private Sub btn_backproductdetails_Click(sender As Object, e As EventArgs) Handles btn_backproductdetails.Click
        frm_mainmenu_a174366.Show()
        Me.Hide()
    End Sub


End Class
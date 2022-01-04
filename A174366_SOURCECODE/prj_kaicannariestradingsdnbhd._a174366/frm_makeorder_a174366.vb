Public Class frm_makeorder_a174366

    Private Sub frm_productdetails_a174366_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_date.Text = Date.Today
        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A174366"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_makeorder_id.DataSource = mydatatable
        lst_makeorder_id.DisplayMember = "FLD_PRODUCT_ID"
        '' cust.Text = generate_customer()
        staffid.Text = generate_staff()
        orderid.Text = generate_order()

        cust()
        staff()

        Dim data As DataTable = run_sql_query("SELECT * FROM TBL_TRANSACTIONS_A174366")
        '' Dim df As Integer = data.Columns.Count
        ''MsgBox(df)
        grdcart.ColumnCount = data.Columns.Count
        ''MsgBox(grdcart.Columns.Count)
        For i = 0 To data.Columns.Count - 1
            grdcart.Columns(i).HeaderText = data.Columns(i).ColumnName
        Next
        refresh_text(lst_makeorder_id.Text)
        cartprice.Text = 0

    End Sub
    Private Sub refresh_text(matric As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A174366 WHERE FLD_PRODUCT_ID='" &
        matric & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        txt_makeorder_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_makeorderprice.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_makeorderbrand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        txt_makeorderlabelled.Text = mydatatable.Rows(0).Item("FLD_LABELLED")
        txt_makeordernet_weight.Text = mydatatable.Rows(0).Item("FLD_NET_WEIGHT")


        quantity.Items.Clear()
        quantity.Items.AddRange(Enumerable.Range(1, mydatatable.Rows(0).Item("FLD_QUANTITY")).Select(Function(s) s.ToString()).ToArray())
        quantity.SelectedIndex = 0
        Try
            pic_makeorder.BackgroundImage = Image.FromFile("pictures/" & lst_makeorder_id.Text & ".jpg")
        Catch ex As Exception
            pic_makeorder.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub

    Private Sub lst_makeorder_id_MouseClick(sender As Object, e As EventArgs) Handles lst_makeorder_id.MouseClick

        refresh_text(lst_makeorder_id.Text)

    End Sub

    Private Function generate_order() As String
        Try
            Dim lastmatric As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTMATRIC FROM TBL_ORDERS_A174366").Rows(0).Item("LASTMATRIC")
            '' MsgBox(lastmatric)
            Dim newmatric As String = "O" & (Mid(lastmatric, 2) + 1).ToString("000")
            Return newmatric

        Catch ex As Exception
            Return "O001"
        End Try
    End Function

    Private Sub staff()
        Dim mysql As String = "SELECT FLD_STAFF_ID FROM TBL_STAFF_A174366"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        staffid.DataSource = mydatatable
        staffid.DisplayMember = "FLD_STAFF_ID"
    End Sub

    Private Sub cust()
        Dim mysql As String = "SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMER_A174366"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        customer.DataSource = mydatatable
        customer.DisplayMember = "FLD_CUSTOMER_ID"

    End Sub





    Private Function generate_staff() As String
        '' Dim rn As Integer = System.Random
        Dim rdm As New Random()
        Dim data As DataTable = run_sql_query("SELECT FLD_STAFF_ID AS RN FROM TBL_STAFF_A174366 ORDER BY RND()")
        Dim rands As String = data.Rows(rdm.Next(0, data.Rows.Count)).Item("RN")
        '' MsgBox(lastmatric)
        Return rands
    End Function

    Private Sub lst_makeorder_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_makeorder_id.SelectedIndexChanged
        Try
            refresh_text(lst_makeorder_id.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_backmakeorder_Click(sender As Object, e As EventArgs) Handles btn_backmakeorder.Click
        frm_mainmenu_a174366.Show()
        Me.Close()
    End Sub

    Private Sub lv_Click(sender As Object, e As EventArgs) Handles lv.Click
        For Each row As DataGridViewRow In grdcart.Rows
            If (row.Cells(0).Value = orderid.Text And row.Cells(1).Value = lst_makeorder_id.Text) Then
                row.Cells(2).Value = Val(row.Cells(2).Value) + quantity.Text
                row.Cells(3).Value = row.Cells(2).Value * txt_makeorderprice.Text
                cartprice.Text = Val(totalprice.Text) + Val(cartprice.Text)
                Return
            Else

            End If
        Next
        grdcart.Rows.Add(orderid.Text, lst_makeorder_id.Text, quantity.Text, totalprice.Text)
        cartprice.Text = Val(totalprice.Text) + Val(cartprice.Text)
    End Sub

    Private Sub quantity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles quantity.SelectedIndexChanged
        Try
            Dim qu As Decimal = (quantity.Text)
            Dim pr As Decimal = (txt_makeorderprice.Text)
            totalprice.Text = qu * pr
        Catch ex As Exception

        End Try
    End Sub

    Private Sub emove_Click(sender As Object, e As EventArgs) Handles emove.Click
        Try
            Dim i As Integer = grdcart.SelectedRows(0).Index
            cartprice.Text = Val(cartprice.Text) - Val(grdcart.Rows(i).Cells(3).Value)
            grdcart.Rows.RemoveAt(i)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub customer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles customer.SelectedIndexChanged
        grdcart.Rows.Clear()
        lst_makeorder_id.SelectedIndex = 0
        cartprice.Text = ""
    End Sub

    Private Sub checkout_Click(sender As Object, e As EventArgs) Handles checkout.Click
        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()
        mytransaction = myconnection2.BeginTransaction
        Try
            Dim orderids As String = orderid.Text
            Dim orderdate As String = DateTime.Now.ToString("dd MMMM yyyy, hh:mm dddd")
            Dim customerids As String = customer.Text
            Dim staffids As String = staffid.Text

            Dim mysqls As String = "INSERT INTO TBL_ORDERS_A174366 VALUES ('" & orderids & "', '" & orderdate & "', '" & customerids & "', '" & staffids & "')"
            Dim mywriters As New OleDb.OleDbCommand(mysqls, myconnection2,
                mytransaction)
            mywriters.ExecuteNonQuery()

            For i As Integer = 0 To grdcart.RowCount - 1
                Dim orderidss As String = grdcart(0, i).Value
                Dim productids As String = grdcart(1, i).Value
                Dim quantitys As String = grdcart(2, i).Value
                Dim tprices As String = grdcart(3, i).Value

                Dim mysql As String = "INSERT INTO TBL_TRANSACTIONS_A174366 VALUES ('" & orderidss & "', '" & productids & "', '" & quantitys & "', '" & tprices & "')"
                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2,
                mytransaction)
                mywriter.ExecuteNonQuery()

            Next

            Beep()
            If (grdcart.Rows.Count = 0) Then
                MessageBox.Show("Please Add Item To Cart", "Checkout")
            Else
                mytransaction.Commit()
                MessageBox.Show("Transaction successful!", "Checkout")
                staffid.Text = generate_staff()
                orderid.Text = generate_order()

                lst_makeorder_id.SelectedIndex = 0
                cartprice.Text = ""
            End If
            grdcart.Rows.Clear()
            myconnection2.Close()

        Catch ex As Exception
            Beep()
            ' MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)
            MessageBox.Show("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message, "Checkout")

            mytransaction.Rollback()
            myconnection2.Close()
        End Try
    End Sub


End Class
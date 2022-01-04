Public Class frm_orderdata_a174366

    Dim Totals As Decimal = 0
    Private Sub frm_orderdata_a174366_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()

        DisplayInvois("O001")


        updates(lst_order_id.Text)
    End Sub

    Private Sub refresh_grid()
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_KAICANNARIESTRADINGSDNBHD_A174366.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_ORDERS_A174366 ORDER BY FLD_ORDER_ID ASC "
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_order_id.DataSource = mydatatable
        lst_order_id.DisplayMember = "FLD_ORDER_ID"

    End Sub

    Private Sub lst_order_id_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_order_id.MouseClick

        DisplayInvois(lst_order_id.Text)

    End Sub
    Private Sub updates(ids As String)

    End Sub

    Private Sub DisplayInvois(orderID As String)

        Dim mysql As String = "SELECT * FROM TBL_ORDERS_A174366 WHERE FLD_ORDER_ID='" & orderID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        For row As Integer = 0 To Me.grd_order.RowCount - 1
            For Each rows As DataGridViewRow In grd_order.Rows
                grd_order.Rows.Remove(rows)
            Next
            Totals = 0
        Next
        lbl_orderID.Text = orderID
        lbl_customerID.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_ID")
        lbl_staffID.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")
        lbl_date.Text = mydatatable.Rows(0).Item("FLD_ORDER_DATE")

        Dim mysql2 As String = "SELECT * FROM TBL_TRANSACTIONS_A174366 WHERE FLD_ORDER_ID='" & orderID & "'"
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
        myreader2.Fill(mydatatable2)
        Dim totalrow As String = run_sql_query("SELECT COUNT (*) AS TOTALROW FROM TBL_TRANSACTIONS_A174366 WHERE FLD_ORDER_ID='" & orderID & "'").Rows(0).Item("TOTALROW")
        Dim totalrowcount As Integer = totalrow


        For i As Integer = 0 To totalrowcount - 1
            'Dim PRODUCTID As String = mydatatable2.Rows(i).Item("FLD_PRODUCT_ID")
            Dim mysql3 As String = "SELECT * FROM TBL_PRODUCTS_A174366 WHERE FLD_PRODUCT_ID='" & mydatatable2.Rows(i).Item("FLD_PRODUCT_ID") & "'"
            Dim mydatatable3 As New DataTable
            Dim myreader3 As New OleDb.OleDbDataAdapter(mysql3, myconnection)
            myreader3.Fill(mydatatable3)

            Dim PRODUCTNAME As String = mydatatable3.Rows(0).Item("FLD_PRODUCT_NAME")
            Me.grd_order.Rows.Add(PRODUCTNAME, mydatatable2.Rows(i).Item("FLD_QUANTITY"), mydatatable2.Rows(i).Item("FLD_PRICE"))
            CalculatedTotal(mydatatable2.Rows(i).Item("FLD_PRICE"))
        Next

    End Sub

    Private Sub CalculatedTotal(prices As Decimal)

        Dim FinalTotal As Decimal = Totals + prices
        Totals = FinalTotal
        ftotal.Text = Totals

    End Sub

    Private Sub lst_order_id_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            updates(lst_order_id.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_backorderdata_Click(sender As Object, e As EventArgs) Handles btn_backorderdata.Click
        frm_mainmenu_a174366.Show()
    End Sub


End Class
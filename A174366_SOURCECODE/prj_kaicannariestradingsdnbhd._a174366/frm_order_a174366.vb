Public Class frm_order_a174366

    Private Sub frm_order_a174366_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_KAICANNARIESTRADINGSDNBHD_A174366.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_ORDERS_A174366"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_orders.DataSource = mydatatable

    End Sub

    Private Sub btn_backorder_Click(sender As Object, e As EventArgs) Handles btn_backorder.Click

        frm_mainmenu_a174366.Show()
        Me.Hide()

    End Sub


End Class
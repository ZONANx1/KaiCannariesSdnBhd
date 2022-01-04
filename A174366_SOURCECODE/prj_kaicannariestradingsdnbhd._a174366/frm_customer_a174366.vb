Public Class frm_customer_a174366
    Private Sub grd_customers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customers.CellContentClick

    End Sub
    Private Sub frm_customer_a174366_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_KAICANNARIESTRADINGSDNBHD_A174366.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A174366"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customers.DataSource = mydatatable
    End Sub

    Private Sub btn_backcustomer_Click(sender As Object, e As EventArgs) Handles btn_backcustomer.Click
        frm_mainmenu_a174366.Show()
        Me.Hide()
    End Sub
End Class
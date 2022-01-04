Module mod_globals_a174366
    Public myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_KAICANNARIESTRADINGSDNBHD_A174366.accdb;Persist Security Info=False;"
    Public myconnection2 As New OleDb.OleDbConnection(myconnection)

    Public Function run_sql_query(mysql As String) As DataTable
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        Try
            myreader.Fill(mydatatable)
        Catch ex As Exception
            Beep()
            MsgBox("There is no error:" & vbCrLf & vbCrLf & ex.Message)

        End Try

        Return mydatatable
    End Function
    Public Sub run_sql_command(thissql As String)
        Dim mywriter As New OleDb.OleDbCommand(thissql, myconnection2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()
        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf _
            & ex.Message)
            mywriter.Connection.Close()
        End Try
    End Sub
End Module

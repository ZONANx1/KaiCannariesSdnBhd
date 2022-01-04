Public Class frm_insertproduct_a174366
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"
    Private Sub frm_insertproduct_a174366_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grd_insertproduct.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A174366")

        txt_insertproduct_id.Text = generate_matric()

        txt_picture.Text = defaultpicture
        pic_insertproduct.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub

    Private Function generate_matric() As String

        Dim lastmatric As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTMATRIC FROM TBL_PRODUCTS_A174366").Rows(0).Item("LASTMATRIC")



        Dim newmatric As String = "P" & Mid(lastmatric, 2) + 1

        Return newmatric

    End Function

    Private Sub btn_insertproduct_Click(sender As Object, e As EventArgs) Handles btn_insertproduct.Click
        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A174366 VALUES ('" & txt_insertproduct_id.Text & "', '" & txt_insertproduct_name.Text & "', " & txt_insertprice.Text & ", '" & txt_insertbrand.Text & "', '" & txt_insertlabelled.Text & "', '" & txt_insertnet_weight.Text & "', '" & txt_insertquantity.Text & "' )"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_insertproduct_id.Text & ".jpg")

            grd_insertproduct.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A174366")
            txt_insertproduct_id.Text = generate_matric()
            txt_insertproduct_name.Text = ""
            txt_insertprice.Text = ""
            txt_insertbrand.Text = ""
            txt_insertlabelled.Text = ""
            txt_insertnet_weight.Text = ""
            txt_insertquantity.Text = ""
            txt_picture.Text = defaultpicture
            pic_insertproduct.BackgroundImage = Image.FromFile(defaultpicture)

        Catch ex As Exception
            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try
    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click

        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        pic_insertproduct.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_picture.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub btn_back_insertproduct_Click(sender As Object, e As EventArgs) Handles btn_back_insertproduct.Click
        frm_mainmenu_a174366.Show()
        Me.Hide()
    End Sub
End Class
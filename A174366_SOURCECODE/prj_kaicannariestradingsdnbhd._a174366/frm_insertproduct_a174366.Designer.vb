<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertproduct_a174366
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertproduct_a174366))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_back_insertproduct = New System.Windows.Forms.Button()
        Me.lbl_titleinsertproduct = New System.Windows.Forms.Label()
        Me.grd_insertproduct = New System.Windows.Forms.DataGridView()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.pic_insertproduct = New System.Windows.Forms.PictureBox()
        Me.btn_insertproduct = New System.Windows.Forms.Button()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.txt_insertlabelled = New System.Windows.Forms.TextBox()
        Me.txt_insertnet_weight = New System.Windows.Forms.TextBox()
        Me.txt_insertbrand = New System.Windows.Forms.TextBox()
        Me.txt_insertquantity = New System.Windows.Forms.TextBox()
        Me.txt_insertprice = New System.Windows.Forms.TextBox()
        Me.txt_insertproduct_name = New System.Windows.Forms.TextBox()
        Me.txt_insertproduct_id = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.grd_insertproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_insertproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_back_insertproduct)
        Me.Panel1.Controls.Add(Me.lbl_titleinsertproduct)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1182, 45)
        Me.Panel1.TabIndex = 0
        '
        'btn_back_insertproduct
        '
        Me.btn_back_insertproduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_back_insertproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_back_insertproduct.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_insertproduct.ForeColor = System.Drawing.Color.White
        Me.btn_back_insertproduct.Location = New System.Drawing.Point(4, 4)
        Me.btn_back_insertproduct.Name = "btn_back_insertproduct"
        Me.btn_back_insertproduct.Size = New System.Drawing.Size(94, 40)
        Me.btn_back_insertproduct.TabIndex = 1
        Me.btn_back_insertproduct.Text = "Back"
        Me.btn_back_insertproduct.UseVisualStyleBackColor = False
        '
        'lbl_titleinsertproduct
        '
        Me.lbl_titleinsertproduct.AutoSize = True
        Me.lbl_titleinsertproduct.Font = New System.Drawing.Font("Arial Narrow", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titleinsertproduct.ForeColor = System.Drawing.Color.White
        Me.lbl_titleinsertproduct.Location = New System.Drawing.Point(102, 9)
        Me.lbl_titleinsertproduct.Name = "lbl_titleinsertproduct"
        Me.lbl_titleinsertproduct.Size = New System.Drawing.Size(117, 26)
        Me.lbl_titleinsertproduct.TabIndex = 0
        Me.lbl_titleinsertproduct.Text = "Product List"
        '
        'grd_insertproduct
        '
        Me.grd_insertproduct.BackgroundColor = System.Drawing.Color.MistyRose
        Me.grd_insertproduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grd_insertproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_insertproduct.Location = New System.Drawing.Point(2, 47)
        Me.grd_insertproduct.Name = "grd_insertproduct"
        Me.grd_insertproduct.RowHeadersWidth = 51
        Me.grd_insertproduct.RowTemplate.Height = 24
        Me.grd_insertproduct.Size = New System.Drawing.Size(1178, 341)
        Me.grd_insertproduct.TabIndex = 1
        '
        'txt_picture
        '
        Me.txt_picture.Location = New System.Drawing.Point(956, 296)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(175, 22)
        Me.txt_picture.TabIndex = 9
        '
        'pic_insertproduct
        '
        Me.pic_insertproduct.BackColor = System.Drawing.Color.Transparent
        Me.pic_insertproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_insertproduct.Location = New System.Drawing.Point(837, 66)
        Me.pic_insertproduct.Name = "pic_insertproduct"
        Me.pic_insertproduct.Size = New System.Drawing.Size(300, 204)
        Me.pic_insertproduct.TabIndex = 10
        Me.pic_insertproduct.TabStop = False
        '
        'btn_insertproduct
        '
        Me.btn_insertproduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_insertproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_insertproduct.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertproduct.ForeColor = System.Drawing.Color.White
        Me.btn_insertproduct.Location = New System.Drawing.Point(556, 743)
        Me.btn_insertproduct.Name = "btn_insertproduct"
        Me.btn_insertproduct.Size = New System.Drawing.Size(94, 40)
        Me.btn_insertproduct.TabIndex = 11
        Me.btn_insertproduct.Text = "Add"
        Me.btn_insertproduct.UseVisualStyleBackColor = False
        '
        'btn_picture
        '
        Me.btn_picture.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_picture.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_picture.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_picture.ForeColor = System.Drawing.Color.White
        Me.btn_picture.Location = New System.Drawing.Point(846, 285)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(94, 40)
        Me.btn_picture.TabIndex = 12
        Me.btn_picture.Text = "Select"
        Me.btn_picture.UseVisualStyleBackColor = False
        '
        'txt_insertlabelled
        '
        Me.txt_insertlabelled.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_insertlabelled.Location = New System.Drawing.Point(227, 151)
        Me.txt_insertlabelled.Name = "txt_insertlabelled"
        Me.txt_insertlabelled.Size = New System.Drawing.Size(557, 27)
        Me.txt_insertlabelled.TabIndex = 6
        '
        'txt_insertnet_weight
        '
        Me.txt_insertnet_weight.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_insertnet_weight.Location = New System.Drawing.Point(227, 188)
        Me.txt_insertnet_weight.Name = "txt_insertnet_weight"
        Me.txt_insertnet_weight.Size = New System.Drawing.Size(557, 27)
        Me.txt_insertnet_weight.TabIndex = 7
        '
        'txt_insertbrand
        '
        Me.txt_insertbrand.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_insertbrand.Location = New System.Drawing.Point(227, 114)
        Me.txt_insertbrand.Name = "txt_insertbrand"
        Me.txt_insertbrand.Size = New System.Drawing.Size(557, 27)
        Me.txt_insertbrand.TabIndex = 5
        '
        'txt_insertquantity
        '
        Me.txt_insertquantity.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_insertquantity.Location = New System.Drawing.Point(227, 225)
        Me.txt_insertquantity.Name = "txt_insertquantity"
        Me.txt_insertquantity.Size = New System.Drawing.Size(557, 27)
        Me.txt_insertquantity.TabIndex = 8
        '
        'txt_insertprice
        '
        Me.txt_insertprice.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_insertprice.Location = New System.Drawing.Point(227, 77)
        Me.txt_insertprice.Name = "txt_insertprice"
        Me.txt_insertprice.Size = New System.Drawing.Size(557, 27)
        Me.txt_insertprice.TabIndex = 4
        '
        'txt_insertproduct_name
        '
        Me.txt_insertproduct_name.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_insertproduct_name.Location = New System.Drawing.Point(227, 40)
        Me.txt_insertproduct_name.Name = "txt_insertproduct_name"
        Me.txt_insertproduct_name.Size = New System.Drawing.Size(557, 27)
        Me.txt_insertproduct_name.TabIndex = 3
        '
        'txt_insertproduct_id
        '
        Me.txt_insertproduct_id.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_insertproduct_id.Location = New System.Drawing.Point(227, 3)
        Me.txt_insertproduct_id.Name = "txt_insertproduct_id"
        Me.txt_insertproduct_id.Size = New System.Drawing.Size(557, 27)
        Me.txt_insertproduct_id.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.Food_Canned_Background_3
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btn_picture)
        Me.Panel3.Controls.Add(Me.pic_insertproduct)
        Me.Panel3.Controls.Add(Me.txt_picture)
        Me.Panel3.Location = New System.Drawing.Point(2, 392)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1178, 344)
        Me.Panel3.TabIndex = 12
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.RosyBrown
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_insertproduct_id, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_insertproduct_name, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_insertprice, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_insertbrand, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_insertlabelled, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_insertnet_weight, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_insertquantity, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(30, 54)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(787, 264)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.RosyBrown
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Product name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.RosyBrown
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Price :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.RosyBrown
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Brand :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.RosyBrown
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Labelled :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.RosyBrown
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Net weight : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.RosyBrown
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 222)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Quantity :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.RosyBrown
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Product ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.RosyBrown
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ADD NEW PRODUCT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(928, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Insert picture"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_insertproduct_a174366
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.background_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1182, 790)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btn_insertproduct)
        Me.Controls.Add(Me.grd_insertproduct)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_insertproduct_a174366"
        Me.Text = "Kai Cannaries Trading Sdn Bhd Insert Product"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grd_insertproduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_insertproduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents grd_insertproduct As DataGridView
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents pic_insertproduct As PictureBox
    Friend WithEvents btn_insertproduct As Button
    Friend WithEvents btn_picture As Button
    Friend WithEvents txt_insertlabelled As TextBox
    Friend WithEvents txt_insertnet_weight As TextBox
    Friend WithEvents txt_insertbrand As TextBox
    Friend WithEvents txt_insertquantity As TextBox
    Friend WithEvents txt_insertprice As TextBox
    Friend WithEvents txt_insertproduct_name As TextBox
    Friend WithEvents txt_insertproduct_id As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lbl_titleinsertproduct As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_back_insertproduct As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class

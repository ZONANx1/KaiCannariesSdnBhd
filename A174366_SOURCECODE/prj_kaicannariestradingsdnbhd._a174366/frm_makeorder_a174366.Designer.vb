<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_makeorder_a174366
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_makeorder_a174366))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_backmakeorder = New System.Windows.Forms.Button()
        Me.lbl_makeordertitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.orderid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lst_makeorder_id = New System.Windows.Forms.ListBox()
        Me.pic_makeorder = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_spec = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grdcart = New System.Windows.Forms.DataGridView()
        Me.quantity = New System.Windows.Forms.ComboBox()
        Me.lv = New System.Windows.Forms.Button()
        Me.emove = New System.Windows.Forms.Button()
        Me.txt_makeorder_name = New System.Windows.Forms.TextBox()
        Me.txt_makeorderprice = New System.Windows.Forms.TextBox()
        Me.txt_makeorderbrand = New System.Windows.Forms.TextBox()
        Me.txt_makeorderlabelled = New System.Windows.Forms.TextBox()
        Me.txt_makeordernet_weight = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cartprice = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.checkout = New System.Windows.Forms.Button()
        Me.totalprice = New System.Windows.Forms.TextBox()
        Me.customer = New System.Windows.Forms.ComboBox()
        Me.staffid = New System.Windows.Forms.ComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_makeorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdcart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_backmakeorder)
        Me.Panel1.Controls.Add(Me.lbl_makeordertitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1207, 45)
        Me.Panel1.TabIndex = 1
        '
        'btn_backmakeorder
        '
        Me.btn_backmakeorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_backmakeorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_backmakeorder.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_backmakeorder.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_backmakeorder.Location = New System.Drawing.Point(3, 1)
        Me.btn_backmakeorder.Name = "btn_backmakeorder"
        Me.btn_backmakeorder.Size = New System.Drawing.Size(80, 40)
        Me.btn_backmakeorder.TabIndex = 1
        Me.btn_backmakeorder.Text = "Back"
        Me.btn_backmakeorder.UseVisualStyleBackColor = False
        '
        'lbl_makeordertitle
        '
        Me.lbl_makeordertitle.AutoSize = True
        Me.lbl_makeordertitle.Font = New System.Drawing.Font("Arial Narrow", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_makeordertitle.ForeColor = System.Drawing.Color.White
        Me.lbl_makeordertitle.Location = New System.Drawing.Point(89, 9)
        Me.lbl_makeordertitle.Name = "lbl_makeordertitle"
        Me.lbl_makeordertitle.Size = New System.Drawing.Size(116, 26)
        Me.lbl_makeordertitle.TabIndex = 0
        Me.lbl_makeordertitle.Text = "Make Order "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(26, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Order ID :"
        '
        'orderid
        '
        Me.orderid.Location = New System.Drawing.Point(137, 44)
        Me.orderid.Name = "orderid"
        Me.orderid.ReadOnly = True
        Me.orderid.Size = New System.Drawing.Size(121, 22)
        Me.orderid.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(435, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Staff ID :"
        '
        'lst_makeorder_id
        '
        Me.lst_makeorder_id.FormattingEnabled = True
        Me.lst_makeorder_id.ItemHeight = 16
        Me.lst_makeorder_id.Location = New System.Drawing.Point(47, 133)
        Me.lst_makeorder_id.Name = "lst_makeorder_id"
        Me.lst_makeorder_id.Size = New System.Drawing.Size(142, 260)
        Me.lst_makeorder_id.TabIndex = 6
        '
        'pic_makeorder
        '
        Me.pic_makeorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_makeorder.Location = New System.Drawing.Point(217, 148)
        Me.pic_makeorder.Name = "pic_makeorder"
        Me.pic_makeorder.Size = New System.Drawing.Size(251, 231)
        Me.pic_makeorder.TabIndex = 7
        Me.pic_makeorder.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(436, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Date :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(26, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Customer ID :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(46, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Product ID :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 414)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Product name "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(44, 453)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Price (RM) "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(44, 491)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Brand "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Rockwell", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(43, 529)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 17)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Labelled "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Rockwell", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(43, 568)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 17)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Net Weight "
        '
        'lbl_spec
        '
        Me.lbl_spec.AutoSize = True
        Me.lbl_spec.BackColor = System.Drawing.Color.Gray
        Me.lbl_spec.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lbl_spec.Location = New System.Drawing.Point(178, 78)
        Me.lbl_spec.Name = "lbl_spec"
        Me.lbl_spec.Size = New System.Drawing.Size(231, 22)
        Me.lbl_spec.TabIndex = 17
        Me.lbl_spec.Text = "CHOOSE ANY PRODUCT"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Rockwell", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(43, 615)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 17)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Quantity "
        '
        'grdcart
        '
        Me.grdcart.AllowUserToAddRows = False
        Me.grdcart.AllowUserToDeleteRows = False
        Me.grdcart.AllowUserToResizeColumns = False
        Me.grdcart.AllowUserToResizeRows = False
        Me.grdcart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdcart.BackgroundColor = System.Drawing.Color.CadetBlue
        Me.grdcart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdcart.Location = New System.Drawing.Point(539, 188)
        Me.grdcart.Name = "grdcart"
        Me.grdcart.ReadOnly = True
        Me.grdcart.RowHeadersWidth = 51
        Me.grdcart.RowTemplate.Height = 24
        Me.grdcart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdcart.Size = New System.Drawing.Size(604, 260)
        Me.grdcart.TabIndex = 43
        '
        'quantity
        '
        Me.quantity.FormattingEnabled = True
        Me.quantity.Location = New System.Drawing.Point(128, 612)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(77, 24)
        Me.quantity.TabIndex = 24
        '
        'lv
        '
        Me.lv.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lv.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lv.ForeColor = System.Drawing.Color.White
        Me.lv.Location = New System.Drawing.Point(373, 601)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(95, 39)
        Me.lv.TabIndex = 25
        Me.lv.Text = "Add"
        Me.lv.UseVisualStyleBackColor = False
        '
        'emove
        '
        Me.emove.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.emove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.emove.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold)
        Me.emove.ForeColor = System.Drawing.Color.White
        Me.emove.Location = New System.Drawing.Point(27, 403)
        Me.emove.Name = "emove"
        Me.emove.Size = New System.Drawing.Size(91, 40)
        Me.emove.TabIndex = 26
        Me.emove.Text = "Remove"
        Me.emove.UseVisualStyleBackColor = False
        '
        'txt_makeorder_name
        '
        Me.txt_makeorder_name.Location = New System.Drawing.Point(155, 412)
        Me.txt_makeorder_name.Name = "txt_makeorder_name"
        Me.txt_makeorder_name.ReadOnly = True
        Me.txt_makeorder_name.Size = New System.Drawing.Size(314, 22)
        Me.txt_makeorder_name.TabIndex = 27
        '
        'txt_makeorderprice
        '
        Me.txt_makeorderprice.Location = New System.Drawing.Point(154, 453)
        Me.txt_makeorderprice.Name = "txt_makeorderprice"
        Me.txt_makeorderprice.ReadOnly = True
        Me.txt_makeorderprice.Size = New System.Drawing.Size(314, 22)
        Me.txt_makeorderprice.TabIndex = 28
        '
        'txt_makeorderbrand
        '
        Me.txt_makeorderbrand.Location = New System.Drawing.Point(154, 491)
        Me.txt_makeorderbrand.Name = "txt_makeorderbrand"
        Me.txt_makeorderbrand.ReadOnly = True
        Me.txt_makeorderbrand.Size = New System.Drawing.Size(314, 22)
        Me.txt_makeorderbrand.TabIndex = 29
        '
        'txt_makeorderlabelled
        '
        Me.txt_makeorderlabelled.Location = New System.Drawing.Point(154, 529)
        Me.txt_makeorderlabelled.Name = "txt_makeorderlabelled"
        Me.txt_makeorderlabelled.ReadOnly = True
        Me.txt_makeorderlabelled.Size = New System.Drawing.Size(314, 22)
        Me.txt_makeorderlabelled.TabIndex = 30
        '
        'txt_makeordernet_weight
        '
        Me.txt_makeordernet_weight.Location = New System.Drawing.Point(154, 566)
        Me.txt_makeordernet_weight.Name = "txt_makeordernet_weight"
        Me.txt_makeordernet_weight.ReadOnly = True
        Me.txt_makeordernet_weight.Size = New System.Drawing.Size(314, 22)
        Me.txt_makeordernet_weight.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(248, 597)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 17)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Price (RM)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Rockwell", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(396, 405)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 17)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Total Price (RM)"
        '
        'cartprice
        '
        Me.cartprice.Location = New System.Drawing.Point(530, 403)
        Me.cartprice.Name = "cartprice"
        Me.cartprice.ReadOnly = True
        Me.cartprice.Size = New System.Drawing.Size(100, 22)
        Me.cartprice.TabIndex = 75
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Gray
        Me.Label15.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label15.Location = New System.Drawing.Point(293, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 22)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Invoice"
        '
        'txt_date
        '
        Me.txt_date.Location = New System.Drawing.Point(510, 46)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.ReadOnly = True
        Me.txt_date.Size = New System.Drawing.Size(121, 22)
        Me.txt_date.TabIndex = 36
        '
        'checkout
        '
        Me.checkout.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.checkout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.checkout.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold)
        Me.checkout.ForeColor = System.Drawing.Color.White
        Me.checkout.Location = New System.Drawing.Point(809, 603)
        Me.checkout.Name = "checkout"
        Me.checkout.Size = New System.Drawing.Size(103, 39)
        Me.checkout.TabIndex = 37
        Me.checkout.Text = "Confirm"
        Me.checkout.UseVisualStyleBackColor = False
        '
        'totalprice
        '
        Me.totalprice.Location = New System.Drawing.Point(237, 622)
        Me.totalprice.Name = "totalprice"
        Me.totalprice.ReadOnly = True
        Me.totalprice.Size = New System.Drawing.Size(100, 22)
        Me.totalprice.TabIndex = 72
        '
        'customer
        '
        Me.customer.FormattingEnabled = True
        Me.customer.Location = New System.Drawing.Point(510, 84)
        Me.customer.Name = "customer"
        Me.customer.Size = New System.Drawing.Size(121, 24)
        Me.customer.TabIndex = 39
        '
        'staffid
        '
        Me.staffid.FormattingEnabled = True
        Me.staffid.Location = New System.Drawing.Point(138, 83)
        Me.staffid.Name = "staffid"
        Me.staffid.Size = New System.Drawing.Size(121, 24)
        Me.staffid.TabIndex = 40
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.Food_Canned_Background
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.customer)
        Me.Panel2.Controls.Add(Me.staffid)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.cartprice)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txt_date)
        Me.Panel2.Controls.Add(Me.orderid)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.emove)
        Me.Panel2.Location = New System.Drawing.Point(512, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(653, 524)
        Me.Panel2.TabIndex = 76
        '
        'frm_makeorder_a174366
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.Food_Canned_Background_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1207, 658)
        Me.Controls.Add(Me.totalprice)
        Me.Controls.Add(Me.checkout)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_makeordernet_weight)
        Me.Controls.Add(Me.txt_makeorderlabelled)
        Me.Controls.Add(Me.txt_makeorderbrand)
        Me.Controls.Add(Me.txt_makeorderprice)
        Me.Controls.Add(Me.txt_makeorder_name)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.quantity)
        Me.Controls.Add(Me.grdcart)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbl_spec)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pic_makeorder)
        Me.Controls.Add(Me.lst_makeorder_id)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_makeorder_a174366"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kai Cannaries Trading Sdn Bhd Add Order"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pic_makeorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdcart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_makeordertitle As Label
    Friend WithEvents btn_backmakeorder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents orderid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lst_makeorder_id As ListBox
    Friend WithEvents pic_makeorder As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_spec As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents grdcart As DataGridView
    Friend WithEvents quantity As ComboBox
    Friend WithEvents lv As Button
    Friend WithEvents emove As Button
    Friend WithEvents txt_makeorder_name As TextBox
    Friend WithEvents txt_makeorderprice As TextBox
    Friend WithEvents txt_makeorderbrand As TextBox
    Friend WithEvents txt_makeorderlabelled As TextBox
    Friend WithEvents txt_makeordernet_weight As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cartprice As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_date As TextBox
    Friend WithEvents checkout As Button
    Friend WithEvents totalprice As TextBox
    Friend WithEvents customer As ComboBox
    Friend WithEvents staffid As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel2 As Panel
End Class

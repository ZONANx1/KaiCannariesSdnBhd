<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orderdata_a174366
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orderdata_a174366))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_customerID = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_staffID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pnl_product = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbl_orderdatatitle = New System.Windows.Forms.Label()
        Me.btn_backorderdata = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ftotal = New System.Windows.Forms.TextBox()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbl_orderID = New System.Windows.Forms.Label()
        Me.lst_order_id = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.pnl_product.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 31.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(515, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(452, 54)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Order Invoice"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.32777!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33611!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33611!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_customerID, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_date, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_staffID, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 4, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(14, 10)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1365, 59)
        Me.TableLayoutPanel2.TabIndex = 84
        '
        'lbl_customerID
        '
        Me.lbl_customerID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_customerID.AutoSize = True
        Me.lbl_customerID.BackColor = System.Drawing.Color.White
        Me.lbl_customerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customerID.Location = New System.Drawing.Point(397, 3)
        Me.lbl_customerID.Name = "lbl_customerID"
        Me.lbl_customerID.Size = New System.Drawing.Size(48, 53)
        Me.lbl_customerID.TabIndex = 78
        Me.lbl_customerID.Text = "cid"
        Me.lbl_customerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.White
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(1293, 3)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(66, 53)
        Me.lbl_date.TabIndex = 81
        Me.lbl_date.Text = "date"
        Me.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_staffID
        '
        Me.lbl_staffID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_staffID.AutoSize = True
        Me.lbl_staffID.BackColor = System.Drawing.Color.White
        Me.lbl_staffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffID.Location = New System.Drawing.Point(845, 3)
        Me.lbl_staffID.Name = "lbl_staffID"
        Me.lbl_staffID.Size = New System.Drawing.Size(48, 53)
        Me.lbl_staffID.TabIndex = 79
        Me.lbl_staffID.Text = "sid"
        Me.lbl_staffID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(454, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(382, 53)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Staff ID :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 53)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Customer ID :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(902, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(382, 53)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "Date :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(1139, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 29)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Order ID :"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(6, 3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(177, 30)
        Me.Label12.TabIndex = 83
        Me.Label12.Text = "Total (RM)"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_product
        '
        Me.pnl_product.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.pnl_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_product.Controls.Add(Me.Label15)
        Me.pnl_product.Controls.Add(Me.lbl_orderID)
        Me.pnl_product.Controls.Add(Me.lbl_orderdatatitle)
        Me.pnl_product.Controls.Add(Me.btn_backorderdata)
        Me.pnl_product.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnl_product.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_product.Location = New System.Drawing.Point(0, 0)
        Me.pnl_product.Name = "pnl_product"
        Me.pnl_product.Size = New System.Drawing.Size(1424, 45)
        Me.pnl_product.TabIndex = 89
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Location = New System.Drawing.Point(1293, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 29)
        Me.Label15.TabIndex = 95
        Me.Label15.Text = "No."
        '
        'lbl_orderdatatitle
        '
        Me.lbl_orderdatatitle.AutoSize = True
        Me.lbl_orderdatatitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lbl_orderdatatitle.Font = New System.Drawing.Font("Arial Narrow", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderdatatitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_orderdatatitle.Location = New System.Drawing.Point(86, 10)
        Me.lbl_orderdatatitle.Name = "lbl_orderdatatitle"
        Me.lbl_orderdatatitle.Size = New System.Drawing.Size(81, 26)
        Me.lbl_orderdatatitle.TabIndex = 1
        Me.lbl_orderdatatitle.Text = "Salinan "
        '
        'btn_backorderdata
        '
        Me.btn_backorderdata.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_backorderdata.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_backorderdata.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_backorderdata.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_backorderdata.Location = New System.Drawing.Point(5, 2)
        Me.btn_backorderdata.Name = "btn_backorderdata"
        Me.btn_backorderdata.Size = New System.Drawing.Size(80, 40)
        Me.btn_backorderdata.TabIndex = 0
        Me.btn_backorderdata.Text = "Back"
        Me.btn_backorderdata.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 31.8!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(371, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(716, 54)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Kai Cannaries Sdn Bhd"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(566, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(371, 58)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "        Tel: +60196185020" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Emel: a174366@siswa.ukm.my"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Controls.Add(Me.grd_order)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Location = New System.Drawing.Point(13, 326)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1397, 479)
        Me.Panel1.TabIndex = 92
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.66197!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.33803!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ftotal, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(923, 430)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(429, 36)
        Me.TableLayoutPanel3.TabIndex = 88
        '
        'ftotal
        '
        Me.ftotal.Location = New System.Drawing.Point(192, 6)
        Me.ftotal.Name = "ftotal"
        Me.ftotal.Size = New System.Drawing.Size(231, 22)
        Me.ftotal.TabIndex = 87
        '
        'grd_order
        '
        Me.grd_order.AllowUserToAddRows = False
        Me.grd_order.AllowUserToDeleteRows = False
        Me.grd_order.AllowUserToResizeColumns = False
        Me.grd_order.AllowUserToResizeRows = False
        Me.grd_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_order.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.grd_order.Location = New System.Drawing.Point(42, 76)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.ReadOnly = True
        Me.grd_order.RowHeadersWidth = 51
        Me.grd_order.RowTemplate.Height = 24
        Me.grd_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_order.Size = New System.Drawing.Size(1310, 348)
        Me.grd_order.TabIndex = 97
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = "PRODUCT NAME"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 450
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = "QUANTITY"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 300
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column3.HeaderText = "PRICE"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 300
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(566, 817)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(358, 58)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "NO RETURNS OR REFUNDS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     ALL SALES ARE FINAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(22, 217)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(360, 87)
        Me.Label14.TabIndex = 94
        Me.Label14.Text = "No 56, Jalan Ampang, SG 7/3," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Selayang Baru, 6800" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Selangor Darul Ehsan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(22, 817)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(125, 29)
        Me.Label16.TabIndex = 95
        Me.Label16.Text = "Signature"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(22, 846)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(176, 29)
        Me.Label17.TabIndex = 96
        Me.Label17.Text = "Khairul Amirin"
        '
        'lbl_orderID
        '
        Me.lbl_orderID.AutoSize = True
        Me.lbl_orderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_orderID.ForeColor = System.Drawing.Color.White
        Me.lbl_orderID.Location = New System.Drawing.Point(1344, 9)
        Me.lbl_orderID.Name = "lbl_orderID"
        Me.lbl_orderID.Size = New System.Drawing.Size(55, 29)
        Me.lbl_orderID.TabIndex = 99
        Me.lbl_orderID.Text = "Oid"
        '
        'lst_order_id
        '
        Me.lst_order_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_order_id.FormattingEnabled = True
        Me.lst_order_id.ItemHeight = 16
        Me.lst_order_id.Location = New System.Drawing.Point(1298, 208)
        Me.lst_order_id.Name = "lst_order_id"
        Me.lst_order_id.Size = New System.Drawing.Size(85, 96)
        Me.lst_order_id.TabIndex = 101
        '
        'frm_orderdata_a174366
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1424, 882)
        Me.Controls.Add(Me.lst_order_id)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pnl_product)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_orderdata_a174366"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INVOICE"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.pnl_product.ResumeLayout(False)
        Me.pnl_product.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lbl_customerID As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_staffID As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents pnl_product As Panel
    Friend WithEvents lbl_orderdatatitle As Label
    Friend WithEvents btn_backorderdata As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents ftotal As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents lbl_orderID As Label
    Friend WithEvents lst_order_id As ListBox
End Class

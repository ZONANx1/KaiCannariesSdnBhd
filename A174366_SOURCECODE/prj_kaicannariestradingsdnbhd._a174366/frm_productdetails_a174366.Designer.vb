<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productdetails_a174366
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_productdetails_a174366))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lst_product_id = New System.Windows.Forms.ListBox()
        Me.txt_product_name = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_labelled = New System.Windows.Forms.TextBox()
        Me.txt_net_weight = New System.Windows.Forms.TextBox()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_product_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_backproductdetails = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_labelled = New System.Windows.Forms.Label()
        Me.lbl_net_weight = New System.Windows.Forms.Label()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_product_id = New System.Windows.Forms.Label()
        Me.lbl_product_name = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(982, 45)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 26)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Product Details List"
        '
        'lst_product_id
        '
        Me.lst_product_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lst_product_id.FormattingEnabled = True
        Me.lst_product_id.ItemHeight = 16
        Me.lst_product_id.Location = New System.Drawing.Point(49, 126)
        Me.lst_product_id.Name = "lst_product_id"
        Me.lst_product_id.Size = New System.Drawing.Size(196, 324)
        Me.lst_product_id.TabIndex = 1
        '
        'txt_product_name
        '
        Me.txt_product_name.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_product_name.Location = New System.Drawing.Point(305, 146)
        Me.txt_product_name.Name = "txt_product_name"
        Me.txt_product_name.Size = New System.Drawing.Size(251, 23)
        Me.txt_product_name.TabIndex = 2
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(185, 3)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(177, 27)
        Me.txt_price.TabIndex = 3
        '
        'txt_brand
        '
        Me.txt_brand.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Bold)
        Me.txt_brand.Location = New System.Drawing.Point(185, 64)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(177, 27)
        Me.txt_brand.TabIndex = 4
        '
        'txt_labelled
        '
        Me.txt_labelled.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Bold)
        Me.txt_labelled.Location = New System.Drawing.Point(185, 125)
        Me.txt_labelled.Name = "txt_labelled"
        Me.txt_labelled.Size = New System.Drawing.Size(177, 27)
        Me.txt_labelled.TabIndex = 5
        '
        'txt_net_weight
        '
        Me.txt_net_weight.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Bold)
        Me.txt_net_weight.Location = New System.Drawing.Point(185, 186)
        Me.txt_net_weight.Name = "txt_net_weight"
        Me.txt_net_weight.Size = New System.Drawing.Size(177, 27)
        Me.txt_net_weight.TabIndex = 6
        '
        'txt_quantity
        '
        Me.txt_quantity.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Bold)
        Me.txt_quantity.Location = New System.Drawing.Point(185, 247)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(177, 27)
        Me.txt_quantity.TabIndex = 7
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.White
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(305, 219)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(251, 231)
        Me.pic_product.TabIndex = 8
        Me.pic_product.TabStop = False
        '
        'txt_product_id
        '
        Me.txt_product_id.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_product_id.Location = New System.Drawing.Point(444, 66)
        Me.txt_product_id.Name = "txt_product_id"
        Me.txt_product_id.Size = New System.Drawing.Size(112, 23)
        Me.txt_product_id.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.RosyBrown
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Choose any product :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MistyRose
        Me.Panel2.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.Food_Canned_Background
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_backproductdetails)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(601, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(381, 442)
        Me.Panel2.TabIndex = 11
        '
        'btn_backproductdetails
        '
        Me.btn_backproductdetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_backproductdetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_backproductdetails.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_backproductdetails.ForeColor = System.Drawing.Color.White
        Me.btn_backproductdetails.Location = New System.Drawing.Point(149, 391)
        Me.btn_backproductdetails.Name = "btn_backproductdetails"
        Me.btn_backproductdetails.Size = New System.Drawing.Size(80, 40)
        Me.btn_backproductdetails.TabIndex = 0
        Me.btn_backproductdetails.Text = "Back"
        Me.btn_backproductdetails.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(114, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "SPECIFICATIONS"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_price, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_brand, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_labelled, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_net_weight, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_quantity, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_brand, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_labelled, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_net_weight, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_quantity, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_price, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 64)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(365, 308)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'lbl_brand
        '
        Me.lbl_brand.BackColor = System.Drawing.Color.Gray
        Me.lbl_brand.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.Location = New System.Drawing.Point(3, 61)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(176, 23)
        Me.lbl_brand.TabIndex = 9
        Me.lbl_brand.Text = "Brand :"
        '
        'lbl_labelled
        '
        Me.lbl_labelled.BackColor = System.Drawing.Color.Gray
        Me.lbl_labelled.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_labelled.Location = New System.Drawing.Point(3, 122)
        Me.lbl_labelled.Name = "lbl_labelled"
        Me.lbl_labelled.Size = New System.Drawing.Size(176, 23)
        Me.lbl_labelled.TabIndex = 10
        Me.lbl_labelled.Text = "Labelled :"
        '
        'lbl_net_weight
        '
        Me.lbl_net_weight.BackColor = System.Drawing.Color.Gray
        Me.lbl_net_weight.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_net_weight.Location = New System.Drawing.Point(3, 183)
        Me.lbl_net_weight.Name = "lbl_net_weight"
        Me.lbl_net_weight.Size = New System.Drawing.Size(176, 34)
        Me.lbl_net_weight.TabIndex = 11
        Me.lbl_net_weight.Text = "Net Weight :"
        '
        'lbl_quantity
        '
        Me.lbl_quantity.BackColor = System.Drawing.Color.Gray
        Me.lbl_quantity.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.Location = New System.Drawing.Point(3, 244)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(176, 35)
        Me.lbl_quantity.TabIndex = 12
        Me.lbl_quantity.Text = "Quantity :"
        '
        'lbl_price
        '
        Me.lbl_price.BackColor = System.Drawing.Color.Gray
        Me.lbl_price.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(3, 0)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(176, 25)
        Me.lbl_price.TabIndex = 8
        Me.lbl_price.Text = "Price (RM) :"
        '
        'lbl_product_id
        '
        Me.lbl_product_id.BackColor = System.Drawing.Color.RosyBrown
        Me.lbl_product_id.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_id.Location = New System.Drawing.Point(305, 67)
        Me.lbl_product_id.Name = "lbl_product_id"
        Me.lbl_product_id.Size = New System.Drawing.Size(133, 22)
        Me.lbl_product_id.TabIndex = 12
        Me.lbl_product_id.Text = "Product ID :"
        '
        'lbl_product_name
        '
        Me.lbl_product_name.BackColor = System.Drawing.Color.RosyBrown
        Me.lbl_product_name.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_name.Location = New System.Drawing.Point(305, 106)
        Me.lbl_product_name.Name = "lbl_product_name"
        Me.lbl_product_name.Size = New System.Drawing.Size(251, 23)
        Me.lbl_product_name.TabIndex = 13
        Me.lbl_product_name.Text = "Product name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.RosyBrown
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(398, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Picture"
        '
        'frm_productdetails_a174366
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.Food_Canned_Background_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 487)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_product_name)
        Me.Controls.Add(Me.lbl_product_id)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_product_id)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.txt_product_name)
        Me.Controls.Add(Me.lst_product_id)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_productdetails_a174366"
        Me.Text = "Kai Cannaries Trading Sdn Bhd Products Details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lst_product_id As ListBox
    Friend WithEvents txt_product_name As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_labelled As TextBox
    Friend WithEvents txt_net_weight As TextBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_product_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_product_id As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_labelled As Label
    Friend WithEvents lbl_net_weight As Label
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents lbl_product_name As Label
    Friend WithEvents btn_backproductdetails As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class

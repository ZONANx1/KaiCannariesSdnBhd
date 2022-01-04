<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_updateproduct_a174366
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_updateproduct_a174366))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_backupdate_product = New System.Windows.Forms.Button()
        Me.lbl_title_updateproduct = New System.Windows.Forms.Label()
        Me.grd_updateproduct = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_updateproduct_id = New System.Windows.Forms.TextBox()
        Me.txt_updateproduct_name = New System.Windows.Forms.TextBox()
        Me.txt_updatequantity = New System.Windows.Forms.TextBox()
        Me.txt_updateprice = New System.Windows.Forms.TextBox()
        Me.txt_updatenet_weight = New System.Windows.Forms.TextBox()
        Me.txt_updatebrand = New System.Windows.Forms.TextBox()
        Me.txt_updatelabelled = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_updateproduct = New System.Windows.Forms.Button()
        Me.btn_deleteproduct = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.grd_updateproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_backupdate_product)
        Me.Panel1.Controls.Add(Me.lbl_title_updateproduct)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1182, 45)
        Me.Panel1.TabIndex = 0
        '
        'btn_backupdate_product
        '
        Me.btn_backupdate_product.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_backupdate_product.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_backupdate_product.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backupdate_product.ForeColor = System.Drawing.Color.White
        Me.btn_backupdate_product.Location = New System.Drawing.Point(5, 3)
        Me.btn_backupdate_product.Name = "btn_backupdate_product"
        Me.btn_backupdate_product.Size = New System.Drawing.Size(94, 40)
        Me.btn_backupdate_product.TabIndex = 3
        Me.btn_backupdate_product.Text = "Back"
        Me.btn_backupdate_product.UseVisualStyleBackColor = False
        '
        'lbl_title_updateproduct
        '
        Me.lbl_title_updateproduct.AutoSize = True
        Me.lbl_title_updateproduct.Font = New System.Drawing.Font("Arial Narrow", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title_updateproduct.ForeColor = System.Drawing.Color.White
        Me.lbl_title_updateproduct.Location = New System.Drawing.Point(102, 10)
        Me.lbl_title_updateproduct.Name = "lbl_title_updateproduct"
        Me.lbl_title_updateproduct.Size = New System.Drawing.Size(117, 26)
        Me.lbl_title_updateproduct.TabIndex = 0
        Me.lbl_title_updateproduct.Text = "Product List"
        '
        'grd_updateproduct
        '
        Me.grd_updateproduct.BackgroundColor = System.Drawing.Color.MistyRose
        Me.grd_updateproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_updateproduct.Location = New System.Drawing.Point(5, 47)
        Me.grd_updateproduct.Name = "grd_updateproduct"
        Me.grd_updateproduct.RowHeadersWidth = 51
        Me.grd_updateproduct.RowTemplate.Height = 24
        Me.grd_updateproduct.Size = New System.Drawing.Size(1174, 334)
        Me.grd_updateproduct.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.Food_Canned_Background_3
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(5, 387)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1174, 328)
        Me.Panel2.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.RosyBrown
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_updateproduct_id, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_updateproduct_name, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_updatequantity, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_updateprice, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_updatenet_weight, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_updatebrand, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_updatelabelled, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 6)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(297, 43)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(607, 267)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'txt_updateproduct_id
        '
        Me.txt_updateproduct_id.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_updateproduct_id.Location = New System.Drawing.Point(176, 3)
        Me.txt_updateproduct_id.Name = "txt_updateproduct_id"
        Me.txt_updateproduct_id.Size = New System.Drawing.Size(428, 27)
        Me.txt_updateproduct_id.TabIndex = 3
        '
        'txt_updateproduct_name
        '
        Me.txt_updateproduct_name.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_updateproduct_name.Location = New System.Drawing.Point(176, 41)
        Me.txt_updateproduct_name.Name = "txt_updateproduct_name"
        Me.txt_updateproduct_name.Size = New System.Drawing.Size(428, 27)
        Me.txt_updateproduct_name.TabIndex = 4
        '
        'txt_updatequantity
        '
        Me.txt_updatequantity.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_updatequantity.Location = New System.Drawing.Point(176, 231)
        Me.txt_updatequantity.Name = "txt_updatequantity"
        Me.txt_updatequantity.Size = New System.Drawing.Size(428, 27)
        Me.txt_updatequantity.TabIndex = 9
        '
        'txt_updateprice
        '
        Me.txt_updateprice.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_updateprice.Location = New System.Drawing.Point(176, 79)
        Me.txt_updateprice.Name = "txt_updateprice"
        Me.txt_updateprice.Size = New System.Drawing.Size(428, 27)
        Me.txt_updateprice.TabIndex = 5
        '
        'txt_updatenet_weight
        '
        Me.txt_updatenet_weight.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_updatenet_weight.Location = New System.Drawing.Point(176, 193)
        Me.txt_updatenet_weight.Name = "txt_updatenet_weight"
        Me.txt_updatenet_weight.Size = New System.Drawing.Size(428, 27)
        Me.txt_updatenet_weight.TabIndex = 8
        '
        'txt_updatebrand
        '
        Me.txt_updatebrand.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_updatebrand.Location = New System.Drawing.Point(176, 117)
        Me.txt_updatebrand.Name = "txt_updatebrand"
        Me.txt_updatebrand.Size = New System.Drawing.Size(428, 27)
        Me.txt_updatebrand.TabIndex = 6
        '
        'txt_updatelabelled
        '
        Me.txt_updatelabelled.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_updatelabelled.Location = New System.Drawing.Point(176, 155)
        Me.txt_updatelabelled.Name = "txt_updatelabelled"
        Me.txt_updatelabelled.Size = New System.Drawing.Size(428, 27)
        Me.txt_updatelabelled.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.RosyBrown
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Product ID :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.RosyBrown
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Product name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.RosyBrown
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Price :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.RosyBrown
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Brand :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.RosyBrown
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Labelled :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.RosyBrown
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Net weight :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.RosyBrown
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Quantity :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.RosyBrown
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 28)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "UPDATE OR DELETE PRODUCT"
        '
        'btn_updateproduct
        '
        Me.btn_updateproduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_updateproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_updateproduct.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updateproduct.ForeColor = System.Drawing.Color.White
        Me.btn_updateproduct.Location = New System.Drawing.Point(501, 720)
        Me.btn_updateproduct.Name = "btn_updateproduct"
        Me.btn_updateproduct.Size = New System.Drawing.Size(94, 40)
        Me.btn_updateproduct.TabIndex = 0
        Me.btn_updateproduct.Text = "Update"
        Me.btn_updateproduct.UseVisualStyleBackColor = False
        '
        'btn_deleteproduct
        '
        Me.btn_deleteproduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_deleteproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_deleteproduct.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deleteproduct.ForeColor = System.Drawing.Color.White
        Me.btn_deleteproduct.Location = New System.Drawing.Point(610, 721)
        Me.btn_deleteproduct.Name = "btn_deleteproduct"
        Me.btn_deleteproduct.Size = New System.Drawing.Size(94, 40)
        Me.btn_deleteproduct.TabIndex = 1
        Me.btn_deleteproduct.Text = "Delete"
        Me.btn_deleteproduct.UseVisualStyleBackColor = False
        '
        'frm_updateproduct_a174366
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.background_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1182, 765)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.grd_updateproduct)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_deleteproduct)
        Me.Controls.Add(Me.btn_updateproduct)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_updateproduct_a174366"
        Me.Text = "Kai Cannaries Trading Sdn Bhd Update Product"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grd_updateproduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents grd_updateproduct As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_deleteproduct As Button
    Friend WithEvents btn_updateproduct As Button
    Friend WithEvents btn_backupdate_product As Button
    Friend WithEvents lbl_title_updateproduct As Label
    Friend WithEvents txt_updatebrand As TextBox
    Friend WithEvents txt_updateprice As TextBox
    Friend WithEvents txt_updateproduct_name As TextBox
    Friend WithEvents txt_updateproduct_id As TextBox
    Friend WithEvents txt_updatequantity As TextBox
    Friend WithEvents txt_updatenet_weight As TextBox
    Friend WithEvents txt_updatelabelled As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class

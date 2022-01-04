<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_product_a174366
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_product_a174366))
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.pnl_product = New System.Windows.Forms.Panel()
        Me.lbl_producttitle = New System.Windows.Forms.Label()
        Me.btn_backproduct = New System.Windows.Forms.Button()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_product.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd_products
        '
        Me.grd_products.BackgroundColor = System.Drawing.Color.MistyRose
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(3, 46)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.RowHeadersWidth = 51
        Me.grd_products.RowTemplate.Height = 24
        Me.grd_products.Size = New System.Drawing.Size(978, 455)
        Me.grd_products.TabIndex = 0
        '
        'pnl_product
        '
        Me.pnl_product.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.pnl_product.Controls.Add(Me.lbl_producttitle)
        Me.pnl_product.Controls.Add(Me.btn_backproduct)
        Me.pnl_product.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_product.Location = New System.Drawing.Point(0, 0)
        Me.pnl_product.Name = "pnl_product"
        Me.pnl_product.Size = New System.Drawing.Size(982, 45)
        Me.pnl_product.TabIndex = 1
        '
        'lbl_producttitle
        '
        Me.lbl_producttitle.AutoSize = True
        Me.lbl_producttitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lbl_producttitle.Font = New System.Drawing.Font("Arial Narrow", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_producttitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_producttitle.Location = New System.Drawing.Point(86, 10)
        Me.lbl_producttitle.Name = "lbl_producttitle"
        Me.lbl_producttitle.Size = New System.Drawing.Size(117, 26)
        Me.lbl_producttitle.TabIndex = 1
        Me.lbl_producttitle.Text = "Product List"
        '
        'btn_backproduct
        '
        Me.btn_backproduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_backproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_backproduct.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_backproduct.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_backproduct.Location = New System.Drawing.Point(3, 3)
        Me.btn_backproduct.Name = "btn_backproduct"
        Me.btn_backproduct.Size = New System.Drawing.Size(80, 40)
        Me.btn_backproduct.TabIndex = 0
        Me.btn_backproduct.Text = "Back"
        Me.btn_backproduct.UseVisualStyleBackColor = False
        '
        'frm_product_a174366
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.background_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 503)
        Me.Controls.Add(Me.pnl_product)
        Me.Controls.Add(Me.grd_products)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_product_a174366"
        Me.Text = "Kai Cannaries Trading Sdn Bhd Products"
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_product.ResumeLayout(False)
        Me.pnl_product.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grd_products As DataGridView
    Friend WithEvents pnl_product As Panel
    Friend WithEvents btn_backproduct As Button
    Friend WithEvents lbl_producttitle As Label
End Class

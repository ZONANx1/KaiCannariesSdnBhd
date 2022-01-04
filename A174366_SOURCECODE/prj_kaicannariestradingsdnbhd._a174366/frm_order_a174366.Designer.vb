<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_order_a174366
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_order_a174366))
        Me.grd_orders = New System.Windows.Forms.DataGridView()
        Me.pnl_order = New System.Windows.Forms.Panel()
        Me.lbl_ordertitle = New System.Windows.Forms.Label()
        Me.btn_backorder = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.grd_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_order.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd_orders
        '
        Me.grd_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_orders.BackgroundColor = System.Drawing.Color.MistyRose
        Me.grd_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orders.Location = New System.Drawing.Point(2, 45)
        Me.grd_orders.Name = "grd_orders"
        Me.grd_orders.RowHeadersWidth = 51
        Me.grd_orders.RowTemplate.Height = 24
        Me.grd_orders.Size = New System.Drawing.Size(980, 458)
        Me.grd_orders.TabIndex = 0
        '
        'pnl_order
        '
        Me.pnl_order.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.pnl_order.Controls.Add(Me.lbl_ordertitle)
        Me.pnl_order.Controls.Add(Me.btn_backorder)
        Me.pnl_order.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_order.Location = New System.Drawing.Point(0, 0)
        Me.pnl_order.Name = "pnl_order"
        Me.pnl_order.Size = New System.Drawing.Size(982, 45)
        Me.pnl_order.TabIndex = 1
        '
        'lbl_ordertitle
        '
        Me.lbl_ordertitle.AutoSize = True
        Me.lbl_ordertitle.Font = New System.Drawing.Font("Arial Narrow", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ordertitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_ordertitle.Location = New System.Drawing.Point(86, 9)
        Me.lbl_ordertitle.Name = "lbl_ordertitle"
        Me.lbl_ordertitle.Size = New System.Drawing.Size(115, 26)
        Me.lbl_ordertitle.TabIndex = 1
        Me.lbl_ordertitle.Text = "Order Detail"
        '
        'btn_backorder
        '
        Me.btn_backorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_backorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_backorder.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_backorder.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_backorder.Location = New System.Drawing.Point(2, 2)
        Me.btn_backorder.Name = "btn_backorder"
        Me.btn_backorder.Size = New System.Drawing.Size(80, 40)
        Me.btn_backorder.TabIndex = 0
        Me.btn_backorder.Text = "Back"
        Me.btn_backorder.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frm_order_a174366
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.background_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 503)
        Me.Controls.Add(Me.pnl_order)
        Me.Controls.Add(Me.grd_orders)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_order_a174366"
        Me.Text = "Kai Cannaries Trading Sdn Bhd Order"
        CType(Me.grd_orders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_order.ResumeLayout(False)
        Me.pnl_order.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grd_orders As DataGridView
    Friend WithEvents pnl_order As Panel
    Friend WithEvents lbl_ordertitle As Label
    Friend WithEvents btn_backorder As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class

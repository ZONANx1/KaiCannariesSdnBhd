<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customer_a174366
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_customer_a174366))
        Me.grd_customers = New System.Windows.Forms.DataGridView()
        Me.pnl_customer = New System.Windows.Forms.Panel()
        Me.lbl_customertitle = New System.Windows.Forms.Label()
        Me.btn_backcustomer = New System.Windows.Forms.Button()
        CType(Me.grd_customers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_customer.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd_customers
        '
        Me.grd_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_customers.BackgroundColor = System.Drawing.Color.MistyRose
        Me.grd_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customers.Location = New System.Drawing.Point(3, 48)
        Me.grd_customers.Name = "grd_customers"
        Me.grd_customers.RowHeadersWidth = 51
        Me.grd_customers.RowTemplate.Height = 24
        Me.grd_customers.Size = New System.Drawing.Size(977, 452)
        Me.grd_customers.TabIndex = 0
        '
        'pnl_customer
        '
        Me.pnl_customer.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.pnl_customer.Controls.Add(Me.lbl_customertitle)
        Me.pnl_customer.Controls.Add(Me.btn_backcustomer)
        Me.pnl_customer.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_customer.Location = New System.Drawing.Point(0, 0)
        Me.pnl_customer.Name = "pnl_customer"
        Me.pnl_customer.Size = New System.Drawing.Size(982, 45)
        Me.pnl_customer.TabIndex = 1
        '
        'lbl_customertitle
        '
        Me.lbl_customertitle.AutoSize = True
        Me.lbl_customertitle.Font = New System.Drawing.Font("Arial Narrow", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customertitle.ForeColor = System.Drawing.Color.White
        Me.lbl_customertitle.Location = New System.Drawing.Point(90, 9)
        Me.lbl_customertitle.Name = "lbl_customertitle"
        Me.lbl_customertitle.Size = New System.Drawing.Size(133, 26)
        Me.lbl_customertitle.TabIndex = 1
        Me.lbl_customertitle.Text = "Customer List"
        '
        'btn_backcustomer
        '
        Me.btn_backcustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_backcustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_backcustomer.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_backcustomer.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_backcustomer.Location = New System.Drawing.Point(4, 3)
        Me.btn_backcustomer.Name = "btn_backcustomer"
        Me.btn_backcustomer.Size = New System.Drawing.Size(80, 40)
        Me.btn_backcustomer.TabIndex = 0
        Me.btn_backcustomer.Text = "Back"
        Me.btn_backcustomer.UseVisualStyleBackColor = False
        '
        'frm_customer_a174366
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.background_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 503)
        Me.Controls.Add(Me.pnl_customer)
        Me.Controls.Add(Me.grd_customers)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_customer_a174366"
        Me.Text = "Kai Cannaries Trading Sdn Customers"
        CType(Me.grd_customers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_customer.ResumeLayout(False)
        Me.pnl_customer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grd_customers As DataGridView
    Friend WithEvents pnl_customer As Panel
    Friend WithEvents btn_backcustomer As Button
    Friend WithEvents lbl_customertitle As Label
End Class

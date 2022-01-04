<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staff_a174366
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_staff_a174366))
        Me.grd_staffs = New System.Windows.Forms.DataGridView()
        Me.pnl_customer = New System.Windows.Forms.Panel()
        Me.btn_backstaff = New System.Windows.Forms.Button()
        Me.lbl_stafftitle = New System.Windows.Forms.Label()
        CType(Me.grd_staffs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_customer.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd_staffs
        '
        Me.grd_staffs.BackgroundColor = System.Drawing.Color.MistyRose
        Me.grd_staffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staffs.Location = New System.Drawing.Point(2, 45)
        Me.grd_staffs.Name = "grd_staffs"
        Me.grd_staffs.RowHeadersWidth = 51
        Me.grd_staffs.RowTemplate.Height = 24
        Me.grd_staffs.Size = New System.Drawing.Size(980, 455)
        Me.grd_staffs.TabIndex = 0
        '
        'pnl_customer
        '
        Me.pnl_customer.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.pnl_customer.Controls.Add(Me.btn_backstaff)
        Me.pnl_customer.Controls.Add(Me.lbl_stafftitle)
        Me.pnl_customer.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_customer.Location = New System.Drawing.Point(0, 0)
        Me.pnl_customer.Name = "pnl_customer"
        Me.pnl_customer.Size = New System.Drawing.Size(982, 45)
        Me.pnl_customer.TabIndex = 1
        '
        'btn_backstaff
        '
        Me.btn_backstaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_backstaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_backstaff.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_backstaff.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_backstaff.Location = New System.Drawing.Point(2, 2)
        Me.btn_backstaff.Name = "btn_backstaff"
        Me.btn_backstaff.Size = New System.Drawing.Size(80, 40)
        Me.btn_backstaff.TabIndex = 2
        Me.btn_backstaff.Text = "Back"
        Me.btn_backstaff.UseVisualStyleBackColor = False
        '
        'lbl_stafftitle
        '
        Me.lbl_stafftitle.AutoSize = True
        Me.lbl_stafftitle.Font = New System.Drawing.Font("Arial Narrow", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_stafftitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_stafftitle.Location = New System.Drawing.Point(86, 9)
        Me.lbl_stafftitle.Name = "lbl_stafftitle"
        Me.lbl_stafftitle.Size = New System.Drawing.Size(89, 26)
        Me.lbl_stafftitle.TabIndex = 0
        Me.lbl_stafftitle.Text = "Staff List"
        '
        'frm_staff_a174366
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.background_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 503)
        Me.Controls.Add(Me.pnl_customer)
        Me.Controls.Add(Me.grd_staffs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_staff_a174366"
        Me.Text = "Kai Cannaries Trading Sdn Bhd Staffs"
        CType(Me.grd_staffs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_customer.ResumeLayout(False)
        Me.pnl_customer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grd_staffs As DataGridView
    Friend WithEvents pnl_customer As Panel
    Friend WithEvents lbl_stafftitle As Label
    Friend WithEvents btn_backstaff As Button
End Class

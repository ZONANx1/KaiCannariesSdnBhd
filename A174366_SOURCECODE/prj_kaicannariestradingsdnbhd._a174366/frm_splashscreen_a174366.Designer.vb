<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_splashscreen_a174366
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_splashscreen_a174366))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_matric = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.PeachPuff
        Me.lbl_title.Font = New System.Drawing.Font("Niagara Solid", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(104, 55)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(657, 85)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = " Kai Cannaries Trading Sdn Bhd."
        '
        'lbl_matric
        '
        Me.lbl_matric.AutoSize = True
        Me.lbl_matric.BackColor = System.Drawing.Color.Black
        Me.lbl_matric.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lbl_matric.ForeColor = System.Drawing.Color.White
        Me.lbl_matric.Location = New System.Drawing.Point(115, 208)
        Me.lbl_matric.Name = "lbl_matric"
        Me.lbl_matric.Size = New System.Drawing.Size(89, 22)
        Me.lbl_matric.TabIndex = 1
        Me.lbl_matric.Text = "A174366"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Black
        Me.lbl_name.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lbl_name.ForeColor = System.Drawing.Color.White
        Me.lbl_name.Location = New System.Drawing.Point(242, 207)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(228, 22)
        Me.lbl_name.TabIndex = 2
        Me.lbl_name.Text = "Khairul Amirin bin Ismail"
        '
        'btn_start
        '
        Me.btn_start.BackColor = System.Drawing.Color.Black
        Me.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start.ForeColor = System.Drawing.Color.Red
        Me.btn_start.Location = New System.Drawing.Point(11, 297)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(127, 59)
        Me.btn_start.TabIndex = 3
        Me.btn_start.Text = "Let's Get Started"
        Me.btn_start.UseVisualStyleBackColor = False
        '
        'frm_splashscreen_a174366
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.Food_Canned_Background_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(879, 366)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_matric)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_splashscreen_a174366"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "START"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_matric As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents btn_start As Button
End Class

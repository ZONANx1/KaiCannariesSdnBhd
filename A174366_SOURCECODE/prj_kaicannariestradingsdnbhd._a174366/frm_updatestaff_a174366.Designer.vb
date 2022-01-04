<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updatestaff_a174366
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_updatestaff_a174366))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_backupdate_staff = New System.Windows.Forms.Button()
        Me.grd_updatestaff = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_updatestaff_id = New System.Windows.Forms.TextBox()
        Me.txt_updatestaff_name = New System.Windows.Forms.TextBox()
        Me.txt_updatestaff_email = New System.Windows.Forms.TextBox()
        Me.txt_updatestaff_num = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_updatestaff = New System.Windows.Forms.Button()
        Me.btn_deletestaff = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.grd_updatestaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btn_backupdate_staff)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1182, 45)
        Me.Panel1.TabIndex = 0
        '
        'btn_backupdate_staff
        '
        Me.btn_backupdate_staff.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_backupdate_staff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_backupdate_staff.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_backupdate_staff.ForeColor = System.Drawing.Color.White
        Me.btn_backupdate_staff.Location = New System.Drawing.Point(5, 2)
        Me.btn_backupdate_staff.Name = "btn_backupdate_staff"
        Me.btn_backupdate_staff.Size = New System.Drawing.Size(94, 40)
        Me.btn_backupdate_staff.TabIndex = 0
        Me.btn_backupdate_staff.Text = "Back"
        Me.btn_backupdate_staff.UseVisualStyleBackColor = False
        '
        'grd_updatestaff
        '
        Me.grd_updatestaff.BackgroundColor = System.Drawing.Color.MistyRose
        Me.grd_updatestaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_updatestaff.Location = New System.Drawing.Point(5, 47)
        Me.grd_updatestaff.Name = "grd_updatestaff"
        Me.grd_updatestaff.RowHeadersWidth = 51
        Me.grd_updatestaff.RowTemplate.Height = 24
        Me.grd_updatestaff.Size = New System.Drawing.Size(1174, 334)
        Me.grd_updatestaff.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Turquoise
        Me.Panel2.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.Food_Canned_Background_2
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(5, 385)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1174, 244)
        Me.Panel2.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_updatestaff_id, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_updatestaff_name, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_updatestaff_email, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_updatestaff_num, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(300, 43)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(596, 180)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'txt_updatestaff_id
        '
        Me.txt_updatestaff_id.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_updatestaff_id.Location = New System.Drawing.Point(173, 3)
        Me.txt_updatestaff_id.Name = "txt_updatestaff_id"
        Me.txt_updatestaff_id.Size = New System.Drawing.Size(420, 27)
        Me.txt_updatestaff_id.TabIndex = 0
        '
        'txt_updatestaff_name
        '
        Me.txt_updatestaff_name.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_updatestaff_name.Location = New System.Drawing.Point(173, 48)
        Me.txt_updatestaff_name.Name = "txt_updatestaff_name"
        Me.txt_updatestaff_name.Size = New System.Drawing.Size(420, 27)
        Me.txt_updatestaff_name.TabIndex = 1
        '
        'txt_updatestaff_email
        '
        Me.txt_updatestaff_email.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_updatestaff_email.Location = New System.Drawing.Point(173, 138)
        Me.txt_updatestaff_email.Name = "txt_updatestaff_email"
        Me.txt_updatestaff_email.Size = New System.Drawing.Size(420, 27)
        Me.txt_updatestaff_email.TabIndex = 3
        '
        'txt_updatestaff_num
        '
        Me.txt_updatestaff_num.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_updatestaff_num.Location = New System.Drawing.Point(173, 93)
        Me.txt_updatestaff_num.Name = "txt_updatestaff_num"
        Me.txt_updatestaff_num.Size = New System.Drawing.Size(420, 27)
        Me.txt_updatestaff_num.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Turquoise
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Staff ID :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Turquoise
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Staff name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Turquoise
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Staff num :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Turquoise
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(3, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Staff email :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Turquoise
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 27)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "UPDATE OR DELETE STAFF"
        '
        'btn_updatestaff
        '
        Me.btn_updatestaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_updatestaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_updatestaff.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updatestaff.ForeColor = System.Drawing.Color.White
        Me.btn_updatestaff.Location = New System.Drawing.Point(501, 632)
        Me.btn_updatestaff.Name = "btn_updatestaff"
        Me.btn_updatestaff.Size = New System.Drawing.Size(94, 40)
        Me.btn_updatestaff.TabIndex = 3
        Me.btn_updatestaff.Text = "Update"
        Me.btn_updatestaff.UseVisualStyleBackColor = False
        '
        'btn_deletestaff
        '
        Me.btn_deletestaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_deletestaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_deletestaff.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deletestaff.ForeColor = System.Drawing.Color.White
        Me.btn_deletestaff.Location = New System.Drawing.Point(607, 632)
        Me.btn_deletestaff.Name = "btn_deletestaff"
        Me.btn_deletestaff.Size = New System.Drawing.Size(94, 40)
        Me.btn_deletestaff.TabIndex = 4
        Me.btn_deletestaff.Text = "Delete"
        Me.btn_deletestaff.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 13.2!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(103, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 26)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Staff List"
        '
        'frm_updatestaff_a174366
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.background_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1182, 679)
        Me.Controls.Add(Me.btn_deletestaff)
        Me.Controls.Add(Me.btn_updatestaff)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.grd_updatestaff)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_updatestaff_a174366"
        Me.Text = "Kai Cannaries Trading Sdn Bhd Update Staff"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grd_updatestaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_backupdate_staff As Button
    Friend WithEvents grd_updatestaff As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_updatestaff As Button
    Friend WithEvents btn_deletestaff As Button
    Friend WithEvents txt_updatestaff_email As TextBox
    Friend WithEvents txt_updatestaff_num As TextBox
    Friend WithEvents txt_updatestaff_name As TextBox
    Friend WithEvents txt_updatestaff_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class

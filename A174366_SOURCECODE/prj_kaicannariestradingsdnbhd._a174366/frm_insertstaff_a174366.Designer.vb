<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertstaff_a174366
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_backinsert_staff = New System.Windows.Forms.Button()
        Me.grd_insertstaff = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_insertstaff_id = New System.Windows.Forms.TextBox()
        Me.txt_insertstaff_email = New System.Windows.Forms.TextBox()
        Me.txt_insertstaff_name = New System.Windows.Forms.TextBox()
        Me.txt_insertstaff_num = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_insertstaff = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.grd_insertstaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btn_backinsert_staff)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1182, 45)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(103, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Staff List"
        '
        'btn_backinsert_staff
        '
        Me.btn_backinsert_staff.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_backinsert_staff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_backinsert_staff.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backinsert_staff.ForeColor = System.Drawing.Color.White
        Me.btn_backinsert_staff.Location = New System.Drawing.Point(5, 3)
        Me.btn_backinsert_staff.Name = "btn_backinsert_staff"
        Me.btn_backinsert_staff.Size = New System.Drawing.Size(94, 40)
        Me.btn_backinsert_staff.TabIndex = 0
        Me.btn_backinsert_staff.Text = "Back"
        Me.btn_backinsert_staff.UseVisualStyleBackColor = False
        '
        'grd_insertstaff
        '
        Me.grd_insertstaff.BackgroundColor = System.Drawing.Color.MistyRose
        Me.grd_insertstaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_insertstaff.Location = New System.Drawing.Point(5, 46)
        Me.grd_insertstaff.Name = "grd_insertstaff"
        Me.grd_insertstaff.RowHeadersWidth = 51
        Me.grd_insertstaff.RowTemplate.Height = 24
        Me.grd_insertstaff.Size = New System.Drawing.Size(1173, 341)
        Me.grd_insertstaff.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.Food_Canned_Background_2
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(5, 390)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1173, 212)
        Me.Panel2.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Turquoise
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_insertstaff_id, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_insertstaff_email, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_insertstaff_name, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_insertstaff_num, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(238, 39)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(720, 158)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'txt_insertstaff_id
        '
        Me.txt_insertstaff_id.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_insertstaff_id.Location = New System.Drawing.Point(208, 3)
        Me.txt_insertstaff_id.Name = "txt_insertstaff_id"
        Me.txt_insertstaff_id.Size = New System.Drawing.Size(509, 27)
        Me.txt_insertstaff_id.TabIndex = 1
        '
        'txt_insertstaff_email
        '
        Me.txt_insertstaff_email.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_insertstaff_email.Location = New System.Drawing.Point(208, 120)
        Me.txt_insertstaff_email.Name = "txt_insertstaff_email"
        Me.txt_insertstaff_email.Size = New System.Drawing.Size(509, 27)
        Me.txt_insertstaff_email.TabIndex = 4
        '
        'txt_insertstaff_name
        '
        Me.txt_insertstaff_name.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_insertstaff_name.Location = New System.Drawing.Point(208, 42)
        Me.txt_insertstaff_name.Name = "txt_insertstaff_name"
        Me.txt_insertstaff_name.Size = New System.Drawing.Size(509, 27)
        Me.txt_insertstaff_name.TabIndex = 2
        '
        'txt_insertstaff_num
        '
        Me.txt_insertstaff_num.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_insertstaff_num.Location = New System.Drawing.Point(208, 81)
        Me.txt_insertstaff_num.Name = "txt_insertstaff_num"
        Me.txt_insertstaff_num.Size = New System.Drawing.Size(509, 27)
        Me.txt_insertstaff_num.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Turquoise
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Staff ID :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Turquoise
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Staff name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Turquoise
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Staff num :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Turquoise
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Staff email :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Turquoise
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADD NEW STAFF"
        '
        'btn_insertstaff
        '
        Me.btn_insertstaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_insertstaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_insertstaff.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertstaff.ForeColor = System.Drawing.Color.White
        Me.btn_insertstaff.Location = New System.Drawing.Point(550, 607)
        Me.btn_insertstaff.Name = "btn_insertstaff"
        Me.btn_insertstaff.Size = New System.Drawing.Size(94, 40)
        Me.btn_insertstaff.TabIndex = 3
        Me.btn_insertstaff.Text = "Add"
        Me.btn_insertstaff.UseVisualStyleBackColor = False
        '
        'frm_insertstaff_a174366
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.background_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1182, 651)
        Me.Controls.Add(Me.btn_insertstaff)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.grd_insertstaff)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_insertstaff_a174366"
        Me.Text = "frm_insertstaff_a174366"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grd_insertstaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_backinsert_staff As Button
    Friend WithEvents grd_insertstaff As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_insertstaff As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_insertstaff_email As TextBox
    Friend WithEvents txt_insertstaff_num As TextBox
    Friend WithEvents txt_insertstaff_name As TextBox
    Friend WithEvents txt_insertstaff_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class

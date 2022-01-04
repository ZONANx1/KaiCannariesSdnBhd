<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updatecustomer_a174366
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_updatecustomer_a174366))
        Me.grd_updatecustomer = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_backupdate_customer = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_updatecustomer_name = New System.Windows.Forms.TextBox()
        Me.txt_updatecustomer_email = New System.Windows.Forms.TextBox()
        Me.txt_updatecustomer_num = New System.Windows.Forms.TextBox()
        Me.txt_updatecustomer_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_updatecustomer = New System.Windows.Forms.Button()
        Me.btn_deletecustomer = New System.Windows.Forms.Button()
        CType(Me.grd_updatecustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd_updatecustomer
        '
        Me.grd_updatecustomer.BackgroundColor = System.Drawing.Color.MistyRose
        Me.grd_updatecustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_updatecustomer.Location = New System.Drawing.Point(2, 46)
        Me.grd_updatecustomer.Name = "grd_updatecustomer"
        Me.grd_updatecustomer.RowHeadersWidth = 51
        Me.grd_updatecustomer.RowTemplate.Height = 24
        Me.grd_updatecustomer.Size = New System.Drawing.Size(1178, 334)
        Me.grd_updatecustomer.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btn_backupdate_customer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1182, 45)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(102, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer List"
        '
        'btn_backupdate_customer
        '
        Me.btn_backupdate_customer.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_backupdate_customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_backupdate_customer.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backupdate_customer.ForeColor = System.Drawing.Color.White
        Me.btn_backupdate_customer.Location = New System.Drawing.Point(4, 3)
        Me.btn_backupdate_customer.Name = "btn_backupdate_customer"
        Me.btn_backupdate_customer.Size = New System.Drawing.Size(94, 40)
        Me.btn_backupdate_customer.TabIndex = 0
        Me.btn_backupdate_customer.Text = "Back"
        Me.btn_backupdate_customer.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.Food_Canned_Background_2
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(2, 383)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1178, 244)
        Me.Panel2.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Turquoise
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_updatecustomer_name, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_updatecustomer_email, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_updatecustomer_num, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_updatecustomer_id, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(304, 48)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(596, 180)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'txt_updatecustomer_name
        '
        Me.txt_updatecustomer_name.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_updatecustomer_name.Location = New System.Drawing.Point(173, 48)
        Me.txt_updatecustomer_name.Name = "txt_updatecustomer_name"
        Me.txt_updatecustomer_name.Size = New System.Drawing.Size(420, 27)
        Me.txt_updatecustomer_name.TabIndex = 2
        '
        'txt_updatecustomer_email
        '
        Me.txt_updatecustomer_email.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_updatecustomer_email.Location = New System.Drawing.Point(173, 138)
        Me.txt_updatecustomer_email.Name = "txt_updatecustomer_email"
        Me.txt_updatecustomer_email.Size = New System.Drawing.Size(420, 27)
        Me.txt_updatecustomer_email.TabIndex = 0
        '
        'txt_updatecustomer_num
        '
        Me.txt_updatecustomer_num.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_updatecustomer_num.Location = New System.Drawing.Point(173, 93)
        Me.txt_updatecustomer_num.Name = "txt_updatecustomer_num"
        Me.txt_updatecustomer_num.Size = New System.Drawing.Size(420, 27)
        Me.txt_updatecustomer_num.TabIndex = 3
        '
        'txt_updatecustomer_id
        '
        Me.txt_updatecustomer_id.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txt_updatecustomer_id.Location = New System.Drawing.Point(173, 3)
        Me.txt_updatecustomer_id.Name = "txt_updatecustomer_id"
        Me.txt_updatecustomer_id.Size = New System.Drawing.Size(420, 27)
        Me.txt_updatecustomer_id.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Turquoise
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Customer ID :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Turquoise
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Customer name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Turquoise
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Customer num :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Turquoise
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Customer email :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Turquoise
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(395, 28)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "UPDATE OR DELETE CUSTOMER"
        '
        'btn_updatecustomer
        '
        Me.btn_updatecustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_updatecustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_updatecustomer.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updatecustomer.ForeColor = System.Drawing.Color.White
        Me.btn_updatecustomer.Location = New System.Drawing.Point(502, 632)
        Me.btn_updatecustomer.Name = "btn_updatecustomer"
        Me.btn_updatecustomer.Size = New System.Drawing.Size(94, 40)
        Me.btn_updatecustomer.TabIndex = 3
        Me.btn_updatecustomer.Text = "Update"
        Me.btn_updatecustomer.UseVisualStyleBackColor = False
        '
        'btn_deletecustomer
        '
        Me.btn_deletecustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_deletecustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_deletecustomer.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deletecustomer.ForeColor = System.Drawing.Color.White
        Me.btn_deletecustomer.Location = New System.Drawing.Point(607, 632)
        Me.btn_deletecustomer.Name = "btn_deletecustomer"
        Me.btn_deletecustomer.Size = New System.Drawing.Size(94, 40)
        Me.btn_deletecustomer.TabIndex = 4
        Me.btn_deletecustomer.Text = "Delete"
        Me.btn_deletecustomer.UseVisualStyleBackColor = False
        '
        'frm_updatecustomer_a174366
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.background_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1182, 679)
        Me.Controls.Add(Me.btn_deletecustomer)
        Me.Controls.Add(Me.btn_updatecustomer)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grd_updatecustomer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_updatecustomer_a174366"
        Me.Text = "Kai Cannaries Trading Sdn Bhd Update Customer"
        CType(Me.grd_updatecustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grd_updatecustomer As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_updatecustomer As Button
    Friend WithEvents btn_backupdate_customer As Button
    Friend WithEvents btn_deletecustomer As Button
    Friend WithEvents txt_updatecustomer_num As TextBox
    Friend WithEvents txt_updatecustomer_name As TextBox
    Friend WithEvents txt_updatecustomer_id As TextBox
    Friend WithEvents txt_updatecustomer_email As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class

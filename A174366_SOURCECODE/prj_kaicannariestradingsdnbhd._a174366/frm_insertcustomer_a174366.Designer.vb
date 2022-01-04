<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertcustomer_a174366
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertcustomer_a174366))
        Me.grd_insertcustomer = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_backinsert_customer = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_insertcustomer_email = New System.Windows.Forms.TextBox()
        Me.txt_insertcustomer_id = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_insertcustomer_num = New System.Windows.Forms.TextBox()
        Me.txt_insertcustomer_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_insertcustomer = New System.Windows.Forms.Button()
        CType(Me.grd_insertcustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd_insertcustomer
        '
        Me.grd_insertcustomer.BackgroundColor = System.Drawing.Color.MistyRose
        Me.grd_insertcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_insertcustomer.Location = New System.Drawing.Point(2, 47)
        Me.grd_insertcustomer.Name = "grd_insertcustomer"
        Me.grd_insertcustomer.RowHeadersWidth = 51
        Me.grd_insertcustomer.RowTemplate.Height = 24
        Me.grd_insertcustomer.Size = New System.Drawing.Size(1178, 341)
        Me.grd_insertcustomer.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btn_backinsert_customer)
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
        Me.Label2.Location = New System.Drawing.Point(101, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer List"
        '
        'btn_backinsert_customer
        '
        Me.btn_backinsert_customer.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_backinsert_customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_backinsert_customer.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backinsert_customer.ForeColor = System.Drawing.Color.White
        Me.btn_backinsert_customer.Location = New System.Drawing.Point(3, 4)
        Me.btn_backinsert_customer.Name = "btn_backinsert_customer"
        Me.btn_backinsert_customer.Size = New System.Drawing.Size(94, 40)
        Me.btn_backinsert_customer.TabIndex = 0
        Me.btn_backinsert_customer.Text = "Back"
        Me.btn_backinsert_customer.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.Food_Canned_Background_2
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(5, 391)
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
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_insertcustomer_email, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_insertcustomer_id, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_insertcustomer_num, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_insertcustomer_name, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(273, 41)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(720, 158)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Turquoise
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Customer ID :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Turquoise
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Customer email :"
        '
        'txt_insertcustomer_email
        '
        Me.txt_insertcustomer_email.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_insertcustomer_email.Location = New System.Drawing.Point(208, 120)
        Me.txt_insertcustomer_email.Name = "txt_insertcustomer_email"
        Me.txt_insertcustomer_email.Size = New System.Drawing.Size(509, 27)
        Me.txt_insertcustomer_email.TabIndex = 4
        '
        'txt_insertcustomer_id
        '
        Me.txt_insertcustomer_id.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_insertcustomer_id.Location = New System.Drawing.Point(208, 3)
        Me.txt_insertcustomer_id.Name = "txt_insertcustomer_id"
        Me.txt_insertcustomer_id.Size = New System.Drawing.Size(509, 27)
        Me.txt_insertcustomer_id.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Turquoise
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Customer number :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Turquoise
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Customer name :"
        '
        'txt_insertcustomer_num
        '
        Me.txt_insertcustomer_num.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_insertcustomer_num.Location = New System.Drawing.Point(208, 81)
        Me.txt_insertcustomer_num.Name = "txt_insertcustomer_num"
        Me.txt_insertcustomer_num.Size = New System.Drawing.Size(509, 27)
        Me.txt_insertcustomer_num.TabIndex = 3
        '
        'txt_insertcustomer_name
        '
        Me.txt_insertcustomer_name.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_insertcustomer_name.Location = New System.Drawing.Point(208, 42)
        Me.txt_insertcustomer_name.Name = "txt_insertcustomer_name"
        Me.txt_insertcustomer_name.Size = New System.Drawing.Size(509, 27)
        Me.txt_insertcustomer_name.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Turquoise
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 27)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ADD NEW CUSTOMER"
        '
        'btn_insertcustomer
        '
        Me.btn_insertcustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_insertcustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_insertcustomer.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertcustomer.ForeColor = System.Drawing.Color.White
        Me.btn_insertcustomer.Location = New System.Drawing.Point(551, 609)
        Me.btn_insertcustomer.Name = "btn_insertcustomer"
        Me.btn_insertcustomer.Size = New System.Drawing.Size(94, 40)
        Me.btn_insertcustomer.TabIndex = 3
        Me.btn_insertcustomer.Text = "Add"
        Me.btn_insertcustomer.UseVisualStyleBackColor = False
        '
        'frm_insertcustomer_a174366
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.BackgroundImage = Global.prj_kaicannariestradingsdnbhd._a174366.My.Resources.Resources.background_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1182, 653)
        Me.Controls.Add(Me.btn_insertcustomer)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grd_insertcustomer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_insertcustomer_a174366"
        Me.Text = "Kai Cannaries Trading Sdn Bhd Insert Customer"
        CType(Me.grd_insertcustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grd_insertcustomer As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_backinsert_customer As Button
    Friend WithEvents btn_insertcustomer As Button
    Friend WithEvents txt_insertcustomer_email As TextBox
    Friend WithEvents txt_insertcustomer_num As TextBox
    Friend WithEvents txt_insertcustomer_name As TextBox
    Friend WithEvents txt_insertcustomer_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class

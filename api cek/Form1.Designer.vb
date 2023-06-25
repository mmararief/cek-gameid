<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCek = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtZone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGame = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbServer = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnCek
        '
        Me.btnCek.Location = New System.Drawing.Point(103, 389)
        Me.btnCek.Name = "btnCek"
        Me.btnCek.Size = New System.Drawing.Size(498, 52)
        Me.btnCek.TabIndex = 0
        Me.btnCek.Text = "Cek Username"
        Me.btnCek.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Heebo", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(103, 167)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(498, 43)
        Me.txtUser.TabIndex = 1
        Me.txtUser.Visible = False
        '
        'txtZone
        '
        Me.txtZone.Font = New System.Drawing.Font("Heebo", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZone.Location = New System.Drawing.Point(103, 243)
        Me.txtZone.Name = "txtZone"
        Me.txtZone.Size = New System.Drawing.Size(498, 43)
        Me.txtZone.TabIndex = 2
        Me.txtZone.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "USER ID :"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ZONE ID :"
        Me.Label2.Visible = False
        '
        'cmbGame
        '
        Me.cmbGame.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGame.FormattingEnabled = True
        Me.cmbGame.Items.AddRange(New Object() {"MOBILE LEGENDS", "FREE FIRE", "PUBG MOBILE", "SAUSAGE MAN", "POINT BLANK", "GENSHIN IMPACT"})
        Me.cmbGame.Location = New System.Drawing.Point(103, 67)
        Me.cmbGame.Name = "cmbGame"
        Me.cmbGame.Size = New System.Drawing.Size(498, 37)
        Me.cmbGame.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "PILIH GAME :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(632, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "PILIH SERVER :"
        Me.Label4.Visible = False
        '
        'cmbServer
        '
        Me.cmbServer.Font = New System.Drawing.Font("Roboto Light", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbServer.FormattingEnabled = True
        Me.cmbServer.Items.AddRange(New Object() {"os_asia", "os_usa", "os_euro", "os_cht"})
        Me.cmbServer.Location = New System.Drawing.Point(636, 167)
        Me.cmbServer.Name = "cmbServer"
        Me.cmbServer.Size = New System.Drawing.Size(171, 32)
        Me.cmbServer.TabIndex = 8
        Me.cmbServer.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 540)
        Me.Controls.Add(Me.cmbServer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbGame)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtZone)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.btnCek)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCek As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtZone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbGame As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbServer As ComboBox
End Class

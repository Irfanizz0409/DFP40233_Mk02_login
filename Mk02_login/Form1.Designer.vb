<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtFirst = New TextBox()
        txtSecond = New TextBox()
        BtnLogin = New Button()
        lblIdpengguna = New Label()
        lblLogmasuk = New Label()
        lblKatalaluan = New Label()
        SuspendLayout()
        ' 
        ' txtFirst
        ' 
        txtFirst.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtFirst.Location = New Point(124, 75)
        txtFirst.Multiline = True
        txtFirst.Name = "txtFirst"
        txtFirst.Size = New Size(211, 32)
        txtFirst.TabIndex = 1
        ' 
        ' txtSecond
        ' 
        txtSecond.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSecond.Location = New Point(124, 118)
        txtSecond.Multiline = True
        txtSecond.Name = "txtSecond"
        txtSecond.Size = New Size(211, 32)
        txtSecond.TabIndex = 2
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = SystemColors.ButtonShadow
        BtnLogin.Location = New Point(141, 180)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(94, 29)
        BtnLogin.TabIndex = 3
        BtnLogin.Text = "LOGIN"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' lblIdpengguna
        ' 
        lblIdpengguna.AutoSize = True
        lblIdpengguna.Location = New Point(12, 78)
        lblIdpengguna.Name = "lblIdpengguna"
        lblIdpengguna.Size = New Size(106, 20)
        lblIdpengguna.TabIndex = 4
        lblIdpengguna.Text = "ID PENGGUNA"
        ' 
        ' lblLogmasuk
        ' 
        lblLogmasuk.Location = New Point(124, 39)
        lblLogmasuk.Name = "lblLogmasuk"
        lblLogmasuk.Size = New Size(123, 33)
        lblLogmasuk.TabIndex = 5
        lblLogmasuk.Text = "LOG MASUK"
        lblLogmasuk.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblKatalaluan
        ' 
        lblKatalaluan.AutoSize = True
        lblKatalaluan.Location = New Point(12, 121)
        lblKatalaluan.Name = "lblKatalaluan"
        lblKatalaluan.Size = New Size(103, 20)
        lblKatalaluan.TabIndex = 6
        lblKatalaluan.Text = "KATA LALUAN"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(382, 220)
        Controls.Add(lblKatalaluan)
        Controls.Add(lblLogmasuk)
        Controls.Add(lblIdpengguna)
        Controls.Add(BtnLogin)
        Controls.Add(txtSecond)
        Controls.Add(txtFirst)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterParent
        Text = "Login Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtSecond As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents lblIdpengguna As Label
    Friend WithEvents lblLogmasuk As Label
    Friend WithEvents lblKatalaluan As Label

End Class

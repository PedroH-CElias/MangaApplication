<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEditarSenha
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
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Painel = New System.Windows.Forms.Panel()
        Me.Voltar = New System.Windows.Forms.Button()
        Me.Salvar = New System.Windows.Forms.Button()
        Me.TextSenhaAtual = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextNovaSenha = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextConfirmarSenha = New System.Windows.Forms.TextBox()
        Me.TextUsuario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MostrarSenha = New System.Windows.Forms.CheckBox()
        Me.Painel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(134, 189)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(0, 13)
        Me.LinkLabel1.TabIndex = 15
        '
        'Painel
        '
        Me.Painel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Painel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Painel.Controls.Add(Me.MostrarSenha)
        Me.Painel.Controls.Add(Me.TextUsuario)
        Me.Painel.Controls.Add(Me.Label6)
        Me.Painel.Controls.Add(Me.TextConfirmarSenha)
        Me.Painel.Controls.Add(Me.Label5)
        Me.Painel.Controls.Add(Me.Voltar)
        Me.Painel.Controls.Add(Me.Salvar)
        Me.Painel.Controls.Add(Me.TextSenhaAtual)
        Me.Painel.Controls.Add(Me.Label2)
        Me.Painel.Controls.Add(Me.Label1)
        Me.Painel.Controls.Add(Me.TextNovaSenha)
        Me.Painel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Painel.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Painel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Painel.Location = New System.Drawing.Point(37, 217)
        Me.Painel.Name = "Painel"
        Me.Painel.Size = New System.Drawing.Size(472, 300)
        Me.Painel.TabIndex = 17
        '
        'Voltar
        '
        Me.Voltar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Voltar.BackColor = System.Drawing.Color.White
        Me.Voltar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Voltar.Location = New System.Drawing.Point(46, 260)
        Me.Voltar.Name = "Voltar"
        Me.Voltar.Size = New System.Drawing.Size(155, 27)
        Me.Voltar.TabIndex = 16
        Me.Voltar.Text = "Voltar"
        Me.Voltar.UseVisualStyleBackColor = False
        '
        'Salvar
        '
        Me.Salvar.BackColor = System.Drawing.Color.White
        Me.Salvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salvar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Salvar.Location = New System.Drawing.Point(299, 257)
        Me.Salvar.Name = "Salvar"
        Me.Salvar.Size = New System.Drawing.Size(155, 30)
        Me.Salvar.TabIndex = 0
        Me.Salvar.Text = "Salvar"
        Me.Salvar.UseVisualStyleBackColor = False
        '
        'TextSenhaAtual
        '
        Me.TextSenhaAtual.Location = New System.Drawing.Point(46, 81)
        Me.TextSenhaAtual.MaxLength = 50
        Me.TextSenhaAtual.Name = "TextSenhaAtual"
        Me.TextSenhaAtual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextSenhaAtual.Size = New System.Drawing.Size(408, 22)
        Me.TextSenhaAtual.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(43, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nova senha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Senha atual:"
        '
        'TextNovaSenha
        '
        Me.TextNovaSenha.Location = New System.Drawing.Point(46, 137)
        Me.TextNovaSenha.MaxLength = 50
        Me.TextNovaSenha.Name = "TextNovaSenha"
        Me.TextNovaSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextNovaSenha.Size = New System.Drawing.Size(408, 22)
        Me.TextNovaSenha.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(37, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(473, 195)
        Me.Panel1.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(270, 50)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Insira seus dados a seguir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para efetuar a alteração"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(3, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 33)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Edite sua senha!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.MangaApplication.My.Resources.Resources.Logo_Manga1
        Me.PictureBox1.Location = New System.Drawing.Point(582, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(309, 505)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(43, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Confirmar senha:"
        '
        'TextConfirmarSenha
        '
        Me.TextConfirmarSenha.Location = New System.Drawing.Point(46, 191)
        Me.TextConfirmarSenha.MaxLength = 50
        Me.TextConfirmarSenha.Name = "TextConfirmarSenha"
        Me.TextConfirmarSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextConfirmarSenha.Size = New System.Drawing.Size(408, 22)
        Me.TextConfirmarSenha.TabIndex = 18
        '
        'TextUsuario
        '
        Me.TextUsuario.Location = New System.Drawing.Point(46, 25)
        Me.TextUsuario.MaxLength = 50
        Me.TextUsuario.Name = "TextUsuario"
        Me.TextUsuario.Size = New System.Drawing.Size(408, 22)
        Me.TextUsuario.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(43, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Usuário (E-mail):"
        '
        'MostrarSenha
        '
        Me.MostrarSenha.AutoSize = True
        Me.MostrarSenha.Location = New System.Drawing.Point(46, 219)
        Me.MostrarSenha.Name = "MostrarSenha"
        Me.MostrarSenha.Size = New System.Drawing.Size(112, 20)
        Me.MostrarSenha.TabIndex = 21
        Me.MostrarSenha.Text = "Mostrar senha"
        Me.MostrarSenha.UseVisualStyleBackColor = True
        '
        'FormEditarSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(928, 561)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Painel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormEditarSenha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormEditarSenha"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Painel.ResumeLayout(False)
        Me.Painel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Painel As Panel
    Friend WithEvents Salvar As Button
    Friend WithEvents TextSenhaAtual As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextNovaSenha As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Voltar As Button
    Friend WithEvents TextConfirmarSenha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextUsuario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MostrarSenha As CheckBox
End Class

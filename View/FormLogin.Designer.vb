<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextSenha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Login = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextUsuario = New System.Windows.Forms.TextBox()
        Me.Painel = New System.Windows.Forms.Panel()
        Me.Fechar = New System.Windows.Forms.Button()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelCadastro = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MostrarSenha = New System.Windows.Forms.CheckBox()
        Me.Painel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(115, 205)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(0, 13)
        Me.LinkLabel1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(2, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(270, 66)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Bem Vindo à " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Manga Application !"
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
        Me.Label4.Text = "Insira seus dados a seguir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para efetuar o Login"
        '
        'TextSenha
        '
        Me.TextSenha.Location = New System.Drawing.Point(46, 112)
        Me.TextSenha.MaxLength = 50
        Me.TextSenha.Name = "TextSenha"
        Me.TextSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextSenha.Size = New System.Drawing.Size(408, 22)
        Me.TextSenha.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuário (E-mail):"
        '
        'Login
        '
        Me.Login.BackColor = System.Drawing.Color.White
        Me.Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Login.Location = New System.Drawing.Point(299, 153)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(155, 30)
        Me.Login.TabIndex = 0
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(43, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Senha:"
        '
        'TextUsuario
        '
        Me.TextUsuario.Location = New System.Drawing.Point(46, 57)
        Me.TextUsuario.MaxLength = 50
        Me.TextUsuario.Name = "TextUsuario"
        Me.TextUsuario.Size = New System.Drawing.Size(408, 22)
        Me.TextUsuario.TabIndex = 1
        '
        'Painel
        '
        Me.Painel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Painel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Painel.Controls.Add(Me.MostrarSenha)
        Me.Painel.Controls.Add(Me.Fechar)
        Me.Painel.Controls.Add(Me.LinkLabel2)
        Me.Painel.Controls.Add(Me.LinkLabelCadastro)
        Me.Painel.Controls.Add(Me.Login)
        Me.Painel.Controls.Add(Me.TextUsuario)
        Me.Painel.Controls.Add(Me.Label2)
        Me.Painel.Controls.Add(Me.Label1)
        Me.Painel.Controls.Add(Me.TextSenha)
        Me.Painel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Painel.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Painel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Painel.Location = New System.Drawing.Point(18, 233)
        Me.Painel.Name = "Painel"
        Me.Painel.Size = New System.Drawing.Size(472, 300)
        Me.Painel.TabIndex = 7
        '
        'Fechar
        '
        Me.Fechar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Fechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Fechar.ForeColor = System.Drawing.Color.White
        Me.Fechar.Location = New System.Drawing.Point(46, 274)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(75, 23)
        Me.Fechar.TabIndex = 11
        Me.Fechar.Text = "Fechar"
        Me.Fechar.UseVisualStyleBackColor = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkColor = System.Drawing.Color.DarkGoldenrod
        Me.LinkLabel2.Location = New System.Drawing.Point(46, 244)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(83, 16)
        Me.LinkLabel2.TabIndex = 7
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Editar senha"
        '
        'LinkLabelCadastro
        '
        Me.LinkLabelCadastro.AutoSize = True
        Me.LinkLabelCadastro.LinkColor = System.Drawing.Color.DarkGoldenrod
        Me.LinkLabelCadastro.Location = New System.Drawing.Point(46, 210)
        Me.LinkLabelCadastro.Name = "LinkLabelCadastro"
        Me.LinkLabelCadastro.Size = New System.Drawing.Size(140, 16)
        Me.LinkLabelCadastro.TabIndex = 6
        Me.LinkLabelCadastro.TabStop = True
        Me.LinkLabelCadastro.Text = "Não possui cadastro?"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(18, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(473, 195)
        Me.Panel1.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.MangaApplication.My.Resources.Resources.Logo_Manga1
        Me.PictureBox1.Location = New System.Drawing.Point(563, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(309, 505)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'MostrarSenha
        '
        Me.MostrarSenha.AutoSize = True
        Me.MostrarSenha.Location = New System.Drawing.Point(48, 163)
        Me.MostrarSenha.Name = "MostrarSenha"
        Me.MostrarSenha.Size = New System.Drawing.Size(112, 20)
        Me.MostrarSenha.TabIndex = 12
        Me.MostrarSenha.Text = "Mostrar senha"
        Me.MostrarSenha.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(928, 561)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Painel)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manga Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Painel.ResumeLayout(False)
        Me.Painel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextSenha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Login As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextUsuario As TextBox
    Friend WithEvents Painel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabelCadastro As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Fechar As Button
    Friend WithEvents MostrarSenha As CheckBox
End Class

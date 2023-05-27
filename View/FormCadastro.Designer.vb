<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCadastro
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
        Me.Cadastro = New System.Windows.Forms.Button()
        Me.TextUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextSenha = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Voltar = New System.Windows.Forms.Button()
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
        Me.LinkLabel1.TabIndex = 11
        '
        'Painel
        '
        Me.Painel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Painel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Painel.Controls.Add(Me.Voltar)
        Me.Painel.Controls.Add(Me.Cadastro)
        Me.Painel.Controls.Add(Me.TextUsuario)
        Me.Painel.Controls.Add(Me.Label2)
        Me.Painel.Controls.Add(Me.Label1)
        Me.Painel.Controls.Add(Me.TextSenha)
        Me.Painel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Painel.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Painel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Painel.Location = New System.Drawing.Point(37, 217)
        Me.Painel.Name = "Painel"
        Me.Painel.Size = New System.Drawing.Size(472, 300)
        Me.Painel.TabIndex = 13
        '
        'Cadastro
        '
        Me.Cadastro.BackColor = System.Drawing.Color.White
        Me.Cadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cadastro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cadastro.Location = New System.Drawing.Point(159, 157)
        Me.Cadastro.Name = "Cadastro"
        Me.Cadastro.Size = New System.Drawing.Size(155, 30)
        Me.Cadastro.TabIndex = 0
        Me.Cadastro.Text = "Cadastrar"
        Me.Cadastro.UseVisualStyleBackColor = False
        '
        'TextUsuario
        '
        Me.TextUsuario.Location = New System.Drawing.Point(46, 57)
        Me.TextUsuario.MaxLength = 50
        Me.TextUsuario.Name = "TextUsuario"
        Me.TextUsuario.Size = New System.Drawing.Size(408, 22)
        Me.TextUsuario.TabIndex = 1
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
        'TextSenha
        '
        Me.TextSenha.Location = New System.Drawing.Point(46, 112)
        Me.TextSenha.MaxLength = 50
        Me.TextSenha.Name = "TextSenha"
        Me.TextSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextSenha.Size = New System.Drawing.Size(408, 22)
        Me.TextSenha.TabIndex = 2
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
        Me.Panel1.TabIndex = 14
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
        Me.Label4.Text = "Insira seus dados a seguir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para efetuar o Cadastro"
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
        Me.Label3.Text = "Cadastre-se na" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Manga Application !"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.MangaApplication.My.Resources.Resources.Logo_Manga1
        Me.PictureBox1.Location = New System.Drawing.Point(582, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(309, 505)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Voltar
        '
        Me.Voltar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Voltar.BackColor = System.Drawing.Color.White
        Me.Voltar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Voltar.Location = New System.Drawing.Point(159, 204)
        Me.Voltar.Name = "Voltar"
        Me.Voltar.Size = New System.Drawing.Size(155, 27)
        Me.Voltar.TabIndex = 15
        Me.Voltar.Text = "Voltar"
        Me.Voltar.UseVisualStyleBackColor = False
        '
        'FormCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(928, 561)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Painel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manga Cadastro"
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
    Friend WithEvents Cadastro As Button
    Friend WithEvents TextUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextSenha As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Voltar As Button
End Class

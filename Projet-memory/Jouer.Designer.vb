<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jouer
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_NomDuJoueur = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_TempsRestant = New System.Windows.Forms.Label()
        Me.Button_Abandon = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button_ArreterTimer = New System.Windows.Forms.Button()
        Me.Button_ReprendreTimer = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Joueur :"
        '
        'Label_NomDuJoueur
        '
        Me.Label_NomDuJoueur.AutoSize = True
        Me.Label_NomDuJoueur.Location = New System.Drawing.Point(115, 29)
        Me.Label_NomDuJoueur.Name = "Label_NomDuJoueur"
        Me.Label_NomDuJoueur.Size = New System.Drawing.Size(34, 17)
        Me.Label_NomDuJoueur.TabIndex = 1
        Me.Label_NomDuJoueur.Text = "vide"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(234, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "- Temps restant :"
        '
        'Label_TempsRestant
        '
        Me.Label_TempsRestant.AutoSize = True
        Me.Label_TempsRestant.Location = New System.Drawing.Point(365, 29)
        Me.Label_TempsRestant.Name = "Label_TempsRestant"
        Me.Label_TempsRestant.Size = New System.Drawing.Size(0, 17)
        Me.Label_TempsRestant.TabIndex = 3
        '
        'Button_Abandon
        '
        Me.Button_Abandon.Location = New System.Drawing.Point(507, 29)
        Me.Button_Abandon.Name = "Button_Abandon"
        Me.Button_Abandon.Size = New System.Drawing.Size(131, 76)
        Me.Button_Abandon.TabIndex = 5
        Me.Button_Abandon.Text = "Abandon"
        Me.Button_Abandon.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button_ArreterTimer
        '
        Me.Button_ArreterTimer.Location = New System.Drawing.Point(216, 64)
        Me.Button_ArreterTimer.Name = "Button_ArreterTimer"
        Me.Button_ArreterTimer.Size = New System.Drawing.Size(89, 41)
        Me.Button_ArreterTimer.TabIndex = 49
        Me.Button_ArreterTimer.Text = "Button1"
        Me.Button_ArreterTimer.UseVisualStyleBackColor = True
        '
        'Button_ReprendreTimer
        '
        Me.Button_ReprendreTimer.Location = New System.Drawing.Point(349, 64)
        Me.Button_ReprendreTimer.Name = "Button_ReprendreTimer"
        Me.Button_ReprendreTimer.Size = New System.Drawing.Size(93, 41)
        Me.Button_ReprendreTimer.TabIndex = 50
        Me.Button_ReprendreTimer.Text = "Button2"
        Me.Button_ReprendreTimer.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox3.Location = New System.Drawing.Point(418, 284)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 54
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox4.Location = New System.Drawing.Point(293, 284)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 53
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox5.Location = New System.Drawing.Point(169, 284)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 57
        Me.PictureBox5.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox7.Location = New System.Drawing.Point(44, 284)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 56
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox8.Location = New System.Drawing.Point(548, 284)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox8.TabIndex = 59
        Me.PictureBox8.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox1.Location = New System.Drawing.Point(548, 445)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox2.Location = New System.Drawing.Point(169, 445)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 63
        Me.PictureBox2.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox6.Location = New System.Drawing.Point(44, 445)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 62
        Me.PictureBox6.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox9.Location = New System.Drawing.Point(418, 445)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox9.TabIndex = 61
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox10.Location = New System.Drawing.Point(293, 445)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox10.TabIndex = 60
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox11.Location = New System.Drawing.Point(548, 605)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox11.TabIndex = 69
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox12.Location = New System.Drawing.Point(169, 605)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox12.TabIndex = 68
        Me.PictureBox12.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox13.Location = New System.Drawing.Point(44, 605)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox13.TabIndex = 67
        Me.PictureBox13.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox14.Location = New System.Drawing.Point(418, 605)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox14.TabIndex = 66
        Me.PictureBox14.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox15.Location = New System.Drawing.Point(293, 605)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox15.TabIndex = 65
        Me.PictureBox15.TabStop = False
        '
        'PictureBox16
        '
        Me.PictureBox16.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox16.Location = New System.Drawing.Point(548, 128)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox16.TabIndex = 74
        Me.PictureBox16.TabStop = False
        '
        'PictureBox17
        '
        Me.PictureBox17.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox17.Location = New System.Drawing.Point(169, 128)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox17.TabIndex = 73
        Me.PictureBox17.TabStop = False
        '
        'PictureBox_1
        '
        Me.PictureBox_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox_1.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_1.Location = New System.Drawing.Point(44, 128)
        Me.PictureBox_1.Name = "PictureBox_1"
        Me.PictureBox_1.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_1.TabIndex = 72
        Me.PictureBox_1.TabStop = False
        '
        'PictureBox19
        '
        Me.PictureBox19.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox19.Location = New System.Drawing.Point(418, 128)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox19.TabIndex = 71
        Me.PictureBox19.TabStop = False
        '
        'PictureBox20
        '
        Me.PictureBox20.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox20.Location = New System.Drawing.Point(293, 128)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox20.TabIndex = 70
        Me.PictureBox20.TabStop = False
        '
        'Jouer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 790)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.PictureBox_1)
        Me.Controls.Add(Me.PictureBox19)
        Me.Controls.Add(Me.PictureBox20)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Button_ReprendreTimer)
        Me.Controls.Add(Me.Button_ArreterTimer)
        Me.Controls.Add(Me.Button_Abandon)
        Me.Controls.Add(Me.Label_TempsRestant)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label_NomDuJoueur)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Jouer"
        Me.Text = "Memory"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label_NomDuJoueur As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_TempsRestant As Label
    Friend WithEvents Button_Abandon As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button_ArreterTimer As Button
    Friend WithEvents Button_ReprendreTimer As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox_1 As PictureBox
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents PictureBox20 As PictureBox
End Class

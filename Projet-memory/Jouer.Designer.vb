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
        Me.PictureBox_9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_20 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_19 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_18 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.PictureBox21 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Button_ArreterTimer.Text = "Pause"
        Me.Button_ArreterTimer.UseVisualStyleBackColor = True
        '
        'Button_ReprendreTimer
        '
        Me.Button_ReprendreTimer.Location = New System.Drawing.Point(349, 64)
        Me.Button_ReprendreTimer.Name = "Button_ReprendreTimer"
        Me.Button_ReprendreTimer.Size = New System.Drawing.Size(93, 41)
        Me.Button_ReprendreTimer.TabIndex = 50
        Me.Button_ReprendreTimer.Text = "Reprendre"
        Me.Button_ReprendreTimer.UseVisualStyleBackColor = True
        '
        'PictureBox_9
        '
        Me.PictureBox_9.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_9.Location = New System.Drawing.Point(418, 284)
        Me.PictureBox_9.Name = "PictureBox_9"
        Me.PictureBox_9.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_9.TabIndex = 54
        Me.PictureBox_9.TabStop = False
        '
        'PictureBox_8
        '
        Me.PictureBox_8.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_8.Location = New System.Drawing.Point(293, 284)
        Me.PictureBox_8.Name = "PictureBox_8"
        Me.PictureBox_8.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_8.TabIndex = 53
        Me.PictureBox_8.TabStop = False
        '
        'PictureBox_7
        '
        Me.PictureBox_7.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_7.Location = New System.Drawing.Point(169, 284)
        Me.PictureBox_7.Name = "PictureBox_7"
        Me.PictureBox_7.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_7.TabIndex = 57
        Me.PictureBox_7.TabStop = False
        '
        'PictureBox_6
        '
        Me.PictureBox_6.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_6.Location = New System.Drawing.Point(44, 284)
        Me.PictureBox_6.Name = "PictureBox_6"
        Me.PictureBox_6.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_6.TabIndex = 56
        Me.PictureBox_6.TabStop = False
        '
        'PictureBox_10
        '
        Me.PictureBox_10.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_10.Location = New System.Drawing.Point(548, 284)
        Me.PictureBox_10.Name = "PictureBox_10"
        Me.PictureBox_10.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_10.TabIndex = 59
        Me.PictureBox_10.TabStop = False
        '
        'PictureBox_15
        '
        Me.PictureBox_15.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_15.Location = New System.Drawing.Point(548, 445)
        Me.PictureBox_15.Name = "PictureBox_15"
        Me.PictureBox_15.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_15.TabIndex = 64
        Me.PictureBox_15.TabStop = False
        '
        'PictureBox_12
        '
        Me.PictureBox_12.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_12.Location = New System.Drawing.Point(169, 445)
        Me.PictureBox_12.Name = "PictureBox_12"
        Me.PictureBox_12.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_12.TabIndex = 63
        Me.PictureBox_12.TabStop = False
        '
        'PictureBox_11
        '
        Me.PictureBox_11.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_11.Location = New System.Drawing.Point(44, 445)
        Me.PictureBox_11.Name = "PictureBox_11"
        Me.PictureBox_11.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_11.TabIndex = 62
        Me.PictureBox_11.TabStop = False
        '
        'PictureBox_14
        '
        Me.PictureBox_14.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_14.Location = New System.Drawing.Point(418, 445)
        Me.PictureBox_14.Name = "PictureBox_14"
        Me.PictureBox_14.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_14.TabIndex = 61
        Me.PictureBox_14.TabStop = False
        '
        'PictureBox_13
        '
        Me.PictureBox_13.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_13.Location = New System.Drawing.Point(293, 445)
        Me.PictureBox_13.Name = "PictureBox_13"
        Me.PictureBox_13.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_13.TabIndex = 60
        Me.PictureBox_13.TabStop = False
        '
        'PictureBox_20
        '
        Me.PictureBox_20.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_20.Location = New System.Drawing.Point(548, 605)
        Me.PictureBox_20.Name = "PictureBox_20"
        Me.PictureBox_20.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_20.TabIndex = 69
        Me.PictureBox_20.TabStop = False
        '
        'PictureBox_17
        '
        Me.PictureBox_17.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_17.Location = New System.Drawing.Point(169, 605)
        Me.PictureBox_17.Name = "PictureBox_17"
        Me.PictureBox_17.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_17.TabIndex = 68
        Me.PictureBox_17.TabStop = False
        '
        'PictureBox_16
        '
        Me.PictureBox_16.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_16.Location = New System.Drawing.Point(44, 605)
        Me.PictureBox_16.Name = "PictureBox_16"
        Me.PictureBox_16.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_16.TabIndex = 67
        Me.PictureBox_16.TabStop = False
        '
        'PictureBox_19
        '
        Me.PictureBox_19.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_19.Location = New System.Drawing.Point(418, 605)
        Me.PictureBox_19.Name = "PictureBox_19"
        Me.PictureBox_19.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_19.TabIndex = 66
        Me.PictureBox_19.TabStop = False
        '
        'PictureBox_18
        '
        Me.PictureBox_18.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_18.Location = New System.Drawing.Point(293, 605)
        Me.PictureBox_18.Name = "PictureBox_18"
        Me.PictureBox_18.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_18.TabIndex = 65
        Me.PictureBox_18.TabStop = False
        '
        'PictureBox_5
        '
        Me.PictureBox_5.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_5.Location = New System.Drawing.Point(548, 128)
        Me.PictureBox_5.Name = "PictureBox_5"
        Me.PictureBox_5.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_5.TabIndex = 74
        Me.PictureBox_5.TabStop = False
        '
        'PictureBox_2
        '
        Me.PictureBox_2.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_2.Location = New System.Drawing.Point(169, 128)
        Me.PictureBox_2.Name = "PictureBox_2"
        Me.PictureBox_2.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_2.TabIndex = 73
        Me.PictureBox_2.TabStop = False
        '
        'PictureBox_1
        '
        Me.PictureBox_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox_1.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_1.Location = New System.Drawing.Point(44, 128)
        Me.PictureBox_1.Name = "PictureBox_1"
        Me.PictureBox_1.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_1.TabIndex = 72
        Me.PictureBox_1.TabStop = False
        '
        'PictureBox_4
        '
        Me.PictureBox_4.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_4.Location = New System.Drawing.Point(418, 128)
        Me.PictureBox_4.Name = "PictureBox_4"
        Me.PictureBox_4.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_4.TabIndex = 71
        Me.PictureBox_4.TabStop = False
        '
        'PictureBox_3
        '
        Me.PictureBox_3.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox_3.Location = New System.Drawing.Point(293, 128)
        Me.PictureBox_3.Name = "PictureBox_3"
        Me.PictureBox_3.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_3.TabIndex = 70
        Me.PictureBox_3.TabStop = False
        '
        'PictureBox18
        '
        Me.PictureBox18.Image = Global.Projet_memory.My.Resources.Resources.Capture1
        Me.PictureBox18.Location = New System.Drawing.Point(761, 128)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(99, 132)
        Me.PictureBox18.TabIndex = 75
        Me.PictureBox18.TabStop = False
        '
        'PictureBox21
        '
        Me.PictureBox21.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox21.Location = New System.Drawing.Point(803, 319)
        Me.PictureBox21.Name = "PictureBox21"
        Me.PictureBox21.Size = New System.Drawing.Size(90, 125)
        Me.PictureBox21.TabIndex = 76
        Me.PictureBox21.TabStop = False
        '
        'Jouer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Projet_memory.My.Resources.Resources.FondDessinAnimé
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(990, 901)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox21)
        Me.Controls.Add(Me.PictureBox18)
        Me.Controls.Add(Me.PictureBox_5)
        Me.Controls.Add(Me.PictureBox_2)
        Me.Controls.Add(Me.PictureBox_1)
        Me.Controls.Add(Me.PictureBox_4)
        Me.Controls.Add(Me.PictureBox_3)
        Me.Controls.Add(Me.PictureBox_20)
        Me.Controls.Add(Me.PictureBox_17)
        Me.Controls.Add(Me.PictureBox_16)
        Me.Controls.Add(Me.PictureBox_19)
        Me.Controls.Add(Me.PictureBox_18)
        Me.Controls.Add(Me.PictureBox_15)
        Me.Controls.Add(Me.PictureBox_12)
        Me.Controls.Add(Me.PictureBox_11)
        Me.Controls.Add(Me.PictureBox_14)
        Me.Controls.Add(Me.PictureBox_13)
        Me.Controls.Add(Me.PictureBox_10)
        Me.Controls.Add(Me.PictureBox_7)
        Me.Controls.Add(Me.PictureBox_6)
        Me.Controls.Add(Me.PictureBox_9)
        Me.Controls.Add(Me.PictureBox_8)
        Me.Controls.Add(Me.Button_ReprendreTimer)
        Me.Controls.Add(Me.Button_ArreterTimer)
        Me.Controls.Add(Me.Button_Abandon)
        Me.Controls.Add(Me.Label_TempsRestant)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label_NomDuJoueur)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Jouer"
        Me.Text = "Memory"
        CType(Me.PictureBox_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox_9 As PictureBox
    Friend WithEvents PictureBox_8 As PictureBox
    Friend WithEvents PictureBox_7 As PictureBox
    Friend WithEvents PictureBox_6 As PictureBox
    Friend WithEvents PictureBox_10 As PictureBox
    Friend WithEvents PictureBox_15 As PictureBox
    Friend WithEvents PictureBox_12 As PictureBox
    Friend WithEvents PictureBox_11 As PictureBox
    Friend WithEvents PictureBox_14 As PictureBox
    Friend WithEvents PictureBox_13 As PictureBox
    Friend WithEvents PictureBox_20 As PictureBox
    Friend WithEvents PictureBox_17 As PictureBox
    Friend WithEvents PictureBox_16 As PictureBox
    Friend WithEvents PictureBox_19 As PictureBox
    Friend WithEvents PictureBox_18 As PictureBox
    Friend WithEvents PictureBox_5 As PictureBox
    Friend WithEvents PictureBox_2 As PictureBox
    Friend WithEvents PictureBox_1 As PictureBox
    Friend WithEvents PictureBox_4 As PictureBox
    Friend WithEvents PictureBox_3 As PictureBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents PictureBox21 As PictureBox
End Class

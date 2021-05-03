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
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label18
        '
        Me.Label18.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.Label18.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label18.Location = New System.Drawing.Point(523, 588)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(115, 160)
        Me.Label18.TabIndex = 48
        '
        'Label19
        '
        Me.Label19.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label19.Location = New System.Drawing.Point(402, 588)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(115, 160)
        Me.Label19.TabIndex = 47
        '
        'Label20
        '
        Me.Label20.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.Label20.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label20.Location = New System.Drawing.Point(281, 588)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(115, 160)
        Me.Label20.TabIndex = 46
        '
        'Label21
        '
        Me.Label21.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.Label21.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label21.Location = New System.Drawing.Point(160, 588)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(115, 160)
        Me.Label21.TabIndex = 45
        '
        'Label22
        '
        Me.Label22.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.Label22.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label22.Location = New System.Drawing.Point(39, 588)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(115, 160)
        Me.Label22.TabIndex = 44
        '
        'Label13
        '
        Me.Label13.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label13.Location = New System.Drawing.Point(523, 428)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 160)
        Me.Label13.TabIndex = 43
        '
        'Label14
        '
        Me.Label14.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label14.Location = New System.Drawing.Point(402, 428)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 160)
        Me.Label14.TabIndex = 42
        '
        'Label15
        '
        Me.Label15.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label15.Location = New System.Drawing.Point(281, 428)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(115, 160)
        Me.Label15.TabIndex = 41
        '
        'Label16
        '
        Me.Label16.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.Label16.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label16.Location = New System.Drawing.Point(160, 428)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 160)
        Me.Label16.TabIndex = 40
        '
        'Label17
        '
        Me.Label17.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.Label17.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label17.Location = New System.Drawing.Point(39, 428)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(115, 160)
        Me.Label17.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label8.Location = New System.Drawing.Point(523, 268)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 160)
        Me.Label8.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label9.Location = New System.Drawing.Point(402, 268)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 160)
        Me.Label9.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label10.Location = New System.Drawing.Point(281, 268)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 160)
        Me.Label10.TabIndex = 36
        '
        'Label11
        '
        Me.Label11.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label11.Location = New System.Drawing.Point(160, 268)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 160)
        Me.Label11.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label12.Location = New System.Drawing.Point(39, 268)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 160)
        Me.Label12.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label7.Location = New System.Drawing.Point(523, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 160)
        Me.Label7.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label5.Location = New System.Drawing.Point(402, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 160)
        Me.Label5.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label4.Location = New System.Drawing.Point(281, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 160)
        Me.Label4.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label2.Location = New System.Drawing.Point(160, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 160)
        Me.Label2.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label6.Location = New System.Drawing.Point(39, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 160)
        Me.Label6.TabIndex = 29
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox1.Location = New System.Drawing.Point(684, 138)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 162)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'Jouer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 790)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button_ReprendreTimer)
        Me.Controls.Add(Me.Button_ArreterTimer)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button_Abandon)
        Me.Controls.Add(Me.Label_TempsRestant)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label_NomDuJoueur)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Jouer"
        Me.Text = "Memory"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label_NomDuJoueur As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_TempsRestant As Label
    Friend WithEvents Button_Abandon As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button_ArreterTimer As Button
    Friend WithEvents Button_ReprendreTimer As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

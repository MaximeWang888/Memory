<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label_Entrezvotrenom = New System.Windows.Forms.Label()
        Me.Button_Jouer = New System.Windows.Forms.Button()
        Me.ButtonOptions = New System.Windows.Forms.Button()
        Me.ButtonScores = New System.Windows.Forms.Button()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.Label_Nom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label_Entrezvotrenom
        '
        Me.Label_Entrezvotrenom.AutoSize = True
        Me.Label_Entrezvotrenom.Location = New System.Drawing.Point(120, 169)
        Me.Label_Entrezvotrenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Entrezvotrenom.Name = "Label_Entrezvotrenom"
        Me.Label_Entrezvotrenom.Size = New System.Drawing.Size(124, 17)
        Me.Label_Entrezvotrenom.TabIndex = 0
        Me.Label_Entrezvotrenom.Text = "Entrez votre nom :"
        '
        'Button_Jouer
        '
        Me.Button_Jouer.Enabled = False
        Me.Button_Jouer.Location = New System.Drawing.Point(285, 246)
        Me.Button_Jouer.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Jouer.Name = "Button_Jouer"
        Me.Button_Jouer.Size = New System.Drawing.Size(100, 28)
        Me.Button_Jouer.TabIndex = 1
        Me.Button_Jouer.Text = "Jouer"
        Me.Button_Jouer.UseVisualStyleBackColor = True
        '
        'ButtonOptions
        '
        Me.ButtonOptions.Location = New System.Drawing.Point(285, 299)
        Me.ButtonOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonOptions.Name = "ButtonOptions"
        Me.ButtonOptions.Size = New System.Drawing.Size(100, 28)
        Me.ButtonOptions.TabIndex = 2
        Me.ButtonOptions.Text = "Options"
        Me.ButtonOptions.UseVisualStyleBackColor = True
        '
        'ButtonScores
        '
        Me.ButtonScores.Location = New System.Drawing.Point(285, 358)
        Me.ButtonScores.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonScores.Name = "ButtonScores"
        Me.ButtonScores.Size = New System.Drawing.Size(100, 28)
        Me.ButtonScores.TabIndex = 3
        Me.ButtonScores.Text = "Scores"
        Me.ButtonScores.UseVisualStyleBackColor = True
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Location = New System.Drawing.Point(285, 414)
        Me.ButtonQuitter.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(100, 28)
        Me.ButtonQuitter.TabIndex = 4
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'Label_Nom
        '
        Me.Label_Nom.Location = New System.Drawing.Point(252, 166)
        Me.Label_Nom.Margin = New System.Windows.Forms.Padding(4)
        Me.Label_Nom.Name = "Label_Nom"
        Me.Label_Nom.Size = New System.Drawing.Size(309, 22)
        Me.Label_Nom.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bauhaus 93", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(333, 76)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "4 Memory"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bauhaus 93", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(281, 118)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "a concentration game"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 508)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label_Nom)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ButtonScores)
        Me.Controls.Add(Me.ButtonOptions)
        Me.Controls.Add(Me.Button_Jouer)
        Me.Controls.Add(Me.Label_Entrezvotrenom)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Entrezvotrenom As Label
    Friend WithEvents Button_Jouer As Button
    Friend WithEvents ButtonOptions As Button
    Friend WithEvents ButtonScores As Button
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents Label_Nom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label3 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Memory
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Memory))
        Me.Label_Entrezvotrenom = New System.Windows.Forms.Label()
        Me.Button_Jouer = New System.Windows.Forms.Button()
        Me.ButtonOptions = New System.Windows.Forms.Button()
        Me.ButtonScores = New System.Windows.Forms.Button()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LabelTest = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label_Entrezvotrenom
        '
        resources.ApplyResources(Me.Label_Entrezvotrenom, "Label_Entrezvotrenom")
        Me.Label_Entrezvotrenom.Name = "Label_Entrezvotrenom"
        '
        'Button_Jouer
        '
        resources.ApplyResources(Me.Button_Jouer, "Button_Jouer")
        Me.Button_Jouer.Name = "Button_Jouer"
        Me.Button_Jouer.UseVisualStyleBackColor = True
        '
        'ButtonOptions
        '
        resources.ApplyResources(Me.ButtonOptions, "ButtonOptions")
        Me.ButtonOptions.Name = "ButtonOptions"
        Me.ButtonOptions.UseVisualStyleBackColor = True
        '
        'ButtonScores
        '
        resources.ApplyResources(Me.ButtonScores, "ButtonScores")
        Me.ButtonScores.Name = "ButtonScores"
        Me.ButtonScores.UseVisualStyleBackColor = True
        '
        'ButtonQuitter
        '
        resources.ApplyResources(Me.ButtonQuitter, "ButtonQuitter")
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Name = "Label3"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.Name = "ComboBox1"
        '
        'LabelTest
        '
        resources.ApplyResources(Me.LabelTest, "LabelTest")
        Me.LabelTest.Name = "LabelTest"
        '
        'Memory
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelTest)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ButtonScores)
        Me.Controls.Add(Me.ButtonOptions)
        Me.Controls.Add(Me.Button_Jouer)
        Me.Controls.Add(Me.Label_Entrezvotrenom)
        Me.Name = "Memory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Entrezvotrenom As Label
    Friend WithEvents Button_Jouer As Button
    Friend WithEvents ButtonOptions As Button
    Friend WithEvents ButtonScores As Button
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LabelTest As Label
End Class

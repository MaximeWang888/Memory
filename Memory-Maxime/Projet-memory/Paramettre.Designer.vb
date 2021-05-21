<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Paramettre
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
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxMinute = New System.Windows.Forms.TextBox()
        Me.TextBoxSecond = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonReset
        '
        Me.ButtonReset.Font = New System.Drawing.Font("Showcard Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReset.Location = New System.Drawing.Point(183, 467)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(123, 23)
        Me.ButtonReset.TabIndex = 0
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'ButtonRetour
        '
        Me.ButtonRetour.Font = New System.Drawing.Font("Showcard Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRetour.Location = New System.Drawing.Point(147, 511)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(192, 23)
        Me.ButtonRetour.TabIndex = 1
        Me.ButtonRetour.Text = "Retour"
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(70, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tempde la partie "
        '
        'TextBoxMinute
        '
        Me.TextBoxMinute.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxMinute.Font = New System.Drawing.Font("Showcard Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMinute.Location = New System.Drawing.Point(214, 58)
        Me.TextBoxMinute.MaxLength = 2
        Me.TextBoxMinute.Name = "TextBoxMinute"
        Me.TextBoxMinute.Size = New System.Drawing.Size(30, 17)
        Me.TextBoxMinute.TabIndex = 3
        Me.TextBoxMinute.Text = "01"
        Me.TextBoxMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxSecond
        '
        Me.TextBoxSecond.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSecond.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxSecond.Font = New System.Drawing.Font("Showcard Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSecond.Location = New System.Drawing.Point(324, 59)
        Me.TextBoxSecond.MaxLength = 2
        Me.TextBoxSecond.Name = "TextBoxSecond"
        Me.TextBoxSecond.Size = New System.Drawing.Size(33, 17)
        Me.TextBoxSecond.TabIndex = 2
        Me.TextBoxSecond.Text = "00"
        Me.TextBoxSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(250, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "minutes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(363, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Seconds"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Projet_memory.My.Resources.Resources.Capture4
        Me.PictureBox2.Location = New System.Drawing.Point(318, 239)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(91, 126)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox1.Image = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox1.InitialImage = Global.Projet_memory.My.Resources.Resources.BackCard
        Me.PictureBox1.Location = New System.Drawing.Point(96, 239)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(319, 414)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(85, 17)
        Me.RadioButton2.TabIndex = 10
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Theme néon"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(97, 414)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(84, 17)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Theme Alice"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(64, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(379, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Les cartes disparaissent apres avoir été trouvé"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(449, 112)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(50, 18)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.Text = "Non"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Showcard Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(64, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(320, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Les cartes aparaissent 1 second au début"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(390, 160)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(50, 18)
        Me.CheckBox3.TabIndex = 4
        Me.CheckBox3.Text = "Non"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Paramettre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 561)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.TextBoxSecond)
        Me.Controls.Add(Me.TextBoxMinute)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.ButtonReset)
        Me.Name = "Paramettre"
        Me.Text = "Option"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonReset As Button
    Friend WithEvents ButtonRetour As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxMinute As TextBox
    Friend WithEvents TextBoxSecond As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox3 As CheckBox
End Class

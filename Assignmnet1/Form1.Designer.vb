<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.EarthWeightLabel = New System.Windows.Forms.Label()
        Me.VenusWeightLabel = New System.Windows.Forms.Label()
        Me.MarsWeightLabel = New System.Windows.Forms.Label()
        Me.JupiterWeightLabel = New System.Windows.Forms.Label()
        Me.EarthWeightTextBox = New System.Windows.Forms.TextBox()
        Me.VenusWeightTextBox = New System.Windows.Forms.TextBox()
        Me.MarsWeightTextBox = New System.Windows.Forms.TextBox()
        Me.JupiterWeightTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EarthWeightLabel
        '
        Me.EarthWeightLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.EarthWeightLabel.AutoSize = True
        Me.EarthWeightLabel.Location = New System.Drawing.Point(281, 94)
        Me.EarthWeightLabel.Name = "EarthWeightLabel"
        Me.EarthWeightLabel.Size = New System.Drawing.Size(95, 20)
        Me.EarthWeightLabel.TabIndex = 0
        Me.EarthWeightLabel.Tag = ""
        Me.EarthWeightLabel.Text = "&Earth weight:"
        '
        'VenusWeightLabel
        '
        Me.VenusWeightLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.VenusWeightLabel.AutoSize = True
        Me.VenusWeightLabel.Location = New System.Drawing.Point(109, 231)
        Me.VenusWeightLabel.Name = "VenusWeightLabel"
        Me.VenusWeightLabel.Size = New System.Drawing.Size(99, 20)
        Me.VenusWeightLabel.TabIndex = 1
        Me.VenusWeightLabel.Tag = ""
        Me.VenusWeightLabel.Text = "Venus weight:"
        Me.VenusWeightLabel.UseMnemonic = False
        '
        'MarsWeightLabel
        '
        Me.MarsWeightLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.MarsWeightLabel.AutoSize = True
        Me.MarsWeightLabel.Location = New System.Drawing.Point(302, 231)
        Me.MarsWeightLabel.Name = "MarsWeightLabel"
        Me.MarsWeightLabel.Size = New System.Drawing.Size(93, 20)
        Me.MarsWeightLabel.TabIndex = 2
        Me.MarsWeightLabel.Tag = ""
        Me.MarsWeightLabel.Text = "Mars weight:"
        Me.MarsWeightLabel.UseMnemonic = False
        '
        'JupiterWeightLabel
        '
        Me.JupiterWeightLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.JupiterWeightLabel.AutoSize = True
        Me.JupiterWeightLabel.Location = New System.Drawing.Point(517, 231)
        Me.JupiterWeightLabel.Name = "JupiterWeightLabel"
        Me.JupiterWeightLabel.Size = New System.Drawing.Size(105, 20)
        Me.JupiterWeightLabel.TabIndex = 3
        Me.JupiterWeightLabel.Tag = ""
        Me.JupiterWeightLabel.Text = "Jupiter weight:"
        Me.JupiterWeightLabel.UseMnemonic = False
        '
        'EarthWeightTextBox
        '
        Me.EarthWeightTextBox.Location = New System.Drawing.Point(398, 91)
        Me.EarthWeightTextBox.Name = "EarthWeightTextBox"
        Me.EarthWeightTextBox.Size = New System.Drawing.Size(125, 27)
        Me.EarthWeightTextBox.TabIndex = 0
        '
        'VenusWeightTextBox
        '
        Me.VenusWeightTextBox.Enabled = False
        Me.VenusWeightTextBox.Location = New System.Drawing.Point(109, 265)
        Me.VenusWeightTextBox.Name = "VenusWeightTextBox"
        Me.VenusWeightTextBox.Size = New System.Drawing.Size(125, 27)
        Me.VenusWeightTextBox.TabIndex = 5
        Me.VenusWeightTextBox.TabStop = False
        '
        'MarsWeightTextBox
        '
        Me.MarsWeightTextBox.Enabled = False
        Me.MarsWeightTextBox.Location = New System.Drawing.Point(302, 265)
        Me.MarsWeightTextBox.Name = "MarsWeightTextBox"
        Me.MarsWeightTextBox.Size = New System.Drawing.Size(125, 27)
        Me.MarsWeightTextBox.TabIndex = 6
        Me.MarsWeightTextBox.TabStop = False
        '
        'JupiterWeightTextBox
        '
        Me.JupiterWeightTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.JupiterWeightTextBox.Enabled = False
        Me.JupiterWeightTextBox.Location = New System.Drawing.Point(517, 265)
        Me.JupiterWeightTextBox.Name = "JupiterWeightTextBox"
        Me.JupiterWeightTextBox.Size = New System.Drawing.Size(125, 27)
        Me.JupiterWeightTextBox.TabIndex = 7
        Me.JupiterWeightTextBox.TabStop = False
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(235, 327)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(94, 29)
        Me.CalculateButton.TabIndex = 1
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(398, 327)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(94, 29)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.JupiterWeightTextBox)
        Me.Controls.Add(Me.MarsWeightTextBox)
        Me.Controls.Add(Me.VenusWeightTextBox)
        Me.Controls.Add(Me.EarthWeightTextBox)
        Me.Controls.Add(Me.JupiterWeightLabel)
        Me.Controls.Add(Me.MarsWeightLabel)
        Me.Controls.Add(Me.VenusWeightLabel)
        Me.Controls.Add(Me.EarthWeightLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EarthWeightLabel As Label
    Friend WithEvents VenusWeightLabel As Label
    Friend WithEvents MarsWeightLabel As Label
    Friend WithEvents JupiterWeightLabel As Label
    Friend WithEvents EarthWeightTextBox As TextBox
    Friend WithEvents VenusWeightTextBox As TextBox
    Friend WithEvents MarsWeightTextBox As TextBox
    Friend WithEvents JupiterWeightTextBox As TextBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ExitButton As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GpaMainForm
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
        Me.AverageGPAGroupBox = New System.Windows.Forms.GroupBox()
        Me.lblFemaleStudents = New System.Windows.Forms.Label()
        Me.lblMaleStudents = New System.Windows.Forms.Label()
        Me.lblAllStudents = New System.Windows.Forms.Label()
        Me.FemaleStudentsLabel = New System.Windows.Forms.Label()
        Me.MaleStudentsLabel = New System.Windows.Forms.Label()
        Me.AllStudentsLabel = New System.Windows.Forms.Label()
        Me.FemaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.MaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GPABox = New System.Windows.Forms.ListBox()
        Me.GPALIstBoxLabel = New System.Windows.Forms.Label()
        Me.AverageGPAGroupBox.SuspendLayout
        Me.SuspendLayout
        '
        'AverageGPAGroupBox
        '
        Me.AverageGPAGroupBox.Controls.Add(Me.lblFemaleStudents)
        Me.AverageGPAGroupBox.Controls.Add(Me.lblMaleStudents)
        Me.AverageGPAGroupBox.Controls.Add(Me.lblAllStudents)
        Me.AverageGPAGroupBox.Controls.Add(Me.FemaleStudentsLabel)
        Me.AverageGPAGroupBox.Controls.Add(Me.MaleStudentsLabel)
        Me.AverageGPAGroupBox.Controls.Add(Me.AllStudentsLabel)
        Me.AverageGPAGroupBox.Location = New System.Drawing.Point(36, 135)
        Me.AverageGPAGroupBox.Name = "AverageGPAGroupBox"
        Me.AverageGPAGroupBox.Size = New System.Drawing.Size(293, 97)
        Me.AverageGPAGroupBox.TabIndex = 0
        Me.AverageGPAGroupBox.TabStop = false
        Me.AverageGPAGroupBox.Text = "Average GPA"
        '
        'lblFemaleStudents
        '
        Me.lblFemaleStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFemaleStudents.Location = New System.Drawing.Point(190, 48)
        Me.lblFemaleStudents.Name = "lblFemaleStudents"
        Me.lblFemaleStudents.Size = New System.Drawing.Size(87, 20)
        Me.lblFemaleStudents.TabIndex = 9
        '
        'lblMaleStudents
        '
        Me.lblMaleStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaleStudents.Location = New System.Drawing.Point(95, 48)
        Me.lblMaleStudents.Name = "lblMaleStudents"
        Me.lblMaleStudents.Size = New System.Drawing.Size(81, 20)
        Me.lblMaleStudents.TabIndex = 8
        '
        'lblAllStudents
        '
        Me.lblAllStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAllStudents.Location = New System.Drawing.Point(16, 48)
        Me.lblAllStudents.Name = "lblAllStudents"
        Me.lblAllStudents.Size = New System.Drawing.Size(73, 20)
        Me.lblAllStudents.TabIndex = 7
        '
        'FemaleStudentsLabel
        '
        Me.FemaleStudentsLabel.AutoSize = true
        Me.FemaleStudentsLabel.Location = New System.Drawing.Point(187, 35)
        Me.FemaleStudentsLabel.Name = "FemaleStudentsLabel"
        Me.FemaleStudentsLabel.Size = New System.Drawing.Size(87, 13)
        Me.FemaleStudentsLabel.TabIndex = 6
        Me.FemaleStudentsLabel.Text = "Female students:"
        '
        'MaleStudentsLabel
        '
        Me.MaleStudentsLabel.AutoSize = true
        Me.MaleStudentsLabel.Location = New System.Drawing.Point(93, 35)
        Me.MaleStudentsLabel.Name = "MaleStudentsLabel"
        Me.MaleStudentsLabel.Size = New System.Drawing.Size(76, 13)
        Me.MaleStudentsLabel.TabIndex = 5
        Me.MaleStudentsLabel.Text = "Male students:"
        '
        'AllStudentsLabel
        '
        Me.AllStudentsLabel.AutoSize = true
        Me.AllStudentsLabel.Location = New System.Drawing.Point(17, 35)
        Me.AllStudentsLabel.Name = "AllStudentsLabel"
        Me.AllStudentsLabel.Size = New System.Drawing.Size(64, 13)
        Me.AllStudentsLabel.TabIndex = 4
        Me.AllStudentsLabel.Text = "All students:"
        '
        'FemaleRadioButton
        '
        Me.FemaleRadioButton.AutoSize = true
        Me.FemaleRadioButton.Location = New System.Drawing.Point(66, 21)
        Me.FemaleRadioButton.Name = "FemaleRadioButton"
        Me.FemaleRadioButton.Size = New System.Drawing.Size(59, 17)
        Me.FemaleRadioButton.TabIndex = 1
        Me.FemaleRadioButton.TabStop = true
        Me.FemaleRadioButton.Text = "&Female"
        Me.FemaleRadioButton.UseVisualStyleBackColor = true
        '
        'MaleRadioButton
        '
        Me.MaleRadioButton.AutoSize = true
        Me.MaleRadioButton.Location = New System.Drawing.Point(66, 57)
        Me.MaleRadioButton.Name = "MaleRadioButton"
        Me.MaleRadioButton.Size = New System.Drawing.Size(48, 17)
        Me.MaleRadioButton.TabIndex = 2
        Me.MaleRadioButton.TabStop = true
        Me.MaleRadioButton.Text = "&Male"
        Me.MaleRadioButton.UseVisualStyleBackColor = true
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(225, 32)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 3
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = true
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(225, 61)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = true
        '
        'GPABox
        '
        Me.GPABox.AccessibleName = ""
        Me.GPABox.DisplayMember = "fgdg"
        Me.GPABox.FormattingEnabled = true
        Me.GPABox.Items.AddRange(New Object() {"1.0", "1.1", "1.2", "1.3", "1.4", "1.5", "1.6", "1.7", "1.8", "1.9", "2.0", "2.2", "2.3", "2.4", "2.5", "2.6", "2.7", "2.8", "2.9", "3.0", "3.1", "3.2", "3.3", "3.4", "3.5", "3.6", "3.7", "3.8", "3.9", "4.0"})
        Me.GPABox.Location = New System.Drawing.Point(147, 32)
        Me.GPABox.Name = "GPABox"
        Me.GPABox.Size = New System.Drawing.Size(65, 82)
        Me.GPABox.Sorted = true
        Me.GPABox.TabIndex = 5
        Me.GPABox.Tag = ""
        '
        'GPALIstBoxLabel
        '
        Me.GPALIstBoxLabel.AutoSize = true
        Me.GPALIstBoxLabel.Location = New System.Drawing.Point(142, 16)
        Me.GPALIstBoxLabel.Name = "GPALIstBoxLabel"
        Me.GPALIstBoxLabel.Size = New System.Drawing.Size(32, 13)
        Me.GPALIstBoxLabel.TabIndex = 6
        Me.GPALIstBoxLabel.Text = "&GPA:"
        '
        'GPAMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 269)
        Me.Controls.Add(Me.GPALIstBoxLabel)
        Me.Controls.Add(Me.GPABox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.MaleRadioButton)
        Me.Controls.Add(Me.FemaleRadioButton)
        Me.Controls.Add(Me.AverageGPAGroupBox)
        Me.Name = "GPAMainForm"
        Me.Text = "GPA Calculator"
        Me.AverageGPAGroupBox.ResumeLayout(false)
        Me.AverageGPAGroupBox.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents AverageGPAGroupBox As GroupBox
    Friend WithEvents FemaleRadioButton As RadioButton
    Friend WithEvents MaleRadioButton As RadioButton
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents GPABox As ListBox
    Friend WithEvents GPALIstBoxLabel As Label
    Friend WithEvents FemaleStudentsLabel As Label
    Friend WithEvents MaleStudentsLabel As Label
    Friend WithEvents AllStudentsLabel As Label
    Friend WithEvents lblFemaleStudents As Label
    Friend WithEvents lblMaleStudents As Label
    Friend WithEvents lblAllStudents As Label
End Class

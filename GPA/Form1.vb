
Option Explicit On
Option Strict Off
Option Infer On
Public Class GpaMainForm

    Private Sub Gpa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GPABox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GPABox.SelectedIndexChanged
        'Clears the labels when the gpa selected index is changed.
        lblMaleStudents.Text = String.Empty
        lblFemaleStudents.Text = String.Empty
    End Sub

    Private Sub AllStudentsLabel_Click(sender As Object, e As EventArgs) Handles AllStudentsLabel.Click

    End Sub

    Private Sub FemaleRadio_CheckedChanged(sender As Object, e As EventArgs) Handles FemaleRadioButton.CheckedChanged
        lblMaleStudents.Text = String.Empty
    End Sub

    Private Sub MaleRadio_CheckedChanged(sender As Object, e As EventArgs) Handles MaleRadioButton.CheckedChanged
        lblFemaleStudents.Text = String.Empty
    End Sub


    Private Sub MaleStudentsLabel_Click(sender As Object, e As EventArgs) Handles MaleStudentsLabel.Click

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        
        'variable declarations
        Dim dblMale As Decimal
        Dim dblFemale As Decimal
        Dim dblStudents As Decimal
        Static dblTotalMale As Decimal
        Static dblTotalFemale As Decimal
        Static dblTotalGpa As Decimal
        

        'Adds to Male and AllStudents TextBoxes only if Male Radio Button is checked
        If MaleRadioButton.Checked Then
            dblMale = GPABox.SelectedItem
            dblStudents = GPABox.SelectedItem
            'Adds to Female and AllStudents TextBoxes only if Female Radio Button is checked
        ElseIf FemaleRadioButton.Checked Then
            dblFemale = GPABox.SelectedItem
            dblStudents = GPABox.SelectedItem
        End If


        'Keeps running total of Male Gpa and displays in Male TextBox
        dblTotalMale = dblTotalMale + dblMale
        lblMaleStudents.Text = dblTotalMale.ToString("N1")

        'Keeps running total of Female Gpa and displays in Female TextBox
        dblTotalFemale = dblTotalFemale + dblFemale
        lblFemaleStudents.Text = dblTotalFemale.ToString("N1")

        'Keeps running total of Male and Female Gpa and displays in AllStudents TextBox
        dblTotalGpa = dblTotalGpa + dblStudents
        lblAllStudents.Text = dblTotalGpa.ToString("N1")


    End Sub
   
    Private Sub FemaleStudentsLabel_Click(sender As Object, e As EventArgs) Handles FemaleStudentsLabel.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblAllStudents.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblMaleStudents.Click

    End Sub

    Private Sub label3_Click(sender As Object, e As EventArgs) Handles lblFemaleStudents.Click

    End Sub

    Private Sub GPABox_TextChanged(sender As Object, e As EventArgs) Handles GPABox.TextChanged

    End Sub

    Private Sub GPABox_AutoSizeChanged(sender As Object, e As EventArgs) Handles GPABox.AutoSizeChanged

    End Sub

    Private Sub GPABox_Click(sender As Object, e As EventArgs) Handles GPABox.Click

    End Sub

    
End Class

Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    ' variable to store total credits

    Private totalCredits As Integer = 0
    Private totalPoints As Integer = 0


    Private WithEvents GroupBox2 As New GroupBox
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GradeCombox.Items.Add("Select a grade")
        GradeCombox.Items.Add("A")
        GradeCombox.Items.Add("B")
        GradeCombox.Items.Add("C")
        GradeCombox.Items.Add("D")
        GradeCombox.Items.Add("F")

        GradeCombox.DropDownStyle = ComboBoxStyle.DropDownList

        ' Add placeholder text and set default index to -1

        GradeCombox.SelectedIndex = -1
        GradeCombox.Text = "Select a grade"

    End Sub
    Private Sub GradeCombox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GradeCombox.SelectedIndexChanged



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Creating variables

        Dim Course, Grade, GPA, LetterGrade As String
        Dim Credits, Points As Integer


        'Data validation

        If CourseTextBox.Text = Nothing Then MsgBox("Please enter a course", vbExclamation, "Error")
        If CreditsTextBox.Text = Nothing Or IsNumeric(CreditsTextBox.Text) = False Then MsgBox("Please enter a valid number for credits", vbExclamation, "Error")
        If Val(CreditsTextBox.Text) < 0 Then MsgBox("Credits cannot be negative", vbExclamation, "Error")
        If GradeCombox.SelectedIndex = 0 Then MsgBox("A grade must be selected", vbExclamation, "Error")



        ' A course can only be added if all the required fields have been filled out completely.

        If CourseTextBox.Text = Nothing Then Return
        If CreditsTextBox.Text = Nothing Then Return
        If IsNumeric(CreditsTextBox.Text) = False Then Return
        If Val(CreditsTextBox.Text) < 0 Then Return
        If GradeCombox.SelectedIndex = 0 Then Return


        Course = CourseTextBox.Text
        Credits = CreditsTextBox.Text
        Grade = GradeCombox.Text






        Select Case Grade
            Case "A"
                Points = 4
            Case "B"
                Points = 3
            Case "C"
                Points = 2
            Case "D"
                Points = 1
            Case "F"
                Points = 0
        End Select

        'Process
        ' Add entered credits to total credits and points to total points

        totalCredits += CInt(Credits)
        totalPoints += Credits * Points

        GPA = (totalPoints / totalCredits).ToString("F1")

        'Criteria to incorporate letter grade of the GPA

        Dim gpaValue As Double = CDbl(GPA)

        Select Case gpaValue
            Case >= 3.5
                LetterGrade = "A"
            Case >= 3.0
                LetterGrade = "B"
            Case >= 2.5
                LetterGrade = "C"
            Case >= 2.0
                LetterGrade = "D"
            Case Else
                LetterGrade = "F"
        End Select


        'Output

        Dim item As String = Course & vbTab & vbTab & "   " & Credits & vbTab & vbTab & "   " & Grade & vbTab & vbTab & "   " & Points

        ListBox1.Items.Add(item)

        ' Display total credits in TotalCreditsTextBox

        TotalCreditsTextBox.Text = totalCredits.ToString()
        TotalPointsTextBox.Text = totalPoints.ToString()
        GPATextBox.Text = GPA.ToString() & "/4.0 " & LetterGrade





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Clear button

        CourseTextBox.Clear()
        CreditsTextBox.Clear()
        TotalCreditsTextBox.Clear()
        TotalPointsTextBox.Clear()
        GPATextBox.Clear()
        GradeCombox.SelectedIndex = 0
        GradeCombox.Text = " "
        ListBox1.Items.Clear()

        ' Reset totalCredits and totalPoints to 0 when the clear button is hit

        totalCredits = 0
        totalPoints = 0

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class

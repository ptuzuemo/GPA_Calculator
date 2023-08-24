<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CourseTextBox = New System.Windows.Forms.TextBox()
        Me.CreditsTextBox = New System.Windows.Forms.TextBox()
        Me.GradeCombox = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GPATextBox = New System.Windows.Forms.TextBox()
        Me.TotalPointsTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCreditsTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Credits"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(341, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Grade"
        '
        'CourseTextBox
        '
        Me.CourseTextBox.Location = New System.Drawing.Point(15, 51)
        Me.CourseTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CourseTextBox.Name = "CourseTextBox"
        Me.CourseTextBox.Size = New System.Drawing.Size(110, 23)
        Me.CourseTextBox.TabIndex = 0
        '
        'CreditsTextBox
        '
        Me.CreditsTextBox.Location = New System.Drawing.Point(155, 51)
        Me.CreditsTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CreditsTextBox.Name = "CreditsTextBox"
        Me.CreditsTextBox.Size = New System.Drawing.Size(110, 23)
        Me.CreditsTextBox.TabIndex = 1
        '
        'GradeCombox
        '
        Me.GradeCombox.FormattingEnabled = True
        Me.GradeCombox.Location = New System.Drawing.Point(304, 51)
        Me.GradeCombox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GradeCombox.Name = "GradeCombox"
        Me.GradeCombox.Size = New System.Drawing.Size(133, 23)
        Me.GradeCombox.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(116, 115)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(0, 23)
        Me.TextBox3.TabIndex = 6
        '
        'ListBox1
        '
        Me.ListBox1.Enabled = False
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(15, 98)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(421, 184)
        Me.ListBox1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(429, 267)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(0, 0)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(146, 115)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(0, 1)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(455, 50)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 22)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Add Course"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(498, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "GPA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(455, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Total Points"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(449, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Total Credits"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(455, 227)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 22)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GPATextBox
        '
        Me.GPATextBox.Enabled = False
        Me.GPATextBox.Location = New System.Drawing.Point(535, 98)
        Me.GPATextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GPATextBox.Name = "GPATextBox"
        Me.GPATextBox.Size = New System.Drawing.Size(92, 23)
        Me.GPATextBox.TabIndex = 4
        '
        'TotalPointsTextBox
        '
        Me.TotalPointsTextBox.Enabled = False
        Me.TotalPointsTextBox.Location = New System.Drawing.Point(535, 138)
        Me.TotalPointsTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TotalPointsTextBox.Name = "TotalPointsTextBox"
        Me.TotalPointsTextBox.Size = New System.Drawing.Size(92, 23)
        Me.TotalPointsTextBox.TabIndex = 5
        '
        'TotalCreditsTextBox
        '
        Me.TotalCreditsTextBox.Enabled = False
        Me.TotalCreditsTextBox.Location = New System.Drawing.Point(535, 182)
        Me.TotalCreditsTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TotalCreditsTextBox.Name = "TotalCreditsTextBox"
        Me.TotalCreditsTextBox.Size = New System.Drawing.Size(92, 23)
        Me.TotalCreditsTextBox.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(78, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 15)
        Me.Label7.TabIndex = 14
        '
        'ListBox2
        '
        Me.ListBox2.Enabled = False
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Items.AddRange(New Object() {"Course" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Credits" & Global.Microsoft.VisualBasic.ChrW(9) & "   " & Global.Microsoft.VisualBasic.ChrW(9) & "Grade" & Global.Microsoft.VisualBasic.ChrW(9) & "  " & Global.Microsoft.VisualBasic.ChrW(9) & "Points"})
        Me.ListBox2.Location = New System.Drawing.Point(15, 80)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(421, 19)
        Me.ListBox2.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 338)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TotalCreditsTextBox)
        Me.Controls.Add(Me.TotalPointsTextBox)
        Me.Controls.Add(Me.GPATextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.GradeCombox)
        Me.Controls.Add(Me.CreditsTextBox)
        Me.Controls.Add(Me.CourseTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CourseTextBox As TextBox
    Friend WithEvents CreditsTextBox As TextBox
    Friend WithEvents GradeCombox As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents GPATextBox As TextBox
    Friend WithEvents TotalPointsTextBox As TextBox
    Friend WithEvents TotalCreditsTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBox2 As ListBox
End Class

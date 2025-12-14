<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Button1 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        MonthCalendar1 = New MonthCalendar()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(153, 149)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlDark
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Cursor = Cursors.AppStarting
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Location = New Point(153, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 17)
        Label1.TabIndex = 1
        Label1.Text = "State Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(153, 109)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(75, 23)
        TextBox1.TabIndex = 2
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(524, 121)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MonthCalendar1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MonthCalendar1 As MonthCalendar

End Class

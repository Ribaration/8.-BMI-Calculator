Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declaring of variables that we are using to calculate BMI
        Dim height, weight, bmi As Double
        weight = Val(TextBox1.Text)
        height = Val(TextBox2.Text)

        'BMI Calculation formula
        bmi = weight / (height) ^ 2
        TextBox3.Text = bmi

        'The conditions of the BMI calculation

        If bmi < 18 Then
            TextBox4.Text = "You are underweight"
        ElseIf 18 <= bmi And bmi < 26 Then
            TextBox4.Text = "You have normal weight"
        Else
            TextBox4.Text = "You are overweight"
        End If

    End Sub
End Class

Public Class Form1
    Dim num1 As Double
    Dim num2 As Double
    Dim result As Double
    Dim op As Char

    Private Sub Num_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        TextBox1.Text += CType(sender, Button).Text
    End Sub

    Private Sub Op_Click(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMinus.Click, btnMultiply.Click, btnDivide.Click
        num1 = CDbl(TextBox1.Text)
        TextBox1.Text = ""
        op = CType(sender, Button).Text
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        num2 = CDbl(TextBox1.Text)
        Select Case op
            Case "+"
                result = num1 + num2
            Case "-"
                result = num1 - num2
            Case "x"
                result = num1 * num2
            Case "÷"
                result = num1 / num2
        End Select
        TextBox1.Text = result.ToString()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Text = ""
        num1 = 0
        num2 = 0
        result = 0
        op = ""
    End Sub
End Class

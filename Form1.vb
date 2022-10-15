Public Class Form1
    Dim num1 As Decimal
    Dim num2 As Decimal
    Dim result As Decimal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        num1 = Val(txtNum1.Text
                   )
        num2 = Val(txtNum2.Text
                   )
        result = num1 + num2
        txtResult.Text = result


    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        num1 = Val(txtNum1.Text
                   )
        num2 = Val(txtNum2.Text
                   )
        result = num1 - num2
        txtResult.Text = result
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        num1 = Val(txtNum1.Text
                   )
        num2 = Val(txtNum2.Text
                   )
        result = num1 * num2
        txtResult.Text = result
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        num1 = Val(txtNum1.Text
                   )
        num2 = Val(txtNum2.Text
                   )
        Try
            result = num1 / num2
            txtResult.Text = result
        Catch ex As Exception
            MsgBox(ex.Message())

        End Try

    End Sub

    Private Sub btnMOD_Click(sender As Object, e As EventArgs) Handles btnMOD.Click
        num1 = Val(txtNum1.Text
                   )
        num2 = Val(txtNum2.Text
                   )
        txtResult.Text = result

    End Sub

    Private Sub txtResult_TextChanged(sender As Object, e As EventArgs) Handles txtResult.TextChanged

    End Sub
End Class

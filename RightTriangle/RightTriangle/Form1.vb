Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        Dim x, y As Double

        x = CDbl(txtSideOne.Text)
        y = CDbl(txtSideTwo.Text)

        txtHyp.Text = CStr(Math.Round(Hypotenuse(x, y), 3))

    End Sub

    Function Hypotenuse(ByVal a As Double, ByVal b As Double) As Double

        Dim hyp As Double = Math.Sqrt(a ^ 2 + b ^ 2)
        Return hyp

    End Function

End Class

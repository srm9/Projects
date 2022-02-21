Public Class Form1
    Dim first As Double
    Dim second As Double
    Dim ans As Double
    Dim operators As String
    Dim n As Int64
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn4.Click, btn9.Click, btn8.Click, btn7.Click, btn0.Click, btn3.Click, btn2.Click, btn6.Click, btn5.Click, btnDec.Click

        Dim btn As Button = CType(sender, Button)
        If lblAns.Text = "0" Then
            lblAns.Text = btn.Text
        Else
            lblAns.Text = lblAns.Text + btn.Text
        End If




    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblProblem.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblAns.Text = "0"
        lblProblem.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblAns.Text = "0"
        lblProblem.Text = ""
    End Sub

    Private Sub basic(sender As Object, e As EventArgs) Handles btnAdd.Click, btnSub.Click, btnMult.Click, btnMod.Click, btnDivide.Click, btnPow.Click
        Dim btn As Button = CType(sender, Button)
        first = CDbl(lblAns.Text)
        lblProblem.Text = lblAns.Text
        lblAns.Text = ""
        operators = btn.Text
        lblProblem.Text = lblProblem.Text + " " + operators
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        second = CDbl(lblAns.Text)
        If operators = "+" Then
            ans = first + second
            lblAns.Text = CStr(ans)
            lblProblem.Text = ""
        ElseIf operators = "-" Then
            ans = first - second
            lblAns.Text = CStr(ans)
            lblProblem.Text = ""
        ElseIf operators = "*" Then
            ans = first * second
            lblAns.Text = CStr(ans)
            lblProblem.Text = ""
        ElseIf operators = "/" Then
            ans = first / second
            lblAns.Text = CStr(ans)
            lblProblem.Text = ""
        ElseIf operators = "Mod" Then
            ans = first Mod second
            lblAns.Text = CStr(ans)
            lblProblem.Text = ""
        ElseIf operators = "X^y" Then
            ans = Math.Pow(CDbl(first), CDbl(second))
            lblAns.Text = CStr(ans)
            lblProblem.Text = ""

        End If

    End Sub

    Private Sub btnSin_Click(sender As Object, e As EventArgs) Handles btnSin.Click
        ans = Math.Sin(CDbl(lblAns.Text))
        lblAns.Text = CStr(ans)
        lblProblem.Text = ""
    End Sub

    Private Sub btnCos_Click(sender As Object, e As EventArgs) Handles btnCos.Click
        ans = Math.Cos(CDbl(lblAns.Text))
        lblAns.Text = CStr(ans)
        lblProblem.Text = ""
    End Sub

    Private Sub btnTan_Click(sender As Object, e As EventArgs) Handles btnTan.Click
        ans = Math.Tan(CDbl(lblAns.Text))
        lblAns.Text = CStr(ans)
        lblProblem.Text = ""
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        ans = Math.Log(CDbl(lblAns.Text))
        lblAns.Text = CStr(ans)
        lblProblem.Text = ""

    End Sub

    Private Sub btnBin_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnPi_Click(sender As Object, e As EventArgs) Handles btnPi.Click
        ans = Math.PI
        lblAns.Text = CStr(ans)
        lblProblem.Text = ""
    End Sub

    Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        ans = Math.Sqrt(CDbl(lblAns.Text))
        lblAns.Text = CStr(ans)
        lblProblem.Text = ""
    End Sub

    Private Sub btnSquare_Click(sender As Object, e As EventArgs) Handles btnSquare.Click
        ans = Math.Pow(CDbl(lblAns.Text), 2)
        lblAns.Text = CStr(ans)
        lblProblem.Text = ""
    End Sub

    Private Sub btnCube_Click(sender As Object, e As EventArgs) Handles btnCube.Click
        ans = Math.Pow(CDbl(lblAns.Text), 3)
        lblAns.Text = CStr(ans)
        lblProblem.Text = ""
    End Sub

    Private Sub btnPow_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAbs_Click(sender As Object, e As EventArgs) Handles btnAbs.Click
        ans = Math.Abs(CDbl(lblAns.Text))
        lblAns.Text = CStr(ans)
        lblProblem.Text = ""
    End Sub

    Private Sub btnNeg_Click(sender As Object, e As EventArgs) Handles btnNeg.Click
        ans = CDbl(lblAns.Text) * -1
        lblAns.Text = CStr(ans)
        lblProblem.Text = ""
    End Sub

    Private Sub btnExp_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        ans = Math.Exp(CDbl(lblAns.Text))
        lblAns.Text = CStr(ans)
        lblProblem.Text = ""
    End Sub

    Private Sub btnPercent_Click(sender As Object, e As EventArgs) Handles btnPercent.Click
        ans = (CDbl(lblAns.Text) / 100)
        lblAns.Text = CStr(ans)
        lblProblem.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class

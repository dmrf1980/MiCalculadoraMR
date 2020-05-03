Public Class Form1

    Dim numero1 As Double = 0
    Dim numero2 As Double = 0

    Private Sub BtnSumar_Click(sender As Object, e As EventArgs) Handles BtnSumar.Click

        If Double.TryParse(txtNumero1.Text, numero1) Then

            If Double.TryParse(txtNumero2.Text, numero2) Then

                lblresultado.Text = numero1 + numero2

            Else

                MsgBox("Numero 2 no es un numero valido!")

            End If

        Else

            MsgBox("Numero 1 no es un numero valido!")

        End If

    End Sub

    Private Sub BtnResta_Click(sender As Object, e As EventArgs) Handles BtnResta.Click

        If Double.TryParse(txtNumero1.Text, numero1) Then

            If Double.TryParse(txtNumero2.Text, numero2) Then

                lblresultado.Text = numero1 - numero2

            Else

                MsgBox("Numero 2 no es un numero valido!")

            End If

        Else

            MsgBox("Numero 1 no es un numero valido!")

        End If

    End Sub

    Private Sub BtnMultiplicar_Click(sender As Object, e As EventArgs) Handles BtnMultiplicar.Click

        If Double.TryParse(txtNumero1.Text, numero1) Then

            If Double.TryParse(txtNumero2.Text, numero2) Then

                lblresultado.Text = numero1 * numero2

            Else

                MsgBox("Numero 2 no es un numero valido!")

            End If

        Else

            MsgBox("Numero 1 no es un numero valido!")

        End If

    End Sub

    Private Sub BtnDividir_Click(sender As Object, e As EventArgs) Handles BtnDividir.Click

        If Double.TryParse(txtNumero1.Text, numero1) Then

            If Double.TryParse(txtNumero2.Text, numero2) Then

                If numero2 <> 0 Then

                    lblresultado.Text = numero1 / numero2

                Else

                    MsgBox("Numero 2 no puede ser CERO!!!")

                End If

            Else

                MsgBox("Numero 2 no es un numero valido!")

            End If

        Else

            MsgBox("Numero 1 no es un numero valido!")

        End If

    End Sub
End Class

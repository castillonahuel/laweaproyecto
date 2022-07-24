Public Class Form1
    Dim Azar As Boolean = True

    Function NumDado(Random As Boolean) As Integer

        If Random Then Randomize()
        Return Int(Rnd() * 6 + 1)

    End Function

    Private Sub Cubilete_Click(sender As Object, e As EventArgs) Handles Cubilete.Click

        CambiaDado(Dado)

        If Jogador.Text = "Jugador 1" Then
            Jogador.Text = "Jugador 2"
        ElseIf Jogador.Text = "Jugador 2" Then
            Jogador.Text = "Jugador 1"
        End If



    End Sub

    Sub CambiaDado(ByRef Dado As PictureBox)

        Dim Num As Integer = NumDado(True)
        Dim Num2 As Integer = NumDado(True)
        Dim Num3 As Integer = NumDado(True)
        Dim Num4 As Integer = NumDado(True)
        Dim Num5 As Integer = NumDado(True)

        Select Case Num
            Case 1 : Dado.Image = My.Resources.dado1
            Case 2 : Dado.Image = My.Resources.dado2
            Case 3 : Dado.Image = My.Resources.dado3
            Case 4 : Dado.Image = My.Resources.dado4
            Case 5 : Dado.Image = My.Resources.dado5
            Case 6 : Dado.Image = My.Resources.dado6
        End Select

        Select Case Num2
            Case 1 : Dado2.Image = My.Resources.dado1
            Case 2 : Dado2.Image = My.Resources.dado2
            Case 3 : Dado2.Image = My.Resources.dado3
            Case 4 : Dado2.Image = My.Resources.dado4
            Case 5 : Dado2.Image = My.Resources.dado5
            Case 6 : Dado2.Image = My.Resources.dado6
        End Select

        Select Case Num3
            Case 1 : Dado3.Image = My.Resources.dado1
            Case 2 : Dado3.Image = My.Resources.dado2
            Case 3 : Dado3.Image = My.Resources.dado3
            Case 4 : Dado3.Image = My.Resources.dado4
            Case 5 : Dado3.Image = My.Resources.dado5
            Case 6 : Dado3.Image = My.Resources.dado6
        End Select

        Select Case Num4
            Case 1 : Dado4.Image = My.Resources.dado1
            Case 2 : Dado4.Image = My.Resources.dado2
            Case 3 : Dado4.Image = My.Resources.dado3
            Case 4 : Dado4.Image = My.Resources.dado4
            Case 5 : Dado4.Image = My.Resources.dado5
            Case 6 : Dado4.Image = My.Resources.dado6
        End Select

        Select Case Num5
            Case 1 : Dado5.Image = My.Resources.dado1
            Case 2 : Dado5.Image = My.Resources.dado2
            Case 3 : Dado5.Image = My.Resources.dado3
            Case 4 : Dado5.Image = My.Resources.dado4
            Case 5 : Dado5.Image = My.Resources.dado5
            Case 6 : Dado5.Image = My.Resources.dado6
        End Select

        If Num = 1 And Num2 = 1 And Num3 = 1 And Num4 = 1 And Num5 = 1 Then
            MessageBox.Show(Jogador.Text + " Saco Generala!")

        ElseIf Num = 2 And Num2 = 2 And Num3 = 2 And Num4 = 2 And Num5 = 2 Then
            MessageBox.Show(Jogador.Text + " Saco Generala!")

        ElseIf Num = 3 And Num2 = 3 And Num3 = 3 And Num4 = 3 And Num5 = 3 Then
            MessageBox.Show(Jogador.Text + " Saco Generala!")

        ElseIf Num = 4 And Num2 = 4 And Num3 = 4 And Num4 = 4 And Num5 = 4 Then
            MessageBox.Show(Jogador.Text + " Saco Generala!")

        ElseIf Num = 5 And Num2 = 5 And Num3 = 5 And Num4 = 5 And Num5 = 5 Then
            MessageBox.Show(Jogador.Text + " Saco Generala!")

        ElseIf Num = 6 And Num2 = 6 And Num3 = 6 And Num4 = 6 And Num5 = 6 Then
            MessageBox.Show(Jogador.Text + " Saco Generala!")

        ElseIf Num = 1 And Num2 = 2 And Num3 = 3 And Num4 = 4 And Num5 = 5 Then
            MessageBox.Show(Jogador.Text + " Saco Escalera!")

        ElseIf Num = 1 And Num2 = 3 And Num3 = 4 And Num4 = 5 And Num5 = 2 Then
            MessageBox.Show(Jogador.Text + " Saco Escalera!")

        ElseIf Num = 1 And Num2 = 4 And Num3 = 5 And Num4 = 2 And Num5 = 3 Then
            MessageBox.Show(Jogador.Text + " Saco Escalera!")

        ElseIf Num = 1 And Num2 = 5 And Num3 = 2 And Num4 = 3 And Num5 = 4 Then
            MessageBox.Show(Jogador.Text + " Saco Escalera!")

        ElseIf Num = 2 And Num2 = 3 And Num3 = 4 And Num4 = 5 And Num5 = 1 Then
            MessageBox.Show(Jogador.Text + " Saco Escalera!")

        ElseIf Num = 2 And Num2 = 3 And Num3 = 4 And Num4 = 5 And Num5 = 6 Then
            MessageBox.Show(Jogador.Text + " Saco Escalera!")
        End If

    End Sub

End Class

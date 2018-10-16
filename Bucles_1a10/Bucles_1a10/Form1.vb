Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If CDbl(VI.Text) < CDbl(VF.Text) And CDbl(Inc.Text) > 0 Then

                If CDbl(VI.Text) - CInt(VI.Text) = 0 And
                   CDbl(VF.Text) - CInt(VF.Text) = 0 And
                   CDbl(Inc.Text) - CInt(Inc.Text) = 0 Then

                    Dim A, B, D As Integer
                    For C = 0 To 4 Step 1

                        A = CInt(VI.Text)
                        B = CInt(VF.Text)
                        D = CInt(Inc.Text)

                        Select Case C
                            Case 0

                                For i As Integer = A To B Step [D]
                                    F.Text = F.Text & i.ToString() & vbCr & vbLf

                                Next
                            Case 1

                                Do While A <= B
                                    D_W.Text = D_W.Text & A & vbCr & vbLf
                                    A = A + D
                                Loop

                            Case 2
                                Do Until A > B
                                    D_U.Text = D_U.Text & A & vbCr & vbLf
                                    A = A + D
                                Loop

                            Case 3
                                Do
                                    L_W.Text = L_W.Text & A & vbCr & vbLf
                                    A = A + D

                                Loop While A <= B

                            Case 4
                                Do
                                    L_U.Text = L_U.Text & A & vbCr & vbLf
                                    A = A + D
                                Loop Until A > B
                        End Select
                    Next

                Else
                    MessageBox.Show("Por favor ingresar numeros enteros", "Aviso")

                    If CDbl(VI.Text) - CInt(VI.Text) <> 0 Then
                        VI.SelectAll()
                        VI.Focus()

                    ElseIf CDbl(VF.Text) - CInt(VF.Text) <> 0 Then
                        VF.SelectAll()
                        VF.Focus()

                    ElseIf CDbl(Inc.Text) - CInt(Inc.Text) <> 0 Then
                        Inc.SelectAll()
                        Inc.Focus()

                    End If
                End If
            Else
                If CDbl(VI.Text) >= CDbl(VF.Text) Then
                    MessageBox.Show("El primer valor siempre debe ser menor que el valor final", "Aviso")
                    VI.SelectAll()
                    VI.Focus()

                ElseIf CDbl(Inc.Text) <= 0 Then
                    MessageBox.Show("El valor para incrementar debe ser siempre positivo", "Aviso")
                    Inc.SelectAll()
                    Inc.Focus()
                End If
            End If
        Catch ex As InvalidCastException
            MessageBox.Show("Por favor debe ingresar un numero", "Aviso")
            If Not IsNumeric(VI.Text) Then
                VI.SelectAll()
                VI.Focus()
                Exit Try
            ElseIf Not IsNumeric(VF.Text) Then
                VF.SelectAll()
                VF.Focus()
                Exit Try
            ElseIf Not IsNumeric(Inc.Text) Then
                Inc.SelectAll()
                Inc.Focus()
                Exit Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class


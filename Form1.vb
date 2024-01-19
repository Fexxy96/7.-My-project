Imports System.ComponentModel

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim answer
        answer = MsgBox("Thank you, we are working on your order!")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim answer
        answer = MsgBox("You have succesfully created an order!")
    End Sub

End Class

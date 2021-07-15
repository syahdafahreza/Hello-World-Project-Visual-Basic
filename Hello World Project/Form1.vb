Public Class Form1

    Dim KataKata As String
    Private Sub btnCreateHelloWorld_Click(sender As Object, e As EventArgs) Handles btnCreateHelloWorld.Click
        KataKata = "Hello World"
        textField1.Text = KataKata
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClearText.Click
        KataKata = ""
        textField1.Text = KataKata
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnShowStringDialog.Click
        KataKata = textField1.Text
        MsgBox(KataKata)
    End Sub
End Class

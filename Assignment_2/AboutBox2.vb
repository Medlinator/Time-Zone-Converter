Public NotInheritable Class AboutBox2

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub TextBoxDescription_TextChanged(sender As Object, e As EventArgs) Handles txtIntro.TextChanged
        txtIntro.Text = "A little about me:" & vbCrLf & vbCrLf & "Active duty military studying computer science. I plan to finish my education, " _
                      & "separate from the military, And become a video game developer. I'm married, and my wife and I just had our first child in September."
    End Sub
End Class

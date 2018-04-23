Public Class Informacje
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DownloadAssistant.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("C:\CupPageData\Downloads")
    End Sub
End Class
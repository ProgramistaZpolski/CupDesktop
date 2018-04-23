Public Class DownloadAssistant
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DownloadAssistant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(250)
        My.Computer.Network.DownloadFile(Form1.DLink, "C:\CupPageData\Downloads\" + Form1.OpenName + ".zip")
        MsgBox(Prompt:="Pobieranie zakończone!")
    End Sub
End Class
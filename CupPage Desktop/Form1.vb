Public Class Form1
    Public Description As String
    Public DLink As String
    Public OpenName As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Informacje.Show()
        Description = My.Computer.FileSystem.ReadAllText("C:\CupPageData\InfoZmieniator.txt")
        Informacje.RichTextBox1.Text = Description
        DLink = "https://cuppage-desktop.000webhostapp.com/Downloads/Czyny.zip"
        OpenName = "Zmieniator3000"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Informacje.Show()
        Description = My.Computer.FileSystem.ReadAllText("C:\CupPageData\InfoLuXme.txt")
        Informacje.RichTextBox1.Text = Description
        DLink = "http://cuppage.000webhostapp.com/download/LuXme%201.1v.rar"
        OpenName = "LuXme"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Informacje.Show()
        Description = My.Computer.FileSystem.ReadAllText("C:\CupPageData\InfoFileMan.txt")
        Informacje.RichTextBox1.Text = Description
        DLink = "https://cuppage-desktop.000webhostapp.com/Downloads/fileman_amd64_linux.zip"
        OpenName = "FileMan"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Informacje.Show()
        Description = My.Computer.FileSystem.ReadAllText("C:\CupPageData\InfoHardBTC.txt")
        Informacje.RichTextBox1.Text = Description
        DLink = "https://cuppage-desktop.000webhostapp.com/Downloads/HardBTC.zip"
        OpenName = "HardBTC"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Informacje.Show()
        Description = My.Computer.FileSystem.ReadAllText("C:\CupPageData\InfoCrypto.txt")
        Informacje.RichTextBox1.Text = Description
        DLink = "https://cuppage-desktop.000webhostapp.com/Downloads/Crypto.zip"
        OpenName = "CryptoGame"
    End Sub
End Class

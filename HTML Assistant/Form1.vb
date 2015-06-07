Imports System.IO
Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim FilePath As String = InputBox("Folder for import")
        Dim di As New DirectoryInfo(FilePath)
        Dim fileJPG As FileInfo()
        Dim strNEFs As New List(Of String)

        Dim outFile As StreamWriter
        'Dim inFile As StreamReader

        outFile = File.AppendText("HTML.txt")
        fileJPG = di.GetFiles("*.JPG")

        For Each JPG In fileJPG
            Dim intSub As Integer = JPG.Name.IndexOf(".")
            Dim strParsedJPG As String = JPG.Name.Substring(0, intSub)
            outFile.WriteLine("<a href=""img/" & JPG.Name & """ data-lightbox=""" & strParsedJPG & "a""></a>")
        Next

        outFile.Close()

    End Sub
End Class

Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Public Class window
    Private filePath As String = ""








    Private Function generateFileHash(hashName As String, filePath As String) As String
        Dim hash As HashAlgorithm

        Select Case hashName.ToLower()
            Case "md5"
                hash = MD5.Create()
            Case "sha1"
                hash = SHA1.Create()
            Case "sha256"
                hash = SHA256.Create()
            Case Else
                Throw New Exception("Unknown hashName")
        End Select

        Dim fs As FileStream = New FileStream(filePath, FileMode.Open)
        Dim hashByteArray As Byte() = hash.ComputeHash(fs)
        fs.Close()

        Dim hashResult As String = ""
        For Each b As Byte In hashByteArray
            hashResult += b.ToString("x2")
        Next
        Return hashResult
    End Function

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        fdOpen.ShowDialog()
    End Sub

    Private Sub tbFileName_Click(sender As Object, e As EventArgs) Handles tbFileName.Click
        fdOpen.ShowDialog()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim hash As String
        Dim userHash As String = tbHash.Text

        hash = generateFileHash("md5", filePath)
        tbMd5.Text = hash
        If hash = userHash Then
            lblMd5.ForeColor = Color.Green
        Else
            lblMd5.ForeColor = Color.Red
        End If

        hash = generateFileHash("sha1", filePath)
        tbSha1.Text = hash
        If hash = userHash Then
            lblSha1.ForeColor = Color.Green
        Else
            lblSha1.ForeColor = Color.Red
        End If

        hash = generateFileHash("sha256", filePath)
        tbSha256.Text = hash
        If hash = userHash Then
            lblSha256.ForeColor = Color.Green
        Else
            lblSha256.ForeColor = Color.Red
        End If

    End Sub

    Private Sub fdOpen_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles fdOpen.FileOk
        If fdOpen.FileName <> "" Then
            filePath = fdOpen.FileName
            tbFileName.Text = filePath
        End If
    End Sub
End Class

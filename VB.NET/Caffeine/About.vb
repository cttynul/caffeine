Public Class About
    Private Sub LinkLicense_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLicense.LinkClicked
        Dim url As String = "http://www.gnu.org/licenses/gpl.html"
        Process.Start(url)
    End Sub
End Class
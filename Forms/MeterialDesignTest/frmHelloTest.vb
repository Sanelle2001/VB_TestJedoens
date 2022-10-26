Public Class frmHelloTest
    Private Async Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click
        btnHello.Enabled = False
        tbFirstName.Enabled = False
        tbLastName.Enabled = False
        Await Task.Delay(1000).ConfigureAwait(True)
        MessageBox.Show($"Hello {tbFirstName.Text} {tbLastName.Text}!")
        Await Task.Delay(1000).ConfigureAwait(True)
        tbFirstName.Enabled = True
        tbLastName.Enabled = True
        btnHello.Enabled = True
    End Sub
End Class

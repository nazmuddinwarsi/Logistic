Public Class frmRptViewer

    Private Sub frmRptViewer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.P Then
            CRViewer.PrintReport()
        End If
    End Sub

    Private Sub frmRptViewer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub
End Class
Public Class Form1

    Private Sub cmdarea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdarea.Click
        Const pi = 3.141592
        Dim radius As Double
        Dim area As Double
        radius = CDbl(txtradius.Text)
        area = pi * radius * radius
        lblarea.Text = "the area of the circle is" & area
    End Sub

    Private Sub txtradius_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtradius.TextChanged

    End Sub
End Class

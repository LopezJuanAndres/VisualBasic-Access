Public Class Form2

    Private Sub CarrerasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarrerasToolStripMenuItem.Click
        GAl.Enabled = True
        GAs.Enabled = False
    End Sub

    Private Sub ProfesoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfesoresToolStripMenuItem.Click
        GAl.Enabled = False
        GAs.Enabled = True
    End Sub

    Private Sub AlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnosToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class
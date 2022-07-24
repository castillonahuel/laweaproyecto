Public Class Form1
    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        If MessageBox.Show("Desea salir del sistema?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub

    Private Sub bClientes_Click(sender As Object, e As EventArgs) Handles bClientes.Click
        Dim cli As New Clientes
        cli.BackColor = Color.Red
        cli.ShowDialog()
    End Sub

    Private Sub bProveedores_Click(sender As Object, e As EventArgs) Handles bProveedores.Click
        Dim pro As New Proveedores
        pro.BackColor = Color.Green
        pro.ShowDialog()
    End Sub

    Private Sub bListados_Click(sender As Object, e As EventArgs) Handles bListados.Click
        Dim list As New Listados
        list.BackColor = Color.Blue
        list.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MessageBox.Show("Desea salir del sistema?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim cli As New Clientes
        cli.BackColor = Color.Red
        cli.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim pro As New Proveedores
        pro.BackColor = Color.Green
        pro.ShowDialog()
    End Sub

    Private Sub ListasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListasToolStripMenuItem.Click
        Dim list As New Listados
        list.BackColor = Color.Blue
        list.ShowDialog()
    End Sub
End Class

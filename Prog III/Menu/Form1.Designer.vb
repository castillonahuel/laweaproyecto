<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bClientes = New System.Windows.Forms.Button()
        Me.bProveedores = New System.Windows.Forms.Button()
        Me.bListados = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IBBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntregasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bSalir
        '
        Me.bSalir.Location = New System.Drawing.Point(12, 234)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(96, 34)
        Me.bSalir.TabIndex = 0
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'bClientes
        '
        Me.bClientes.BackColor = System.Drawing.Color.Red
        Me.bClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bClientes.Location = New System.Drawing.Point(141, 42)
        Me.bClientes.Name = "bClientes"
        Me.bClientes.Size = New System.Drawing.Size(285, 38)
        Me.bClientes.TabIndex = 1
        Me.bClientes.Text = "Clientes"
        Me.bClientes.UseVisualStyleBackColor = False
        '
        'bProveedores
        '
        Me.bProveedores.BackColor = System.Drawing.Color.Green
        Me.bProveedores.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bProveedores.Location = New System.Drawing.Point(141, 101)
        Me.bProveedores.Name = "bProveedores"
        Me.bProveedores.Size = New System.Drawing.Size(285, 38)
        Me.bProveedores.TabIndex = 2
        Me.bProveedores.Text = "Proveedores"
        Me.bProveedores.UseVisualStyleBackColor = False
        '
        'bListados
        '
        Me.bListados.BackColor = System.Drawing.Color.Blue
        Me.bListados.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bListados.Location = New System.Drawing.Point(141, 161)
        Me.bListados.Name = "bListados"
        Me.bListados.Size = New System.Drawing.Size(285, 38)
        Me.bListados.TabIndex = 3
        Me.bListados.Text = "Listados"
        Me.bListados.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.VentasToolStripMenuItem, Me.ComprasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(559, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListasToolStripMenuItem, Me.BackupsToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(60, 20)
        Me.ToolStripMenuItem1.Text = "Sistema"
        '
        'ListasToolStripMenuItem
        '
        Me.ListasToolStripMenuItem.Name = "ListasToolStripMenuItem"
        Me.ListasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListasToolStripMenuItem.Text = "Listados"
        '
        'BackupsToolStripMenuItem
        '
        Me.BackupsToolStripMenuItem.Name = "BackupsToolStripMenuItem"
        Me.BackupsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BackupsToolStripMenuItem.Text = "Backups"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.FacturasToolStripMenuItem, Me.IBBToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'IBBToolStripMenuItem
        '
        Me.IBBToolStripMenuItem.Name = "IBBToolStripMenuItem"
        Me.IBBToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.IBBToolStripMenuItem.Text = "IBB"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.EntregasToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'EntregasToolStripMenuItem
        '
        Me.EntregasToolStripMenuItem.Name = "EntregasToolStripMenuItem"
        Me.EntregasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EntregasToolStripMenuItem.Text = "Entregas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 280)
        Me.ControlBox = False
        Me.Controls.Add(Me.bListados)
        Me.Controls.Add(Me.bProveedores)
        Me.Controls.Add(Me.bClientes)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bSalir As Button
    Friend WithEvents bClientes As Button
    Friend WithEvents bProveedores As Button
    Friend WithEvents bListados As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IBBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntregasToolStripMenuItem As ToolStripMenuItem
End Class

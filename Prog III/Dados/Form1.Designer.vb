<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Cubilete = New System.Windows.Forms.PictureBox()
        Me.Dado = New System.Windows.Forms.PictureBox()
        Me.Dado3 = New System.Windows.Forms.PictureBox()
        Me.Dado2 = New System.Windows.Forms.PictureBox()
        Me.Dado4 = New System.Windows.Forms.PictureBox()
        Me.Dado5 = New System.Windows.Forms.PictureBox()
        Me.Jogador = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Cubilete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cubilete
        '
        Me.Cubilete.BackColor = System.Drawing.Color.Transparent
        Me.Cubilete.Location = New System.Drawing.Point(453, 16)
        Me.Cubilete.Name = "Cubilete"
        Me.Cubilete.Size = New System.Drawing.Size(329, 285)
        Me.Cubilete.TabIndex = 1
        Me.Cubilete.TabStop = False
        '
        'Dado
        '
        Me.Dado.Image = Global.Dados.My.Resources.Resources.dado6
        Me.Dado.Location = New System.Drawing.Point(74, 72)
        Me.Dado.Name = "Dado"
        Me.Dado.Size = New System.Drawing.Size(95, 96)
        Me.Dado.TabIndex = 2
        Me.Dado.TabStop = False
        '
        'Dado3
        '
        Me.Dado3.Image = Global.Dados.My.Resources.Resources.dado6
        Me.Dado3.Location = New System.Drawing.Point(74, 205)
        Me.Dado3.Name = "Dado3"
        Me.Dado3.Size = New System.Drawing.Size(95, 96)
        Me.Dado3.TabIndex = 3
        Me.Dado3.TabStop = False
        '
        'Dado2
        '
        Me.Dado2.Image = Global.Dados.My.Resources.Resources.dado6
        Me.Dado2.Location = New System.Drawing.Point(240, 72)
        Me.Dado2.Name = "Dado2"
        Me.Dado2.Size = New System.Drawing.Size(95, 96)
        Me.Dado2.TabIndex = 4
        Me.Dado2.TabStop = False
        '
        'Dado4
        '
        Me.Dado4.Image = Global.Dados.My.Resources.Resources.dado6
        Me.Dado4.Location = New System.Drawing.Point(240, 205)
        Me.Dado4.Name = "Dado4"
        Me.Dado4.Size = New System.Drawing.Size(95, 96)
        Me.Dado4.TabIndex = 5
        Me.Dado4.TabStop = False
        '
        'Dado5
        '
        Me.Dado5.Image = Global.Dados.My.Resources.Resources.dado6
        Me.Dado5.Location = New System.Drawing.Point(150, 338)
        Me.Dado5.Name = "Dado5"
        Me.Dado5.Size = New System.Drawing.Size(95, 96)
        Me.Dado5.TabIndex = 6
        Me.Dado5.TabStop = False
        '
        'Jogador
        '
        Me.Jogador.AutoSize = True
        Me.Jogador.BackColor = System.Drawing.Color.Transparent
        Me.Jogador.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jogador.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Jogador.Location = New System.Drawing.Point(654, 409)
        Me.Jogador.Name = "Jogador"
        Me.Jogador.Size = New System.Drawing.Size(100, 25)
        Me.Jogador.TabIndex = 7
        Me.Jogador.Text = "Jugador 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(565, 409)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Turno de:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dados.My.Resources.Resources.mesa
        Me.ClientSize = New System.Drawing.Size(784, 503)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Jogador)
        Me.Controls.Add(Me.Dado5)
        Me.Controls.Add(Me.Dado4)
        Me.Controls.Add(Me.Dado2)
        Me.Controls.Add(Me.Dado3)
        Me.Controls.Add(Me.Dado)
        Me.Controls.Add(Me.Cubilete)
        Me.Name = "Form1"
        Me.Text = "Apretá el Cubilete para tirar los dados"
        CType(Me.Cubilete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cubilete As PictureBox
    Friend WithEvents Dado As PictureBox
    Friend WithEvents Dado3 As PictureBox
    Friend WithEvents Dado2 As PictureBox
    Friend WithEvents Dado4 As PictureBox
    Friend WithEvents Dado5 As PictureBox
    Friend WithEvents Jogador As Label
    Friend WithEvents Label1 As Label
End Class

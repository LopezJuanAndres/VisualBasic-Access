<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CarrerasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfesoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GAl = New System.Windows.Forms.GroupBox()
        Me.DtgvAlum = New System.Windows.Forms.DataGridView()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.GAs = New System.Windows.Forms.GroupBox()
        Me.DtgvAsis = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btnm = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GAl.SuspendLayout()
        CType(Me.DtgvAlum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GAs.SuspendLayout()
        CType(Me.DtgvAsis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CarrerasToolStripMenuItem, Me.ProfesoresToolStripMenuItem, Me.AlumnosToolStripMenuItem, Me.PermisosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(492, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CarrerasToolStripMenuItem
        '
        Me.CarrerasToolStripMenuItem.Name = "CarrerasToolStripMenuItem"
        Me.CarrerasToolStripMenuItem.Size = New System.Drawing.Size(75, 22)
        Me.CarrerasToolStripMenuItem.Text = "Alumnos"
        '
        'ProfesoresToolStripMenuItem
        '
        Me.ProfesoresToolStripMenuItem.Name = "ProfesoresToolStripMenuItem"
        Me.ProfesoresToolStripMenuItem.Size = New System.Drawing.Size(83, 22)
        Me.ProfesoresToolStripMenuItem.Text = "Asistencia"
        '
        'AlumnosToolStripMenuItem
        '
        Me.AlumnosToolStripMenuItem.Name = "AlumnosToolStripMenuItem"
        Me.AlumnosToolStripMenuItem.Size = New System.Drawing.Size(58, 22)
        Me.AlumnosToolStripMenuItem.Text = "Notas"
        '
        'PermisosToolStripMenuItem
        '
        Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(75, 22)
        Me.PermisosToolStripMenuItem.Text = "Usuarios"
        '
        'GAl
        '
        Me.GAl.Controls.Add(Me.DtgvAlum)
        Me.GAl.Controls.Add(Me.Button8)
        Me.GAl.Controls.Add(Me.Button9)
        Me.GAl.Controls.Add(Me.Button10)
        Me.GAl.Controls.Add(Me.Button11)
        Me.GAl.Enabled = False
        Me.GAl.Location = New System.Drawing.Point(0, 29)
        Me.GAl.Name = "GAl"
        Me.GAl.Size = New System.Drawing.Size(492, 215)
        Me.GAl.TabIndex = 7
        Me.GAl.TabStop = False
        Me.GAl.Text = "Alumnos"
        '
        'DtgvAlum
        '
        Me.DtgvAlum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgvAlum.Location = New System.Drawing.Point(0, 67)
        Me.DtgvAlum.Name = "DtgvAlum"
        Me.DtgvAlum.RowTemplate.Height = 24
        Me.DtgvAlum.Size = New System.Drawing.Size(490, 142)
        Me.DtgvAlum.TabIndex = 8
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(112, 21)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 34)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "Buscar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(21, 21)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(80, 34)
        Me.Button9.TabIndex = 4
        Me.Button9.Text = "Agregar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(198, 21)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(80, 34)
        Me.Button10.TabIndex = 3
        Me.Button10.Text = "Eliminar"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(284, 21)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(80, 34)
        Me.Button11.TabIndex = 2
        Me.Button11.Text = "Modificar"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'GAs
        '
        Me.GAs.Controls.Add(Me.DtgvAsis)
        Me.GAs.Controls.Add(Me.Button5)
        Me.GAs.Controls.Add(Me.Button4)
        Me.GAs.Controls.Add(Me.Button2)
        Me.GAs.Controls.Add(Me.Btnm)
        Me.GAs.Enabled = False
        Me.GAs.Location = New System.Drawing.Point(0, 250)
        Me.GAs.Name = "GAs"
        Me.GAs.Size = New System.Drawing.Size(492, 215)
        Me.GAs.TabIndex = 8
        Me.GAs.TabStop = False
        Me.GAs.Text = "Asistencia"
        '
        'DtgvAsis
        '
        Me.DtgvAsis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgvAsis.Location = New System.Drawing.Point(0, 67)
        Me.DtgvAsis.Name = "DtgvAsis"
        Me.DtgvAsis.RowTemplate.Height = 24
        Me.DtgvAsis.Size = New System.Drawing.Size(490, 142)
        Me.DtgvAsis.TabIndex = 9
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(112, 21)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 34)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Buscar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(21, 21)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 34)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Agregar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(198, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 34)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Btnm
        '
        Me.Btnm.Location = New System.Drawing.Point(284, 21)
        Me.Btnm.Name = "Btnm"
        Me.Btnm.Size = New System.Drawing.Size(80, 34)
        Me.Btnm.TabIndex = 2
        Me.Btnm.Text = "Modificar"
        Me.Btnm.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 468)
        Me.Controls.Add(Me.GAs)
        Me.Controls.Add(Me.GAl)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GAl.ResumeLayout(False)
        CType(Me.DtgvAlum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GAs.ResumeLayout(False)
        CType(Me.DtgvAsis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CarrerasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfesoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlumnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GAl As System.Windows.Forms.GroupBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents PermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GAs As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Btnm As System.Windows.Forms.Button
    Friend WithEvents DtgvAlum As System.Windows.Forms.DataGridView
    Friend WithEvents DtgvAsis As System.Windows.Forms.DataGridView
End Class

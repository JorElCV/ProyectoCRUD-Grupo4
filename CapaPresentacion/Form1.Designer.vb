﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanelMenuIzq = New System.Windows.Forms.Panel()
        Me.btnBiblioteca = New System.Windows.Forms.Button()
        Me.btnMatricula = New System.Windows.Forms.Button()
        Me.btnHorarios = New System.Windows.Forms.Button()
        Me.btnCursos = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.DgvEmpleado = New System.Windows.Forms.DataGridView()
        Me.PanelMenuIzq.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenuIzq
        '
        Me.PanelMenuIzq.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelMenuIzq.Controls.Add(Me.btnBiblioteca)
        Me.PanelMenuIzq.Controls.Add(Me.btnMatricula)
        Me.PanelMenuIzq.Controls.Add(Me.btnHorarios)
        Me.PanelMenuIzq.Controls.Add(Me.btnCursos)
        Me.PanelMenuIzq.Controls.Add(Me.btnInicio)
        Me.PanelMenuIzq.Controls.Add(Me.PanelLogo)
        Me.PanelMenuIzq.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenuIzq.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuIzq.Name = "PanelMenuIzq"
        Me.PanelMenuIzq.Size = New System.Drawing.Size(811, 53)
        Me.PanelMenuIzq.TabIndex = 1
        '
        'btnBiblioteca
        '
        Me.btnBiblioteca.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnBiblioteca.Location = New System.Drawing.Point(704, 0)
        Me.btnBiblioteca.Name = "btnBiblioteca"
        Me.btnBiblioteca.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnBiblioteca.Size = New System.Drawing.Size(120, 53)
        Me.btnBiblioteca.TabIndex = 6
        Me.btnBiblioteca.Text = "Biblioteca"
        Me.btnBiblioteca.UseVisualStyleBackColor = True
        '
        'btnMatricula
        '
        Me.btnMatricula.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMatricula.Location = New System.Drawing.Point(584, 0)
        Me.btnMatricula.Name = "btnMatricula"
        Me.btnMatricula.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnMatricula.Size = New System.Drawing.Size(120, 53)
        Me.btnMatricula.TabIndex = 5
        Me.btnMatricula.Text = "Matrícula"
        Me.btnMatricula.UseVisualStyleBackColor = True
        '
        'btnHorarios
        '
        Me.btnHorarios.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnHorarios.Location = New System.Drawing.Point(464, 0)
        Me.btnHorarios.Name = "btnHorarios"
        Me.btnHorarios.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnHorarios.Size = New System.Drawing.Size(120, 53)
        Me.btnHorarios.TabIndex = 4
        Me.btnHorarios.Text = "Horarios"
        Me.btnHorarios.UseVisualStyleBackColor = True
        '
        'btnCursos
        '
        Me.btnCursos.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCursos.Location = New System.Drawing.Point(344, 0)
        Me.btnCursos.Name = "btnCursos"
        Me.btnCursos.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnCursos.Size = New System.Drawing.Size(120, 53)
        Me.btnCursos.TabIndex = 3
        Me.btnCursos.Text = "Mis Cursos"
        Me.btnCursos.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnInicio.Location = New System.Drawing.Point(224, 0)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnInicio.Size = New System.Drawing.Size(120, 53)
        Me.btnInicio.TabIndex = 2
        Me.btnInicio.Text = "Empleados"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(224, 53)
        Me.PanelLogo.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 52)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.btnEditar)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(811, 50)
        Me.Panel1.TabIndex = 2
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(724, 14)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 2
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(368, 14)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(51, 15)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'DgvEmpleado
        '
        Me.DgvEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpleado.Location = New System.Drawing.Point(12, 109)
        Me.DgvEmpleado.Name = "DgvEmpleado"
        Me.DgvEmpleado.Size = New System.Drawing.Size(787, 329)
        Me.DgvEmpleado.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 450)
        Me.Controls.Add(Me.DgvEmpleado)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenuIzq)
        Me.Name = "Form1"
        Me.Text = "CRUD Básico"
        Me.PanelMenuIzq.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenuIzq As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnInicio As Button
    Friend WithEvents btnMatricula As Button
    Friend WithEvents btnHorarios As Button
    Friend WithEvents btnCursos As Button
    Friend WithEvents btnBiblioteca As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents DgvEmpleado As DataGridView
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medReportPacientes
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.dgvPacientes = New System.Windows.Forms.DataGridView()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtTelEmergencia1 = New System.Windows.Forms.TextBox()
        Me.txtTelEmergencia2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmergencia2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEmergencia1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCodPaciente = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.txtDui = New System.Windows.Forms.TextBox()
        Me.txtFechaNac = New System.Windows.Forms.TextBox()
        Me.txtEstadoCivil = New System.Windows.Forms.TextBox()
        Me.txtTelMovil = New System.Windows.Forms.TextBox()
        Me.txtTelFijo = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.dgvConsultas = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgvConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(11, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(635, 398)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(627, 370)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Pacientes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSeleccionar)
        Me.GroupBox1.Controls.Add(Me.dgvPacientes)
        Me.GroupBox1.Controls.Add(Me.txtBusqueda)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 354)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar Paciente"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(491, 294)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(108, 46)
        Me.btnSeleccionar.TabIndex = 3
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'dgvPacientes
        '
        Me.dgvPacientes.AllowUserToAddRows = False
        Me.dgvPacientes.AllowUserToDeleteRows = False
        Me.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPacientes.Location = New System.Drawing.Point(22, 51)
        Me.dgvPacientes.Name = "dgvPacientes"
        Me.dgvPacientes.ReadOnly = True
        Me.dgvPacientes.Size = New System.Drawing.Size(577, 237)
        Me.dgvPacientes.TabIndex = 2
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(79, 23)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(525, 22)
        Me.txtBusqueda.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Búsqueda:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TabControl2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(627, 370)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalles"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Location = New System.Drawing.Point(6, 7)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(615, 354)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.txtCodPaciente)
        Me.TabPage3.Controls.Add(Me.Label24)
        Me.TabPage3.Controls.Add(Me.txtDireccion)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.txtGenero)
        Me.TabPage3.Controls.Add(Me.txtDui)
        Me.TabPage3.Controls.Add(Me.txtFechaNac)
        Me.TabPage3.Controls.Add(Me.txtEstadoCivil)
        Me.TabPage3.Controls.Add(Me.txtTelMovil)
        Me.TabPage3.Controls.Add(Me.txtTelFijo)
        Me.TabPage3.Controls.Add(Me.Label27)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label25)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.txtNombre)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(607, 326)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Datos Generales"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtTelEmergencia1)
        Me.GroupBox5.Controls.Add(Me.txtTelEmergencia2)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.txtEmergencia2)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.txtEmergencia1)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 155)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(589, 165)
        Me.GroupBox5.TabIndex = 42
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos de Emergencia"
        '
        'txtTelEmergencia1
        '
        Me.txtTelEmergencia1.Enabled = False
        Me.txtTelEmergencia1.Location = New System.Drawing.Point(202, 58)
        Me.txtTelEmergencia1.Name = "txtTelEmergencia1"
        Me.txtTelEmergencia1.Size = New System.Drawing.Size(171, 22)
        Me.txtTelEmergencia1.TabIndex = 5
        '
        'txtTelEmergencia2
        '
        Me.txtTelEmergencia2.Enabled = False
        Me.txtTelEmergencia2.Location = New System.Drawing.Point(202, 128)
        Me.txtTelEmergencia2.Name = "txtTelEmergencia2"
        Me.txtTelEmergencia2.Size = New System.Drawing.Size(171, 22)
        Me.txtTelEmergencia2.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(140, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 15)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Teléfono:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(140, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 15)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Teléfono:"
        '
        'txtEmergencia2
        '
        Me.txtEmergencia2.Enabled = False
        Me.txtEmergencia2.Location = New System.Drawing.Point(202, 100)
        Me.txtEmergencia2.Name = "txtEmergencia2"
        Me.txtEmergencia2.Size = New System.Drawing.Size(223, 22)
        Me.txtEmergencia2.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(171, 15)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "En caso de Emergencia llamar a:"
        '
        'txtEmergencia1
        '
        Me.txtEmergencia1.Enabled = False
        Me.txtEmergencia1.Location = New System.Drawing.Point(202, 30)
        Me.txtEmergencia1.Name = "txtEmergencia1"
        Me.txtEmergencia1.Size = New System.Drawing.Size(223, 22)
        Me.txtEmergencia1.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(25, 33)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(171, 15)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "En caso de Emergencia llamar a:"
        '
        'txtCodPaciente
        '
        Me.txtCodPaciente.Enabled = False
        Me.txtCodPaciente.Location = New System.Drawing.Point(453, 67)
        Me.txtCodPaciente.Name = "txtCodPaciente"
        Me.txtCodPaciente.Size = New System.Drawing.Size(133, 22)
        Me.txtCodPaciente.TabIndex = 41
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(374, 70)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(73, 15)
        Me.Label24.TabIndex = 40
        Me.Label24.Text = "Registro No.:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(133, 96)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(453, 22)
        Me.txtDireccion.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(69, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 15)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Dirección:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(399, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Género:"
        '
        'txtGenero
        '
        Me.txtGenero.Enabled = False
        Me.txtGenero.Location = New System.Drawing.Point(453, 39)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(132, 22)
        Me.txtGenero.TabIndex = 31
        '
        'txtDui
        '
        Me.txtDui.Enabled = False
        Me.txtDui.Location = New System.Drawing.Point(453, 11)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.Size = New System.Drawing.Size(132, 22)
        Me.txtDui.TabIndex = 31
        '
        'txtFechaNac
        '
        Me.txtFechaNac.Enabled = False
        Me.txtFechaNac.Location = New System.Drawing.Point(133, 67)
        Me.txtFechaNac.Name = "txtFechaNac"
        Me.txtFechaNac.Size = New System.Drawing.Size(194, 22)
        Me.txtFechaNac.TabIndex = 32
        '
        'txtEstadoCivil
        '
        Me.txtEstadoCivil.Enabled = False
        Me.txtEstadoCivil.Location = New System.Drawing.Point(133, 39)
        Me.txtEstadoCivil.Name = "txtEstadoCivil"
        Me.txtEstadoCivil.Size = New System.Drawing.Size(194, 22)
        Me.txtEstadoCivil.TabIndex = 32
        '
        'txtTelMovil
        '
        Me.txtTelMovil.Enabled = False
        Me.txtTelMovil.Location = New System.Drawing.Point(453, 127)
        Me.txtTelMovil.Name = "txtTelMovil"
        Me.txtTelMovil.Size = New System.Drawing.Size(133, 22)
        Me.txtTelMovil.TabIndex = 37
        '
        'txtTelFijo
        '
        Me.txtTelFijo.Enabled = False
        Me.txtTelFijo.Location = New System.Drawing.Point(133, 124)
        Me.txtTelFijo.Name = "txtTelFijo"
        Me.txtTelFijo.Size = New System.Drawing.Size(133, 22)
        Me.txtTelFijo.TabIndex = 35
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(9, 70)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(118, 15)
        Me.Label27.TabIndex = 21
        Me.Label27.Text = "Fecha de Nacimiento:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(57, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 15)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Estado Civil:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(352, 130)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(95, 15)
        Me.Label25.TabIndex = 26
        Me.Label25.Text = "Teléfono Celular:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(418, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 15)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "DUI:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Teléfono Fijo:"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(133, 11)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(279, 22)
        Me.txtNombre.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Nombre Completo:"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.dtpFechaFin)
        Me.TabPage5.Controls.Add(Me.Label6)
        Me.TabPage5.Controls.Add(Me.dtpFechaInicio)
        Me.TabPage5.Controls.Add(Me.Label5)
        Me.TabPage5.Controls.Add(Me.btnLimpiar)
        Me.TabPage5.Controls.Add(Me.dgvConsultas)
        Me.TabPage5.Location = New System.Drawing.Point(4, 24)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(607, 326)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Historial de Consultas"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Location = New System.Drawing.Point(301, 16)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(208, 22)
        Me.dtpFechaFin.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(272, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 15)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Fin:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Location = New System.Drawing.Point(46, 16)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(217, 22)
        Me.dtpFechaInicio.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 15)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Inicio:"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(516, 11)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(82, 30)
        Me.btnLimpiar.TabIndex = 2
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'dgvConsultas
        '
        Me.dgvConsultas.AllowUserToAddRows = False
        Me.dgvConsultas.AllowUserToDeleteRows = False
        Me.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultas.Location = New System.Drawing.Point(3, 47)
        Me.dgvConsultas.Name = "dgvConsultas"
        Me.dgvConsultas.ReadOnly = True
        Me.dgvConsultas.Size = New System.Drawing.Size(601, 276)
        Me.dgvConsultas.TabIndex = 0
        '
        'medReportPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 422)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Open Sans", 8.25!)
        Me.Name = "medReportPacientes"
        Me.Text = "Reporte de Pacientes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.dgvConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents dgvPacientes As System.Windows.Forms.DataGridView
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents dgvConsultas As System.Windows.Forms.DataGridView
    Friend WithEvents txtCodPaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGenero As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As System.Windows.Forms.TextBox
    Friend WithEvents txtEstadoCivil As System.Windows.Forms.TextBox
    Friend WithEvents txtTelMovil As System.Windows.Forms.TextBox
    Friend WithEvents txtTelFijo As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelEmergencia1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTelEmergencia2 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEmergencia2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtEmergencia1 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtFechaNac As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
End Class

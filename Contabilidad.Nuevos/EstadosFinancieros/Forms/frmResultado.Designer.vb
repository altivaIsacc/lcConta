<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmResultado
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResultado))
        Me.rbAnual = New System.Windows.Forms.RadioButton()
        Me.rbMensual = New System.Windows.Forms.RadioButton()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.lbMes = New System.Windows.Forms.Label()
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nuAño = New System.Windows.Forms.NumericUpDown()
        Me.btMostrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbMoneda = New System.Windows.Forms.ComboBox()
        Me.MonedaBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.dts = New LcConta.Nuevos.dtsEstadosFinancieros()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbEstadoResultadoMensual = New System.Windows.Forms.RadioButton()
        Me.rbBalance = New System.Windows.Forms.RadioButton()
        Me.rbEstadoResultado = New System.Windows.Forms.RadioButton()
        Me.ResultadoBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nuNivel = New System.Windows.Forms.NumericUpDown()
        Me.bwCargar = New System.ComponentModel.BackgroundWorker()
        Me.pnParametros = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbCargando = New System.Windows.Forms.Label()
        Me.tcReporte = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentaContableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MostrarDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MaxHijoNivelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NivelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoAcumulado1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoAcumulado2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoAcumulado3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoAcumulado4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoAcumulado5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoAcumulado6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoAcumulado7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoAcumulado8DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoAcumulado9DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoAcumulado10DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoAcumulado11DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoAcumulado12DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcumuladoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientosDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GastoNoDeducibleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PARENTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.nuAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MonedaBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ResultadoBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuNivel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnParametros.SuspendLayout()
        Me.tcReporte.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbAnual
        '
        Me.rbAnual.AutoSize = True
        Me.rbAnual.Location = New System.Drawing.Point(6, 41)
        Me.rbAnual.Name = "rbAnual"
        Me.rbAnual.Size = New System.Drawing.Size(52, 17)
        Me.rbAnual.TabIndex = 0
        Me.rbAnual.Text = "Anual"
        Me.rbAnual.UseVisualStyleBackColor = True
        '
        'rbMensual
        '
        Me.rbMensual.AutoSize = True
        Me.rbMensual.Checked = True
        Me.rbMensual.Location = New System.Drawing.Point(6, 17)
        Me.rbMensual.Name = "rbMensual"
        Me.rbMensual.Size = New System.Drawing.Size(64, 17)
        Me.rbMensual.TabIndex = 1
        Me.rbMensual.TabStop = True
        Me.rbMensual.Text = "Mensual"
        Me.rbMensual.UseVisualStyleBackColor = True
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(3, 3)
        Me.crv.Name = "crv"
        Me.crv.ShowParameterPanelButton = False
        Me.crv.Size = New System.Drawing.Size(804, 358)
        Me.crv.TabIndex = 2
        Me.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'lbMes
        '
        Me.lbMes.AutoSize = True
        Me.lbMes.Location = New System.Drawing.Point(342, 8)
        Me.lbMes.Name = "lbMes"
        Me.lbMes.Size = New System.Drawing.Size(30, 13)
        Me.lbMes.TabIndex = 5
        Me.lbMes.Text = "Mes:"
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.FormattingEnabled = True
        Me.cbMes.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SETIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cbMes.Location = New System.Drawing.Point(397, 8)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(121, 21)
        Me.cbMes.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(524, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Año:"
        '
        'nuAño
        '
        Me.nuAño.Location = New System.Drawing.Point(572, 9)
        Me.nuAño.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.nuAño.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nuAño.Name = "nuAño"
        Me.nuAño.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.nuAño.Size = New System.Drawing.Size(48, 21)
        Me.nuAño.TabIndex = 9
        Me.nuAño.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'btMostrar
        '
        Me.btMostrar.BackColor = System.Drawing.Color.RoyalBlue
        Me.btMostrar.FlatAppearance.BorderSize = 0
        Me.btMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMostrar.ForeColor = System.Drawing.Color.White
        Me.btMostrar.Location = New System.Drawing.Point(689, 3)
        Me.btMostrar.Name = "btMostrar"
        Me.btMostrar.Size = New System.Drawing.Size(126, 50)
        Me.btMostrar.TabIndex = 11
        Me.btMostrar.Text = "Mostrar"
        Me.btMostrar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbMensual)
        Me.GroupBox1.Controls.Add(Me.rbAnual)
        Me.GroupBox1.Location = New System.Drawing.Point(246, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(90, 64)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comparación"
        '
        'cbMoneda
        '
        Me.cbMoneda.DataSource = Me.MonedaBS
        Me.cbMoneda.DisplayMember = "MonedaNombre"
        Me.cbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMoneda.FormattingEnabled = True
        Me.cbMoneda.Location = New System.Drawing.Point(397, 35)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Size = New System.Drawing.Size(121, 21)
        Me.cbMoneda.TabIndex = 14
        Me.cbMoneda.ValueMember = "CodMoneda"
        '
        'MonedaBS
        '
        Me.MonedaBS.DataMember = "Moneda"
        Me.MonedaBS.DataSource = Me.dts
        '
        'dts
        '
        Me.dts.DataSetName = "dtsResultado"
        Me.dts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbEstadoResultadoMensual)
        Me.GroupBox2.Controls.Add(Me.rbBalance)
        Me.GroupBox2.Controls.Add(Me.rbEstadoResultado)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(235, 64)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reporte"
        '
        'rbEstadoResultadoMensual
        '
        Me.rbEstadoResultadoMensual.AutoSize = True
        Me.rbEstadoResultadoMensual.Location = New System.Drawing.Point(6, 41)
        Me.rbEstadoResultadoMensual.Name = "rbEstadoResultadoMensual"
        Me.rbEstadoResultadoMensual.Size = New System.Drawing.Size(160, 17)
        Me.rbEstadoResultadoMensual.TabIndex = 2
        Me.rbEstadoResultadoMensual.Text = "Estado Resultado Extendido"
        Me.rbEstadoResultadoMensual.UseVisualStyleBackColor = True
        '
        'rbBalance
        '
        Me.rbBalance.AutoSize = True
        Me.rbBalance.Checked = True
        Me.rbBalance.Location = New System.Drawing.Point(6, 16)
        Me.rbBalance.Name = "rbBalance"
        Me.rbBalance.Size = New System.Drawing.Size(108, 17)
        Me.rbBalance.TabIndex = 1
        Me.rbBalance.TabStop = True
        Me.rbBalance.Text = "Balance Situación"
        Me.rbBalance.UseVisualStyleBackColor = True
        '
        'rbEstadoResultado
        '
        Me.rbEstadoResultado.AutoSize = True
        Me.rbEstadoResultado.Location = New System.Drawing.Point(120, 16)
        Me.rbEstadoResultado.Name = "rbEstadoResultado"
        Me.rbEstadoResultado.Size = New System.Drawing.Size(109, 17)
        Me.rbEstadoResultado.TabIndex = 0
        Me.rbEstadoResultado.Text = "Estado Resultado"
        Me.rbEstadoResultado.UseVisualStyleBackColor = True
        '
        'ResultadoBS
        '
        Me.ResultadoBS.DataMember = "Resultados"
        Me.ResultadoBS.DataSource = Me.dts
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(524, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Niveles:"
        '
        'nuNivel
        '
        Me.nuNivel.Location = New System.Drawing.Point(572, 33)
        Me.nuNivel.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nuNivel.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nuNivel.Name = "nuNivel"
        Me.nuNivel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.nuNivel.Size = New System.Drawing.Size(48, 21)
        Me.nuNivel.TabIndex = 14
        Me.nuNivel.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'bwCargar
        '
        '
        'pnParametros
        '
        Me.pnParametros.Controls.Add(Me.Label1)
        Me.pnParametros.Controls.Add(Me.cbMoneda)
        Me.pnParametros.Controls.Add(Me.btMostrar)
        Me.pnParametros.Controls.Add(Me.Label3)
        Me.pnParametros.Controls.Add(Me.GroupBox1)
        Me.pnParametros.Controls.Add(Me.nuNivel)
        Me.pnParametros.Controls.Add(Me.GroupBox2)
        Me.pnParametros.Controls.Add(Me.lbMes)
        Me.pnParametros.Controls.Add(Me.nuAño)
        Me.pnParametros.Controls.Add(Me.cbMes)
        Me.pnParametros.Controls.Add(Me.Label2)
        Me.pnParametros.Location = New System.Drawing.Point(12, 3)
        Me.pnParametros.Name = "pnParametros"
        Me.pnParametros.Size = New System.Drawing.Size(818, 67)
        Me.pnParametros.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(342, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Moneda:"
        '
        'lbCargando
        '
        Me.lbCargando.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCargando.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCargando.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbCargando.Location = New System.Drawing.Point(97, 199)
        Me.lbCargando.Name = "lbCargando"
        Me.lbCargando.Size = New System.Drawing.Size(682, 79)
        Me.lbCargando.TabIndex = 17
        Me.lbCargando.Text = "Consultando Base de Datos..."
        Me.lbCargando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbCargando.Visible = False
        '
        'tcReporte
        '
        Me.tcReporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcReporte.Controls.Add(Me.TabPage1)
        Me.tcReporte.Controls.Add(Me.TabPage2)
        Me.tcReporte.Location = New System.Drawing.Point(12, 73)
        Me.tcReporte.Name = "tcReporte"
        Me.tcReporte.SelectedIndex = 0
        Me.tcReporte.Size = New System.Drawing.Size(818, 390)
        Me.tcReporte.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.crv)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(810, 364)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Reporte"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvDatos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(810, 364)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.AutoGenerateColumns = False
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipoDataGridViewTextBoxColumn, Me.CuentaContableDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.MostrarDataGridViewCheckBoxColumn, Me.MaxHijoNivelDataGridViewTextBoxColumn, Me.NivelDataGridViewTextBoxColumn, Me.SaldoAcumulado1DataGridViewTextBoxColumn, Me.SaldoAcumulado2DataGridViewTextBoxColumn, Me.SaldoAcumulado3DataGridViewTextBoxColumn, Me.SaldoAcumulado4DataGridViewTextBoxColumn, Me.SaldoAcumulado5DataGridViewTextBoxColumn, Me.SaldoAcumulado6DataGridViewTextBoxColumn, Me.SaldoAcumulado7DataGridViewTextBoxColumn, Me.SaldoAcumulado8DataGridViewTextBoxColumn, Me.SaldoAcumulado9DataGridViewTextBoxColumn, Me.SaldoAcumulado10DataGridViewTextBoxColumn, Me.SaldoAcumulado11DataGridViewTextBoxColumn, Me.SaldoAcumulado12DataGridViewTextBoxColumn, Me.AcumuladoDataGridViewTextBoxColumn, Me.MovimientosDataGridViewCheckBoxColumn, Me.GastoNoDeducibleDataGridViewCheckBoxColumn, Me.PARENTIDDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn, Me.NotasDataGridViewTextBoxColumn})
        Me.dgvDatos.DataSource = Me.ResultadoBS
        Me.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDatos.Location = New System.Drawing.Point(3, 3)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.Size = New System.Drawing.Size(804, 358)
        Me.dgvDatos.TabIndex = 0
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CuentaContableDataGridViewTextBoxColumn
        '
        Me.CuentaContableDataGridViewTextBoxColumn.DataPropertyName = "CuentaContable"
        Me.CuentaContableDataGridViewTextBoxColumn.HeaderText = "CuentaContable"
        Me.CuentaContableDataGridViewTextBoxColumn.Name = "CuentaContableDataGridViewTextBoxColumn"
        Me.CuentaContableDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MostrarDataGridViewCheckBoxColumn
        '
        Me.MostrarDataGridViewCheckBoxColumn.DataPropertyName = "Mostrar"
        Me.MostrarDataGridViewCheckBoxColumn.HeaderText = "Mostrar"
        Me.MostrarDataGridViewCheckBoxColumn.Name = "MostrarDataGridViewCheckBoxColumn"
        Me.MostrarDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'MaxHijoNivelDataGridViewTextBoxColumn
        '
        Me.MaxHijoNivelDataGridViewTextBoxColumn.DataPropertyName = "MaxHijoNivel"
        Me.MaxHijoNivelDataGridViewTextBoxColumn.HeaderText = "MaxHijoNivel"
        Me.MaxHijoNivelDataGridViewTextBoxColumn.Name = "MaxHijoNivelDataGridViewTextBoxColumn"
        Me.MaxHijoNivelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NivelDataGridViewTextBoxColumn
        '
        Me.NivelDataGridViewTextBoxColumn.DataPropertyName = "Nivel"
        Me.NivelDataGridViewTextBoxColumn.HeaderText = "Nivel"
        Me.NivelDataGridViewTextBoxColumn.Name = "NivelDataGridViewTextBoxColumn"
        Me.NivelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoAcumulado1DataGridViewTextBoxColumn
        '
        Me.SaldoAcumulado1DataGridViewTextBoxColumn.DataPropertyName = "SaldoAcumulado1"
        Me.SaldoAcumulado1DataGridViewTextBoxColumn.HeaderText = "SaldoAcumulado1"
        Me.SaldoAcumulado1DataGridViewTextBoxColumn.Name = "SaldoAcumulado1DataGridViewTextBoxColumn"
        Me.SaldoAcumulado1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoAcumulado2DataGridViewTextBoxColumn
        '
        Me.SaldoAcumulado2DataGridViewTextBoxColumn.DataPropertyName = "SaldoAcumulado2"
        Me.SaldoAcumulado2DataGridViewTextBoxColumn.HeaderText = "SaldoAcumulado2"
        Me.SaldoAcumulado2DataGridViewTextBoxColumn.Name = "SaldoAcumulado2DataGridViewTextBoxColumn"
        Me.SaldoAcumulado2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoAcumulado3DataGridViewTextBoxColumn
        '
        Me.SaldoAcumulado3DataGridViewTextBoxColumn.DataPropertyName = "SaldoAcumulado3"
        Me.SaldoAcumulado3DataGridViewTextBoxColumn.HeaderText = "SaldoAcumulado3"
        Me.SaldoAcumulado3DataGridViewTextBoxColumn.Name = "SaldoAcumulado3DataGridViewTextBoxColumn"
        Me.SaldoAcumulado3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoAcumulado4DataGridViewTextBoxColumn
        '
        Me.SaldoAcumulado4DataGridViewTextBoxColumn.DataPropertyName = "SaldoAcumulado4"
        Me.SaldoAcumulado4DataGridViewTextBoxColumn.HeaderText = "SaldoAcumulado4"
        Me.SaldoAcumulado4DataGridViewTextBoxColumn.Name = "SaldoAcumulado4DataGridViewTextBoxColumn"
        Me.SaldoAcumulado4DataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoAcumulado5DataGridViewTextBoxColumn
        '
        Me.SaldoAcumulado5DataGridViewTextBoxColumn.DataPropertyName = "SaldoAcumulado5"
        Me.SaldoAcumulado5DataGridViewTextBoxColumn.HeaderText = "SaldoAcumulado5"
        Me.SaldoAcumulado5DataGridViewTextBoxColumn.Name = "SaldoAcumulado5DataGridViewTextBoxColumn"
        Me.SaldoAcumulado5DataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoAcumulado6DataGridViewTextBoxColumn
        '
        Me.SaldoAcumulado6DataGridViewTextBoxColumn.DataPropertyName = "SaldoAcumulado6"
        Me.SaldoAcumulado6DataGridViewTextBoxColumn.HeaderText = "SaldoAcumulado6"
        Me.SaldoAcumulado6DataGridViewTextBoxColumn.Name = "SaldoAcumulado6DataGridViewTextBoxColumn"
        Me.SaldoAcumulado6DataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoAcumulado7DataGridViewTextBoxColumn
        '
        Me.SaldoAcumulado7DataGridViewTextBoxColumn.DataPropertyName = "SaldoAcumulado7"
        Me.SaldoAcumulado7DataGridViewTextBoxColumn.HeaderText = "SaldoAcumulado7"
        Me.SaldoAcumulado7DataGridViewTextBoxColumn.Name = "SaldoAcumulado7DataGridViewTextBoxColumn"
        Me.SaldoAcumulado7DataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoAcumulado8DataGridViewTextBoxColumn
        '
        Me.SaldoAcumulado8DataGridViewTextBoxColumn.DataPropertyName = "SaldoAcumulado8"
        Me.SaldoAcumulado8DataGridViewTextBoxColumn.HeaderText = "SaldoAcumulado8"
        Me.SaldoAcumulado8DataGridViewTextBoxColumn.Name = "SaldoAcumulado8DataGridViewTextBoxColumn"
        Me.SaldoAcumulado8DataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoAcumulado9DataGridViewTextBoxColumn
        '
        Me.SaldoAcumulado9DataGridViewTextBoxColumn.DataPropertyName = "SaldoAcumulado9"
        Me.SaldoAcumulado9DataGridViewTextBoxColumn.HeaderText = "SaldoAcumulado9"
        Me.SaldoAcumulado9DataGridViewTextBoxColumn.Name = "SaldoAcumulado9DataGridViewTextBoxColumn"
        Me.SaldoAcumulado9DataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoAcumulado10DataGridViewTextBoxColumn
        '
        Me.SaldoAcumulado10DataGridViewTextBoxColumn.DataPropertyName = "SaldoAcumulado10"
        Me.SaldoAcumulado10DataGridViewTextBoxColumn.HeaderText = "SaldoAcumulado10"
        Me.SaldoAcumulado10DataGridViewTextBoxColumn.Name = "SaldoAcumulado10DataGridViewTextBoxColumn"
        Me.SaldoAcumulado10DataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoAcumulado11DataGridViewTextBoxColumn
        '
        Me.SaldoAcumulado11DataGridViewTextBoxColumn.DataPropertyName = "SaldoAcumulado11"
        Me.SaldoAcumulado11DataGridViewTextBoxColumn.HeaderText = "SaldoAcumulado11"
        Me.SaldoAcumulado11DataGridViewTextBoxColumn.Name = "SaldoAcumulado11DataGridViewTextBoxColumn"
        Me.SaldoAcumulado11DataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoAcumulado12DataGridViewTextBoxColumn
        '
        Me.SaldoAcumulado12DataGridViewTextBoxColumn.DataPropertyName = "SaldoAcumulado12"
        Me.SaldoAcumulado12DataGridViewTextBoxColumn.HeaderText = "SaldoAcumulado12"
        Me.SaldoAcumulado12DataGridViewTextBoxColumn.Name = "SaldoAcumulado12DataGridViewTextBoxColumn"
        Me.SaldoAcumulado12DataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcumuladoDataGridViewTextBoxColumn
        '
        Me.AcumuladoDataGridViewTextBoxColumn.DataPropertyName = "Acumulado"
        Me.AcumuladoDataGridViewTextBoxColumn.HeaderText = "Acumulado"
        Me.AcumuladoDataGridViewTextBoxColumn.Name = "AcumuladoDataGridViewTextBoxColumn"
        Me.AcumuladoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MovimientosDataGridViewCheckBoxColumn
        '
        Me.MovimientosDataGridViewCheckBoxColumn.DataPropertyName = "Movimientos"
        Me.MovimientosDataGridViewCheckBoxColumn.HeaderText = "Movimientos"
        Me.MovimientosDataGridViewCheckBoxColumn.Name = "MovimientosDataGridViewCheckBoxColumn"
        Me.MovimientosDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'GastoNoDeducibleDataGridViewCheckBoxColumn
        '
        Me.GastoNoDeducibleDataGridViewCheckBoxColumn.DataPropertyName = "GastoNoDeducible"
        Me.GastoNoDeducibleDataGridViewCheckBoxColumn.HeaderText = "GastoNoDeducible"
        Me.GastoNoDeducibleDataGridViewCheckBoxColumn.Name = "GastoNoDeducibleDataGridViewCheckBoxColumn"
        Me.GastoNoDeducibleDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'PARENTIDDataGridViewTextBoxColumn
        '
        Me.PARENTIDDataGridViewTextBoxColumn.DataPropertyName = "PARENTID"
        Me.PARENTIDDataGridViewTextBoxColumn.HeaderText = "PARENTID"
        Me.PARENTIDDataGridViewTextBoxColumn.Name = "PARENTIDDataGridViewTextBoxColumn"
        Me.PARENTIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NotasDataGridViewTextBoxColumn
        '
        Me.NotasDataGridViewTextBoxColumn.DataPropertyName = "Notas"
        Me.NotasDataGridViewTextBoxColumn.HeaderText = "Notas"
        Me.NotasDataGridViewTextBoxColumn.Name = "NotasDataGridViewTextBoxColumn"
        Me.NotasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmResultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(834, 465)
        Me.Controls.Add(Me.lbCargando)
        Me.Controls.Add(Me.tcReporte)
        Me.Controls.Add(Me.pnParametros)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(737, 446)
        Me.Name = "frmResultado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resultados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.nuAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MonedaBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ResultadoBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuNivel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnParametros.ResumeLayout(False)
        Me.pnParametros.PerformLayout()
        Me.tcReporte.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rbAnual As Windows.Forms.RadioButton
    Friend WithEvents rbMensual As Windows.Forms.RadioButton
    Friend WithEvents ResultadoBS As Windows.Forms.BindingSource
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents lbMes As Windows.Forms.Label
    Friend WithEvents cbMes As Windows.Forms.ComboBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents nuAño As Windows.Forms.NumericUpDown
    Friend WithEvents btMostrar As Windows.Forms.Button
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents rbBalance As Windows.Forms.RadioButton
    Friend WithEvents rbEstadoResultado As Windows.Forms.RadioButton
    Friend WithEvents cbMoneda As Windows.Forms.ComboBox
    Friend WithEvents dts As dtsEstadosFinancieros
    Friend WithEvents MonedaBS As Windows.Forms.BindingSource
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents nuNivel As Windows.Forms.NumericUpDown
    Friend WithEvents bwCargar As ComponentModel.BackgroundWorker
    Friend WithEvents pnParametros As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents lbCargando As Windows.Forms.Label
    Friend WithEvents rbEstadoResultadoMensual As Windows.Forms.RadioButton
    Friend WithEvents tcReporte As Windows.Forms.TabControl
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents TabPage2 As Windows.Forms.TabPage
    Friend WithEvents dgvDatos As Windows.Forms.DataGridView
    Friend WithEvents TipoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuentaContableDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MostrarDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MaxHijoNivelDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NivelDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoAcumulado1DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoAcumulado2DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoAcumulado3DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoAcumulado4DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoAcumulado5DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoAcumulado6DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoAcumulado7DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoAcumulado8DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoAcumulado9DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoAcumulado10DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoAcumulado11DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoAcumulado12DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AcumuladoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovimientosDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GastoNoDeducibleDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PARENTIDDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotasDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
End Class

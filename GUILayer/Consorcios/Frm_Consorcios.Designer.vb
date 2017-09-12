<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Consorcios
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
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.pnl_filtros = New System.Windows.Forms.GroupBox()
        Me.dgv_consorcios = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nroCalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_barrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.cbo_tipo = New System.Windows.Forms.ComboBox()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.pnl_filtros.SuspendLayout()
        CType(Me.dgv_consorcios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_quitar
        '
        Me.btn_quitar.Enabled = False
        Me.btn_quitar.Location = New System.Drawing.Point(138, 343)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(44, 40)
        Me.btn_quitar.TabIndex = 16
        Me.btn_quitar.Text = "Quitar"
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(396, 343)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(40, 40)
        Me.btn_salir.TabIndex = 17
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Enabled = False
        Me.btn_editar.Location = New System.Drawing.Point(78, 343)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(54, 40)
        Me.btn_editar.TabIndex = 15
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(23, 343)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(49, 40)
        Me.btn_nuevo.TabIndex = 14
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'pnl_filtros
        '
        Me.pnl_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnl_filtros.Controls.Add(Me.dgv_consorcios)
        Me.pnl_filtros.Controls.Add(Me.chk_todos)
        Me.pnl_filtros.Controls.Add(Me.Label3)
        Me.pnl_filtros.Controls.Add(Me.txt_nombre)
        Me.pnl_filtros.Controls.Add(Me.btn_consultar)
        Me.pnl_filtros.Controls.Add(Me.cbo_tipo)
        Me.pnl_filtros.Controls.Add(Me.lbl_estado)
        Me.pnl_filtros.Location = New System.Drawing.Point(23, 24)
        Me.pnl_filtros.Name = "pnl_filtros"
        Me.pnl_filtros.Size = New System.Drawing.Size(413, 313)
        Me.pnl_filtros.TabIndex = 13
        Me.pnl_filtros.TabStop = False
        Me.pnl_filtros.Text = "Filtros"
        '
        'dgv_consorcios
        '
        Me.dgv_consorcios.AllowUserToAddRows = False
        Me.dgv_consorcios.AllowUserToDeleteRows = False
        Me.dgv_consorcios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_consorcios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_nombre, Me.col_tipo, Me.col_calle, Me.col_nroCalle, Me.col_barrio})
        Me.dgv_consorcios.Location = New System.Drawing.Point(26, 115)
        Me.dgv_consorcios.Name = "dgv_consorcios"
        Me.dgv_consorcios.ReadOnly = True
        Me.dgv_consorcios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_consorcios.Size = New System.Drawing.Size(372, 192)
        Me.dgv_consorcios.TabIndex = 8
        '
        'col_id
        '
        Me.col_id.HeaderText = "ID"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        '
        'col_tipo
        '
        Me.col_tipo.HeaderText = "Tipo"
        Me.col_tipo.Name = "col_tipo"
        Me.col_tipo.ReadOnly = True
        '
        'col_calle
        '
        Me.col_calle.HeaderText = "Calle"
        Me.col_calle.Name = "col_calle"
        Me.col_calle.ReadOnly = True
        '
        'col_nroCalle
        '
        Me.col_nroCalle.HeaderText = "Nro"
        Me.col_nroCalle.Name = "col_nroCalle"
        Me.col_nroCalle.ReadOnly = True
        '
        'col_barrio
        '
        Me.col_barrio.HeaderText = "Barrio"
        Me.col_barrio.Name = "col_barrio"
        Me.col_barrio.ReadOnly = True
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.Location = New System.Drawing.Point(74, 75)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos.TabIndex = 2
        Me.chk_todos.Text = "Todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Nombre:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(74, 22)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(181, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(311, 86)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(87, 23)
        Me.btn_consultar.TabIndex = 3
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'cbo_tipo
        '
        Me.cbo_tipo.FormattingEnabled = True
        Me.cbo_tipo.Location = New System.Drawing.Point(74, 48)
        Me.cbo_tipo.Name = "cbo_tipo"
        Me.cbo_tipo.Size = New System.Drawing.Size(181, 21)
        Me.cbo_tipo.TabIndex = 1
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Location = New System.Drawing.Point(32, 51)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(31, 13)
        Me.lbl_estado.TabIndex = 0
        Me.lbl_estado.Text = "Tipo:"
        '
        'Frm_Consorcios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 442)
        Me.Controls.Add(Me.btn_quitar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.pnl_filtros)
        Me.Name = "Frm_Consorcios"
        Me.Text = "Form1"
        Me.pnl_filtros.ResumeLayout(False)
        Me.pnl_filtros.PerformLayout()
        CType(Me.dgv_consorcios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_quitar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents pnl_filtros As GroupBox
    Friend WithEvents dgv_consorcios As DataGridView
    Friend WithEvents chk_todos As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents btn_consultar As Button
    Friend WithEvents cbo_tipo As ComboBox
    Friend WithEvents lbl_estado As Label
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As DataGridViewTextBoxColumn
    Friend WithEvents col_tipo As DataGridViewTextBoxColumn
    Friend WithEvents col_calle As DataGridViewTextBoxColumn
    Friend WithEvents col_nroCalle As DataGridViewTextBoxColumn
    Friend WithEvents col_barrio As DataGridViewTextBoxColumn
End Class

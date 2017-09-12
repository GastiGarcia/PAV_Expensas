Public Class Frm_Consorcios

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        Frm_abm_Consorcios.ShowDialog()
    End Sub

    Private Sub Frm_Consorcios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombo(cbo_tipo, BDHelper.getDBHelper.ConsultaSQL("SELECT * From TipoConsorcio"), "descripcion", "id_tipoConsorcio")
    End Sub

    Friend Sub llenarCombo(ByVal cbo As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.ValueMember = value
        cbo.SelectedIndex = -1
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_todos.CheckedChanged
        If chk_todos.Checked Then
            txt_nombre.Enabled = False
            cbo_tipo.Enabled = False
        Else
            txt_nombre.Enabled = True
            cbo_tipo.Enabled = True
        End If
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        'Confirmación de salida.
        If MsgBox("Seguro que desea salir de todas formas?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consultar.Click
        Dim sql As String = "SELECT id_conorcio, C.nombre as 'nombre', T.descripcion as 'descripcion', calle, nro_calle, B.nombre as 'barrio' FROM Consorcio C JOIN TipoConsorcio T ON C.id_tipo_consorcio = T.id_tipoConsorcio JOIN Barrio B ON C.id_barrio=B.id_barrio WHERE 1=1"
        Dim filters As New List(Of Object)
        Dim flag_filtros As Boolean = False

        If Not chk_todos.Checked Then
            'Validar si el combo 'Perfiles' esta seleccionado.
            If cbo_tipo.Text <> String.Empty Then
                'Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                filters.Add(cbo_tipo.SelectedValue)
                sql += " AND T.id_tipoConsorcio=@param1 "
                flag_filtros = True
            Else
                filters.Add(Nothing)
            End If

            'Validar si el combo 'Perfiles' esta seleccionado.
            If txt_nombre.Text <> String.Empty Then
                'Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                filters.Add(txt_nombre.Text)
                sql += " AND C.nombre LIKE '%' + @param2 + '%' "
                flag_filtros = True
            Else
                filters.Add(Nothing)
            End If

            If flag_filtros Then
                llenar_grid(BDHelper.getDBHelper.ConsultarSQLConParametros(sql, filters.ToArray))
            Else
                MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            llenar_grid(BDHelper.getDBHelper.ConsultaSQL(sql))
        End If
    End Sub

    Private Sub llenar_grid(ByVal source As DataTable)
        dgv_consorcios.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_consorcios.Rows.Add(New String() {row.Item("id_conorcio").ToString, row.Item("nombre").ToString, row.Item("descripcion").ToString, row.Item("calle").ToString, row.Item("nro_calle").ToString, row.Item("barrio").ToString})
        Next
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        Frm_abm_Consorcios.seleccionar_consorcio(Frm_abm_Consorcios.Opcion.update, dgv_consorcios.CurrentRow)
        Frm_abm_Consorcios.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub


    Private Sub dgv_users_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_consorcios.CellContentClick
        btn_editar.Enabled = True
        btn_quitar.Enabled = True
    End Sub

    Private Sub btn_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quitar.Click
        Frm_abm_Consorcios.seleccionar_consorcio(Frm_abm_Consorcios.Opcion.delete, dgv_consorcios.CurrentRow)
        Frm_abm_Consorcios.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub

End Class

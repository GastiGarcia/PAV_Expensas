Public Class Frm_abm_Consorcios
    Enum Opcion
        insert
        update
        delete
    End Enum

    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow

    Friend Sub llenarCombo(ByVal cbo As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.ValueMember = value
        cbo.SelectedIndex = -1
    End Sub

    Private Sub Frm_new_Consorcios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombo(cbo_tipo, BDHelper.getDBHelper.ConsultaSQL("SELECT * From TipoConsorcio"), "descripcion", "id_tipoConsorcio")
        llenarCombo(cbo_Barrio, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Barrio"), "nombre", "id_barrio")
        Select Case _action
            Case Opcion.insert
                Me.Text = "Nuevo Consorcio"
                _row_selected = Nothing

            Case Opcion.update
                Me.Text = "Actualizar Consorcio"
                'Recuperar consorcio seleccionado en la grilla 
                mostrar_datos()
                txt_Nombre.Enabled = True
                cbo_tipo.Enabled = True
                txt_calle.Enabled = True
                txt_nro.Enabled = True
                cbo_Barrio.Enabled = True

            Case Opcion.delete
                mostrar_datos()
                Me.Text = "Eliminar Consorcio"
                txt_Nombre.Enabled = True
                cbo_tipo.Enabled = True
                txt_calle.Enabled = True
                txt_nro.Enabled = True
                cbo_Barrio.Enabled = True
        End Select


    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Dispose()
    End Sub


    Public Sub seleccionar_consorcio(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub

    Private Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then

            txt_Nombre.Text = _row_selected.Cells("col_nombre").Value
            cbo_tipo.Text = _row_selected.Cells("col_tipo").Value
            txt_calle.Text = _row_selected.Cells("col_calle").Value
            txt_nro.Text = _row_selected.Cells("col_nroCalle").Value
            cbo_Barrio.Text = _row_selected.Cells("col_barrio").Value
        End If
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Dim str_sql As String = ""


        Select Case _action
            Case Opcion.insert
                If existe_nombre() = False Then
                    If validar_campos() Then
                        str_sql = "INSERT INTO Consorcio (nombre, id_tipo_consorcio, calle, nro_calle, id_barrio) VALUES('"
                        str_sql += txt_Nombre.Text + "','"
                        str_sql += cbo_tipo.SelectedValue.ToString + "','"
                        str_sql += txt_calle.Text + "','"
                        str_sql += txt_nro.Text + "',"
                        str_sql += cbo_Barrio.SelectedValue.ToString + ")"
                        If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                            MessageBox.Show("Consorcio insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Me.Close()
                        End If
                    End If
                Else
                    MessageBox.Show("Nombre de Consorcio encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case Opcion.update
                If validar_campos() Then
                    MsgBox(txt_Nombre.ToString())
                    str_sql = "UPDATE Consorcio SET nombre = '"
                    str_sql += txt_Nombre.Text + "', id_tipo_consorcio = "
                    str_sql += cbo_tipo.SelectedValue.ToString + ", calle ='"
                    str_sql += txt_calle.Text + "', nro_calle ='"
                    str_sql += txt_nro.Text + "', id_barrio = '"
                    str_sql += cbo_Barrio.SelectedValue.ToString
                    str_sql += " WHERE id_conorcio = " + _row_selected.Cells("col_id").Value
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Consorcio actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el consorcio!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case Opcion.delete
                'Dim existe As Object

                If MsgBox("Seguro que desea borrar el consorcio seleccionado?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    str_sql = "Select COUNT(*) from Propiedad P JOIN Consorcio C ON P.id_consorcio=C.id_conorcio AND C.id_conorcio =" + ToString(3) ' _row_selected.Cells("col_id").Value.ToString
                    MessageBox.Show(_row_selected.Cells("col_id").Value, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MessageBox.Show(BDHelper.getDBHelper.EjecutarSQL(str_sql), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) <= 0 Then
                        MessageBox.Show("Consorcio asociado a propiedades", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select
    End Sub

    Private Function validar_campos() As Boolean
        'campos obligatorios
        'If txt_Nombre.Text = String.Empty Then
        'txt_Nombre.BackColor = Color.Red
        '  txt_Nombre.Focus()
        ' Return False
        ' Else
        'txt_Nombre.BackColor = Color.White
        'End If

        'If txt_password.Text = String.Empty Then
        'txt_password.BackColor = Color.Red
        'txt_password.Focus()
        'Return False
        'Else
        'txt_password.BackColor = Color.White
        'End If

        ' If txt_confirmar_pass.Text = String.Empty Then
        'txt_confirmar_pass.BackColor = Color.Red
        'txt_confirmar_pass.Focus()
        'Return False
        'Else
        'txt_confirmar_pass.BackColor = Color.White
        'End If

        If cbo_tipo.Text = String.Empty Then
            cbo_tipo.BackColor = Color.Red
            cbo_tipo.Focus()
            Return False
        Else
            cbo_tipo.BackColor = Color.White
        End If

        If cbo_Barrio.Text = String.Empty Then
            cbo_Barrio.BackColor = Color.Red
            cbo_Barrio.Focus()
            Return False
        Else
            cbo_Barrio.BackColor = Color.White
        End If

        'If txt_confirmar_pass.Text <> txt_password.Text Then
        'txt_confirmar_pass.BackColor = Color.Red
        'txt_password.BackColor = Color.Red
        'txt_confirmar_pass.Focus()
        'Return False
        'Else
        'txt_confirmar_pass.BackColor = Color.White
        'txt_password.BackColor = Color.White
        'End If

        Return True
    End Function

    Private Function existe_nombre() As Boolean
        Return BDHelper.getDBHelper.ConsultaSQL("Select * from Consorcio where nombre = '" + txt_Nombre.Text + "'").Rows.Count > 0
    End Function

End Class
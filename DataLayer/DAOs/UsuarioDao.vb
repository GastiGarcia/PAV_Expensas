Public Class UsuarioDao
    'Permite recuperar un usuario a partir de un nombre y password
    Public Function getUserByNamePass(ByVal nombre As String, ByVal password As String) As Usuario
        Dim sql As String = "Select * from Usuario where nom_usuario = '" + nombre + "' AND pass = '" + password + "'"
        Dim oTabla As DataTable
        Dim oUsuario As Usuario = Nothing

        oTabla = BDHelper.getDBHelper.ConsultaSQL(sql)
        If oTabla.Rows.Count Then
            oUsuario = map_user(oTabla.Rows(0))
        End If

        Return oUsuario
    End Function

    Public Function getUserByName(nombre As String) As Usuario
        Dim sql As String = "Select * from Usuario where nom_usuario = '" + nombre + "'"
        Dim oTabla As DataTable
        Dim oUsuario As Usuario = Nothing

        oTabla = BDHelper.getDBHelper.ConsultaSQL(sql)
        If oTabla.Rows.Count Then
            oUsuario = map_user(oTabla.Rows(0))
        End If

        Return oUsuario
    End Function



    'Permite recuperar todos los usuarios cargados
    Public Function getAll() As IList(Of Usuario)
        Dim lst As New List(Of Usuario)
        Dim sql As String = "Select x.*, y.n_perfil, y.id_perfil as perfil_usuario from Users x, Perfiles y where x.id_perfil=y.id_perfil"
        Dim oUsuario As Usuario = Nothing

        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(sql).Rows
            lst.Add(map_user(row))
        Next

        Return lst
    End Function

    'Permite recuperar todos los usuarios cargados para un determinado rango de fechas y/o perfil recibidos como 
    'parámetrosr
    Public Function getByFilters(ByVal params As Object()) As IList(Of Usuario)

        Dim lst As New List(Of Usuario)
        Dim sql As String = "Select x.*, y.n_perfil, y.id_perfil as perfil_usuario from Users x, Perfiles y where x.id_perfil=y.id_perfil "
        Dim oUsuario As Usuario = Nothing

        If Not IsNothing(params(0)) Then sql += " AND x.id_perfil=@param1 "
        If Not IsNothing(params(1)) Then sql += " AND x.n_usuario LIKE '%' + @param2 + '%' "

        For Each row As DataRow In BDHelper.getDBHelper.ConsultarSQLConParametros(sql, params).Rows
            lst.Add(map_user(row))
        Next

        Return lst
    End Function

    'Funciones CRUD
    Public Function create(ByVal oUsuario As Usuario)
        Dim str_sql As String

        str_sql = "INSERT INTO Usuario (nom_usuario, pass, email, administrador) VALUES('"
        str_sql += oUsuario.nom_usuario + "','"
        str_sql += oUsuario.pass + "','"
        str_sql += oUsuario.email + "',"
        str_sql += oUsuario.administrador + "')"

        'Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
        Return (BDHelper.getDBHelper().EjecutarSQL(str_sql) = 1)
    End Function
    'Funciones CRUD

    Public Function update(ByVal oUsuario As Usuario)
        Dim str_sql As String

        str_sql = "UPDATE Usuario SET nom_usuario = '"
        str_sql += oUsuario.nom_usuario + "', pass = '"
        str_sql += oUsuario.pass + "', email = '"
        str_sql += oUsuario.email + "', administrador = "
        str_sql += oUsuario.administrador + "'"

        str_sql += " WHERE id_usuario = " + oUsuario.id_usuario.ToString

        'Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
        Return (BDHelper.getDBHelper().EjecutarSQL(str_sql) = 1)
    End Function

    'Función auxiliar responsable de MAPPEAR una fila de Users a un objeto Usuario
    Private Function map_user(ByRef row As DataRow) As Usuario
        Dim oUsuario As New Usuario

        oUsuario.id_usuario = Convert.ToInt32(row.Item("id_usuario").ToString)
        oUsuario.nom_usuario = row.Item("nom_usuario").ToString
        oUsuario.pass = row.Item("pass").ToString
        oUsuario.email = row.Item("email").ToString
        oUsuario.administrador = row.Item("administrador").ToString
        Return oUsuario
    End Function
End Class

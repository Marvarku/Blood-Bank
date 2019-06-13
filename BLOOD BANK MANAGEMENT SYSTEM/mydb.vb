Imports MySql.Data.MySqlClient
Public Class mydb

    Private con As New MySqlConnection("datasource = localhost; port=3306; username=root; password=; database=blood_bank_management")

    'the read only here means that the procedure can be only read from but not written to.
    ReadOnly Property getconnection() As MySqlConnection
        Get
            Return con
        End Get
    End Property

    'opening connection
    Sub openconnection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    'closing connection
    Sub closeconnection()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

End Class

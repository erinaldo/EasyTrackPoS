Imports System.Data.SqlClient

Module DBConnection
    Public Function PosConnection() As SqlConnection
        Return New SqlConnection(My.Settings.PoSConnectionString)
    End Function
    Public Poscon As SqlConnection = PosConnection()
End Module
'Imports MySql.Data.MySqlClient

'Module DBConnection
'    Public Function strstrconnection() As MySqlConnection
'        Return New MySqlConnection("server=localhost;user id=root;Password=;database=foodapp;sslMode=none;Convert Zero Datetime=True;")
'    End Function
'    Public Poscon As MySqlConnection = strstrconnection()
'End Module

Imports MySql.Data.MySqlClient

Module DBConnection
    Public Function strstrconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;Password=;database=foodapp;sslMode=none;Convert Zero Datetime=True;")
    End Function
    Public strcon As MySqlConnection = strstrconnection()
End Module

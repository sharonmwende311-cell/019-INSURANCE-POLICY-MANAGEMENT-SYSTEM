Imports DotNetEnv

Imports MySql.Data.MySqlClient


Public Class DatabaseConnection

    Public Shared Function GetConnection() As MySqlConnection

        Env.Load()


        Dim connectionString As String =
            $"Server={Environment.GetEnvironmentVariable("DB_HOST")};" &
            $"Port={Environment.GetEnvironmentVariable("DB_PORT")};" &
            $"Database={Environment.GetEnvironmentVariable("DB_NAME")};" &
            $"Uid={Environment.GetEnvironmentVariable("DB_USER")};" &
            $"Pwd={Environment.GetEnvironmentVariable("DB_PASS")};"

        Return New MySqlConnection(connectionString)

    End Function

End Class
Imports System.Data.SqlClient

Public Class SessionManager


    ' Function to check if a user is already logged in
    Public Function IsUserLoggedIn(userId As Integer) As Boolean
        Dim isLoggedIn As Boolean = False

        Using connection As New SqlConnection(cnn)
            connection.Open()

            ' SQL query to check if there is an active session for the user
            Dim query As String = "SELECT COUNT(*) FROM UserSessions WHERE UserId = @userId AND IsActive = 1 AND ExpiryDate > GETDATE()"

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@userId", userId)

                ' Execute the query
                Dim sessionCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' If there is at least one active session, the user is already logged in
                If sessionCount > 0 Then
                    isLoggedIn = True
                End If
            End Using
        End Using

        Return isLoggedIn
    End Function
    Public Sub CreateNewSession(userId As Integer)
        Dim sessionToken As String = Guid.NewGuid().ToString()
        Dim expiryDate As DateTime = DateTime.Now.AddHours(1) ' Session expires in 1 hour

        Using connection As New SqlConnection(cnn)
            connection.Open()

            Dim query As String = "INSERT INTO UserSessions (UserId, SessionToken, ExpiryDate, IsActive) VALUES (@userId, @sessionToken, @expiryDate, 1)"

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@userId", userId)
                command.Parameters.AddWithValue("@sessionToken", sessionToken)
                command.Parameters.AddWithValue("@expiryDate", expiryDate)

                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Method to delete the session during sign-out
    Public Sub DeleteSession(userId As Integer)
        Using connection As New SqlConnection(cnn)
            connection.Open()

            ' SQL query to delete the session for the user
            Dim query As String = "DELETE FROM UserSessions WHERE UserId = @userId AND IsActive = 1"

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@userId", userId)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Alternatively, you can use this method to mark the session as inactive
    Public Sub InvalidateSession(userId As Integer)
        Using connection As New SqlConnection(cnn)
            connection.Open()

            ' SQL query to mark the session as inactive
            Dim query As String = "UPDATE UserSessions SET IsActive = 0 WHERE UserId = @userId AND IsActive = 1"

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@userId", userId)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class

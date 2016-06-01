Imports System.Data.SqlClient
Imports System.Data

Module vbSQLConnect

    Public Class SQLConnect

        Public Shared Function ConnectDB() As Boolean
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim Success As Boolean = False

            Try
                con.ConnectionString = "Server=LNGIV90;Database=DBTICKET;Trusted_Connection=Yes;"
                con.Open()
                Success = True

            Catch ex As Exception
                MessageBox.Show("Error while connecting to SQL Server." & ex.Message) 'Finally

                Success = False
                con.Close() 'Whether there is error or not. Close the connection.
            End Try

            Return Success

        End Function

        Public Shared Function InsertDB(ByVal strIncId As String, ByVal strSumm As String, ByVal strAssign As String, ByVal strRelate As String, ByVal strNotes As String, ByVal chkComp As Boolean, ByVal chkFix As Boolean) As String
            Dim sqCon As New SqlConnection("Server=LNGIV90;Database=DBTICKET;Trusted_Connection=Yes;")
            Dim sqCmd As New SqlCommand
            Dim strInsert As String = ""

            strInsert = "INSERT INTO DBTICKET.dbo.tblTicket"
            strInsert = strInsert + " (IncId , Summary , Assignment , Relationship , Notes , Complete , Fix )"
            strInsert = strInsert + " VALUES ("
            strInsert = strInsert + "'" + strIncId + "' ,"
            strInsert = strInsert + "'" + strSumm + "' ,"
            strInsert = strInsert + "'" + strAssign + "' ,"
            strInsert = strInsert + "'" + strRelate + "' ,"
            strInsert = strInsert + "'" + strNotes + "' ,"
            strInsert = strInsert + chkComp.ToString + ","
            strInsert = strInsert + chkFix.ToString + ")"

            Try
                sqCmd.Connection = sqCon            'create the DB connection
                sqCmd.CommandText = strInsert
                sqCon.Open()                        'open the connection
                sqCmd.ExecuteNonQuery()             'execute the SQL command
                sqCon.Close()

            Catch ex As Exception
                MessageBox.Show("Error while connecting to SQL Server." & ex.Message) 'Finally

                sqCon.Close() 'Whether there is error or not. Close the connection.

            End Try

            Return strInsert
        End Function
    End Class

End Module

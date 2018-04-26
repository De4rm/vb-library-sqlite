'it is an installed package
'that contain objects for 
'work with SQLite database
Imports System.Data.SQLite

'this class is created to help 
'for manipulation of data in database
Public Class Server
    'geting path to desktop where it will be
    'database with name "myDataBase.db"
    Dim location As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Dim fileName As String = "myDataBase.db"
    Dim fullPath As String = System.IO.Path.Combine(location, fileName)
    Public connectionString As String = String.Format("Data Source = {0}", fullPath)

    'method that check if it was created
    'database. if it was not created then 
    'create it
    Public Sub createDataBase()
        'condition for cheacking if there exist database
        If Not duplicateDataBase(fullPath) Then
            'SQL query for creation of table in database
            Dim createTable As String = "CREATE TABLE `books` (
	                                    `id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	                                    `name`	TEXT NOT NULL UNIQUE,
	                                    `author`	TEXT NOT NULL UNIQUE,
	                                    `description`	TEXT NOT NULL,
	                                    `is_avaible`	INTEGER NOT NULL,
	                                    `image`	TEXT
                                        );"
            'connect to database and execute query for creation of table
            Using SqlConn As New SQLiteConnection(connectionString)
                Dim cmd As New SQLiteCommand(createTable, SqlConn)
                SqlConn.Open()
                cmd.ExecuteNonQuery()
            End Using

        End If
    End Sub

    'method for adding a new row in table
    'it is used parameter bookData with type 
    'BookTable that is a structure from module 
    'Common.
    Public Sub addNewBook(bookData As BookTable)
        'SQL query for creating a new record in table
        Dim addNewBook As String = "INSERT INTO books(name, author, description, is_avaible, image) VALUES(@name, @author, 
                                                             @description, @is_avaible, @image);"

        'connect to database
        Using SqlConn As New SQLiteConnection(connectionString)
            'create a command object
            Dim cmd As New SQLiteCommand(addNewBook, SqlConn)
            'open connection with database
            SqlConn.Open()
            'add values of parameters in query
            cmd.Parameters.AddWithValue("@name", bookData.name)
            cmd.Parameters.AddWithValue("@author", bookData.author)
            cmd.Parameters.AddWithValue("@description", bookData.description)
            cmd.Parameters.AddWithValue("@is_avaible", bookData.bookAvalible)
            cmd.Parameters.AddWithValue("@image", bookData.image)
            'execute command
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    'deleting record from table.
    'parameter id help in identifing 
    'of row in table with help of column id.
    Public Sub DeleteBook(id As Integer)
        'connection to db
        Using SqlConn As New SQLiteConnection(connectionString)
            'sql query for deletion of row with parameter id
            Dim removeQuery As String = "DELETE FROM books WHERE id = @id"

            'create command object, open connection, 
            'add parameter  id to query and execute query
            Dim cmd As New SQLiteCommand(removeQuery, SqlConn)
            SqlConn.Open()
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    'method for getting records from table.
    'parameter type_show have valueType TypeShow 
    'from module Common. help in selection of 
    'available, unavailable and all books.
    'This method return a list of records with 
    'valueType BookTable from Common module.
    Public Function selectBooks(type_show As TypeShow) As List(Of BookTable)
        'create var that will register and will be returned 
        'to form for proccessing of data
        Dim allBooks As New List(Of BookTable)
        'connection to db 
        Using SqlConn As New SQLiteConnection(connectionString)
            'save sql query
            Dim removeQuery As String = "SELECT * FROM books"
            'var that will save value for filter
            Dim value As Short
            'check if filter parameter is not for all table
            If Not type_show = TypeShow.All Then
                'if it is specific books then we add 
                'to selection query this string
                removeQuery = removeQuery + " WHERE is_avaible = @is_avaible"
                'check if filter parameter is of type available 
                'or unavailable.
                If type_show = TypeShow.Available Then
                    value = 1
                Else
                    value = 0
                End If

            End If

            'create a command object and open connection
            Dim cmd As New SQLiteCommand(removeQuery, SqlConn)
            SqlConn.Open()

            'add parameter to sql query if 
            'Filter Type Is Not for all books
            If Not type_show = TypeShow.All Then
                cmd.Parameters.AddWithValue("@is_avaible", value)
            End If

            'create a reader that will 
            'execute Sql cmd
            Dim reader As SQLiteDataReader = cmd.ExecuteReader()

            'read every row from table
            While reader.Read()
                'create a new structure with valueType
                'BookTable()
                Dim nextBook As New BookTable()
                'add every value from column to object 
                'BookTable
                nextBook.id = reader.GetValue(0)
                nextBook.name = reader.GetValue(1)
                nextBook.author = reader.GetValue(2)
                nextBook.description = reader.GetValue(3)
                nextBook.bookAvalible = reader.GetValue(4)
                nextBook.image = reader.GetValue(5)
                'add this structure to list that will be returned
                allBooks.Add(nextBook)
            End While
        End Using
        'return list of BookTable
        Return allBooks
    End Function

    'method for updating of a record 
    'from table
    Public Sub updateBook(bookData As BookTable, ChangeAll As Boolean)
        'connect to db
        Using SqlConn As New SQLiteConnection(connectionString)
            'sql query
            Dim removeQuery As String = "UPDATE books SET "

            'check if parameter ChangeAll is true
            'if is true then all columns from record 
            'will be updated
            If ChangeAll Then
                'str that will help with updating 
                'of all data from record
                removeQuery = removeQuery + "name=@name,
                                             author=@author,
                                             description=@description,
                                             image=@image,"
            End If
            removeQuery = removeQuery + "is_avaible=@is_avaible WHERE id = @id"

            'create comand object
            Dim cmd As New SQLiteCommand(removeQuery, SqlConn)
            SqlConn.Open()
            'add all parameters and execute update
            cmd.Parameters.AddWithValue("@name", bookData.name)
            cmd.Parameters.AddWithValue("@author", bookData.author)
            cmd.Parameters.AddWithValue("@description", bookData.description)
            cmd.Parameters.AddWithValue("@is_avaible", bookData.bookAvalible)
            cmd.Parameters.AddWithValue("@image", bookData.image)
            cmd.Parameters.AddWithValue("@id", bookData.id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    'check if database file alredy exist
    Private Function duplicateDataBase(fullPath As String) As Boolean
        Return System.IO.File.Exists(fullPath)
    End Function

End Class

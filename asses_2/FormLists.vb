Public Class FormLists
    'type of filter
    Public showType As TypeShow
    Private Sub FormLists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'create new server object and list of BookTable
        Dim serv As New Server()
        Dim list As List(Of BookTable)
        'get all books by filter
        list = serv.selectBooks(showType)

        'loop every book from list
        For Each item In list
            'var for flag Available/Unavailable
            Dim av_val As String
            'check if book is available and add 
            'coresponding value to av_val 
            If item.bookAvalible Then
                av_val = "Available"
            Else
                av_val = "Unavailable"
            End If
            'add item in ListBox with bookName, bookAuthor, and bookStatus
            ListBox1.Items.Add(item.name + ", " + item.author + ", " + av_val)
        Next
    End Sub
End Class
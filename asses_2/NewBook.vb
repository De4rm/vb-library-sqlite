Public Class NewBook
    'public var that check if is update or new book
    Public UpdateFlag As Boolean = False
    'it is current book, may be new or existing book for update
    Public book As BookTable

    'event onclick for button add
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'create server object
        Dim serv As New Server()
        'fill data from form into BookTable object
        book.name = tbxName.Text
        book.author = tbxAuthor.Text
        book.description = tbxDescription.Text
        book.bookAvalible = 1
        book.image = Label4.Text
        'check if is update of existing book
        If UpdateFlag Then
            'update current book with new data
            serv.updateBook(book, True)
            'make changes in form
            Library.ChangeCurrentBook(book)
        Else
            'create new book with current data
            serv.addNewBook(book)
            'update data on form
            Library.UpdateDataOnForm(book)
        End If
        'close this form
        Me.Close()
    End Sub

    'event on load of this form
    Private Sub NewBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'check if is update of existing book
        If UpdateFlag Then
            'change button text and form text to update
            Dim labl As String = "Update"
            btnAdd.Text = labl
            Me.Text = labl
            'load data on form from current book
            tbxAuthor.Text = book.author
            tbxName.Text = book.name
            tbxDescription.Text = book.description
            Label4.Text = book.image
        End If
    End Sub

    'event on click for button browse
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'create a file dialog object
        Dim dialog As New OpenFileDialog()
        'after selection of file check if it was pressed
        'button OK then save path in label4.text
        If dialog.ShowDialog() = DialogResult.OK Then
            Label4.Text = dialog.FileName
        End If
    End Sub
End Class

Public Class Library

    'a list of all books
    Dim books As List(Of BookTable)
    'var with current book
    Dim currentBook As New BookTable()
    'current index of book in list
    Dim currentIndex As Integer
    'num. total of books in database
    Dim TotalBooks As Integer

    'check if it was added a new book
    Public addedNewBook As Boolean = False

    'update data if form when is
    'added new book
    Public Sub UpdateDataOnForm(book As BookTable)
        'add new book to list of all books
        books.Add(book)
        'update total books
        TotalBooks = TotalBooks + 1
        'update label that show current book number and total books
        lblCounter.Text = String.Concat(currentIndex + 1) + "/" + String.Concat(TotalBooks)
    End Sub

    'change column that show if 
    'book Is available Or Not
    Private Sub update_is_available(value As Short)
        'create a new object Server
        Dim serv As New Server()
        'change value of field BookAvailable 
        'With value from parameter "value"
        currentBook.bookAvalible = value
        'update database with changes
        serv.updateBook(currentBook, False)
        'after change in db also change in list
        'with actual data
        books(currentIndex) = currentBook
        'update form data in fileds
        LoadBook()
    End Sub

    'update adata in form after some changes in database
    Public Sub ChangeCurrentBook(book As BookTable)
        'update current book in form
        currentBook = book
        'update current book in list of books
        books(currentIndex) = book
        'update fields on form
        LoadBook()
    End Sub

    'event onclick for button <<(previous)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        'control if we are in boundary of the list
        If currentIndex > 0 Then
            'enables button
            btnNext.Enabled = True
            'change index of the book
            currentIndex = currentIndex - 1
            'change current book
            currentBook = books(currentIndex)
            'update data on form
            LoadBook()
            'update label on form with current book number
            'and total numbers of books
            lblCounter.Text = String.Concat(currentIndex + 1) + "/" + String.Concat(TotalBooks)
        Else
            'if we do not have any more 
            'books make button disabled
            btnPrevious.Enabled = False
        End If
    End Sub

    'event onclick for new book in menu books
    Private Sub NewBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewBookToolStripMenuItem.Click
        'create a form NewBook
        Dim new_book As New NewBook()
        'open this form
        new_book.Show()
    End Sub

    'event on load this form.
    'first event that is executed by
    'app on start.
    Private Sub Library_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'create a new object Server
        Dim server As New Server()
        'check if database is created 
        'If Not create Then New database
        server.createDataBase()
        'fill var books with list of all 
        'books from database
        books = server.selectBooks(TypeShow.All)
        'count all books in list and write in 
        'var TotalBooks
        TotalBooks = books.Count()
        'check if totalBooks is not 0
        If TotalBooks Then
            'make currentBook first book
            'and currentIndex index of first book
            currentBook = books(0)
            currentIndex = 0
            'update form with data of currentBook
            LoadBook()
            'update label on form with currentBook count number 
            'and TotalBooks
            lblCounter.Text = "1/" + String.Concat(TotalBooks)
        Else
            'if there are not books in database
            lblCounter.Text = "0/0"
        End If
    End Sub

    'update data on form
    'every time is made a chenge in
    'database  or change of currentBook
    Private Sub LoadBook()
        'will show if book is available or not
        Dim message As String

        'update all textboxs with respective data
        'from currentBook structure
        tbxName.Text = currentBook.name
        tbxAuthor.Text = currentBook.author
        tbxDescription.Text = currentBook.description
        'check if image field in database is not empty
        If currentBook.image <> "..." Then
            'if is not empty get path of image on this computer
            PictureBoxBook.Image = Image.FromFile(currentBook.image)
        Else
            'if field is empty then load default image
            PictureBoxBook.Image = Image.FromFile("C:\Users\de4rm\Desktop\no_image.jpg")
        End If
        'check book status
        If currentBook.bookAvalible = 1 Then
            'if is available then color for label lblIsAvaible will be green
            message = "Available"
            lblIsAvaible.ForeColor = Color.Green
        Else
            'if is available then color for label lblIsAvaible will be red
            message = "Unavailable"
            lblIsAvaible.ForeColor = Color.Red
        End If
        'update with status of the book
        lblIsAvaible.Text = message
    End Sub

    'event for button >>(next)
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'check boundary of list of books
        If Not currentIndex + 1 = TotalBooks Then
            'enables button <<(previous)
            btnPrevious.Enabled = True
            'move current index forward
            currentIndex = currentIndex + 1
            'update current book with a step forward
            currentBook = books(currentIndex)
            'update of data on form
            LoadBook()
            lblCounter.Text = String.Concat(currentIndex + 1) + "/" + String.Concat(TotalBooks)
        Else
            'if is last book disables button next
            btnNext.Enabled = False
        End If
    End Sub

    Private Sub UpdateBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateBookToolStripMenuItem.Click
        Dim update_book As New NewBook()
        update_book.book = currentBook
        update_book.UpdateFlag = True
        update_book.Show()
    End Sub

    'event delete Book from menu Books
    Private Sub DeleteBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteBookToolStripMenuItem.Click
        'create object server
        Dim serv As New Server()

        'delete record from database 
        serv.DeleteBook(currentBook.id)
        'remove book from books list
        books.Remove(currentBook)
        'change totalbooks
        TotalBooks = TotalBooks - 1
        'check if thre is any more books in list
        If TotalBooks > 0 Then
            'check if current index was on last book
            If TotalBooks = currentIndex Then
                'if it was on last book then decrease 
                'current index with one
                currentIndex = currentIndex - 1
            End If
            'update current book
            currentBook = books(currentIndex)
        Else
            'if there is not any more book in list then create a new
            'book for current book
            currentBook = New BookTable()
        End If
        'update data on form
        LoadBook()
        lblCounter.Text = String.Concat(currentIndex) + "/" + String.Concat(TotalBooks)
    End Sub

    'event for menu Books->Change Books Status->Available
    'update field IsAvailable of current book 
    Private Sub AvaibleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvaibleToolStripMenuItem.Click
        update_is_available(1)
    End Sub

    'event for menu Books->Change Books Status->Unavailable
    'update field IsAvailable of current book 
    Private Sub UnavailableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnavailableToolStripMenuItem.Click
        update_is_available(0)
    End Sub

    'event for menu Books->List->Available Books
    'show all available books in a new Form
    Private Sub AvaibleBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvaibleBooksToolStripMenuItem.Click
        showList(TypeShow.Available)
    End Sub

    'event for menu Books->List->Unavailable Books
    'show all unavailable books in a new Form
    Private Sub BooksInProcessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BooksInProcessToolStripMenuItem.Click
        showList(TypeShow.Unavailable)
    End Sub

    'event for menu Books->List->Show all Books
    'show all books in a new Form
    Private Sub ShowAllBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAllBooksToolStripMenuItem.Click
        showList(TypeShow.All)
    End Sub

    'general procedure that help with
    'opening a new listForm with showType parameter
    Private Sub showList(showType As TypeShow)
        'create a form FormLists
        Dim listForm As New FormLists()
        'add value to variable showtype in form FormLists
        listForm.showType = showType
        'open form
        listForm.Show()
    End Sub

End Class

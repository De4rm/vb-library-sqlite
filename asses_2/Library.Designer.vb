<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Library
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Library))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.PictureBoxBook = New System.Windows.Forms.PictureBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.tbxAuthor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvaibleBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksInProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowAllBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeBookStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvaibleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnavailableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.lblIsAvaible = New System.Windows.Forms.Label()
        CType(Me.PictureBoxBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'tbxName
        '
        Me.tbxName.Location = New System.Drawing.Point(79, 31)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(162, 20)
        Me.tbxName.TabIndex = 1
        '
        'PictureBoxBook
        '
        Me.PictureBoxBook.Image = CType(resources.GetObject("PictureBoxBook.Image"), System.Drawing.Image)
        Me.PictureBoxBook.Location = New System.Drawing.Point(263, 31)
        Me.PictureBoxBook.Name = "PictureBoxBook"
        Me.PictureBoxBook.Size = New System.Drawing.Size(186, 209)
        Me.PictureBoxBook.TabIndex = 2
        Me.PictureBoxBook.TabStop = False
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(60, 274)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(40, 23)
        Me.btnPrevious.TabIndex = 3
        Me.btnPrevious.Text = "<<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'tbxAuthor
        '
        Me.tbxAuthor.Location = New System.Drawing.Point(79, 70)
        Me.tbxAuthor.Name = "tbxAuthor"
        Me.tbxAuthor.Size = New System.Drawing.Size(162, 20)
        Me.tbxAuthor.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Author"
        '
        'tbxDescription
        '
        Me.tbxDescription.Location = New System.Drawing.Point(79, 109)
        Me.tbxDescription.Multiline = True
        Me.tbxDescription.Name = "tbxDescription"
        Me.tbxDescription.Size = New System.Drawing.Size(162, 113)
        Me.tbxDescription.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Description"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(475, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewBookToolStripMenuItem, Me.ListToolStripMenuItem, Me.DeleteBookToolStripMenuItem, Me.UpdateBookToolStripMenuItem, Me.ChangeBookStatusToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.FileToolStripMenuItem.Text = "Books"
        '
        'NewBookToolStripMenuItem
        '
        Me.NewBookToolStripMenuItem.Name = "NewBookToolStripMenuItem"
        Me.NewBookToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewBookToolStripMenuItem.Text = "New Book"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AvaibleBooksToolStripMenuItem, Me.BooksInProcessToolStripMenuItem, Me.ShowAllBooksToolStripMenuItem})
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'AvaibleBooksToolStripMenuItem
        '
        Me.AvaibleBooksToolStripMenuItem.Name = "AvaibleBooksToolStripMenuItem"
        Me.AvaibleBooksToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AvaibleBooksToolStripMenuItem.Text = "Available Books"
        '
        'BooksInProcessToolStripMenuItem
        '
        Me.BooksInProcessToolStripMenuItem.Name = "BooksInProcessToolStripMenuItem"
        Me.BooksInProcessToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BooksInProcessToolStripMenuItem.Text = "Unavailable books"
        '
        'ShowAllBooksToolStripMenuItem
        '
        Me.ShowAllBooksToolStripMenuItem.Name = "ShowAllBooksToolStripMenuItem"
        Me.ShowAllBooksToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ShowAllBooksToolStripMenuItem.Text = "Show all books"
        '
        'DeleteBookToolStripMenuItem
        '
        Me.DeleteBookToolStripMenuItem.Name = "DeleteBookToolStripMenuItem"
        Me.DeleteBookToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteBookToolStripMenuItem.Text = "Delete Book"
        '
        'UpdateBookToolStripMenuItem
        '
        Me.UpdateBookToolStripMenuItem.Name = "UpdateBookToolStripMenuItem"
        Me.UpdateBookToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UpdateBookToolStripMenuItem.Text = "Update Book"
        '
        'ChangeBookStatusToolStripMenuItem
        '
        Me.ChangeBookStatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AvaibleToolStripMenuItem, Me.UnavailableToolStripMenuItem})
        Me.ChangeBookStatusToolStripMenuItem.Name = "ChangeBookStatusToolStripMenuItem"
        Me.ChangeBookStatusToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ChangeBookStatusToolStripMenuItem.Text = "Change Book Status"
        '
        'AvaibleToolStripMenuItem
        '
        Me.AvaibleToolStripMenuItem.Name = "AvaibleToolStripMenuItem"
        Me.AvaibleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AvaibleToolStripMenuItem.Text = "Available"
        '
        'UnavailableToolStripMenuItem
        '
        Me.UnavailableToolStripMenuItem.Name = "UnavailableToolStripMenuItem"
        Me.UnavailableToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UnavailableToolStripMenuItem.Text = "Unavailable"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(199, 274)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(40, 23)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Location = New System.Drawing.Point(130, 279)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(39, 13)
        Me.lblCounter.TabIndex = 10
        Me.lblCounter.Text = "Label4"
        '
        'lblIsAvaible
        '
        Me.lblIsAvaible.AutoSize = True
        Me.lblIsAvaible.ForeColor = System.Drawing.Color.Red
        Me.lblIsAvaible.Location = New System.Drawing.Point(79, 229)
        Me.lblIsAvaible.Name = "lblIsAvaible"
        Me.lblIsAvaible.Size = New System.Drawing.Size(39, 13)
        Me.lblIsAvaible.TabIndex = 11
        Me.lblIsAvaible.Text = "Label5"
        '
        'Library
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 318)
        Me.Controls.Add(Me.lblIsAvaible)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.tbxDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxAuthor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.PictureBoxBook)
        Me.Controls.Add(Me.tbxName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Library"
        Me.Text = "Library"
        CType(Me.PictureBoxBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbxName As TextBox
    Friend WithEvents PictureBoxBook As PictureBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents tbxAuthor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnNext As Button
    Friend WithEvents lblCounter As Label
    Friend WithEvents ListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvaibleBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BooksInProcessToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblIsAvaible As Label
    Friend WithEvents DeleteBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeBookStatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvaibleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnavailableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowAllBooksToolStripMenuItem As ToolStripMenuItem
End Class

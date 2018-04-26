<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewBook
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
        Me.tbxDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxAuthor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbxDescription
        '
        Me.tbxDescription.Location = New System.Drawing.Point(94, 113)
        Me.tbxDescription.Multiline = True
        Me.tbxDescription.Name = "tbxDescription"
        Me.tbxDescription.Size = New System.Drawing.Size(162, 113)
        Me.tbxDescription.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Description"
        '
        'tbxAuthor
        '
        Me.tbxAuthor.Location = New System.Drawing.Point(94, 74)
        Me.tbxAuthor.Name = "tbxAuthor"
        Me.tbxAuthor.Size = New System.Drawing.Size(162, 20)
        Me.tbxAuthor.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Author"
        '
        'tbxName
        '
        Me.tbxName.Location = New System.Drawing.Point(94, 35)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(162, 20)
        Me.tbxName.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(31, 310)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(31, 248)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 15
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(112, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "..."
        '
        'NewBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 356)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.tbxDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxAuthor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewBook"
        Me.Text = "NewBook"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxAuthor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label4 As Label
End Class

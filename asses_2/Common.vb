'its a module that contain objects that are used 
'everywhere for development of this library
Public Module Common

    'TypeShow its an enum that are used on filter 
    'of data on listing 
    Public Enum TypeShow
        Available
        Unavailable
        All
    End Enum

    'because database have a lot of columns and 
    'in proccess of development we can add some
    'it was decided to create a structure that will
    'simplify transfer from form to class Server
    'that is responsable for every manipulation with 
    'data in database
    Public Structure BookTable
        Public id As Integer
        Public name As String
        Public author As String
        Public description As String
        Public bookAvalible As Short
        Public image As String
    End Structure


End Module

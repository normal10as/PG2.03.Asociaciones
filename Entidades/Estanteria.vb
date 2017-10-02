Public Class Estanteria
    Private _id As String
    Private _libros As List(Of Libro)

    Sub New()
        _libros = New List(Of Libro)
    End Sub

    Public Property id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    ' responsable de la bidireccionalidad asigan al libro a si misma
    Public Sub addLibro(libro As Libro)
        If _libros.Count < 5 Then
            ' si el libro esta en otra estantería se la quita de ahi
            If libro.estanteria IsNot Nothing Then
                Dim otraEstanteria = libro.estanteria
                otraEstanteria.removeLibro(libro)
            End If
            libro.estanteria = Me
            _libros.Add(libro)
        End If
    End Sub

    ' el libro al ser quitado queda en nada
    Public Sub removeLibro(libro As Libro)
        libro.estanteria = Nothing
        _libros.Remove(libro)
    End Sub

    Public Function getAllLibros() As List(Of Libro)
        Return _libros
    End Function

    Public Overrides Function ToString() As String
        Return id
    End Function
End Class

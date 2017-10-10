Public Class Libro
    Private _nombre As String
    Private _estanteria As Estanteria

    Public Sub New()
        _estanteria = Nothing
    End Sub

    Public Sub New(nombre As String, estanteria As Estanteria)
        Me.nombre = nombre
        ' asociación bidireccional
        estanteria.addLibro(Me)
    End Sub

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property estanteria As Estanteria
        Get
            Return _estanteria
        End Get
        'setter unicamente accesible en el paquete
        'responsables: estanteria
        Friend Set(value As Estanteria)
            _estanteria = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return nombre & " (" & estanteria.ToString & ")"
    End Function
End Class

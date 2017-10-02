Public Class Hombre
    Private _nombre As String
    Private _esposa As Mujer

    Sub New(nombre As String)
        Me.nombre = nombre
    End Sub

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public ReadOnly Property esposa As Mujer
        Get
            Return _esposa
        End Get
    End Property

    ' solo permite esposar si no tiene actualmente esposa
    Friend Function Esposar(value As Mujer) As Boolean
        If _esposa Is Nothing Then
            _esposa = value
            Return True
        End If
        Return False
    End Function

    Public Overrides Function ToString() As String
        Return _nombre & If(esposa Is Nothing, " (soltero)", " casado con " & esposa.nombre)
    End Function
End Class

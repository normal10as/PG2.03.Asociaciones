Public Class Mujer
    Private _nombre As String
    Private _esposo As Hombre

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

    Public ReadOnly Property esposo As Hombre
        Get
            Return _esposo
        End Get
    End Property

    ' solo permite esposar si no tiene actualmente esposo
    Public Sub Esposar(esposo As Hombre)
        If _esposo Is Nothing Then
            If esposo.Esposar(Me) Then
                _esposo = esposo
            End If
        End If
    End Sub

    Public Overrides Function ToString() As String
        Return _nombre & If(esposo Is Nothing, " (soltera)", " casada con " & esposo.nombre)
    End Function
End Class

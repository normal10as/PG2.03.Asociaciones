Imports Entidades

Module simple_multiple
    Sub main()
        Dim estante1 As New Estanteria()
        estante1.id = "E56"

        Dim libro1 As New Libro()
        libro1.nombre = "Paint for dummies"
        'libro1.estanteria = estante1
        estante1.addLibro(libro1)
        mostrarEstante(estante1)
        Console.ReadKey()
        Dim libro2 As New Libro("Paint experto", estante1)

        mostrarEstante(estante1)

        Dim estante2 As New Estanteria()
        estante2.id = "X9"
        Console.WriteLine("Estantería: " & estante2.ToString())

        estante2.addLibro(libro2)
        mostrarEstante(estante1)
        mostrarEstante(estante2)
    End Sub

    Private Sub mostrarEstante(estante As Estanteria)
        Console.WriteLine("Estantería: " & estante.ToString())
        For Each libro As Libro In estante.getAllLibros()
            Console.WriteLine(libro)
        Next
    End Sub
End Module

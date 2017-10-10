Imports Entidades

Module simple_simple

    Sub Main()
        Dim maria As New Mujer("Maria")
        Dim juan As New Hombre("Juan")
        Console.WriteLine(maria)
        Console.WriteLine(juan)
        maria.Esposar(juan)
        Console.WriteLine(maria)
        Console.WriteLine(juan)
        Console.ReadKey()
        Dim nina As New Mujer("Nina")
        Dim pedro As New Hombre("Pedro")
        Console.WriteLine(nina)
        Console.WriteLine(pedro)
        nina.Esposar(juan)
        'pedro.Esposar(maria)
        Console.WriteLine(maria)
        Console.WriteLine(juan)
        Console.WriteLine(nina)
        Console.WriteLine(pedro)
        maria.Esposar(pedro)
        'nina.Esposar(pedro)
        'pedro.Esposar(maria)
        Console.WriteLine(maria)
        Console.WriteLine(juan)
        Console.WriteLine(nina)
        Console.WriteLine(pedro)
    End Sub

End Module

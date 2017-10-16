Option Strict On
Module Module1

    Sub Main()
        Dim presion, temperatura As Double

        Console.WriteLine("La preasion es:")
        presion = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("La temperatura es:")
        temperatura = Convert.ToDouble(Console.ReadLine())

        If presion > 2 Then
            Console.WriteLine("Abrir la válvula de seguridad")
        End If

        If temperatura > 500 Then
            Console.WriteLine("Reducir la temperatura")
        End If

        If presion <= 2 And temperatura <= 500 Then
            Console.WriteLine("Todo en orden")
        End If

        Console.ReadLine()
    End Sub

End Module

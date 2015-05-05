Module Module1
    Dim Bob As String
    Sub Main()
        Bob = Console.ReadLine
        If Bob = Bob Then
            Console.WriteLine("You Win! BOB!")
            Console.ReadKey()
        Else
            Console.WriteLine("YOU LOSE! YOU GET NOTHING! GOOD DAY SIR!")
            Console.ReadKey()
        End If
    End Sub

End Module

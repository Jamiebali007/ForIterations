Module Module1
    Dim Index As Integer
    Sub Main()
        For Index = 1 To 20
            If Index = 17 Then
                Console.WriteLine("Found Seventeen")
            End If
            Console.WriteLine(Index)
        Next
        Console.ReadKey()
    End Sub

End Module

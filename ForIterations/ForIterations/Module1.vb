Module Module1
    Dim Index As Integer
    Sub Main()
        For Index = 1 To 10
            If Index = 7 Then
                Console.WriteLine("Found Seven")
            End If
            Console.WriteLine(Index)
        Next
        Console.ReadKey()
    End Sub

End Module

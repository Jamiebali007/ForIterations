Module Module1
    Dim Choice As String
    Sub Main()
        Choice = Console.ReadLine
        Select Case Choice
            Case "Yes"
                Console.WriteLine("Yes")
                Console.ReadKey()
            Case "No"
                Console.WriteLine("No")
                Console.ReadKey()
            Case Else
                Console.WriteLine("Unknown")
        End Select
        Choice = ("")
        Choice = Console.ReadLine
        Select Case Choice
            Case "Yes"
                Console.WriteLine(Choice)
                Console.ReadKey()
            Case "Neo"
                Console.WriteLine(Choice)
                Console.ReadKey()
            Case Else
                Console.WriteLine(Choice)
        End Select
        Console.ReadKey()
    End Sub
End Module

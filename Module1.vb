Module Module1

    Sub Main()
        Dim String1, String2 As String
        Dim charToRemove, CurrentChar As Char
        Dim Counter As Integer

        String1 = ""
        String2 = ""
        charToRemove = ""
        CurrentChar = ""
        Counter = 0

        Console.Write("Enter character to be removed: ")
        charToRemove = Console.ReadLine

        Console.Write("Enter String to be clean: ")
        String1 = Console.ReadLine

        For Counter = 1 To Len(String1)
            CurrentChar = Mid(String1, Counter, 1)
            If CurrentChar <> charToRemove Then
                String2 = String2 & CurrentChar
            End If
        Next

        Console.Write("Final string = " & String2)
        Console.ReadKey()
    End Sub

End Module

Module Module1

    Sub Main()
        Dim Str1, Str2, Str3, char1, char2 As String
        Dim Count1, Count2 As Integer

        Str1 = ""
        Str2 = ""
        Str3 = ""
        char1 = ""
        char2 = ""
        Count1 = 0
        Count2 = 0

        Console.Write("Enter the first string: ")
        Str1 = Console.ReadLine
        Console.Write("Enter the second string: ")
        Str2 = Console.ReadLine

        If Len(Str1) <> Len(Str2) Then
            Console.WriteLine("The 2 strings are not Anagram to each other.")
        Else
            For Count1 = 1 To Len(Str1)
                char1 = UCase(Mid(Str1, Count1, 1))
                Str3 = ""
            
                For Count2 = 1 To Len(Str2)
                    char2 = UCase(Mid(Str2, Count2, 1))
                    If char2 <> char1 Then
                        Str3 = Str3 & char2
                    End If
                Next
                Str2 = Str3
            Next
            If Str2 = "" Then
                Console.WriteLine("The 2 strings are Anagram to Each Other")
            Else
                Console.WriteLine("The 2 strings are not Anagram to Each Other")
            End If
        End If
        Console.ReadKey()

    End Sub

End Module

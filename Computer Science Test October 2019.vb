Module Module1

    Sub Main()
        Dim Str1 As String
        Dim validBinaryString As Boolean
        Dim Worth, Count1, Bit, Value, DenaryValue, Count, AscValue As Integer

        Str1 = ""
        Count = 0
        AscValue = 0
        validBinaryString = True
        Worth = 1
        Count1 = 0
        Bit = 0
        Value = 0
        DenaryValue = 0

        Console.Write("Please enter a binary string: ")
        Str1 = Console.ReadLine

        If Len(Str1) > 8 Or Len(Str1) < 1 Then
            validBinaryString = False
        End If

        If validBinaryString = True Then
            For Count = 1 To Len(Str1)
                AscValue = Asc(Mid(Str1, Count, 1))
                If AscValue = 48 Or AscValue = 49 Then
                    validBinaryString = True
                Else
                    validBinaryString = False
                    Exit For
                End If
            Next
        End If

        If validBinaryString = True Then
            Console.Write("The string is a valid Binary Number.")
        Else
            Console.Write("The string entered is either out of the lenght range or contains non-binary numbers. Please re-enter the string.")
        End If

        If validBinaryString = True Then
            For Count1 = 1 To Len(Str1)
                Bit = Val(Mid(Str1, Len(Str1) - Count1 + 1, 1))
                Value = Bit * Worth
                DenaryValue = DenaryValue + Value
                Worth = Worth * 2
            Next
            Console.Write(" The denary value is: " & DenaryValue)
        End If
        Console.ReadKey()

    End Sub

End Module

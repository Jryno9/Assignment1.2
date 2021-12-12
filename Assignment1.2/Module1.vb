Module Module1

    Sub Main()
        Dim inpstr As String
        Dim inpchar As Char
        Dim i As Integer
        Dim cmpchar As Char
        Dim replchar As Char
        Dim fstring As String
        inpchar = ""
        i = 0
        fstring = ""
        inpstr = ""
        cmpchar = ""
        replchar = ""
        Console.WriteLine("Enter the string: ")
        inpstr = Console.ReadLine()
        Console.WriteLine("Enter the character you want to replace: ")
        inpchar = Console.ReadLine()
        Console.WriteLine("Enter the character you want to replace with:")
        replchar = Console.ReadLine()
        For i = 1 To Len(inpstr)
            cmpchar = Mid(inpstr, i, 1)
            If inpchar <> cmpchar Then
                fstring = fstring + cmpchar
            Else
                fstring = fstring + replchar
            End If


        Next
        Console.WriteLine(fstring)
        Console.ReadKey()

    End Sub

End Module

Module Module1

    Sub Main()
        Dim myArray(9) As Integer

        Dim anotherArray = {1, 2, 3, 4, 5, 6, 7, 8, 9}
        Dim yetAnotherArray = New Integer() {9, 8, 7, 6, 5, 4, 3, 2, 1}

        For i = 0 To myArray.Length - 1
            myArray(i) = i
        Next

    End Sub

End Module

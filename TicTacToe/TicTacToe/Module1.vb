Module Module1

    Dim grid(,) As String = {{"", "A", "B", "C"},
                             {"1", "", "", ""},
                             {"2", "", "", ""},
                             {"3", "", "", ""}}
    Dim playerColumn As Integer
    Dim playerRow As Integer

    Sub Main()
        Dim currentPlayer As Integer
        Dim winner As Boolean = False

        currentPlayer = 1
        While winner = False
            DrawGrid()
            GetLocation()
            If currentPlayer = 1 Then
                grid(playerRow, playerColumn) = "O"
                currentPlayer = 0
            Else
                grid(playerRow, playerColumn) = "X"
                currentPlayer = 1
            End If
        End While



        Console.ReadKey()
    End Sub

    Sub DrawGrid()

        Console.Clear()
        Console.WriteLine("Noughts and Crosses")
        Console.WriteLine("===================")
        Console.WriteLine()
        For row = 0 To 3
            For column = 0 To 3
                Console.Write(grid(row, column).PadLeft(3))
            Next
            Console.WriteLine()
        Next

    End Sub

    Sub GetLocation()
        Dim tempValue As String
        Dim valid As Boolean

        valid = False
        While Not valid
            valid = False
        While Not valid
            Console.Write("Enter the column: ")
            tempValue = Console.ReadLine().ToUpper()
            Select Case tempValue
                Case "A"
                        playerColumn = 1
                        valid = True
                Case "B"
                    playerColumn = 2
                    valid = True
                Case "C"
                    playerColumn = 3
                    valid = True
                Case Else
                    Console.WriteLine("Invalid column")
            End Select
        End While

        valid = False
        While Not valid
            Console.Write("Enter the row: ")
            tempValue = Console.ReadLine()
            Select Case tempValue
                Case "1"
                    playerRow = 1
                    valid = True
                Case "2"
                    playerRow = 2
                    valid = True
                Case "3"
                    playerRow = 3
                    valid = True
                Case Else
                    Console.WriteLine("Invalid column")
            End Select
            End While

            If grid(playerRow, playerColumn) <> "" Then
                valid = False
                Console.WriteLine("The square has already been taken.
Choose another location")
            End If


        End While

    End Sub

End Module

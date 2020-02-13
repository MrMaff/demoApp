Module Module1

    Public Structure ShopItem
        Public ItemCode As String
        Public Category As String
        Public Description As String
        Public Price As Decimal

    End Structure

    Function LoadStock() As Array

        Dim infile As System.IO.StreamReader
        Dim num As Integer = 16
        Dim stock(num) As ShopItem

        infile = My.Computer.FileSystem.OpenTextFileReader("data.txt")

        'Load Stock
        For index = 0 To num - 1
            stock(index).ItemCode = infile.ReadLine()
            stock(index).Category = infile.ReadLine()
            stock(index).Description = infile.ReadLine()
            stock(index).Price = infile.ReadLine()
        Next

        infile.Close()

        Return stock
    End Function

    Sub Title()

        Console.Clear()
        Console.WriteLine("╔══════════════════╗".PadLeft(37))
        Console.WriteLine("║ Mr Long's Phones ║".PadLeft(37))
        Console.WriteLine("╚══════════════════╝".PadLeft(37))
        Console.WriteLine()

    End Sub

    Sub DisplayCat(stock() As ShopItem, category As String)
        For index = 0 To stock.Length - 1
            If stock(index).Category = category Then
                Console.WriteLine(stock(index).Category.PadRight(10) & stock(index).ItemCode.PadRight(6) & stock(index).Description.PadRight(30) & stock(index).Price.ToString().PadLeft(8))
            End If
        Next
    End Sub

    Function GetValidStockItem(stock() As ShopItem, category As String, code As String) As ShopItem
        Dim requestedItem As ShopItem?

        For index = 0 To stock.Length - 1
            If stock(index).Category = category And code = stock(index).ItemCode Then
                requestedItem = stock(index)
            End If
        Next

        Return requestedItem
    End Function

    Function GetItem(stock() As ShopItem, category As String)
        Dim tempItem As ShopItem?

        DisplayCat(stock, category)
        Console.Write("Enter Item code: ")
        tempItem = GetValidStockItem(stock, category, Console.ReadLine())
        While tempItem Is Nothing
            Console.WriteLine("Invalid code.")
            Console.Write("Enter Item code: ")
            tempItem = GetValidStockItem(stock, category, Console.ReadLine())

            Return tempItem
        End While
    End Function
    Sub Main()

        Dim stock() As ShopItem = LoadStock()
        Dim order(6) As ShopItem
        Dim choice As Integer

        Title()

        'Get Device
        Console.WriteLine("Devices for Sale!")
        DisplayCat(stock, "Phone")
        DisplayCat(stock, "Tablet")

        Console.WriteLine("Would you like:")
        Console.WriteLine("1. Phone")
        Console.WriteLine("2. Tablet")
        Integer.TryParse(Console.ReadLine(), choice)
        Select Case choice
            Case 1
                order(0) = GetItem(stock, "Phone")
                order(1) = GetItem(stock, "SIM")
            Case 2
                order(0) = GetItem(stock, "Tablet")
            Case Else
                Console.WriteLine("Invalid Choice please choose again")
        End Select




    End Sub

End Module

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

    Function GetValidStockItem(stock() As ShopItem, category As String, code As String) As ShopItem?
        Dim requestedItem As ShopItem? = Nothing

        For index = 0 To stock.Length - 1
            If stock(index).Category = category And code = stock(index).ItemCode Then
                requestedItem = stock(index)
            End If
        Next

        Return requestedItem
    End Function

    Function GetItem(stock() As ShopItem, category As String) As ShopItem?
        Dim tempItem As ShopItem? = Nothing

        DisplayCat(stock, category)
        Console.Write("Enter Item code: ")
        tempItem = GetValidStockItem(stock, category, Console.ReadLine().ToUpper())
        While tempItem Is Nothing
            Console.WriteLine("Invalid code.")
            Console.Write("Enter Item code: ")
            tempItem = GetValidStockItem(stock, category, Console.ReadLine().ToUpper())
        End While
        Return tempItem
    End Function

    Sub DisplayOrder(order() As ShopItem)
        For index = 0 To order.Length - 1
            If order(index).Category <> "" Then
                Console.WriteLine(order(index).Category.PadRight(10) & order(index).ItemCode.PadRight(6) & order(index).Description.PadRight(30) & order(index).Price.ToString().PadLeft(8))
            End If
        Next
    End Sub

    Function CalculateTotal(order() As ShopItem) As Decimal
        Dim total As Decimal = 0

        For index = 0 To order.Length - 1
            total = total + order(index).Price

        Next
        Return total

    End Function
    Sub Main()

        Dim stock() As ShopItem = LoadStock()
        Dim order(6) As ShopItem
        Dim total As Decimal
        Dim orderNum As Integer = 0
        Dim choice As Integer
        Dim validChoice As Boolean

        Title()

        'Get Device
        Console.WriteLine("Devices for Sale!")
        DisplayCat(stock, "Phone")
        DisplayCat(stock, "Tablet")

        Console.WriteLine("Would you like:")
        Console.WriteLine("1. Phone")
        Console.WriteLine("2. Tablet")
        Do
            validChoice = True
            Integer.TryParse(Console.ReadLine(), choice)
            Select Case choice
                Case 1
                    Title()
                    order(orderNum) = GetItem(stock, "Phone")
                    orderNum = orderNum + 1
                    order(orderNum) = GetItem(stock, "SIM card")
                    orderNum = orderNum + 1
                Case 2
                    Title()
                    order(0) = GetItem(stock, "Tablet")
                    orderNum = orderNum + 1
                Case Else
                    Console.WriteLine("Invalid Choice please choose again")
                    validChoice = False
            End Select
        Loop Until validChoice = True

        Title()
        order(orderNum) = GetItem(stock, "Case")
        orderNum = orderNum + 1

        Console.WriteLine("Would you like:")
        Console.WriteLine("1. No Chargers")
        Console.WriteLine("2. One Charger")
        Console.WriteLine("3. Two Chargers")

        Do
            validChoice = True
            Integer.TryParse(Console.ReadLine(), choice)
            Select Case choice
                Case 1
                    Console.WriteLine("You have chosen not to order a charger.")
                Case 2
                    order(orderNum) = GetItem(stock, "Charger")
                    orderNum = orderNum + 1
                Case 3
                    order(orderNum) = GetItem(stock, "Charger")
                    orderNum = orderNum + 1
                    order(orderNum) = GetItem(stock, "Charger")
                    orderNum = orderNum + 1
                Case Else
                    Console.WriteLine("Invalid Choice please choose again")
                    validChoice = False
            End Select
        Loop Until validChoice = True

        Title()

        DisplayOrder(order)
        Console.WriteLine()
        total = CalculateTotal(order)
        Console.WriteLine("The total price is £{0}", total)
        Console.ReadKey()

    End Sub

End Module

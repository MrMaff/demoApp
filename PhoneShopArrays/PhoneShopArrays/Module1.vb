Module Module1

    Sub Main()
        'Task 1
        'Store data in appropriate structures
        Dim category() As String = {"Phone", "Phone", "Phone", "Phone", "Phone", "Phone", "Tablet", "Tablet", "Tablet", "Tablet", "SIM card", "SIM card", "Case", "Case", "Charger", "Charger"}
        Dim itemCode() As String = {"BPCM", "BPSH", "RPSS", "RPLL", "YPLS", "YPLL", "RTMS", "RTLM", "YTLM", "YTLL", "SMNO", "SMPG", "CSST", "CSLX", "CGCR", "CGHM"}
        Dim description() As String = {
            "Compact",
            "Clam Shell",
            "RoboPhone - 5 inch, 64GB ",
            "RoboPhone - 6 inch, 256GB",
            "Y-Phone Standard",
            "Y-Phone Deluxe",
            "RoboTab - 8 inch, 64GB",
            "RoboTab - 10 inch, 128GB",
            "Y-Tab Standard",
            "Y-Tab Deluxe",
            "SIM Free",
            "Pay As You Go",
            "Standard",
            "Luxury",
            "Car",
            "Home"
        }
        Dim price() As Decimal = {29.99, 49.99, 199.99, 499.99, 549.99, 649.99, 149.99, 299.99, 499.99, 599.99, 0, 9.99, 0, 50, 19.99, 15.99}

        'Array to store Order
        Dim tempChoice As String
        Dim validCode As Boolean
        Dim phone As Boolean = False
        Dim order(4) As String
        Dim numOfChargers As Integer

        'Variables for Calculated values
        Dim totalPrice As Decimal

        Title()
        'Display Phones & Tablets
        For index = 0 To itemCode.Length - 1
            If category(index) = "Phone" Or category(index) = "Tablet" Then
                Console.WriteLine(category(index).PadRight(10) & itemCode(index).PadRight(6) & description(index).PadRight(30) & price(index).ToString().PadLeft(8))
            End If
        Next
        Console.WriteLine()

        'Get Cusomer Choice (and validate)
        Do
            Console.Write("Enter the ItemCode of the device: ")
            tempChoice = Console.ReadLine().ToUpper()
            validCode = False
            For index = 0 To itemCode.Length - 1
                If (category(index) = "Phone" Or category(index) = "Tablet") And tempChoice = itemCode(index) Then
                    validCode = True
                    If category(index) = "Phone" Then phone = True
                    totalPrice = totalPrice + price(index)
                End If
            Next
            If validCode = False Then
                Console.Beep()
                Console.WriteLine("Invalid Item Code")
            End If
        Loop Until validCode = True

        Title()
        'If Phone, display SIM Cards
        If phone Then
            For index = 0 To itemCode.Length - 1
                If category(index) = "SIM card" Then
                    Console.WriteLine(category(index).PadRight(10) & itemCode(index).PadRight(6) & description(index).PadRight(30) & price(index).ToString().PadLeft(8))
                End If
            Next
            Console.WriteLine()

            '.....Get Customer SIM choice
            Do
                Console.Write("Enter the ItemCode of the SIM card: ")
                tempChoice = Console.ReadLine().ToUpper()
                validCode = False
                For index = 0 To itemCode.Length - 1
                    If category(index) = "SIM card" And tempChoice = itemCode(index) Then
                        validCode = True
                        totalPrice = totalPrice + price(index)
                    End If
                Next
                If validCode = False Then
                    Console.Beep()
                    Console.WriteLine("Invalid Item Code")
                End If
            Loop Until validCode = True
        End If

        'Display Case choice
        For index = 0 To itemCode.Length - 1
            If category(index) = "Case" Then
                Console.WriteLine(category(index).PadRight(10) & itemCode(index).PadRight(6) & description(index).PadRight(30) & price(index).ToString().PadLeft(8))
            End If
        Next
        Console.WriteLine()
        'Get customer case choice
        Do
            Console.Write("Enter the ItemCode of the device: ")
            tempChoice = Console.ReadLine().ToUpper()
            validCode = False
            For index = 0 To itemCode.Length - 1
                If category(index) = "Case" And tempChoice = itemCode(index) Then
                    validCode = True
                    totalPrice = totalPrice + price(index)
                End If
            Next
            If validCode = False Then
                Console.Beep()
                Console.WriteLine("Invalid Item Code")
            End If
        Loop Until validCode = True
        'Display Charger Choice
        For index = 0 To itemCode.Length - 1
            If category(index) = "Charger" Then
                Console.WriteLine(category(index).PadRight(10) & itemCode(index).PadRight(6) & description(index).PadRight(30) & price(index).ToString().PadLeft(8))
            End If
        Next
        Console.WriteLine()
        'get customer charger choice

        Console.WriteLine("How many Charges would you like?")
        While Integer.TryParse(Console.ReadLine(), numOfChargers) = False Or numOfChargers > 5
            Console.WriteLine("Enter a number between 0 and 5")
        End While
        For charger = 1 To numOfChargers
            Do
                Console.Write("Enter the ItemCode of the device: ")
                tempChoice = Console.ReadLine().ToUpper()
                validCode = False
                For index = 0 To itemCode.Length - 1
                    If category(index) = "Charger" And tempChoice = itemCode(index) Then
                        validCode = True
                        totalPrice = totalPrice + price(index)
                    End If
                Next
                If validCode = False Then
                    Console.Beep()
                    Console.WriteLine("Invalid Item Code")
                End If
            Loop Until validCode = True
        Next

        'Calculate total price
        'Display customer order
        Title()
        For index = 0 To 10

        Next

        Console.ReadKey()

    End Sub

    Sub Title()

        Console.Clear()
        Console.WriteLine("╔══════════════════╗".PadLeft(37))
        Console.WriteLine("║ Mr Long's Phones ║".PadLeft(37))
        Console.WriteLine("╚══════════════════╝".PadLeft(37))
        Console.WriteLine()

    End Sub


End Module

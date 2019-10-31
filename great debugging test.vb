        ''''End legitimate program begin testing section



        ''''REMOVE BEFORE PUBLISHING
        '''
        '''Research on printing a hidden form https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.printpreviewcontrol?view=netframework-4.8
        For Each pair In dctYachtSizePrice
            Console.WriteLine("{0}, {1}", pair.Key, pair.Value)
        Next


        Try
            Console.WriteLine("For key = ""tif"", value = {0}.",
                dctYachtSizePrice("tif"))
        Catch
            Console.WriteLine("______________________________")
            Console.WriteLine("Key = ""tif"" is not found.")
            Console.WriteLine("______________________________")
        End Try

        Try
            Console.WriteLine("For key = ""22"", value = {0}.",
                dctYachtSizePrice("22"))
        Catch
            Console.WriteLine("Key = ""22"" is not found.")
        End Try


        Dim value As String = ""
        If dctYachtSizePrice.TryGetValue("45", value) Then
            Console.WriteLine("For key = ""45"", value = {0}.", value)
        Else
            Console.WriteLine("Key = ""45"" is not found.")
        End If

        Dim TestPrice As Decimal = GetRentalPrice("38", 4)
        Console.WriteLine("The fabulous low price of: {0:N2}", TestPrice)

        ''''REMOVE BEFORE PUBLISHING
        '''

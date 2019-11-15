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
        Dim strLookup As String = "General"
        For Each label In Me.Controls.OfType(Of Label).Where(Function(x) x.Name.Contains(strLookup))  'lambda expressions, which I only kinda sorta understand  
            If label.Visible = False Then
                label.Visible = True
            End If
        Next
        ''this weird shit with lambda expressions here didn't quite work


        ''this did though
    Public Shared Sub CheckLabels(Container As Control, Value As String, ByRef blCurrentState As Boolean, ByRef blDesiredState As Boolean)
        'This sub checks Controls to see if they contain a specific string in their assigned name
        'Then if switches their visibility if their visibility is in an undesired state. 
        'For example if the visibility is set to True and the desired state is False, it will flip.
        'If the visibility is set to false and the desired state false it will do nothing!
        'Recursively checks child elements as well.
        'ATTENTION PROFESSOR THOMAS, I DO NOT KNOW HOW I FIGURED THIS OUT  AND I CANNOT RECREATE MY THOUGHT PROCESS BUT IT WORKS, WHY?
        For Each C As Control In Container.Controls
            If TypeOf C Is Label AndAlso CType(C, Label).Name.Contains(Value) Then
                If C.Visible = blCurrentState Then
                    C.Visible = blDesiredState
                End If
            ElseIf C.HasChildren Then
                CheckLabels(C, Value, blCurrentState, blDesiredState)
            End If

            If TypeOf C Is TextBox AndAlso CType(C, TextBox).Name.Contains(Value) Then
                If C.Visible = blCurrentState Then
                    C.Visible = blDesiredState
                ElseIf C.HasChildren Then
                    CheckLabels(C, Value, blCurrentState, blDesiredState)
                End If
            End If
        Next
    End Sub
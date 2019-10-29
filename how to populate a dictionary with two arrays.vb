'Populate a dictionary with two arrays

    Dim pair As KeyValuePair(Of String, String)
        Dim array1() As String = {"A", "B"}
        Dim array2() As String = {"a", "b"}
        Dim Dict As New Dictionary(Of String, String)
        For i = 0 To array1.Count() - 1
            Dict.Add(array1(i), array2(i))
        Next
        For Each pair In Dict
            Console.WriteLine("{0}, {1}", pair.Key, pair.Value)
        Next
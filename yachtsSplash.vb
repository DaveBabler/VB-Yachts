Public NotInheritable Class yachtsSplash

    Public Shared strYachtFromStream(0) As String
    Public ReadOnly _strFolderPath = Environment.CurrentDirectory()

    Public ReadOnly _strFileIn As String = _strFolderPath & "\Text\Yachts.txt"
    Public ReadOnly _strSaveFileOut As String = _strFolderPath & "\Text\YachtLog.txt"

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).
    ' https://stackoverflow.com/questions/34881859/mystring-or-as-string


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Console.WriteLine("Here is the path " & _strFolderPath.ToString())
        Console.WriteLine("Here is the other path " & _strFileIn.ToString())
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright & vbCrLf & " Author: " & My.Application.Info.CompanyName
        ReadTextFileIntoArray(_strFileIn, strYachtFromStream)
        ReportBuilding.StrOfStrDicPopulateKeys(ReportBuilding.dicOutputReport, ReportBuilding.strOfReportKeys, True)
        For Each pair In ReportBuilding.dicOutputReport
            Console.WriteLine("{0}, {1}", pair.Key, pair.Value)
        Next

    End Sub

    '  http://vbcity.com/blogs/xtab/archive/2011/11/28/how-to-read-text-file-content-into-a-list-of-string.aspx





    Private Sub ReadTextFileIntoArray(ByVal strFileToRead As String, ByRef strArray As String())
        'Note apparently you cannot directly read a text file into a Listof object!  ATTENTION LISA THOMAS  IF THIS IS INACCURATE PLEASE EMAIL ME!!!
        ' I was forced to do it as an array first!
        Dim objReader As IO.StreamReader
        Dim intCount As Integer = 0
        If IO.File.Exists(strFileToRead) = True Then
            Dim strTextFileLength As String = IO.File.ReadAllText(strFileToRead)
            If strTextFileLength.Length = 0 Then
                MsgBox("Sorry but C:\Yachts.txt does currently contain data." & vbNewLine & "Make data exist in the file, then try again.", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "File not found")
            Else
                objReader = IO.File.OpenText(strFileToRead)

                Do While objReader.Peek <> -1
                    strArray(intCount) = objReader.ReadLine()
                    If strArray(intCount) Is Nothing Then
                        Console.WriteLine("We are in nothing ")
                    Else
                        intCount += 1
                        'intCount -= 1

                        'ReDim Preserve strArray(intCount)
                    End If
                    ReDim Preserve strArray(intCount)
                Loop
                objReader.Close()
                'The array seems to pickup a Nothing Value no matter what logic I use. 
                ReDim Preserve strArray(intCount - 1)
            End If
        Else
            MsgBox("Sorry but C:\Yachts.txt does not currently exist." & vbNewLine & "Make the file exist then reload program", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "File not found")


        End If

    End Sub

End Class

Public NotInheritable Class yachtsSplash

    Public Shared strYachtFromStream(0) As String
    Public ReadOnly _strFolderPath = Environment.CurrentDirectory()

    Public ReadOnly _strFileIn As String = _strFolderPath & "\Text\Yachts.txt"
    Public ReadOnly _strSaveFileOut As String = _strFolderPath & "\Text\YachtLog.txt"

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).
    ' https://stackoverflow.com/questions/34881859/mystring-or-as-string


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Console.WriteLine("Here is the path " & _strFolderPath.ToString())
        'Console.WriteLine("Here is the other path " & _strFileIn.ToString())
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
        ReportBuilding.ReadTextFileIntoObject(_strFileIn, strYachtFromStream)
        ReportBuilding.StrOfStrDicPopulateKeys(ReportBuilding.dicOutputReport, ReportBuilding.strOfReportKeys, True)
        'For Each pair In ReportBuilding.dicOutputReport
        '    Console.WriteLine("{0}, {1}", pair.Key, pair.Value)
        'Next

    End Sub

    '  http://vbcity.com/blogs/xtab/archive/2011/11/28/how-to-read-text-file-content-into-a-list-of-string.aspx





End Class

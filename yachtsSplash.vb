﻿Public NotInheritable Class yachtsSplash
    Public Shared lstYachtTypesFromStream As New List(Of String)
    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        ReadTextFileIntoList(lstYachtTypesFromStream)
        For Each strValue In lstYachtTypesFromStream
            Console.WriteLine("We have this yacht {0}", lstYachtTypesFromStream)
        Next


    End Sub
    '  http://vbcity.com/blogs/xtab/archive/2011/11/28/how-to-read-text-file-content-into-a-list-of-string.aspx

    Private Sub ReadTextFileIntoList(ByRef lstToPopulate As List(Of String))
        Dim objReader As IO.StreamReader
        If IO.File.Exists("c:\Yachts.txt") = True Then
            objReader = IO.File.OpenText("c:\Yachts.txt")
            Do While objReader.Peek <> -1
                lstToPopulate.Add(objReader.ReadLine().ToString())
            Loop
        Else
            MsgBox("Sorry but C:\Yachts.txt does not currently exist." & vbNewLine & "Make the file exist then reload program", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "File not found")
        End If
    End Sub


End Class

'=========================================================================='
'                                                                          '
'                    (C) Copyright 2018 Devil7 Softwares.                  '
'                                                                          '
' Licensed under the Apache License, Version 2.0 (the "License");          '
' you may not use this file except in compliance with the License.         '
' You may obtain a copy of the License at                                  '
'                                                                          '
'                http://www.apache.org/licenses/LICENSE-2.0                '
'                                                                          '
' Unless required by applicable law or agreed to in writing, software      '
' distributed under the License is distributed on an "AS IS" BASIS,        '
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. '
' See the License for the specific language governing permissions and      '
' limitations under the License.                                           '
'                                                                          '
' Contributors :                                                           '
'     Dineshkumar T                                                        '
'=========================================================================='

Public Class DatabaseIO

#Region "Variables"
    Private Shared DatabasePath As String = ""
#End Region

#Region "Database"
    Public Shared Sub CreateDB()
        DatabasePath = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "data_" & (New Random).Next(1000, 9999) & ".db")
        My.Computer.FileSystem.WriteAllBytes(DatabasePath, My.Resources.data, False)
    End Sub

    Public Shared Sub Clean()
        If DatabasePath <> "" AndAlso My.Computer.FileSystem.FileExists(DatabasePath) Then
            My.Computer.FileSystem.DeleteFile(DatabasePath)
        End If
    End Sub
#End Region

End Class

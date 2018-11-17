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

Public Class frm_Splash
    Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As [Enum], ByVal arg As Object)
        Invoke(Sub() lbl_description.Text = arg.ToString)
    End Sub

    Private Sub Splash_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        lbl_copyright.Text = My.Application.Info.Copyright
        If My.Settings.Skin <> "" Then
            Try
                Me.Theme.LookAndFeel.SkinName = My.Settings.Skin
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class

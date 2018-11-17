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

Namespace Objects
    Public Class TwinName

#Region "Fields/Properties"
        ReadOnly Property ID As Integer
        ReadOnly Property Language As String
        ReadOnly Property Gender As String
        ReadOnly Property Name1 As String
        ReadOnly Property Meaning1 As String
        ReadOnly Property Name2 As String
        ReadOnly Property Meaning2 As String
#End Region

#Region "Sub"
        Sub New(ByVal ID As Integer, ByVal Language As String, ByVal Gender As String, ByVal Name1 As String, ByVal Meaning1 As String, ByVal Name2 As String, ByVal Meaning2 As String)
            Me.ID = ID
            Me.Language = Language
            Me.Gender = Gender
            Me.Name1 = Name1
            Me.Name2 = Name2
            Me.Meaning1 = Meaning1
            Me.Meaning2 = Meaning2
        End Sub

        Public Overrides Function ToString() As String
            Return String.Format("{0}, {1}", Name1, Name2)
        End Function
#End Region

    End Class
End Namespace
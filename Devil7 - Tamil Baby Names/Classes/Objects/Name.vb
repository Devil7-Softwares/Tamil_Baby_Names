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
    Public Class Name

#Region "Fields/Properties"
        ReadOnly Property ID As Integer
        ReadOnly Property Gender As String
        ReadOnly Property Religion As String
        ReadOnly Property FirstLetter As String
        ReadOnly Property Language As String
        ReadOnly Property Name As String
        ReadOnly Property Meaning As String
#End Region

#Region "Sub"
        Sub New(ByVal ID As Integer, ByVal Gender As String, ByVal Religion As String, ByVal FirstLetter As String, ByVal Language As String, ByVal Name As String, ByVal Meaning As String)
            Me.ID = ID
            Me.Gender = Gender
            Me.Religion = Religion
            Me.FirstLetter = FirstLetter
            Me.Language = Language
            Me.Name = Name
            Me.Meaning = Meaning
        End Sub

        Public Overrides Function ToString() As String
            Return Name
        End Function
#End Region

    End Class
End Namespace
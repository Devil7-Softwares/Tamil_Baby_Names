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
    Public Class Nakshatra

#Region "Fields/Properties"
        ReadOnly Property ID As Integer
        ReadOnly Property Name_TAM As String
        ReadOnly Property Name_ENG As String
        ReadOnly Property Letters_TAM As String
        ReadOnly Property Letters_ENG As String
        ReadOnly Property Meaning As String
#End Region

#Region "Subs"
        Sub New(ByVal ID As Integer, ByVal Name_TAM As String, ByVal Name_ENG As String, ByVal Letters_TAM As String, ByVal Letters_ENG As String, ByVal Meaning As String)
            Me.ID = ID
            Me.Name_TAM = Name_TAM
            Me.Name_ENG = Name_ENG
            Me.Letters_TAM = Letters_TAM
            Me.Letters_ENG = Letters_ENG
            Me.Meaning = Meaning
        End Sub
#End Region

    End Class
End Namespace
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
    Public Class NamesReportItem

#Region "Properties"
        Property Gender As String
        Property Religion As String
        Property Language As String
        Property Rashi As String
        Property Nakshatra As String
        Property NakshatraMeaning As String
        Property Letters As String
        Property Names As List(Of Name)
        ReadOnly Property Count As Integer
            Get
                Return If(Names Is Nothing, 0, Names.Count)
            End Get
        End Property
        Property AddressInfo As AddressInfo
#End Region

#Region "Subs"
        Sub New(ByVal Gender As String, ByVal Religion As String, ByVal Language As String, ByVal Rashi As String, ByVal Nakshatra As String, ByVal NakshatraMeaning As String, ByVal Letters As String, ByVal Names As List(Of Name), ByVal AddressInfo As AddressInfo)
            Me.Gender = Gender
            Me.Religion = Religion
            Me.Rashi = Rashi
            Me.Nakshatra = Nakshatra
            Me.NakshatraMeaning = NakshatraMeaning
            Me.Letters = Letters
            Me.Names = Names
            Me.Language = Language
            Me.AddressInfo = AddressInfo
        End Sub
#End Region

    End Class
End Namespace
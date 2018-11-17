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
    Public Class City

#Region "Fields/Properties"
        ReadOnly Property ID As Integer
        ReadOnly Property Name As String
        ReadOnly Property TimeZone As String
        ReadOnly Property Longitude As String
        ReadOnly Property Latitude As String
#End Region

#Region "Subs"
        Sub New(ByVal ID As Integer, ByVal Name As String, ByVal TimeZone As String, ByVal Longitude As String, ByVal Latitude As String)
            Me.ID = ID
            Me.Name = Name
            Me.TimeZone = TimeZone
            Me.Longitude = Longitude
            Me.Latitude = Latitude
        End Sub

        Public Overrides Function ToString() As String
            Return Name
        End Function
#End Region

    End Class
End Namespace
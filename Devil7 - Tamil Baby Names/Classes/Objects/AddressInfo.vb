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
    Public Class AddressInfo

#Region "Properties"
        Property Name As String
        Property AddressLine1 As String
        Property AddressLine2 As String
        Property City As String
        Property PinCode As String
        Property State As String
        Property ContactNo As String
        Property EmailID As String
#End Region

#Region "Subs"
        Sub New()
            Me.Name = ""
            Me.AddressLine1 = ""
            Me.AddressLine2 = ""
            Me.City = ""
            Me.PinCode = ""
            Me.State = ""
            Me.ContactNo = ""
            Me.EmailID = ""
        End Sub

        Sub New(ByVal Name As String, ByVal AddressLine1 As String, ByVal AddressLine2 As String, ByVal City As String, ByVal PinCode As String, ByVal State As String, ByVal ContactNo As String, ByVal EmailID As String)
            Me.Name = Name
            Me.AddressLine1 = AddressLine1
            Me.AddressLine2 = AddressLine2
            Me.City = City
            Me.PinCode = PinCode
            Me.State = State
            Me.ContactNo = ContactNo
            Me.EmailID = EmailID
        End Sub
#End Region

    End Class
End Namespace
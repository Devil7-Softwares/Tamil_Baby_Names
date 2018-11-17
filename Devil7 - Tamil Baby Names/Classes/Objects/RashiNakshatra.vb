﻿'=========================================================================='
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
    Public Class RashiNakshatra

#Region "Properties"
        Property Rashi As Rashi
        Property Nakshatra As Nakshatra
#End Region

#Region "Constructors"
        Sub New(ByVal Rashi As Rashi, ByVal Nakshatra As Nakshatra)
            Me.Rashi = Rashi
            Me.Nakshatra = Nakshatra
        End Sub

        Public Overrides Function ToString() As String
            Return String.Format("{0}, {1}", Rashi.ToString, Nakshatra.ToString)
        End Function
#End Region

    End Class
End Namespace
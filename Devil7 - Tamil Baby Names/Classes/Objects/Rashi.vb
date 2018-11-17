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
    Public Class Rashi

#Region "Properties"
        ReadOnly Property Name_TA As String
        ReadOnly Property Name_EN As String
#End Region

#Region "Constructors"
        Sub New(ByVal Name_EN As String, ByVal Name_TA As String)
            Me.Name_TA = Name_TA
            Me.Name_EN = Name_EN
        End Sub
#End Region

#Region "Subs"
        Public Shared Function GetAllRashis() As List(Of Rashi)
            Return New List(Of Rashi)({
                                      New Rashi("Aries", "மேஷம்"),
                                      New Rashi("Taurus", "ரிஷபம்"),
                                      New Rashi("Gemini", "மிதுனம்"),
                                      New Rashi("Cancer", "கடகம்"),
                                      New Rashi("Leo", "சிம்மம்"),
                                      New Rashi("Virgo", "கன்னி"),
                                      New Rashi("Libra", "துலாம்"),
                                      New Rashi("Scorpio", "விருச்சிகம்"),
                                      New Rashi("Sagittarius", "தனுசு"),
                                      New Rashi("Capricorn", "மகரம்"),
                                      New Rashi("Aquarius", "கும்பம்"),
                                      New Rashi("Pisces", "மீனம்")
                                      })
        End Function

        Public Overrides Function ToString() As String
            Return Name_TA
        End Function
#End Region

    End Class
End Namespace
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

Imports System.Math

Public Class Astro

#Region "Constants"
    Const d2r As Double = PI / 180
    Const r2d As Double = 180 / PI
#End Region

#Region "Public Functions"
    ''' <summary>
    ''' Calculates Rashi (Moon Sign) &amp; Nakshatra (Star Sign) Based on Vedic Astrology
    ''' </summary>
    ''' <param name="DateTimeOfBirth">Local Date &amp; Time of Birth of Person.</param>
    ''' <param name="BirthCity">City Where the Person is Born.</param>
    ''' <param name="DaylightSaving">Whether Daylight Saving is Applicable.</param>
    ''' <remarks></remarks>
    Public Shared Function GetRashiNakshatra(ByVal DateTimeOfBirth As Date, ByVal BirthCity As Objects.City, ByVal DaylightSaving As Boolean) As Objects.RashiNakshatra
        ' Date Of Birth
        Dim Day As Double = DateTimeOfBirth.Day
        Dim Month As Double = DateTimeOfBirth.Month
        Dim Year As Double = DateTimeOfBirth.Year

        ' Time Of Birth
        Dim Minute As Double = DateTimeOfBirth.Minute
        Dim Hour As Double = DateTimeOfBirth.Hour + (Minute / 60)

        ' Birth City - Longitude
        Dim longitude_hour As Double = BirthCity.Longitude.Split(".")(0)
        Dim longitude_min As Double = BirthCity.Longitude.Split(".")(1).Substring(0, 2)
        Dim ln As Double = longitude_hour + (longitude_min / 60)
        If BirthCity.Longitude.Split(".")(1).Substring(2, 1) = "E" Then ln *= -1

        ' Birth City - Latitude
        Dim latitude_hour As Double = BirthCity.Latitude.Split(".")(0)
        Dim latitude_min As Double = BirthCity.Latitude.Split(".")(1).Substring(0, 2)
        Dim la As Double = latitude_hour + (latitude_min / 60)
        If BirthCity.Latitude.Split(".")(1).Substring(2, 1) = "S" Then la *= -1

        ' Birth City - TimeZone
        Dim tz_hour As Double = BirthCity.TimeZone.Split(".")(0)
        Dim tz_min As Double = BirthCity.TimeZone.Split(".")(1).Substring(0, 2)
        Dim tz_sig As String = BirthCity.TimeZone.Split(".")(1).Substring(2, 1)
        Dim tz As Double = tz_hour + (tz_min / 60)
        If (DaylightSaving) Then
            If (ln < 0.0) Then
                tz += 1
            Else
                tz -= 1
            End If
        End If


        Dim jd = mdy2julian(Month, Day, Year)

        Dim f As Double
        If (ln < 0.0) Then
            f = Hour - tz
        Else
            f = Hour + tz
        End If
        Dim ffin = f
        Dim t As Double = (jd - 2451545 - 0.5) / 36525
        Dim gst As Double = ut2gst(t, f)
        t = ((jd - 2451545) + f / 24 - 0.5) / 36525
        Dim ay = calcayan(t)
        Dim ob = 23.452294 - 0.0130125 * t
        Dim l = (218.3164591 + 481267.88134236 * t)

        Dim dtime = 367 * Year - Floor((7 * (Year + (Floor((Month + 9) / 12)))) / 4) + Floor((275 * Month) / 9) + Day - 730530 + ffin / 24

        Dim d = (297.8502042 + 445267.1115168 * t)
        Dim m As Double = (357.5291092 + 35999.0502909 * t)
        Dim mm = (134.9634114 + 477198.8676313 * t)
        f = (93.2720993 + 483202.0175273 * t)
        d *= d2r
        m *= d2r
        mm *= d2r
        f *= d2r
        Dim e = 1 - 0.002516 * t - 0.0000074 * t * t

        Dim p = 6.288774 * Math.Sin(mm) + 1.274027 * Sin(d * 2 - mm) + 0.658314 * Sin(d * 2) + 0.213618 * Sin(2 * mm) - 0.185116 * e * Sin(m) - 0.114332 * Sin(f * 2)
        p += 0.058793 * Sin(d * 2 - mm * 2) + 0.057066 * e * Sin(d * 2 - m - mm) + 0.053322 * Sin(d * 2 + mm) + 0.045758 * e * Sin(d * 2 - m) - 0.040923 * e * Sin(m - mm) - 0.03472 * Sin(d) - 0.030383 * e * Sin(m + mm)
        p += 0.015327 * Sin(d * 2 - f * 2) - 0.012528 * Sin(mm + f * 2) + 0.01098 * Sin(mm - f * 2) + 0.010675 * Sin(d * 4 - mm) + 0.010034 * Sin(3 * mm)
        p += 0.008548 * Sin(d * 4 - mm * 2) - 0.007888 * e * Sin(d * 2 + m - mm) - 0.006766 * e * Sin(d * 2 + m) - 0.005163 * Sin(d - mm) + 0.004987 * e * Sin(d + m) + 0.004036 * e * Sin(d * 2 - m + mm) + 0.003994 * Sin(d * 2 + mm * 2)
        Dim b = 5.128122 * Sin(f) + 0.280602 * Sin(mm + f) + 0.277693 * Sin(mm - f) + 0.173237 * Sin(d * 2 - f) + 0.055413 * Sin(d * 2 - mm + f) + 0.046271 * Sin(d * 2 - mm - f)
        b += 0.032573 * Sin(2 * d + f) + 0.017198 * Sin(2 * mm + f) + 0.009266 * Sin(2 * d + mm - f) + 0.008823 * Sin(2 * mm - f) + 0.008247 * e * Sin(2 * d - m - f) + 0.004324 * Sin(2 * d - f - 2 * mm)
        b += 0.0042 * Sin(2 * d + f + mm) + 0.003372 * e * Sin(f - m - 2 * d) + 0.002472 * e * Sin(2 * d + f - m - mm) + 0.002222 * e * Sin(2 * d + f - m) + 0.002072 * e * Sin(2 * d - f - m - mm) + 0.001877 * e * Sin(f - m + mm)
        b += 0.001828 * Sin(4 * d - f - mm) - 0.001803 * e * Sin(f + m) - 0.00175 * Sin(3 * f) + 0.00157 * e * Sin(mm - m - f) - 0.001487 * Sin(f + d) - 0.001481 * e * Sin(f + m + mm)
        Dim r = 0.950724 + 0.051818 * Cos(mm) + 0.009531 * Cos(2 * d - mm) + 0.007843 * Cos(2 * d) + 0.002824 * Cos(2 * mm) + 0.000857 * Cos(2 * d + mm) + 0.000533 * e * Cos(2 * d - m)
        r += 0.000401 * e * Cos(2 * d - m - mm) + 0.00032 * e * Cos(mm - m) - 0.000271 * Cos(d) - 0.000264 * e * Cos(m + mm) - 0.000198 * Cos(2 * f - mm) + 0.000173 * Cos(3 * mm)
        r += 0.000167 * Cos(4 * d - mm) - 0.000111 * e * Cos(m) + 0.000103 * Cos(4 * d - 2 * mm) - 0.000084 * Cos(2 * mm - 2 * d) - 0.000083 * e * Cos(2 * d + m) + 0.000079 * Cos(2 * d + 2 * mm) + 0.000072 * Cos(4 * d)

        l += p
        While (l < 0.0)
            l += 360.0
        End While
        While (l > 360.0)
            l -= 360.0
        End While
        ln = -ln
        ln /= 15
        ln += gst
        While (ln < 0.0)
            ln += 24
        End While
        While (ln > 24.0)
            ln -= 24
        End While

        l += ay
        If (l < 0.0) Then l += 360.0
        Dim Rashi As Objects.Rashi = Objects.Rashi.GetAllRashis()(lon2dmsz(l))
        Dim Nakshatra As Objects.Nakshatra = DatabaseIO.GetNakshatras(True)(Floor((l * 60) / 800.0))
        Return New Objects.RashiNakshatra(Rashi, Nakshatra)
    End Function
#End Region

#Region "Private Functions"
    Private Shared Function mdy2julian(m, d, y)
        Dim im = 12 * (y + 4800) + m - 3
        Dim j = (2 * (im - Floor(im / 12) * 12) + 7 + 365 * im) / 12
        j = Floor(j) + d + Floor(im / 48) - 32083
        If (j > 2299171) Then j += Floor(im / 4800) - Floor(im / 1200) + 38
        Return j
    End Function

    Private Shared Function ut2gst(t, ut) As Double
        Dim t0 = 6.697374558 + (2400.051336 * t) + (0.000025862 * t * t)
        ut *= 1.002737909
        t0 += ut
        While (t0 < 0.0)
            t0 += 24
        End While
        While (t0 > 24.0)
            t0 -= 24
        End While
        Return t0
    End Function

    Private Shared Function calcayan(ByVal t As Double) As Double
        Dim ln As Double = 125.044555 - 1934.1361849 * t + 0.0020762 * t * t
        Dim off As Double = 280.466449 + 36000.7698231 * t + 0.0003106 * t * t
        off = 17.23 * Sin(d2r * ln) + 1.27 * Sin(d2r * off) - (5025.64 + 1.11 * t) * t
        off = (off - 80861.27) / 3600.0
        Return off
    End Function

    Private Shared Function lon2dmsz(ByVal x As Double) As Integer
        Dim d, m, s As Double
        x = Abs(x)
        d = Floor(x)
        m = (x - d)
        s = m * 60
        m = Floor(s)
        s = s - m
        Return Floor(d / 30)
    End Function

    Private Shared Function dsin(ByVal num As Double) As Double
        Return Sin(dtor(num))
    End Function

    Private Shared Function dcos(ByVal num As Double) As Double
        Return Cos(dtor(num))
    End Function

    Private Shared Function dtor(ByVal num As Double)
        Return num / 57.29577951
    End Function

    Function fix360(ByVal v As Double) As Double
        While (v < 0.0)
            v += 360
        End While
        While (v > 360)
            v -= 360
        End While
        Return v
    End Function
#End Region

End Class

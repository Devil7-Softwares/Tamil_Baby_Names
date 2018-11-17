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

Public Class frm_CalcAstro

#Region "Properties"
    Property RashiNakshatra As Objects.RashiNakshatra
#End Region

#Region "Form Events"
    Private Sub frm_CalcAstro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_BirthCity.Properties.Items.AddRange(DatabaseIO.GetCities.ToArray)
    End Sub
#End Region

#Region "Control Events"
    Private Sub txt_Date_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Date.EditValueChanged
        txt_Time.EditValue = txt_Date.EditValue
    End Sub

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        Try
            Me.RashiNakshatra = Astro.GetRashiNakshatra(txt_Time.EditValue, txt_BirthCity.SelectedItem, switch_DaylightSaving.IsOn)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
#End Region

End Class
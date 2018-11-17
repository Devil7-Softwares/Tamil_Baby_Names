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

Public Class frm_Main

#Region "Form Events"
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatabaseIO.CreateDB()
        cmb_Nakshatra.Properties.Items.AddRange(DatabaseIO.GetNakshatras.ToArray)
        cmb_Rashi.Properties.Items.AddRange(Objects.Rashi.GetAllRashis)
    End Sub

    Private Sub frm_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        DatabaseIO.Clean()
    End Sub

    Private Sub btn_CalcStarSign_Click(sender As Object, e As EventArgs) Handles btn_CalcStarSign.Click
        If frm_CalcAstro.ShowDialog = DialogResult.OK Then
            cmb_Nakshatra.SelectedItem = frm_CalcAstro.RashiNakshatra.Nakshatra
            cmb_Rashi.SelectedItem = frm_CalcAstro.RashiNakshatra.Rashi
        End If
    End Sub
#End Region

End Class
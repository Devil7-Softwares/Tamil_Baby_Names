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

Imports DevExpress.XtraBars

Public Class frm_Main

#Region "Form Events"
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_Splash.ProcessCommand(Nothing, "Initializing Database...")
        DatabaseIO.CreateDB()
        frm_Splash.ProcessCommand(Nothing, "Reading Nakshatras...")
        cmb_Nakshatra.Properties.Items.AddRange(DatabaseIO.GetNakshatras(True).ToArray)
        frm_Splash.ProcessCommand(Nothing, "Reading Rashis...")
        cmb_Rashi.Properties.Items.AddRange(Objects.Rashi.GetAllRashis.ToArray)
        frm_Splash.ProcessCommand(Nothing, "Reading Cities...")
        DatabaseIO.GetCities(False)
        frm_Splash.ProcessCommand(Nothing, "Reading Twin Names...")
        DatabaseIO.GetTwinNames(False)
        frm_Splash.ProcessCommand(Nothing, "Reading Names...")
        DatabaseIO.GetNames(True)
    End Sub

    Private Sub frm_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        DatabaseIO.Clean()
    End Sub
#End Region

#Region "Button Control Events"
    Private Sub btn_CalcStarSign_Click(sender As Object, e As EventArgs) Handles btn_CalcStarSign.Click
        If frm_CalcAstro.ShowDialog = DialogResult.OK Then
            cmb_Nakshatra.SelectedItem = frm_CalcAstro.RashiNakshatra.Nakshatra
            cmb_Rashi.SelectedItem = frm_CalcAstro.RashiNakshatra.Rashi
        End If
    End Sub

    Private Sub btn_Filter_FirstLetter_Automatic_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Filter_FirstLetter_Automatic.ItemClick
        If btn_Filter_FirstLetter_Automatic.Down Then
            btn_Filter_FirstLetter_Manual.Down = False
            grp_AutoFilter.Visible = True
            grp_ManualFilter.Visible = False
        Else
            btn_Filter_FirstLetter_Automatic.Down = True
        End If
    End Sub

    Private Sub btn_Filter_FirstLetter_Manual_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Filter_FirstLetter_Manual.ItemClick
        If btn_Filter_FirstLetter_Manual.Down Then
            btn_Filter_FirstLetter_Automatic.Down = False
            grp_AutoFilter.Visible = False
            grp_ManualFilter.Visible = True
        Else
            btn_Filter_FirstLetter_Manual.Down = True
        End If
    End Sub

    Private Sub cmb_Nakshatra_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_Nakshatra.SelectedValueChanged
        If cmb_Nakshatra.SelectedItem IsNot Nothing Then
            txt_Letters.Text = String.Format("{0} | {1}", CType(cmb_Nakshatra.SelectedItem, Objects.Nakshatra).Letters_TAM, CType(cmb_Nakshatra.SelectedItem, Objects.Nakshatra).Letters_ENG)
        End If
    End Sub
#End Region

#Region "Other Control Events"

#End Region

End Class
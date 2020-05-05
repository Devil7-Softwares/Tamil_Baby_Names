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
            btn_Filter_FirstLetter_None.Down = False
            grp_AutoFilter.Visible = True
            grp_ManualFilter.Visible = False
        Else
            btn_Filter_FirstLetter_Automatic.Down = True
        End If
    End Sub

    Private Sub btn_Filter_FirstLetter_Manual_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Filter_FirstLetter_Manual.ItemClick
        If btn_Filter_FirstLetter_Manual.Down Then
            btn_Filter_FirstLetter_Automatic.Down = False
            btn_Filter_FirstLetter_None.Down = False
            grp_AutoFilter.Visible = False
            grp_ManualFilter.Visible = True
        Else
            btn_Filter_FirstLetter_Manual.Down = True
        End If
    End Sub
    Private Sub btn_Filter_FirstLetter_None_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Filter_FirstLetter_None.ItemClick
        If btn_Filter_FirstLetter_Automatic.Down Then
            btn_Filter_FirstLetter_Manual.Down = False
            btn_Filter_FirstLetter_Automatic.Down = False
            grp_AutoFilter.Visible = False
            grp_ManualFilter.Visible = False
        Else
            btn_Filter_FirstLetter_None.Down = True
        End If
    End Sub

    Private Sub cmb_Nakshatra_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_Nakshatra.SelectedValueChanged
        If cmb_Nakshatra.SelectedItem IsNot Nothing Then
            txt_Letters.Text = String.Format("{0} | {1}", CType(cmb_Nakshatra.SelectedItem, Objects.Nakshatra).Letters_TAM, CType(cmb_Nakshatra.SelectedItem, Objects.Nakshatra).Letters_ENG)
        End If
    End Sub

    Private Sub btn_InsertTamilLetters_Click(sender As Object, e As EventArgs) Handles btn_InsertTamilLetters.Click
        Dim dlg As New frm_InsertTamilLetters
        If txt_BeginsWith.Text <> "" Then
            Dim list As String() = txt_BeginsWith.Text.Split(",")
            If list.Count > 0 Then dlg.Letters = New List(Of String)(list)
        End If
        If dlg.ShowDialog = DialogResult.OK Then
            txt_BeginsWith.Text = String.Join(",", dlg.Letters)
        End If
    End Sub

    Private Sub btn_GenerateReport_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_GenerateReport.ItemClick
        If gc_Names.DataSource Is Nothing Then
            MsgBox("Apply Filter Before Generating Report.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        Else
            Dim Gender As String = "Boy"
            If btn_Filter_Gender_Boy.Down And btn_Filter_Gender_Girl.Down Then
                Gender = "Boy / Girl"
            ElseIf btn_Filter_Gender_Boy.Down Then
                Gender = "Boy"
            ElseIf btn_Filter_Gender_Girl.Down Then
                Gender = "Girl"
            End If

            Dim Religions As New List(Of String)
            If btn_Filter_Religion_Hindu.Down Then Religions.Add("Hindu")
            If btn_Filter_Religion_Islam.Down Then Religions.Add("Muslim")
            If btn_Filter_Religion_Christianity.Down Then Religions.Add("Chiristian")
            Dim Religion As String = String.Join(" / ", Religions)

            Dim Language As String = "Tamil"

            Dim Rashi As String = "-"
            If btn_Filter_FirstLetter_Automatic.Down And cmb_Rashi.SelectedItem IsNot Nothing Then
                Dim R As Objects.Rashi = cmb_Rashi.SelectedItem
                Rashi = R.Name_EN & " / " & R.Name_TA
            End If

            Dim Nakshatra As String = "-"
            Dim NakshatraMeaning As String = ""
            Dim Letters As String = ""
            If btn_Filter_FirstLetter_Automatic.Down And cmb_Nakshatra.SelectedItem IsNot Nothing Then
                Dim N As Objects.Nakshatra = cmb_Nakshatra.SelectedItem
                Nakshatra = N.Name_ENG & " / " & N.Name_TAM
                NakshatraMeaning = N.Meaning
                Letters = N.Letters_TAM
            ElseIf btn_Filter_FirstLetter_Manual.Down Then
                Letters = txt_BeginsWith.Text
            End If

            Dim AddressInfo As Objects.AddressInfo = New Objects.AddressInfo(My.Settings.Name, My.Settings.AddressLine1, My.Settings.AddressLine2, My.Settings.City, My.Settings.PinCode, My.Settings.State, My.Settings.ContactNo, My.Settings.EmailID)


            Dim ReportItem As New Objects.NamesReportItem(Gender, Religion, Language, Rashi, Nakshatra, NakshatraMeaning, Letters, gc_Names.DataSource, AddressInfo)
            Dim Report As New NamesReport With {.DataMember = "Names"}
            Report.DataSourceItem.DataSource = ReportItem
            Dim D As New frm_ReportViewer(Report)
            D.ShowDialog()
        End If
    End Sub
#End Region

#Region "Other Control Events"

#End Region

#Region "Filter"
    Private Sub btn_ApplyFilter_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_ApplyFilter.ItemClick
        gc_Names.DataSource = DatabaseIO.GetNames(True).FindAll(AddressOf Filter)
        gc_Names.RefreshDataSource()
        txt_NoOfItems.Caption = gc_Names.DataSource.Count
    End Sub

    Function Filter(ByVal Item As Objects.Name) As Boolean
        If btn_Filter_Gender_Boy.Down And Not btn_Filter_Gender_Girl.Down Then
            If Item.Gender <> "ஆண்" Then Return False
        ElseIf btn_Filter_Gender_Girl.Down And Not btn_Filter_Gender_Boy.Down Then
            If Item.Gender <> "பெண்" Then Return False
        End If

        Dim Religions As New List(Of String)
        If btn_Filter_Religion_Hindu.Down Then Religions.Add("இந்து")
        If btn_Filter_Religion_Islam.Down Then Religions.Add("முஸ்லிம்")
        If btn_Filter_Religion_Christianity.Down Then Religions.Add("கிறிஸ்துவர்")
        If Religions.Count > 0 AndAlso Not Religions.Contains(Item.Religion) Then Return False

        Dim FirstLetters As New List(Of String)
        If btn_Filter_FirstLetter_Automatic.Down Then
            If cmb_Nakshatra.SelectedItem IsNot Nothing Then
                Dim Nakshatra As Objects.Nakshatra = cmb_Nakshatra.SelectedItem
                FirstLetters.AddRange(Nakshatra.Letters_ENG.Split(","))
                FirstLetters.AddRange(Nakshatra.Letters_TAM.Split(","))
            End If
        ElseIf btn_Filter_FirstLetter_Manual.Down Then
            If txt_BeginsWith.Text.Trim <> "" Then
                FirstLetters.AddRange(txt_BeginsWith.Text.Split(","))
            End If
        Else
            Return True
        End If
        Dim FirstLetterMatched As Boolean = False
        If FirstLetters.Contains(Item.FirstLetter.Trim) Then
            FirstLetterMatched = True
        Else
            For Each i As String In FirstLetters
                If Item.Name.Trim.StartsWith(i) Then FirstLetterMatched = True
            Next
        End If

        Return FirstLetterMatched
    End Function
#End Region

End Class
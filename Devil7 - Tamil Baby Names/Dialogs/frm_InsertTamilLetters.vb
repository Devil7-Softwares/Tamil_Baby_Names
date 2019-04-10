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

Public Class frm_InsertTamilLetters

#Region "Properties"
    Property Letters As List(Of String)
#End Region

#Region "Form Events"
    Private Sub frm_InsertTamilLetters_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each i As Objects.Name In DatabaseIO.GetNames(True)
            If Not lst_Letters.Items.Contains(i.FirstLetter.Trim) AndAlso i.FirstLetter.Trim <> "" Then lst_Letters.Items.Add(i.FirstLetter.Trim)
        Next
        If Letters IsNot Nothing Then
            For Each i As String In Letters
                Dim index = lst_Letters.Items.IndexOf(i.Trim)
                If index >= 0 Then
                    lst_Letters.Items(index).CheckState = CheckState.Checked
                End If
            Next
        End If
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Insert_Click(sender As Object, e As EventArgs) Handles btn_Insert.Click
        If Letters Is Nothing Then
            Letters = New List(Of String)
            For Each i As DevExpress.XtraEditors.Controls.CheckedListBoxItem In lst_Letters.CheckedItems
                Letters.Add(i.Value)
            Next
        Else
            For Each i As DevExpress.XtraEditors.Controls.CheckedListBoxItem In lst_Letters.CheckedItems
                If Not Letters.Contains(i.Value) Then Letters.Add(i.Value)
            Next
        End If
        DialogResult = DialogResult.OK
        Close()
    End Sub
#End Region

End Class
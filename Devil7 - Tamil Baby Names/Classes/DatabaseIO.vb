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

Imports System.Data.SQLite
Imports Devil7.Astro.Names.Objects

Public Class DatabaseIO

#Region "Variables"
    Private Shared DatabasePath As String = ""
#End Region

#Region "Database"
    Public Shared Sub CreateDB()
        DatabasePath = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "data_" & (New Random).Next(1000, 9999) & ".db")
        My.Computer.FileSystem.WriteAllBytes(DatabasePath, My.Resources.data, False)
    End Sub

    Public Shared Sub Clean()
        If DatabasePath <> "" AndAlso My.Computer.FileSystem.FileExists(DatabasePath) Then
            My.Computer.FileSystem.DeleteFile(DatabasePath)
        End If
    End Sub

    Public Shared Function GetConnection() As SQLiteConnection
        Return New SQLiteConnection(String.Format("Data Source={0};Password=devil7softwares@2018;", DatabasePath))
    End Function
#End Region

#Region "Cities"
    Private Shared Cities As List(Of City)

    Public Shared Function GetCities(ByVal CloseConnection As Boolean) As List(Of City)
        If DatabasePath = "" OrElse My.Computer.FileSystem.FileExists(DatabasePath) = False Then CreateDB()

        If Cities Is Nothing Then
            Cities = New List(Of City)

            Dim Connection As SQLiteConnection = GetConnection()
            If Connection.State = ConnectionState.Closed Then Connection.Open()
            Using Command As New SQLiteCommand("SELECT * FROM cities", Connection)
                Using Reader As SQLiteDataReader = Command.ExecuteReader
                    While Reader.Read
                        Dim ID As Integer = Reader.Item("id")
                        Dim Name As String = Reader.Item("name")
                        Dim TimeZone As String = Reader.Item("timezone")
                        Dim Longitude As String = Reader.Item("longitude")
                        Dim Latitude As String = Reader.Item("latitude")
                        Cities.Add(New City(ID, Name, TimeZone, Longitude, Latitude))
                    End While
                End Using
            End Using
            If CloseConnection Then Connection.Close()
        End If

        Return Cities
    End Function
#End Region

#Region "Stars"
    Private Shared Nakshatras As List(Of Nakshatra)

    Public Shared Function GetNakshatras(ByVal CloseConnection As Boolean) As List(Of Nakshatra)
        If DatabasePath = "" OrElse My.Computer.FileSystem.FileExists(DatabasePath) = False Then CreateDB()

        If Nakshatras Is Nothing Then
            Nakshatras = New List(Of Nakshatra)

            Dim Connection As SQLiteConnection = GetConnection()
            If Connection.State = ConnectionState.Closed Then Connection.Open()
            Using Command As New SQLiteCommand("SELECT * FROM stars", Connection)
                Using Reader As SQLiteDataReader = Command.ExecuteReader
                    While Reader.Read
                        Dim ID As Integer = Reader.Item("id")
                        Dim Name_TAM As String = Reader.Item("name_ta")
                        Dim Name_ENG As String = Reader.Item("name_en")
                        Dim Letters_TAM As String = Reader.Item("letters_ta")
                        Dim Letters_ENG As String = Reader.Item("letters_en")
                        Dim Meaning As String = Reader.Item("meaning")
                        Nakshatras.Add(New Nakshatra(ID, Name_TAM, Name_ENG, Letters_TAM, Letters_ENG, Meaning))
                    End While
                End Using
            End Using
            If CloseConnection Then Connection.Close()
        End If

        Return Nakshatras
    End Function
#End Region

#Region "Names"
    Private Shared Names As List(Of Name)

    Public Shared Function GetNames(ByVal CloseConnection As Boolean) As List(Of Name)
        If DatabasePath = "" OrElse My.Computer.FileSystem.FileExists(DatabasePath) = False Then CreateDB()

        If Names Is Nothing Then
            Names = New List(Of Name)

            Dim Connection As SQLiteConnection = GetConnection()
            If Connection.State = ConnectionState.Closed Then Connection.Open()
            Using Command As New SQLiteCommand("SELECT * FROM names", Connection)
                Using Reader As SQLiteDataReader = Command.ExecuteReader
                    While Reader.Read
                        Dim ID As Integer = Reader.Item("id")
                        Dim Gender As String = Reader.Item("gender")
                        Dim Religion As String = Reader.Item("religion")
                        Dim FirstLetter As String = Reader.Item("first_letter")
                        Dim Language As String = Reader.Item("language")
                        Dim Name As String = Reader.Item("name")
                        Dim Meaning As String = Reader.Item("meaning")
                        Names.Add(New Name(ID, Gender, Religion, FirstLetter, Language, Name, Meaning))
                    End While
                End Using
            End Using
            If CloseConnection Then Connection.Close()
        End If

        Return Names
    End Function
#End Region

#Region "Twin Names"
    Private Shared TwinNames As List(Of TwinName)

    Public Shared Function GetTwinNames(ByVal CloseConnection As Boolean) As List(Of TwinName)
        If DatabasePath = "" OrElse My.Computer.FileSystem.FileExists(DatabasePath) = False Then CreateDB()

        If TwinNames Is Nothing Then
            TwinNames = New List(Of TwinName)

            Dim Connection As SQLiteConnection = GetConnection()
            If Connection.State = ConnectionState.Closed Then Connection.Open()
            Using Command As New SQLiteCommand("SELECT * FROM twin_names", Connection)
                Using Reader As SQLiteDataReader = Command.ExecuteReader
                    While Reader.Read
                        Dim ID As Integer = Reader.Item("id")
                        Dim Language As String = Reader.Item("language")
                        Dim Gender As String = Reader.Item("gender")
                        Dim Name1 As String = Reader.Item("name1")
                        Dim Meaning1 As String = Reader.Item("meaning1")
                        Dim Name2 As String = Reader.Item("name2")
                        Dim Meaning2 As String = Reader.Item("meaning2")
                        TwinNames.Add(New TwinName(ID, Language, Gender, Name1, Meaning1, Name2, Meaning2))
                    End While
                End Using
            End Using
            If CloseConnection Then Connection.Close()
        End If

        Return TwinNames
    End Function
#End Region

End Class

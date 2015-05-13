Imports Harmony_Tool.Global_Variables
Imports System.Array

Public Class Note
    Private pname As String

    Public Shared Operator =(ByVal note1 As Note, ByVal note2 As Note) As Boolean
        If (note1.Name = note2.Name) Then
            Return True
        End If
        Return False
    End Operator

    Public Shared Operator <>(ByVal note1 As Note, ByVal note2 As Note) As Boolean
        If (note1.Name <> note2.Name) Then
            Return True
        End If
        Return False
    End Operator

    Public Sub New()

    End Sub

    Public Sub New(ByVal value As String)
        pname = value
    End Sub

    Public Function Interval(ByVal value As Double)
        Dim note1 As Note = New Note
        Dim pos As Integer = IndexOf(Notes, Me.Name)
        note1.Name = Notes((pos + value * 2 + 24) Mod 12)

        Return note1
    End Function

    Property Name() As String
        Get
            Return pname
        End Get
        Set(value As String)
            pname = value
        End Set
    End Property

End Class

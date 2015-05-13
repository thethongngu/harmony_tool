Imports Harmony_Tool.Global_Variables

Public Class Chord : Inherits Scale

    Public Function NoteInTriadChord(ByVal num As Integer) As Note
        Dim note1 As Note = New Note
        If (Me.Type = "major") Then
            Select Case num
                Case 1
                    note1.Name = Me.NoteI.Name
                    Return note1
                Case 3
                    note1 = Me.NoteI.Interval(2)
                    Return note1
                Case 5
                    note1 = Me.NoteI.Interval(3.5)
                    Return note1
            End Select
        End If

        If (Me.Type = "minor") Then
            Select Case num
                Case 1
                    note1.Name = Me.NoteI.Name
                    Return note1
                Case 3
                    note1 = Me.NoteI.Interval(1.5)
                    Return note1
                Case 5
                    note1 = Me.NoteI.Interval(3.5)
                    Return note1
            End Select
        End If

        Return note1
    End Function

    Public Sub ShowChord(ByVal lab1 As Label)
        If (Me.Type = "major") Then
            lab1.Text += Me.NoteI.Name + "       "
        ElseIf Me.Type = "minor" Then
            lab1.Text += Me.NoteI.Name + "m      "
        Else
            lab1.Text += Me.NoteI.Name + "dim    "
        End If
    End Sub

End Class

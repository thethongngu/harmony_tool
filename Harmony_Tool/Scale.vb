Imports Harmony_Tool.Global_Variables
Imports System.Array

Public Class Scale
    Private pnote As Note = New Note
    Private ptype As String

    'Contrustor
    Public Sub New()
        
    End Sub

    'NOTE !!!!   Input with string inteads of Note object
    Public Sub New(ByVal value1 As String, ByVal value2 As String)
        '   Console.WriteLine(pnote.Name)
        pnote.Name = value1
        ptype = value2

    End Sub

    ''NOTE !!!!   Input with string inteads of Note object
    Public Sub Update(ByVal value1 As String, ByVal value2 As String)
       ' Console.WriteLine(pnote.Name)
        pnote.Name = value1
        ptype = value2
    End Sub

    'Just for debug 
    Public Sub Debug()
        Console.WriteLine(Me.NoteI.Name)
        Console.WriteLine(Me.Type)
        Console.WriteLine(urlbase + Me.NoteI.Name + " " + ptype + ".PNG")
    End Sub

    'Return the note in num level of scale
    Public Function GetNote(ByVal num As Integer) As Note

        Dim tmp_note As Note = New Note(Me.NoteI.Name)
        Dim i As Integer
        Dim tmp As Integer = IndexOf(Notes, Me.NoteI.Name)
        num -= 1

        If (Me.Type = "major") Then
            For i = 0 To num - 1
                If (i = 2 Or i = 6) Then
                    tmp += 1
                Else
                    tmp += 2
                End If
            Next
        End If

        If (Me.Type = "natural minor") Then
            For i = 0 To num - 1
                If (i = 1 Or i = 4) Then
                    tmp += 1
                Else
                    tmp += 2
                End If
            Next
        End If

        tmp_note.Name = Notes(tmp Mod 12)

        Return tmp_note
    End Function

    'Show picture scale in PicBox
    Public Sub Show(ByVal PicBox As PictureBox)
        '    Console.WriteLine(urlbase + pnote.Name + " " + ptype + ".PNG")
        PicBox.Load(urlbase + pnote.Name + " " + ptype + ".PNG")
    End Sub

    'Hide picture scale in PicBox
    Public Sub Hide(ByVal PicBox As PictureBox)
        PicBox.Image = Nothing
    End Sub

    'Compare to figure out whether is this scale or not
    Public Function Compare(ByVal value() As Note) As Scale()
        Dim res() As Scale


        Return res
    End Function

    'Find the parallel scale 
    Public Function Parallel() As Scale
        Dim res As Scale = New Scale(Me.NoteI.Name, Me.Type)

        If Type = "major" Then
            res = res.Translate(-1.5)
            res.Type = "natural minor"
            Me.Type = "major"
            Return res
        End If

        If Me.Type = "natural minor" Then
            res = res.Translate(1.5)
            res.Type = "major"
            Return res
        End If

        Return res
    End Function

    'Translate the scale to "num" level. Num is graduateed the conditions 0.5k
    Public Function Translate(ByVal num As Double) As Scale
        Dim res As Scale = New Scale(NoteI.Name, Type)
        res.NoteI = res.NoteI.Interval(num)
        Return res
    End Function

    'Return the chord in num level
    Public Function TriadChordInScale(ByVal num As Integer) As Chord
        Dim res As Chord = New Chord
        '    Console.WriteLine(Me.NoteI.Name)

        If (Me.Type = "major") Then
            Select Case num
                Case 2, 3, 6
                    res.Type = "minor"
                Case 7
                    res.Type = "dim"
                Case Else
                    res.Type = "major"
            End Select
            res.NoteI = Me.GetNote(num)
            Return res
        End If

        If (Me.Type = "natural minor") Then
            Select Case num
                Case 1, 4, 5, 7
                    res.Type = "minor"
                Case 2
                    res.Type = "dim"
                Case Else
                    res.Type = "major"
            End Select
            res.NoteI = Me.GetNote(num)
            Return res
        End If

        '  res.Debug()
        Return res
    End Function

    'Show all TriadChord in lab
    Public Sub ShowAllTriad(ByVal lab1 As Label)
        Dim x As Chord = New Chord
        lab1.Text = ""    

        For i As Integer = 1 To 7
            x = Me.TriadChordInScale(i)
            '   x.Debug()
            If (x.Type = "major") Then
                lab1.Text += CStr(i) + ". "
                x.ShowChord(lab1)
            ElseIf x.Type = "minor" Then
                lab1.Text += CStr(i) + ". "
                x.ShowChord(lab1)
            Else
                lab1.Text += CStr(i) + ". "
                x.ShowChord(lab1)
            End If
        Next
    End Sub


    Property Type() As String
        Get
            Return ptype
        End Get
        Set(value As String)
            ptype = value
        End Set
    End Property

    Property NoteI() As Note
        Set(value As Note)
            pnote = value
        End Set
        Get
            Return pnote
        End Get
    End Property

End Class

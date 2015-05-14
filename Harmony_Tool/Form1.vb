Imports Harmony_Tool.Global_Variables

Public Class Form1

    Public inputScale As Scale = New Scale
    Public outputScale As Scale = New Scale

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load content to combobox
        For i As Integer = 0 To 11 Step 1
            ComboBox1.Items.Add(Notes(i))
            Combo_Notes.Items.Add(Notes(i))
            ComboBox3.Items.Add(Intervals(i))
        Next

        ComboBox2.Items.Add("major")
        ComboBox2.Items.Add("natural minor")

        Dim path As String
        path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
        '  MessageBox.Show(path)
        path = Microsoft.VisualBasic.Right(path, path.Length() - 6)
        '  path = Microsoft.VisualBasic.Left(path, path.Length() - 10)
        '  MessageBox.Show(urlbase + " " + path + "\images\")
        urlbase = path + "\images\"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged, ComboBox2.SelectedIndexChanged
        'Close last picture
        inputScale.Hide(Picture_Scale1)
        outputScale.Hide(Picture_Scale2)

        'Show picture
        Try
            If (ComboBox1.SelectedIndex > -1) And (ComboBox2.SelectedIndex > -1) Then 'Check whether item is chosen
                inputScale.Update(ComboBox1.Text, ComboBox2.Text)
                inputScale.Show(Picture_Scale1)
                'Find all chords of scale and level
                inputScale.ShowAllTriad(label_Chord1)
            End If
        Catch ex As Exception
            MessageBox.Show(" Picture scale not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            If (ComboBox1.SelectedIndex > -1) And (ComboBox2.SelectedIndex > -1) Then  'Check whether item is chosen                
                outputScale = inputScale.Parallel()
                outputScale.Debug()
                outputScale.Show(Picture_Scale2)
                Name_Scale.Text = outputScale.NoteI.Name + " " + outputScale.Type
                'Find all chords of scale and level
                outputScale.ShowAllTriad(label_chord2)
            End If
        Catch ex As Exception
            MessageBox.Show("Parellel picture scale not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub

    Private Sub AboutToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem2.Click
        About.Show()
    End Sub

    Private Sub Combo_Notes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_Notes.SelectedIndexChanged, ComboBox3.SelectedIndexChanged
        If Combo_Notes.SelectedIndex > -1 And ComboBox3.SelectedIndex > -1 Then
            Dim note1 As Note = New Note(Combo_Notes.Text)
            Dim noteres As Note = New Note(labRes.Text)
            labRes.Text = ""
            labChord.Text = ""

            noteres = note1.Interval(Ton(ComboBox3.SelectedIndex))
            Console.WriteLine(ComboBox3.SelectedIndex)
            Console.WriteLine(Ton(ComboBox3.SelectedIndex))
            labRes.Text = noteres.Name

            Dim x As Chord = New Chord
            For i As Integer = 1 To 7
                x = inputScale.TriadChordInScale(i)
                For j As Integer = 1 To 5 Step 2
                    '  Console.WriteLine(x.NoteInTriadChord(j).Name)
                    If noteres = x.NoteInTriadChord(j) Then
                        x.ShowChord(labChord)
                    End If
                Next
            Next
        End If
    End Sub
End Class

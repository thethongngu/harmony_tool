<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmartFinderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Select_Scales = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Picture_Scale1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Name_Scale = New System.Windows.Forms.Label()
        Me.Picture_Scale2 = New System.Windows.Forms.PictureBox()
        Me.Chord1 = New System.Windows.Forms.GroupBox()
        Me.label_Chord1 = New System.Windows.Forms.Label()
        Me.Chord2 = New System.Windows.Forms.GroupBox()
        Me.label_chord2 = New System.Windows.Forms.Label()
        Me.Combo_Notes = New System.Windows.Forms.ComboBox()
        Me.labRes = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.labChord = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Picture_Scale1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Picture_Scale2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Chord1.SuspendLayout()
        Me.Chord2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(106, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(111, 23)
        Me.ComboBox1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1075, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FileToolStripMenuItem.Text = "File "
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save as ..."
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SmartFinderToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'SmartFinderToolStripMenuItem
        '
        Me.SmartFinderToolStripMenuItem.Name = "SmartFinderToolStripMenuItem"
        Me.SmartFinderToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.SmartFinderToolStripMenuItem.Text = "Smart Finder"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.AboutToolStripMenuItem2})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.AboutToolStripMenuItem.Text = "Helps"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.AboutToolStripMenuItem1.Text = "Document"
        '
        'AboutToolStripMenuItem2
        '
        Me.AboutToolStripMenuItem2.Name = "AboutToolStripMenuItem2"
        Me.AboutToolStripMenuItem2.Size = New System.Drawing.Size(130, 22)
        Me.AboutToolStripMenuItem2.Text = "About"
        '
        'Select_Scales
        '
        Me.Select_Scales.AutoSize = True
        Me.Select_Scales.Location = New System.Drawing.Point(6, 19)
        Me.Select_Scales.Name = "Select_Scales"
        Me.Select_Scales.Size = New System.Drawing.Size(97, 15)
        Me.Select_Scales.TabIndex = 2
        Me.Select_Scales.Text = "Select your scale:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Picture_Scale1)
        Me.GroupBox1.Controls.Add(Me.Select_Scales)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 167)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scales"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(223, 16)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(109, 23)
        Me.ComboBox2.TabIndex = 4
        '
        'Picture_Scale1
        '
        Me.Picture_Scale1.Location = New System.Drawing.Point(6, 49)
        Me.Picture_Scale1.Name = "Picture_Scale1"
        Me.Picture_Scale1.Size = New System.Drawing.Size(509, 110)
        Me.Picture_Scale1.TabIndex = 3
        Me.Picture_Scale1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Name_Scale)
        Me.GroupBox2.Controls.Add(Me.Picture_Scale2)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(539, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(525, 167)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parallel Scale"
        '
        'Name_Scale
        '
        Me.Name_Scale.AutoSize = True
        Me.Name_Scale.Location = New System.Drawing.Point(6, 19)
        Me.Name_Scale.Name = "Name_Scale"
        Me.Name_Scale.Size = New System.Drawing.Size(0, 15)
        Me.Name_Scale.TabIndex = 5
        '
        'Picture_Scale2
        '
        Me.Picture_Scale2.Location = New System.Drawing.Point(6, 49)
        Me.Picture_Scale2.Name = "Picture_Scale2"
        Me.Picture_Scale2.Size = New System.Drawing.Size(513, 110)
        Me.Picture_Scale2.TabIndex = 4
        Me.Picture_Scale2.TabStop = False
        '
        'Chord1
        '
        Me.Chord1.Controls.Add(Me.label_Chord1)
        Me.Chord1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chord1.Location = New System.Drawing.Point(12, 206)
        Me.Chord1.Name = "Chord1"
        Me.Chord1.Size = New System.Drawing.Size(521, 63)
        Me.Chord1.TabIndex = 5
        Me.Chord1.TabStop = False
        Me.Chord1.Text = "Chords"
        '
        'label_Chord1
        '
        Me.label_Chord1.Location = New System.Drawing.Point(6, 19)
        Me.label_Chord1.Name = "label_Chord1"
        Me.label_Chord1.Size = New System.Drawing.Size(509, 26)
        Me.label_Chord1.TabIndex = 0
        '
        'Chord2
        '
        Me.Chord2.Controls.Add(Me.label_chord2)
        Me.Chord2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chord2.Location = New System.Drawing.Point(539, 206)
        Me.Chord2.Name = "Chord2"
        Me.Chord2.Size = New System.Drawing.Size(524, 63)
        Me.Chord2.TabIndex = 6
        Me.Chord2.TabStop = False
        Me.Chord2.Text = "Chords"
        '
        'label_chord2
        '
        Me.label_chord2.Location = New System.Drawing.Point(12, 19)
        Me.label_chord2.Name = "label_chord2"
        Me.label_chord2.Size = New System.Drawing.Size(506, 26)
        Me.label_chord2.TabIndex = 0
        '
        'Combo_Notes
        '
        Me.Combo_Notes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Notes.FormattingEnabled = True
        Me.Combo_Notes.Location = New System.Drawing.Point(9, 19)
        Me.Combo_Notes.Name = "Combo_Notes"
        Me.Combo_Notes.Size = New System.Drawing.Size(111, 23)
        Me.Combo_Notes.TabIndex = 5
        '
        'labRes
        '
        Me.labRes.AutoSize = True
        Me.labRes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labRes.Location = New System.Drawing.Point(260, 22)
        Me.labRes.Name = "labRes"
        Me.labRes.Size = New System.Drawing.Size(0, 15)
        Me.labRes.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox3)
        Me.GroupBox3.Controls.Add(Me.labChord)
        Me.GroupBox3.Controls.Add(Me.Combo_Notes)
        Me.GroupBox3.Controls.Add(Me.labRes)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 270)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1052, 56)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Interval"
        '
        'labChord
        '
        Me.labChord.AutoSize = True
        Me.labChord.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labChord.Location = New System.Drawing.Point(454, 22)
        Me.labChord.Name = "labChord"
        Me.labChord.Size = New System.Drawing.Size(0, 15)
        Me.labChord.TabIndex = 9
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(128, 19)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(91, 23)
        Me.ComboBox3.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 335)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Chord2)
        Me.Controls.Add(Me.Chord1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Harmony Tools"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Picture_Scale1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Picture_Scale2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Chord1.ResumeLayout(False)
        Me.Chord2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SmartFinderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Select_Scales As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Picture_Scale1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Name_Scale As System.Windows.Forms.Label
    Friend WithEvents Picture_Scale2 As System.Windows.Forms.PictureBox
    Friend WithEvents Chord1 As System.Windows.Forms.GroupBox
    Friend WithEvents Chord2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents label_Chord1 As System.Windows.Forms.Label
    Friend WithEvents label_chord2 As System.Windows.Forms.Label
    Friend WithEvents Combo_Notes As System.Windows.Forms.ComboBox
    Friend WithEvents labRes As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents labChord As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox

End Class

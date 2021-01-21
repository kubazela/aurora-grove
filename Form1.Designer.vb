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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btNapoveda = New System.Windows.Forms.ToolStripMenuItem()
        Me.SouborToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btOtevrit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btUlozit = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDial = New System.Windows.Forms.OpenFileDialog()
        Me.SaveDial = New System.Windows.Forms.SaveFileDialog()
        Me.TimerCas = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbPosuv = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbHodiny = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btZavri = New System.Windows.Forms.Button()
        Me.lbZavri = New System.Windows.Forms.Label()
        Me.gbMaterial = New System.Windows.Forms.GroupBox()
        Me.rbPlast = New System.Windows.Forms.RadioButton()
        Me.rbDrevo = New System.Windows.Forms.RadioButton()
        Me.rbKov = New System.Windows.Forms.RadioButton()
        Me.txBxScitA = New System.Windows.Forms.TextBox()
        Me.lbPlus = New System.Windows.Forms.Label()
        Me.txBxScitB = New System.Windows.Forms.TextBox()
        Me.btScitani = New System.Windows.Forms.Button()
        Me.lbVysl = New System.Windows.Forms.Label()
        Me.cbVolba = New System.Windows.Forms.CheckBox()
        Me.nudKusy = New System.Windows.Forms.NumericUpDown()
        Me.lbKusy = New System.Windows.Forms.Label()
        Me.lbTyp = New System.Windows.Forms.Label()
        Me.cbTyp = New System.Windows.Forms.ComboBox()
        Me.tbPosuv = New System.Windows.Forms.TrackBar()
        Me.lbTextVyber = New System.Windows.Forms.Label()
        Me.pbInstall = New System.Windows.Forms.ProgressBar()
        Me.lbProgress = New System.Windows.Forms.Label()
        Me.TimerProgress = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txBox = New System.Windows.Forms.TextBox()
        Me.txBox2 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.gbMaterial.SuspendLayout()
        CType(Me.nudKusy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPosuv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btNapoveda, Me.SouborToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(743, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btNapoveda
        '
        Me.btNapoveda.Name = "btNapoveda"
        Me.btNapoveda.Size = New System.Drawing.Size(73, 20)
        Me.btNapoveda.Text = "Nápověda"
        '
        'SouborToolStripMenuItem1
        '
        Me.SouborToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btOtevrit, Me.btUlozit})
        Me.SouborToolStripMenuItem1.Name = "SouborToolStripMenuItem1"
        Me.SouborToolStripMenuItem1.Size = New System.Drawing.Size(57, 20)
        Me.SouborToolStripMenuItem1.Text = "Soubor"
        '
        'btOtevrit
        '
        Me.btOtevrit.Name = "btOtevrit"
        Me.btOtevrit.Size = New System.Drawing.Size(110, 22)
        Me.btOtevrit.Text = "Otevřít"
        '
        'btUlozit
        '
        Me.btUlozit.Name = "btUlozit"
        Me.btUlozit.Size = New System.Drawing.Size(110, 22)
        Me.btUlozit.Text = "Uložit"
        '
        'TimerCas
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbPosuv, Me.lbHodiny, Me.slInfo})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 537)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(743, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbPosuv
        '
        Me.lbPosuv.Name = "lbPosuv"
        Me.lbPosuv.Size = New System.Drawing.Size(13, 17)
        Me.lbPosuv.Text = "1"
        '
        'lbHodiny
        '
        Me.lbHodiny.Name = "lbHodiny"
        Me.lbHodiny.Size = New System.Drawing.Size(46, 17)
        Me.lbHodiny.Text = "Hodiny"
        '
        'slInfo
        '
        Me.slInfo.Name = "slInfo"
        Me.slInfo.Size = New System.Drawing.Size(147, 17)
        Me.slInfo.Text = "Poslední otevřený soubor: "
        '
        'btZavri
        '
        Me.btZavri.BackgroundImage = CType(resources.GetObject("btZavri.BackgroundImage"), System.Drawing.Image)
        Me.btZavri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btZavri.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btZavri.Location = New System.Drawing.Point(31, 43)
        Me.btZavri.Name = "btZavri"
        Me.btZavri.Size = New System.Drawing.Size(127, 106)
        Me.btZavri.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btZavri, "Stisknutím se zavře formulář")
        Me.btZavri.UseVisualStyleBackColor = True
        '
        'lbZavri
        '
        Me.lbZavri.AutoSize = True
        Me.lbZavri.Location = New System.Drawing.Point(20, 167)
        Me.lbZavri.Name = "lbZavri"
        Me.lbZavri.Size = New System.Drawing.Size(156, 13)
        Me.lbZavri.TabIndex = 3
        Me.lbZavri.Text = "Stiskni pro ukončení nebo ESC"
        '
        'gbMaterial
        '
        Me.gbMaterial.Controls.Add(Me.rbPlast)
        Me.gbMaterial.Controls.Add(Me.rbDrevo)
        Me.gbMaterial.Controls.Add(Me.rbKov)
        Me.gbMaterial.Location = New System.Drawing.Point(222, 43)
        Me.gbMaterial.Name = "gbMaterial"
        Me.gbMaterial.Size = New System.Drawing.Size(124, 124)
        Me.gbMaterial.TabIndex = 4
        Me.gbMaterial.TabStop = False
        Me.gbMaterial.Text = "Zvolte materiál"
        '
        'rbPlast
        '
        Me.rbPlast.AutoSize = True
        Me.rbPlast.Location = New System.Drawing.Point(27, 76)
        Me.rbPlast.Name = "rbPlast"
        Me.rbPlast.Size = New System.Drawing.Size(48, 17)
        Me.rbPlast.TabIndex = 2
        Me.rbPlast.TabStop = True
        Me.rbPlast.Text = "Plast"
        Me.rbPlast.UseVisualStyleBackColor = True
        '
        'rbDrevo
        '
        Me.rbDrevo.AutoSize = True
        Me.rbDrevo.Location = New System.Drawing.Point(27, 53)
        Me.rbDrevo.Name = "rbDrevo"
        Me.rbDrevo.Size = New System.Drawing.Size(55, 17)
        Me.rbDrevo.TabIndex = 1
        Me.rbDrevo.TabStop = True
        Me.rbDrevo.Text = "Dřevo"
        Me.rbDrevo.UseVisualStyleBackColor = True
        '
        'rbKov
        '
        Me.rbKov.AutoSize = True
        Me.rbKov.Location = New System.Drawing.Point(27, 30)
        Me.rbKov.Name = "rbKov"
        Me.rbKov.Size = New System.Drawing.Size(44, 17)
        Me.rbKov.TabIndex = 0
        Me.rbKov.TabStop = True
        Me.rbKov.Text = "Kov"
        Me.rbKov.UseVisualStyleBackColor = True
        '
        'txBxScitA
        '
        Me.txBxScitA.Location = New System.Drawing.Point(427, 43)
        Me.txBxScitA.Name = "txBxScitA"
        Me.txBxScitA.Size = New System.Drawing.Size(67, 20)
        Me.txBxScitA.TabIndex = 5
        '
        'lbPlus
        '
        Me.lbPlus.AutoSize = True
        Me.lbPlus.Location = New System.Drawing.Point(500, 46)
        Me.lbPlus.Name = "lbPlus"
        Me.lbPlus.Size = New System.Drawing.Size(13, 13)
        Me.lbPlus.TabIndex = 6
        Me.lbPlus.Text = "+"
        '
        'txBxScitB
        '
        Me.txBxScitB.Location = New System.Drawing.Point(519, 43)
        Me.txBxScitB.Name = "txBxScitB"
        Me.txBxScitB.Size = New System.Drawing.Size(67, 20)
        Me.txBxScitB.TabIndex = 7
        '
        'btScitani
        '
        Me.btScitani.Location = New System.Drawing.Point(602, 39)
        Me.btScitani.Name = "btScitani"
        Me.btScitani.Size = New System.Drawing.Size(52, 26)
        Me.btScitani.TabIndex = 8
        Me.btScitani.Text = "="
        Me.btScitani.UseVisualStyleBackColor = True
        '
        'lbVysl
        '
        Me.lbVysl.AutoSize = True
        Me.lbVysl.Location = New System.Drawing.Point(669, 46)
        Me.lbVysl.Name = "lbVysl"
        Me.lbVysl.Size = New System.Drawing.Size(0, 13)
        Me.lbVysl.TabIndex = 9
        '
        'cbVolba
        '
        Me.cbVolba.AutoSize = True
        Me.cbVolba.Location = New System.Drawing.Point(427, 121)
        Me.cbVolba.Name = "cbVolba"
        Me.cbVolba.Size = New System.Drawing.Size(98, 17)
        Me.cbVolba.TabIndex = 10
        Me.cbVolba.Text = "Lesklý povrch?"
        Me.cbVolba.UseVisualStyleBackColor = True
        '
        'nudKusy
        '
        Me.nudKusy.Location = New System.Drawing.Point(428, 147)
        Me.nudKusy.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudKusy.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudKusy.Name = "nudKusy"
        Me.nudKusy.Size = New System.Drawing.Size(32, 20)
        Me.nudKusy.TabIndex = 11
        Me.nudKusy.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbKusy
        '
        Me.lbKusy.AutoSize = True
        Me.lbKusy.Location = New System.Drawing.Point(481, 150)
        Me.lbKusy.Name = "lbKusy"
        Me.lbKusy.Size = New System.Drawing.Size(99, 13)
        Me.lbKusy.TabIndex = 12
        Me.lbKusy.Text = "Kolik kusů? (max 3)"
        '
        'lbTyp
        '
        Me.lbTyp.AutoSize = True
        Me.lbTyp.Location = New System.Drawing.Point(48, 201)
        Me.lbTyp.Name = "lbTyp"
        Me.lbTyp.Size = New System.Drawing.Size(98, 13)
        Me.lbTyp.TabIndex = 13
        Me.lbTyp.Text = "Zvolte typ výrobku:"
        '
        'cbTyp
        '
        Me.cbTyp.FormattingEnabled = True
        Me.cbTyp.Items.AddRange(New Object() {"židle", "skříň", "police"})
        Me.cbTyp.Location = New System.Drawing.Point(36, 225)
        Me.cbTyp.Name = "cbTyp"
        Me.cbTyp.Size = New System.Drawing.Size(121, 21)
        Me.cbTyp.TabIndex = 14
        '
        'tbPosuv
        '
        Me.tbPosuv.Location = New System.Drawing.Point(438, 190)
        Me.tbPosuv.Minimum = 1
        Me.tbPosuv.Name = "tbPosuv"
        Me.tbPosuv.Size = New System.Drawing.Size(162, 45)
        Me.tbPosuv.TabIndex = 15
        Me.tbPosuv.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.tbPosuv.Value = 1
        '
        'lbTextVyber
        '
        Me.lbTextVyber.AutoSize = True
        Me.lbTextVyber.Location = New System.Drawing.Point(30, 413)
        Me.lbTextVyber.Name = "lbTextVyber"
        Me.lbTextVyber.Size = New System.Drawing.Size(104, 13)
        Me.lbTextVyber.TabIndex = 17
        Me.lbTextVyber.Text = "Výsledný text výběru"
        '
        'pbInstall
        '
        Me.pbInstall.Location = New System.Drawing.Point(27, 438)
        Me.pbInstall.Name = "pbInstall"
        Me.pbInstall.Size = New System.Drawing.Size(175, 28)
        Me.pbInstall.TabIndex = 18
        '
        'lbProgress
        '
        Me.lbProgress.AutoSize = True
        Me.lbProgress.Location = New System.Drawing.Point(27, 473)
        Me.lbProgress.Name = "lbProgress"
        Me.lbProgress.Size = New System.Drawing.Size(96, 13)
        Me.lbProgress.TabIndex = 19
        Me.lbProgress.Text = "Probíhá instalace, "
        '
        'TimerProgress
        '
        '
        'txBox
        '
        Me.txBox.Location = New System.Drawing.Point(31, 269)
        Me.txBox.Multiline = True
        Me.txBox.Name = "txBox"
        Me.txBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txBox.Size = New System.Drawing.Size(159, 122)
        Me.txBox.TabIndex = 21
        '
        'txBox2
        '
        Me.txBox2.Location = New System.Drawing.Point(355, 281)
        Me.txBox2.Multiline = True
        Me.txBox2.Name = "txBox2"
        Me.txBox2.Size = New System.Drawing.Size(265, 82)
        Me.txBox2.TabIndex = 22
        '
        'Form1
        '
        Me.AcceptButton = Me.btScitani
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btZavri
        Me.ClientSize = New System.Drawing.Size(743, 559)
        Me.Controls.Add(Me.txBox2)
        Me.Controls.Add(Me.txBox)
        Me.Controls.Add(Me.lbProgress)
        Me.Controls.Add(Me.pbInstall)
        Me.Controls.Add(Me.lbTextVyber)
        Me.Controls.Add(Me.tbPosuv)
        Me.Controls.Add(Me.cbTyp)
        Me.Controls.Add(Me.lbTyp)
        Me.Controls.Add(Me.lbKusy)
        Me.Controls.Add(Me.nudKusy)
        Me.Controls.Add(Me.cbVolba)
        Me.Controls.Add(Me.lbVysl)
        Me.Controls.Add(Me.btScitani)
        Me.Controls.Add(Me.txBxScitB)
        Me.Controls.Add(Me.lbPlus)
        Me.Controls.Add(Me.txBxScitA)
        Me.Controls.Add(Me.gbMaterial)
        Me.Controls.Add(Me.lbZavri)
        Me.Controls.Add(Me.btZavri)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Zeleňák - Nábytek"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.gbMaterial.ResumeLayout(False)
        Me.gbMaterial.PerformLayout()
        CType(Me.nudKusy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbPosuv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents btNapoveda As Windows.Forms.ToolStripMenuItem
    Friend WithEvents SouborToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents btOtevrit As Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenDial As Windows.Forms.OpenFileDialog
    Friend WithEvents SaveDial As Windows.Forms.SaveFileDialog
    Friend WithEvents TimerCas As Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
    Friend WithEvents btZavri As Windows.Forms.Button
    Friend WithEvents lbZavri As Windows.Forms.Label
    Friend WithEvents gbMaterial As Windows.Forms.GroupBox
    Friend WithEvents rbPlast As Windows.Forms.RadioButton
    Friend WithEvents rbDrevo As Windows.Forms.RadioButton
    Friend WithEvents rbKov As Windows.Forms.RadioButton
    Friend WithEvents txBxScitA As Windows.Forms.TextBox
    Friend WithEvents lbPlus As Windows.Forms.Label
    Friend WithEvents txBxScitB As Windows.Forms.TextBox
    Friend WithEvents btScitani As Windows.Forms.Button
    Friend WithEvents lbVysl As Windows.Forms.Label
    Friend WithEvents cbVolba As Windows.Forms.CheckBox
    Friend WithEvents nudKusy As Windows.Forms.NumericUpDown
    Friend WithEvents lbKusy As Windows.Forms.Label
    Friend WithEvents lbTyp As Windows.Forms.Label
    Friend WithEvents cbTyp As Windows.Forms.ComboBox
    Friend WithEvents tbPosuv As Windows.Forms.TrackBar
    Friend WithEvents lbPosuv As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbHodiny As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbTextVyber As Windows.Forms.Label
    Friend WithEvents pbInstall As Windows.Forms.ProgressBar
    Friend WithEvents lbProgress As Windows.Forms.Label
    Friend WithEvents TimerProgress As Windows.Forms.Timer
    Friend WithEvents ToolTip1 As Windows.Forms.ToolTip
    Friend WithEvents btUlozit As Windows.Forms.ToolStripMenuItem
    Friend WithEvents slInfo As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txBox As Windows.Forms.TextBox
    Friend WithEvents txBox2 As Windows.Forms.TextBox
End Class

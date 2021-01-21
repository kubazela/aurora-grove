Imports Scripting
Imports System.Windows.Forms
Public Class Form1
    Public rbString As String
    Public cbText As String
    Public cas As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TimerCas.Start()
        Me.TimerProgress.Start()
    End Sub
    Private Sub Form1_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If Asc(e.KeyChar) = 27 Then
            Me.Close()
        End If
    End Sub
    Private Sub btNapoveda_Click(sender As Object, e As EventArgs) Handles btNapoveda.Click
        MsgBox("Toto je nápověda...",, "Nápověda")
    End Sub

    Private Sub btOtevrit_Click(sender As Object, e As EventArgs) Handles btOtevrit.Click
        Dim vs As DialogResult
        With OpenDial
            .Title = "Otervři soubor"
            .Filter = "Všechno (*.*) |*.*| Textové souvory (*.txt)|*.txt"
            .FilterIndex = 2
            vs = .ShowDialog()
            If vs = DialogResult.OK Then
                slInfo.Text = "Poslední soubor: " + .FileName
            Else
                slInfo.Text = "Stornováno"
            End If
        End With
        If vs = DialogResult.OK Then
            Dim objectReader As IO.StreamReader
            objectReader = IO.File.OpenText(OpenDial.FileName)
            txBox2.Text = objectReader.ReadToEnd
            objectReader.Close()
            '
            txBox.Text = My.Computer.FileSystem.ReadAllText(OpenDial.FileName)
            FileOpen(1, OpenDial.FileName, OpenMode.Input, OpenAccess.Read)
            'Input(1, txBox.Text)
            FileClose(1)
        End If
    End Sub
    Private Sub btUlozit_Click(sender As Object, e As EventArgs) Handles btUlozit.Click
        Dim v As DialogResult
        With SaveDial
            .Title = "Uložit soubor"
            v = .ShowDialog()
            If v = DialogResult.OK Then
                slInfo.Text = "Poslední soubor: " + .FileName
            Else
                slInfo.Text = "Stornováno"
            End If
        End With
        If v = DialogResult.OK Then
            Dim objWriter As New System.IO.StreamWriter(SaveDial.FileName, False)
            objWriter.Write(txBox.Text)
            objWriter.Close()
        End If
    End Sub
    Private Sub TimerCas_Tick(sender As Object, e As EventArgs) Handles TimerCas.Tick
        lbHodiny.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub btZavri_Click(sender As Object, e As EventArgs) Handles btZavri.Click
        Me.Close()
    End Sub

    Private Sub txBxScitA_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txBxScitA.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txBxScitB_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txBxScitB.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub
    Function vypisScit() As String
        Dim s As String
        If (Val(txBxScitA.Text) + Val(txBxScitB.Text)) > -1 Then
            lbVysl.Font = New Drawing.Font(lbVysl.Font.FontFamily, lbVysl.Font.Size, Font.Style.Regular)
            s = Str(Val(txBxScitA.Text) + Val(txBxScitB.Text))
            Return s
        Else
            lbVysl.Font = New Drawing.Font(lbVysl.Font.FontFamily, lbVysl.Font.Size, Font.Style.Bold)
            s = Str(Val(txBxScitA.Text) + Val(txBxScitB.Text))
            Return s
        End If
    End Function

    Private Sub btScitani_Click(sender As Object, e As EventArgs) Handles btScitani.Click
        lbVysl.Text = vypisScit()
        labelVypis()
    End Sub

    Private Sub tbPosuv_Scroll(sender As Object, e As EventArgs) Handles tbPosuv.Scroll
        lbPosuv.Text = Str(tbPosuv.Value)
    End Sub

    Private Sub TimerProgress_Tick(sender As Object, e As EventArgs) Handles TimerProgress.Tick
        Me.pbInstall.Maximum = cas * 1000
        Me.pbInstall.Value += Me.TimerProgress.Interval
        lbProgress.Text = "Probíhá instalace, čekejte " + Str(Math.Round(Me.cas - (pbInstall.Value / 1000))) + " s"
        If Math.Round(Me.cas - (pbInstall.Value / 1000)) = 0 Then
            lbProgress.Text = "Instalace dokončena"
        End If
        If Me.pbInstall.Value = pbInstall.Maximum Then TimerProgress.Stop()
    End Sub
    Private Sub cbTyp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTyp.SelectedIndexChanged
        Me.cbText = cbTyp.SelectedItem
        labelVypis()
    End Sub
    Sub labelVypis()
        If cbVolba.Checked = True Then
            lbTextVyber.Text = cbText + " " + ", lesklý povrch" + " " + rbString + "," + Str(nudKusy.Value) + " kusů"
        Else
            lbTextVyber.Text = cbText + " " + ", matný povrch" + " " + rbString + "," + Str(nudKusy.Value) + " kusů"
        End If
    End Sub

    Private Sub cbVolba_CheckedChanged(sender As Object, e As EventArgs) Handles cbVolba.CheckedChanged
        labelVypis()
    End Sub

    Private Sub rbKov_CheckedChanged(sender As Object, e As EventArgs) Handles rbKov.CheckedChanged
        If rbKov.Checked Then
            Me.rbString = ", kov"
        End If
        labelVypis()
    End Sub

    Private Sub rbDrevo_CheckedChanged(sender As Object, e As EventArgs) Handles rbDrevo.CheckedChanged
        If rbDrevo.Checked Then
            Me.rbString = ", dřevo"
        End If
        labelVypis()
    End Sub

    Private Sub rbPlast_CheckedChanged(sender As Object, e As EventArgs) Handles rbPlast.CheckedChanged
        If rbPlast.Checked = True Then
            Me.rbString = ", plast"
        End If
        labelVypis()
    End Sub

    Private Sub nudKusy_ValueChanged(sender As Object, e As EventArgs) Handles nudKusy.ValueChanged
        labelVypis()
    End Sub

    Private Sub cbTyp_TextChanged(sender As Object, e As EventArgs) Handles cbTyp.TextChanged
        Me.cbText = cbTyp.Text
        labelVypis()
    End Sub

    Private Sub txBxScitB_TextChanged(sender As Object, e As EventArgs) Handles txBxScitB.TextChanged

    End Sub

    Private Sub txBxScitA_TextChanged(sender As Object, e As EventArgs) Handles txBxScitA.TextChanged

    End Sub
End Class
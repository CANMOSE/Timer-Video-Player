Public Class Form1


    Dim saniye As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        saniye = saniye + 1

        If Form2.TextBox1.Text = saniye Then

            AxWindowsMediaPlayer1.Ctlcontrols.play()
            Timer1.Stop()

            If Form2.CheckBox1.Checked Then


                AxWindowsMediaPlayer1.fullScreen = True
            End If

        End If

        Form2.Label1.Text = saniye

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AxWindowsMediaPlayer1.Ctlcontrols.play()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxWindowsMediaPlayer1.fullScreen = True

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxWindowsMediaPlayer1.Ctlcontrols.play()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form2.Show()

    End Sub


    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            saniye = 0
            Form2.Label1.Text = ("0")

        End If
    End Sub

    Private Sub VideoyuSeçToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VideoyuSeçToolStripMenuItem.Click
        If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName

        End If
    End Sub

    Private Sub ZamanlayıcıToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZamanlayıcıToolStripMenuItem.Click
        Form2.Show()

    End Sub

    Private Sub TamEkranToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TamEkranToolStripMenuItem1.Click

        AxWindowsMediaPlayer1.fullScreen = True
    End Sub

    Private Sub UyarıÖnceTıklayınızToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UyarıÖnceTıklayınızToolStripMenuItem.Click
        MsgBox("Video yu Başlatmadan lütfen basmayınız.", MsgBoxStyle.Information, "Uyarı")
    End Sub

    Private Sub HakkındaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HakkındaToolStripMenuItem.Click
        AboutBox1.Show()

    End Sub
End Class

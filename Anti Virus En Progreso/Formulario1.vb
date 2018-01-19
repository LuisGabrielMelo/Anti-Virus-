
Public Class Form1


    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click

        Me.Close()

    End Sub

    Private Sub CuarentenaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuarentenaToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()



    End Sub

    Private Sub OpcionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpcionesToolStripMenuItem.Click
        Me.Hide()
        Formulario4.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Label5.Text = ProgressBar1.Value.ToString() + "%"
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Formulario5.Show()

        End If
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Stop()
        ProgressBar1.Value = 0
        Label5.Text = ProgressBar1.Value.ToString() + "%"
    End Sub

    Private Sub Btnescanear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnalisis.Click
        Timer1.Start()

    End Sub

    Private Sub InformacionSobreElProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformacionSobreElProductoToolStripMenuItem.Click
        Me.Show()
        Formulario6.Show()



    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Label6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Formulario3.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Formulario7.Show()

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Formulario8.Show()

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        





    End Sub

    Private Sub Label6_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lblvirus.Click

    End Sub
End Class

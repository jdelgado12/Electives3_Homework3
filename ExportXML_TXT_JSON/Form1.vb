Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim saveFile As New SaveFileDialog
        saveFile.Filter = "Text File (*.txt) | *.txt"
        saveFile.FilterIndex = 2
        saveFile.RestoreDirectory = False

        If saveFile.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(saveFile.FileName, displayBox.Text)
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles displayBox.TextChanged

    End Sub

    Private Sub display_Click(sender As Object, e As EventArgs) Handles display.Click
        displayBox.AppendText("###########################" + vbNewLine)
        displayBox.AppendText(nameLabel.Text + "   " + nameBox.Text + vbNewLine)
        displayBox.AppendText(ageLabel.Text + "   " + ageBox.Text + vbNewLine)
        displayBox.AppendText(addressLabel.Text + "   " + addressBox.Text + vbNewLine)
        displayBox.AppendText("###########################")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim saveFile As New SaveFileDialog
        saveFile.Filter = "XML File (*.xml) | *.xml"
        saveFile.FilterIndex = 2
        saveFile.RestoreDirectory = False

        If saveFile.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(saveFile.FileName, displayBox.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim saveFile As New SaveFileDialog
        saveFile.Filter = "JSON File (*.json) | *.xml"
        saveFile.FilterIndex = 2
        saveFile.RestoreDirectory = False

        If saveFile.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(saveFile.FileName, displayBox.Text)
        End If
    End Sub
End Class

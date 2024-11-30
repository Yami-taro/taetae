Imports System.IO

Public Class Form1
    Private Sub btnReadFile_Click(sender As Object, e As EventArgs) Handles btnReadFile.Click
        Try
            Dim filePath As String = txtFilePath.Text
            If File.Exists(filePath) Then
                txtFileContent.Text = File.ReadAllText(filePath)
            Else
                MessageBox.Show("File not found. Please check the path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As UnauthorizedAccessException
            MessageBox.Show("Access denied. You do not have permission to access this file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnWriteFile_Click(sender As Object, e As EventArgs) Handles btnWriteFile.Click
        Try
            Dim filePath As String = txtFilePath.Text
            File.WriteAllText(filePath, txtFileContent.Text)
            MessageBox.Show("File written successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As UnauthorizedAccessException
            MessageBox.Show("Access denied. You do not have permission to write to this file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAppendFile_Click(sender As Object, e As EventArgs) Handles btnAppendFile.Click
        Try
            Dim filePath As String = txtFilePath.Text
            File.AppendAllText(filePath, txtFileContent.Text & Environment.NewLine)
            MessageBox.Show("Content appended successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As UnauthorizedAccessException
            MessageBox.Show("Access denied. You do not have permission to append to this file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBrowseFile_Click(sender As Object, e As EventArgs) Handles btnBrowseFile.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.InitialDirectory = "C:\"
        openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            txtFilePath.Text = openFileDialog.FileName
        End If
    End Sub
End Class

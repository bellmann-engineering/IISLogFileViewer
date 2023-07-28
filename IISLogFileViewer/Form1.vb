Public Class Form1
    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Log Files|*.log"
            openFileDialog.Title = "Open Log File"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim logFile As String = openFileDialog.FileName
                txtFile.Text = logFile

                Dim parser As New LogParser()
                Dim entries As List(Of LogEntry) = parser.ParseLogFile(logFile)

                ' Reduce entries to 100
                If entries.Count > 100 Then
                    entries = entries.GetRange(0, 100)
                End If

                lvEntries.Items.Clear()

                For Each entry In entries
                    Dim item As New ListViewItem(entry.DateTime.ToShortDateString())
                    item.SubItems.Add(entry.DateTime.ToShortTimeString())
                    item.SubItems.Add(entry.CsUriQuery)
                    item.SubItems.Add(entry.ScStatus.ToString())
                    lvEntries.Items.Add(item)
                Next
            End If
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvEntries.View = View.Details
        lvEntries.FullRowSelect = True

        lvEntries.Columns.Add("Date", 100)
        lvEntries.Columns.Add("Time", 100)
        lvEntries.Columns.Add("cs-uri-query", 200)
        lvEntries.Columns.Add("sc-status", -1)
    End Sub
End Class

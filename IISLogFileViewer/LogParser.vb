Imports System.Globalization
Imports System.IO

Public Class LogParser
    Public Function ParseLogFile(filePath As String, Optional filterTodayEntries As Boolean = False) As List(Of LogEntry)
        Dim logEntries As New List(Of LogEntry)()

        Dim currentDate As Date = Date.Now.Date ' Get the current date without the time

        Using reader As New StreamReader(filePath)
            Dim line As String = reader.ReadLine()

            ' Skip header lines
            While line IsNot Nothing AndAlso line.StartsWith("#")
                line = reader.ReadLine()
            End While

            While line IsNot Nothing
                ' Skip lines that start with "#" (header lines)
                If Not line.StartsWith("#") Then

                    Dim entry As LogEntry = LogEntry.CreateFromLogLine(line)

                    ' Check if the entry is from today (if filterTodayEntries is true)
                    If Not filterTodayEntries OrElse entry.DateTime.Date = currentDate Then
                        logEntries.Add(entry)
                    End If
                End If

                line = reader.ReadLine()
            End While
        End Using

        Return logEntries
    End Function



End Class

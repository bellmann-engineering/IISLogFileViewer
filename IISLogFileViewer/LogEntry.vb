Imports System.Globalization

Public Class LogEntry
    Public Property DateTime As DateTime
    Public Property CsUriQuery As String
    Public Property ScStatus As String

    Public Shared Function CreateFromLogLine(line As String) As LogEntry
        Dim fields As String() = line.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)

        Dim entry As New LogEntry()
        entry.DateTime = DateTime.ParseExact(fields(0) & " " & fields(1), "yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)
        entry.CsUriQuery = fields(3)
        entry.ScStatus = fields(6).Trim("""")

        Return entry
    End Function

End Class

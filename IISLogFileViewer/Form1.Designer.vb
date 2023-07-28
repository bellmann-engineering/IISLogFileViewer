<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnOpenFile = New Button()
        txtFile = New TextBox()
        lvEntries = New ListView()
        SuspendLayout()
        ' 
        ' btnOpenFile
        ' 
        btnOpenFile.Location = New Point(713, 12)
        btnOpenFile.Name = "btnOpenFile"
        btnOpenFile.Size = New Size(75, 23)
        btnOpenFile.TabIndex = 0
        btnOpenFile.Text = "..."
        btnOpenFile.UseVisualStyleBackColor = True
        ' 
        ' txtFile
        ' 
        txtFile.Location = New Point(12, 12)
        txtFile.Name = "txtFile"
        txtFile.ReadOnly = True
        txtFile.Size = New Size(695, 23)
        txtFile.TabIndex = 1
        ' 
        ' lvEntries
        ' 
        lvEntries.Location = New Point(12, 41)
        lvEntries.Name = "lvEntries"
        lvEntries.Size = New Size(776, 397)
        lvEntries.TabIndex = 2
        lvEntries.UseCompatibleStateImageBehavior = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lvEntries)
        Controls.Add(txtFile)
        Controls.Add(btnOpenFile)
        Name = "Form1"
        Text = "IIS Log File Viewer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnOpenFile As Button
    Friend WithEvents txtFile As TextBox
    Friend WithEvents lvEntries As ListView
End Class

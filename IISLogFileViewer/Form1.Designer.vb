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
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.lvEntries = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(1324, 26)
        Me.btnOpenFile.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(139, 49)
        Me.btnOpenFile.TabIndex = 0
        Me.btnOpenFile.Text = "..."
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(22, 26)
        Me.txtFile.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.ReadOnly = True
        Me.txtFile.Size = New System.Drawing.Size(1287, 39)
        Me.txtFile.TabIndex = 1
        '
        'lvEntries
        '
        Me.lvEntries.Location = New System.Drawing.Point(22, 87)
        Me.lvEntries.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lvEntries.Name = "lvEntries"
        Me.lvEntries.Size = New System.Drawing.Size(1438, 842)
        Me.lvEntries.TabIndex = 2
        Me.lvEntries.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1486, 960)
        Me.Controls.Add(Me.lvEntries)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form1"
        Me.Text = "IIS LogFile Viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpenFile As Button
    Friend WithEvents txtFile As TextBox
    Friend WithEvents lvEntries As ListView
End Class

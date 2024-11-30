<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.txtFileContent = New System.Windows.Forms.TextBox()
        Me.btnReadFile = New System.Windows.Forms.Button()
        Me.btnWriteFile = New System.Windows.Forms.Button()
        Me.btnAppendFile = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBrowseFile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File Path:"
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(117, 21)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(178, 20)
        Me.txtFilePath.TabIndex = 1
        '
        'txtFileContent
        '
        Me.txtFileContent.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileContent.Location = New System.Drawing.Point(16, 158)
        Me.txtFileContent.Multiline = True
        Me.txtFileContent.Name = "txtFileContent"
        Me.txtFileContent.Size = New System.Drawing.Size(567, 350)
        Me.txtFileContent.TabIndex = 2
        '
        'btnReadFile
        '
        Me.btnReadFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReadFile.Location = New System.Drawing.Point(48, 85)
        Me.btnReadFile.Name = "btnReadFile"
        Me.btnReadFile.Size = New System.Drawing.Size(115, 25)
        Me.btnReadFile.TabIndex = 3
        Me.btnReadFile.Text = "Read File"
        Me.btnReadFile.UseVisualStyleBackColor = True
        '
        'btnWriteFile
        '
        Me.btnWriteFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWriteFile.Location = New System.Drawing.Point(228, 85)
        Me.btnWriteFile.Name = "btnWriteFile"
        Me.btnWriteFile.Size = New System.Drawing.Size(111, 25)
        Me.btnWriteFile.TabIndex = 4
        Me.btnWriteFile.Text = "Write File"
        Me.btnWriteFile.UseVisualStyleBackColor = True
        '
        'btnAppendFile
        '
        Me.btnAppendFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppendFile.Location = New System.Drawing.Point(392, 85)
        Me.btnAppendFile.Name = "btnAppendFile"
        Me.btnAppendFile.Size = New System.Drawing.Size(131, 25)
        Me.btnAppendFile.TabIndex = 5
        Me.btnAppendFile.Text = "Append to File"
        Me.btnAppendFile.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(224, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "File Content"
        '
        'btnBrowseFile
        '
        Me.btnBrowseFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseFile.Location = New System.Drawing.Point(301, 21)
        Me.btnBrowseFile.Name = "btnBrowseFile"
        Me.btnBrowseFile.Size = New System.Drawing.Size(76, 25)
        Me.btnBrowseFile.TabIndex = 7
        Me.btnBrowseFile.Text = "Browse File"
        Me.btnBrowseFile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 520)
        Me.Controls.Add(Me.btnBrowseFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAppendFile)
        Me.Controls.Add(Me.btnWriteFile)
        Me.Controls.Add(Me.btnReadFile)
        Me.Controls.Add(Me.txtFileContent)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "R"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents txtFileContent As System.Windows.Forms.TextBox
    Friend WithEvents btnReadFile As System.Windows.Forms.Button
    Friend WithEvents btnWriteFile As System.Windows.Forms.Button
    Friend WithEvents btnAppendFile As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseFile As System.Windows.Forms.Button

End Class

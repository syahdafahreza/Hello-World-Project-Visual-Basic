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
        Me.textField1 = New System.Windows.Forms.TextBox()
        Me.btnCreateHelloWorld = New System.Windows.Forms.Button()
        Me.btnClearText = New System.Windows.Forms.Button()
        Me.btnShowStringDialog = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textField1
        '
        Me.textField1.Location = New System.Drawing.Point(13, 13)
        Me.textField1.Name = "textField1"
        Me.textField1.Size = New System.Drawing.Size(330, 22)
        Me.textField1.TabIndex = 0
        '
        'btnCreateHelloWorld
        '
        Me.btnCreateHelloWorld.AutoSize = True
        Me.btnCreateHelloWorld.Location = New System.Drawing.Point(13, 45)
        Me.btnCreateHelloWorld.Name = "btnCreateHelloWorld"
        Me.btnCreateHelloWorld.Size = New System.Drawing.Size(186, 27)
        Me.btnCreateHelloWorld.TabIndex = 1
        Me.btnCreateHelloWorld.Text = "Buatkan Saya Hello World"
        Me.btnCreateHelloWorld.UseVisualStyleBackColor = True
        '
        'btnClearText
        '
        Me.btnClearText.Location = New System.Drawing.Point(205, 45)
        Me.btnClearText.Name = "btnClearText"
        Me.btnClearText.Size = New System.Drawing.Size(138, 28)
        Me.btnClearText.TabIndex = 2
        Me.btnClearText.Text = "Hapus Teks Diatas"
        Me.btnClearText.UseVisualStyleBackColor = True
        '
        'btnShowStringDialog
        '
        Me.btnShowStringDialog.Location = New System.Drawing.Point(13, 79)
        Me.btnShowStringDialog.Name = "btnShowStringDialog"
        Me.btnShowStringDialog.Size = New System.Drawing.Size(330, 34)
        Me.btnShowStringDialog.TabIndex = 3
        Me.btnShowStringDialog.Text = "Tampilkan dialog tulisan diatas!"
        Me.btnShowStringDialog.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(360, 127)
        Me.Controls.Add(Me.btnShowStringDialog)
        Me.Controls.Add(Me.btnClearText)
        Me.Controls.Add(Me.btnCreateHelloWorld)
        Me.Controls.Add(Me.textField1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hello World Project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textField1 As TextBox
    Friend WithEvents btnCreateHelloWorld As Button
    Friend WithEvents btnClearText As Button
    Friend WithEvents btnShowStringDialog As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class window
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(window))
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.tbFileName = New System.Windows.Forms.TextBox()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.lblHash = New System.Windows.Forms.Label()
        Me.tbHash = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblMd5 = New System.Windows.Forms.Label()
        Me.tbMd5 = New System.Windows.Forms.TextBox()
        Me.lblSha1 = New System.Windows.Forms.Label()
        Me.lblSha256 = New System.Windows.Forms.Label()
        Me.tbSha1 = New System.Windows.Forms.TextBox()
        Me.tbSha256 = New System.Windows.Forms.TextBox()
        Me.fdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Location = New System.Drawing.Point(12, 9)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(34, 20)
        Me.lblFileName.TabIndex = 0
        Me.lblFileName.Text = "File"
        '
        'tbFileName
        '
        Me.tbFileName.Location = New System.Drawing.Point(52, 6)
        Me.tbFileName.Name = "tbFileName"
        Me.tbFileName.ReadOnly = True
        Me.tbFileName.Size = New System.Drawing.Size(577, 26)
        Me.tbFileName.TabIndex = 1
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(635, 6)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(93, 32)
        Me.btnOpenFile.TabIndex = 2
        Me.btnOpenFile.Text = "Open"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'lblHash
        '
        Me.lblHash.AutoSize = True
        Me.lblHash.Location = New System.Drawing.Point(12, 47)
        Me.lblHash.Name = "lblHash"
        Me.lblHash.Size = New System.Drawing.Size(47, 20)
        Me.lblHash.TabIndex = 3
        Me.lblHash.Text = "Hash"
        '
        'tbHash
        '
        Me.tbHash.Location = New System.Drawing.Point(65, 44)
        Me.tbHash.Name = "tbHash"
        Me.tbHash.Size = New System.Drawing.Size(564, 26)
        Me.tbHash.TabIndex = 4
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(635, 44)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(93, 33)
        Me.btnGenerate.TabIndex = 5
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lblMd5
        '
        Me.lblMd5.AutoSize = True
        Me.lblMd5.Location = New System.Drawing.Point(13, 89)
        Me.lblMd5.Name = "lblMd5"
        Me.lblMd5.Size = New System.Drawing.Size(47, 20)
        Me.lblMd5.TabIndex = 6
        Me.lblMd5.Text = "MD5:"
        '
        'tbMd5
        '
        Me.tbMd5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbMd5.Location = New System.Drawing.Point(93, 83)
        Me.tbMd5.Name = "tbMd5"
        Me.tbMd5.ReadOnly = True
        Me.tbMd5.Size = New System.Drawing.Size(633, 26)
        Me.tbMd5.TabIndex = 7
        '
        'lblSha1
        '
        Me.lblSha1.AutoSize = True
        Me.lblSha1.Location = New System.Drawing.Point(12, 120)
        Me.lblSha1.Name = "lblSha1"
        Me.lblSha1.Size = New System.Drawing.Size(56, 20)
        Me.lblSha1.TabIndex = 8
        Me.lblSha1.Text = "SHA1:"
        '
        'lblSha256
        '
        Me.lblSha256.AutoSize = True
        Me.lblSha256.Location = New System.Drawing.Point(13, 156)
        Me.lblSha256.Name = "lblSha256"
        Me.lblSha256.Size = New System.Drawing.Size(74, 20)
        Me.lblSha256.TabIndex = 9
        Me.lblSha256.Text = "SHA256:"
        '
        'tbSha1
        '
        Me.tbSha1.Location = New System.Drawing.Point(93, 120)
        Me.tbSha1.Name = "tbSha1"
        Me.tbSha1.ReadOnly = True
        Me.tbSha1.Size = New System.Drawing.Size(633, 26)
        Me.tbSha1.TabIndex = 10
        '
        'tbSha256
        '
        Me.tbSha256.Location = New System.Drawing.Point(93, 154)
        Me.tbSha256.Name = "tbSha256"
        Me.tbSha256.ReadOnly = True
        Me.tbSha256.Size = New System.Drawing.Size(633, 26)
        Me.tbSha256.TabIndex = 11
        '
        'fdOpen
        '
        Me.fdOpen.Title = "Open File"
        '
        'window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 191)
        Me.Controls.Add(Me.tbSha256)
        Me.Controls.Add(Me.tbSha1)
        Me.Controls.Add(Me.lblSha256)
        Me.Controls.Add(Me.lblSha1)
        Me.Controls.Add(Me.tbMd5)
        Me.Controls.Add(Me.lblMd5)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.tbHash)
        Me.Controls.Add(Me.lblHash)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.tbFileName)
        Me.Controls.Add(Me.lblFileName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "window"
        Me.Text = "Hash Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFileName As Label
    Friend WithEvents tbFileName As TextBox
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents lblHash As Label
    Friend WithEvents tbHash As TextBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblMd5 As Label
    Friend WithEvents tbMd5 As TextBox
    Friend WithEvents lblSha1 As Label
    Friend WithEvents lblSha256 As Label
    Friend WithEvents tbSha1 As TextBox
    Friend WithEvents tbSha256 As TextBox
    Friend WithEvents fdOpen As OpenFileDialog
End Class

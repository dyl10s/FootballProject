<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDraft
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
        Me.ofdBrowseDraft = New System.Windows.Forms.OpenFileDialog()
        Me.pStart = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPlayers = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDraftRounds = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pDraft = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblCurrentUser = New System.Windows.Forms.Label()
        Me.pStart.SuspendLayout()
        Me.pDraft.SuspendLayout()
        Me.SuspendLayout()
        '
        'ofdBrowseDraft
        '
        Me.ofdBrowseDraft.FileName = "OpenFileDialog1"
        '
        'pStart
        '
        Me.pStart.Controls.Add(Me.Button1)
        Me.pStart.Controls.Add(Me.btnBrowse)
        Me.pStart.Controls.Add(Me.txtFile)
        Me.pStart.Controls.Add(Me.Label3)
        Me.pStart.Controls.Add(Me.txtPlayers)
        Me.pStart.Controls.Add(Me.Label2)
        Me.pStart.Controls.Add(Me.txtDraftRounds)
        Me.pStart.Controls.Add(Me.Label1)
        Me.pStart.Dock = System.Windows.Forms.DockStyle.Top
        Me.pStart.Location = New System.Drawing.Point(0, 0)
        Me.pStart.Name = "pStart"
        Me.pStart.Size = New System.Drawing.Size(299, 185)
        Me.pStart.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(270, 68)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Start Draft"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(225, 62)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(62, 21)
        Me.btnBrowse.TabIndex = 14
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(121, 62)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(98, 20)
        Me.txtFile.TabIndex = 13
        Me.txtFile.Text = "Draft.txt"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Draft File: "
        '
        'txtPlayers
        '
        Me.txtPlayers.Location = New System.Drawing.Point(121, 36)
        Me.txtPlayers.Name = "txtPlayers"
        Me.txtPlayers.Size = New System.Drawing.Size(166, 20)
        Me.txtPlayers.TabIndex = 11
        Me.txtPlayers.Text = "2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Number of Players: "
        '
        'txtDraftRounds
        '
        Me.txtDraftRounds.Location = New System.Drawing.Point(121, 10)
        Me.txtDraftRounds.Name = "txtDraftRounds"
        Me.txtDraftRounds.Size = New System.Drawing.Size(166, 20)
        Me.txtDraftRounds.TabIndex = 9
        Me.txtDraftRounds.Text = "5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Draft Rounds: "
        '
        'pDraft
        '
        Me.pDraft.Controls.Add(Me.Button2)
        Me.pDraft.Controls.Add(Me.ListBox1)
        Me.pDraft.Controls.Add(Me.lblCurrentUser)
        Me.pDraft.Dock = System.Windows.Forms.DockStyle.Top
        Me.pDraft.Location = New System.Drawing.Point(0, 185)
        Me.pDraft.Name = "pDraft"
        Me.pDraft.Size = New System.Drawing.Size(299, 185)
        Me.pDraft.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Location = New System.Drawing.Point(0, 151)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(299, 34)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Select Player"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 30)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(299, 121)
        Me.ListBox1.TabIndex = 9
        '
        'lblCurrentUser
        '
        Me.lblCurrentUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCurrentUser.Location = New System.Drawing.Point(0, 0)
        Me.lblCurrentUser.Name = "lblCurrentUser"
        Me.lblCurrentUser.Size = New System.Drawing.Size(299, 30)
        Me.lblCurrentUser.TabIndex = 8
        Me.lblCurrentUser.Text = "Current User: Player 1"
        Me.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDraft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 185)
        Me.Controls.Add(Me.pDraft)
        Me.Controls.Add(Me.pStart)
        Me.Name = "frmDraft"
        Me.Text = "Draft"
        Me.pStart.ResumeLayout(False)
        Me.pStart.PerformLayout()
        Me.pDraft.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ofdBrowseDraft As OpenFileDialog
    Friend WithEvents pStart As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtFile As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPlayers As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDraftRounds As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pDraft As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblCurrentUser As Label
End Class

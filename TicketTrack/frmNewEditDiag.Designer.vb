<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewEditDiag
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtInc = New System.Windows.Forms.TextBox()
        Me.txtSummary = New System.Windows.Forms.TextBox()
        Me.txtAssign = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.chkComplete = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbRelate = New System.Windows.Forms.ComboBox()
        Me.chkFix = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCreatedDate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(13, 265)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(95, 265)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtInc
        '
        Me.txtInc.Location = New System.Drawing.Point(89, 12)
        Me.txtInc.Name = "txtInc"
        Me.txtInc.Size = New System.Drawing.Size(161, 20)
        Me.txtInc.TabIndex = 2
        '
        'txtSummary
        '
        Me.txtSummary.Location = New System.Drawing.Point(89, 38)
        Me.txtSummary.Name = "txtSummary"
        Me.txtSummary.Size = New System.Drawing.Size(351, 20)
        Me.txtSummary.TabIndex = 3
        '
        'txtAssign
        '
        Me.txtAssign.Location = New System.Drawing.Point(89, 64)
        Me.txtAssign.Name = "txtAssign"
        Me.txtAssign.Size = New System.Drawing.Size(258, 20)
        Me.txtAssign.TabIndex = 4
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(89, 138)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(350, 98)
        Me.txtNotes.TabIndex = 6
        '
        'chkComplete
        '
        Me.chkComplete.AutoSize = True
        Me.chkComplete.Location = New System.Drawing.Point(256, 14)
        Me.chkComplete.Name = "chkComplete"
        Me.chkComplete.Size = New System.Drawing.Size(76, 17)
        Me.chkComplete.TabIndex = 7
        Me.chkComplete.Text = "Completed"
        Me.chkComplete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Incident ID *:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Summary *:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Assignment *:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-2, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Relationship *:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Fix Link / Notes:"
        '
        'cmbRelate
        '
        Me.cmbRelate.AutoCompleteCustomSource.AddRange(New String() {"Duplicate of", "Original of", "Related to", "Caused", "Caused by", "Resolved by", "Resolved"})
        Me.cmbRelate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRelate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRelate.FormattingEnabled = True
        Me.cmbRelate.Items.AddRange(New Object() {"Duplicate of", "Original of", "Related to", "Caused", "Caused by", "Resolved by", "Resolved"})
        Me.cmbRelate.Location = New System.Drawing.Point(89, 90)
        Me.cmbRelate.Name = "cmbRelate"
        Me.cmbRelate.Size = New System.Drawing.Size(257, 21)
        Me.cmbRelate.TabIndex = 5
        Me.cmbRelate.Text = "Duplicate of"
        '
        'chkFix
        '
        Me.chkFix.AutoSize = True
        Me.chkFix.Location = New System.Drawing.Point(89, 115)
        Me.chkFix.Name = "chkFix"
        Me.chkFix.Size = New System.Drawing.Size(51, 17)
        Me.chkFix.TabIndex = 13
        Me.chkFix.Text = "Fixed"
        Me.chkFix.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(331, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "* = Required Field"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Created Date:"
        '
        'txtCreatedDate
        '
        Me.txtCreatedDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCreatedDate.Location = New System.Drawing.Point(89, 242)
        Me.txtCreatedDate.Name = "txtCreatedDate"
        Me.txtCreatedDate.ReadOnly = True
        Me.txtCreatedDate.Size = New System.Drawing.Size(161, 13)
        Me.txtCreatedDate.TabIndex = 16
        '
        'frmNewEditDiag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCreatedDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkFix)
        Me.Controls.Add(Me.cmbRelate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkComplete)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtAssign)
        Me.Controls.Add(Me.txtSummary)
        Me.Controls.Add(Me.txtInc)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewEditDiag"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNewEditDiag"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtInc As System.Windows.Forms.TextBox
    Friend WithEvents txtSummary As System.Windows.Forms.TextBox
    Friend WithEvents txtAssign As System.Windows.Forms.TextBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents chkComplete As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbRelate As System.Windows.Forms.ComboBox
    Friend WithEvents chkFix As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCreatedDate As System.Windows.Forms.TextBox
End Class

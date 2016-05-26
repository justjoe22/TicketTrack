<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicket_SQL_R2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicket_SQL_R2))
        Me.tblTicketLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTicketNo = New System.Windows.Forms.Label()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.lblAssignment = New System.Windows.Forms.Label()
        Me.lblRelationship = New System.Windows.Forms.Label()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.lblReference = New System.Windows.Forms.Label()
        Me.lblComplete = New System.Windows.Forms.Label()
        Me.lblCreated = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tblTicketLayout
        '
        Me.tblTicketLayout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblTicketLayout.AutoScroll = True
        Me.tblTicketLayout.AutoSize = True
        Me.tblTicketLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tblTicketLayout.ColumnCount = 8
        Me.tblTicketLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tblTicketLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tblTicketLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tblTicketLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tblTicketLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tblTicketLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tblTicketLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tblTicketLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblTicketLayout.Location = New System.Drawing.Point(12, 77)
        Me.tblTicketLayout.Name = "tblTicketLayout"
        Me.tblTicketLayout.RowCount = 4
        Me.tblTicketLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tblTicketLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tblTicketLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tblTicketLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tblTicketLayout.Size = New System.Drawing.Size(887, 125)
        Me.tblTicketLayout.TabIndex = 0
        '
        'lblTicketNo
        '
        Me.lblTicketNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTicketNo.AutoEllipsis = True
        Me.lblTicketNo.AutoSize = True
        Me.lblTicketNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketNo.Location = New System.Drawing.Point(15, 61)
        Me.lblTicketNo.Name = "lblTicketNo"
        Me.lblTicketNo.Size = New System.Drawing.Size(55, 13)
        Me.lblTicketNo.TabIndex = 1
        Me.lblTicketNo.Text = "Ticket #"
        '
        'lblSummary
        '
        Me.lblSummary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSummary.AutoEllipsis = True
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummary.Location = New System.Drawing.Point(136, 61)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(57, 13)
        Me.lblSummary.TabIndex = 2
        Me.lblSummary.Text = "Summary"
        '
        'lblAssignment
        '
        Me.lblAssignment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAssignment.AutoEllipsis = True
        Me.lblAssignment.AutoSize = True
        Me.lblAssignment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignment.Location = New System.Drawing.Point(277, 61)
        Me.lblAssignment.Name = "lblAssignment"
        Me.lblAssignment.Size = New System.Drawing.Size(71, 13)
        Me.lblAssignment.TabIndex = 3
        Me.lblAssignment.Text = "Assignment"
        '
        'lblRelationship
        '
        Me.lblRelationship.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRelationship.AutoEllipsis = True
        Me.lblRelationship.AutoSize = True
        Me.lblRelationship.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRelationship.Location = New System.Drawing.Point(378, 61)
        Me.lblRelationship.Name = "lblRelationship"
        Me.lblRelationship.Size = New System.Drawing.Size(77, 13)
        Me.lblRelationship.TabIndex = 4
        Me.lblRelationship.Text = "Relationship"
        '
        'lblNotes
        '
        Me.lblNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNotes.AutoEllipsis = True
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.Location = New System.Drawing.Point(479, 61)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(40, 13)
        Me.lblNotes.TabIndex = 5
        Me.lblNotes.Text = "Notes"
        '
        'lblReference
        '
        Me.lblReference.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReference.AutoEllipsis = True
        Me.lblReference.AutoSize = True
        Me.lblReference.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReference.Location = New System.Drawing.Point(600, 61)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(66, 13)
        Me.lblReference.TabIndex = 6
        Me.lblReference.Text = "Reference"
        '
        'lblComplete
        '
        Me.lblComplete.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblComplete.AutoEllipsis = True
        Me.lblComplete.AutoSize = True
        Me.lblComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplete.Location = New System.Drawing.Point(681, 61)
        Me.lblComplete.Name = "lblComplete"
        Me.lblComplete.Size = New System.Drawing.Size(59, 13)
        Me.lblComplete.TabIndex = 7
        Me.lblComplete.Text = "Complete"
        '
        'lblCreated
        '
        Me.lblCreated.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCreated.AutoEllipsis = True
        Me.lblCreated.AutoSize = True
        Me.lblCreated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreated.Location = New System.Drawing.Point(762, 61)
        Me.lblCreated.Name = "lblCreated"
        Me.lblCreated.Size = New System.Drawing.Size(51, 13)
        Me.lblCreated.TabIndex = 8
        Me.lblCreated.Text = "Created"
        '
        'frmTicket_SQL_R2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 214)
        Me.Controls.Add(Me.lblCreated)
        Me.Controls.Add(Me.lblComplete)
        Me.Controls.Add(Me.lblReference)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.lblRelationship)
        Me.Controls.Add(Me.lblAssignment)
        Me.Controls.Add(Me.lblTicketNo)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.tblTicketLayout)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTicket_SQL_R2"
        Me.Text = "TicketTrack"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tblTicketLayout As TableLayoutPanel
    Friend WithEvents lblTicketNo As Label
    Friend WithEvents lblSummary As Label
    Friend WithEvents lblAssignment As Label
    Friend WithEvents lblRelationship As Label
    Friend WithEvents lblNotes As Label
    Friend WithEvents lblReference As Label
    Friend WithEvents lblComplete As Label
    Friend WithEvents lblCreated As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketSQL
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicketSQL))
        Me.dgSQL = New System.Windows.Forms.DataGridView()
        Me.CopyMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbView = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.time_track = New System.Windows.Forms.Timer(Me.components)
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtRecordCt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CopyMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgSQL
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgSQL.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgSQL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgSQL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgSQL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgSQL.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSQL.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgSQL.ContextMenuStrip = Me.CopyMenu
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSQL.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgSQL.Location = New System.Drawing.Point(12, 40)
        Me.dgSQL.MultiSelect = False
        Me.dgSQL.Name = "dgSQL"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSQL.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgSQL.Size = New System.Drawing.Size(794, 106)
        Me.dgSQL.TabIndex = 1
        '
        'CopyMenu
        '
        Me.CopyMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopy, Me.mnuDelete})
        Me.CopyMenu.Name = "CopyMenu"
        Me.CopyMenu.ShowImageMargin = False
        Me.CopyMenu.Size = New System.Drawing.Size(128, 70)
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeyDisplayString = "Ctrl+C"
        Me.mnuCopy.Size = New System.Drawing.Size(127, 22)
        Me.mnuCopy.Text = "&Copy"
        '
        'mnuDelete
        '
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.mnuDelete.Size = New System.Drawing.Size(127, 22)
        Me.mnuDelete.Text = "&Delete"
        '
        'cmbView
        '
        Me.cmbView.Items.AddRange(New Object() {"Open Tickets", "Reference Tickets", "Completed Tickets"})
        Me.cmbView.Location = New System.Drawing.Point(53, 13)
        Me.cmbView.Name = "cmbView"
        Me.cmbView.Size = New System.Drawing.Size(121, 21)
        Me.cmbView.TabIndex = 0
        Me.cmbView.Text = "Open Tickets"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "View:"
        '
        'time_track
        '
        Me.time_track.Interval = 60
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Location = New System.Drawing.Point(731, 11)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'txtRecordCt
        '
        Me.txtRecordCt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecordCt.BackColor = System.Drawing.SystemColors.Control
        Me.txtRecordCt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRecordCt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecordCt.ForeColor = System.Drawing.Color.Red
        Me.txtRecordCt.Location = New System.Drawing.Point(625, 16)
        Me.txtRecordCt.Name = "txtRecordCt"
        Me.txtRecordCt.Size = New System.Drawing.Size(100, 13)
        Me.txtRecordCt.TabIndex = 4
        Me.txtRecordCt.Text = "0"
        Me.txtRecordCt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtRecordCt.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Reference = Any Ticket that is FYI and not an active issue."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(180, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(243, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Complete = Any Ticket that is Resolved or Closed."
        '
        'frmTicketSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 158)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtRecordCt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbView)
        Me.Controls.Add(Me.dgSQL)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTicketSQL"
        Me.Text = "TicketTrack"
        CType(Me.dgSQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CopyMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgSQL As System.Windows.Forms.DataGridView
    'Friend WithEvents TblTicketBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmbView As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CopyMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents time_track As System.Windows.Forms.Timer
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    'Friend WithEvents ITT00501_PT_TICKT_MSTTableAdapter As Global.TicketTrack.dbTickets_sql_dsTableAdapters.ITT00501_PT_TICKT_MSTTableAdapter
    'Friend WithEvents dbTickets_sql_ds As Global.TicketTrack.dbTickets_sql_ds
    'Friend WithEvents TableAdapterManager As Global.TicketTrack.dbTickets_sql_dsTableAdapters.TableAdapterManager
    Friend WithEvents txtRecordCt As System.Windows.Forms.TextBox
    'Friend WithEvents ITT00501PTTICKTMSTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents INCDNTIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SUMMDESCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ASSGNIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RLATETXTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents NOTEDESCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIXFLGDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CMPLTFLGDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CREATDTMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

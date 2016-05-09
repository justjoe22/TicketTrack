<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicketMain))
        Me.dgTicket = New System.Windows.Forms.DataGridView()
        Me.IncIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SummaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RelationshipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FixDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompleteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CreatedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CopyMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.TblTicketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbTicketDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbTicketDataSet = New TicketTrack.dbTicketDataSet()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.time_track = New System.Windows.Forms.Timer(Me.components)
        Me.chkAutoR = New System.Windows.Forms.CheckBox()
        Me.txtInt = New System.Windows.Forms.TextBox()
        Me.TblTicketTableAdapter = New TicketTrack.dbTicketDataSetTableAdapters.tblTicketTableAdapter()
        Me.btnArchive = New System.Windows.Forms.Button()
        CType(Me.dgTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CopyMenu.SuspendLayout()
        CType(Me.TblTicketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbTicketDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbTicketDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgTicket
        '
        Me.dgTicket.AllowUserToAddRows = False
        Me.dgTicket.AllowUserToDeleteRows = False
        Me.dgTicket.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgTicket.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgTicket.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTicket.AutoGenerateColumns = False
        Me.dgTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTicket.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IncIdDataGridViewTextBoxColumn, Me.SummaryDataGridViewTextBoxColumn, Me.AssignmentDataGridViewTextBoxColumn, Me.RelationshipDataGridViewTextBoxColumn, Me.FixDataGridViewCheckBoxColumn, Me.NotesDataGridViewTextBoxColumn, Me.CompleteDataGridViewCheckBoxColumn, Me.CreatedDateDataGridViewTextBoxColumn})
        Me.dgTicket.ContextMenuStrip = Me.CopyMenu
        Me.dgTicket.DataSource = Me.TblTicketBindingSource
        Me.dgTicket.Location = New System.Drawing.Point(12, 12)
        Me.dgTicket.Name = "dgTicket"
        Me.dgTicket.ReadOnly = True
        Me.dgTicket.Size = New System.Drawing.Size(768, 120)
        Me.dgTicket.TabIndex = 0
        '
        'IncIdDataGridViewTextBoxColumn
        '
        Me.IncIdDataGridViewTextBoxColumn.DataPropertyName = "IncId"
        Me.IncIdDataGridViewTextBoxColumn.HeaderText = "Incident ID"
        Me.IncIdDataGridViewTextBoxColumn.Name = "IncIdDataGridViewTextBoxColumn"
        Me.IncIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SummaryDataGridViewTextBoxColumn
        '
        Me.SummaryDataGridViewTextBoxColumn.DataPropertyName = "Summary"
        Me.SummaryDataGridViewTextBoxColumn.HeaderText = "Summary"
        Me.SummaryDataGridViewTextBoxColumn.Name = "SummaryDataGridViewTextBoxColumn"
        Me.SummaryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AssignmentDataGridViewTextBoxColumn
        '
        Me.AssignmentDataGridViewTextBoxColumn.DataPropertyName = "Assignment"
        Me.AssignmentDataGridViewTextBoxColumn.HeaderText = "Assignment"
        Me.AssignmentDataGridViewTextBoxColumn.Name = "AssignmentDataGridViewTextBoxColumn"
        Me.AssignmentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RelationshipDataGridViewTextBoxColumn
        '
        Me.RelationshipDataGridViewTextBoxColumn.DataPropertyName = "Relationship"
        Me.RelationshipDataGridViewTextBoxColumn.HeaderText = "Relationship"
        Me.RelationshipDataGridViewTextBoxColumn.Name = "RelationshipDataGridViewTextBoxColumn"
        Me.RelationshipDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FixDataGridViewCheckBoxColumn
        '
        Me.FixDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.FixDataGridViewCheckBoxColumn.DataPropertyName = "Fix"
        Me.FixDataGridViewCheckBoxColumn.HeaderText = "Fixed"
        Me.FixDataGridViewCheckBoxColumn.Name = "FixDataGridViewCheckBoxColumn"
        Me.FixDataGridViewCheckBoxColumn.ReadOnly = True
        Me.FixDataGridViewCheckBoxColumn.Width = 38
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Fix Link/Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        Me.NotesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CompleteDataGridViewCheckBoxColumn
        '
        Me.CompleteDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CompleteDataGridViewCheckBoxColumn.DataPropertyName = "Complete"
        Me.CompleteDataGridViewCheckBoxColumn.HeaderText = "Complete"
        Me.CompleteDataGridViewCheckBoxColumn.Name = "CompleteDataGridViewCheckBoxColumn"
        Me.CompleteDataGridViewCheckBoxColumn.ReadOnly = True
        Me.CompleteDataGridViewCheckBoxColumn.Width = 57
        '
        'CreatedDateDataGridViewTextBoxColumn
        '
        Me.CreatedDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate"
        Me.CreatedDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate"
        Me.CreatedDateDataGridViewTextBoxColumn.Name = "CreatedDateDataGridViewTextBoxColumn"
        Me.CreatedDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreatedDateDataGridViewTextBoxColumn.Visible = False
        '
        'CopyMenu
        '
        Me.CopyMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopy})
        Me.CopyMenu.Name = "CopyMenu"
        Me.CopyMenu.ShowImageMargin = False
        Me.CopyMenu.Size = New System.Drawing.Size(120, 26)
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopy.Size = New System.Drawing.Size(119, 22)
        Me.mnuCopy.Text = "&Copy"
        '
        'TblTicketBindingSource
        '
        Me.TblTicketBindingSource.DataMember = "tblTicket"
        Me.TblTicketBindingSource.DataSource = Me.DbTicketDataSetBindingSource
        '
        'DbTicketDataSetBindingSource
        '
        Me.DbTicketDataSetBindingSource.DataSource = Me.DbTicketDataSet
        Me.DbTicketDataSetBindingSource.Position = 0
        '
        'DbTicketDataSet
        '
        Me.DbTicketDataSet.DataSetName = "dbTicketDataSet"
        Me.DbTicketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Location = New System.Drawing.Point(704, 138)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'chkAll
        '
        Me.chkAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(631, 142)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(67, 17)
        Me.chkAll.TabIndex = 3
        Me.chkAll.Text = "Show All"
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(13, 138)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Location = New System.Drawing.Point(95, 138)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'time_track
        '
        Me.time_track.Interval = 60
        '
        'chkAutoR
        '
        Me.chkAutoR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAutoR.AutoSize = True
        Me.chkAutoR.Location = New System.Drawing.Point(490, 142)
        Me.chkAutoR.Name = "chkAutoR"
        Me.chkAutoR.Size = New System.Drawing.Size(88, 17)
        Me.chkAutoR.TabIndex = 6
        Me.chkAutoR.Text = "Auto-Refresh"
        Me.chkAutoR.UseVisualStyleBackColor = True
        Me.chkAutoR.Visible = False
        '
        'txtInt
        '
        Me.txtInt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInt.Location = New System.Drawing.Point(584, 140)
        Me.txtInt.MaxLength = 2
        Me.txtInt.Name = "txtInt"
        Me.txtInt.Size = New System.Drawing.Size(26, 20)
        Me.txtInt.TabIndex = 7
        Me.txtInt.Text = "60"
        Me.txtInt.Visible = False
        '
        'TblTicketTableAdapter
        '
        Me.TblTicketTableAdapter.ClearBeforeFill = True
        '
        'btnArchive
        '
        Me.btnArchive.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnArchive.Location = New System.Drawing.Point(176, 138)
        Me.btnArchive.Name = "btnArchive"
        Me.btnArchive.Size = New System.Drawing.Size(100, 23)
        Me.btnArchive.TabIndex = 8
        Me.btnArchive.Text = "View &Archive"
        Me.btnArchive.UseVisualStyleBackColor = True
        '
        'frmTicketMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 173)
        Me.Controls.Add(Me.btnArchive)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtInt)
        Me.Controls.Add(Me.chkAutoR)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.dgTicket)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 200)
        Me.Name = "frmTicketMain"
        Me.Text = "TicketTrack"
        CType(Me.dgTicket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CopyMenu.ResumeLayout(False)
        CType(Me.TblTicketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbTicketDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbTicketDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgTicket As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents time_track As System.Windows.Forms.Timer
    Friend WithEvents chkAutoR As System.Windows.Forms.CheckBox
    Friend WithEvents txtInt As System.Windows.Forms.TextBox
    Friend WithEvents DbTicketDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbTicketDataSet As TicketTrack.dbTicketDataSet
    Friend WithEvents TblTicketBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTicketTableAdapter As TicketTrack.dbTicketDataSetTableAdapters.tblTicketTableAdapter
    Friend WithEvents btnArchive As System.Windows.Forms.Button
    Friend WithEvents IncIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SummaryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AssignmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RelationshipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FixDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompleteDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CreatedDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CopyMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuCopy As System.Windows.Forms.ToolStripMenuItem

End Class

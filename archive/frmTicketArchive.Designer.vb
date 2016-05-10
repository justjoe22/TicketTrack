<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketArchive
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicketArchive))
        Me.dgTicket = New System.Windows.Forms.DataGridView()
        Me.TblArchiveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbArchiveDataSet = New TicketTrack.dbArchiveDataSet()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.TblArchiveTableAdapter = New TicketTrack.dbArchiveDataSetTableAdapters.tblArchiveTableAdapter()
        Me.btnPurge = New System.Windows.Forms.Button()
        Me.IncIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Purge = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SummaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RelationshipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FixDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompleteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CreatedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblArchiveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbArchiveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgTicket.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IncIdDataGridViewTextBoxColumn, Me.Purge, Me.SummaryDataGridViewTextBoxColumn, Me.AssignmentDataGridViewTextBoxColumn, Me.RelationshipDataGridViewTextBoxColumn, Me.FixDataGridViewCheckBoxColumn, Me.NotesDataGridViewTextBoxColumn, Me.CompleteDataGridViewCheckBoxColumn, Me.CreatedDate})
        Me.dgTicket.DataSource = Me.TblArchiveBindingSource
        Me.dgTicket.Location = New System.Drawing.Point(12, 12)
        Me.dgTicket.Name = "dgTicket"
        Me.dgTicket.ReadOnly = True
        Me.dgTicket.Size = New System.Drawing.Size(936, 371)
        Me.dgTicket.TabIndex = 0
        '
        'TblArchiveBindingSource
        '
        Me.TblArchiveBindingSource.DataMember = "tblArchive"
        Me.TblArchiveBindingSource.DataSource = Me.DbArchiveDataSet
        '
        'DbArchiveDataSet
        '
        Me.DbArchiveDataSet.DataSetName = "dbArchiveDataSet"
        Me.DbArchiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Location = New System.Drawing.Point(12, 389)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'TblArchiveTableAdapter
        '
        Me.TblArchiveTableAdapter.ClearBeforeFill = True
        '
        'btnPurge
        '
        Me.btnPurge.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPurge.Location = New System.Drawing.Point(93, 389)
        Me.btnPurge.Name = "btnPurge"
        Me.btnPurge.Size = New System.Drawing.Size(75, 23)
        Me.btnPurge.TabIndex = 6
        Me.btnPurge.Text = "&Purge"
        Me.btnPurge.UseVisualStyleBackColor = True
        '
        'IncIdDataGridViewTextBoxColumn
        '
        Me.IncIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IncIdDataGridViewTextBoxColumn.DataPropertyName = "IncId"
        Me.IncIdDataGridViewTextBoxColumn.HeaderText = "Incident ID"
        Me.IncIdDataGridViewTextBoxColumn.Name = "IncIdDataGridViewTextBoxColumn"
        Me.IncIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IncIdDataGridViewTextBoxColumn.Width = 84
        '
        'Purge
        '
        Me.Purge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Purge.DataPropertyName = "Purge"
        Me.Purge.HeaderText = "Purge"
        Me.Purge.Name = "Purge"
        Me.Purge.ReadOnly = True
        Me.Purge.Width = 41
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
        Me.FixDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
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
        Me.CompleteDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CompleteDataGridViewCheckBoxColumn.DataPropertyName = "Complete"
        Me.CompleteDataGridViewCheckBoxColumn.HeaderText = "Complete"
        Me.CompleteDataGridViewCheckBoxColumn.Name = "CompleteDataGridViewCheckBoxColumn"
        Me.CompleteDataGridViewCheckBoxColumn.ReadOnly = True
        Me.CompleteDataGridViewCheckBoxColumn.Width = 57
        '
        'CreatedDate
        '
        Me.CreatedDate.DataPropertyName = "CreatedDate"
        Me.CreatedDate.HeaderText = "CreatedDate"
        Me.CreatedDate.Name = "CreatedDate"
        Me.CreatedDate.ReadOnly = True
        Me.CreatedDate.Visible = False
        '
        'frmTicketArchive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 424)
        Me.Controls.Add(Me.btnPurge)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.dgTicket)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 200)
        Me.Name = "frmTicketArchive"
        Me.Text = "TicketTrack - Archive"
        CType(Me.dgTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblArchiveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbArchiveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgTicket As System.Windows.Forms.DataGridView
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents DbArchiveDataSet As TicketTrack.dbArchiveDataSet
    Friend WithEvents TblArchiveBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblArchiveTableAdapter As TicketTrack.dbArchiveDataSetTableAdapters.tblArchiveTableAdapter
    Friend WithEvents btnPurge As System.Windows.Forms.Button
    Friend WithEvents IncIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Purge As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SummaryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AssignmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RelationshipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FixDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompleteDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CreatedDate As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

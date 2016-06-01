
Public Class frmTicketArchive

    Private Sub frmTicketArchive_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'TODO: This line of code loads data into the 'DbTicketDataSet.tblTicket' table. You can move, or remove it, as needed.
        Me.TblArchiveTableAdapter.Fill(Me.DbArchiveDataSet.tblArchive)

        If Me.dgTicket.RowCount > 0 Then
            Me.btnEdit.Enabled = True
        Else
            Me.btnEdit.Enabled = False
        End If

    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        frmNewEditArchive.Show()
        frmNewEditArchive.Text = "Edit Archive Ticket: " & Me.dgTicket.CurrentRow.Cells.Item(0).Value.ToString

        frmNewEditArchive.txtInc.Text = Me.dgTicket.CurrentRow.Cells.Item(0).Value.ToString
        frmNewEditArchive.txtInc.ReadOnly = True

        frmNewEditArchive.chkPurge.Checked = Me.dgTicket.CurrentRow.Cells.Item(1).Value.ToString

        frmNewEditArchive.txtSummary.Text = Me.dgTicket.CurrentRow.Cells.Item(2).Value.ToString
        frmNewEditArchive.txtSummary.ReadOnly = True

        frmNewEditArchive.txtAssign.Text = Me.dgTicket.CurrentRow.Cells.Item(3).Value.ToString
        frmNewEditArchive.txtAssign.ReadOnly = True

        frmNewEditArchive.cmbRelate.SelectedItem = Me.dgTicket.CurrentRow.Cells.Item(4).Value.ToString
        frmNewEditArchive.cmbRelate.Enabled = False

        frmNewEditArchive.chkFix.Checked = Me.dgTicket.CurrentRow.Cells.Item(5).Value.ToString
        frmNewEditArchive.chkFix.Enabled = False

        frmNewEditArchive.txtNotes.Text = Me.dgTicket.CurrentRow.Cells.Item(6).Value.ToString
        frmNewEditArchive.txtNotes.ReadOnly = True

        frmNewEditArchive.chkComplete.Checked = Me.dgTicket.CurrentRow.Cells.Item(7).Value.ToString
        frmNewEditArchive.chkComplete.Enabled = False

        frmNewEditArchive.txtCreatedDate.Text = Me.dgTicket.CurrentRow.Cells.Item(8).Value.ToString

    End Sub

    Private Sub dgTicket_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTicket.CellDoubleClick
        Dim URL As String = "", Place As Integer = 0

        'If Me.dgTicket.SelectedCells.Item(0).Value = Me.dgTicket.CurrentRow.Cells.Item(5).Value And Me.dgTicket.CurrentRow.Cells.Item(4).Value = True Then
        '    URL = Me.dgTicket.CurrentRow.Cells.Item(5).Value.ToString
        '    Place = InStr(URL, "http://", vbTextCompare)

        '    If Place > 0 Then
        '        URL = Microsoft.VisualBasic.Right(URL, Len(URL) - Place + 1).Trim

        '        Place = InStr(URL, Environment.NewLine, vbTextCompare)
        '        If Place > 0 Then
        '            URL = Microsoft.VisualBasic.Left(URL, Place - 1).Trim
        '        Else
        '            Place = InStr(URL, " ", vbTextCompare)
        '            If Place > 0 Then
        '                URL = Microsoft.VisualBasic.Left(URL, Place - 1).Trim
        '            End If
        '        End If


        '        System.Diagnostics.Process.Start(URL)
        '    End If
        'Else

        frmNewEditArchive.Show()
        frmNewEditArchive.Text = "Edit Archive Ticket: " & Me.dgTicket.CurrentRow.Cells.Item(0).Value.ToString

        frmNewEditArchive.txtInc.Text = Me.dgTicket.CurrentRow.Cells.Item(0).Value.ToString
        frmNewEditArchive.txtInc.ReadOnly = True

        frmNewEditArchive.chkPurge.Checked = Me.dgTicket.CurrentRow.Cells.Item(1).Value.ToString

        frmNewEditArchive.txtSummary.Text = Me.dgTicket.CurrentRow.Cells.Item(2).Value.ToString
        frmNewEditArchive.txtSummary.ReadOnly = True

        frmNewEditArchive.txtAssign.Text = Me.dgTicket.CurrentRow.Cells.Item(3).Value.ToString
        frmNewEditArchive.txtAssign.ReadOnly = True

        frmNewEditArchive.cmbRelate.SelectedItem = Me.dgTicket.CurrentRow.Cells.Item(4).Value.ToString
        frmNewEditArchive.cmbRelate.Enabled = False

        frmNewEditArchive.chkFix.Checked = Me.dgTicket.CurrentRow.Cells.Item(5).Value.ToString
        frmNewEditArchive.chkFix.Enabled = False

        frmNewEditArchive.txtNotes.Text = Me.dgTicket.CurrentRow.Cells.Item(6).Value.ToString
        frmNewEditArchive.txtNotes.ReadOnly = True

        frmNewEditArchive.chkComplete.Checked = Me.dgTicket.CurrentRow.Cells.Item(7).Value.ToString
        frmNewEditArchive.chkComplete.Enabled = False

        frmNewEditArchive.txtCreatedDate.Text = Me.dgTicket.CurrentRow.Cells.Item(8).Value.ToString
        'End If
    End Sub

    Private Sub btnPurge_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPurge.Click

        Dim strMsg As DialogResult

        strMsg = MessageBox.Show(frmNewEditArchive, "This will purge the Archived tickets. Are you sure you want to proceed?", "TicketTrack", vbYesNo)

        If strMsg = DialogResult.Yes Then

            Me.TblArchiveTableAdapter.Delete()

            Me.TblArchiveTableAdapter.Fill(Me.DbArchiveDataSet.tblArchive)

            If Me.dgTicket.RowCount > 0 Then
                Me.btnEdit.Enabled = True
            Else
                Me.btnEdit.Enabled = False
            End If

        End If

    End Sub
End Class

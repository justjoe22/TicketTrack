Public Class frmNewEditArchive

    Private Sub frmNewEditArchive_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        frmTicketArchive.Enabled = False
        Me.Focus()

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim blStop As Boolean = False

        If Me.txtInc.Text = "" Then
            MessageBox.Show("Incident ID cannot be left blank. Please fill out the Incident ID.")
            blStop = True
        End If

        If Me.txtSummary.Text = "" Then
            MessageBox.Show("Summary cannot be left blank. Please fill out the Summary.")
            blStop = True
        End If

        If Me.txtAssign.Text = "" Then
            MessageBox.Show("Assignment cannot be left blank. Please fill out the Assignment.")
            blStop = True
        End If

        If Me.cmbRelate.Text = "" Then
            MessageBox.Show("Relationship cannot be left blank. Please select a Relationship.")
            blStop = True
        End If

        If blStop = False Then

            frmTicketArchive.TblArchiveTableAdapter.Update(Me.txtSummary.Text, Me.txtAssign.Text, Me.cmbRelate.SelectedItem.ToString, Me.txtNotes.Text, Me.chkComplete.Checked.ToString, Me.chkFix.Checked.ToString, Me.chkPurge.Checked.ToString, Me.txtInc.Text)

            frmTicketArchive.TblArchiveTableAdapter.Fill(frmTicketArchive.DbArchiveDataSet.tblArchive)

            frmTicketArchive.Enabled = True

            If frmTicketArchive.dgTicket.RowCount > 0 Then
                frmTicketArchive.btnEdit.Enabled = True
            Else
                frmTicketArchive.btnEdit.Enabled = False
            End If

            Me.Close()

        End If

    End Sub


    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        frmTicketArchive.TblArchiveTableAdapter.Fill(frmTicketArchive.DbArchiveDataSet.tblArchive)

        frmTicketArchive.Enabled = True

        If frmTicketArchive.dgTicket.RowCount > 0 Then
            frmTicketArchive.btnEdit.Enabled = True
        Else
            frmTicketArchive.btnEdit.Enabled = False
        End If

        Me.Close()

    End Sub

End Class
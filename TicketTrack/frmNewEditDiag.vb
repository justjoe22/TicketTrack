Public Class frmNewEditDiag

    Private Sub frmNewEditDiag_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        frmTicketMain.Enabled = False
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

            If Me.txtInc.ReadOnly = True Then
                frmTicketMain.TblTicketTableAdapter.Update(Me.txtSummary.Text, Me.txtAssign.Text, Me.cmbRelate.SelectedItem.ToString, Me.txtNotes.Text, Me.chkComplete.Checked.ToString, Me.chkFix.Checked.ToString, Me.txtInc.Text)
            Else
                frmTicketMain.TblTicketTableAdapter.DupCheck(frmTicketMain.DbTicketDataSet.tblTicket, Me.txtInc.Text)

                If frmTicketMain.dgTicket.RowCount <= 0 Then
                    frmTicketMain.TblTicketTableAdapter.Insert(Me.txtInc.Text, Me.txtSummary.Text, Me.txtAssign.Text, Me.cmbRelate.SelectedItem.ToString, Me.txtNotes.Text, Me.chkComplete.Checked, Me.chkFix.Checked)
                    blStop = False
                Else
                    MessageBox.Show("Duplicate incident found for " + Me.txtInc.Text + ". Please enter a unique Incident ID.")
                    blStop = True
                End If

            End If

            If blStop = False Then

                If frmTicketMain.chkAll.Checked = True Then
                    frmTicketMain.TblTicketTableAdapter.SelectALL(frmTicketMain.DbTicketDataSet.tblTicket)
                Else
                    frmTicketMain.TblTicketTableAdapter.Fill(frmTicketMain.DbTicketDataSet.tblTicket)
                End If

                frmTicketMain.Enabled = True

                If frmTicketMain.dgTicket.RowCount > 0 Then
                    frmTicketMain.btnEdit.Enabled = True
                Else
                    frmTicketMain.btnEdit.Enabled = False
                End If

                Me.Close()

            End If

        End If

        frmTicketMain.fncSelectHigh(0)

    End Sub


    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        If frmTicketMain.chkAll.Checked = True Then
            frmTicketMain.TblTicketTableAdapter.SelectALL(frmTicketMain.DbTicketDataSet.tblTicket)
        Else
            frmTicketMain.TblTicketTableAdapter.Fill(frmTicketMain.DbTicketDataSet.tblTicket)
        End If

        frmTicketMain.Enabled = True

        If frmTicketMain.dgTicket.RowCount > 0 Then
            frmTicketMain.btnEdit.Enabled = True
        Else
            frmTicketMain.btnEdit.Enabled = False
        End If

        Me.Close()

    End Sub

End Class
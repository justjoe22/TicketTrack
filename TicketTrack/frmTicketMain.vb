
Public Class frmTicketMain
    Public Timer As Integer = 0

    Private Sub frmTicketMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim verDeployed As System.Version
        Dim strVerDeployed As String = ""
        Dim connSuccess As Boolean = False

        Try

            If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then

                verDeployed = My.Application.Deployment.CurrentVersion

                strVerDeployed = verDeployed.ToString

            Else ' or if command line execution

                'Dim asmThis As System.Reflection.Assembly = System.Reflection.Assembly.Load("CADView")

                'Dim asnThis As System.Reflection.AssemblyName = asmThis.GetName()

                'verDeployed = asnThis.Version

                'strVerDeployed = verDeployed.ToString

                strVerDeployed = "001"

            End If

            Me.Text = Me.Text + " v." + strVerDeployed

            'SQL Connection
            'connSuccess = SQLConnect.ConnectDB()

            Me.TblTicketTableAdapter.qryArchive()

            Me.TblTicketTableAdapter.qryPurge()

            'TODO: This line of code loads data into the 'DbTicketDataSet.tblTicket' table. You can move, or remove it, as needed.
            Me.TblTicketTableAdapter.Fill(Me.DbTicketDataSet.tblTicket)


            If Me.dgTicket.RowCount > 0 Then
                Me.btnEdit.Enabled = True
            Else
                Me.btnEdit.Enabled = False
            End If

            Me.time_track.Interval = 120
            Me.time_track.Enabled = True
            Me.time_track.Start()

            fncSelectHigh(0)

        Catch ex As Exception
            MsgBox(vbOKOnly, MsgBoxStyle.Critical + ex.Message, "TicketTrack")
        End Try
    End Sub

    Public Function fncSelectHigh(ByRef iVal As Integer) As Boolean
        Dim iLength As Integer = 0

        Do While iLength < Me.dgTicket.Rows.Count
            If Me.dgTicket.Rows.Item(iLength).Cells.Item(4).Value = False Then

                Me.dgTicket.Rows.Item(iLength).DefaultCellStyle.BackColor = Color.Red

            End If

            iLength = iLength + 1
        Loop

        Return True

    End Function

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try

            If Me.chkAll.Checked = True Then
                Me.TblTicketTableAdapter.SelectALL(Me.DbTicketDataSet.tblTicket)
                fncSelectHigh(0)
            Else
                Me.TblTicketTableAdapter.Fill(Me.DbTicketDataSet.tblTicket)
                fncSelectHigh(0)
            End If

            If Me.dgTicket.RowCount > 0 Then
                Me.btnEdit.Enabled = True
            Else
                Me.btnEdit.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(vbOKOnly, MsgBoxStyle.Critical + ex.Message, "TicketTrack")
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        frmNewEditDiag.Show()
        frmNewEditDiag.Text = "Add Watch Ticket"

        frmNewEditDiag.txtInc.Text = ""
        frmNewEditDiag.txtInc.ReadOnly = False

        frmNewEditDiag.txtAssign.Text = ""
        frmNewEditDiag.chkFix.Checked = False
        frmNewEditDiag.txtNotes.Text = ""
        frmNewEditDiag.cmbRelate.SelectionStart = 0
        frmNewEditDiag.txtSummary.Text = ""
        frmNewEditDiag.chkComplete.Checked = False

    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        frmNewEditDiag.Show()
        frmNewEditDiag.Text = "Edit Watch Ticket: " & Me.dgTicket.CurrentRow.Cells.Item(0).Value.ToString

        frmNewEditDiag.txtInc.Text = Me.dgTicket.CurrentRow.Cells.Item(0).Value.ToString
        frmNewEditDiag.txtInc.ReadOnly = True

        frmNewEditDiag.txtSummary.Text = Me.dgTicket.CurrentRow.Cells.Item(1).Value.ToString
        frmNewEditDiag.txtAssign.Text = Me.dgTicket.CurrentRow.Cells.Item(2).Value.ToString
        frmNewEditDiag.cmbRelate.SelectedItem = Me.dgTicket.CurrentRow.Cells.Item(3).Value.ToString
        frmNewEditDiag.chkFix.Checked = Me.dgTicket.CurrentRow.Cells.Item(4).Value.ToString
        frmNewEditDiag.txtNotes.Text = Me.dgTicket.CurrentRow.Cells.Item(5).Value.ToString
        frmNewEditDiag.chkComplete.Checked = Me.dgTicket.CurrentRow.Cells.Item(6).Value.ToString

        frmNewEditDiag.txtCreatedDate.Text = Me.dgTicket.CurrentRow.Cells.Item(7).Value.ToString

    End Sub

    Private Sub time_track_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles time_track.Tick

        Timer = Timer + 1

        Try
            If Timer = Me.time_track.Interval Then
                If Me.chkAll.Checked = True Then
                    Me.TblTicketTableAdapter.SelectALL(Me.DbTicketDataSet.tblTicket)
                    fncSelectHigh(0)
                Else
                    Me.TblTicketTableAdapter.Fill(Me.DbTicketDataSet.tblTicket)
                    fncSelectHigh(0)
                End If

                If Me.dgTicket.RowCount > 0 Then
                    Me.btnEdit.Enabled = True
                Else
                    Me.btnEdit.Enabled = False
                End If

                Timer = 0
            End If
        Catch ex As Exception
            MsgBox(vbOKOnly, MsgBoxStyle.Critical + ex.Message, "TicketTrack")
        End Try
    End Sub

    Private Sub chkAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAll.Click

        If Me.chkAll.Checked = True Then
            'Me.chkAutoR.Enabled = False
            'Me.txtInt.Enabled = False
            Me.TblTicketTableAdapter.SelectALL(Me.DbTicketDataSet.tblTicket)
            fncSelectHigh(0)
        Else
            'Me.chkAutoR.Enabled = True
            'Me.txtInt.Enabled = True
            Me.TblTicketTableAdapter.Fill(Me.DbTicketDataSet.tblTicket)
            fncSelectHigh(0)
        End If

        If Me.dgTicket.RowCount > 0 Then
            Me.btnEdit.Enabled = True
        Else
            Me.btnEdit.Enabled = False
        End If

    End Sub

    Private Sub chkAutoR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAutoR.Click
        If Me.chkAutoR.Checked = True Then
            'Me.txtInt.Enabled = False
            'Me.chkAll.Enabled = False
            'Me.btnAdd.Enabled = False
            'Me.btnEdit.Enabled = False
            Me.btnRefresh.Enabled = False
            Me.time_track.Interval = Me.txtInt.Text
            Me.time_track.Enabled = True
            Me.time_track.Start()
        Else
            Timer = 0
            Me.time_track.Stop()
            Me.time_track.Enabled = False
            'Me.txtInt.Enabled = True
            'Me.chkAll.Enabled = True
            'Me.btnAdd.Enabled = True
            'Me.btnEdit.Enabled = True
            Me.btnRefresh.Enabled = True
        End If
    End Sub

    Private Sub dgTicket_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTicket.CellDoubleClick
        Dim URL As String = "", Place As Integer = 0

        If Me.dgTicket.SelectedCells.Item(0).Value = Me.dgTicket.CurrentRow.Cells.Item(5).Value And Me.dgTicket.CurrentRow.Cells.Item(4).Value = True Then
            URL = Me.dgTicket.CurrentRow.Cells.Item(5).Value.ToString
            Place = InStr(URL, "http://", vbTextCompare)

            If Place > 0 Then
                URL = Microsoft.VisualBasic.Right(URL, Len(URL) - Place + 1).Trim

                Place = InStr(URL, Environment.NewLine, vbTextCompare)
                If Place > 0 Then
                    URL = Microsoft.VisualBasic.Left(URL, Place - 1).Trim
                Else
                    Place = InStr(URL, " ", vbTextCompare)
                    If Place > 0 Then
                        URL = Microsoft.VisualBasic.Left(URL, Place - 1).Trim
                    End If
                End If


                System.Diagnostics.Process.Start(URL)
            End If
        Else
            'If chkAutoR.Checked = False Then
            frmNewEditDiag.Show()
            frmNewEditDiag.Text = "Edit Watch Ticket: " & Me.dgTicket.CurrentRow.Cells.Item(0).Value.ToString

            frmNewEditDiag.txtInc.Text = Me.dgTicket.CurrentRow.Cells.Item(0).Value.ToString
            frmNewEditDiag.txtInc.ReadOnly = True

            frmNewEditDiag.txtSummary.Text = Me.dgTicket.CurrentRow.Cells.Item(1).Value.ToString
            frmNewEditDiag.txtAssign.Text = Me.dgTicket.CurrentRow.Cells.Item(2).Value.ToString
            frmNewEditDiag.cmbRelate.SelectedItem = Me.dgTicket.CurrentRow.Cells.Item(3).Value.ToString
            frmNewEditDiag.chkFix.Checked = Me.dgTicket.CurrentRow.Cells.Item(4).Value.ToString
            frmNewEditDiag.txtNotes.Text = Me.dgTicket.CurrentRow.Cells.Item(5).Value.ToString
            frmNewEditDiag.chkComplete.Checked = Me.dgTicket.CurrentRow.Cells.Item(6).Value.ToString

            frmNewEditDiag.txtCreatedDate.Text = Me.dgTicket.CurrentRow.Cells.Item(7).Value.ToString
            'End If
        End If
    End Sub

    Private Sub btnArchive_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnArchive.Click

        frmTicketArchive.Show()

    End Sub

    Private Sub mnuCopy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuCopy.Click
        If Me.dgTicket.GetClipboardContent Is Nothing Then
            MessageBox.Show("Nothing selected to copy to clipboard.")
        Else
            Me.dgTicket.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
            Clipboard.SetDataObject(Me.dgTicket.GetClipboardContent)
        End If
    End Sub


End Class

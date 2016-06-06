Imports System.Data
Imports System.Data.SqlClient

Public Class frmTicketSQL

    Public Timer As Integer = 0

    Private Sub frmTicketSQL_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try

            If Me.WindowState = FormWindowState.Normal Then
                My.Settings.frmTicketSQL_location = Me.Location
                My.Settings.frmTicketSQL_size = Me.Size
            End If

            My.Settings.frmTicketSQL_windowstate = Me.WindowState
            My.Settings.Save()

            Me.time_track.Stop()
            Me.time_track.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)

            Exit Try
        End Try
    End Sub

    Private Sub frmTicketSQL_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            Dim verDeployed As System.Version
            Dim strVerDeployed As String = ""

            If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then

                verDeployed = My.Application.Deployment.CurrentVersion

                strVerDeployed = "Version " + verDeployed.ToString

            Else

                strVerDeployed = "SQL Test {Local Copy}"

            End If

            Me.Text = Me.Text + " - " + strVerDeployed + " - " + My.Application.Info.Description

            Me.Location = My.Settings.frmTicketSQL_location
            Me.Size = My.Settings.frmTicketSQL_size
            Me.WindowState = My.Settings.frmTicketSQL_windowstate

            'TODO: This line of code loads data into the 'DbTicketSQLds.ITT00501_PT_TICKT_MST' table. You can move, or remove it, as needed.
            'Me.ITT00501_PT_TICKT_MSTTableAdapter.ITP00501_PT_TICKT_CHK_CMPLT_GET(Me.DbTicketSQLds.ITT00501_PT_TICKT_MST, False, False)

            Me.dgSQL.Columns(0).ReadOnly = True
            Me.dgSQL.Item(0, Me.dgSQL.NewRowIndex).ReadOnly = False
            Me.dgSQL.Item(6, Me.dgSQL.NewRowIndex).ReadOnly = True

            Me.time_track.Interval = 30
            Me.time_track.Enabled = True
            Me.time_track.Start()

            'frmSplash.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)

            Exit Try
        End Try
    End Sub

    Private Sub dgSQL_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSQL.CellDoubleClick
        Try

            If IsDBNull(Me.dgSQL.SelectedCells.Item(0).Value) = False Then
                If Me.dgSQL.SelectedCells.Item(0).Value = Me.dgSQL.CurrentRow.Cells.Item(4).Value Then
                    frmNotes.txtNotes.Text = Me.dgSQL.CurrentCell.Value

                    frmNotes.ShowDialog()

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)

            Exit Try
        End Try
    End Sub

    Private Sub dgSQL_RowLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSQL.RowLeave
        Try
            If Me.dgSQL.IsCurrentRowDirty = True Then

                If IsDBNull(Me.dgSQL.CurrentRow.Cells.Item(0).Value) = False Then

                    Me.dgSQL.CurrentRow.Cells.Item(1).Value = IIf(IsDBNull(Me.dgSQL.CurrentRow.Cells.Item(1).Value), "None", Me.dgSQL.CurrentRow.Cells.Item(1).Value)
                    Me.dgSQL.CurrentRow.Cells.Item(2).Value = IIf(IsDBNull(Me.dgSQL.CurrentRow.Cells.Item(2).Value), "None", Me.dgSQL.CurrentRow.Cells.Item(2).Value)
                    Me.dgSQL.CurrentRow.Cells.Item(3).Value = IIf(IsDBNull(Me.dgSQL.CurrentRow.Cells.Item(3).Value), "Duplicate of", Me.dgSQL.CurrentRow.Cells.Item(3).Value)
                    Me.dgSQL.CurrentRow.Cells.Item(4).Value = IIf(IsDBNull(Me.dgSQL.CurrentRow.Cells.Item(4).Value), "None", Me.dgSQL.CurrentRow.Cells.Item(4).Value)
                    Me.dgSQL.CurrentRow.Cells.Item(5).Value = IIf(IsDBNull(Me.dgSQL.CurrentRow.Cells.Item(5).Value), False, Me.dgSQL.CurrentRow.Cells.Item(5).Value)
                    Me.dgSQL.CurrentRow.Cells.Item(6).Value = IIf(IsDBNull(Me.dgSQL.CurrentRow.Cells.Item(6).Value), False, Me.dgSQL.CurrentRow.Cells.Item(6).Value)
                    Me.dgSQL.CurrentRow.Cells.Item(7).Value = IIf(IsDBNull(Me.dgSQL.CurrentRow.Cells.Item(7).Value), Today.Date.ToString, Me.dgSQL.CurrentRow.Cells.Item(7).Value)

                    Me.dgSQL.CurrentRow.Cells.Item(5).Value = IIf(Me.dgSQL.CurrentRow.Cells.Item(6).Value = True, False, Me.dgSQL.CurrentRow.Cells.Item(5).Value)

                    'If IsNothing(Me.ITT00501_PT_TICKT_MSTTableAdapter.ITP00501_PT_TICKT_GET(Me.dgSQL.CurrentRow.Cells.Item(0).Value.ToString)) = True Then

                    '    Me.ITT00501_PT_TICKT_MSTTableAdapter.ITP00501_PT_TICKT_INS(Me.dgSQL.CurrentRow.Cells.Item(0).Value.ToString,
                    '                                    Me.dgSQL.CurrentRow.Cells.Item(1).Value.ToString,
                    '                                    Me.dgSQL.CurrentRow.Cells.Item(2).Value.ToString,
                    '                                    Me.dgSQL.CurrentRow.Cells.Item(3).Value.ToString,
                    '                                    Me.dgSQL.CurrentRow.Cells.Item(4).Value.ToString,
                    '                                    Me.dgSQL.CurrentRow.Cells.Item(6).Value,
                    '                                     Me.dgSQL.CurrentRow.Cells.Item(5).Value,
                    '                                    Me.dgSQL.CurrentRow.Cells.Item(7).Value)

                    'ElseIf IsNothing(Me.ITT00501_PT_TICKT_MSTTableAdapter.ITP00501_PT_TICKT_GET(Me.dgSQL.CurrentRow.Cells.Item(0).Value.ToString)) = False Then
                    '    If MsgBox("Are you sure you want to overwrite, " + Me.dgSQL.CurrentRow.Cells.Item(0).Value.ToString + "?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                    '        Me.ITT00501_PT_TICKT_MSTTableAdapter.ITP00501_PT_TICKT_UPD(Me.dgSQL.CurrentRow.Cells.Item(0).Value.ToString,
                    '                                        Me.dgSQL.CurrentRow.Cells.Item(1).Value.ToString,
                    '                                        Me.dgSQL.CurrentRow.Cells.Item(2).Value.ToString,
                    '                                        Me.dgSQL.CurrentRow.Cells.Item(3).Value.ToString,
                    '                                        Me.dgSQL.CurrentRow.Cells.Item(4).Value.ToString,
                    '                                         Me.dgSQL.CurrentRow.Cells.Item(6).Value,
                    '                                         Me.dgSQL.CurrentRow.Cells.Item(5).Value)
                    '    End If

                    'Else

                    '    Me.TableAdapterManager.UpdateAll(Me.DbTicketSQLds)

                    'End If

                Else
                    MsgBox("Ticket # cannot be left blank. Please fill out the Ticket #.", MsgBoxStyle.Information, Me.Text)
                End If

                If cmbView.SelectedItem.ToString = "Open Tickets" Then

                    'Me.ITT00501_PT_TICKT_MSTTableAdapter.ITP00501_PT_TICKT_CHK_CMPLT_GET(Me.DbTicketSQLds.ITT00501_PT_TICKT_MST, False, False)

                    If Me.dgSQL.NewRowIndex >= 0 Then
                        Me.dgSQL.Columns(0).ReadOnly = True
                        Me.dgSQL.Item(0, Me.dgSQL.NewRowIndex).ReadOnly = False
                        Me.dgSQL.Item(6, Me.dgSQL.NewRowIndex).ReadOnly = True
                    End If

                ElseIf cmbView.SelectedItem.ToString = "Reference Tickets" Then

                    'Me.ITT00501_PT_TICKT_MSTTableAdapter.ITP00501_PT_TICKT_CHK_CMPLT_GET(Me.DbTicketSQLds.ITT00501_PT_TICKT_MST, False, True)

                    Me.dgSQL.Columns(0).ReadOnly = True
                    Me.dgSQL.Item(0, Me.dgSQL.NewRowIndex).ReadOnly = False
                    Me.dgSQL.Item(6, Me.dgSQL.NewRowIndex).ReadOnly = True

                ElseIf cmbView.SelectedItem.ToString = "Completed Tickets" Then

                    'Me.ITT00501_PT_TICKT_MSTTableAdapter.ITP00501_PT_TICKT_CHK_CMPLT_GET(Me.DbTicketSQLds.ITT00501_PT_TICKT_MST, True, False)

                    Me.dgSQL.Columns(0).ReadOnly = True
                    Me.dgSQL.Item(0, Me.dgSQL.NewRowIndex).ReadOnly = False
                    Me.dgSQL.Item(6, Me.dgSQL.NewRowIndex).ReadOnly = True

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)

            Exit Try
        End Try
    End Sub

    Private Sub cmbView_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbView.SelectedValueChanged
        Try
            If Me.dgSQL.IsCurrentRowDirty = True Then
                'Me.TableAdapterManager.UpdateAll(Me.DbTicketSQLds)
            End If

            If cmbView.SelectedItem.ToString = "Open Tickets" Then

                'Me.ITT00501_PT_TICKT_MSTTableAdapter.ITP00501_PT_TICKT_CHK_CMPLT_GET(Me.DbTicketSQLds.ITT00501_PT_TICKT_MST, False, False)

                If Me.dgSQL.NewRowIndex >= 0 Then
                    Me.dgSQL.Columns(0).ReadOnly = True
                    Me.dgSQL.Item(0, Me.dgSQL.NewRowIndex).ReadOnly = False
                    Me.dgSQL.Item(6, Me.dgSQL.NewRowIndex).ReadOnly = True
                End If

                Me.time_track.Interval = 30
                Me.time_track.Enabled = True
                Me.time_track.Start()

            ElseIf cmbView.SelectedItem.ToString = "Reference Tickets" Then

                'Me.ITT00501_PT_TICKT_MSTTableAdapter.ITP00501_PT_TICKT_CHK_CMPLT_GET(Me.DbTicketSQLds.ITT00501_PT_TICKT_MST, False, True)

                Me.dgSQL.Columns(0).ReadOnly = True
                Me.dgSQL.Item(0, Me.dgSQL.NewRowIndex).ReadOnly = False
                Me.dgSQL.Item(6, Me.dgSQL.NewRowIndex).ReadOnly = True

                Me.time_track.Stop()
                Me.time_track.Enabled = False
                Me.btnRefresh.ForeColor = DefaultForeColor
                Me.txtRecordCt.Visible = False


            ElseIf cmbView.SelectedItem.ToString = "Completed Tickets" Then

                'Me.ITT00501_PT_TICKT_MSTTableAdapter.ITP00501_PT_TICKT_CHK_CMPLT_GET(Me.DbTicketSQLds.ITT00501_PT_TICKT_MST, True, False)

                Me.dgSQL.Columns(0).ReadOnly = True
                Me.dgSQL.Item(0, Me.dgSQL.NewRowIndex).ReadOnly = False
                Me.dgSQL.Item(6, Me.dgSQL.NewRowIndex).ReadOnly = True

                Me.time_track.Stop()
                Me.time_track.Enabled = False
                Me.btnRefresh.ForeColor = DefaultForeColor
                Me.txtRecordCt.Visible = False

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)

            Exit Try
        End Try
    End Sub

    Private Sub CopyMenu_Click(sender As Object, e As System.EventArgs) Handles CopyMenu.Click
        Try
            If Me.dgSQL.GetClipboardContent Is Nothing Then
                MsgBox("Nothing selected to copy to clipboard.", MsgBoxStyle.Information, Me.Text)
            Else
                Me.dgSQL.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
                Clipboard.SetDataObject(Me.dgSQL.GetClipboardContent)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)

            Exit Try
        End Try
    End Sub

    Private Sub mnuDelete_Click(sender As Object, e As System.EventArgs) Handles mnuDelete.Click
        Try
            If MsgBox("Are you sure you want to delete, " + Me.dgSQL.CurrentRow.Cells.Item(0).Value.ToString + "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'Me.ITT00501_PT_TICKT_MSTTableAdapter.ITP00501_PT_TICKT_DEL(Me.dgSQL.CurrentRow.Cells.Item(0).Value.ToString)

                'If cmbView.SelectedItem.ToString = "Open Tickets" Then

                '    Me.ITT00501_PT_TICKT_MSTTableAdapter.ITP00501_PT_TICKT_CHK_CMPLT_GET(Me.DbTicketSQLds.ITT00501_PT_TICKT_MST, False, False)

                'ElseIf cmbView.SelectedItem.ToString = "Reference Tickets" Then

                '    Me.ITT00501_PT_TICKT_MSTTableAdapter.ITP00501_PT_TICKT_CHK_CMPLT_GET(Me.DbTicketSQLds.ITT00501_PT_TICKT_MST, False, True)

                'ElseIf cmbView.SelectedItem.ToString = "Completed Tickets" Then

                '    Me.ITT00501_PT_TICKT_MSTTableAdapter.ITP00501_PT_TICKT_CHK_CMPLT_GET(Me.DbTicketSQLds.ITT00501_PT_TICKT_MST, True, False)

                'End If

                Me.dgSQL.Columns(0).ReadOnly = True
                Me.dgSQL.Item(0, Me.dgSQL.NewRowIndex).ReadOnly = False
                Me.dgSQL.Item(6, Me.dgSQL.NewRowIndex).ReadOnly = True

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)

            Exit Try
        End Try
    End Sub

    Private Sub time_track_Tick(sender As Object, e As System.EventArgs) Handles time_track.Tick
        Try

            Timer = Timer + 1

            If Timer = Me.time_track.Interval Then

                'Me.txtRecordCt.Text = Me.ITT00501_PT_TICKT_MSTTableAdapter.CountQry(False, False)

                If (Me.dgSQL.RowCount - 1) <> CInt(Me.txtRecordCt.Text) Then

                    Me.btnRefresh.ForeColor = Color.Red
                    Me.txtRecordCt.Visible = True

                Else

                    Me.btnRefresh.ForeColor = DefaultForeColor
                    Me.txtRecordCt.Visible = False

                End If

                Timer = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)

            Exit Try
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As System.EventArgs) Handles btnRefresh.Click
        Try
            If Me.dgSQL.IsCurrentRowDirty = True Then
                'Me.TableAdapterManager.UpdateAll(Me.DbTicketSQLds)
            End If

            If cmbView.SelectedItem.ToString = "Open Tickets" Then

                'Me.ITT00501_PT_TICKT_MSTTableAdapter.ITP00501_PT_TICKT_CHK_CMPLT_GET(Me.DbTicketSQLds.ITT00501_PT_TICKT_MST, False, False)

                If Me.dgSQL.NewRowIndex >= 0 Then
                    Me.dgSQL.Columns(0).ReadOnly = True
                    Me.dgSQL.Item(0, Me.dgSQL.NewRowIndex).ReadOnly = False
                    Me.dgSQL.Item(6, Me.dgSQL.NewRowIndex).ReadOnly = True
                End If

            ElseIf cmbView.SelectedItem.ToString = "Reference Tickets" Then

                'Me.ITT00501_PT_TICKT_MSTTableAdapter.ITP00501_PT_TICKT_CHK_CMPLT_GET(Me.DbTicketSQLds.ITT00501_PT_TICKT_MST, False, True)

                Me.dgSQL.Columns(0).ReadOnly = True
                Me.dgSQL.Item(0, Me.dgSQL.NewRowIndex).ReadOnly = False
                Me.dgSQL.Item(6, Me.dgSQL.NewRowIndex).ReadOnly = True

            ElseIf cmbView.SelectedItem.ToString = "Completed Tickets" Then

                'Me.ITT00501_PT_TICKT_MSTTableAdapter.ITP00501_PT_TICKT_CHK_CMPLT_GET(Me.DbTicketSQLds.ITT00501_PT_TICKT_MST, True, False)

                Me.dgSQL.Columns(0).ReadOnly = True
                Me.dgSQL.Item(0, Me.dgSQL.NewRowIndex).ReadOnly = False
                Me.dgSQL.Item(6, Me.dgSQL.NewRowIndex).ReadOnly = True

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)

            Exit Try
        End Try
    End Sub

End Class
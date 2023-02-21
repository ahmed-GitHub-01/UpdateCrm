Imports System.IO
Imports System.Data.SqlClient
Public Class FRM_ADD_USER
    Dim CLS_USER_ As New CLS_USER
    Dim CLS_ENTER_USER_ As New CLS_ENTER_USER
    Dim CLS_REPORT_BATCHES_ As New CLS_REPORT_BATCHES
    Dim SQLCON_TELE As New SqlConnection("Server = " & My.Settings.CONNECTION & ";initial catalog = DB_TELE; user ID = sa; password = " & My.Settings.PASSWORD & "")

    Private Sub FRM_ADD_USER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MAX_1()
            TXT_DEP_DropDown(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub MAX_1()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_USER_.MAX_1()
        If DT.Rows.Count > 0 Then
            ButtonEdit1.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub
    Sub MAX()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_USER_.MAX_()
        If DT.Rows.Count > 0 Then
            ButtonEdit1.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub
    Sub MAX__()
        Dim MAX_ As Double = 0
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_USER_.MAX_
        If DT.Rows.Count > 0 Then
            MAX_ = DT.Rows(0)(0).ToString()
        End If
        ButtonEdit1.Text = Val(ButtonEdit1.Text) + 1
        If Val(ButtonEdit1.Text) > Val(MAX_) Then
            ButtonEdit1.Text = MAX_
            MessageBox.Show("هذا اكبر رقم", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Sub MIN_1()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_USER_.MIN_()
        If DT.Rows.Count > 0 Then
            ButtonEdit1.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub
    Sub MIN__()
        Dim MAX_ As Double = 0
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_USER_.MIN_
        If DT.Rows.Count > 0 Then
            MAX_ = DT.Rows(0)(0).ToString()
        End If
        ButtonEdit1.Text = Val(ButtonEdit1.Text) + 1
        If Val(ButtonEdit1.Text) > Val(MAX_) Then
            ButtonEdit1.Text = MAX_
            MessageBox.Show("هذا اكبر رقم", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub PictureEdit1_Click(sender As Object, e As EventArgs) Handles PictureEdit1.Click
        'Try
        '    Dim OFD As New OpenFileDialog
        '    OFD.Filter = "اختر صورة|*.JPG;*.PNG;*.GIG;"
        '    If OFD.ShowDialog = DialogResult.OK Then
        '        PictureEdit1.Image = Image.FromFile(OFD.FileName)
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        'End Try
    End Sub
    Sub ADD_NEW_USER()
        Dim CMD As New SqlCommand
        'Dim MS As New MemoryStream
        'PictureEdit1.Image.Save(MS, PictureEdit1.Image.RawFormat)
        'Dim PIC() As Byte = MS.ToArray
        CMD = New SqlCommand("INSERT INTO [dbo].[EMPLOYEE] (NAME,DATE_recruitment,PASS,DEPARTMENT,CODE,NUM,IS_VOKE,ACTIVEE,INTERNAL,SWITCH,NAME_EN)
                              VALUES
                             (@NAME,@DATE_recruitment,@PASS,@DEPARTMENT,@CODE,@NUM,@IS_VOKE,@ACTIVEE,@INTERNAL,
                             @SWITCH,@NAME_EN)", SQLCON_TELE)
        CMD.Parameters.Add(New SqlParameter("@NAME", SqlDbType.NVarChar)).Value = TXT_NAME.Text
        CMD.Parameters.Add(New SqlParameter("@DATE_recruitment", SqlDbType.Date)).Value = DTP.Value
        CMD.Parameters.Add(New SqlParameter("@PASS", SqlDbType.NVarChar)).Value = TXT_PASS.Text
        'CMD.Parameters.Add(New SqlParameter("@PIC", SqlDbType.Image)).Value = PIC
        CMD.Parameters.Add(New SqlParameter("@DEPARTMENT", SqlDbType.NVarChar)).Value = TXT_DEP.Text
        CMD.Parameters.Add(New SqlParameter("@CODE", SqlDbType.Int)).Value = ButtonEdit1.Text
        CMD.Parameters.Add(New SqlParameter("@NUM", SqlDbType.Float)).Value = 0
        CMD.Parameters.Add(New SqlParameter("@IS_VOKE", SqlDbType.NVarChar)).Value = 0
        CMD.Parameters.Add(New SqlParameter("@ACTIVEE", SqlDbType.NVarChar)).Value = COM_FAAL.Text
        CMD.Parameters.Add(New SqlParameter("@INTERNAL", SqlDbType.Int)).Value = TXT_INTERNAL.Text
        CMD.Parameters.Add(New SqlParameter("@SWITCH", SqlDbType.Int)).Value = TXT_SWITCH.Text
        CMD.Parameters.Add(New SqlParameter("@NAME_EN", SqlDbType.NVarChar)).Value = TXT_NAME_AR.Text
        CLS_ENTER_USER_.ADD_ROULE(ButtonEdit1.Text)
        SQLCON_TELE.Open()
        CMD.ExecuteNonQuery()
        SQLCON_TELE.Close()
        Dim X As Boolean = False
       MessageBox.Show(Me, "تم الحفظ بنجاح", "تـــــأكيد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub
    Sub SHOW_NEW_USER()
        Try
            Dim DT As New DataTable
            DT.Clear()
            If ButtonEdit1.Text = String.Empty Then
            Else
                DT = CLS_USER_.SHOW_NEW_USERE(ButtonEdit1.Text)
                TXT_DEP.SelectedIndex = -1
                If DT.Rows.Count > 0 Then
                    TXT_DEP.Text = DT.Rows(0)(5).ToString()
                    TXT_NAME.Text = DT.Rows(0)(1).ToString()
                    TXT_PASS.Text = DT.Rows(0)(3).ToString()
                    DTP.Value = DT.Rows(0)(2)
                    COM_FAAL.Text = DT.Rows(0)(6)
                    Dim MS As New MemoryStream(CType(DT.Rows(0)(4), Byte()))
                    PictureEdit1.Image = Image.FromStream(MS)
                    TXT_NUMBER.Text = DT.Rows(0)(7)
                    TXT_NAME_AR.Text = DT.Rows(0)(8).ToString()
                    TXT_INTERNAL.Text = DT.Rows(0)(9).ToString()
                    TXT_SWITCH.Text = DT.Rows(0)(10).ToString()
                Else
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub حفظToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حفظToolStripMenuItem.Click
        Try
            ADD_NEW_USER()
            MAX_1()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub ButtonEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles ButtonEdit1.EditValueChanged
        Try
            'SHOW_NEW_USER()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub جديدToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles جديدToolStripMenuItem.Click
        Try
            MAX_1()
            TXT_NAME.Text = String.Empty
            TXT_PASS.Text = String.Empty
            TXT_DEP.Text = String.Empty
            DTP.Value = Now
            TXT_DEP.SelectedIndex = -1
            TXT_NAME_AR.Text = String.Empty
            TXT_INTERNAL.Text = 0
            TXT_NUMBER.Text = 0
            TXT_SWITCH.Text = 0
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub تعديلToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تعديلToolStripMenuItem.Click
        Try
            If String.IsNullOrWhiteSpace(ButtonEdit1.Text) Or
               String.IsNullOrWhiteSpace(TXT_NAME.Text) Or
               String.IsNullOrWhiteSpace(TXT_PASS.Text) Or
               String.IsNullOrWhiteSpace(TXT_DEP.Text) Then
            Else
                CLS_USER_.EDIT_USER(ButtonEdit1.Text, TXT_NAME.Text, TXT_PASS.Text, TXT_DEP.Text, COM_FAAL.Text, TXT_NUMBER.Text, TXT_INTERNAL.Text, TXT_SWITCH.Text, TXT_NAME_AR.Text)
                MessageBox.Show("! تم التعديل", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub TXT_DEP_DropDown(sender As Object, e As EventArgs) Handles TXT_DEP.DropDown
        Try
            Dim COUNT As Integer = 0
            Dim DT1 As New DataTable
            DT1.Clear()
            Dim DT As New DataTable
            With DT
                .Columns.Add("ID")
                .Columns.Add("Z")
            End With
            DT.Clear()
            DT1 = CLS_USER_.COMPANY()
            For I As Integer = 0 To DT1.Rows.Count - 1
                DT.Rows.Add(COUNT, DT1.Rows(I)(0))
                COUNT += 1
            Next
            If DT1.Rows.Count > 0 Then
                TXT_DEP.DataSource = DT
                TXT_DEP.DisplayMember = "Z"
                TXT_DEP.ValueMember = "ID"
            Else
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub ButtonEdit1_KeyUp(sender As Object, e As KeyEventArgs) Handles ButtonEdit1.KeyUp
        Try
            If e.KeyCode = Keys.Enter Then
                SHOW_NEW_USER()
            Else
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    'Private Sub TXT_PASS_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles TXT_PASS.ButtonClick
    '    Try
    '        If TXT_PASS.Properties.UseSystemPasswordChar = True Then
    '            TXT_PASS.Properties.UseSystemPasswordChar = False
    '        Else
    '            TXT_PASS.Properties.UseSystemPasswordChar = True
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
End Class
Imports System.Data
Imports System.Data.OleDb

Public Class form4

    Public constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & Application.StartupPath & "\database.accdb"

    Dim ds As New OleDbConnection(constr)
    Dim dss As New DataSet
    Dim sql As String = "select * from pass"
    Dim x As String
    Dim d As String
    Dim ed As Integer = 0

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ed = ed + 1




        Dim y As String
        Dim s As String


        y = UsernameTextBox.Text


        s = PasswordTextBox.Text
        PasswordTextBox.Text = ""


        UsernameTextBox.Text = ""
        If (y = x) Then
            If (s = d) Then

                AxWindowsMediaPlayer1.close()

                Me.Hide()
                Form1.Show()
            Else
                If MsgBox(" حطأ في كلمه الس", MsgBoxStyle.RetryCancel) = MsgBoxResult.Cancel Then
                    End

                End If
            End If
        Else
            If MsgBox(" حطأ في اسم المستخدم", MsgBoxStyle.RetryCancel) = MsgBoxResult.Cancel Then
                End
            End If
        End If
        If ed = 3 Then
            OK.Visible = False

        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        If MsgBox("Did you want to go out ", MsgBoxStyle.OkCancel, "exit") = MsgBoxResult.Ok Then
            Application.Exit()
        End If

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ds.Open()
        Dim A As New OleDbDataAdapter(sql, ds)
        A.Fill(dss, "pass")
        ds.Close()
        UsernameTextBox.DataBindings.Add("text", dss, "pass.name")
        x = UsernameTextBox.Text
        UsernameTextBox.Text = ""

        PasswordTextBox.DataBindings.Add("text", dss, "pass.p_w")
        d = PasswordTextBox.Text
        PasswordTextBox.Text = ""


    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub


End Class

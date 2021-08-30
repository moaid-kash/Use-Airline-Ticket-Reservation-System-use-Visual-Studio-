Imports System.Data
Imports System.Data.OleDb


Public Class Form3

    Public constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & Application.StartupPath & "\database.accdb"
    Dim dss As New DataSet
    Dim ds As New OleDbConnection(constr)


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged, TextBox7.TextChanged, TextBox8.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
         Dim sqlup As String = "INSERT INTO  emp  ( name , phon , acco , pz ,in_st, to_en ,dr,prs,date_go) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & Label8.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox6.Text & "')"
        Dim cmd As New OleDbCommand(sqlup, ds)

        ds.Open()
        cmd.ExecuteNonQuery()

        ds.Close()

     
        MsgBox("  تم تاكيد الحجز سوف تصلك رساله التاكيد في رقم الهاتف", MsgBoxStyle.OkOnly)
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox6.Text = Form1.DateTimePicker1.Value.ToString("yyyy/MM/dd")
        TextBox1.Text = Form2.TextBox1.Text
        TextBox2.Text = Form2.TextBox2.Text
        TextBox4.Text = Form2.TextBox4.Text
        TextBox3.Text = Form2.TextBox3.Text
        TextBox5.Text = Form1.ComboBox2.Text
        TextBox7.Text = Form1.ComboBox3.Text
        TextBox8.Text = Form1.ComboBox1.Text
        If TextBox8.Text = "الخاصه" Then
            Label8.Text = " 9000  $"
        Else
            Label8.Text = " 5000  $"
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click, Label11.Click

    End Sub
End Class
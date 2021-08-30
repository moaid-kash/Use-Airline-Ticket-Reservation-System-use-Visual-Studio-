Public Class Form1
    Dim i As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox3.Items.Add("تركيا")
        ComboBox3.Items.Add("مصر")
        ComboBox3.Items.Add("السعوديه")
        ComboBox3.Items.Add("السودان")

        ComboBox2.Items.Add("تركيا")
        ComboBox2.Items.Add("مصر")
        ComboBox2.Items.Add("السعوديه")
        ComboBox2.Items.Add("السودان")

        ComboBox1.Items.Add("عادي")
        ComboBox1.Items.Add("الخاصه")
        RadioButton1.Select()

    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        DateTimePicker2.Hide()
        Label4.Hide()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        DateTimePicker2.Show()
        Label4.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click, Button3.Click
        i = NumericUpDown1.Value
        If ComboBox3.Text <> "" And ComboBox2.Text <> "" And ComboBox1.Text <> "" And i <> 0 Then
            Me.Hide()
            Form2.Show()
        Else
            MsgBox("الرجاء ادخال جميع البيانات", MsgBoxStyle.Exclamation)

        End If




    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub


End Class
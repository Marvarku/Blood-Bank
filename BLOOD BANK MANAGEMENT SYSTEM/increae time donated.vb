Imports MySql.Data.MySqlClient
Public Class increase_form
    Dim DONATE As New donate
    Dim mysqlconn As New MySqlConnection("Server=localhost; Uid=root; Password=; Database=blood_bank_management")

    Private Sub increae_time_donated_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Visible = False
        Label3.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim fname As String = txtfname.Text
        'Dim tdonated As Integer = NumericUpDown1.Value

        'If DONATE.inserttimesdonated(fname, tdonated) Then

        '    MsgBox("Donor Record updated", MsgBoxStyle.Information, "Update Donor")

        'Else

        '    MsgBox("Error", MsgBoxStyle.Critical, "update Donor")
        'End If


        'SECOND ALTERNATIVE
        Try
            mysqlconn.Open()

            Dim command As New MySqlCommand("UPDATE `donoation` SET `times_donated`= '" & NumericUpDown1.Value & "' WHERE `first_name`='" & txtfname.Text & "'", mysqlconn)
            Dim reader As MySqlDataReader
            reader = command.ExecuteReader
            MessageBox.Show("number of times updated")
        Catch ex As Exception
            mysqlconn.Close()
            MessageBox.Show(ex.Message)
        Finally
            mySqlconn.Dispose()

        End Try
      
    End Sub
End Class
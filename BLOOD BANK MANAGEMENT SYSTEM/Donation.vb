Imports MySql.Data.MySqlClient
Public Class Donation


    'add button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim table As New DataTable()
        Dim DONATE As New donate
        Dim fname As String = txtfname.Text
        Dim mname As String = txtmname.Text
        Dim lname As String = txtlname.Text
        Dim bdate As Date = DateTimePicker1.Value
        Dim phone As String = txtcontact.Text
        Dim address As String = txtaddress.Text
        Dim ldoner As Date = DateTimePicker2.Value
        ' Dim next_donate As Date = DateTimePicker3.Value
        Dim time_donated As Integer = 1
        Dim btype As String = ComboBox1.Text

        Dim aDate As String = Format(DateTimePicker3.Value, "yyyy-MM-dd")
        Dim Dates3 = aDate.ToString()

        Dim gender As String = "male"

        If rdfemale.Checked Then
            gender = "female"
        End If

        Dim fdoner As String = "Yes"

        If rdno.Checked Then
            fdoner = "No"
        End If

        'checking if birthdate is too high or to low
        Dim born_year As Integer = DateTimePicker1.Value.Year
        Dim this_year As Integer = Date.Now.Year

        'allowing students age between 10 and 100
        If this_year - born_year < 10 Or this_year - born_year > 100 Then

            MsgBox("The Studemt age must be between 10 and 100", MsgBoxStyle.Information, "Birth Date Error")

        Else
         
            If verif() Then

                If DONATE.checkDonorsName(mname, lname) Then

                    If DONATE.InsertDonor(fname, mname, lname, bdate, gender, address, phone, fdoner, ldoner, Dates3, time_donated, btype) Then
                        ', next_donate
                        MsgBox("New Doner Added", MsgBoxStyle.Information, "Add Doner")

                    Else

                        MsgBox("Error", MsgBoxStyle.Critical, "Add Doner")

                    End If
                Else

                    MsgBox("Donors Name already exist", MsgBoxStyle.Information, "Add Donor")
                    increase_form.Show(Me)
                    Timer1.Start()

                End If
            Else

                MsgBox("Empty Spaces available", MsgBoxStyle.Critical, "Add Doner")

            End If

                End If

              
    End Sub

    'function to verify data
    Function verif() As Boolean
        If txtfname.Text.Trim() = "" Or txtlname.Text.Trim() = "" Or txtaddress.Text.Trim() = "" Or txtcontact.Text.Trim() = "" Or ComboBox1.Text.Trim() = "" Or txtmname.Text.Trim() = "" Then
            Return False

        Else

            Return True
        End If

    End Function

    Private Sub txtcontact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontact.KeyPress
        'allows only numbers in this textbox
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        increase_form.txtfname.Text = txtfname.Text
    End Sub

  
    Private Sub Donation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
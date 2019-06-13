Imports MySql.Data.MySqlClient
Public Class Donors_List

    Dim DONATE As New donate
    Private Sub btnaddstudent_Click(sender As Object, e As EventArgs) Handles btnaddstudent.Click

        Dim ID As Integer
        Dim fname As String = txtfname.Text
        Dim mname As String = txtmname.Text
        Dim lname As String = txtmname.Text
        Dim bdate As Date = DateTimePicker1.Value
        Dim phone As String = txtcontact.Text
        Dim address As String = txtaddress.Text
        Dim btype As String = cmbblood.Text
        Dim gender As String = "male"
        Dim fdoner As String = "yes"
        Dim ldoner As Date = DateTimePicker2.Value
        ' Dim next_donation As Date = DateTimePicker3.Value
        Dim aDate As String = Format(DateTimePicker3.Value, "yyyy-MM-dd")
        Dim Dates3 = aDate.ToString()

        If rdfemale.Checked Then
            gender = "female"
        End If
        If rdno.Checked Then
            fdoner = "no"
        End If
        '   Dim pic As New MemoryStream

        'checking if birthdate is too high or to low
        Dim born_year As Integer = DateTimePicker1.Value.Year
        Dim this_year As Integer = Date.Now.Year

        'allowing students age between 10 and 100
        If this_year - born_year < 10 Or this_year - born_year > 100 Then

            MsgBox("The Studemt age must be between 10 and 100", MsgBoxStyle.Information, "Birth Date Error")

        Else

            If verif() Then
                Try
                    ID = Convert.ToInt32(txtid.Text)
                Catch ex As Exception
                    MsgBox("Please Enter a valid Numeric ID", MsgBoxStyle.Information, "upate student")
                End Try

                ' addstudentpic.Image.Save(pic, addstudentpic.Image.RawFormat)

                If DONATE.updateDonor(ID, fname, mname, lname, bdate, gender, address, phone, fdoner, ldoner, btype) Then

                    MsgBox("Student Record updated", MsgBoxStyle.Information, "Update Student")

                    Dim command As New MySqlCommand("SELECT * FROM `donoation` ")
                    fillgrid(command)

                Else

                    MsgBox("Error", MsgBoxStyle.Critical, "update Student")
                End If

            Else

                MsgBox("Empty Spaces available", MsgBoxStyle.Critical, "update Student")
            End If
        End If
    End Sub

    'function to verify data
    Function verif() As Boolean
        If txtfname.Text.Trim() = "" Or txtmname.Text.Trim() = "" Or txtlname.Text.Trim() = "" Or txtaddress.Text.Trim() = "" Or txtcontact.Text.Trim() = "" Or cmbblood.Text.Trim() = "" Then
            Return False

        Else

            Return True
        End If

    End Function

   

    Private Sub Donors_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ', `next_donation`
        Dim command As New MySqlCommand("SELECT `id`, `first_name` as 'First Name', `middle_name` as 'Middle Name', `last_name` as 'Last Name', `birth_date` as 'Date Of Birth', `gender`, `address`, `contact`, `First_time_donor` as 'First Donor', `last_time_donate` as 'Date Of First Donation' , `next_donation` as 'Date for Next Donation', `times_donated` as 'times Donated', `Blood_type` as 'Blood Type' FROM `donoation` ORDER by `times_donated` DESC")
        fillgrid(command)
    End Sub

    'sub to fill gridview
    Sub fillgrid(ByVal command As MySqlCommand)

        DataGridView1.ReadOnly = True

        Dim pickcol As New DataGridViewImageColumn()

        DataGridView1.RowTemplate.Height = 80

        DataGridView1.DataSource = DONATE.getdonors(command)

        ' pickcol = DataGridView1.Columns(7)

        'pickcol.ImageLayout = DataGridViewImageCellLayout.Stretch

        DataGridView1.AllowUserToAddRows = False

        DataGridView1.DataSource = DONATE.getdonors(command)

        'display student count using the gridview
        lbtotalstudents.Text = "Total Donors: " & DataGridView1.Rows.Count

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

        txtid.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtfname.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtmname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtlname.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(4).Value
        If DataGridView1.CurrentRow.Cells(5).Value = "female" Then
            rdfemale.Checked = True
        Else
            rdfemale.Checked = True
        End If

        txtaddress.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        txtcontact.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString

        If DataGridView1.CurrentRow.Cells(8).Value = "no" Then
            rdno.Checked = True
        Else
            rdyes.Checked = True
        End If

        DateTimePicker2.Value = DataGridView1.CurrentRow.Cells(9).Value
        cmbblood.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString
        'txtaddress.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
    End Sub
End Class
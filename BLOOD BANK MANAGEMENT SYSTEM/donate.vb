Imports MySql.Data.MySqlClient
Public Class donate

    Dim db As New mydb
    'function to insert a new donor
    Public Function InsertDonor(ByVal fname As String, ByVal mname As String, ByVal lname As String, ByVal bdate As Date, ByVal gender As String, ByVal address As String, ByVal phone As String, ByVal fdoner As String, ByVal ldoner As Date, ByVal next_due As Date, ByVal times_donated As Integer, ByVal btype As String) As Boolean
        ' ByVal next_due As Date
        '@nd
        ', `next_donation`
        Dim command As New MySqlCommand("INSERT INTO `donoation`(`first_name`, `middle_name`, `last_name`, `birth_date`, `gender`, `address`, `contact`, `First_time_donor`, `last_time_donate`, `next_donation`, `times_donated`, `Blood_type`) VALUES (@fn, @mn, @ln, @dbi, @gn, @addr, @ph, @fd, @ld, @nd, @td, @bt)", db.getconnection)


        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
        command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname
        command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
        command.Parameters.Add("@dbi", MySqlDbType.DateTime).Value = bdate
        command.Parameters.Add("@gn", MySqlDbType.VarChar).Value = gender
        command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address
        command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone
        command.Parameters.Add("@fd", MySqlDbType.VarChar).Value = fdoner
        command.Parameters.Add("@ld", MySqlDbType.DateTime).Value = ldoner
        command.Parameters.Add("@nd", MySqlDbType.DateTime).Value = next_due
        command.Parameters.Add("@td", MySqlDbType.Int32).Value = times_donated
        'times_donated = 1
        command.Parameters.Add("@bt", MySqlDbType.VarChar).Value = btype

        db.openconnection()

        If command.ExecuteNonQuery() = 1 Then
            ' MsgBox("New donor added")
            Return True
        Else
            'MsgBox("insert donor error")
            Return False
        End If

        db.closeconnection()

    End Function

    'function to get all student from database
    Function getdonors(ByVal command As MySqlCommand) As DataTable

        ' Dim command As New MySqlCommand("SELECT * FROM `student`")
        command.Connection = db.getconnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        Return table

    End Function

    'function to execute count query
    Function execCount(ByVal query As String) As String

        Dim command As New MySqlCommand(query, db.getconnection)

        db.openconnection()

        Return command.ExecuteScalar().ToString()

        db.closeconnection()
    End Function

    Function totaldonors() As String

        Return execCount("SELECT COUNT(*) FROM `donoation`")
    End Function

    Function totalmaledonors() As String

        Return execCount("SELECT COUNT(*) FROM `donoation` WHERE `gender` = 'male'")
    End Function

    Function totalfemaledonors() As String

        Return execCount("SELECT COUNT(*) FROM `donoation` WHERE `gender` = 'female'")
    End Function

    'Function for update
    Public Function updateDonor(ByVal id As Integer, ByVal fname As String, ByVal mname As String, ByVal lname As String, ByVal bdate As Date, ByVal gender As String, ByVal address As String, ByVal phone As String, ByVal fdoner As String, ByVal ldoner As Date, ByVal btype As String) As Boolean

        Dim command As New MySqlCommand("UPDATE `donoation` SET `first_name`=@fname, `middle_name`=@mname, `last_name`=@lname,`birth_date`=@bdate,`gender`=@gn,`address`=@addr,`contact`=@pho,`First_time_donor`=@ftdone,`last_time_donate`=@ltdone,`Blood_type`=@bt WHERE id=@id", db.getconnection)

        command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id
        command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname
        command.Parameters.Add("@mname", MySqlDbType.VarChar).Value = mname
        command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname
        command.Parameters.Add("@bdate", MySqlDbType.DateTime).Value = bdate
        command.Parameters.Add("@gn", MySqlDbType.VarChar).Value = gender
        command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address
        command.Parameters.Add("@pho", MySqlDbType.VarChar).Value = phone
        command.Parameters.Add("@ftdone", MySqlDbType.VarChar).Value = fdoner
        command.Parameters.Add("@ltdone", MySqlDbType.DateTime).Value = ldoner
        command.Parameters.Add("@bt", MySqlDbType.VarChar).Value = btype

        db.openconnection()

        If command.ExecuteNonQuery() = 1 Then
            ' MsgBox("New Student added")
            Return True
        Else
            'MsgBox("insert student error")
            Return False
        End If

        db.closeconnection()
    End Function

    'function for delete
    Public Function deleteDonor(ByVal id As Integer) As Boolean

        Dim command As New MySqlCommand("DELETE FROM `donoation` WHERE `id`= @donorid", db.getconnection)

        command.Parameters.Add("@donorid", MySqlDbType.Int32).Value = id

        db.openconnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        db.closeconnection()

    End Function

    'function to check the existence of names
    Public Function checkDonorsName(ByVal Donorsmname As String, ByVal Donorslname As String) As Boolean

        Dim command As New MySqlCommand("SELECT * FROM `donoation` WHERE CONCAT(`middle_name`=@mname, `last_name`=@lname)", db.getconnection)
        command.Parameters.Add("@mname", MySqlDbType.VarChar).Value = Donorsmname
        command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = Donorslname

        Dim adapter As New MySqlDataAdapter(command)

        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count > 0 Then

            'the course already exist
            Return False
        Else
            Return True
        End If

    End Function

    Public Function inserttimesdonated(ByVal fname As String, ByVal times_donated As Integer) As Boolean

        Dim command As New MySqlCommand("UPDATE `donoation` SET `times_donated`=@tdonated WHERE `first_name`=@fname", db.getconnection)

        command.Parameters.Add("@tdonate", MySqlDbType.Int32).Value = times_donated
        ' command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname

        db.openconnection()

        If command.ExecuteNonQuery() = 1 Then
            ' MsgBox("New Student added")
            Return True
        Else
            'MsgBox("insert student error")
            Return False
        End If

        db.closeconnection()

        ' Dim adapter As New MySqlDataAdapter(command)

    End Function


End Class

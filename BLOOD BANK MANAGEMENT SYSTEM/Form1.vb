Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundImage = Image.FromFile("../../images/images3.jpg")

    End Sub

    Private Sub DonorsListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonorsListToolStripMenuItem.Click

        Dim donation As New Donation
        donation.Show(Me)
    End Sub

    Private Sub DonorsListToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DonorsListToolStripMenuItem1.Click
        Dim doners As New Donors_List

        doners.Show(Me)
    End Sub

    'request for blood
    Private Sub RequestForBloodToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RequestForBloodToolStripMenuItem1.Click
        request_blood.Show(Me)
    End Sub
End Class

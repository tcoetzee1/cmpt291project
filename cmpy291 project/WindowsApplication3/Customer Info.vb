Imports System.Data.SqlClient

Public Class Customer_Info

    Dim cid = 0

    Private Sub Customer_Info_Activated(ByVal sender As Object,
    ByVal e As System.EventArgs) Handles MyBase.Activated
        If (Main.viewCustomers = 1) Then
            If (Main.words.Count > 0) Then

                cid = Main.words.Item(0)

                TextBox1.Text = Main.words.Item(1)
                TextBox2.Text = Main.words.Item(2)
                TextBox3.Text = Main.words.Item(4)
                TextBox5.Text = Main.words.Item(3)
                TextBox6.Text = Main.words.Item(5)
                TextBox10.Text = Main.words.Item(6)

            End If
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RentalBooking.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connection As New SqlConnection(GlobalVariables.serverString) ' CHANGE DATA SOURCE

        Dim searchQuery As String = "SELECT * From [Project291].dbo.Customer Where CID=" + cid.ToString

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridView1.DataSource = table


        connection.Close()

    End Sub
End Class
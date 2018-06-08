Imports System.Data.SqlClient

Public Class Delete_Customer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' -------------------------------------------------------------------------------------
        ' Delete a customer, based on their CID
        ' -------------------------------------------------------------------------------------
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = GlobalVariables.serverString ' CHANGE DATA SOURCE

        con.Open()

        cmd.Connection = con

        cmd.CommandText = "Delete From [Project291].dbo.Customer where CID= @CID"

        If (TextBox6.Text.Length > 0) Then

            cmd.Parameters.Add(New SqlParameter("@CID", TextBox6.Text))

            If cmd.ExecuteNonQuery = 0 Then
                MessageBox.Show("Record deletion NOT successful!")
            Else
                MessageBox.Show("Record deletion successful!")
            End If

        End If

        If (TextBox6.Text.Length = 0) Then

            MessageBox.Show("enter a customer id num")

        End If

        con.Close()
        ' -------------------------------------------------------------------------------------
        Me.Close()
    End Sub

    Private Sub Delete_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
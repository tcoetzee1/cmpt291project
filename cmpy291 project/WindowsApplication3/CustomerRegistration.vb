Imports System.Data.SqlClient

Public Class CustomerRegistration

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' -----------------------------------------------------------------------------------------------------------------------------
        ' Insert a customer into the database
        ' -----------------------------------------------------------------------------------------------------------------------------
        Dim connStr = GlobalVariables.serverString ' CHANGE DATA SOURCE

        Using con = New SqlConnection(connStr)

            Dim sql = "INSERT INTO [Project291].dbo.Customer (FName, LName, City, Street, Postal_Code, Credit_Card, Goldstar)" &
                      "VALUES (@FName, @LName, @City, @Street, @Postal_Code, @Credit_Card, @Goldstar)"
            Using cmd As New SqlClient.SqlCommand(sql, con)

                Dim num = 0

                ' -------------------------------------
                If (TextBox1.Text.Length > 0) Then
                    cmd.Parameters.AddWithValue("@FName", TextBox1.Text)
                    num = num + 1
                End If
                If (TextBox1.Text.Length = 0) Then
                    MessageBox.Show("enter a first name")
                End If
                ' -------------------------------------

                ' -------------------------------------
                If (TextBox2.Text.Length > 0) Then
                    cmd.Parameters.AddWithValue("@LName", TextBox2.Text)
                    num = num + 1
                End If
                If (TextBox2.Text.Length = 0) Then
                    MessageBox.Show("enter a last name")
                End If
                ' -------------------------------------

                ' -------------------------------------
                If (TextBox5.Text.Length > 0) Then
                    cmd.Parameters.AddWithValue("@City", TextBox5.Text)
                    num = num + 1
                End If
                If (TextBox5.Text.Length = 0) Then
                    MessageBox.Show("enter a city name")
                End If
                ' -------------------------------------

                ' -------------------------------------
                If (TextBox3.Text.Length > 0) Then
                    cmd.Parameters.AddWithValue("@Street", TextBox3.Text)
                    num = num + 1
                End If
                If (TextBox3.Text.Length = 0) Then
                    MessageBox.Show("enter a address")
                End If
                ' -------------------------------------

                ' -------------------------------------
                If (TextBox6.Text.Length > 0) Then
                    cmd.Parameters.AddWithValue("@Postal_Code", TextBox6.Text)
                    num = num + 1
                End If
                If (TextBox6.Text.Length = 0) Then
                    MessageBox.Show("enter a postal code")
                End If
                ' -------------------------------------

                ' -------------------------------------
                If (TextBox10.Text.Length > 0) Then
                    cmd.Parameters.AddWithValue("@Credit_Card", TextBox10.Text)
                    num = num + 1
                End If
                If (TextBox10.Text.Length = 0) Then
                    MessageBox.Show("enter a credit card")
                End If
                ' -------------------------------------

                cmd.Parameters.AddWithValue("@Goldstar", "0")

                If (num = 6) Then ' if all fields are entered then start the insertion
                    con.Open()

                    If cmd.ExecuteNonQuery = 0 Then
                        MessageBox.Show("Record insertion NOT successful!")
                    Else
                        MessageBox.Show("Record insertion successful!")
                    End If

                    con.Close()

                    Me.Close()

                End If

            End Using
        End Using
        ' -----------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub CustomerRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
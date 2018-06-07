Imports System.Data.SqlClient

Public Class Main
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Delete_Customer.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Delete_Employee.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles CheckInBut.Click

        Test.TopLevel = False
        Test.TopMost = True
        SplitContainer2.Panel2.Controls.Add(Test.Panel1)
        Test.Show()

        ' ---------------------------------------------------------------------------------------------
        ' Fills table with data from SQL query
        ' ---------------------------------------------------------------------------------------------
        Dim connection As New SqlConnection("Data Source=COMPOOPTER;Integrated Security=True") ' CHANGE DATA SOURCE
        Dim searchQuery As String = "UPDATE * From [Project291].dbo.Customer"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridView1.DataSource = table
        ' ---------------------------------------------------------------------------------------------    End Sub
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CustomerRegistration.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EmployeeRegister.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Customer_Search.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Customer_Search.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Test.TopLevel = False
        Test.TopMost = True
        SplitContainer2.Panel2.Controls.Add(Test.Panel1)
        Test.Show()

        ' ---------------------------------------------------------------------------------------------
        ' Fills table with data from SQL query
        ' ---------------------------------------------------------------------------------------------
        Dim connection As New SqlConnection("Data Source=COMPOOPTER;Integrated Security=True") ' CHANGE DATA SOURCE
        Dim searchQuery As String = "SELECT * From [Project291].dbo.Customer"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridView1.DataSource = table
        ' ---------------------------------------------------------------------------------------------

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Test.TopLevel = False
        Test.TopMost = True
        SplitContainer2.Panel2.Controls.Add(Test.Panel1)
        Test.Show()

        ' ---------------------------------------------------------------------------------------------
        ' Fills table with data from SQL query
        ' ---------------------------------------------------------------------------------------------
        Dim connection As New SqlConnection("Data Source=COMPOOPTER;Integrated Security=True") ' CHANGE DATA SOURCE
        Dim searchQuery As String = "SELECT * From [Project291].dbo.Branch"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridView1.DataSource = table
        ' ---------------------------------------------------------------------------------------------
    End Sub
End Class
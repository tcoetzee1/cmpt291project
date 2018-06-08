Imports System.Data.SqlClient
Imports System.Text
Public Class Main

    Public Shared viewCars = 0
    Public Shared viewBranches = 0
    Public Shared viewCustomers = 0

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Delete_Customer.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Delete_Employee.Show()
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
        ' ---------------------------------------------------------------------------------------------
        ' Fills table with data from SQL query
        ' ---------------------------------------------------------------------------------------------
        Dim connection As New SqlConnection(GlobalVariables.serverString) ' CHANGE DATA SOURCE
        Dim searchQuery As String = "SELECT * From [Project291].dbo.Customer"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridView1.DataSource = table

        DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
        ' ---------------------------------------------------------------------------------------------
        viewCustomers = 1
        viewCars = 0
        viewBranches = 0

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' ---------------------------------------------------------------------------------------------
        ' Fills table with data from SQL query
        ' ---------------------------------------------------------------------------------------------
        Dim connection As New SqlConnection(GlobalVariables.serverString) ' CHANGE DATA SOURCE
        Dim searchQuery As String = "SELECT * From [Project291].dbo.Branch"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridView1.DataSource = table

        DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
        ' ---------------------------------------------------------------------------------------------
        viewBranches = 1
        viewCars = 0
        viewCustomers = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' ---------------------------------------------------------------------------------------------
        ' Fills table with data from SQL query
        ' ---------------------------------------------------------------------------------------------
        Dim connection As New SqlConnection(GlobalVariables.serverString) ' CHANGE DATA SOURCE
        Dim searchQuery As String = "SELECT * From [Project291].dbo.Car, [Project291].dbo.Branch Where Car.BID=Branch.BID and Branch.BID=2"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridView1.DataSource = table

        DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
        ' ---------------------------------------------------------------------------------------------
        viewCars = 1
        viewBranches = 0
        viewCustomers = 0
    End Sub

    Public Shared words As New List(Of String)

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim i, j As Integer
        i = DataGridView1.CurrentRow.Index

        words.Clear()

        Dim s As String

        Dim index As Integer = 0
        While index < 100
            Try
                s = DataGridView1.Item(index, i).Value.ToString
                words.Add(s)
                index = index + 1
            Catch ex As Exception
                index = 100
            End Try
        End While

        If viewCustomers = 1 Then
            Customer_Info.Show()
        End If

    End Sub

End Class
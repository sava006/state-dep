Imports System.Data.SqlClient
Public Class Form1
    Dim objConnection As New SqlConnection("server=HARRY-HP\SQLEXPRESS;database=support; Trusted_Connection=Yes")
    Dim objDataAdapter As New SqlDataAdapter
    Dim objDataTable As New DataTable



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setupRolesComboBox()
        loadTechnicianDataGridView()
    End Sub

    Private Sub setupRolesComboBox()
        Dim roles As String() = {"PC Support", "Mac Support", "Server Support", "Network support"}
        cboTechRole.Items.AddRange(roles)
        cboTechRole.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub loadTechnicianDataGridView()
        'use should only  select whole rows; and one at a time
        grdTechnicians.MultiSelect = False
        grdTechnicians.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'In this app, user will not be able to edit the table directly, they will be adding techicians using the text box/combo boxes
        grdTechnicians.EditMode = DataGridViewEditMode.EditProgrammatically
        'So hid the letfmost edit column (the row headers)
        grdTechnicians.RowHeadersVisible = False
        'Size the columns to fit the data they contain
        grdTechnicians.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        'Get data from DB and add it to Data  GridView
        objDataAdapter = New SqlDataAdapter("Select * from technicians", objConnection)
        objDataAdapter.Fill(objDataTable)
        objConnection.Close()
        'Fi we want to modify and/or delecte data, it's useful to have commandbuilder
        'to automatically generate insert, update or delete statements for our data
        Dim SqlCommandBuilder As New SqlCommandBuilder(objDataAdapter)
        'Tell the DataGridView to use this DataTAble as its DataSource
        grdTechnicians.DataSource = objDataTable

    End Sub

    Private Sub btnAddTech_Click(sender As Object, e As EventArgs) Handles btnAddTech.Click

        'Read in data from text boxes and combobox; simplle validation
        'other checks - is the email address is in a valid format?
        'You can probably think of other  things to check
        If txtTechEmail Is String.Empty Or txtTechName Is String.Empty Or
            cboTechRole.SelectedItem Is Nothing Then

            MessageBox.Show("Check you've entered all the data needed")

        Else
            'If the data is ok, add to and DataGridView(via DataTable)
            '  adn to database (via DataTable and DataAdapter).

            Dim newTechRow As DataRow = objDataTable.NewRow()
            'Add the data from the textboxes, combobox. Use the column names
            newTechRow("name") = txtTechName.Text
            newTechRow("email") = txtTechEmail.Text
            newTechRow("role") = cboTechRole.SelectedItem
            'add to the datatable; this also updates the dataGrid
            objDataTable.Rows.Add(newTechRow)
            'tell the dataAdapter that the datatabble has changed and send the changes to the database 
            objDataAdapter.Update(objDataTable)
        End If
    End Sub

    Private Sub grdTechnicians_SelectionChanged(sender As Object, e As EventArgs) Handles grdTechnicians.SelectionChanged

        'populates the textBoxes and Combobox with info from the selected row
        'SelectedRows returns an array of rows. Since the DataGridView is set up
        'to only allow one row to be selected, our selected row is element 0.

        Dim row As DataGridViewRow = grdTechnicians.SelectedRows.Item(0)
        'From the row, get each cell, get the formatted value, turn it to a string
        'and use it to set the text or selected itme of the component
        txtTechName.Text = row.Cells.Item(1).FormattedValue.ToString
        txtTechEmail.Text = row.Cells.Item(2).FormattedValue.ToString
        cboTechRole.SelectedItem = row.Cells.Item(3).FormattedValue.ToString
    End Sub


    Private Sub btnEditTech_Click(sender As Object, e As EventArgs) Handles btnEditTech.Click
        Dim row As DataGridViewRow = grdTechnicians.SelectedRows.Item(0)
        Dim techID As String = row.Cells.Item(0).FormattedValue.ToString

        'Read in the values from the textboxes and combox. **this needs validation
        Dim newName As String = txtTechName.Text
        Dim newemail As String = txtTechEmail.Text
        Dim newRole As String = cboTechRole.SelectedItem.ToString

        Dim editTechrow As DataRow = objDataTable.Select("id = " & techID)(0)

        'Use column values to update this row with the new data. IT doesn't if it's different or not.
        'As this updates the DataTable, the DataGridView will see the changes and update too
        editTechrow("name") = newName
        editTechrow("email") = newemail
        editTechrow("role") = newRole

        'Request the dataAdapter updates the database
        objDataAdapter.Update(objDataTable)

    End Sub

    Private Sub btnEmailTech_Click(sender As Object, e As EventArgs) Handles btnEmailTech.Click

        'Get the selected row
        Dim row As DataGridViewRow = grdTechnicians.SelectedRows.Item(0)
        'from the row, get the second cell- the one with the email in
        Dim techEmail As String = row.Cells.Item(2).FormattedValue.ToString
        Dim subject As String = "Hello from the Technician Management Application!"
        Try
            Process.Start(String.Format("mailto:{0}?subject={1}", techEmail, subject))

        Catch ex As Exception
            MessageBox.Show("No default email client (e.g. Outlook) is configured")

        End Try
    End Sub
End Class

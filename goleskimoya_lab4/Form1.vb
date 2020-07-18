Option Strict On

' Name:         Moya Goleski
' Date:         2020-07-17
' Description:  The purpose of this program is to create a car inventory application that will
'               allow the user to create and update content. The content will include the Make, 
'               Model, Year, Price, and a value indicating wheter the car is New is used.
Public Class carInventoryForm

#Region "Variables and Constants"
    ' min price that can be entered
    Const MIN_PRICE As Integer = 0

    Dim cars As New List(Of CarClass)
    Dim editMode As Boolean = False
    Dim updatingData As Boolean = False
    Dim currentlySelectedIndex As Integer = -1
#End Region

#Region "Event Handlers"
    ' EXIT BUTTON
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exits the form
        Application.Exit()
    End Sub

    ' RESET BUTTON
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Resets the form
        ResetForm()
    End Sub

    ' ENTER BUTTON
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' users input for Make
        Dim inputMake As String = cbMake.Text
        ' users input for Model
        Dim inputModel As String = txtModel.Text
        ' users input for Year
        Dim inputYear As String = cbYear.Text
        ' users input for Price
        Dim inputPrice As String = txtPrice.Text
        ' user input for New or Used
        Dim inputNewStatus As Boolean = ckNew.Checked
        ' errors for validation
        Dim errors As String = ValidateInputs(inputMake, inputModel, inputYear, inputPrice)
        ' variable for Car Class
        Dim carInventory As CarClass

        If (String.IsNullOrEmpty(errors)) Then
            ' validation was successful
            If (editMode) Then
                ' updating existing car
                ' updates Status
                cars(currentlySelectedIndex).CarStatus = inputNewStatus
                ' updates Make
                cars(currentlySelectedIndex).CarMake = inputMake
                ' updates Model
                cars(currentlySelectedIndex).CarModel = inputModel
                ' updates Year
                cars(currentlySelectedIndex).CarYear = inputYear
                ' updates Price
                cars(currentlySelectedIndex).CarPrice = inputPrice
                ' calling UpdateInventoryList function
                UpdateCarInventoryList()
                ' calling ResetForm function
                ResetForm()
                ' message to show car update was successful
                txtOutput.Text = "Update Successful"
            Else
                ' create new car
                carInventory = New CarClass(inputMake, inputModel, inputYear, inputPrice, inputNewStatus)
                ' adds to car class
                cars.Add(carInventory)
                ' calling UpdateInventoryList function
                UpdateCarInventoryList()
                ' calling ResetForm function
                ResetForm()
                ' message to show that new car was added
                txtOutput.Text = "New inventory added"
            End If
        Else
            ' validation failed
            txtOutput.Text = errors
        End If
    End Sub

    ' HANDLES SELECTION OF CAR FROM LIST
    Private Sub lvCarList_IndexChanged(sender As Object, e As EventArgs) Handles lvCarList.SelectedIndexChanged

        Dim carInventory As CarClass

        If (Not lvCarList.FocusedItem Is Nothing) Then

            currentlySelectedIndex = lvCarList.FocusedItem.Index
            carInventory = cars(currentlySelectedIndex)

            editMode = True

            cbMake.Text = carInventory.CarMake
            txtModel.Text = carInventory.CarModel
            cbYear.Text = carInventory.CarYear
            txtPrice.Text = carInventory.CarPrice

            ckNew.Checked = carInventory.CarStatus

        End If

    End Sub

    ' Prevents the user from using checkboxes in CarList
    Private Sub lvwCustomers_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvCarList.ItemCheck
        If (Not updatingData) Then
            e.NewValue = e.CurrentValue
        End If
    End Sub


#End Region

#Region "Subs and Functions"

    ' RESETS THE FORM
    Private Sub ResetForm()
        ' sets Make combo box back to default (empty)
        cbMake.SelectedIndex = -1
        ' sets Model text to empty 
        txtModel.Text = String.Empty
        ' sets Year combo box back to default (empty)
        cbYear.SelectedIndex = -1
        ' sets Price text to empty 
        txtPrice.Text = String.Empty
        ' sets New checkbox to unchecked
        ckNew.Checked = False
        ' sets edit more to false
        editMode = False
    End Sub

    ' FUNCTION TO VALIDATE THE INPUT
    Function ValidateInputs(Make As String, Model As String, Year As String, Price As String) As String
        ' empties error message
        Dim errorMessage As String = String.Empty
        ' var. to make year integer
        ' Dim yearAsInteger As Integer
        ' var. to make price decimal
        Dim priceAsDecimal As Decimal

        ' if Make is not selected
        If (String.IsNullOrWhiteSpace(Make)) Then
            ' error message
            errorMessage += "Please enter a valid make" & Environment.NewLine
        End If
        ' if Model is empty
        If (String.IsNullOrWhiteSpace(Model)) Then
            ' error message
            errorMessage += "Please enter a valid model" & Environment.NewLine
        End If
        ' if Year not selected
        If (String.IsNullOrWhiteSpace(Year)) Then
            ' if Year is not integer
            ' If Integer.TryParse(Year, yearAsInteger) Then
            ' error message
            errorMessage += "Please enter a valid year" & Environment.NewLine
            ' End If
        End If
        ' if price not selected
        If (String.IsNullOrWhiteSpace(Price)) Then
            errorMessage += "Please enter a price" & Environment.NewLine
            ' if price is not decimal
            Decimal.TryParse(Price, priceAsDecimal)
            ' if price not in range
            If (priceAsDecimal <= MIN_PRICE) Then
                ' error message
                errorMessage += "Please enter a valid price greater than " & MIN_PRICE & Environment.NewLine
            End If
        End If

        ' returns if there are any error message(s)
        Return errorMessage
    End Function

    ' UPDATES CAR LIST
    ' reloads current list of cars in ListView
    Private Sub UpdateCarInventoryList()

        Dim carListItem As ListViewItem

        updatingData = True
        lvCarList.Items.Clear()

        For Each carInventory As CarClass In cars

            carListItem = New ListViewItem()

            carListItem.Checked = carInventory.CarStatus
            carListItem.SubItems.Add(carInventory.CarIdentification.ToString)
            carListItem.SubItems.Add(carInventory.CarMake)
            carListItem.SubItems.Add(carInventory.CarModel)
            carListItem.SubItems.Add(carInventory.CarYear)
            carListItem.SubItems.Add(carInventory.CarPrice)

            lvCarList.Items.Add(carListItem)

        Next

        updatingData = False

    End Sub

#End Region

End Class
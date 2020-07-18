<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class carInventoryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.cbMake = New System.Windows.Forms.ComboBox()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.ckNew = New System.Windows.Forms.CheckBox()
        Me.lvCarList = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.CarToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(12, 22)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(100, 23)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make:"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarToolTip.SetToolTip(Me.lblMake, "Select Make of Car")
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(12, 74)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(100, 23)
        Me.lblModel.TabIndex = 1
        Me.lblModel.Text = "M&odel:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarToolTip.SetToolTip(Me.lblModel, "Enter Model of Car")
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(12, 124)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(100, 23)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "&Year:"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarToolTip.SetToolTip(Me.lblYear, "Select Year of Car")
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(12, 175)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "&Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarToolTip.SetToolTip(Me.lblPrice, "Enter Price of Car")
        '
        'lblNew
        '
        Me.lblNew.Location = New System.Drawing.Point(12, 221)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(100, 23)
        Me.lblNew.TabIndex = 4
        Me.lblNew.Text = "&New:"
        Me.lblNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarToolTip.SetToolTip(Me.lblNew, "Check if New Car")
        '
        'cbMake
        '
        Me.cbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMake.FormattingEnabled = True
        Me.cbMake.Items.AddRange(New Object() {"Mini Cooper", "Chevrolet", "Ford", "BMW", "Jeep", "Madza"})
        Me.cbMake.Location = New System.Drawing.Point(134, 22)
        Me.cbMake.Name = "cbMake"
        Me.cbMake.Size = New System.Drawing.Size(121, 28)
        Me.cbMake.TabIndex = 5
        '
        'cbYear
        '
        Me.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Items.AddRange(New Object() {"1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cbYear.Location = New System.Drawing.Point(134, 124)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(121, 28)
        Me.cbYear.TabIndex = 6
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(134, 74)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 26)
        Me.txtModel.TabIndex = 7
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(134, 175)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 26)
        Me.txtPrice.TabIndex = 8
        '
        'ckNew
        '
        Me.ckNew.AutoSize = True
        Me.ckNew.Location = New System.Drawing.Point(134, 221)
        Me.ckNew.Name = "ckNew"
        Me.ckNew.Size = New System.Drawing.Size(22, 21)
        Me.ckNew.TabIndex = 9
        Me.ckNew.UseVisualStyleBackColor = True
        '
        'lvCarList
        '
        Me.lvCarList.CheckBoxes = True
        Me.lvCarList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colId, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvCarList.FullRowSelect = True
        Me.lvCarList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvCarList.HideSelection = False
        Me.lvCarList.Location = New System.Drawing.Point(66, 264)
        Me.lvCarList.MultiSelect = False
        Me.lvCarList.Name = "lvCarList"
        Me.lvCarList.Size = New System.Drawing.Size(434, 201)
        Me.lvCarList.TabIndex = 11
        Me.lvCarList.UseCompatibleStateImageBehavior = False
        Me.lvCarList.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        Me.colNew.Width = 40
        '
        'colId
        '
        Me.colId.Text = "ID"
        Me.colId.Width = 40
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        Me.colModel.Width = 50
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        Me.colYear.Width = 50
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(66, 487)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(434, 101)
        Me.txtOutput.TabIndex = 12
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(232, 610)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(84, 35)
        Me.btnEnter.TabIndex = 14
        Me.btnEnter.Text = "&Enter"
        Me.CarToolTip.SetToolTip(Me.btnEnter, "Enter the form")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(416, 610)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 35)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.CarToolTip.SetToolTip(Me.btnExit, "Exit the form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(324, 610)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(84, 35)
        Me.btnReset.TabIndex = 16
        Me.btnReset.Text = "&Reset"
        Me.CarToolTip.SetToolTip(Me.btnReset, "Reset the Form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'carInventoryForm
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(574, 659)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.lvCarList)
        Me.Controls.Add(Me.ckNew)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.cbYear)
        Me.Controls.Add(Me.cbMake)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "carInventoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblNew As Label
    Friend WithEvents cbMake As ComboBox
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents ckNew As CheckBox
    Friend WithEvents lvCarList As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colId As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents CarToolTip As ToolTip
End Class

' This program allows the user to enter a specific time in one of four time zones, adjusting the others accordingly
Public Class frmTimeZones

    ' Variables
    Dim input As String
    Dim inputAsInt As Integer
    Dim militaryTime As DateTime
    Dim formattedTime As String

    ' Sub to display Eastern time zone, and adjust other time zones accordingly
    Private Sub btnEastern_Click(sender As Object, e As EventArgs) Handles btnEastern.Click
        ' If statements to properly validate and format input
        If txtEastern.TextLength < 4 Then
            MessageBox.Show("Please enter four numeric characters.")
            txtEastern.Clear()
        ElseIf Integer.TryParse(txtEastern.Text, inputAsInt) = False Then
            MessageBox.Show("Please enter four numeric characters.")
            txtEastern.Clear()
        ElseIf chkEasternAM.Checked And chkEasternPM.Checked Then
            MessageBox.Show("A.M. and P.M. cannot be checked simultaneously.")
        ElseIf chkEasternAM.Checked Then
            input = txtEastern.Text.Insert(2, ":")
            input += "am"
            If IsDate(input) = True Then
                adjustTimes("easternAM")
            Else
                MessageBox.Show("Please enter a valid time.")
                txtEastern.Clear()
            End If
        ElseIf chkEasternPM.Checked Then
            input = txtEastern.Text.Insert(2, ":")
            input += "pm"
            If IsDate(input) = True Then
                adjustTimes("easternPM")
            Else
                MessageBox.Show("Please enter a valid time.")
                txtEastern.Clear()
            End If
        Else
        MessageBox.Show("Please check either A.M. or P.M. before clicking Submit.")
        End If
    End Sub

    ' Sub to display Central time zone, and adjust other time zones accordingly
    Private Sub btnCentral_Click(sender As Object, e As EventArgs) Handles btnCentral.Click
        ' If statements to properly format input
        If txtCentral.TextLength < 4 Then
            MessageBox.Show("Please enter four numeric characters.")
            txtCentral.Clear()
        ElseIf Integer.TryParse(txtCentral.Text, inputAsInt) = False Then
            MessageBox.Show("Please enter four numeric characters.")
            txtCentral.Clear()
        ElseIf chkCentralAM.Checked And chkCentralPM.Checked Then
            MessageBox.Show("A.M. and P.M. cannot be checked simultaneously.")
        ElseIf chkCentralAM.Checked Then
            input = txtCentral.Text.Insert(2, ":")
            input += "am"
            If IsDate(input) = True Then
                adjustTimes("centralAM")
            Else
                MessageBox.Show("Please enter a valid time.")
                txtCentral.Clear()
            End If
        ElseIf chkCentralPM.Checked Then
            input = txtCentral.Text.Insert(2, ":")
            input += "pm"
            If IsDate(input) = True Then
                adjustTimes("centralPM")
            Else
                MessageBox.Show("Please enter a valid time.")
                txtCentral.Clear()
            End If
        Else
            MessageBox.Show("Please check either A.M. or P.M. before clicking submit.")
        End If
    End Sub

    ' Sub to display Mountain time zone, and adjust other time zones accordingly
    Private Sub btnMountain_Click(sender As Object, e As EventArgs) Handles btnMountain.Click
        ' If statements to properly format input
        If txtMountain.TextLength < 4 Then
            MessageBox.Show("Please enter four numeric characters.")
            txtMountain.Clear()
        ElseIf Integer.TryParse(txtMountain.Text, inputAsInt) = False Then
            MessageBox.Show("Please enter four numeric characters.")
            txtMountain.Clear()
        ElseIf chkMountainAM.Checked And chkMountainPM.Checked Then
            MessageBox.Show("A.M. and P.M. cannot be checked simultaneously.")
        ElseIf chkMountainAM.Checked Then
            input = txtMountain.Text.Insert(2, ":")
            input += "am"
            If IsDate(input) = True Then
                adjustTimes("mountainAM")
            Else
                MessageBox.Show("Please enter a valid time.")
                txtMountain.Clear()
            End If
        ElseIf chkMountainPM.Checked Then
            input = txtMountain.Text.Insert(2, ":")
            input += "pm"
            If IsDate(input) = True Then
                adjustTimes("mountainPM")
            Else
                MessageBox.Show("Please enter a valid time.")
                txtMountain.Clear()
            End If
        Else
            MessageBox.Show("Please check either A.M. or P.M. before clicking submit.")
        End If
    End Sub

    ' Sub to display Pacific time zone, and adjust other time zones accordingly
    Private Sub btnPacific_Click(sender As Object, e As EventArgs) Handles btnPacific.Click
        ' If statements to properly format input
        If txtPacific.TextLength < 4 Then
            MessageBox.Show("Please enter four numeric characters.")
            txtPacific.Clear()
        ElseIf Integer.TryParse(txtPacific.Text, inputAsInt) = False Then
            MessageBox.Show("Please enter four numeric characters.")
            txtPacific.Clear()
        ElseIf chkPacificAM.Checked And chkPacificPM.Checked Then
            MessageBox.Show("A.M. and P.M. cannot be checked simultaneously.")
        ElseIf chkPacificAM.Checked Then
            input = txtPacific.Text.Insert(2, ":")
            input += "am"
            If IsDate(input) = True Then
                adjustTimes("pacificAM")
            Else
                MessageBox.Show("Please enter a valid time.")
                txtPacific.Clear()
            End If
        ElseIf chkPacificPM.Checked Then
            input = txtPacific.Text.Insert(2, ":")
            input += "pm"
            If IsDate(input) = True Then
                adjustTimes("pacificPM")
            Else
                MessageBox.Show("Please enter a valid time.")
                txtPacific.Clear()
            End If
        Else
            MessageBox.Show("Please check either A.M. or P.M. before clicking submit.")
        End If
    End Sub

    'Sub to ensure Submit button is clicked when user presses Enter when focused in textbox
    Private Sub txtEastern_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEastern.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnEastern.PerformClick()
        End If
    End Sub

    'Sub to ensure Submit button is clicked when user presses Enter when focused in textbox
    Private Sub txtCentral_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCentral.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnCentral.PerformClick()
        End If
    End Sub

    'Sub to ensure Submit button is clicked when user presses Enter when focused in textbox
    Private Sub txtMountain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMountain.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnMountain.PerformClick()
        End If
    End Sub

    'Sub to ensure Submit button is clicked when user presses Enter when focused in textbox
    Private Sub txtPacific_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPacific.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnPacific.PerformClick()
        End If
    End Sub

    ' Sub to show About Box when user clicks About button
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click

        AboutBox2.Show()
    End Sub

    ' Sub to ensure all textboxes and checkboxes are cleared when Clear button is clicked
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearEverything()
    End Sub

    ' Sub to ensure application closes when user clicks Exit
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ' User defined sub to ensure all textboxes and checkboxes clear when the Clear button is clicked
    Private Sub clearEverything()
        txtCentral.Clear()
        txtEastern.Clear()
        txtMountain.Clear()
        txtPacific.Clear()
        chkCentralAM.Checked = False
        chkCentralPM.Checked = False
        chkEasternAM.Checked = False
        chkEasternPM.Checked = False
        chkMountainAM.Checked = False
        chkMountainPM.Checked = False
        chkPacificAM.Checked = False
        chkPacificPM.Checked = False
    End Sub

    ' User defined function to convert time zones
    Function timeConverter(ByRef time As DateTime, ByRef num As Integer) As DateTime
        time = time.AddHours(num)
        Return time
    End Function

    ' User defined sub to adjust all time zones
    Sub adjustTimes(str)
        Select Case str
            Case "easternAM"
                militaryTime = Convert.ToDateTime(input)
                picTimeZone.Image = My.Resources.Eastern
                formattedTime = militaryTime.ToShortTimeString
                txtEastern.Text = formattedTime
                militaryTime = timeConverter(militaryTime, -1)
                formattedTime = militaryTime.ToShortTimeString
                txtCentral.Text = formattedTime
                militaryTime = timeConverter(militaryTime, -1)
                formattedTime = militaryTime.ToShortTimeString
                txtMountain.Text = formattedTime
                militaryTime = timeConverter(militaryTime, -1)
                formattedTime = militaryTime.ToShortTimeString
                txtPacific.Text = formattedTime
            Case "easternPM"
                militaryTime = Convert.ToDateTime(input)
                picTimeZone.Image = My.Resources.Eastern
                formattedTime = militaryTime.ToShortTimeString
                txtEastern.Text = formattedTime
                militaryTime = timeConverter(militaryTime, -1)
                formattedTime = militaryTime.ToShortTimeString
                txtCentral.Text = formattedTime
                militaryTime = timeConverter(militaryTime, -1)
                formattedTime = militaryTime.ToShortTimeString
                txtMountain.Text = formattedTime
                militaryTime = timeConverter(militaryTime, -1)
                formattedTime = militaryTime.ToShortTimeString
                txtPacific.Text = formattedTime
            Case "centralAM"
                militaryTime = Convert.ToDateTime(input)
                picTimeZone.Image = My.Resources.Central
                formattedTime = militaryTime.ToShortTimeString
                txtCentral.Text = formattedTime
                militaryTime = militaryTime.AddHours(1)
                formattedTime = militaryTime.ToShortTimeString
                txtEastern.Text = formattedTime
                militaryTime = militaryTime.AddHours(-2)
                formattedTime = militaryTime.ToShortTimeString
                txtMountain.Text = formattedTime
                militaryTime = militaryTime.AddHours(-1)
                formattedTime = militaryTime.ToShortTimeString
                txtPacific.Text = formattedTime
            Case "centralPM"
                militaryTime = Convert.ToDateTime(input)
                picTimeZone.Image = My.Resources.Central
                formattedTime = militaryTime.ToShortTimeString
                txtCentral.Text = formattedTime
                militaryTime = militaryTime.AddHours(1)
                formattedTime = militaryTime.ToShortTimeString
                txtEastern.Text = formattedTime
                militaryTime = militaryTime.AddHours(-2)
                formattedTime = militaryTime.ToShortTimeString
                txtMountain.Text = formattedTime
                militaryTime = militaryTime.AddHours(-1)
                formattedTime = militaryTime.ToShortTimeString
                txtPacific.Text = formattedTime
            Case "mountainAM"
                militaryTime = Convert.ToDateTime(input)
                picTimeZone.Image = My.Resources.Mountain
                formattedTime = militaryTime.ToShortTimeString
                txtMountain.Text = formattedTime
                militaryTime = militaryTime.AddHours(2)
                formattedTime = militaryTime.ToShortTimeString
                txtEastern.Text = formattedTime
                militaryTime = militaryTime.AddHours(-1)
                formattedTime = militaryTime.ToShortTimeString
                txtCentral.Text = formattedTime
                militaryTime = militaryTime.AddHours(-2)
                formattedTime = militaryTime.ToShortTimeString
                txtPacific.Text = formattedTime
            Case "mountainPM"
                militaryTime = Convert.ToDateTime(input)
                picTimeZone.Image = My.Resources.Mountain
                formattedTime = militaryTime.ToShortTimeString
                txtMountain.Text = formattedTime
                militaryTime = militaryTime.AddHours(2)
                formattedTime = militaryTime.ToShortTimeString
                txtEastern.Text = formattedTime
                militaryTime = militaryTime.AddHours(-1)
                formattedTime = militaryTime.ToShortTimeString
                txtCentral.Text = formattedTime
                militaryTime = militaryTime.AddHours(-2)
                formattedTime = militaryTime.ToShortTimeString
                txtPacific.Text = formattedTime
            Case "pacificAM"
                militaryTime = Convert.ToDateTime(input)
                picTimeZone.Image = My.Resources.Pacific
                formattedTime = militaryTime.ToShortTimeString
                txtPacific.Text = formattedTime
                militaryTime = militaryTime.AddHours(-1)
                formattedTime = militaryTime.ToShortTimeString
                txtMountain.Text = formattedTime
                militaryTime = militaryTime.AddHours(-1)
                formattedTime = militaryTime.ToShortTimeString
                txtCentral.Text = formattedTime
                militaryTime = militaryTime.AddHours(-1)
                formattedTime = militaryTime.ToShortTimeString
                txtEastern.Text = formattedTime
            Case "pacificPM"
                militaryTime = Convert.ToDateTime(input)
                picTimeZone.Image = My.Resources.Pacific
                formattedTime = militaryTime.ToShortTimeString
                txtPacific.Text = formattedTime
                militaryTime = militaryTime.AddHours(-1)
                formattedTime = militaryTime.ToShortTimeString
                txtMountain.Text = formattedTime
                militaryTime = militaryTime.AddHours(-1)
                formattedTime = militaryTime.ToShortTimeString
                txtCentral.Text = formattedTime
                militaryTime = militaryTime.AddHours(-1)
                formattedTime = militaryTime.ToShortTimeString
                txtEastern.Text = formattedTime
        End Select
    End Sub
End Class
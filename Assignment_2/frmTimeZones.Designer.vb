<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTimeZones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtEastern = New System.Windows.Forms.TextBox()
        Me.picTimeZone = New System.Windows.Forms.PictureBox()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblEastern = New System.Windows.Forms.Label()
        Me.lblCentral = New System.Windows.Forms.Label()
        Me.lblMountain = New System.Windows.Forms.Label()
        Me.lblPacific = New System.Windows.Forms.Label()
        Me.txtMountain = New System.Windows.Forms.TextBox()
        Me.txtPacific = New System.Windows.Forms.TextBox()
        Me.txtCentral = New System.Windows.Forms.TextBox()
        Me.chkEasternAM = New System.Windows.Forms.CheckBox()
        Me.chkEasternPM = New System.Windows.Forms.CheckBox()
        Me.chkCentralAM = New System.Windows.Forms.CheckBox()
        Me.chkCentralPM = New System.Windows.Forms.CheckBox()
        Me.chkMountainAM = New System.Windows.Forms.CheckBox()
        Me.chkMountainPM = New System.Windows.Forms.CheckBox()
        Me.chkPacificAM = New System.Windows.Forms.CheckBox()
        Me.chkPacificPM = New System.Windows.Forms.CheckBox()
        Me.btnEastern = New System.Windows.Forms.Button()
        Me.btnCentral = New System.Windows.Forms.Button()
        Me.btnMountain = New System.Windows.Forms.Button()
        Me.btnPacific = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.picTimeZone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEastern
        '
        Me.txtEastern.Location = New System.Drawing.Point(12, 228)
        Me.txtEastern.Name = "txtEastern"
        Me.txtEastern.Size = New System.Drawing.Size(91, 20)
        Me.txtEastern.TabIndex = 0
        Me.txtEastern.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picTimeZone
        '
        Me.picTimeZone.Location = New System.Drawing.Point(12, 2)
        Me.picTimeZone.Name = "picTimeZone"
        Me.picTimeZone.Size = New System.Drawing.Size(342, 177)
        Me.picTimeZone.TabIndex = 4
        Me.picTimeZone.TabStop = False
        '
        'btnAbout
        '
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(385, 15)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 5
        Me.btnAbout.Text = "&About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(385, 115)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblEastern
        '
        Me.lblEastern.AutoSize = True
        Me.lblEastern.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEastern.Location = New System.Drawing.Point(23, 182)
        Me.lblEastern.Name = "lblEastern"
        Me.lblEastern.Size = New System.Drawing.Size(65, 20)
        Me.lblEastern.TabIndex = 7
        Me.lblEastern.Text = "Eastern"
        Me.lblEastern.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCentral
        '
        Me.lblCentral.AutoSize = True
        Me.lblCentral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCentral.Location = New System.Drawing.Point(148, 182)
        Me.lblCentral.Name = "lblCentral"
        Me.lblCentral.Size = New System.Drawing.Size(60, 20)
        Me.lblCentral.TabIndex = 8
        Me.lblCentral.Text = "Central"
        '
        'lblMountain
        '
        Me.lblMountain.AutoSize = True
        Me.lblMountain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMountain.Location = New System.Drawing.Point(259, 182)
        Me.lblMountain.Name = "lblMountain"
        Me.lblMountain.Size = New System.Drawing.Size(75, 20)
        Me.lblMountain.TabIndex = 9
        Me.lblMountain.Text = "Mountain"
        '
        'lblPacific
        '
        Me.lblPacific.AutoSize = True
        Me.lblPacific.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPacific.Location = New System.Drawing.Point(388, 182)
        Me.lblPacific.Name = "lblPacific"
        Me.lblPacific.Size = New System.Drawing.Size(55, 20)
        Me.lblPacific.TabIndex = 10
        Me.lblPacific.Text = "Pacific"
        '
        'txtMountain
        '
        Me.txtMountain.Location = New System.Drawing.Point(252, 228)
        Me.txtMountain.Name = "txtMountain"
        Me.txtMountain.Size = New System.Drawing.Size(91, 20)
        Me.txtMountain.TabIndex = 2
        Me.txtMountain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPacific
        '
        Me.txtPacific.Location = New System.Drawing.Point(369, 228)
        Me.txtPacific.Name = "txtPacific"
        Me.txtPacific.Size = New System.Drawing.Size(91, 20)
        Me.txtPacific.TabIndex = 3
        Me.txtPacific.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCentral
        '
        Me.txtCentral.Location = New System.Drawing.Point(132, 228)
        Me.txtCentral.Name = "txtCentral"
        Me.txtCentral.Size = New System.Drawing.Size(91, 20)
        Me.txtCentral.TabIndex = 1
        Me.txtCentral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkEasternAM
        '
        Me.chkEasternAM.AutoSize = True
        Me.chkEasternAM.Location = New System.Drawing.Point(12, 205)
        Me.chkEasternAM.Name = "chkEasternAM"
        Me.chkEasternAM.Size = New System.Drawing.Size(48, 17)
        Me.chkEasternAM.TabIndex = 11
        Me.chkEasternAM.Text = "A.M."
        Me.chkEasternAM.UseVisualStyleBackColor = True
        '
        'chkEasternPM
        '
        Me.chkEasternPM.AutoSize = True
        Me.chkEasternPM.Location = New System.Drawing.Point(66, 205)
        Me.chkEasternPM.Name = "chkEasternPM"
        Me.chkEasternPM.Size = New System.Drawing.Size(48, 17)
        Me.chkEasternPM.TabIndex = 12
        Me.chkEasternPM.Text = "P.M."
        Me.chkEasternPM.UseVisualStyleBackColor = True
        '
        'chkCentralAM
        '
        Me.chkCentralAM.AutoSize = True
        Me.chkCentralAM.Location = New System.Drawing.Point(132, 205)
        Me.chkCentralAM.Name = "chkCentralAM"
        Me.chkCentralAM.Size = New System.Drawing.Size(48, 17)
        Me.chkCentralAM.TabIndex = 13
        Me.chkCentralAM.Text = "A.M."
        Me.chkCentralAM.UseVisualStyleBackColor = True
        '
        'chkCentralPM
        '
        Me.chkCentralPM.AutoSize = True
        Me.chkCentralPM.Location = New System.Drawing.Point(186, 205)
        Me.chkCentralPM.Name = "chkCentralPM"
        Me.chkCentralPM.Size = New System.Drawing.Size(48, 17)
        Me.chkCentralPM.TabIndex = 14
        Me.chkCentralPM.Text = "P.M."
        Me.chkCentralPM.UseVisualStyleBackColor = True
        '
        'chkMountainAM
        '
        Me.chkMountainAM.AutoSize = True
        Me.chkMountainAM.Location = New System.Drawing.Point(252, 205)
        Me.chkMountainAM.Name = "chkMountainAM"
        Me.chkMountainAM.Size = New System.Drawing.Size(48, 17)
        Me.chkMountainAM.TabIndex = 15
        Me.chkMountainAM.Text = "A.M."
        Me.chkMountainAM.UseVisualStyleBackColor = True
        '
        'chkMountainPM
        '
        Me.chkMountainPM.AutoSize = True
        Me.chkMountainPM.Location = New System.Drawing.Point(306, 205)
        Me.chkMountainPM.Name = "chkMountainPM"
        Me.chkMountainPM.Size = New System.Drawing.Size(48, 17)
        Me.chkMountainPM.TabIndex = 16
        Me.chkMountainPM.Text = "P.M."
        Me.chkMountainPM.UseVisualStyleBackColor = True
        '
        'chkPacificAM
        '
        Me.chkPacificAM.AutoSize = True
        Me.chkPacificAM.Location = New System.Drawing.Point(369, 205)
        Me.chkPacificAM.Name = "chkPacificAM"
        Me.chkPacificAM.Size = New System.Drawing.Size(48, 17)
        Me.chkPacificAM.TabIndex = 17
        Me.chkPacificAM.Text = "A.M."
        Me.chkPacificAM.UseVisualStyleBackColor = True
        '
        'chkPacificPM
        '
        Me.chkPacificPM.AutoSize = True
        Me.chkPacificPM.Location = New System.Drawing.Point(423, 205)
        Me.chkPacificPM.Name = "chkPacificPM"
        Me.chkPacificPM.Size = New System.Drawing.Size(48, 17)
        Me.chkPacificPM.TabIndex = 18
        Me.chkPacificPM.Text = "P.M."
        Me.chkPacificPM.UseVisualStyleBackColor = True
        '
        'btnEastern
        '
        Me.btnEastern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEastern.Location = New System.Drawing.Point(25, 254)
        Me.btnEastern.Name = "btnEastern"
        Me.btnEastern.Size = New System.Drawing.Size(64, 23)
        Me.btnEastern.TabIndex = 19
        Me.btnEastern.Text = "Submit"
        Me.btnEastern.UseVisualStyleBackColor = True
        '
        'btnCentral
        '
        Me.btnCentral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCentral.Location = New System.Drawing.Point(145, 254)
        Me.btnCentral.Name = "btnCentral"
        Me.btnCentral.Size = New System.Drawing.Size(64, 23)
        Me.btnCentral.TabIndex = 20
        Me.btnCentral.Text = "Submit"
        Me.btnCentral.UseVisualStyleBackColor = True
        '
        'btnMountain
        '
        Me.btnMountain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMountain.Location = New System.Drawing.Point(265, 254)
        Me.btnMountain.Name = "btnMountain"
        Me.btnMountain.Size = New System.Drawing.Size(64, 23)
        Me.btnMountain.TabIndex = 21
        Me.btnMountain.Text = "Submit"
        Me.btnMountain.UseVisualStyleBackColor = True
        '
        'btnPacific
        '
        Me.btnPacific.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPacific.Location = New System.Drawing.Point(385, 254)
        Me.btnPacific.Name = "btnPacific"
        Me.btnPacific.Size = New System.Drawing.Size(64, 23)
        Me.btnPacific.TabIndex = 22
        Me.btnPacific.Text = "Submit"
        Me.btnPacific.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(385, 65)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmTimeZones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 286)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPacific)
        Me.Controls.Add(Me.btnMountain)
        Me.Controls.Add(Me.btnCentral)
        Me.Controls.Add(Me.btnEastern)
        Me.Controls.Add(Me.chkPacificPM)
        Me.Controls.Add(Me.chkPacificAM)
        Me.Controls.Add(Me.chkMountainPM)
        Me.Controls.Add(Me.chkMountainAM)
        Me.Controls.Add(Me.chkCentralPM)
        Me.Controls.Add(Me.chkCentralAM)
        Me.Controls.Add(Me.chkEasternPM)
        Me.Controls.Add(Me.chkEasternAM)
        Me.Controls.Add(Me.lblPacific)
        Me.Controls.Add(Me.lblMountain)
        Me.Controls.Add(Me.lblCentral)
        Me.Controls.Add(Me.lblEastern)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.picTimeZone)
        Me.Controls.Add(Me.txtMountain)
        Me.Controls.Add(Me.txtPacific)
        Me.Controls.Add(Me.txtCentral)
        Me.Controls.Add(Me.txtEastern)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "frmTimeZones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Time Zone Converter"
        CType(Me.picTimeZone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEastern As TextBox
    Friend WithEvents picTimeZone As PictureBox
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblEastern As Label
    Friend WithEvents lblCentral As Label
    Friend WithEvents lblMountain As Label
    Friend WithEvents lblPacific As Label
    Friend WithEvents txtMountain As TextBox
    Friend WithEvents txtPacific As TextBox
    Friend WithEvents txtCentral As TextBox
    Friend WithEvents chkEasternAM As CheckBox
    Friend WithEvents chkEasternPM As CheckBox
    Friend WithEvents chkCentralAM As CheckBox
    Friend WithEvents chkCentralPM As CheckBox
    Friend WithEvents chkMountainAM As CheckBox
    Friend WithEvents chkMountainPM As CheckBox
    Friend WithEvents chkPacificAM As CheckBox
    Friend WithEvents chkPacificPM As CheckBox
    Friend WithEvents btnEastern As Button
    Friend WithEvents btnCentral As Button
    Friend WithEvents btnMountain As Button
    Friend WithEvents btnPacific As Button
    Friend WithEvents btnClear As Button
End Class

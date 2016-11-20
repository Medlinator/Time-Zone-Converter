<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBox2
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

    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents lblOccupation As System.Windows.Forms.Label
    Friend WithEvents txtIntro As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblBorn As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBox2))
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblBorn = New System.Windows.Forms.Label()
        Me.lblOccupation = New System.Windows.Forms.Label()
        Me.txtIntro = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.TableLayoutPanel.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.0!))
        Me.TableLayoutPanel.Controls.Add(Me.picLogo, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.lblName, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.lblFrom, 1, 1)
        Me.TableLayoutPanel.Controls.Add(Me.lblBorn, 1, 2)
        Me.TableLayoutPanel.Controls.Add(Me.lblOccupation, 1, 3)
        Me.TableLayoutPanel.Controls.Add(Me.txtIntro, 1, 4)
        Me.TableLayoutPanel.Controls.Add(Me.btnOK, 1, 5)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(9, 9)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 6
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(396, 226)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'picLogo
        '
        Me.picLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(3, 3)
        Me.picLogo.Name = "picLogo"
        Me.TableLayoutPanel.SetRowSpan(Me.picLogo, 6)
        Me.picLogo.Size = New System.Drawing.Size(124, 220)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'lblName
        '
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblName.Location = New System.Drawing.Point(136, 0)
        Me.lblName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblName.MaximumSize = New System.Drawing.Size(0, 17)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(257, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name: Sean Medlin"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFrom
        '
        Me.lblFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFrom.Location = New System.Drawing.Point(136, 22)
        Me.lblFrom.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblFrom.MaximumSize = New System.Drawing.Size(0, 17)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(257, 17)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From: Tulsa, Oklahoma"
        Me.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBorn
        '
        Me.lblBorn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBorn.Location = New System.Drawing.Point(136, 44)
        Me.lblBorn.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblBorn.MaximumSize = New System.Drawing.Size(0, 17)
        Me.lblBorn.Name = "lblBorn"
        Me.lblBorn.Size = New System.Drawing.Size(257, 17)
        Me.lblBorn.TabIndex = 0
        Me.lblBorn.Text = "Born: Feb 9, 1988"
        Me.lblBorn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOccupation
        '
        Me.lblOccupation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOccupation.Location = New System.Drawing.Point(136, 66)
        Me.lblOccupation.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblOccupation.MaximumSize = New System.Drawing.Size(0, 17)
        Me.lblOccupation.Name = "lblOccupation"
        Me.lblOccupation.Size = New System.Drawing.Size(257, 17)
        Me.lblOccupation.TabIndex = 0
        Me.lblOccupation.Text = "Occupation: Active Duty Air Force Member"
        Me.lblOccupation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIntro
        '
        Me.txtIntro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtIntro.Location = New System.Drawing.Point(136, 91)
        Me.txtIntro.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.txtIntro.Multiline = True
        Me.txtIntro.Name = "txtIntro"
        Me.txtIntro.ReadOnly = True
        Me.txtIntro.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtIntro.Size = New System.Drawing.Size(257, 107)
        Me.txtIntro.TabIndex = 0
        Me.txtIntro.TabStop = False
        Me.txtIntro.Text = resources.GetString("txtIntro.Text")
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(318, 204)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 19)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'AboutBox2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnOK
        Me.ClientSize = New System.Drawing.Size(414, 244)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutBox2"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About Me"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Etch_a_Sketch
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
        Me.DisplayPictureBox = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.DrawWaveformsButton = New System.Windows.Forms.Button()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeftClickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RightClickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiddleClickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeavesTheProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShakesTheEtchASketchAndClearsAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawsThreeWaveformsOfTanSinAndCosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllowsForSelectionOfColorToDrawWithToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UseToDrawToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuicklySelectColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsGroupBox = New System.Windows.Forms.GroupBox()
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.OptionsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DisplayPictureBox
        '
        Me.DisplayPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplayPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DisplayPictureBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DisplayPictureBox.Location = New System.Drawing.Point(12, 22)
        Me.DisplayPictureBox.Name = "DisplayPictureBox"
        Me.DisplayPictureBox.Size = New System.Drawing.Size(978, 462)
        Me.DisplayPictureBox.TabIndex = 0
        Me.DisplayPictureBox.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(485, 20)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(110, 61)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'DrawWaveformsButton
        '
        Me.DrawWaveformsButton.Location = New System.Drawing.Point(322, 20)
        Me.DrawWaveformsButton.Name = "DrawWaveformsButton"
        Me.DrawWaveformsButton.Size = New System.Drawing.Size(110, 62)
        Me.DrawWaveformsButton.TabIndex = 1
        Me.DrawWaveformsButton.Text = "Draw Waveforms"
        Me.DrawWaveformsButton.UseVisualStyleBackColor = True
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Location = New System.Drawing.Point(161, 20)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(110, 61)
        Me.SelectColorButton.TabIndex = 1
        Me.SelectColorButton.Text = "Select Color"
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(646, 20)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(110, 61)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 580)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1002, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenusToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1002, 30)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenusToolStripMenuItem
        '
        Me.MenusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem, Me.DrawWaveformsToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenusToolStripMenuItem.Name = "MenusToolStripMenuItem"
        Me.MenusToolStripMenuItem.Size = New System.Drawing.Size(66, 26)
        Me.MenusToolStripMenuItem.Text = "Menus"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeftClickToolStripMenuItem, Me.RightClickToolStripMenuItem, Me.MiddleClickToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 26)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'LeftClickToolStripMenuItem
        '
        Me.LeftClickToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UseToDrawToolStripMenuItem})
        Me.LeftClickToolStripMenuItem.Name = "LeftClickToolStripMenuItem"
        Me.LeftClickToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.LeftClickToolStripMenuItem.Text = "Left-Click"
        '
        'RightClickToolStripMenuItem
        '
        Me.RightClickToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoActionToolStripMenuItem})
        Me.RightClickToolStripMenuItem.Name = "RightClickToolStripMenuItem"
        Me.RightClickToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RightClickToolStripMenuItem.Text = "Right-Click"
        '
        'MiddleClickToolStripMenuItem
        '
        Me.MiddleClickToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuicklySelectColorToolStripMenuItem})
        Me.MiddleClickToolStripMenuItem.Name = "MiddleClickToolStripMenuItem"
        Me.MiddleClickToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.MiddleClickToolStripMenuItem.Text = "Middle-Click"
        '
        'SelectColorToolStripMenuItem
        '
        Me.SelectColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllowsForSelectionOfColorToDrawWithToolStripMenuItem})
        Me.SelectColorToolStripMenuItem.Name = "SelectColorToolStripMenuItem"
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SelectColorToolStripMenuItem.Text = "Select Color"
        '
        'DrawWaveformsToolStripMenuItem
        '
        Me.DrawWaveformsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DrawsThreeWaveformsOfTanSinAndCosToolStripMenuItem})
        Me.DrawWaveformsToolStripMenuItem.Name = "DrawWaveformsToolStripMenuItem"
        Me.DrawWaveformsToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DrawWaveformsToolStripMenuItem.Text = "Draw Waveforms"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShakesTheEtchASketchAndClearsAreaToolStripMenuItem})
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeavesTheProgramToolStripMenuItem})
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'LeavesTheProgramToolStripMenuItem
        '
        Me.LeavesTheProgramToolStripMenuItem.Name = "LeavesTheProgramToolStripMenuItem"
        Me.LeavesTheProgramToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.LeavesTheProgramToolStripMenuItem.Text = "Leaves the program"
        '
        'ShakesTheEtchASketchAndClearsAreaToolStripMenuItem
        '
        Me.ShakesTheEtchASketchAndClearsAreaToolStripMenuItem.Name = "ShakesTheEtchASketchAndClearsAreaToolStripMenuItem"
        Me.ShakesTheEtchASketchAndClearsAreaToolStripMenuItem.Size = New System.Drawing.Size(357, 26)
        Me.ShakesTheEtchASketchAndClearsAreaToolStripMenuItem.Text = "Shakes the Etch a Sketch and clears area"
        '
        'DrawsThreeWaveformsOfTanSinAndCosToolStripMenuItem
        '
        Me.DrawsThreeWaveformsOfTanSinAndCosToolStripMenuItem.Name = "DrawsThreeWaveformsOfTanSinAndCosToolStripMenuItem"
        Me.DrawsThreeWaveformsOfTanSinAndCosToolStripMenuItem.Size = New System.Drawing.Size(373, 26)
        Me.DrawsThreeWaveformsOfTanSinAndCosToolStripMenuItem.Text = "Draws three waveforms of tan, sin, and cos"
        '
        'AllowsForSelectionOfColorToDrawWithToolStripMenuItem
        '
        Me.AllowsForSelectionOfColorToDrawWithToolStripMenuItem.Name = "AllowsForSelectionOfColorToDrawWithToolStripMenuItem"
        Me.AllowsForSelectionOfColorToDrawWithToolStripMenuItem.Size = New System.Drawing.Size(365, 26)
        Me.AllowsForSelectionOfColorToDrawWithToolStripMenuItem.Text = "Allows for selection of color to draw with"
        '
        'UseToDrawToolStripMenuItem
        '
        Me.UseToDrawToolStripMenuItem.Name = "UseToDrawToolStripMenuItem"
        Me.UseToDrawToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.UseToDrawToolStripMenuItem.Text = "Use to draw"
        '
        'NoActionToolStripMenuItem
        '
        Me.NoActionToolStripMenuItem.Name = "NoActionToolStripMenuItem"
        Me.NoActionToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NoActionToolStripMenuItem.Text = "No action"
        '
        'QuicklySelectColorToolStripMenuItem
        '
        Me.QuicklySelectColorToolStripMenuItem.Name = "QuicklySelectColorToolStripMenuItem"
        Me.QuicklySelectColorToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.QuicklySelectColorToolStripMenuItem.Text = "Quickly select color"
        '
        'OptionsGroupBox
        '
        Me.OptionsGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OptionsGroupBox.Controls.Add(Me.SelectColorButton)
        Me.OptionsGroupBox.Controls.Add(Me.ClearButton)
        Me.OptionsGroupBox.Controls.Add(Me.DrawWaveformsButton)
        Me.OptionsGroupBox.Controls.Add(Me.ExitButton)
        Me.OptionsGroupBox.Location = New System.Drawing.Point(12, 490)
        Me.OptionsGroupBox.Name = "OptionsGroupBox"
        Me.OptionsGroupBox.Size = New System.Drawing.Size(978, 87)
        Me.OptionsGroupBox.TabIndex = 4
        Me.OptionsGroupBox.TabStop = False
        '
        'Etch_a_Sketch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 602)
        Me.Controls.Add(Me.OptionsGroupBox)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DisplayPictureBox)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Etch_a_Sketch"
        Me.Text = "Form1"
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.OptionsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayPictureBox As PictureBox
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents ClearButton As Button
    Friend WithEvents DrawWaveformsButton As Button
    Friend WithEvents SelectColorButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllowsForSelectionOfColorToDrawWithToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawsThreeWaveformsOfTanSinAndCosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShakesTheEtchASketchAndClearsAreaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeavesTheProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeftClickToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UseToDrawToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RightClickToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NoActionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiddleClickToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuicklySelectColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsGroupBox As GroupBox
End Class

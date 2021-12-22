<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PfrmReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PfrmReports))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim Animation1 As Utilities.BunifuPages.BunifuAnimatorNS.Animation = New Utilities.BunifuPages.BunifuAnimatorNS.Animation()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.BunifuButton4 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuPages1 = New Bunifu.UI.WinForms.BunifuPages()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.BunifuPages1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.BunifuButton4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.BunifuPages1)
        Me.SplitContainer1.Size = New System.Drawing.Size(872, 450)
        Me.SplitContainer1.SplitterDistance = 111
        Me.SplitContainer1.TabIndex = 0
        '
        'BunifuButton4
        '
        Me.BunifuButton4.AllowAnimations = True
        Me.BunifuButton4.AllowMouseEffects = True
        Me.BunifuButton4.AllowToggling = False
        Me.BunifuButton4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuButton4.AnimationSpeed = 200
        Me.BunifuButton4.AutoGenerateColors = False
        Me.BunifuButton4.AutoRoundBorders = True
        Me.BunifuButton4.AutoSizeLeftIcon = True
        Me.BunifuButton4.AutoSizeRightIcon = True
        Me.BunifuButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton4.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton4.BackgroundImage = CType(resources.GetObject("BunifuButton4.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton4.ButtonText = "Messaging Setup"
        Me.BunifuButton4.ButtonTextMarginLeft = 0
        Me.BunifuButton4.ColorContrastOnClick = 45
        Me.BunifuButton4.ColorContrastOnHover = 45
        Me.BunifuButton4.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BunifuButton4.CustomizableEdges = BorderEdges1
        Me.BunifuButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton4.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton4.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton4.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton4.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton4.IconLeft = CType(resources.GetObject("BunifuButton4.IconLeft"), System.Drawing.Image)
        Me.BunifuButton4.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton4.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton4.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton4.IconMarginLeft = 11
        Me.BunifuButton4.IconPadding = 10
        Me.BunifuButton4.IconRight = Nothing
        Me.BunifuButton4.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton4.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton4.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton4.IconSize = 35
        Me.BunifuButton4.IdleBorderColor = System.Drawing.Color.White
        Me.BunifuButton4.IdleBorderRadius = 1
        Me.BunifuButton4.IdleBorderThickness = 1
        Me.BunifuButton4.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton4.IdleIconLeftImage = CType(resources.GetObject("BunifuButton4.IdleIconLeftImage"), System.Drawing.Image)
        Me.BunifuButton4.IdleIconRightImage = Nothing
        Me.BunifuButton4.IndicateFocus = False
        Me.BunifuButton4.Location = New System.Drawing.Point(0, 190)
        Me.BunifuButton4.Name = "BunifuButton4"
        Me.BunifuButton4.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton4.OnDisabledState.BorderRadius = 1
        Me.BunifuButton4.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton4.OnDisabledState.BorderThickness = 1
        Me.BunifuButton4.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton4.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton4.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton4.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton4.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton4.onHoverState.BorderRadius = 1
        Me.BunifuButton4.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton4.onHoverState.BorderThickness = 1
        Me.BunifuButton4.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton4.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton4.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton4.onHoverState.IconRightImage = Nothing
        Me.BunifuButton4.OnIdleState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton4.OnIdleState.BorderRadius = 1
        Me.BunifuButton4.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton4.OnIdleState.BorderThickness = 1
        Me.BunifuButton4.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton4.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton4.OnIdleState.IconLeftImage = CType(resources.GetObject("BunifuButton4.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.BunifuButton4.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton4.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton4.OnPressedState.BorderRadius = 1
        Me.BunifuButton4.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton4.OnPressedState.BorderThickness = 1
        Me.BunifuButton4.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton4.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton4.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton4.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton4.Size = New System.Drawing.Size(109, 46)
        Me.BunifuButton4.TabIndex = 167
        Me.BunifuButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton4.TextMarginLeft = 0
        Me.BunifuButton4.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton4.UseDefaultRadiusAndThickness = True
        '
        'BunifuPages1
        '
        Me.BunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.BunifuPages1.AllowTransitions = False
        Me.BunifuPages1.Controls.Add(Me.TabPage1)
        Me.BunifuPages1.Controls.Add(Me.TabPage2)
        Me.BunifuPages1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuPages1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuPages1.Multiline = True
        Me.BunifuPages1.Name = "BunifuPages1"
        Me.BunifuPages1.Page = Me.TabPage1
        Me.BunifuPages1.PageIndex = 0
        Me.BunifuPages1.PageName = "TabPage1"
        Me.BunifuPages1.PageTitle = "TabPage1"
        Me.BunifuPages1.SelectedIndex = 0
        Me.BunifuPages1.Size = New System.Drawing.Size(757, 450)
        Me.BunifuPages1.TabIndex = 0
        Animation1.AnimateOnlyDifferences = False
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.BunifuPages1.Transition = Animation1
        Me.BunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(749, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(686, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PfrmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PfrmReports"
        Me.Text = "PfrmReports"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.BunifuPages1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents BunifuPages1 As Bunifu.UI.WinForms.BunifuPages
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BunifuButton4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
End Class

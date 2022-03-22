<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuppliersOders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SuppliersOders))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Dim Animation1 As Utilities.BunifuPages.BunifuAnimatorNS.Animation = New Utilities.BunifuPages.BunifuAnimatorNS.Animation()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.BunifuPanel1 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.BunifuButton22 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.BunifuButton21 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.BunifuPages1 = New Bunifu.UI.WinForms.BunifuPages()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FrmCreateOder1 = New HardSoft_PoS.frmCreateOder()
        Me.RecieveOder1 = New HardSoft_PoS.RecieveOder()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.BunifuPanel1.SuspendLayout()
        Me.BunifuPages1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.BunifuPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.BunifuPages1)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 450)
        Me.SplitContainer1.SplitterDistance = 129
        Me.SplitContainer1.TabIndex = 0
        '
        'BunifuPanel1
        '
        Me.BunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent
        Me.BunifuPanel1.BackgroundImage = CType(resources.GetObject("BunifuPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel1.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel1.BorderRadius = 3
        Me.BunifuPanel1.BorderThickness = 1
        Me.BunifuPanel1.Controls.Add(Me.BunifuButton22)
        Me.BunifuPanel1.Controls.Add(Me.BunifuButton21)
        Me.BunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuPanel1.Name = "BunifuPanel1"
        Me.BunifuPanel1.ShowBorders = True
        Me.BunifuPanel1.Size = New System.Drawing.Size(129, 450)
        Me.BunifuPanel1.TabIndex = 0
        '
        'BunifuButton22
        '
        Me.BunifuButton22.AllowAnimations = True
        Me.BunifuButton22.AllowMouseEffects = True
        Me.BunifuButton22.AllowToggling = False
        Me.BunifuButton22.AnimationSpeed = 200
        Me.BunifuButton22.AutoGenerateColors = False
        Me.BunifuButton22.AutoRoundBorders = False
        Me.BunifuButton22.AutoSizeLeftIcon = True
        Me.BunifuButton22.AutoSizeRightIcon = True
        Me.BunifuButton22.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton22.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.BunifuButton22.BackgroundImage = CType(resources.GetObject("BunifuButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton22.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton22.ButtonText = "Recieve Oder"
        Me.BunifuButton22.ButtonTextMarginLeft = 0
        Me.BunifuButton22.ColorContrastOnClick = 45
        Me.BunifuButton22.ColorContrastOnHover = 45
        Me.BunifuButton22.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BunifuButton22.CustomizableEdges = BorderEdges1
        Me.BunifuButton22.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton22.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton22.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton22.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton22.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed
        Me.BunifuButton22.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton22.ForeColor = System.Drawing.Color.White
        Me.BunifuButton22.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton22.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton22.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton22.IconMarginLeft = 11
        Me.BunifuButton22.IconPadding = 10
        Me.BunifuButton22.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton22.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton22.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton22.IconSize = 25
        Me.BunifuButton22.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton22.IdleBorderRadius = 30
        Me.BunifuButton22.IdleBorderThickness = 1
        Me.BunifuButton22.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton22.IdleIconLeftImage = CType(resources.GetObject("BunifuButton22.IdleIconLeftImage"), System.Drawing.Image)
        Me.BunifuButton22.IdleIconRightImage = Nothing
        Me.BunifuButton22.IndicateFocus = False
        Me.BunifuButton22.Location = New System.Drawing.Point(2, 204)
        Me.BunifuButton22.Name = "BunifuButton22"
        Me.BunifuButton22.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton22.OnDisabledState.BorderRadius = 30
        Me.BunifuButton22.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton22.OnDisabledState.BorderThickness = 1
        Me.BunifuButton22.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton22.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton22.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton22.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton22.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton22.onHoverState.BorderRadius = 30
        Me.BunifuButton22.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton22.onHoverState.BorderThickness = 1
        Me.BunifuButton22.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton22.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton22.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton22.onHoverState.IconRightImage = Nothing
        Me.BunifuButton22.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton22.OnIdleState.BorderRadius = 30
        Me.BunifuButton22.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton22.OnIdleState.BorderThickness = 1
        Me.BunifuButton22.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton22.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton22.OnIdleState.IconLeftImage = CType(resources.GetObject("BunifuButton22.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.BunifuButton22.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton22.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton22.OnPressedState.BorderRadius = 30
        Me.BunifuButton22.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton22.OnPressedState.BorderThickness = 1
        Me.BunifuButton22.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton22.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton22.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton22.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton22.Size = New System.Drawing.Size(124, 42)
        Me.BunifuButton22.TabIndex = 1
        Me.BunifuButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton22.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton22.TextMarginLeft = 0
        Me.BunifuButton22.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton22.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton21
        '
        Me.BunifuButton21.AllowAnimations = True
        Me.BunifuButton21.AllowMouseEffects = True
        Me.BunifuButton21.AllowToggling = False
        Me.BunifuButton21.AnimationSpeed = 200
        Me.BunifuButton21.AutoGenerateColors = False
        Me.BunifuButton21.AutoRoundBorders = False
        Me.BunifuButton21.AutoSizeLeftIcon = True
        Me.BunifuButton21.AutoSizeRightIcon = True
        Me.BunifuButton21.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton21.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.BunifuButton21.BackgroundImage = CType(resources.GetObject("BunifuButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton21.ButtonText = "Create Oder"
        Me.BunifuButton21.ButtonTextMarginLeft = 0
        Me.BunifuButton21.ColorContrastOnClick = 45
        Me.BunifuButton21.ColorContrastOnHover = 45
        Me.BunifuButton21.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.BunifuButton21.CustomizableEdges = BorderEdges2
        Me.BunifuButton21.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton21.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton21.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton21.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton21.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed
        Me.BunifuButton21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton21.ForeColor = System.Drawing.Color.White
        Me.BunifuButton21.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton21.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton21.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton21.IconMarginLeft = 11
        Me.BunifuButton21.IconPadding = 10
        Me.BunifuButton21.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton21.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton21.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton21.IconSize = 25
        Me.BunifuButton21.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton21.IdleBorderRadius = 30
        Me.BunifuButton21.IdleBorderThickness = 1
        Me.BunifuButton21.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton21.IdleIconLeftImage = CType(resources.GetObject("BunifuButton21.IdleIconLeftImage"), System.Drawing.Image)
        Me.BunifuButton21.IdleIconRightImage = Nothing
        Me.BunifuButton21.IndicateFocus = False
        Me.BunifuButton21.Location = New System.Drawing.Point(3, 125)
        Me.BunifuButton21.Name = "BunifuButton21"
        Me.BunifuButton21.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton21.OnDisabledState.BorderRadius = 30
        Me.BunifuButton21.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton21.OnDisabledState.BorderThickness = 1
        Me.BunifuButton21.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton21.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton21.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton21.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton21.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton21.onHoverState.BorderRadius = 30
        Me.BunifuButton21.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton21.onHoverState.BorderThickness = 1
        Me.BunifuButton21.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton21.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton21.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton21.onHoverState.IconRightImage = Nothing
        Me.BunifuButton21.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton21.OnIdleState.BorderRadius = 30
        Me.BunifuButton21.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton21.OnIdleState.BorderThickness = 1
        Me.BunifuButton21.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton21.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton21.OnIdleState.IconLeftImage = CType(resources.GetObject("BunifuButton21.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.BunifuButton21.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton21.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton21.OnPressedState.BorderRadius = 30
        Me.BunifuButton21.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton21.OnPressedState.BorderThickness = 1
        Me.BunifuButton21.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton21.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton21.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton21.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton21.Size = New System.Drawing.Size(123, 42)
        Me.BunifuButton21.TabIndex = 0
        Me.BunifuButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton21.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton21.TextMarginLeft = 0
        Me.BunifuButton21.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton21.UseDefaultRadiusAndThickness = True
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
        Me.BunifuPages1.Page = Me.TabPage2
        Me.BunifuPages1.PageIndex = 1
        Me.BunifuPages1.PageName = "TabPage2"
        Me.BunifuPages1.PageTitle = "Recieve Oder"
        Me.BunifuPages1.SelectedIndex = 0
        Me.BunifuPages1.Size = New System.Drawing.Size(667, 450)
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
        Me.TabPage1.Controls.Add(Me.FrmCreateOder1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(628, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Create Oder"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RecieveOder1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(659, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Recieve Oder"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'FrmCreateOder1
        '
        Me.FrmCreateOder1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmCreateOder1.Location = New System.Drawing.Point(3, 3)
        Me.FrmCreateOder1.Name = "FrmCreateOder1"
        Me.FrmCreateOder1.Size = New System.Drawing.Size(622, 418)
        Me.FrmCreateOder1.TabIndex = 0
        '
        'RecieveOder1
        '
        Me.RecieveOder1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RecieveOder1.Location = New System.Drawing.Point(3, 3)
        Me.RecieveOder1.Name = "RecieveOder1"
        Me.RecieveOder1.Size = New System.Drawing.Size(653, 418)
        Me.RecieveOder1.TabIndex = 0
        '
        'SuppliersOders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "SuppliersOders"
        Me.Text = "Oders"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.BunifuPanel1.ResumeLayout(False)
        Me.BunifuPages1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents BunifuPages1 As Bunifu.UI.WinForms.BunifuPages
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents FrmCreateOder1 As frmCreateOder
    Friend WithEvents BunifuPanel1 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents BunifuButton21 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
    Friend WithEvents BunifuButton22 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
    Friend WithEvents RecieveOder1 As RecieveOder
End Class

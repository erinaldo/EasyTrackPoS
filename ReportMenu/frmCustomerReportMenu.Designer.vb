<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerReportMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerReportMenu))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges6 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuButton3 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton2 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnOpenSession = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton4 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton5 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.dpdatefrom = New System.Windows.Forms.DateTimePicker()
        Me.dpdateto = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 186
        Me.PictureBox1.TabStop = False
        '
        'BunifuButton3
        '
        Me.BunifuButton3.AllowAnimations = True
        Me.BunifuButton3.AllowMouseEffects = True
        Me.BunifuButton3.AllowToggling = False
        Me.BunifuButton3.AnimationSpeed = 200
        Me.BunifuButton3.AutoGenerateColors = False
        Me.BunifuButton3.AutoRoundBorders = False
        Me.BunifuButton3.AutoSizeLeftIcon = True
        Me.BunifuButton3.AutoSizeRightIcon = True
        Me.BunifuButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton3.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton3.BackgroundImage = CType(resources.GetObject("BunifuButton3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.ButtonText = "Customer Info"
        Me.BunifuButton3.ButtonTextMarginLeft = 0
        Me.BunifuButton3.ColorContrastOnClick = 45
        Me.BunifuButton3.ColorContrastOnHover = 45
        Me.BunifuButton3.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BunifuButton3.CustomizableEdges = BorderEdges1
        Me.BunifuButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton3.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton3.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton3.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton3.IconLeft = CType(resources.GetObject("BunifuButton3.IconLeft"), System.Drawing.Image)
        Me.BunifuButton3.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton3.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton3.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton3.IconMarginLeft = 11
        Me.BunifuButton3.IconPadding = 10
        Me.BunifuButton3.IconRight = Nothing
        Me.BunifuButton3.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton3.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton3.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton3.IconSize = 35
        Me.BunifuButton3.IdleBorderColor = System.Drawing.Color.White
        Me.BunifuButton3.IdleBorderRadius = 1
        Me.BunifuButton3.IdleBorderThickness = 1
        Me.BunifuButton3.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton3.IdleIconLeftImage = CType(resources.GetObject("BunifuButton3.IdleIconLeftImage"), System.Drawing.Image)
        Me.BunifuButton3.IdleIconRightImage = Nothing
        Me.BunifuButton3.IndicateFocus = False
        Me.BunifuButton3.Location = New System.Drawing.Point(475, 335)
        Me.BunifuButton3.Name = "BunifuButton3"
        Me.BunifuButton3.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton3.OnDisabledState.BorderRadius = 1
        Me.BunifuButton3.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.OnDisabledState.BorderThickness = 1
        Me.BunifuButton3.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton3.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton3.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton3.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton3.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton3.onHoverState.BorderRadius = 1
        Me.BunifuButton3.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.onHoverState.BorderThickness = 1
        Me.BunifuButton3.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton3.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton3.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton3.onHoverState.IconRightImage = Nothing
        Me.BunifuButton3.OnIdleState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton3.OnIdleState.BorderRadius = 1
        Me.BunifuButton3.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.OnIdleState.BorderThickness = 1
        Me.BunifuButton3.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton3.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton3.OnIdleState.IconLeftImage = CType(resources.GetObject("BunifuButton3.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.BunifuButton3.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton3.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton3.OnPressedState.BorderRadius = 1
        Me.BunifuButton3.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.OnPressedState.BorderThickness = 1
        Me.BunifuButton3.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton3.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton3.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton3.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton3.Size = New System.Drawing.Size(282, 66)
        Me.BunifuButton3.TabIndex = 185
        Me.BunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton3.TextMarginLeft = 0
        Me.BunifuButton3.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton3.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton2
        '
        Me.BunifuButton2.AllowAnimations = True
        Me.BunifuButton2.AllowMouseEffects = True
        Me.BunifuButton2.AllowToggling = False
        Me.BunifuButton2.AnimationSpeed = 200
        Me.BunifuButton2.AutoGenerateColors = False
        Me.BunifuButton2.AutoRoundBorders = False
        Me.BunifuButton2.AutoSizeLeftIcon = True
        Me.BunifuButton2.AutoSizeRightIcon = True
        Me.BunifuButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton2.BackgroundImage = CType(resources.GetObject("BunifuButton2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.ButtonText = "Customer Balance"
        Me.BunifuButton2.ButtonTextMarginLeft = 0
        Me.BunifuButton2.ColorContrastOnClick = 45
        Me.BunifuButton2.ColorContrastOnHover = 45
        Me.BunifuButton2.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.BunifuButton2.CustomizableEdges = BorderEdges2
        Me.BunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton2.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton2.IconLeft = CType(resources.GetObject("BunifuButton2.IconLeft"), System.Drawing.Image)
        Me.BunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton2.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton2.IconMarginLeft = 11
        Me.BunifuButton2.IconPadding = 10
        Me.BunifuButton2.IconRight = Nothing
        Me.BunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton2.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton2.IconSize = 35
        Me.BunifuButton2.IdleBorderColor = System.Drawing.Color.White
        Me.BunifuButton2.IdleBorderRadius = 1
        Me.BunifuButton2.IdleBorderThickness = 1
        Me.BunifuButton2.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton2.IdleIconLeftImage = CType(resources.GetObject("BunifuButton2.IdleIconLeftImage"), System.Drawing.Image)
        Me.BunifuButton2.IdleIconRightImage = Nothing
        Me.BunifuButton2.IndicateFocus = False
        Me.BunifuButton2.Location = New System.Drawing.Point(90, 335)
        Me.BunifuButton2.Name = "BunifuButton2"
        Me.BunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.BorderRadius = 1
        Me.BunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.OnDisabledState.BorderThickness = 1
        Me.BunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton2.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton2.onHoverState.BorderRadius = 1
        Me.BunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.onHoverState.BorderThickness = 1
        Me.BunifuButton2.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton2.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton2.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton2.onHoverState.IconRightImage = Nothing
        Me.BunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton2.OnIdleState.BorderRadius = 1
        Me.BunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.OnIdleState.BorderThickness = 1
        Me.BunifuButton2.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton2.OnIdleState.IconLeftImage = CType(resources.GetObject("BunifuButton2.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.BunifuButton2.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton2.OnPressedState.BorderRadius = 1
        Me.BunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.OnPressedState.BorderThickness = 1
        Me.BunifuButton2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton2.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton2.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton2.Size = New System.Drawing.Size(269, 66)
        Me.BunifuButton2.TabIndex = 184
        Me.BunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton2.TextMarginLeft = 0
        Me.BunifuButton2.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton2.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton1
        '
        Me.BunifuButton1.AllowAnimations = True
        Me.BunifuButton1.AllowMouseEffects = True
        Me.BunifuButton1.AllowToggling = False
        Me.BunifuButton1.AnimationSpeed = 200
        Me.BunifuButton1.AutoGenerateColors = False
        Me.BunifuButton1.AutoRoundBorders = False
        Me.BunifuButton1.AutoSizeLeftIcon = True
        Me.BunifuButton1.AutoSizeRightIcon = True
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.ButtonText = "Customer Ledger"
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.ColorContrastOnClick = 45
        Me.BunifuButton1.ColorContrastOnHover = 45
        Me.BunifuButton1.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.BunifuButton1.CustomizableEdges = BorderEdges3
        Me.BunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton1.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton1.IconLeft = CType(resources.GetObject("BunifuButton1.IconLeft"), System.Drawing.Image)
        Me.BunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton1.IconMarginLeft = 11
        Me.BunifuButton1.IconPadding = 10
        Me.BunifuButton1.IconRight = Nothing
        Me.BunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton1.IconSize = 35
        Me.BunifuButton1.IdleBorderColor = System.Drawing.Color.White
        Me.BunifuButton1.IdleBorderRadius = 1
        Me.BunifuButton1.IdleBorderThickness = 1
        Me.BunifuButton1.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton1.IdleIconLeftImage = CType(resources.GetObject("BunifuButton1.IdleIconLeftImage"), System.Drawing.Image)
        Me.BunifuButton1.IdleIconRightImage = Nothing
        Me.BunifuButton1.IndicateFocus = False
        Me.BunifuButton1.Location = New System.Drawing.Point(90, 109)
        Me.BunifuButton1.Name = "BunifuButton1"
        Me.BunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.BorderRadius = 1
        Me.BunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnDisabledState.BorderThickness = 1
        Me.BunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton1.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton1.onHoverState.BorderRadius = 1
        Me.BunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.onHoverState.BorderThickness = 1
        Me.BunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton1.onHoverState.IconRightImage = Nothing
        Me.BunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton1.OnIdleState.BorderRadius = 1
        Me.BunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnIdleState.BorderThickness = 1
        Me.BunifuButton1.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton1.OnIdleState.IconLeftImage = CType(resources.GetObject("BunifuButton1.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.BunifuButton1.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton1.OnPressedState.BorderRadius = 1
        Me.BunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnPressedState.BorderThickness = 1
        Me.BunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton1.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton1.Size = New System.Drawing.Size(282, 66)
        Me.BunifuButton1.TabIndex = 183
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton1.TextMarginLeft = 0
        Me.BunifuButton1.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton1.UseDefaultRadiusAndThickness = True
        '
        'btnOpenSession
        '
        Me.btnOpenSession.AllowAnimations = True
        Me.btnOpenSession.AllowMouseEffects = True
        Me.btnOpenSession.AllowToggling = False
        Me.btnOpenSession.AnimationSpeed = 200
        Me.btnOpenSession.AutoGenerateColors = False
        Me.btnOpenSession.AutoRoundBorders = False
        Me.btnOpenSession.AutoSizeLeftIcon = True
        Me.btnOpenSession.AutoSizeRightIcon = True
        Me.btnOpenSession.BackColor = System.Drawing.Color.Transparent
        Me.btnOpenSession.BackColor1 = System.Drawing.Color.White
        Me.btnOpenSession.BackgroundImage = CType(resources.GetObject("btnOpenSession.BackgroundImage"), System.Drawing.Image)
        Me.btnOpenSession.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnOpenSession.ButtonText = "Customer Payments"
        Me.btnOpenSession.ButtonTextMarginLeft = 0
        Me.btnOpenSession.ColorContrastOnClick = 45
        Me.btnOpenSession.ColorContrastOnHover = 45
        Me.btnOpenSession.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges4.BottomLeft = True
        BorderEdges4.BottomRight = True
        BorderEdges4.TopLeft = True
        BorderEdges4.TopRight = True
        Me.btnOpenSession.CustomizableEdges = BorderEdges4
        Me.btnOpenSession.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnOpenSession.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnOpenSession.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnOpenSession.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnOpenSession.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnOpenSession.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenSession.ForeColor = System.Drawing.Color.Black
        Me.btnOpenSession.IconLeft = CType(resources.GetObject("btnOpenSession.IconLeft"), System.Drawing.Image)
        Me.btnOpenSession.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpenSession.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnOpenSession.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btnOpenSession.IconMarginLeft = 11
        Me.btnOpenSession.IconPadding = 10
        Me.btnOpenSession.IconRight = Nothing
        Me.btnOpenSession.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOpenSession.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnOpenSession.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btnOpenSession.IconSize = 35
        Me.btnOpenSession.IdleBorderColor = System.Drawing.Color.White
        Me.btnOpenSession.IdleBorderRadius = 1
        Me.btnOpenSession.IdleBorderThickness = 1
        Me.btnOpenSession.IdleFillColor = System.Drawing.Color.White
        Me.btnOpenSession.IdleIconLeftImage = CType(resources.GetObject("btnOpenSession.IdleIconLeftImage"), System.Drawing.Image)
        Me.btnOpenSession.IdleIconRightImage = Nothing
        Me.btnOpenSession.IndicateFocus = False
        Me.btnOpenSession.Location = New System.Drawing.Point(458, 109)
        Me.btnOpenSession.Name = "btnOpenSession"
        Me.btnOpenSession.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnOpenSession.OnDisabledState.BorderRadius = 1
        Me.btnOpenSession.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnOpenSession.OnDisabledState.BorderThickness = 1
        Me.btnOpenSession.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnOpenSession.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnOpenSession.OnDisabledState.IconLeftImage = Nothing
        Me.btnOpenSession.OnDisabledState.IconRightImage = Nothing
        Me.btnOpenSession.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOpenSession.onHoverState.BorderRadius = 1
        Me.btnOpenSession.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnOpenSession.onHoverState.BorderThickness = 1
        Me.btnOpenSession.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOpenSession.onHoverState.ForeColor = System.Drawing.Color.White
        Me.btnOpenSession.onHoverState.IconLeftImage = Nothing
        Me.btnOpenSession.onHoverState.IconRightImage = Nothing
        Me.btnOpenSession.OnIdleState.BorderColor = System.Drawing.Color.White
        Me.btnOpenSession.OnIdleState.BorderRadius = 1
        Me.btnOpenSession.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnOpenSession.OnIdleState.BorderThickness = 1
        Me.btnOpenSession.OnIdleState.FillColor = System.Drawing.Color.White
        Me.btnOpenSession.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.btnOpenSession.OnIdleState.IconLeftImage = CType(resources.GetObject("btnOpenSession.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.btnOpenSession.OnIdleState.IconRightImage = Nothing
        Me.btnOpenSession.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnOpenSession.OnPressedState.BorderRadius = 1
        Me.btnOpenSession.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnOpenSession.OnPressedState.BorderThickness = 1
        Me.btnOpenSession.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnOpenSession.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.btnOpenSession.OnPressedState.IconLeftImage = Nothing
        Me.btnOpenSession.OnPressedState.IconRightImage = Nothing
        Me.btnOpenSession.Size = New System.Drawing.Size(269, 66)
        Me.btnOpenSession.TabIndex = 182
        Me.btnOpenSession.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnOpenSession.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnOpenSession.TextMarginLeft = 0
        Me.btnOpenSession.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnOpenSession.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton4
        '
        Me.BunifuButton4.AllowAnimations = True
        Me.BunifuButton4.AllowMouseEffects = True
        Me.BunifuButton4.AllowToggling = False
        Me.BunifuButton4.AnimationSpeed = 200
        Me.BunifuButton4.AutoGenerateColors = False
        Me.BunifuButton4.AutoRoundBorders = False
        Me.BunifuButton4.AutoSizeLeftIcon = True
        Me.BunifuButton4.AutoSizeRightIcon = True
        Me.BunifuButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton4.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton4.BackgroundImage = CType(resources.GetObject("BunifuButton4.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton4.ButtonText = "Invoice Per Date Summary"
        Me.BunifuButton4.ButtonTextMarginLeft = 0
        Me.BunifuButton4.ColorContrastOnClick = 45
        Me.BunifuButton4.ColorContrastOnHover = 45
        Me.BunifuButton4.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges5.BottomLeft = True
        BorderEdges5.BottomRight = True
        BorderEdges5.TopLeft = True
        BorderEdges5.TopRight = True
        Me.BunifuButton4.CustomizableEdges = BorderEdges5
        Me.BunifuButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton4.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton4.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton4.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton4.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton4.IconLeft = Nothing
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
        Me.BunifuButton4.IdleIconLeftImage = Nothing
        Me.BunifuButton4.IdleIconRightImage = Nothing
        Me.BunifuButton4.IndicateFocus = False
        Me.BunifuButton4.Location = New System.Drawing.Point(90, 213)
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
        Me.BunifuButton4.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton4.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton4.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton4.OnPressedState.BorderRadius = 1
        Me.BunifuButton4.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton4.OnPressedState.BorderThickness = 1
        Me.BunifuButton4.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton4.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton4.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton4.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton4.Size = New System.Drawing.Size(282, 66)
        Me.BunifuButton4.TabIndex = 188
        Me.BunifuButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton4.TextMarginLeft = 0
        Me.BunifuButton4.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton4.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton5
        '
        Me.BunifuButton5.AllowAnimations = True
        Me.BunifuButton5.AllowMouseEffects = True
        Me.BunifuButton5.AllowToggling = False
        Me.BunifuButton5.AnimationSpeed = 200
        Me.BunifuButton5.AutoGenerateColors = False
        Me.BunifuButton5.AutoRoundBorders = False
        Me.BunifuButton5.AutoSizeLeftIcon = True
        Me.BunifuButton5.AutoSizeRightIcon = True
        Me.BunifuButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton5.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton5.BackgroundImage = CType(resources.GetObject("BunifuButton5.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton5.ButtonText = "Payments Per Date"
        Me.BunifuButton5.ButtonTextMarginLeft = 0
        Me.BunifuButton5.ColorContrastOnClick = 45
        Me.BunifuButton5.ColorContrastOnHover = 45
        Me.BunifuButton5.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges6.BottomLeft = True
        BorderEdges6.BottomRight = True
        BorderEdges6.TopLeft = True
        BorderEdges6.TopRight = True
        Me.BunifuButton5.CustomizableEdges = BorderEdges6
        Me.BunifuButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton5.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton5.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton5.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton5.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton5.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton5.IconLeft = CType(resources.GetObject("BunifuButton5.IconLeft"), System.Drawing.Image)
        Me.BunifuButton5.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton5.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton5.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton5.IconMarginLeft = 11
        Me.BunifuButton5.IconPadding = 10
        Me.BunifuButton5.IconRight = Nothing
        Me.BunifuButton5.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton5.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton5.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton5.IconSize = 35
        Me.BunifuButton5.IdleBorderColor = System.Drawing.Color.White
        Me.BunifuButton5.IdleBorderRadius = 1
        Me.BunifuButton5.IdleBorderThickness = 1
        Me.BunifuButton5.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton5.IdleIconLeftImage = CType(resources.GetObject("BunifuButton5.IdleIconLeftImage"), System.Drawing.Image)
        Me.BunifuButton5.IdleIconRightImage = Nothing
        Me.BunifuButton5.IndicateFocus = False
        Me.BunifuButton5.Location = New System.Drawing.Point(475, 213)
        Me.BunifuButton5.Name = "BunifuButton5"
        Me.BunifuButton5.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton5.OnDisabledState.BorderRadius = 1
        Me.BunifuButton5.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton5.OnDisabledState.BorderThickness = 1
        Me.BunifuButton5.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton5.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton5.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton5.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton5.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton5.onHoverState.BorderRadius = 1
        Me.BunifuButton5.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton5.onHoverState.BorderThickness = 1
        Me.BunifuButton5.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton5.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton5.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton5.onHoverState.IconRightImage = Nothing
        Me.BunifuButton5.OnIdleState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton5.OnIdleState.BorderRadius = 1
        Me.BunifuButton5.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton5.OnIdleState.BorderThickness = 1
        Me.BunifuButton5.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton5.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton5.OnIdleState.IconLeftImage = CType(resources.GetObject("BunifuButton5.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.BunifuButton5.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton5.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton5.OnPressedState.BorderRadius = 1
        Me.BunifuButton5.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton5.OnPressedState.BorderThickness = 1
        Me.BunifuButton5.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton5.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton5.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton5.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton5.Size = New System.Drawing.Size(282, 66)
        Me.BunifuButton5.TabIndex = 185
        Me.BunifuButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton5.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton5.TextMarginLeft = 0
        Me.BunifuButton5.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton5.UseDefaultRadiusAndThickness = True
        '
        'dpdatefrom
        '
        Me.dpdatefrom.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpdatefrom.Location = New System.Drawing.Point(197, 49)
        Me.dpdatefrom.Name = "dpdatefrom"
        Me.dpdatefrom.Size = New System.Drawing.Size(180, 27)
        Me.dpdatefrom.TabIndex = 190
        Me.dpdatefrom.Value = New Date(2022, 1, 12, 0, 0, 0, 0)
        '
        'dpdateto
        '
        Me.dpdateto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpdateto.Location = New System.Drawing.Point(418, 49)
        Me.dpdateto.Name = "dpdateto"
        Me.dpdateto.Size = New System.Drawing.Size(180, 27)
        Me.dpdateto.TabIndex = 189
        Me.dpdateto.Value = New Date(2022, 1, 12, 0, 0, 0, 0)
        '
        'frmCustomerReportMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 454)
        Me.Controls.Add(Me.dpdatefrom)
        Me.Controls.Add(Me.dpdateto)
        Me.Controls.Add(Me.BunifuButton4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BunifuButton5)
        Me.Controls.Add(Me.BunifuButton3)
        Me.Controls.Add(Me.BunifuButton2)
        Me.Controls.Add(Me.BunifuButton1)
        Me.Controls.Add(Me.btnOpenSession)
        Me.Name = "frmCustomerReportMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCustomerReportMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuButton3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btnOpenSession As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents dpdatefrom As DateTimePicker
    Friend WithEvents dpdateto As DateTimePicker
End Class

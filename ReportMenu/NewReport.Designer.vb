<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewReport))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges6 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim Animation1 As Utilities.BunifuPages.BunifuAnimatorNS.Animation = New Utilities.BunifuPages.BunifuAnimatorNS.Animation()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.BunifuButton6 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton5 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton2 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton4 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton3 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.dpdatefrom = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.dpdateto = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.BunifuPages1 = New Bunifu.UI.WinForms.BunifuPages()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.InventoryReport1 = New HardSoft_PoS.StockBalancesReport()
        Me.SalesReport1 = New HardSoft_PoS.SalesReport()
        Me.CustomerReport1 = New HardSoft_PoS.CustomerReport()
        Me.SupplierReport1 = New HardSoft_PoS.SupplierReport()
        Me.StockValueReport1 = New HardSoft_PoS.StockValueReport()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.BunifuPages1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(-2, 52)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.BunifuButton6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BunifuButton5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BunifuButton2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BunifuButton1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BunifuButton4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BunifuButton3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dpdatefrom)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dpdateto)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BunifuPages1)
        Me.SplitContainer1.Size = New System.Drawing.Size(819, 469)
        Me.SplitContainer1.SplitterDistance = 146
        Me.SplitContainer1.TabIndex = 0
        '
        'BunifuButton6
        '
        Me.BunifuButton6.AllowAnimations = True
        Me.BunifuButton6.AllowMouseEffects = True
        Me.BunifuButton6.AllowToggling = False
        Me.BunifuButton6.AnimationSpeed = 200
        Me.BunifuButton6.AutoGenerateColors = False
        Me.BunifuButton6.AutoRoundBorders = False
        Me.BunifuButton6.AutoSizeLeftIcon = True
        Me.BunifuButton6.AutoSizeRightIcon = True
        Me.BunifuButton6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton6.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton6.BackgroundImage = CType(resources.GetObject("BunifuButton6.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton6.ButtonText = "Stock Value"
        Me.BunifuButton6.ButtonTextMarginLeft = 0
        Me.BunifuButton6.ColorContrastOnClick = 45
        Me.BunifuButton6.ColorContrastOnHover = 45
        Me.BunifuButton6.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BunifuButton6.CustomizableEdges = BorderEdges1
        Me.BunifuButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton6.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton6.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton6.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton6.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton6.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton6.IconLeft = CType(resources.GetObject("BunifuButton6.IconLeft"), System.Drawing.Image)
        Me.BunifuButton6.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton6.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton6.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton6.IconMarginLeft = 11
        Me.BunifuButton6.IconPadding = 10
        Me.BunifuButton6.IconRight = Nothing
        Me.BunifuButton6.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton6.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton6.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton6.IconSize = 35
        Me.BunifuButton6.IdleBorderColor = System.Drawing.Color.White
        Me.BunifuButton6.IdleBorderRadius = 1
        Me.BunifuButton6.IdleBorderThickness = 1
        Me.BunifuButton6.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton6.IdleIconLeftImage = CType(resources.GetObject("BunifuButton6.IdleIconLeftImage"), System.Drawing.Image)
        Me.BunifuButton6.IdleIconRightImage = Nothing
        Me.BunifuButton6.IndicateFocus = False
        Me.BunifuButton6.Location = New System.Drawing.Point(-6, 368)
        Me.BunifuButton6.Name = "BunifuButton6"
        Me.BunifuButton6.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton6.OnDisabledState.BorderRadius = 1
        Me.BunifuButton6.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton6.OnDisabledState.BorderThickness = 1
        Me.BunifuButton6.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton6.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton6.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton6.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton6.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton6.onHoverState.BorderRadius = 1
        Me.BunifuButton6.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton6.onHoverState.BorderThickness = 1
        Me.BunifuButton6.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton6.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton6.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton6.onHoverState.IconRightImage = Nothing
        Me.BunifuButton6.OnIdleState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton6.OnIdleState.BorderRadius = 1
        Me.BunifuButton6.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton6.OnIdleState.BorderThickness = 1
        Me.BunifuButton6.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton6.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton6.OnIdleState.IconLeftImage = CType(resources.GetObject("BunifuButton6.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.BunifuButton6.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton6.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton6.OnPressedState.BorderRadius = 1
        Me.BunifuButton6.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton6.OnPressedState.BorderThickness = 1
        Me.BunifuButton6.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton6.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton6.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton6.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton6.Size = New System.Drawing.Size(206, 62)
        Me.BunifuButton6.TabIndex = 174
        Me.BunifuButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton6.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton6.TextMarginLeft = 0
        Me.BunifuButton6.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton6.UseDefaultRadiusAndThickness = True
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
        Me.BunifuButton5.ButtonText = "Supplier"
        Me.BunifuButton5.ButtonTextMarginLeft = 0
        Me.BunifuButton5.ColorContrastOnClick = 45
        Me.BunifuButton5.ColorContrastOnHover = 45
        Me.BunifuButton5.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.BunifuButton5.CustomizableEdges = BorderEdges2
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
        Me.BunifuButton5.Location = New System.Drawing.Point(-5, 301)
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
        Me.BunifuButton5.Size = New System.Drawing.Size(188, 61)
        Me.BunifuButton5.TabIndex = 173
        Me.BunifuButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton5.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton5.TextMarginLeft = 0
        Me.BunifuButton5.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton5.UseDefaultRadiusAndThickness = True
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
        Me.BunifuButton2.ButtonText = "Main Menu"
        Me.BunifuButton2.ButtonTextMarginLeft = 0
        Me.BunifuButton2.ColorContrastOnClick = 45
        Me.BunifuButton2.ColorContrastOnHover = 45
        Me.BunifuButton2.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.BunifuButton2.CustomizableEdges = BorderEdges3
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
        Me.BunifuButton2.Location = New System.Drawing.Point(3, 10)
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
        Me.BunifuButton2.Size = New System.Drawing.Size(176, 52)
        Me.BunifuButton2.TabIndex = 172
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
        Me.BunifuButton1.ButtonText = "Customer"
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.ColorContrastOnClick = 45
        Me.BunifuButton1.ColorContrastOnHover = 45
        Me.BunifuButton1.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges4.BottomLeft = True
        BorderEdges4.BottomRight = True
        BorderEdges4.TopLeft = True
        BorderEdges4.TopRight = True
        Me.BunifuButton1.CustomizableEdges = BorderEdges4
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
        Me.BunifuButton1.Location = New System.Drawing.Point(0, 222)
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
        Me.BunifuButton1.Size = New System.Drawing.Size(188, 60)
        Me.BunifuButton1.TabIndex = 171
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton1.TextMarginLeft = 0
        Me.BunifuButton1.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton1.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton4
        '
        Me.BunifuButton4.AllowAnimations = True
        Me.BunifuButton4.AllowMouseEffects = True
        Me.BunifuButton4.AllowToggling = False
        Me.BunifuButton4.AnimationSpeed = 200
        Me.BunifuButton4.AutoGenerateColors = False
        Me.BunifuButton4.AutoRoundBorders = True
        Me.BunifuButton4.AutoSizeLeftIcon = True
        Me.BunifuButton4.AutoSizeRightIcon = True
        Me.BunifuButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton4.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton4.BackgroundImage = CType(resources.GetObject("BunifuButton4.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton4.ButtonText = "Stock Balances"
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
        Me.BunifuButton4.Location = New System.Drawing.Point(-6, 82)
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
        Me.BunifuButton4.Size = New System.Drawing.Size(206, 55)
        Me.BunifuButton4.TabIndex = 169
        Me.BunifuButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton4.TextMarginLeft = 0
        Me.BunifuButton4.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton4.UseDefaultRadiusAndThickness = True
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
        Me.BunifuButton3.ButtonText = "Sales"
        Me.BunifuButton3.ButtonTextMarginLeft = 0
        Me.BunifuButton3.ColorContrastOnClick = 45
        Me.BunifuButton3.ColorContrastOnHover = 45
        Me.BunifuButton3.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges6.BottomLeft = True
        BorderEdges6.BottomRight = True
        BorderEdges6.TopLeft = True
        BorderEdges6.TopRight = True
        Me.BunifuButton3.CustomizableEdges = BorderEdges6
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
        Me.BunifuButton3.Location = New System.Drawing.Point(3, 159)
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
        Me.BunifuButton3.Size = New System.Drawing.Size(148, 57)
        Me.BunifuButton3.TabIndex = 170
        Me.BunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton3.TextMarginLeft = 0
        Me.BunifuButton3.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton3.UseDefaultRadiusAndThickness = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 21)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Date Ranges"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(7, 143)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(659, 323)
        Me.CrystalReportViewer1.TabIndex = 135
        '
        'dpdatefrom
        '
        Me.dpdatefrom.BackColor = System.Drawing.Color.Transparent
        Me.dpdatefrom.BorderColor = System.Drawing.Color.Transparent
        Me.dpdatefrom.BorderRadius = 1
        Me.dpdatefrom.Color = System.Drawing.Color.Transparent
        Me.dpdatefrom.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.dpdatefrom.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.dpdatefrom.DisabledColor = System.Drawing.Color.Transparent
        Me.dpdatefrom.DisplayWeekNumbers = False
        Me.dpdatefrom.DPHeight = 0
        Me.dpdatefrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dpdatefrom.FillDatePicker = False
        Me.dpdatefrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dpdatefrom.ForeColor = System.Drawing.Color.Black
        Me.dpdatefrom.Icon = CType(resources.GetObject("dpdatefrom.Icon"), System.Drawing.Image)
        Me.dpdatefrom.IconColor = System.Drawing.Color.Gray
        Me.dpdatefrom.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.dpdatefrom.LeftTextMargin = 5
        Me.dpdatefrom.Location = New System.Drawing.Point(174, 10)
        Me.dpdatefrom.MinimumSize = New System.Drawing.Size(4, 32)
        Me.dpdatefrom.Name = "dpdatefrom"
        Me.dpdatefrom.Size = New System.Drawing.Size(169, 32)
        Me.dpdatefrom.TabIndex = 134
        Me.dpdatefrom.Value = New Date(2022, 1, 29, 14, 24, 2, 0)
        '
        'dpdateto
        '
        Me.dpdateto.BackColor = System.Drawing.Color.Transparent
        Me.dpdateto.BorderColor = System.Drawing.Color.Silver
        Me.dpdateto.BorderRadius = 1
        Me.dpdateto.Color = System.Drawing.Color.Silver
        Me.dpdateto.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.dpdateto.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.dpdateto.DisabledColor = System.Drawing.Color.Gray
        Me.dpdateto.DisplayWeekNumbers = False
        Me.dpdateto.DPHeight = 0
        Me.dpdateto.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dpdateto.FillDatePicker = False
        Me.dpdateto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dpdateto.ForeColor = System.Drawing.Color.Black
        Me.dpdateto.Icon = CType(resources.GetObject("dpdateto.Icon"), System.Drawing.Image)
        Me.dpdateto.IconColor = System.Drawing.Color.Gray
        Me.dpdateto.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.dpdateto.LeftTextMargin = 5
        Me.dpdateto.Location = New System.Drawing.Point(406, 10)
        Me.dpdateto.MinimumSize = New System.Drawing.Size(4, 32)
        Me.dpdateto.Name = "dpdateto"
        Me.dpdateto.Size = New System.Drawing.Size(169, 32)
        Me.dpdateto.TabIndex = 133
        Me.dpdateto.Value = New Date(2022, 1, 29, 0, 0, 0, 0)
        '
        'BunifuPages1
        '
        Me.BunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.BunifuPages1.AllowTransitions = False
        Me.BunifuPages1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuPages1.Controls.Add(Me.TabPage1)
        Me.BunifuPages1.Controls.Add(Me.TabPage2)
        Me.BunifuPages1.Controls.Add(Me.TabPage3)
        Me.BunifuPages1.Controls.Add(Me.TabPage4)
        Me.BunifuPages1.Controls.Add(Me.TabPage5)
        Me.BunifuPages1.Location = New System.Drawing.Point(3, 48)
        Me.BunifuPages1.Multiline = True
        Me.BunifuPages1.Name = "BunifuPages1"
        Me.BunifuPages1.Page = Me.TabPage5
        Me.BunifuPages1.PageIndex = 4
        Me.BunifuPages1.PageName = "TabPage5"
        Me.BunifuPages1.PageTitle = "StockValue"
        Me.BunifuPages1.SelectedIndex = 0
        Me.BunifuPages1.Size = New System.Drawing.Size(666, 89)
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
        Me.TabPage1.Controls.Add(Me.InventoryReport1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(658, 63)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inventory"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SalesReport1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(658, 63)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Sales"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CustomerReport1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(658, 63)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Customer"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.SupplierReport1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(658, 63)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Supplier"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.StockValueReport1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(658, 63)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "StockValue"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Location = New System.Drawing.Point(5, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(812, 46)
        Me.Panel1.TabIndex = 1
        '
        'InventoryReport1
        '
        Me.InventoryReport1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InventoryReport1.Location = New System.Drawing.Point(3, 3)
        Me.InventoryReport1.Name = "InventoryReport1"
        Me.InventoryReport1.Size = New System.Drawing.Size(652, 57)
        Me.InventoryReport1.TabIndex = 0
        '
        'SalesReport1
        '
        Me.SalesReport1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SalesReport1.Location = New System.Drawing.Point(3, 3)
        Me.SalesReport1.Name = "SalesReport1"
        Me.SalesReport1.Size = New System.Drawing.Size(652, 57)
        Me.SalesReport1.TabIndex = 0
        '
        'CustomerReport1
        '
        Me.CustomerReport1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomerReport1.Location = New System.Drawing.Point(3, 3)
        Me.CustomerReport1.Name = "CustomerReport1"
        Me.CustomerReport1.Size = New System.Drawing.Size(652, 57)
        Me.CustomerReport1.TabIndex = 0
        '
        'SupplierReport1
        '
        Me.SupplierReport1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SupplierReport1.Location = New System.Drawing.Point(3, 3)
        Me.SupplierReport1.Name = "SupplierReport1"
        Me.SupplierReport1.Size = New System.Drawing.Size(652, 57)
        Me.SupplierReport1.TabIndex = 0
        '
        'StockValueReport1
        '
        Me.StockValueReport1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StockValueReport1.Location = New System.Drawing.Point(3, 3)
        Me.StockValueReport1.Name = "StockValueReport1"
        Me.StockValueReport1.Size = New System.Drawing.Size(652, 57)
        Me.StockValueReport1.TabIndex = 0
        '
        'NewReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 533)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "NewReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.BunifuPages1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents BunifuPages1 As Bunifu.UI.WinForms.BunifuPages
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dpdatefrom As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents dpdateto As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuButton2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton6 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents InventoryReport1 As StockBalancesReport
    Friend WithEvents SalesReport1 As SalesReport
    Friend WithEvents CustomerReport1 As CustomerReport
    Friend WithEvents SupplierReport1 As SupplierReport
    Friend WithEvents StockValueReport1 As StockValueReport
End Class

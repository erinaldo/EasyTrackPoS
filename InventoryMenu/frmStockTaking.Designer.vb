<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockTaking
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockTaking))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Me.gvStockBf = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.BunifuButton21 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.cbSuppName = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuButton22 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.gvStockBf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvStockBf
        '
        Me.gvStockBf.AllowCustomTheming = True
        Me.gvStockBf.AllowUserToAddRows = False
        Me.gvStockBf.AllowUserToDeleteRows = False
        Me.gvStockBf.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.gvStockBf.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gvStockBf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvStockBf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvStockBf.BackgroundColor = System.Drawing.Color.Silver
        Me.gvStockBf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvStockBf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvStockBf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvStockBf.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gvStockBf.ColumnHeadersHeight = 20
        Me.gvStockBf.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.gvStockBf.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStockBf.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gvStockBf.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gvStockBf.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStockBf.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.gvStockBf.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.gvStockBf.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStockBf.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.MediumPurple
        Me.gvStockBf.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvStockBf.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gvStockBf.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.gvStockBf.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.gvStockBf.CurrentTheme.Name = Nothing
        Me.gvStockBf.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gvStockBf.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvStockBf.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gvStockBf.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStockBf.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvStockBf.DefaultCellStyle = DataGridViewCellStyle3
        Me.gvStockBf.EnableHeadersVisualStyles = False
        Me.gvStockBf.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStockBf.HeaderBackColor = System.Drawing.Color.MediumPurple
        Me.gvStockBf.HeaderBgColor = System.Drawing.Color.Empty
        Me.gvStockBf.HeaderForeColor = System.Drawing.Color.White
        Me.gvStockBf.Location = New System.Drawing.Point(12, 70)
        Me.gvStockBf.MultiSelect = False
        Me.gvStockBf.Name = "gvStockBf"
        Me.gvStockBf.RowHeadersVisible = False
        Me.gvStockBf.RowTemplate.Height = 40
        Me.gvStockBf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gvStockBf.ShowEditingIcon = False
        Me.gvStockBf.Size = New System.Drawing.Size(776, 302)
        Me.gvStockBf.TabIndex = 180
        Me.gvStockBf.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
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
        Me.BunifuButton21.ButtonText = "Load"
        Me.BunifuButton21.ButtonTextMarginLeft = 0
        Me.BunifuButton21.ColorContrastOnClick = 45
        Me.BunifuButton21.ColorContrastOnHover = 45
        Me.BunifuButton21.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BunifuButton21.CustomizableEdges = BorderEdges1
        Me.BunifuButton21.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton21.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton21.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton21.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton21.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed
        Me.BunifuButton21.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.BunifuButton21.IdleBorderRadius = 15
        Me.BunifuButton21.IdleBorderThickness = 1
        Me.BunifuButton21.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton21.IdleIconLeftImage = Nothing
        Me.BunifuButton21.IdleIconRightImage = Nothing
        Me.BunifuButton21.IndicateFocus = False
        Me.BunifuButton21.Location = New System.Drawing.Point(667, 25)
        Me.BunifuButton21.Name = "BunifuButton21"
        Me.BunifuButton21.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton21.OnDisabledState.BorderRadius = 15
        Me.BunifuButton21.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton21.OnDisabledState.BorderThickness = 1
        Me.BunifuButton21.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton21.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton21.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton21.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton21.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton21.onHoverState.BorderRadius = 15
        Me.BunifuButton21.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton21.onHoverState.BorderThickness = 1
        Me.BunifuButton21.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton21.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton21.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton21.onHoverState.IconRightImage = Nothing
        Me.BunifuButton21.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton21.OnIdleState.BorderRadius = 15
        Me.BunifuButton21.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton21.OnIdleState.BorderThickness = 1
        Me.BunifuButton21.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton21.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton21.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton21.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton21.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton21.OnPressedState.BorderRadius = 15
        Me.BunifuButton21.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton21.OnPressedState.BorderThickness = 1
        Me.BunifuButton21.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton21.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton21.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton21.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton21.Size = New System.Drawing.Size(106, 39)
        Me.BunifuButton21.TabIndex = 181
        Me.BunifuButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton21.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton21.TextMarginLeft = 0
        Me.BunifuButton21.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton21.UseDefaultRadiusAndThickness = True
        Me.BunifuButton21.Visible = False
        '
        'cbSuppName
        '
        Me.cbSuppName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSuppName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSuppName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSuppName.FormattingEnabled = True
        Me.cbSuppName.Location = New System.Drawing.Point(12, 35)
        Me.cbSuppName.Name = "cbSuppName"
        Me.cbSuppName.Size = New System.Drawing.Size(586, 29)
        Me.cbSuppName.TabIndex = 187
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"CASH"})
        Me.ComboBox1.Location = New System.Drawing.Point(155, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(123, 29)
        Me.ComboBox1.TabIndex = 187
        Me.ComboBox1.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"CASH"})
        Me.ComboBox2.Location = New System.Drawing.Point(308, 35)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(123, 29)
        Me.ComboBox2.TabIndex = 187
        Me.ComboBox2.Visible = False
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"CASH"})
        Me.ComboBox3.Location = New System.Drawing.Point(459, 35)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(123, 29)
        Me.ComboBox3.TabIndex = 187
        Me.ComboBox3.Visible = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(18, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 17)
        Me.Label10.TabIndex = 188
        Me.Label10.Text = "Product Line"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(162, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 188
        Me.Label1.Text = "Category"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(315, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 17)
        Me.Label2.TabIndex = 188
        Me.Label2.Text = "Size"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(466, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 188
        Me.Label3.Text = "Colour"
        Me.Label3.Visible = False
        '
        'BunifuButton22
        '
        Me.BunifuButton22.AllowAnimations = True
        Me.BunifuButton22.AllowMouseEffects = True
        Me.BunifuButton22.AllowToggling = False
        Me.BunifuButton22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuButton22.AnimationSpeed = 200
        Me.BunifuButton22.AutoGenerateColors = False
        Me.BunifuButton22.AutoRoundBorders = False
        Me.BunifuButton22.AutoSizeLeftIcon = True
        Me.BunifuButton22.AutoSizeRightIcon = True
        Me.BunifuButton22.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton22.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.BunifuButton22.BackgroundImage = CType(resources.GetObject("BunifuButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton22.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton22.ButtonText = "Save"
        Me.BunifuButton22.ButtonTextMarginLeft = 0
        Me.BunifuButton22.ColorContrastOnClick = 45
        Me.BunifuButton22.ColorContrastOnHover = 45
        Me.BunifuButton22.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.BunifuButton22.CustomizableEdges = BorderEdges2
        Me.BunifuButton22.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton22.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton22.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton22.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton22.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed
        Me.BunifuButton22.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BunifuButton22.IdleBorderRadius = 15
        Me.BunifuButton22.IdleBorderThickness = 1
        Me.BunifuButton22.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton22.IdleIconLeftImage = Nothing
        Me.BunifuButton22.IdleIconRightImage = Nothing
        Me.BunifuButton22.IndicateFocus = False
        Me.BunifuButton22.Location = New System.Drawing.Point(534, 378)
        Me.BunifuButton22.Name = "BunifuButton22"
        Me.BunifuButton22.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton22.OnDisabledState.BorderRadius = 15
        Me.BunifuButton22.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton22.OnDisabledState.BorderThickness = 1
        Me.BunifuButton22.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton22.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton22.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton22.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton22.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton22.onHoverState.BorderRadius = 15
        Me.BunifuButton22.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton22.onHoverState.BorderThickness = 1
        Me.BunifuButton22.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton22.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton22.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton22.onHoverState.IconRightImage = Nothing
        Me.BunifuButton22.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton22.OnIdleState.BorderRadius = 15
        Me.BunifuButton22.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton22.OnIdleState.BorderThickness = 1
        Me.BunifuButton22.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton22.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton22.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton22.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton22.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton22.OnPressedState.BorderRadius = 15
        Me.BunifuButton22.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton22.OnPressedState.BorderThickness = 1
        Me.BunifuButton22.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton22.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton22.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton22.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton22.Size = New System.Drawing.Size(239, 60)
        Me.BunifuButton22.TabIndex = 189
        Me.BunifuButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton22.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton22.TextMarginLeft = 0
        Me.BunifuButton22.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton22.UseDefaultRadiusAndThickness = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Prodcode"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Itemname"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Price"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Qty"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Qty/Ctn"
        Me.Column4.Name = "Column4"
        '
        'frmStockTaking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BunifuButton22)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cbSuppName)
        Me.Controls.Add(Me.BunifuButton21)
        Me.Controls.Add(Me.gvStockBf)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockTaking"
        Me.Text = "frmStockTaking"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gvStockBf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gvStockBf As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents BunifuButton21 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
    Friend WithEvents cbSuppName As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuButton22 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class

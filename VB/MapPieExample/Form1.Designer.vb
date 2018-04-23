Namespace MapPieExample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim imageTilesLayer2 As New DevExpress.XtraMap.ImageTilesLayer()
            Dim openStreetMapDataProvider2 As New DevExpress.XtraMap.OpenStreetMapDataProvider()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
            Me.lbSegments = New System.Windows.Forms.ListBox()
            Me.seRotationAngle = New DevExpress.XtraEditors.SpinEdit()
            Me.lbRotationDirection = New System.Windows.Forms.ListBox()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciRotationDirection = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciRotationAngle = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciSegments = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciSegmentProperties = New DevExpress.XtraLayout.LayoutControlItem()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.seRotationAngle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciRotationDirection, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciRotationAngle, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciSegments, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciSegmentProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.propertyGrid)
            Me.layoutControl1.Controls.Add(Me.lbSegments)
            Me.layoutControl1.Controls.Add(Me.seRotationAngle)
            Me.layoutControl1.Controls.Add(Me.lbRotationDirection)
            Me.layoutControl1.Controls.Add(Me.mapControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = New System.Drawing.Font("Tahoma", 10.25F)
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = True
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = True
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = True
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(718, 454)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' propertyGrid
            ' 
            Me.propertyGrid.Location = New System.Drawing.Point(510, 233)
            Me.propertyGrid.Name = "propertyGrid"
            Me.propertyGrid.Size = New System.Drawing.Size(196, 209)
            Me.propertyGrid.TabIndex = 10
            ' 
            ' lbSegments
            ' 
            Me.lbSegments.FormattingEnabled = True
            Me.lbSegments.Location = New System.Drawing.Point(510, 141)
            Me.lbSegments.Name = "lbSegments"
            Me.lbSegments.Size = New System.Drawing.Size(196, 69)
            Me.lbSegments.TabIndex = 9
            ' 
            ' seRotationAngle
            ' 
            Me.seRotationAngle.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.seRotationAngle.Location = New System.Drawing.Point(510, 28)
            Me.seRotationAngle.Name = "seRotationAngle"
            Me.seRotationAngle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seRotationAngle.Properties.Increment = New Decimal(New Integer() { 1, 0, 0, 65536})
            Me.seRotationAngle.Properties.MaxValue = New Decimal(New Integer() { 628, 0, 0, 131072})
            Me.seRotationAngle.Size = New System.Drawing.Size(196, 20)
            Me.seRotationAngle.StyleController = Me.layoutControl1
            Me.seRotationAngle.TabIndex = 6
            ' 
            ' lbRotationDirection
            ' 
            Me.lbRotationDirection.FormattingEnabled = True
            Me.lbRotationDirection.Location = New System.Drawing.Point(510, 68)
            Me.lbRotationDirection.Name = "lbRotationDirection"
            Me.lbRotationDirection.Size = New System.Drawing.Size(196, 43)
            Me.lbRotationDirection.TabIndex = 5
            ' 
            ' mapControl1
            ' 
            imageTilesLayer2.DataProvider = openStreetMapDataProvider2
            Me.mapControl1.Layers.Add(imageTilesLayer2)
            Me.mapControl1.Location = New System.Drawing.Point(12, 12)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.Size = New System.Drawing.Size(494, 430)
            Me.mapControl1.TabIndex = 4
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.lciRotationDirection, Me.lciRotationAngle, Me.lciSegments, Me.lciSegmentProperties})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(718, 454)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.mapControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(498, 434)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' lciRotationDirection
            ' 
            Me.lciRotationDirection.Control = Me.lbRotationDirection
            Me.lciRotationDirection.Location = New System.Drawing.Point(498, 40)
            Me.lciRotationDirection.Name = "lciRotationDirection"
            Me.lciRotationDirection.Size = New System.Drawing.Size(200, 73)
            Me.lciRotationDirection.Text = "Rotation Direction:"
            Me.lciRotationDirection.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciRotationDirection.TextSize = New System.Drawing.Size(98, 13)
            ' 
            ' lciRotationAngle
            ' 
            Me.lciRotationAngle.Control = Me.seRotationAngle
            Me.lciRotationAngle.Location = New System.Drawing.Point(498, 0)
            Me.lciRotationAngle.Name = "lciRotationAngle"
            Me.lciRotationAngle.Size = New System.Drawing.Size(200, 40)
            Me.lciRotationAngle.Text = "Rotation Angle:"
            Me.lciRotationAngle.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciRotationAngle.TextSize = New System.Drawing.Size(98, 13)
            ' 
            ' lciSegments
            ' 
            Me.lciSegments.Control = Me.lbSegments
            Me.lciSegments.Location = New System.Drawing.Point(498, 113)
            Me.lciSegments.Name = "lciSegments"
            Me.lciSegments.Size = New System.Drawing.Size(200, 92)
            Me.lciSegments.Text = "Segments:"
            Me.lciSegments.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciSegments.TextSize = New System.Drawing.Size(98, 13)
            ' 
            ' lciSegmentProperties
            ' 
            Me.lciSegmentProperties.Control = Me.propertyGrid
            Me.lciSegmentProperties.Location = New System.Drawing.Point(498, 205)
            Me.lciSegmentProperties.Name = "lciSegmentProperties"
            Me.lciSegmentProperties.Size = New System.Drawing.Size(200, 229)
            Me.lciSegmentProperties.Text = "Segment Properties:"
            Me.lciSegmentProperties.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciSegmentProperties.TextSize = New System.Drawing.Size(98, 13)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(718, 454)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.seRotationAngle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciRotationDirection, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciRotationAngle, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciSegments, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciSegmentProperties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private mapControl1 As DevExpress.XtraMap.MapControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents lbRotationDirection As System.Windows.Forms.ListBox
        Private lciRotationDirection As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents seRotationAngle As DevExpress.XtraEditors.SpinEdit
        Private lciRotationAngle As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents lbSegments As System.Windows.Forms.ListBox
        Private lciSegments As DevExpress.XtraLayout.LayoutControlItem
        Private propertyGrid As System.Windows.Forms.PropertyGrid
        Private lciSegmentProperties As DevExpress.XtraLayout.LayoutControlItem

    End Class
End Namespace


namespace MapPieExample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraMap.ImageLayer imageTilesLayer2 = new DevExpress.XtraMap.ImageLayer();
            DevExpress.XtraMap.OpenStreetMapDataProvider openStreetMapDataProvider2 = new DevExpress.XtraMap.OpenStreetMapDataProvider();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.lbSegments = new System.Windows.Forms.ListBox();
            this.seRotationAngle = new DevExpress.XtraEditors.SpinEdit();
            this.lbRotationDirection = new System.Windows.Forms.ListBox();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRotationDirection = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRotationAngle = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSegments = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSegmentProperties = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seRotationAngle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRotationDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRotationAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSegments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSegmentProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.propertyGrid);
            this.layoutControl1.Controls.Add(this.lbSegments);
            this.layoutControl1.Controls.Add(this.seRotationAngle);
            this.layoutControl1.Controls.Add(this.lbRotationDirection);
            this.layoutControl1.Controls.Add(this.mapControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(718, 454);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(510, 233);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(196, 209);
            this.propertyGrid.TabIndex = 10;
            // 
            // lbSegments
            // 
            this.lbSegments.FormattingEnabled = true;
            this.lbSegments.Location = new System.Drawing.Point(510, 141);
            this.lbSegments.Name = "lbSegments";
            this.lbSegments.Size = new System.Drawing.Size(196, 69);
            this.lbSegments.TabIndex = 9;
            this.lbSegments.SelectedIndexChanged += new System.EventHandler(this.lbSegments_SelectedIndexChanged);
            // 
            // seRotationAngle
            // 
            this.seRotationAngle.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seRotationAngle.Location = new System.Drawing.Point(510, 28);
            this.seRotationAngle.Name = "seRotationAngle";
            this.seRotationAngle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seRotationAngle.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.seRotationAngle.Properties.MaxValue = new decimal(new int[] {
            628,
            0,
            0,
            131072});
            this.seRotationAngle.Size = new System.Drawing.Size(196, 20);
            this.seRotationAngle.StyleController = this.layoutControl1;
            this.seRotationAngle.TabIndex = 6;
            this.seRotationAngle.EditValueChanged += new System.EventHandler(this.seRotationAngle_EditValueChanged);
            // 
            // lbRotationDirection
            // 
            this.lbRotationDirection.FormattingEnabled = true;
            this.lbRotationDirection.Location = new System.Drawing.Point(510, 68);
            this.lbRotationDirection.Name = "lbRotationDirection";
            this.lbRotationDirection.Size = new System.Drawing.Size(196, 43);
            this.lbRotationDirection.TabIndex = 5;
            this.lbRotationDirection.SelectedIndexChanged += new System.EventHandler(this.lbRotationDirection_SelectedIndexChanged);
            // 
            // mapControl1
            // 
            imageTilesLayer2.DataProvider = openStreetMapDataProvider2;
            this.mapControl1.Layers.Add(imageTilesLayer2);
            this.mapControl1.Location = new System.Drawing.Point(12, 12);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(494, 430);
            this.mapControl1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lciRotationDirection,
            this.lciRotationAngle,
            this.lciSegments,
            this.lciSegmentProperties});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(718, 454);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.mapControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(498, 434);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lciRotationDirection
            // 
            this.lciRotationDirection.Control = this.lbRotationDirection;
            this.lciRotationDirection.Location = new System.Drawing.Point(498, 40);
            this.lciRotationDirection.Name = "lciRotationDirection";
            this.lciRotationDirection.Size = new System.Drawing.Size(200, 73);
            this.lciRotationDirection.Text = "Rotation Direction:";
            this.lciRotationDirection.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciRotationDirection.TextSize = new System.Drawing.Size(98, 13);
            // 
            // lciRotationAngle
            // 
            this.lciRotationAngle.Control = this.seRotationAngle;
            this.lciRotationAngle.Location = new System.Drawing.Point(498, 0);
            this.lciRotationAngle.Name = "lciRotationAngle";
            this.lciRotationAngle.Size = new System.Drawing.Size(200, 40);
            this.lciRotationAngle.Text = "Rotation Angle:";
            this.lciRotationAngle.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciRotationAngle.TextSize = new System.Drawing.Size(98, 13);
            // 
            // lciSegments
            // 
            this.lciSegments.Control = this.lbSegments;
            this.lciSegments.Location = new System.Drawing.Point(498, 113);
            this.lciSegments.Name = "lciSegments";
            this.lciSegments.Size = new System.Drawing.Size(200, 92);
            this.lciSegments.Text = "Segments:";
            this.lciSegments.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciSegments.TextSize = new System.Drawing.Size(98, 13);
            // 
            // lciSegmentProperties
            // 
            this.lciSegmentProperties.Control = this.propertyGrid;
            this.lciSegmentProperties.Location = new System.Drawing.Point(498, 205);
            this.lciSegmentProperties.Name = "lciSegmentProperties";
            this.lciSegmentProperties.Size = new System.Drawing.Size(200, 229);
            this.lciSegmentProperties.Text = "Segment Properties:";
            this.lciSegmentProperties.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciSegmentProperties.TextSize = new System.Drawing.Size(98, 13);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 454);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seRotationAngle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRotationDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRotationAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSegments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSegmentProperties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.ListBox lbRotationDirection;
        private DevExpress.XtraLayout.LayoutControlItem lciRotationDirection;
        private DevExpress.XtraEditors.SpinEdit seRotationAngle;
        private DevExpress.XtraLayout.LayoutControlItem lciRotationAngle;
        private System.Windows.Forms.ListBox lbSegments;
        private DevExpress.XtraLayout.LayoutControlItem lciSegments;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private DevExpress.XtraLayout.LayoutControlItem lciSegmentProperties;

    }
}


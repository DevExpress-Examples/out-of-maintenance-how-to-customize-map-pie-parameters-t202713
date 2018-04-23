using DevExpress.XtraMap;
using System;
using System.Windows.Forms;

namespace MapPieExample {
    public partial class Form1 : Form {
        #region #InitMapPie
        char letter = 'A';
        double defaultValue = 10;
        MapPie pie;

        private void Form1_Load(object sender, EventArgs e) {
            MapItemStorage storage = new MapItemStorage();
            pie = new MapPie() {
                Location = new GeoPoint(51.507222, -0.1275),
                Size = 100,
                Argument = "pie",
            };
            pie.Segments.Add(new PieSegment() { Argument = NextLetter(), Value = defaultValue });
            pie.Segments.Add(new PieSegment() { Argument = NextLetter(), Value = defaultValue });
            pie.Segments.Add(new PieSegment() { Argument = NextLetter(), Value = defaultValue });

            storage.Items.Add(pie);

            mapControl1.Layers.Add(new VectorItemsLayer() {
                Data = storage,
                Colorizer = new KeyColorColorizer() {
                    ItemKeyProvider = new ArgumentItemKeyProvider(),
                    PredefinedColorSchema = PredefinedColorSchema.Palette
                }
            });

            lbRotationDirection.DataSource = Enum.GetValues(typeof(RotationDirection));
            lbSegments.DataSource = pie.Segments;
        }

        string NextLetter() {
            return letter++.ToString();
        }
        #endregion #InitMapPie

        public Form1() {
            InitializeComponent();
        }

        #region #RotationDirection
        private void lbRotationDirection_SelectedIndexChanged(object sender, EventArgs e) {
            pie.RotationDirection = (RotationDirection)lbRotationDirection.SelectedValue;
        }
        #endregion #RotationDirection

        #region #RotationAngle
        private void seRotationAngle_EditValueChanged(object sender, EventArgs e) {
            pie.RotationAngle = (double)seRotationAngle.Value;
        }
        #endregion #RotationAngle

        private void lbSegments_SelectedIndexChanged(object sender, EventArgs e) {
            propertyGrid.SelectedObject = lbSegments.SelectedValue;
        }
    }
}

Imports DevExpress.XtraMap
Imports System
Imports System.Windows.Forms

Namespace MapPieExample
    Partial Public Class Form1
        Inherits Form

        #Region "#InitMapPie"
        Private letter As Char = "A"c
        Private defaultValue As Double = 10
        Private pie As MapPie

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim storage As New MapItemStorage()
            pie = New MapPie() With {.Location = New GeoPoint(51.507222, -0.1275), .Size = 100, .Argument = "pie"}
            pie.Segments.Add(New PieSegment() With {.Argument = NextLetter(), .Value = defaultValue})
            pie.Segments.Add(New PieSegment() With {.Argument = NextLetter(), .Value = defaultValue})
            pie.Segments.Add(New PieSegment() With {.Argument = NextLetter(), .Value = defaultValue})

            storage.Items.Add(pie)

            mapControl1.Layers.Add(New VectorItemsLayer() With { _
                .Data = storage, .Colorizer = New KeyColorColorizer() With {.ItemKeyProvider = New ArgumentItemKeyProvider(), .PredefinedColorSchema = PredefinedColorSchema.Palette} _
            })

            lbRotationDirection.DataSource = System.Enum.GetValues(GetType(RotationDirection))
            lbSegments.DataSource = pie.Segments
        End Sub

        Private Function NextLetter() As String
            Dim tempVar As Char = letter
            letter = ChrW(AscW(letter) + 1)
            Return tempVar.ToString()
        End Function
        #End Region ' #InitMapPie

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#RotationDirection"
        Private Sub lbRotationDirection_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbRotationDirection.SelectedIndexChanged
            pie.RotationDirection = DirectCast(lbRotationDirection.SelectedValue, RotationDirection)
        End Sub
        #End Region ' #RotationDirection

        #Region "#RotationAngle"
        Private Sub seRotationAngle_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seRotationAngle.EditValueChanged
            pie.RotationAngle = CDbl(seRotationAngle.Value)
        End Sub
        #End Region ' #RotationAngle

        Private Sub lbSegments_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbSegments.SelectedIndexChanged
            propertyGrid.SelectedObject = lbSegments.SelectedValue
        End Sub
    End Class
End Namespace

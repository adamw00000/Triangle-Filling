using PixelMapSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangle_Filling.Models;

namespace Triangle_Filling
{
    public partial class MainWindow : Form
    {
        public Bitmap Bitmap { get; set; } = new Bitmap(800, 600);
        public DirectBitmap old;
        List<Edge> edges = new List<Edge>();
        List<ScanLineFiller> fillers = new List<ScanLineFiller>();
        List<Triangle> triangles = new List<Triangle>();
        bool moveTriangleMode = false;
        bool moveVertexMode = false;
        Vertex movedVertex;
        Triangle movedTriangle;
        Point lastTrianglePos;

        BackgroundWorker worker = new BackgroundWorker();

        public MainWindow()
        {
            InitializeComponent();
            
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;

            Image.Image = Bitmap;

            HeightMapImage.BackgroundImage = FillConfig.HeightMapTexture.GetBitmap();
            NormalMapImage.BackgroundImage = FillConfig.NormalMapTexture.GetBitmap();
            ObjectColorImage.BackColor = FillConfig.ObjectColor;
            ObjectColorImage2.BackColor = FillConfig.SecondObjectColor;
            LightColorImage.BackColor = FillConfig.LightColor;
            ObjectTextureImage.BackgroundImage = FillConfig.ObjectTexture.GetBitmap();
            ObjectTextureImage2.BackgroundImage = FillConfig.SecondObjectTexture.GetBitmap();

            Triangle t1 = new Triangle
            {
                V1 = new Vertex(400, 150),
                V2 = new Vertex(600, 550),
                V3 = new Vertex(200, 550)
            };
            triangles.Add(t1);
            Triangle t2 = new Triangle
            {
                V1 = new Vertex(600, 100),
                V2 = new Vertex(500, 150),
                V3 = new Vertex(400, 100)
            };
            triangles.Add(t2);

            ScanLineFiller f1 = new ScanLineFiller(0, t1);
            fillers.Add(f1);
            ScanLineFiller f2 = new ScanLineFiller(1, t2);
            fillers.Add(f2);

            DrawAsync();
        }

        private void DrawAsync()
        {
            LightVectorProvider.Step++;

            if (!worker.IsBusy)
                worker.RunWorkerAsync();
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Image.Image = (e.Result as DirectBitmap).Bitmap;
            old?.Dispose();
            old = (e.Result as DirectBitmap);
            DrawAsync();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            DirectBitmap bitmap = new DirectBitmap(800, 600);

            foreach (var filler in fillers)
                filler.Fill(bitmap);

            e.Result = bitmap;
        }

        private void DisturbanceRadioButtonMap_CheckedChanged(object sender, EventArgs e)
        {
            if (DisturbanceRadioButtonMap.Checked)
            {
                ScanLineFiller.CalculateDisturbance = DisturbanceProvider.HeightMapDisturbance;
            }
        }

        private void DisturbanceRadioButtonNone_CheckedChanged(object sender, EventArgs e)
        {
            if (DisturbanceRadioButtonNone.Checked)
            {
                ScanLineFiller.CalculateDisturbance = DisturbanceProvider.ConstantDisturbance;
            }
        }

        private void NormalVectorRadioButtonConstant_CheckedChanged(object sender, EventArgs e)
        {
            if (NormalVectorRadioButtonConstant.Checked)
            {
                ScanLineFiller.CalculateNormalVector = NormalVectorProvider.ConstantVector;
            }
        }

        private void NormalMapRadioButtonNormalMap_CheckedChanged(object sender, EventArgs e)
        {
            if (NormalMapRadioButtonNormalMap.Checked)
            {
                ScanLineFiller.CalculateNormalVector = NormalVectorProvider.NormalMapVector;
            }
        }

        private void LightVectorRadioButtonConstant_CheckedChanged(object sender, EventArgs e)
        {
            if (LightVectorRadioButtonConstant.Checked)
            {
                ScanLineFiller.GetLightVector = LightVectorProvider.ConstantVector;
            }
        }

        private void LightVectorRadioButtonRadius_CheckedChanged(object sender, EventArgs e)
        {
            if (LightVectorRadioButtonRadius.Checked)
            {
                ScanLineFiller.GetLightVector = LightVectorProvider.SphereVector;
            }
        }

        private void ObjectColorRadioButtonTexture_CheckedChanged(object sender, EventArgs e)
        {
            if (ObjectColorRadioButtonTexture.Checked)
            {
                ScanLineFiller.GetObjectColor = ObjectColorProvider.TextureColor;
            }
        }

        private void ObjectColorRadioButtonConstant_CheckedChanged(object sender, EventArgs e)
        {
            if (ObjectColorRadioButtonConstant.Checked)
            {
                ScanLineFiller.GetObjectColor = ObjectColorProvider.ConstantColor;
            }
        }
        
        private void LightColorImage_BackColorChanged(object sender, EventArgs e)
        {
            FillConfig.LightColor = (sender as PictureBox).BackColor;
        }

        private void ObjectColorImage_BackColorChanged(object sender, EventArgs e)
        {
            FillConfig.ObjectColor = (sender as PictureBox).BackColor;
        }

        private void ObjectTextureImage_BackgroundImageChanged(object sender, EventArgs e)
        {
            FillConfig.ObjectTexture = PixelMap.SlowLoad((sender as PictureBox).BackgroundImage as Bitmap);
            (sender as PictureBox).Image = (sender as PictureBox).BackgroundImage;
        }

        private void NormalMapImage_BackgroundImageChanged(object sender, EventArgs e)
        {
            FillConfig.NormalMapTexture = PixelMap.SlowLoad((sender as PictureBox).BackgroundImage as Bitmap);
            (sender as PictureBox).Image = (sender as PictureBox).BackgroundImage;
        }

        private void HeightMapImage_BackgroundImageChanged(object sender, EventArgs e)
        {
            FillConfig.HeightMapTexture = PixelMap.SlowLoad((sender as PictureBox).BackgroundImage as Bitmap);
            (sender as PictureBox).Image = (sender as PictureBox).BackgroundImage;
        }

        private void LightColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            LightColorImage.BackColor = dialog.Color;
        }

        private void ObjectColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            ObjectColorImage.BackColor = dialog.Color;
        }

        private void ObjectTextureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Image files|*.png; *.jpg; *.bmp"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            ObjectTextureImage.BackgroundImage = new Bitmap(dialog.FileName);
        }

        private void NormalMapButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Image files|*.png; *.jpg; *.bmp"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            NormalMapImage.BackgroundImage = new Bitmap(dialog.FileName);
        }

        private void ChangeHeightMapButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Image files|*.png; *.jpg; *.bmp"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            HeightMapImage.BackgroundImage = new Bitmap(dialog.FileName);
        }

        private void Image_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Point p = e.Location;

            foreach (var t in triangles)
            {
                if (t.GetClickedVertex(p, out movedVertex))
                {
                    moveVertexMode = true;
                    return;
                }
            }
            foreach (var t in triangles)
            {
                if (t.IsPointInTriangle(p))
                {
                    movedTriangle = t;
                    lastTrianglePos = p;
                    moveTriangleMode = true;
                }
            }
        }

        private void Image_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.Location;

            if (moveVertexMode)
            {
                movedVertex.X = Math.Max(Math.Min(p.X, Bitmap.Width - 1), 0);
                movedVertex.Y = Math.Max(Math.Min(p.Y, Bitmap.Height - 1), 0);
            }
            if (moveTriangleMode)
            {
                var deltaPos = new Vector { X = p.X - lastTrianglePos.X, Y = p.Y - lastTrianglePos.Y };
                movedTriangle.Move(deltaPos);
                lastTrianglePos = p;
            }
        }

        private void Image_MouseUp(object sender, MouseEventArgs e)
        {
            Point p = e.Location;

            if (moveVertexMode)
            {
                moveVertexMode = false;

                movedVertex.X = Math.Max(Math.Min(p.X, Bitmap.Width - 1), 0);
                movedVertex.Y = Math.Max(Math.Min(p.Y, Bitmap.Height - 1), 0);
            }
            if (moveTriangleMode)
            {
                moveTriangleMode = false;

                var deltaPos = new Vector { X = p.X - lastTrianglePos.X, Y = p.Y - lastTrianglePos.Y };
                movedTriangle.Move(deltaPos);
                lastTrianglePos = Point.Empty;
            }
        }

        private void ObjectColorRadioButtonConstant2_CheckedChanged(object sender, EventArgs e)
        {
            if (ObjectColorRadioButtonConstant2.Checked)
            {
                ScanLineFiller.GetSecondObjectColor = ObjectColorProvider.ConstantColor;
            }
        }

        private void ObjectColorRadioButtonTexture2_CheckedChanged(object sender, EventArgs e)
        {
            if (ObjectColorRadioButtonTexture2.Checked)
            {
                ScanLineFiller.GetSecondObjectColor = ObjectColorProvider.TextureColor;
            }
        }

        private void ObjectColorImage2_BackColorChanged(object sender, EventArgs e)
        {
            FillConfig.SecondObjectColor = (sender as PictureBox).BackColor;
        }

        private void ObjectTextureImage2_BackgroundImageChanged(object sender, EventArgs e)
        {
            FillConfig.SecondObjectTexture = PixelMap.SlowLoad((sender as PictureBox).BackgroundImage as Bitmap);
            (sender as PictureBox).Image = (sender as PictureBox).BackgroundImage;
        }

        private void ObjectColorButton2_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            ObjectColorImage2.BackColor = dialog.Color;
        }

        private void ObjectTextureButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Image files|*.png; *.jpg; *.bmp"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            ObjectTextureImage2.BackgroundImage = new Bitmap(dialog.FileName);
        }

        private void LightRadiusTextBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse((sender as TextBox).Text, out double R) && R > 0)
            {
                FillConfig.AnimationLightHeight = R;
            }
        }

        private void RedReflectorCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (RedReflectorCheckbox.Checked)
            {
                ScanLineFiller.GetRedReflectorColor = ReflectorLightProvider.RReflector;
            }
            else
            {
                ScanLineFiller.GetRedReflectorColor = ReflectorLightProvider.NoReflector;
            }
        }

        private void GreenReflectorCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (GreenReflectorCheckbox.Checked)
            {
                ScanLineFiller.GetGreenReflectorColor = ReflectorLightProvider.GReflector;
            }
            else
            {
                ScanLineFiller.GetGreenReflectorColor = ReflectorLightProvider.NoReflector;
            }
        }

        private void BlueReflectorCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (BlueReflectorCheckbox.Checked)
            {
                ScanLineFiller.GetBlueReflectorColor = ReflectorLightProvider.BReflector;
            }
            else
            {
                ScanLineFiller.GetBlueReflectorColor = ReflectorLightProvider.NoReflector;
            }
        }

        private void ReflectorHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse((sender as TextBox).Text, out double H) && H > 0)
            {
                FillConfig.ReflectorHeight = H;
            }
        }

        private void ReflectorCosinePowerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse((sender as TextBox).Text, out double P) && P > 1)
            {
                FillConfig.ReflectorCosinePower = P;
            }
        }
    }
}

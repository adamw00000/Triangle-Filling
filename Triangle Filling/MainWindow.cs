using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Filling
{
    public partial class Form1 : Form
    {
        public Bitmap Bitmap { get; set; } = new Bitmap(800, 600);
        List<Edge> edges = new List<Edge>();
        List<ScanLineFiller> fillers = new List<ScanLineFiller>();

        FillConfig config = new FillConfig();

        public Form1()
        {
            InitializeComponent();
            
            Image.Image = Bitmap;
            HeightMapImage.BackgroundImage = config.HeightMapTexture;
            NormalMapImage.BackgroundImage = config.NormalMapTexture;
            ObjectColorImage.BackColor = config.ObjectColor;
            LightColorImage.BackColor = config.LightColor;
            ObjectTextureImage.BackgroundImage = config.ObjectTexture;

            edges.Add(new Edge() { X1 = 0, Y1 = 0, X2 = 0, Y2 = 600 });
            edges.Add(new Edge() { X1 = 0, Y1 = 600, X2 = 600, Y2 = 600 });
            edges.Add(new Edge() { X1 = 600, Y1 = 600, X2 = 0, Y2 = 0 });

            ScanLineFiller filler = new ScanLineFiller(Bitmap, edges, config);
            fillers.Add(filler);

            Draw();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Bitmap = new Bitmap(800, 600);
            //foreach(var filler in fillers)
            //    filler.Fill();
            //Refresh();
        }

        private void Draw()
        {
            Graphics g = Graphics.FromImage(Bitmap);
            g.Clear(Color.FromKnownColor(KnownColor.White));

            foreach (var filler in fillers)
                filler.Fill();
            Refresh();
        }

        private void DisturbanceRadioButtonMap_CheckedChanged(object sender, EventArgs e)
        {
            if (DisturbanceRadioButtonMap.Checked)
            {
                foreach (var filler in fillers)
                    filler.CalculateDisturbance = DisturbanceProvider.HeightMapDisturbance;
                Draw();
            }
        }

        private void DisturbanceRadioButtonNone_CheckedChanged(object sender, EventArgs e)
        {
            if (DisturbanceRadioButtonNone.Checked)
            {
                foreach (var filler in fillers)
                    filler.CalculateDisturbance = DisturbanceProvider.ConstantDisturbance;
                Draw();
            }
        }

        private void NormalVectorRadioButtonConstant_CheckedChanged(object sender, EventArgs e)
        {
            if (NormalVectorRadioButtonConstant.Checked)
            {
                foreach (var filler in fillers)
                    filler.CalculateNormalVector = NormalVectorProvider.ConstantVector;
                Draw();
            }
        }

        private void NormalMapRadioButtonNormalMap_CheckedChanged(object sender, EventArgs e)
        {
            if (NormalMapRadioButtonNormalMap.Checked)
            {
                foreach (var filler in fillers)
                    filler.CalculateNormalVector = NormalVectorProvider.NormalMapVector;
                Draw();
            }
        }

        private void LightVectorRadioButtonConstant_CheckedChanged(object sender, EventArgs e)
        {
            if (LightVectorRadioButtonConstant.Checked)
            {
                foreach (var filler in fillers)
                    filler.GetLightVector = LightVectorProvider.ConstantVector;
                Draw();
            }
        }

        private void LightVectorRadioButtonRadius_CheckedChanged(object sender, EventArgs e)
        {
            if (LightVectorRadioButtonRadius.Checked)
            {
                foreach (var filler in fillers)
                    filler.GetLightVector = LightVectorProvider.SphereVector;
                Draw();
            }
        }

        private void ObjectColorRadioButtonTexture_CheckedChanged(object sender, EventArgs e)
        {
            if (ObjectColorRadioButtonTexture.Checked)
            {
                foreach (var filler in fillers)
                    filler.GetObjectColor = ObjectColorProvider.TextureColor;
                Draw();
            }
        }

        private void ObjectColorRadioButtonConstant_CheckedChanged(object sender, EventArgs e)
        {
            if (ObjectColorRadioButtonConstant.Checked)
            {
                foreach (var filler in fillers)
                    filler.GetObjectColor = ObjectColorProvider.ConstantColor;
                Draw();
            }
        }
        
        private void LightColorImage_BackColorChanged(object sender, EventArgs e)
        {
            config.LightColor = (sender as PictureBox).BackColor;
            Draw();
        }

        private void ObjectColorImage_BackColorChanged(object sender, EventArgs e)
        {
            config.ObjectColor = (sender as PictureBox).BackColor;
            Draw();
        }

        private void ObjectTextureImage_BackgroundImageChanged(object sender, EventArgs e)
        {
            config.ObjectTexture = (sender as PictureBox).BackgroundImage as Bitmap;
            (sender as PictureBox).Image = (sender as PictureBox).BackgroundImage;
            Draw();
        }

        private void NormalMapImage_BackgroundImageChanged(object sender, EventArgs e)
        {
            config.NormalMapTexture = (sender as PictureBox).BackgroundImage as Bitmap;
            (sender as PictureBox).Image = (sender as PictureBox).BackgroundImage;
            Draw();
        }

        private void HeightMapImage_BackgroundImageChanged(object sender, EventArgs e)
        {
            config.HeightMapTexture = (sender as PictureBox).BackgroundImage as Bitmap;
            (sender as PictureBox).Image = (sender as PictureBox).BackgroundImage;
            Draw();
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
    }
}

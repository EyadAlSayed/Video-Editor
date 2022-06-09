using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiMedia_HW2.dialogs.waterMarks
{
    public partial class ImageWaterMarks : Form
    {
        public Bitmap Image { get; set; }
        public float Opacity { get; set; }
        string fileName;
            
        public ImageWaterMarks()
        {
            InitializeComponent();
            pic.Image = new Bitmap("..\\..\\tmp_bg.png");
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "*.PNG|*.PNG";
            if (op.ShowDialog() == DialogResult.OK)
            {
                fileName = op.FileName;
                pathTextBox.Text = op.FileName;

                Image = new Bitmap(fileName);
                Opacity = float.Parse(opacityBar.Value.ToString()) / 10;
                DisplayImage();
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                Image = new Bitmap(fileName);
                
                Opacity = float.Parse(opacityBar.Value.ToString()) / 10;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            Close();
        }


        private void DisplayImage()
        {
            pic.Image = new Bitmap("..\\..\\tmp_bg.png");

            ColorMatrix colorMatrix = new ColorMatrix();
            colorMatrix.Matrix33 = Opacity;
            ImageAttributes imgAttr = new ImageAttributes();
            imgAttr.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Rectangle rect = new Rectangle(10, 10, 250, 250);
            Image img = pic.Image;

            using (Graphics graphics = Graphics.FromImage(img))
            {

                graphics.DrawImage(Image, rect, 0, 0, Image.Width, Image.Height, GraphicsUnit.Pixel, imgAttr);

            }
            pic.Image = img;
        }

        private void opacityBar_Scroll(object sender, EventArgs e)
        {
            Opacity = float.Parse(opacityBar.Value.ToString()) / 10;
            DisplayImage();
        }
    }
}

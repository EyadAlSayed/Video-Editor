using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiMedia_HW2.dialogs.tools
{
    public partial class CreateVideoDialog : Form
    {
        public List<Bitmap> Images { get; set; }

        public CreateVideoDialog()
        {
            InitializeComponent();
            Images = new List<Bitmap>();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = true;
            op.Filter = "*.JPG;*.PNG;*.GIF;*.JPEG|*.JPG;*.PNG;*.GIF;*.JPEG";

            if (op.ShowDialog() == DialogResult.OK)
            {
                string[] paths = op.FileNames;
                foreach (string path in paths)
                {
                    Images.Add(new Bitmap(Image.FromFile(path),new Size(1080,720)));

                }
                ImageList il = new ImageList();
                il.ImageSize = new Size(80, 80);
                for (int i = 0; i < Images.Count; i++)
                {
                    il.Images.Add(Images[i]);

                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageIndex = i;
                    PictureBox p = new PictureBox();
                    p.Width = 80;
                    p.Height = 80;
                    p.Image = il.Images[i];
                    p.Left = (p.Width + 5) * i;
                    pImages.Controls.Add(p);

                }


            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

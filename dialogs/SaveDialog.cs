using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiMedia_HW2.dialogs
{
    public partial class SaveDialog : Form
    {
        public SaveDialog()
        {
            InitializeComponent();
        }


        public string FileName { get; set; }
        public int FrameRate { get; set; }
        public int VideoWidth { get; set; }
        public int VideoHeight { get; set; }
        public string AudioPath { get; set; }
        public bool HasAudio { get; set; }
        public SaveDialog(int Fps, int videoWidth, int videoHeight)
        {
            InitializeComponent();

            fbsTextBox.Text = Fps.ToString();
            widthTextBox.Text = videoWidth.ToString();
            heightTextBox.Text = videoHeight.ToString();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "*.MP4|*.MP4";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                FileName = sv.FileName;
                fileTextBox.Text = FileName;
            }

        }

        private void audioBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                AudioPath = op.FileName;
                HasAudio = audioCheckBox.Checked;
                audioTextBox.Text = AudioPath;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            VideoWidth = int.Parse(widthTextBox.Text);
            VideoHeight = int.Parse(heightTextBox.Text);
            FrameRate = int.Parse(fbsTextBox.Text);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void audioCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (audioCheckBox.Checked == true)
            {
                audioBrowse.Enabled = true;
                audioTextBox.Enabled = true;
            }
            else
            {
                audioBrowse.Enabled = false;
                audioTextBox.Enabled = false;
            }
        }
    }
}

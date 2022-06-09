using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiMedia_HW2.dialogs.waterMarks
{
    public partial class TextWaterMarks : Form
    {



        public string WaterMarkText { get; set; }
        public Font WaterMarkFont { get; set; }
        public Brush Brush { get; set; }
        public Point Position { get; set; }


        public TextWaterMarks()
        {
            InitializeComponent();
    

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {

                OkButton.Enabled = true;

                if (textBox.Text.Length != 0)
                {
                    WaterMarkText = textBox.Text;
                    WaterMarkFont = fd.Font;
                    Brush = new SolidBrush(Color.FromArgb(opacityBar.Value, fd.Color));

                    reviewText.Text = WaterMarkText;
                    reviewText.Font = WaterMarkFont;
                    reviewText.ForeColor = Color.FromArgb(opacityBar.Value, fd.Color);
                }
            }
        }

        private void opacityBar_Scroll(object sender, EventArgs e)
        {
            opacityValue.Text = opacityBar.Value.ToString();
            reviewText.ForeColor = Color.FromArgb(opacityBar.Value, reviewText.ForeColor);
        }
    }
}

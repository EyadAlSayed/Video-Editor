using System;
using Accord.Math;
using Accord.Video.FFMPEG;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Diagnostics;
using MultiMedia_HW2.dialogs.waterMarks;
using MultiMedia_HW2.dialogs;
using MultiMedia_HW2.dialogs.tools;

namespace MultiMedia_HW2
{
    public partial class Form1 : Form
    {

        int frameIdx, timer;
        int width, height, bitRate;

        long frameCount;

        Rational fps;

        double scale;

        string videoPath;

        List<Bitmap> bitmaps;

        bool isPlaying;

        public Form1()
        {
            InitializeComponent();

            loadProg.Visible = false;
            bitmaps = new List<Bitmap>();
            fps = 30;
            scale = 1;
            frameIdx = 0;
            timer = 0;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "*.MP4|*.MP4";

            if (op.ShowDialog() == DialogResult.OK)
            {
                videoPath = op.FileName;
                OpenVideo();
            }
        }

        private void skipfButton_Click(object sender, EventArgs e)
        {
            frameIdx = frameIdx + (2 * (int)fps);
            if (frameIdx > bitmaps.Count) frameIdx = bitmaps.Count - 1;
        }

        private void skipbButton_Click(object sender, EventArgs e)
        {
            frameIdx = frameIdx - (2 * (int)fps);
            if (frameIdx < 0) frameIdx = 0;
        }

        private void speeduButton_Click(object sender, EventArgs e)
        {
            if (scale > 0)
                scale -= 0.25;
        }

        private void speeddButton_Click(object sender, EventArgs e)
        {
            if (scale < 2)
                scale += 0.25;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveVideo();
        }

        private void SaveVideo()
        {
            SaveDialog sv = new SaveDialog((int)fps, width, height);
            if (sv.ShowDialog() == DialogResult.OK)
            {
                VideoFileWriter writer = new VideoFileWriter();
                if (sv.HasAudio)
                    writer.Open("..\\..\\tmp\\temp.Mp4", sv.VideoWidth, sv.VideoHeight, sv.FrameRate, VideoCodec.H264, bitRate);
                else
                    writer.Open(sv.FileName, sv.VideoWidth, sv.VideoHeight, sv.FrameRate, VideoCodec.H264, bitRate);

                loadProg.Visible = true;
                loadProg.Value = 0;
                loadProg.Maximum = bitmaps.Count;

                for (int i = 0; i < bitmaps.Count; i++)
                {
                    loadProg.Value = i;
                    writer.WriteVideoFrame(bitmaps[i]);
                }
                writer.Close();

                if (sv.HasAudio)
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();

                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg.exe");
                    startInfo.Arguments = string.Format("-i ..\\..\\tmp\\temp.mp4 -i {0} -map 0:v -map 1:a -c:v copy -shortest {1}", sv.AudioPath, sv.FileName);
                    startInfo.RedirectStandardOutput = true;


                    try
                    {
                        loadProg.Value = 0;
                        loadProg.Maximum = bitmaps.Count;
                        int i = 0;
                        using (Process process = Process.Start(startInfo))
                        {
                            while (!process.StandardOutput.EndOfStream)
                            {
                                string line = process.StandardOutput.ReadLine();

                                loadProg.Value = i;
                            }

                            process.WaitForExit();

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    if (File.Exists("..\\..\\tmp\\temp.Mp4"))
                        File.Delete("..\\..\\tmp\\temp.Mp4");
                }
                loadProg.Visible = false;
            }



        }

        private void wTextButton_Click(object sender, EventArgs e)
        {
            TextWaterMarks frm = new TextWaterMarks();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Point location = new Point(10, 10);

                loadProg.Value = 0;
                loadProg.Minimum = 0;
                loadProg.Maximum = bitmaps.Count;
                loadProg.Visible = true;

                for (int i = 0; i < bitmaps.Count; i++)
                {
                    using (Graphics graphics = Graphics.FromImage(bitmaps[i]))
                    {
                        graphics.DrawString(frm.WaterMarkText, frm.WaterMarkFont, frm.Brush, location);
                        loadProg.Value = i;
                    }
                }
                loadProg.Visible = false;
                FormRefresh();
            }
        }

        private void wImageButton_Click(object sender, EventArgs e)
        {
            ImageWaterMarks frm = new ImageWaterMarks();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                loadProg.Value = 0;
                loadProg.Minimum = 0;
                loadProg.Maximum = bitmaps.Count;
                loadProg.Visible = true;

                ColorMatrix colorMatrix = new ColorMatrix();
                colorMatrix.Matrix33 = frm.Opacity;
                ImageAttributes imgAttr = new ImageAttributes();
                imgAttr.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                Rectangle rect = new Rectangle(100,100, 250, 250);

                for (int i = 0; i < bitmaps.Count; i++)
                {
                    using (Graphics graphics = Graphics.FromImage(bitmaps[i]))
                    {

                        graphics.DrawImage(frm.Image, rect, 0, 0, frm.Image.Width, frm.Image.Height, GraphicsUnit.Pixel, imgAttr);

                        loadProg.Value = i;
                    }
                }
                FormRefresh();
                loadProg.Visible = false;
            }
        }

        private void wVideoButton_Click(object sender, EventArgs e)
        {
            loadProg.Value = 0;
            loadProg.Minimum = 0;
            loadProg.Maximum = bitmaps.Count;
            loadProg.Visible = true;

            Rectangle rect = new Rectangle(10, 10, 250, 250);

            for (int i = 0; i < bitmaps.Count; i++)
            {
                using (Graphics graphics = Graphics.FromImage(bitmaps[i]))
                {

                    graphics.DrawImage(bitmaps[i], rect);

                    loadProg.Value = i;
                }
            }
            loadProg.Visible = false;

            FormRefresh();
        }

        private void FormRefresh()
        {
            frameIdx = 0;
            videoTime.Text = TimeSpan.FromSeconds(0).ToString(@"mm\:ss") + "  /  "
       + (TimeSpan.FromSeconds(frameCount / (int)fps).ToString(@"mm\:ss"));
            pFrames.Controls.Clear();
            this.Refresh();
            DisplayFrames();
        }

        private void tCutButton_Click(object sender, EventArgs e)
        {
            CutVideoDialog frm = new CutVideoDialog((int)(frameCount / (int)fps));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int min = (int)(frm.Min * fps);
                int max = (frm.Max * (int)fps);

                if (frm.IsIn)
                {
                    Bitmap bm = bitmaps[max];
                    bitmaps.RemoveRange(0, min);
                    bitmaps.RemoveRange(bitmaps.IndexOf(bm), (bitmaps.Count - bitmaps.IndexOf(bm)));
                }
                else
                {
                    int count = max - min;
                    bitmaps.RemoveRange(min, count);
                }

                frameCount = bitmaps.Count;
                FormRefresh();
            }
        }

        private void tEditButton_Click(object sender, EventArgs e)
        {
            EditDialog frm = new EditDialog((int)(frameCount / (int)fps));
            if (frm.ShowDialog() == DialogResult.OK)
            {

                List<Bitmap> tmp = new List<Bitmap>();
                for (int i = frm.Min * (int)fps; i < frm.Max * (int)fps; i++)
                {
                    tmp.Add(bitmaps[frm.Min * (int)fps]);
                    bitmaps.RemoveAt(frm.Min * (int)fps);
                }

                if (frm.After * fps > bitmaps.Count)
                    bitmaps.AddRange(tmp);
                else bitmaps.InsertRange(frm.After * (int)fps, tmp);


                tmp.Clear();

                pFrames.Controls.Clear();
                DisplayFrames();

            }
        }

        private void tCreateButton_Click(object sender, EventArgs e)
        {
            CreateVideoDialog frm = new CreateVideoDialog();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                List<Bitmap> tmp = frm.Images;

                loadProg.Visible = true;
                loadProg.Value = 0;
                loadProg.Maximum = (int)fps;
                bitmaps.Clear();

                foreach (Bitmap bmp in tmp)
                {
                    for (int i = 0; i < fps; i++)
                    {

                        bitmaps.Add(bmp);
                    }
                    loadProg.Value++;
                }

                frameCount = (int)fps * tmp.Count;

                tmp.Clear();

                pFrames.Controls.Clear();
                FormRefresh();

                loadProg.Visible = false;
                loadProg.Value = 0;

            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            videoProg.Maximum = (int)frameCount / (int)fps;
            videoProg.Minimum = 0;

            if (isPlaying)
            {
                playButton.Text = "Play";
                isPlaying = false;

            }
            else
            {
                playButton.Text = "pause";
                isPlaying = true;
                PlayVideo();
            }
        }

        private void OpenVideo()
        {

            bitmaps.Clear();

            VideoFileReader reader = new VideoFileReader();

            reader.Open(videoPath);

            frameCount = reader.FrameCount;
            fps = (int)reader.FrameRate;
            bitRate = reader.BitRate;

            width = reader.Width;
            height = reader.Height;

            loadProg.Visible = true;
            loadProg.Maximum = (int)reader.FrameCount;
            Bitmap bmp;
            for (int i = 0; i < reader.FrameCount; i++)
            {

                bmp = reader.ReadVideoFrame();
                loadProg.Value = i;
                bitmaps.Add(bmp);

            }


            reader.Close();

            pic.Image = bitmaps[0];

            DisplayFrames();
            loadProg.Visible = false;

        }


         private void DisplayFrames()
        {
            pFrames.Controls.Clear();

            loadProg.Visible = true;
            loadProg.Minimum = 0;
            loadProg.Maximum = bitmaps.Count;

            ImageList il = new ImageList();
            il.ImageSize = new Size(75, 75);

            for (int i = 0; i < bitmaps.Count; i++)
            {
                loadProg.Value = i;
                il.Images.Add(bitmaps[i]);
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                PictureBox p = new PictureBox();
                p.Width = 80;
                p.Height = 80;
                p.Image = il.Images[i];
                p.Left = (p.Width + 5) * i;
                pFrames.Controls.Add(p);
            }

            loadProg.Visible = false;
            pic.Image = bitmaps[0];
        }

        private async void PlayVideo()
        {
            while (isPlaying && frameIdx < bitmaps.Count)
            {
                videoProg.Value = frameIdx / (int)fps;

                pic.Image = bitmaps[frameIdx];

                if (timer == fps)
                {

                    videoTime.Text = TimeSpan.FromSeconds(frameIdx / (int)fps).ToString(@"mm\:ss") + "  /  "
                                 + (TimeSpan.FromSeconds(frameCount / (int)fps).ToString(@"mm\:ss"));

                    timer = 0;

                }
                else
                {
                    timer++;
                }
                await Task.Delay((int)(1000 / ((int)fps / scale)));


                frameIdx = (frameIdx + 1);


            }
            if (videoProg.Value < frameIdx / (int)fps)
            {
                videoProg.Value = frameIdx / (int)fps;
            }

            videoTime.Text = TimeSpan.FromSeconds(frameIdx / (int)fps).ToString(@"mm\:ss") + "  /  "
           + (TimeSpan.FromSeconds(frameCount / (int)fps).ToString(@"mm\:ss"));

            if (frameIdx == bitmaps.Count)
            {
                frameIdx = 0;
                isPlaying = false;
                playButton.Text = "Play";
            }

        }
    }
}

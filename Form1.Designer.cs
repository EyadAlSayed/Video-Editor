
namespace MultiMedia_HW2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wVideoButton = new System.Windows.Forms.Button();
            this.wImageButton = new System.Windows.Forms.Button();
            this.wTextButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tEditButton = new System.Windows.Forms.Button();
            this.tCutButton = new System.Windows.Forms.Button();
            this.tCreateButton = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.skipfButton = new System.Windows.Forms.Button();
            this.skipbButton = new System.Windows.Forms.Button();
            this.speeduButton = new System.Windows.Forms.Button();
            this.speeddButton = new System.Windows.Forms.Button();
            this.videoTime = new System.Windows.Forms.Label();
            this.pFrames = new System.Windows.Forms.Panel();
            this.videoProg = new System.Windows.Forms.ProgressBar();
            this.loadProg = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(1017, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(151, 40);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1017, 58);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(151, 40);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wVideoButton);
            this.groupBox1.Controls.Add(this.wImageButton);
            this.groupBox1.Controls.Add(this.wTextButton);
            this.groupBox1.Location = new System.Drawing.Point(992, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 165);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Water Marks";
            // 
            // wVideoButton
            // 
            this.wVideoButton.Location = new System.Drawing.Point(27, 111);
            this.wVideoButton.Name = "wVideoButton";
            this.wVideoButton.Size = new System.Drawing.Size(151, 40);
            this.wVideoButton.TabIndex = 5;
            this.wVideoButton.Text = "Video";
            this.wVideoButton.UseVisualStyleBackColor = true;
            this.wVideoButton.Click += new System.EventHandler(this.wVideoButton_Click);
            // 
            // wImageButton
            // 
            this.wImageButton.Location = new System.Drawing.Point(27, 65);
            this.wImageButton.Name = "wImageButton";
            this.wImageButton.Size = new System.Drawing.Size(151, 40);
            this.wImageButton.TabIndex = 4;
            this.wImageButton.Text = "Image";
            this.wImageButton.UseVisualStyleBackColor = true;
            this.wImageButton.Click += new System.EventHandler(this.wImageButton_Click);
            // 
            // wTextButton
            // 
            this.wTextButton.Location = new System.Drawing.Point(27, 23);
            this.wTextButton.Name = "wTextButton";
            this.wTextButton.Size = new System.Drawing.Size(151, 40);
            this.wTextButton.TabIndex = 2;
            this.wTextButton.Text = "Text";
            this.wTextButton.UseVisualStyleBackColor = true;
            this.wTextButton.Click += new System.EventHandler(this.wTextButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tEditButton);
            this.groupBox2.Controls.Add(this.tCutButton);
            this.groupBox2.Controls.Add(this.tCreateButton);
            this.groupBox2.Location = new System.Drawing.Point(992, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 168);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tools";
            // 
            // tEditButton
            // 
            this.tEditButton.Location = new System.Drawing.Point(25, 118);
            this.tEditButton.Name = "tEditButton";
            this.tEditButton.Size = new System.Drawing.Size(151, 40);
            this.tEditButton.TabIndex = 5;
            this.tEditButton.Text = "Edit";
            this.tEditButton.UseVisualStyleBackColor = true;
            this.tEditButton.Click += new System.EventHandler(this.tEditButton_Click);
            // 
            // tCutButton
            // 
            this.tCutButton.Location = new System.Drawing.Point(25, 72);
            this.tCutButton.Name = "tCutButton";
            this.tCutButton.Size = new System.Drawing.Size(151, 40);
            this.tCutButton.TabIndex = 4;
            this.tCutButton.Text = "Cut";
            this.tCutButton.UseVisualStyleBackColor = true;
            this.tCutButton.Click += new System.EventHandler(this.tCutButton_Click);
            // 
            // tCreateButton
            // 
            this.tCreateButton.Location = new System.Drawing.Point(25, 30);
            this.tCreateButton.Name = "tCreateButton";
            this.tCreateButton.Size = new System.Drawing.Size(151, 40);
            this.tCreateButton.TabIndex = 3;
            this.tCreateButton.Text = "Create";
            this.tCreateButton.UseVisualStyleBackColor = true;
            this.tCreateButton.Click += new System.EventHandler(this.tCreateButton_Click);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(216, 80);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(609, 342);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 4;
            this.pic.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(1017, 473);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(151, 40);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // skipfButton
            // 
            this.skipfButton.Location = new System.Drawing.Point(1106, 516);
            this.skipfButton.Name = "skipfButton";
            this.skipfButton.Size = new System.Drawing.Size(77, 40);
            this.skipfButton.TabIndex = 6;
            this.skipfButton.Text = "Skip >>";
            this.skipfButton.UseVisualStyleBackColor = true;
            this.skipfButton.Click += new System.EventHandler(this.skipfButton_Click);
            // 
            // skipbButton
            // 
            this.skipbButton.Location = new System.Drawing.Point(1002, 516);
            this.skipbButton.Name = "skipbButton";
            this.skipbButton.Size = new System.Drawing.Size(77, 40);
            this.skipbButton.TabIndex = 7;
            this.skipbButton.Text = "<< Skip";
            this.skipbButton.UseVisualStyleBackColor = true;
            this.skipbButton.Click += new System.EventHandler(this.skipbButton_Click);
            // 
            // speeduButton
            // 
            this.speeduButton.Location = new System.Drawing.Point(1106, 562);
            this.speeduButton.Name = "speeduButton";
            this.speeduButton.Size = new System.Drawing.Size(77, 40);
            this.speeduButton.TabIndex = 8;
            this.speeduButton.Text = "Speed U";
            this.speeduButton.UseVisualStyleBackColor = true;
            this.speeduButton.Click += new System.EventHandler(this.speeduButton_Click);
            // 
            // speeddButton
            // 
            this.speeddButton.Location = new System.Drawing.Point(1002, 562);
            this.speeddButton.Name = "speeddButton";
            this.speeddButton.Size = new System.Drawing.Size(77, 40);
            this.speeddButton.TabIndex = 9;
            this.speeddButton.Text = "Speed D";
            this.speeddButton.UseVisualStyleBackColor = true;
            this.speeddButton.Click += new System.EventHandler(this.speeddButton_Click);
            // 
            // videoTime
            // 
            this.videoTime.AutoSize = true;
            this.videoTime.Location = new System.Drawing.Point(887, 539);
            this.videoTime.Name = "videoTime";
            this.videoTime.Size = new System.Drawing.Size(45, 17);
            this.videoTime.TabIndex = 10;
            this.videoTime.Text = "00:00";
            // 
            // pFrames
            // 
            this.pFrames.AutoScroll = true;
            this.pFrames.Location = new System.Drawing.Point(12, 577);
            this.pFrames.Name = "pFrames";
            this.pFrames.Size = new System.Drawing.Size(971, 100);
            this.pFrames.TabIndex = 11;
            // 
            // videoProg
            // 
            this.videoProg.Location = new System.Drawing.Point(12, 562);
            this.videoProg.Name = "videoProg";
            this.videoProg.Size = new System.Drawing.Size(970, 8);
            this.videoProg.TabIndex = 0;
            // 
            // loadProg
            // 
            this.loadProg.Location = new System.Drawing.Point(12, 683);
            this.loadProg.Name = "loadProg";
            this.loadProg.Size = new System.Drawing.Size(971, 20);
            this.loadProg.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 707);
            this.Controls.Add(this.loadProg);
            this.Controls.Add(this.videoProg);
            this.Controls.Add(this.pFrames);
            this.Controls.Add(this.videoTime);
            this.Controls.Add(this.speeddButton);
            this.Controls.Add(this.speeduButton);
            this.Controls.Add(this.skipbButton);
            this.Controls.Add(this.skipfButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Name = "Form1";
            this.Text = "HM2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button wVideoButton;
        private System.Windows.Forms.Button wImageButton;
        private System.Windows.Forms.Button wTextButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button tEditButton;
        private System.Windows.Forms.Button tCutButton;
        private System.Windows.Forms.Button tCreateButton;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button skipfButton;
        private System.Windows.Forms.Button skipbButton;
        private System.Windows.Forms.Button speeduButton;
        private System.Windows.Forms.Button speeddButton;
        private System.Windows.Forms.Label videoTime;
        private System.Windows.Forms.Panel pFrames;
        private System.Windows.Forms.ProgressBar videoProg;
        private System.Windows.Forms.ProgressBar loadProg;
    }
}


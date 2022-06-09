
namespace MultiMedia_HW2.dialogs
{
    partial class SaveDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.audioCheckBox = new System.Windows.Forms.CheckBox();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fbsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.audioTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.audioBrowse = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(523, 20);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 33);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // audioCheckBox
            // 
            this.audioCheckBox.AutoSize = true;
            this.audioCheckBox.Location = new System.Drawing.Point(523, 148);
            this.audioCheckBox.Name = "audioCheckBox";
            this.audioCheckBox.Size = new System.Drawing.Size(64, 21);
            this.audioCheckBox.TabIndex = 2;
            this.audioCheckBox.Text = "Audio";
            this.audioCheckBox.UseVisualStyleBackColor = true;
            this.audioCheckBox.CheckedChanged += new System.EventHandler(this.audioCheckBox_CheckedChanged);
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(82, 20);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(416, 24);
            this.fileTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(111, 102);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(72, 24);
            this.widthTextBox.TabIndex = 5;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(267, 102);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(72, 24);
            this.heightTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Height";
            // 
            // fbsTextBox
            // 
            this.fbsTextBox.Location = new System.Drawing.Point(412, 98);
            this.fbsTextBox.Name = "fbsTextBox";
            this.fbsTextBox.Size = new System.Drawing.Size(72, 24);
            this.fbsTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "FBS";
            // 
            // audioTextBox
            // 
            this.audioTextBox.Enabled = false;
            this.audioTextBox.Location = new System.Drawing.Point(93, 187);
            this.audioTextBox.Name = "audioTextBox";
            this.audioTextBox.Size = new System.Drawing.Size(416, 24);
            this.audioTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Audio Path";
            // 
            // audioBrowse
            // 
            this.audioBrowse.Enabled = false;
            this.audioBrowse.Location = new System.Drawing.Point(523, 182);
            this.audioBrowse.Name = "audioBrowse";
            this.audioBrowse.Size = new System.Drawing.Size(75, 33);
            this.audioBrowse.TabIndex = 12;
            this.audioBrowse.Text = "Browse";
            this.audioBrowse.UseVisualStyleBackColor = true;
            this.audioBrowse.Click += new System.EventHandler(this.audioBrowse_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(204, 236);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 33);
            this.okButton.TabIndex = 13;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(342, 236);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 33);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SaveDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 281);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.audioBrowse);
            this.Controls.Add(this.audioTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fbsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.audioCheckBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.label1);
            this.Name = "SaveDialog";
            this.Text = "SaveDailog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.CheckBox audioCheckBox;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fbsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox audioTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button audioBrowse;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
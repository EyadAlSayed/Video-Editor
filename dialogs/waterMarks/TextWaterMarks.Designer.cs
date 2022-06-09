
namespace MultiMedia_HW2.dialogs.waterMarks
{
    partial class TextWaterMarks
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.fontButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reviewText = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.opacityBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.opacityValue = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(78, 25);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(324, 24);
            this.textBox.TabIndex = 1;
            // 
            // fontButton
            // 
            this.fontButton.Location = new System.Drawing.Point(425, 25);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(75, 26);
            this.fontButton.TabIndex = 2;
            this.fontButton.Text = "Font";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reviewText);
            this.groupBox1.Location = new System.Drawing.Point(78, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 249);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Review";
            // 
            // reviewText
            // 
            this.reviewText.AutoSize = true;
            this.reviewText.Location = new System.Drawing.Point(24, 45);
            this.reviewText.Name = "reviewText";
            this.reviewText.Size = new System.Drawing.Size(36, 17);
            this.reviewText.TabIndex = 1;
            this.reviewText.Text = "Text";
            // 
            // OkButton
            // 
            this.OkButton.Enabled = false;
            this.OkButton.Location = new System.Drawing.Point(118, 388);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 26);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(284, 388);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 26);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // opacityBar
            // 
            this.opacityBar.Location = new System.Drawing.Point(89, 62);
            this.opacityBar.Maximum = 255;
            this.opacityBar.Name = "opacityBar";
            this.opacityBar.Size = new System.Drawing.Size(313, 56);
            this.opacityBar.TabIndex = 1;
            this.opacityBar.Value = 255;
            this.opacityBar.Scroll += new System.EventHandler(this.opacityBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Opacity";
            // 
            // opacityValue
            // 
            this.opacityValue.AutoSize = true;
            this.opacityValue.Location = new System.Drawing.Point(422, 73);
            this.opacityValue.Name = "opacityValue";
            this.opacityValue.Size = new System.Drawing.Size(32, 17);
            this.opacityValue.TabIndex = 7;
            this.opacityValue.Text = "255";
            // 
            // TextWaterMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.opacityValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.opacityBar);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fontButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Name = "TextWaterMarks";
            this.Text = "TextWaterMarks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label reviewText;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TrackBar opacityBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label opacityValue;
    }
}
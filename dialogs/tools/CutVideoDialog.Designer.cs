
namespace MultiMedia_HW2.dialogs.tools
{
    partial class CutVideoDialog
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.NumericUpDown();
            this.toTextBox = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outRadio = new System.Windows.Forms.RadioButton();
            this.inRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.fromTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toTextBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cut From";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(79, 285);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 34);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(217, 285);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 34);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cut to";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(119, 60);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(196, 24);
            this.fromTextBox.TabIndex = 8;
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(119, 132);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(196, 24);
            this.toTextBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outRadio);
            this.groupBox1.Controls.Add(this.inRadio);
            this.groupBox1.Location = new System.Drawing.Point(79, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 69);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // outRadio
            // 
            this.outRadio.AutoSize = true;
            this.outRadio.Location = new System.Drawing.Point(120, 32);
            this.outRadio.Name = "outRadio";
            this.outRadio.Size = new System.Drawing.Size(52, 21);
            this.outRadio.TabIndex = 9;
            this.outRadio.Text = "Out";
            this.outRadio.UseVisualStyleBackColor = true;
            // 
            // inRadio
            // 
            this.inRadio.AutoSize = true;
            this.inRadio.Checked = true;
            this.inRadio.Location = new System.Drawing.Point(21, 32);
            this.inRadio.Name = "inRadio";
            this.inRadio.Size = new System.Drawing.Size(41, 21);
            this.inRadio.TabIndex = 8;
            this.inRadio.TabStop = true;
            this.inRadio.Text = "In";
            this.inRadio.UseVisualStyleBackColor = true;
            // 
            // CutVideoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 340);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.Name = "CutVideoDialog";
            this.Text = "CutVideoDialog";
            ((System.ComponentModel.ISupportInitialize)(this.fromTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toTextBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown fromTextBox;
        private System.Windows.Forms.NumericUpDown toTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton outRadio;
        private System.Windows.Forms.RadioButton inRadio;
    }
}
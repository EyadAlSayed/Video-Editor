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
    public partial class EditDialog : Form
    {

        public int Min { get; set; }
        public int Max { get; set; }

        public int After { get; set; }

        private int length;
        public EditDialog(int length)
        {
            InitializeComponent();

            this.length = length;

            fromTextBox.Minimum = 0;
            fromTextBox.Maximum = length;

            toTextBox.Minimum = 0;
            toTextBox.Maximum = length;


            afterTextBox.Minimum = 0;
            afterTextBox.Maximum = length - 1;

        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            Min = int.Parse(toTextBox.Value.ToString());
            Max = int.Parse(fromTextBox.Value.ToString());
            After = int.Parse(afterTextBox.Value.ToString());


            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        public EditDialog()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Min = int.Parse(fromTextBox.Value.ToString());
            Max = int.Parse(toTextBox.Value.ToString());
            After = int.Parse(afterTextBox.Value.ToString());


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

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
    public partial class CutVideoDialog : Form
    {


        public int Min { get; set; }
        public int Max { get; set; }
        public bool IsIn { get; set; }
        public bool isOut { get; set; }

        private int length;


        public CutVideoDialog(int length)
        {
            InitializeComponent();

            this.length = length;

            fromTextBox.Minimum = 0;
            fromTextBox.Maximum = length;
            fromTextBox.Value = 0;

            toTextBox.Minimum = 0;
            toTextBox.Maximum = length;
            toTextBox.Value = length;
        }
     
        private void okButton_Click(object sender, EventArgs e)
        {
            Min = int.Parse(fromTextBox.Value.ToString());
            Max = int.Parse(toTextBox.Value.ToString());

            IsIn = inRadio.Checked;
            isOut = outRadio.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

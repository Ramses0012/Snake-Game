using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA5_Draft
{
    public partial class ChooseNumberOfApplesForm : Form
    {
        internal int numberOfApples;

        public ChooseNumberOfApplesForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            numberOfApples = (int)chooseNumberOfApplesUpDown.Value;
            this.Close();
        }

        private void chooseNumberOfApplesUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

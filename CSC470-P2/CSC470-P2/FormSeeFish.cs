using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC470_P2
{
    public partial class FormSeeFish : Form
    {
        public string _Option;  // Declare a global variable to hold the option that the user selects

        public FormSeeFish(int x)
        {
            InitializeComponent();

            if (x == 1)
            {
                pictureBox1.Image = Properties.Resources.Crappie;
            }
            else if (x == 2)
            {
                pictureBox1.Image = Properties.Resources.Perch;
            }
            else if (x == 3)
            {
                pictureBox1.Image = Properties.Resources.Walleye;
            }
        }

        private void FormSeeFish_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonThrowItBack_Click(object sender, EventArgs e)
        {
            _Option = "Throw It Back";
            this.DialogResult = DialogResult.OK;    // This button fulfills the request when clicked
            this.Close();
        }
    }
}

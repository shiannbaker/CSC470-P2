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
    }
}

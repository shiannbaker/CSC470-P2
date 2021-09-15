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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void buttonSeeFish_Click(object sender, EventArgs e)
        {
            DialogResult result;
            int FishToShow = 0;     // 1 for Crappie, 2 for Perch, 3 for Walleye

            if (radioButton1.Checked)
            {
                FishToShow = 1;
            }
            else if (radioButton2.Checked)
            {
                FishToShow = 2;
            }
            else if (radioButton3.Checked)
            {
                FishToShow = 3;
            }

            FormSeeFish seeFish = new FormSeeFish(FishToShow);
            result = seeFish.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
            else
            {

            }
        }
    }
}

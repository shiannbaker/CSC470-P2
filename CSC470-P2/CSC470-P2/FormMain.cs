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
                if (seeFish._Option.Equals("Throw It Back"))
                {
                    MessageBox.Show("Decision is to Throw it back.", "Decision Result");
                }
                else if (seeFish._Option.Equals("Keep It"))
                {
                    MessageBox.Show("Decision is to keep it.", "Decision Result");
                }
                else
                {
                    MessageBox.Show("Unknown Decision", "Error");
                }
            }
            else
            {
                MessageBox.Show("Decision canceled", "Decision Result");
            }
        }
    }
}

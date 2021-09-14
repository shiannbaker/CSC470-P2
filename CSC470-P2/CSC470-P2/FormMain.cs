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

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                FormSeeFish seeFish = new FormSeeFish(1);
                DialogResult result = seeFish.ShowDialog();
            }
            else if (radioButton2.Checked)
            {
                FormSeeFish seeFish = new FormSeeFish(2);
                DialogResult result = seeFish.ShowDialog();
            }
            else if (radioButton3.Checked)
            {
                FormSeeFish seeFish = new FormSeeFish(3);
                DialogResult result = seeFish.ShowDialog();
            }
        }

    }
}

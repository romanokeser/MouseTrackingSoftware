using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseTrackingV._0._4
{
    public partial class checkBox : Form
    {
        public checkBox()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DontShow = checkBox1_CheckedChanged.Checked;
            Properties.Settings.Default.Reset();
        }

        private void checkBox_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customDesign();
        }
        private void customDesign()
        {
            panelSubPanel1.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelSubPanel1.Visible == true)
                panelSubPanel1.Visible = true;
        }

        private void showSideMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            
            showSideMenu(panelSubPanel1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new RecordForm());
            //..
            //Some code
            //..
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new MyRecordsForm());
            //..
            //Some code
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //Some code
            //..
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelChild_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

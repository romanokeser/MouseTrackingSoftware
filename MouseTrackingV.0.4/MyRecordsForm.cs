using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MouseTrackingV._0._4
{
    public partial class MyRecordsForm : Form
    {
        private string selectedFile;
        //string fileName = Application.ExecutablePath;
        string path = Application.ExecutablePath;
        
        public MyRecordsForm()
        {
            InitializeComponent();
            listBoxAllRecords.Items.Clear();
            string[] files = Directory.GetFiles($"{Directory.GetCurrentDirectory()}/logdata");
            foreach (var file in files)
            {
                listBoxAllRecords.Items.Add(file);
            }
        }

        private void buttonCloseForm3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnalyseForm win2 = new AnalyseForm(selectedFile);
            win2.Show();
        }


        private void listBoxAllRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox file = (ListBox)sender;
            foreach(var selected in file.Items)
            {
                this.selectedFile = selected.ToString();
            }
        }

        private void MyRecordsForm_Load(object sender, EventArgs e)
        {

        }
    }
}

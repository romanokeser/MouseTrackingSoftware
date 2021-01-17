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
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace MouseTrackingV._0._4
{
    public partial class RecordForm : Form
    {
        public RecordForm()
        {
            InitializeComponent();
        }

        private static List<Point> coords = new List<Point>();
        private static Boolean record { get; set; }

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X, int Y);

        private static void recordData()
        {
            Point current_pos, prev_pos;
            prev_pos.X = 0;
            prev_pos.Y = 0;

            do
            {
                Thread.Sleep(500);
                if (GetCursorPos(out current_pos))
                {
                    if ((current_pos.X != prev_pos.X) || (current_pos.Y != prev_pos.Y))
                    {
                        Console.WriteLine("({0},{1})", current_pos.X, current_pos.Y);
                        coords.Add(current_pos);
                    }
                    prev_pos.X = current_pos.X;
                    prev_pos.Y = current_pos.Y;
                }

            } while (record);
        }

        static Thread t;
        private void button1_Click(object sender, EventArgs e)
        {
            if (labelRecName.Text == "")
            {
                MessageBox.Show("Give a name to the record!");

                return;
            }

            t = new Thread(new ThreadStart(recordData));        
            record = true;
            if (!t.IsAlive)
            {
                t.Start();
            }
            buttonRecord.Enabled = false;
            buttonStop.Enabled = true;  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            record = false;
            if (t.IsAlive)
            {
                t.Join();
            }

            // ** FIX: u datoteku ostaju prijasnje zapisane koordinate ako se nakon STOP rec ponovo START rec radi, nove koordinate se upisu u .txt tek kad se aplikacija ponovo upali

            //dodati opciju da korisnik upise ime snimanja a ne samo datum snimanja
            //name of rec: "pon 2021 marko snimanje", u apk se vidi tocno vrijeme pocetka i kraja snimanja

            //string datum = DateTime.Now.ToString("MM-dd-yyyy_H_mm_ss");

            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string recName = DateTime.Now.ToString("MM-dd-yyyy_H_mm_ss");
            if (labelRecName.Text != "")
            {
                recName = labelRecName.Text;
            }

            string path = appPath + @"\logdata\" + recName + ".txt";
            Console.WriteLine(path);
            Directory.CreateDirectory(appPath + @"\logdata\");
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(path))
            {
                foreach (Point line in coords)
                {
                    file.WriteLine(line.ToString());
                }
            }
            buttonRecord.Enabled = true;
            buttonStop.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
            scrResLabel.Text = ("Resolution: " +screenWidth + "x" + screenHeight);

            
        }

        
        private void labelRecName_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonLeftHand_CheckedChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DontShow)  //pozivanje forme DontShow -> !Properties
            {
                new checkBox().ShowDialog();
            }
        }
    }
}

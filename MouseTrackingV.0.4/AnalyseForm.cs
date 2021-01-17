using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MouseTrackingV._0._4
{
    public partial class AnalyseForm : Form
    {

        private string selectedFile;

        public AnalyseForm(string selectedFile)
        {
            this.selectedFile = selectedFile;
            InitializeComponent();
        }

        private void buttonCloseAnalyser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<Point> getAllPoints()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            string line;
            List<Point> listPoints = new List<Point>();
            System.IO.StreamReader file =
                new System.IO.StreamReader(selectedFile);

            
            while ((line = file.ReadLine()) != null)
            {
                try 
                {
                    string[] koordinate = line.Split(',');
                    Point p = new Point();
                    p.X = Int32.Parse(koordinate[0]);
                    p.Y = Int32.Parse(koordinate[1]);

                    listPoints.Add(p);
                }
                catch (Exception)   //if there's a space betwen coordinates in txt files it will throw an error
                {
                    MessageBox.Show("Error in reading a record file! Try other record.");
                }
            }

            file.Close();
            return listPoints;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            List<ColorManager> colorManagers = new List<ColorManager>();
            List<RectangleF> rectangles = new List<RectangleF>();
            List <Point> ListOfPoints = getAllPoints();
            int numberOfPoints = ListOfPoints.Count;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int widthStep = screenWidth / 32;
            int heightStep = screenHeight / 16;
            int currentWidthIndex = 1;
            int currentHeightIndex = 1;
            
            //print rectangles
            for (int i = 0; i < 32*16; i++)
            {
                //get the current position
                RectangleF rectangle = new RectangleF(currentWidthIndex * widthStep - widthStep,
                    currentHeightIndex * heightStep -heightStep, widthStep, heightStep);
                if (currentWidthIndex == 32)
                {
                    currentHeightIndex++;
                    currentWidthIndex = 1;
                }
                else
                {
                    currentWidthIndex++;
                }

                List<Point> pointsInRectangle = ListOfPoints.FindAll(p =>
                {
                    
                    if (p.X >= currentWidthIndex * widthStep - widthStep && p.X <= currentWidthIndex * widthStep && p.Y >= currentHeightIndex * heightStep - heightStep && p.Y <= currentHeightIndex * heightStep)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                });
                
                float alfa = pointsInRectangle.Count;
                System.Console.WriteLine("alfa " + alfa);
                SolidBrush sb = new SolidBrush(Color.FromArgb(pointsInRectangle.Count / numberOfPoints, 100, 0, 0));
                ColorManager cm = new ColorManager(rectangle, sb, pointsInRectangle);
                colorManagers.Add(cm);
            }
            foreach (ColorManager item in colorManagers)
            {
                //System.Console.WriteLine("2222");
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(163, 8, 8)), item.rectangleF);
            }
            //e.Graphics.FillRectangles(new SolidBrush(Color.Red), rectangles.ToArray());
        }

        private void AnalyseForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}

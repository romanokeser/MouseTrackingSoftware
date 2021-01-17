using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseTrackingV._0._4
{
    public class ColorManager
    {
        public RectangleF rectangleF { get; set; }
        public SolidBrush solidBrush { get; set; }
        public List<Point> pointsInRectangle { get; set; }
        public ColorManager(RectangleF r, SolidBrush s, List<Point> lp)
        {
            this.rectangleF = r;
            this.solidBrush = s;
            this.pointsInRectangle = lp;
        }
    }
}

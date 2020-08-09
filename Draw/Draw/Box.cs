using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    class Box
    {
        int x;
        int y;
        int width;
        int height;
        Bitmap canvas;
        

        public Box(int x, int y,int width,int height)
        {
          
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public void polydraw4(int red, int green, int blue, Point first, Point second, Point third, Point fouth,Graphics draw)
        {
            Point[] points = new Point[] { first, second, third, fouth };
            draw.FillPolygon(brush(red, green, blue), points);

        }

        public Brush brush(int red, int green, int blue)
        {
            return new SolidBrush(Color.FromArgb(red, green, blue));
        }

        public void DrawBox(PictureBox mainPictureBox, Graphics draw)
        {
            draw.FillRectangle(brush(115, 50, 14), x, 600 + y, width, height);
            polydraw4(176, 94, 26, new Point(x, 600 + y), new Point(x + 40, 585 + y), new Point(x + 90, 585 + y), new Point(x + 50, 600 + y), draw);
            polydraw4(94, 44, 8, new Point(x + 90, 585 + y), new Point(x + 90, 635 + y), new Point(x + 50, 650 + y), new Point(x + 50, 600 + y), draw);
        }




    }
}

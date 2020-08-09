using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        public Graphics draw;
        Bitmap canvas;
        int x = 0;
        int y = -50;
        int raincounter = 1;
        Random rand = new Random();
        List<Particle> rain = new List<Particle>();
        Box box;

        public Form1()
        {
            InitializeComponent();
            canvas = new Bitmap(mainPictureBox.Width, mainPictureBox.Height);
            draw = Graphics.FromImage(canvas);
            box = new Box(x, y, 50, 50);

        }
        public Brush brush(int red, int green, int blue)
        {
            return new SolidBrush(Color.FromArgb(red, green, blue));
        }

        void polydraw4(int red, int green, int blue, Point first, Point second, Point third, Point fouth)
        {
            Point[] points = new Point[] { first, second, third, fouth };
            draw.FillPolygon(brush(red,green,blue), points);

        }

       
        private void Form1_Shown(object sender, EventArgs e)
        {

            ////gfx.FillRectangle(Brushes.Red, 10, 10, 20, 20);
            ////gfx.DrawRectangle(Pens.Black, 54, 34, 10, 10);
            //draw.FillRectangle(brush(0, 0, 0), 0, 400, 750, 200);
            //draw.FillRectangle(brush(186,24,24), 50, 300, 400-100, 200);
            ////draw.FillRectangle(brush(133,5,5), 350, 300, 100, 200);
            ////////////////////////////////////////////////////////////second part of the house
            //Point[] second = new Point[4];
            //second[0] = new Point(350, 300);
            //second[1] = new Point(450, 275);
            //second[2] = new Point(450,475);
            //second[3] = new Point(350, 500);

            //draw.FillPolygon(brush(133, 5, 5), second);
            ////////////////////////////////////////////////////////////window
            //draw.FillRectangle(Brushes.Blue, 75, 350, 50, 50);
            //draw.DrawLine(new Pen(Color.Black,5), 75, 375, 125, 375);
            //draw.DrawLine(new Pen(Color.Black, 5), 100, 350, 100, 400);

            ////////////////////////////////////////////////////////////window
            //draw.FillRectangle(Brushes.Blue, 375-100, 350, 50, 50);
            //draw.DrawLine(new Pen(Color.Black, 5), 375-100, 375, 425-100, 375);
            //draw.DrawLine(new Pen(Color.Black, 5), 400-100, 350, 400-100, 400);

            ////////////////////////////////////////////////////////////roof

            //Point[] roof = new Point[3];
            //roof[0] = new Point(250-25, 200);
            //roof[1] = new Point(450-100, 300);
            //roof[2] = new Point(50, 300);
            //draw.FillPolygon(brush(140,69,10),roof);

            ////////////////////////////////////////////////////////////roof
            //Point[] roof2 = new Point[4];
            //roof2[0] = new Point(250-25,200);
            //roof2[1] = new Point(312, 185);//175
            //roof2[2] = new Point(450, 275);
            //roof2[3] = new Point(350, 300);

            //draw.FillPolygon(brush(94,44,8), roof2);

            ////////////////////////////////////////////////////////////door
            //draw.FillRectangle(brush(255, 255, 255), 175, 350, 50, 150);
        }


        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            draw.Clear(Color.White);


            //////////////////////////////////////////////////////////////housep1
            draw.FillRectangle(brush(123, 164, 184), 0, 0, 1434, 861);
            draw.FillRectangle(brush(24, 110, 36), 0, 400, 1500, 500);
            polydraw4(20, 43, 5, new Point(450, 475), new Point(450, 475), new Point(450, 400), new Point(650, 400));

            draw.FillRectangle(brush(140, 24, 24), 50, 300, 400 - 100, 200);
            //draw.FillRectangle(brush(133,5,5), 350, 300, 100, 200);
            //////////////////////////////////////////////////////////second part of the house
            Point[] second = new Point[4];
            second[0] = new Point(350, 300);
            second[1] = new Point(450, 275);
            second[2] = new Point(450, 475);
            second[3] = new Point(350, 500);

            draw.FillPolygon(brush(107, 13, 13), second);
            //////////////////////////////////////////////////////////window
            draw.FillRectangle(Brushes.Blue, 75, 350, 50, 50);
            draw.DrawLine(new Pen(Color.Black, 5), 75, 375, 125, 375);
            draw.DrawLine(new Pen(Color.Black, 5), 100, 350, 100, 400);

            //////////////////////////////////////////////////////////window
            draw.FillRectangle(Brushes.Blue, 375 - 100, 350, 50, 50);
            draw.DrawLine(new Pen(Color.Black, 5), 375 - 100, 375, 425 - 100, 375);
            draw.DrawLine(new Pen(Color.Black, 5), 400 - 100, 350, 400 - 100, 400);

            //////////////////////////////////////////////////////////roof

            Point[] roof = new Point[3];
            roof[0] = new Point(250 - 25, 200);
            roof[1] = new Point(450 - 100, 300);
            roof[2] = new Point(50, 300);
            draw.FillPolygon(brush(140, 69, 10), roof);

            //////////////////////////////////////////////////////////roof
            Point[] roof2 = new Point[4];
            roof2[0] = new Point(250 - 25, 200);
            roof2[1] = new Point(312, 185);//175
            roof2[2] = new Point(450, 275);
            roof2[3] = new Point(350, 300);

            draw.FillPolygon(brush(94, 44, 8), roof2);

            //////////////////////////////////////////////////////////door
            draw.FillRectangle(brush(255, 255, 255), 175, 350, 50, 150);


            //////////////////////////////////////////////////////////box
            //+15
            //polydraw4(223, 232, 240, new Point(x + 75, 575), new Point(x + 50, 650), new Point(x + 75, 625), new Point(x + 50, 600));
            box.DrawBox(mainPictureBox,draw);

            //draw.FillRectangle(brush(115, 50,14), x, 600 + y, 50, 50);
            //polydraw4(176, 94, 26, new Point(x, 600 + y), new Point(x + 40, 585 + y), new Point(x + 90, 585 + y), new Point(x + 50, 600 + y));
            //polydraw4(94, 44, 8, new Point(x + 90, 585 + y), new Point(x + 90, 635 + y), new Point(x + 50, 650 + y), new Point(x + 50, 600 + y));

            ///////////////////////////////////////////////////////////////rain
            if (raincounter == -1)
            {
                for (int x = 0; x < 1600; x += 40)
                {
                    rain.Add(new Particle(rand.Next(x - 100, x + 100), 0));
                }

            }

            if (raincounter == 1)
            {
                for (int x = 10; x < 1600; x += 40)
                {
                    rain.Add(new Particle(rand.Next(x - 100, x + 100), 10));
                }

            }

            for (int i = 0; i < rain.Count; i++)
            {
                //if(i%2==0)
                rain[i].Particleupdate();
                if (rand.Next(1, 4) == 3 && rain[i].y > 400)
                {
                    rain.Remove(rain[i]);
                    draw.FillEllipse(brush(11, 23, 61), rain[i].x-2, rain[i].y-2, 5, 5);
                }
                if (rain[i].shouldelete() == true)
                {
                    rain.Remove(rain[i]);
                }
                //draw.FillRectangle(brush(11, 23, 61), rain[i].x, rain[i].y, 5, 5);
                draw.DrawLine(new Pen(brush(11, 23, 61)), rain[i].x, rain[i].y, rain[i].pastx, rain[i].pasty);
            }





            raincounter *= -1;
            mainPictureBox.Image = canvas;

        }

        private void left_Click(object sender, EventArgs e)
        {
            x -= 10;
        }

        private void right_Click(object sender, EventArgs e)
        {
            x += 10;
        }

        private void up_Click(object sender, EventArgs e)
        {
            if (y > -50)
            {
                y -= 10;
                x += 10;
            }
        }

        private void down_Click(object sender, EventArgs e)
        {
            y += 10;
            x -= 10;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'w')
            {
                if (y > -50 && x < 400 || y > -145 && x > 450 || y > -50 - x - 400 && x < 450 && x > 400)
                {
                    y -= 10;
                    x += 10;
                }
            }
            else if (e.KeyChar == 's')
            {

                y += 10;
                x -= 10;

            }
            else if (e.KeyChar == 'd')
            {
                x += 10;
            }
            else if (e.KeyChar == 'a')
            {
                if (x > 450 && y < -50 || x > 0 && y > -50)
                {
                    x -= 10;
                }
            }
        }
    }
}



